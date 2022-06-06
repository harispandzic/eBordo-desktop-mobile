﻿using AutoMapper;
using eBordo.Api.Database;
using eBordo.Api.Helpers;
using eBordo.Api.Services.BaseCRUDService;
using eBordo.Api.Services.BaseREADService;
using eBordo.Model.Exceptions;
using eBordo.Model.Helpers;
using eBordo.Model.Requests.Korisnik;
using eBordo.Model.Requests.Notifikacija;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace eBordo.Api.Services.Korisnik
{
    public class KorisnikService: IKorisnikService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly eBordoContext _db;
        private readonly IMapper _mapper;
        private Notifikacija.INotifikacijaService _notifikacijaService { get; set; }
        public KorisnikService(eBordoContext db, IMapper mapper, IHttpContextAccessor httpContext, Notifikacija.INotifikacijaService notifikacijaService)
        {
            _db = db;
            _mapper = mapper;
            _httpContext = httpContext;
            _notifikacijaService = notifikacijaService;
        }
        private PasswordGenerator passwordGenerator = new PasswordGenerator();
        public Model.Models.Korisnik Auth()
        {
            var user = _httpContext.GetUserId();

            var korisnik = _db.korisnici.Where(s => s.korisnickoIme == user)
                .Include(s => s.drzavljanstvo)
                .Include(s => s.gradRodjenja)
                .Include(s => s.gradRodjenja.drzava)
                .SingleOrDefault();
            
            if(korisnik != null)
            {
                return _mapper.Map< Model.Models.Korisnik>(korisnik);
            }
            return null;
        }
        public async Task<Model.Models.Korisnik> Login(string username, string password)
        {
            var entity = await _db.korisnici.FirstOrDefaultAsync(s => s.korisnickoIme == username);

            if (entity == null)
            {
                throw new Exception("Pogrešan username ili password");
            }

            var hash = passwordGenerator.GenerateHash(entity.lozinkaSalt, password);

            if (hash != entity.lozinkaHash)
            {
                throw new Exception("Pogrešan username ili password");
            }

            return _mapper.Map<Model.Models.Korisnik>(entity);
        }
        public Model.Models.Korisnik Insert(KorisnikInsertRequest request)
        {
            if (_db.korisnici.Count() != 0)
            {
                foreach (var item in _db.korisnici)
                {
                    if (item.ime.StartsWith(request.ime) && item.prezime.StartsWith(request.prezime))
                    {
                        throw new UserException("Korisnik postoji u bazi podataka!");
                    }
                }
            }
            
            string autoGeneratedPassword = passwordGenerator.GeneratePassword();
            string saltPassword = passwordGenerator.GenerateSalt();

            string inputMail = request.ime.ToLower() + "." + request.prezime.ToLower() + "@fksarajevo.ba";

            string decomposed = inputMail.Normalize(NormalizationForm.FormD);
            char[] filtered = decomposed
                .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray();

            string email = new String(filtered);

            email = email.Replace("đ", "dj");

            eBordo.Api.Database.Korisnik korisnik = new eBordo.Api.Database.Korisnik
            {
                ime = request.ime,
                prezime = request.prezime,
                datumRodjenja = request.datumRodjenja,
                adresa = request.adresa,
                telefon = request.telefon,
                email = request.email,
                korisnickoIme = email,
                lozinkaSalt = saltPassword,
                //lozinkaHash = passwordGenerator.GenerateHash(saltPassword,autoGeneratedPassword),
                Slika = request.Slika,
                lozinkaHash = passwordGenerator.GenerateHash(saltPassword, "Test1234!"),
                drzavljanstvoId = request.drzavljanstvoId,
                gradRodjenjaId = request.gradRodjenjaId,
                isAktivan = true
            };
    
            _db.Add(korisnik);
            _db.SaveChanges();

            SendLoginDataOnEmail(korisnik, autoGeneratedPassword);

            NotifikacijaInsertRequest notifikacijaInsertRequest = new NotifikacijaInsertRequest
            {
                korisnikId = korisnik.korisnikId,
                tekstNotifikacije = korisnik.ime + " " + korisnik.prezime + ", dobrodošao na eBordo platformu!",
                tipNotifikacije = "Uspješno"
            };

            _notifikacijaService.Insert(notifikacijaInsertRequest);

            return _mapper.Map<eBordo.Model.Models.Korisnik>(korisnik);
        }
        public async Task<Model.Models.Korisnik> ChangePassword(KorisnikChangePasswordRequest request)
        {
            var entity = await _db.korisnici.FirstOrDefaultAsync(s => s.korisnikId == request.korisnikId);

            if (entity == null)
            {
                throw new Exception("Pogrešan username ili password");
            }

            var hash = passwordGenerator.GenerateHash(entity.lozinkaSalt, request.oldPassword);

            if (hash != entity.lozinkaHash)
            {
                throw new Exception("Pogrešan username ili password");
            }
            string saltPassword = passwordGenerator.GenerateSalt();

            entity.lozinkaSalt = saltPassword;
            entity.lozinkaHash = passwordGenerator.GenerateHash(saltPassword, request.newPassword);

            _db.SaveChanges();

            return _mapper.Map<Model.Models.Korisnik>(entity);
        }
        public Model.Models.Korisnik Update(int id, KorisnikUpdateRequest request)
        {
            var korisnik = _db.korisnici.Find(id);

            korisnik.adresa = request.adresa;
            korisnik.email = request.email;
            korisnik.telefon = request.telefon;
            korisnik.isAktivan = request.isAktivan;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Korisnik>(korisnik);
        }
        public Model.Models.Korisnik Delete(int id)
        {
            var entity = _db.korisnici.Where(s => s.korisnikId == id).FirstOrDefault();

            entity.isAktivan = false;

            _db.SaveChanges();

            return _mapper.Map<eBordo.Model.Models.Korisnik>(entity);
        }
        private void SendLoginDataOnEmail(Database.Korisnik korisnik, string autogeneratedPassword)
        {
            string filePath = System.IO.Path.GetFullPath("Helpers/eBordoLoginPodaci.html");

            try
            {
                MailMessage mm = new MailMessage("eBordoApp@outlook.com", korisnik.email);
                mm.Subject = "Login podaci";
                mm.Body = string.Empty;
                using (var reader = new System.IO.StreamReader(filePath))
                {
                    mm.Body = reader.ReadToEnd();
                }
                mm.Body = mm.Body.Replace("{korisnik}", korisnik.ime + " " + korisnik.prezime);
                mm.Body = mm.Body.Replace("{username}", korisnik.korisnickoIme);
                mm.Body = mm.Body.Replace("{password}", autogeneratedPassword);
                mm.BodyEncoding = System.Text.Encoding.UTF8;
                mm.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential("eBordoApp@outlook.com", "7wzS*S9coLUv^sS");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                smtp.Send(mm);
            }
            catch (SmtpException ex)
            {
            }
        }
    }
}
