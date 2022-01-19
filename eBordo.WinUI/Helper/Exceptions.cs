using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBordo.WinUI.Helper
{
    public class Exceptions
    {
        public static TipNotifikacije getException (string tekstErrora)
        {
            TipNotifikacije tipNotifikacije = TipNotifikacije.GREŠKA_NA_SERVERU;

            if(tekstErrora.Contains("Grad postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.GRAD_POSTOJI;
            }
            if (tekstErrora.Contains("Drzava postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.DRZAVA_POSTOJI;
            }
            if (tekstErrora.Contains("Klub postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.KLUB_POSTOJI;
            }
            if (tekstErrora.Contains("Takmicenje postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.TAKMICENJE_POSTOJI;
            }
            if (tekstErrora.Contains("Stadion postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.STADION_POSTOJI;
            }
            if (tekstErrora.Contains("Korisnik postoji u bazi podataka!"))
            {
                tipNotifikacije = TipNotifikacije.KORISNIK_POSTOJI;
            }
            if (tekstErrora.Contains("Odabrani datum je zauzet. Vec je evidentirana utakmica!"))
            {
                tipNotifikacije = TipNotifikacije.DATUM_ZAUZET_UTAKMICA;
            }
            if (tekstErrora.Contains("Odabrani datum je zauzet. Vec je evidentiran trening!"))
            {
                tipNotifikacije = TipNotifikacije.DATUM_ZAUZET_TRENING;
            }
            if (tekstErrora.Contains("One or more validation errors occurred."))
            {
                tipNotifikacije = TipNotifikacije.SERVER_GRESKA_VALIDACIJE;
            }
            if (tekstErrora.Contains("Nema podataka!"))
            {
                tipNotifikacije = TipNotifikacije.NEMA_PODATAKA_U_BAZI;
            }

            return tipNotifikacije;
        }
    }
}
