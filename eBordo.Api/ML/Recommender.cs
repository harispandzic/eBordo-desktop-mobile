using AutoMapper;
using eBordo.Api.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBordo.Api.ML
{
    public class Recommender
    {
        public eBordoContext _db { get; set; }
        protected readonly IMapper _mapper;

        Dictionary<int, List<Database.UtakmicaNastup>> nastupiIgraca = new Dictionary<int, List<Database.UtakmicaNastup>>();

        public Recommender(eBordoContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.Models.Igrac> GetRecommendedIgrace(Model.Requests.Igrac.RecommendedIgraci request)
        {
            UcitajIgrace(request.igracId, request.selectedIds);

            List<Database.UtakmicaNastup> nastupiPosmatranogIgraca = _db.utakmicaNastup.Where(s => s.igracId == request.igracId).OrderBy(s => s.utakmicaId).ToList();

            List<Database.UtakmicaNastup> zajednickiNastupi_1 = new List<UtakmicaNastup>();
            List<Database.UtakmicaNastup> zajednickiNastupi_2 = new List<UtakmicaNastup>();
            List<Database.Igrac> preporuceniIgraci = new List<Database.Igrac>();

            foreach (var item in nastupiIgraca)
            {
                foreach (Database.UtakmicaNastup nastupPosmatranogIgraca in nastupiPosmatranogIgraca)
                {
                    if(item.Value.Where(s => s.utakmicaId == nastupPosmatranogIgraca.utakmicaId).Count() > 0)
                    {
                        zajednickiNastupi_1.Add(nastupPosmatranogIgraca);
                        zajednickiNastupi_2.Add(item.Value.Where(s => s.utakmicaId == nastupPosmatranogIgraca.utakmicaId).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickiNastupi_1,zajednickiNastupi_2);
                if(slicnost > 0.7)
                {
                    preporuceniIgraci.Add(_db.igraci.Where(s => s.igracId == item.Key)
                        .Include(s => s.korisnik)
                        .Include(s => s.pozicija)
                        .Include(s => s.igracStatistika)
                        .FirstOrDefault());
                }
                zajednickiNastupi_1.Clear();
                zajednickiNastupi_2.Clear();
            }

            return _mapper.Map<List<Model.Models.Igrac>>(preporuceniIgraci);
        }

        private double GetSlicnost(List<UtakmicaNastup> zajednickiNastupi_1, List<UtakmicaNastup> zajednickiNastupi_2)
        {
            if (zajednickiNastupi_1.Count != zajednickiNastupi_2.Count)
                return 0;

            double brojnik = 0, nazivnik_1 = 0, nazivnik_2 = 0;

            for (int i = 0; i < zajednickiNastupi_1.Count; i++)
            {
                brojnik = zajednickiNastupi_1[i].ocjena * zajednickiNastupi_2[i].ocjena;
                nazivnik_1 = zajednickiNastupi_1[i].ocjena * zajednickiNastupi_1[i].ocjena;
                nazivnik_2 = zajednickiNastupi_2[i].ocjena * zajednickiNastupi_2[i].ocjena;
            }
            nazivnik_1 = Math.Sqrt(nazivnik_1);
            nazivnik_2 = Math.Sqrt(nazivnik_2);

            double nazivnik = nazivnik_1 * nazivnik_2;

            if (nazivnik == 0)
                return 0;

            return brojnik / nazivnik;
        }

        private void UcitajIgrace(int igracId, List<int> selectedIds)
        {
            List<Database.Igrac> aktivniIgraci = _db.igraci.Where(s => s.igracId != igracId && s.korisnik.isAktivan == true && !selectedIds.Contains(s.igracId)).ToList();
          
            List<Database.UtakmicaNastup> ocjeneIgraca;
            foreach (var igrac in aktivniIgraci)
            {
                ocjeneIgraca = _db.utakmicaNastup.Where(x => x.igracId == igrac.igracId).OrderBy(t => t.utakmicaId).ToList();
                if(ocjeneIgraca.Count > 0)
                {
                    nastupiIgraca.Add(igrac.igracId, ocjeneIgraca);
                }
            }
        }
    }
}
