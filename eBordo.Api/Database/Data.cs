using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eBordo.Api.Database
{
    public class Data
    {
        public static void Seed(eBordoContext context,
            eBordo.Api.Services.Korisnik.IKorisnikService korisnik_service,
            eBordo.Api.Services.Igrac.IIgracService igrac_service,
            eBordo.Api.Services.Trener.ITrenerService trener_service,
            eBordo.Api.Services.Utakmica.IUtakmicaService utakmica_service,
            eBordo.Api.Services.Izvjestaj.IIzvjestajService izvjestaj_service,
            eBordo.Api.Services.Trening.ITreningService trening_service
            )
        {
            context.Database.Migrate();

            var webClient = new System.Net.WebClient();

            int count = context.korisnici.Select(x => x).ToList().Count();

            if (count == 0)
            {
                korisnik_service.Insert(new Model.Requests.Korisnik.KorisnikInsertRequest
                {
                    ime = "Haris",
                    prezime = "Pandžić",
                    datumRodjenja = System.DateTime.Parse("1997-10-03 10:27:31.0000000"),
                    adresa = "Koševo 1",
                    telefon = "38762209709",
                    email = "eBordoApp@outlook.com",
                    drzavljanstvoId = 1,
                    gradRodjenjaId = 1,
                    Slika = webClient.DownloadData("https://i.postimg.cc/xTfHNwZV/admin.png")
                });

                Database.Korisnik admin = context.korisnici.Where(s => s.korisnickoIme == "haris.pandzic@fksarajevo.ba").FirstOrDefault();

                admin.isAdmin = true;

                context.SaveChanges();

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Belmin",
                        prezime = "Dizdarević",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 9,
                        Slika = webClient.DownloadData("https://i.postimg.cc/sGXNhJ22/belmin-dizdarevic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 1,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 3,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 1,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/WFM2yTmZ/belmin-dizdarevic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Numan",
                        prezime = "Kurdić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 10,
                        Slika = webClient.DownloadData("https://i.postimg.cc/jwkhGYss/numan-kurdic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 2,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 27,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/4KpdD6sn/numan-kurdic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Muharem",
                        prezime = "Trako",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 9,
                        Slika = webClient.DownloadData("https://i.postimg.cc/sQ2c6gC6/muharem-trako.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 2,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 33,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/hXkvZyFH/muharem-trako.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Darko",
                        prezime = "Lazić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 7,
                        gradRodjenjaId = 11,
                        Slika = webClient.DownloadData("https://i.postimg.cc/qNnZyqp2/darko-lazic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 3,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 5,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/qhfJQzK0/darko-lazic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Amer",
                        prezime = "Dupovac",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/4K6qkdMX/amer-dupovac.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 3,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 29,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/HJFxK6fq/amer-dupovac.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Dino",
                        prezime = "Islamović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/p9HcZvd4/dino-islamovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 4,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 37,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/Lhpf8sbr/dino-islamovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Armin",
                        prezime = "Imamović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 3,
                        Slika = webClient.DownloadData("https://i.postimg.cc/hhywqNCQ/armin-imamovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 4,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 40,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/7fqLpGWZ/armin-imamovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Andrej",
                        prezime = "Đokanović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 12,
                        Slika = webClient.DownloadData("https://i.postimg.cc/9RcSW25Z/andrej-dokanovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 5,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 8,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/9wYQDCr2/andrej-djokanovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Kerim",
                        prezime = "Palić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/z3Btp0Jz/kerim-palic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 5,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 25,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/PC9vsfDV/kerim-palic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Tarik",
                        prezime = "Ramić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/XBGgW1J9/tarik-ramic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 6,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 14,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/TL9PwTy6/tarik-ramic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Dal",
                        prezime = "Varešanović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 14,
                        Slika = webClient.DownloadData("https://i.postimg.cc/mtPnZVqX/dal-varesanovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 6,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 17,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/DSZwzVFV/dal-varesanovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Muhamed",
                        prezime = "Šahinović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/bGpLnRCj/muhamed-sahinovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 1,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 36,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/75GbVvR3/muhamed-sahinovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Kenan",
                        prezime = "Dervišagić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 3,
                        Slika = webClient.DownloadData("https://i.postimg.cc/vxc0BHPg/kenan-dervisagic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 7,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 23,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/3yG4KMC8/kenan-dervisagic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Anel",
                        prezime = "Hebibović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 15,
                        Slika = webClient.DownloadData("https://i.postimg.cc/Hc3NnNdK/anel-hebibovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 7,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 7,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/z3CBtSpQ/anel-hebibovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Darko",
                        prezime = "Bodul",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 10,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/1fbj8w19/darko-bodul.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 8,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 10,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/75WYGBY5/darko-bodul.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Krste",
                        prezime = "Velkoski",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 5,
                        gradRodjenjaId = 16,
                        Slika = webClient.DownloadData("https://i.postimg.cc/F1BP63Rj/krste-velkoski.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 8,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 11,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/z38b1cLN/krste-velkoski.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Dražen",
                        prezime = "Bagarić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 4,
                        gradRodjenjaId = 14,
                        Slika = webClient.DownloadData("https://i.postimg.cc/cKB9kzgH/drazen-bagaric.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 9,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 22,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/21VLKL1B/drazen-bagaric.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Mersudin",
                        prezime = "Ahmetović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 3,
                        Slika = webClient.DownloadData("https://i.postimg.cc/CRych0b5/mersudin-ahmetovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 10,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 9,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/2V511LFX/mersudin-ahmetovic.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Mirko",
                        prezime = "Oremuš",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 4,
                        gradRodjenjaId = 18,
                        Slika = webClient.DownloadData("https://i.postimg.cc/9DGJzkBp/mirko-oremus.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 11,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 6,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/pp1pzVsV/mirko-oremus.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Halid",
                        prezime = "Šabanović",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/1nRWkKwK/halid-sabanovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 12,
                    noga = "DESNA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 4,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/SJQMcvqd/halid-sabanoivc.png"),
                });

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Vicko",
                        prezime = "Ševelj",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 4,
                        gradRodjenjaId = 18,
                        Slika = webClient.DownloadData("https://i.postimg.cc/qgzw2qLg/vicko-sevelj.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 11,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 24,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/Q9sthFdm/vicko-sevelj.png"),
                });

                Database.Korisnik vicko_sevelj = context.korisnici.Where(s => s.korisnickoIme == "vicko.sevelj@fksarajevo.ba").FirstOrDefault();
                vicko_sevelj.isAktivan = false;
                context.SaveChanges();

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Matthias",
                        prezime = "Fanimo",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 9,
                        gradRodjenjaId = 19,
                        Slika = webClient.DownloadData("https://i.postimg.cc/nC9dfrjN/mathias-fanimo.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 11,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 38,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/m1LtNPxk/mathias-fanimo.png"),
                });

                Database.Korisnik matthias_fanimo = context.korisnici.Where(s => s.korisnickoIme == "matthias.fanimo@fksarajevo.ba").FirstOrDefault();
                matthias_fanimo.isAktivan = false;
                context.SaveChanges();

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Haris",
                        prezime = "Konjalić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 20,
                        Slika = webClient.DownloadData("https://i.postimg.cc/dkWWwT9c/harsi-konjalic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 12,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 42,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/xJyXzK4B/harsi-konjalic.png"),
                });

                Database.Korisnik haris_konjalic = context.korisnici.Where(s => s.korisnickoIme == "haris.konjalic@fksarajevo.ba").FirstOrDefault();
                haris_konjalic.isAktivan = false;
                context.SaveChanges();

                igrac_service.Insert(new Model.Requests.Igrac.IgracInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Boris",
                        prezime = "Cmiljanić",
                        datumRodjenja = System.DateTime.Parse("2000-01-01 10:32:55.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 11,
                        gradRodjenjaId = 21,
                        Slika = webClient.DownloadData("https://i.postimg.cc/t7Cfw9zH/boris-cmiljanic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    pozicijaId = 12,
                    noga = "LIJEVA",
                    jacinaSlabijeNoge = 5,
                    visina = 190,
                    tezina = 75,
                    brojDresa = 18,
                    trzisnaVrijednost = 100000,
                    napomeneOIgracu = "",
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/QHSMs82k/boris-cmiljanic.png"),
                });

                Database.Korisnik boris_cmiljanic = context.korisnici.Where(s => s.korisnickoIme == "boris.cmiljanic@fksarajevo.ba").FirstOrDefault();
                boris_cmiljanic.isAktivan = false;
                context.SaveChanges();

                trener_service.Insert(new Model.Requests.Trener.TrenerInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Goran",
                        prezime = "Sablić",
                        datumRodjenja = System.DateTime.Parse("1988-12-27 19:28:44.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 4,
                        gradRodjenjaId = 22,
                        Slika = webClient.DownloadData("https://i.postimg.cc/PvCvvQ6t/goran-sablic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    preferiranaFormacijaId = 1,
                    trenerskaLicencaId = 1,
                    ulogaTreneraId = 1,
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/dDhhBnBF/goran-sablic.png"),
                });

                trener_service.Insert(new Model.Requests.Trener.TrenerInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Abdulah",
                        prezime = "Oruč",
                        datumRodjenja = System.DateTime.Parse("1988-12-27 19:28:44.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/8Fb625JV/abdulah-oruc.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    preferiranaFormacijaId = 1,
                    trenerskaLicencaId = 2,
                    ulogaTreneraId = 2,
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/941DxnKm/abdulah-oruc.png"),
                });

                trener_service.Insert(new Model.Requests.Trener.TrenerInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Adi",
                        prezime = "Adilović",
                        datumRodjenja = System.DateTime.Parse("1988-12-27 19:28:44.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 9,
                        Slika = webClient.DownloadData("https://i.postimg.cc/R6sn0DLs/adi-adilovic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    preferiranaFormacijaId = 1,
                    trenerskaLicencaId = 2,
                    ulogaTreneraId = 2,
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/G85HRsb6/adi-adilovic.png"),
                });

                trener_service.Insert(new Model.Requests.Trener.TrenerInsertRequest
                {
                    korisnikInsertRequest = new Model.Requests.Korisnik.KorisnikInsertRequest
                    {
                        ime = "Nermin",
                        prezime = "Huskić",
                        datumRodjenja = System.DateTime.Parse("1988-12-27 19:28:44.0000000"),
                        adresa = "Koševo 1",
                        telefon = "38762209709",
                        email = "eBordoApp@outlook.com",
                        drzavljanstvoId = 1,
                        gradRodjenjaId = 1,
                        Slika = webClient.DownloadData("https://i.postimg.cc/grjZ7GGf/nermin-huskic.png"),
                    },
                    ugovorInsertRequest = new Model.Requests.Ugovor.UgovorInsertRequest
                    {
                        datumPocetka = System.DateTime.Now,
                        datumZavrsetka = System.DateTime.Parse("2024-01-30 10:27:31.0000000"),
                    },
                    preferiranaFormacijaId = 1,
                    trenerskaLicencaId = 2,
                    ulogaTreneraId = 2,
                    SlikaPanel = webClient.DownloadData("https://i.postimg.cc/vxxDZHBT/nermin-huskic.png"),
                });

                utakmica_service.Insert(new eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest
                {
                    datumOdigravanja = System.DateTime.Parse("2021-09-01 10:27:31.0000000"),
                    satnica = "15:00",
                    sudija = "Haris Pandžić",
                    stadionId = 6,
                    napomene = "Lorem ipsum",
                    opisUtakmice = "1. KOLO M:TEL PREMIER LIGE BIH",
                    takmicenjeId = 1,
                    kapitenId = 20,
                    trenerId = 1,
                    protivnikId = 6,
                    tipGarniture = "Domaća",
                    tipUtakmice = "Domaća",
                    odigrana = false,
                    sastav = generateSastav(prvaPostava: 11, klupa: 9)
                });

                utakmica_service.Insert(new eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest
                {
                    datumOdigravanja = System.DateTime.Parse("2022-09-03 10:27:31.0000000"),
                    satnica = "20:00",
                    sudija = "Haris Pandžić",
                    stadionId = 2,
                    napomene = "Lorem ipsum",
                    opisUtakmice = "1. PRETKOLO UEFA KONFERENCIJSKE LIGE",
                    takmicenjeId = 5,
                    kapitenId = 20,
                    trenerId = 1,
                    protivnikId = 2,
                    tipGarniture = "Gostujuća",
                    tipUtakmice = "Gostujuća",
                    odigrana = false,
                    sastav = generateSastav(prvaPostava: 5, klupa: 6)
                });

                utakmica_service.Insert(new eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest
                {
                    datumOdigravanja = System.DateTime.Parse("2021-09-06 10:27:31.0000000"),
                    satnica = "13:00",
                    sudija = "Haris Pandžić",
                    stadionId = 7,
                    napomene = "Lorem ipsum",
                    opisUtakmice = "1. KOLO M:TEL PREMIER LIGE BIH",
                    takmicenjeId = 1,
                    kapitenId = 20,
                    trenerId = 1,
                    protivnikId = 9,
                    tipGarniture = "Gostujuća",
                    tipUtakmice = "Gostujuća",
                    odigrana = false,
                    sastav = generateSastav(prvaPostava: 11, klupa: 9)
                });

                utakmica_service.Insert(new eBordo.Model.Requests.Utakmica.UtakmicaInsertRequest
                {
                    datumOdigravanja = System.DateTime.Parse("2022-09-09 10:27:31.0000000"),
                    satnica = "15:00",
                    sudija = "Haris Pandžić",
                    stadionId = 6,
                    napomene = "Lorem ipsum",
                    opisUtakmice = "1/3 KUP-A BIH",
                    takmicenjeId = 2,
                    kapitenId = 20,
                    trenerId = 1,
                    protivnikId = 8,
                    tipGarniture = "Domaća",
                    tipUtakmice = "Domaća",
                    odigrana = false,
                    sastav = generateSastav(prvaPostava: 11, klupa: 9)
                });

                List<eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest> ocjene1 = generateOcjene(1);

                izvjestaj_service.Insert(new Model.Requests.Izvjestaj.IzvjetajInsertRequest
                {
                    goloviSarajevo = ocjene1.Select(s => s.golovi).Sum(),
                    goloviProtivnik = 3,
                    zapisnik = "Utakmica je prošla u sportskom duhu.",
                    vrijeme = Model.Models.Vrijeme.SUNCE,
                    igracUtakmicaID = 20,
                    utakmicaID = 1,
                    trenerID = 1,
                    slikaSaUtakmice = webClient.DownloadData("https://i.postimg.cc/mh1cs1m5/sarajvo-sloboda.jpg"),
                    utakmicaNastup = generateOcjene(1),
                    izmjene = generateIzmjene(1)
                });

                List<eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest> ocjene3 = generateOcjene(3);

                izvjestaj_service.Insert(new Model.Requests.Izvjestaj.IzvjetajInsertRequest
                {
                    goloviSarajevo = ocjene3.Select(s => s.golovi).Sum(),
                    goloviProtivnik = 2,
                    zapisnik = "Utakmica je prošla u sportskom duhu.",
                    vrijeme = Model.Models.Vrijeme.SUNCE,
                    igracUtakmicaID = 20,
                    utakmicaID = 3,
                    trenerID = 1,
                    slikaSaUtakmice = webClient.DownloadData("https://i.postimg.cc/8cLcJdPm/eljo-sarajevo.jpg"),
                    utakmicaNastup = generateOcjene(3),
                    izmjene = generateIzmjene(3)
                });

                trening_service.Insert(new eBordo.Model.Requests.Trening.TreningInsertRequest
                {
                    datumOdrzavanja = System.DateTime.Parse("2022-09-01 10:27:31.0000000"),
                    satnica = "15:00",
                    lokacija = "Stadion",
                    fokusTreninga = "Rad na fizičkoj spremi igrača",
                    zabiljezioID = 1,
                    trajanje = 2
                });

                trening_service.Insert(new eBordo.Model.Requests.Trening.TreningInsertRequest
                {
                    datumOdrzavanja = System.DateTime.Parse("2022-09-02 10:27:31.0000000"),
                    satnica = "15:00",
                    lokacija = "Trening_centar",
                    fokusTreninga = "Rad u teretani",
                    zabiljezioID = 1,
                    trajanje = 2
                });

                trening_service.Insert(new eBordo.Model.Requests.Trening.TreningInsertRequest
                {
                    datumOdrzavanja = System.DateTime.Parse("2022-09-04 10:27:31.0000000"),
                    satnica = "15:00",
                    lokacija = "Trening_centar",
                    fokusTreninga = "Rad na taktici!",
                    zabiljezioID = 1,
                    trajanje = 2
                });
            }
            List<eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest> generateIzmjene(int utakmicaId)
            {
                List<eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest> izmjene = new List<eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest>();

                izmjene.Add(_generateIzmjena(utakmicaId, 6, 14, 70, "POVREDA"));
                izmjene.Add(_generateIzmjena(utakmicaId, 5, 15, 50, "FORMA"));

                return izmjene;
            }
            List<eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest> generateOcjene(int utakmicaId)
            {
                List<eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest> ocjene = new List<Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest>();

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 8,
                    minute: 90,
                    golovi: 2,
                    asistencije: 1,
                    zuti: 0,
                    crveni: 0
                ));

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 9,
                    minute: 90,
                    golovi: 0,
                    asistencije: 0,
                    zuti: 1,
                    crveni: 1
                ));

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 10,
                    minute: 90,
                    golovi: 1,
                    asistencije: 0,
                    zuti: 1,
                    crveni: 0
                ));

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 6,
                    minute: 70,
                    golovi: 0,
                    asistencije: 0,
                    zuti: 0,
                    crveni: 0
                ));

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 5,
                    minute: 50,
                    golovi: 0,
                    asistencije: 0,
                    zuti: 0,
                    crveni: 0
                ));

                ocjene.Add(_generateOcjena(
                    utakmicaId: utakmicaId,
                    igracId: 2,
                    minute: 90,
                    golovi: 0,
                    asistencije: 0,
                    zuti: 1,
                    crveni: 0
                ));

                return ocjene;
            }
            List<eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest> generateSastav(int prvaPostava, int klupa)
            {
                List<eBordo.Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest> sastav = new List<Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest>();

                int count = 1;

                for (int i = 0; i < prvaPostava; i++)
                {
                    sastav.Add(new Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest
                    {
                        igracId = count,
                        pozicijaId = count,
                        uloga = "PRVA_POSTAVA"
                    });

                    count++;
                }

                count = prvaPostava + 1;
                int pozicijaId = 1;

                for (int i = prvaPostava; i < prvaPostava + klupa; i++)
                {
                    sastav.Add(new Model.Requests.UtakmicaSastav.UtakmicaSastavInsertRequest
                    {
                        igracId = count,
                        pozicijaId = pozicijaId,
                        uloga = "KLUPA"
                    });

                    count++;
                    pozicijaId++;
                }

                return sastav;
            }


            //HELPERS
            eBordo.Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest _generateOcjena(int utakmicaId, int igracId, int minute, int golovi, int asistencije, int zuti, int crveni)
            {
                var rand = new Random();

                return new Model.Requests.UtakmicaNastup.UtakmicaNastupInsertRequest
                {
                    igracId = igracId,
                    trenerId = 1,
                    utakmicaId = utakmicaId,
                    minute = minute,
                    golovi = golovi,
                    asistencije = asistencije,
                    zutiKartoni = zuti,
                    crveniKartoni = crveni,
                    ocjena = rand.Next(1, 5),
                    komentar = "Nastup je bio jako dobar i zadovoljavajući.",
                    kontrolaLopte = rand.Next(1, 5),
                    driblanje = rand.Next(1, 5),
                    dodavanje = rand.Next(1, 5),
                    kretanje = rand.Next(1, 5),
                    brzina = rand.Next(1, 5),
                    sut = rand.Next(1, 5),
                    snaga = rand.Next(1, 5),
                    markiranje = rand.Next(1, 5),
                    klizeciStart = rand.Next(1, 5),
                    skok = rand.Next(1, 5),
                    odbrana = rand.Next(1, 5),
                };
            }

            eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest _generateIzmjena(int utakmicaId, int igracOut, int igracIn, int minuta, string razlogIzmjene)
            {
                var rand = new Random();

                return new eBordo.Model.Requests.UtakmicaIzmjena.UtakmicaIzmjenaInsertRequest
                {
                    utakmicaId = utakmicaId,
                    igracOutId = igracOut,
                    igracInId = igracIn,
                    minuta = minuta,
                    izmjenaRazlog = razlogIzmjene
                };
            }
        }
    }
}
