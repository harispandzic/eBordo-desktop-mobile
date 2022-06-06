using Microsoft.EntityFrameworkCore;

namespace eBordo.Api.Database
{
    public partial class eBordoContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            var webClient = new System.Net.WebClient();

            //POZICIJA
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 1, nazivPozicije = "Golman", skracenica = "GK" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 2, nazivPozicije = "Štoper", skracenica = "CB" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 3, nazivPozicije = "Lijevi bek", skracenica = "LB" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 4, nazivPozicije = "Desni bek", skracenica = "RB" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 5, nazivPozicije = "Zadnji vezni", skracenica = "CDM" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 6, nazivPozicije = "Centralni vezni", skracenica = "CM" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 7, nazivPozicije = "Prednji vezni", skracenica = "CAM" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 8, nazivPozicije = "Lijevi vezni", skracenica = "LM" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 9, nazivPozicije = "Desni vezni", skracenica = "RM" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 10, nazivPozicije = "Lijevo krilo", skracenica = "LW" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 11, nazivPozicije = "Desno krilo", skracenica = "RW" });
            modelBuilder.Entity<Pozicija>().HasData(new Pozicija { pozicijaId = 12, nazivPozicije = "Napadač", skracenica = "ST" });

            ////DRZAVA
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 1, nazivDrzave = "Bosna i Hercegovina", zastava = webClient.DownloadData("https://i.postimg.cc/1nd2Xnsk/bosna.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 2, nazivDrzave = "Turska", zastava = webClient.DownloadData("https://i.postimg.cc/DShDSK3w/turska.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 3, nazivDrzave = "Italija", zastava = webClient.DownloadData("https://i.postimg.cc/47yjXbkv/italija.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 4, nazivDrzave = "Hrvatska", zastava = webClient.DownloadData("https://i.postimg.cc/fJmpWRFP/hrvatska.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 5, nazivDrzave = "Makedonija", zastava = webClient.DownloadData("https://i.postimg.cc/s1Bb8cJs/makedonija.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 6, nazivDrzave = "Škotska", zastava = webClient.DownloadData("https://i.postimg.cc/Pv8cwXqP/skotska.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 7, nazivDrzave = "Srbija", zastava = webClient.DownloadData("https://i.postimg.cc/SnGP8tm7/srbija.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 8, nazivDrzave = "Njemačka", zastava = webClient.DownloadData("https://i.postimg.cc/VSD3yZTL/njmeacka.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 9, nazivDrzave = "Engleska", zastava = webClient.DownloadData("https://i.postimg.cc/dDzgKyWd/engleska.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 10, nazivDrzave = "Austrija", zastava = webClient.DownloadData("https://i.postimg.cc/tsH0FxWy/austrija.png") });
            modelBuilder.Entity<Drzava>().HasData(new Drzava { drzavaId = 11, nazivDrzave = "Crna Gora", zastava = webClient.DownloadData("https://i.postimg.cc/McWhFJ9F/crna-gora.png") });

            //GRAD
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 1, nazivGrada = "Sarajevo", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 2, nazivGrada = "Mostar", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 3, nazivGrada = "Tuzla", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 4, nazivGrada = "Bergamo", drzavaId  = 3 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 5, nazivGrada = "Istanbul", drzavaId  = 2 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 6, nazivGrada = "Mönchengladbach", drzavaId  = 8 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 7, nazivGrada = "Glasgow", drzavaId  = 6 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 8, nazivGrada = "Manchester", drzavaId  = 9 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 9, nazivGrada = "Zenica", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 10, nazivGrada = "Tešanj", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 11, nazivGrada = "Smederevska Palanka", drzavaId  = 7 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 12, nazivGrada = "Kasindo", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 13, nazivGrada = "Sanski Most", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 14, nazivGrada = "Wien", drzavaId  = 10 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 15, nazivGrada = "Konjic", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 16, nazivGrada = "Struga", drzavaId  = 5 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 17, nazivGrada = "Split", drzavaId  = 4 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 18, nazivGrada = "Dubrovnik", drzavaId  = 4 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 19, nazivGrada = "London", drzavaId  = 9 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 20, nazivGrada = "Travnik", drzavaId  = 1 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 21, nazivGrada = "Bijelo Polje", drzavaId  = 11 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 22, nazivGrada = "Sinj", drzavaId  = 4 });
            modelBuilder.Entity<Grad>().HasData(new Grad { gradId = 23, nazivGrada = "Stolac", drzavaId  = 1 });

            //FORMACIJA
            modelBuilder.Entity<Formacija>().HasData(new Formacija { formacijaId = 1, nazivFormacije = "4-4-2"});
            modelBuilder.Entity<Formacija>().HasData(new Formacija { formacijaId = 2, nazivFormacije = "4-4-3" });
            modelBuilder.Entity<Formacija>().HasData(new Formacija { formacijaId = 3, nazivFormacije = "4-3-3" });
            modelBuilder.Entity<Formacija>().HasData(new Formacija { formacijaId = 4, nazivFormacije = "4-2-3-1" });

            //TAKMICENJE
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 1, nazivTakmicenja = "M:tel Premier Liga", logo = webClient.DownloadData("https://i.postimg.cc/PLvXzFMc/mtel-premier-liga.png") });
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 2, nazivTakmicenja = "Kup BiH", logo = webClient.DownloadData("https://i.postimg.cc/MvzG25WM/kup-bih.png") });
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 3, nazivTakmicenja = "UEFA Champions League", logo = webClient.DownloadData("https://i.postimg.cc/BPBQPLCn/champions-league.png") });
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 4, nazivTakmicenja = "UEFA Europa League", logo = webClient.DownloadData("https://i.postimg.cc/8sRC09Vg/europa-league.png") });
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 5, nazivTakmicenja = "UEFA Conference League", logo = webClient.DownloadData("https://i.postimg.cc/Yh8CpF9X/uefa-conference.png") });
            modelBuilder.Entity<Takmicenje>().HasData(new Takmicenje { takmicenjeId = 6, nazivTakmicenja = "Prijateljska", logo = webClient.DownloadData("https://i.postimg.cc/VJ6L5N0z/prijateljska.png") });
            
            //STADION
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 1, nazivStadiona = "Gewiss Stadium", lokacijaStadionaId = 4, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/t1PMdLsY/atalanta-arena.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 2, nazivStadiona = "Wodafone Arena", lokacijaStadionaId = 5, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/d7MW045v/vodafone-arena.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 3, nazivStadiona = "Celtic Park", lokacijaStadionaId = 7, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/sQ4Hq79z/celtic-arena.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 4, nazivStadiona = "Borussia-Park", lokacijaStadionaId = 6, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/2bDX02WT/gladbach-arena.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 5, nazivStadiona = "Old Trafford", lokacijaStadionaId = 8, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/XBN1bqQC/old-trafford.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 6, nazivStadiona = "Asim Ferhatović Hase", lokacijaStadionaId = 1, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/xccgyW7n/kosevo.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 7, nazivStadiona = "Grbavica", lokacijaStadionaId = 1, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/1fjCk968/grbavica.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 8, nazivStadiona = "Bijeli Brijeg", lokacijaStadionaId = 2, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/XpJ11ZZM/bijeli-brijeg.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 9, nazivStadiona = "Rođeni", lokacijaStadionaId = 2, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/yW7b9ps8/ro-eni.jpg") });
            modelBuilder.Entity<Stadion>().HasData(new Stadion { stadionId = 10, nazivStadiona = "Tušanj", lokacijaStadionaId = 3, slikaStadiona = webClient.DownloadData("https://i.postimg.cc/WtSf7m16/tusanj.jpg") });
            
            //KLUB
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 1, nazivKluba = "Atalanta", gradId = 4,stadionId = 1, grb = webClient.DownloadData("https://i.postimg.cc/n9qMYVvC/atalanta.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 2, nazivKluba = "Beşiktaş", gradId = 5,stadionId = 2, grb = webClient.DownloadData("https://i.postimg.cc/dZcV1Mzv/besiktas.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 3, nazivKluba = "Borussia Mönchengladbach", gradId = 6,stadionId = 4, grb = webClient.DownloadData("https://i.postimg.cc/4ncKTPrs/bormonch.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 4, nazivKluba = "Celtic", gradId = 7,stadionId = 3, grb = webClient.DownloadData("https://i.postimg.cc/phFdRVcq/celtic.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 5, nazivKluba = "Manchester United", gradId = 8,stadionId = 5, grb = webClient.DownloadData("https://i.postimg.cc/TpXK2m6m/manchester-united.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 6, nazivKluba = "Sloboda", gradId = 3,stadionId = 10, grb = webClient.DownloadData("https://i.postimg.cc/9rtrDMmk/sloboda.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 7, nazivKluba = "Tuzla City", gradId = 3,stadionId = 10, grb = webClient.DownloadData("https://i.postimg.cc/pmWyzHyL/tuzla-city.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 8, nazivKluba = "Velež", gradId = 2,stadionId = 9, grb = webClient.DownloadData("https://i.postimg.cc/DSx0cMbd/velez.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 9, nazivKluba = "Željezničar", gradId = 1,stadionId = 7, grb = webClient.DownloadData("https://i.postimg.cc/JH34H6LX/zeljeznicar.png") });
            modelBuilder.Entity<Klub>().HasData(new Klub { klubId = 10, nazivKluba = "Zrinjski", gradId = 2,stadionId = 8, grb = webClient.DownloadData("https://i.postimg.cc/McXT3m7k/zrinjski.png") });
            
            //TRENERSKA LICENCA
            modelBuilder.Entity<TrenerskaLicenca>().HasData(new TrenerskaLicenca { trenerskaLicencaId = 1, nazivLicence = "UEFA A"});
            modelBuilder.Entity<TrenerskaLicenca>().HasData(new TrenerskaLicenca { trenerskaLicencaId = 2, nazivLicence = "UEFA B" });
            modelBuilder.Entity<TrenerskaLicenca>().HasData(new TrenerskaLicenca { trenerskaLicencaId = 3, nazivLicence = "UEFA PRO" });
        }
    }
}
