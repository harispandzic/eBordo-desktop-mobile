using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace eBordo.WinUI.Helper
{
    public class PosaljiNotifikaciju
    {
        public static void notificationSwitch(BunifuSnackbar snackbar, System.Windows.Forms.Form forma, TipNotifikacije notifikacija = TipNotifikacije.BEZ)
        {
            switch (notifikacija)
            {
                case TipNotifikacije.DODAVANJE:
                    {
                        posaljiNotifikaciju("Zapis uspješno pohranjen!", TipPoruke.SUCCESS, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.UREĐIVANJE:
                    {
                        posaljiNotifikaciju("Promjene uspješno sačuvane!", TipPoruke.INFO, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.BRISANJE:
                    {
                        posaljiNotifikaciju("Zapis je uspješno obrisan!", TipPoruke.SUCCESS, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.NEMA_REZULTATA_PRETRAGE:
                    {
                        posaljiNotifikaciju("Nema razultata pretrage!", TipPoruke.WARNING, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.NEMA_PODATAKA:
                    {
                        posaljiNotifikaciju("Nema podataka!", TipPoruke.WARNING, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.NEISPRAVNI_KREDENCIJALI:
                    {
                        posaljiNotifikaciju("Korisničko ime i lozinka nisu ispravni!", TipPoruke.ERROR, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.PORUKA_DOBRODOSLICE:
                    {
                     string logovaniKorisnik = ApiService.ApiService.logovaniKorisnik.ime + " " + ApiService.ApiService.logovaniKorisnik.prezime;
                     posaljiNotifikaciju($"{logovaniKorisnik}, dobrodošao na eBordo!", TipPoruke.SUCCESS, snackbar, forma);
                     break;
                    }
                case TipNotifikacije.GREŠKA_NA_SERVERU:
                    {
                        posaljiNotifikaciju("Greška na serveru!", TipPoruke.ERROR, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.BROJ_IGRACA_PRVA_POSTAVA:
                    {
                        posaljiNotifikaciju("Prva postava mora imati 11 igrača!", TipPoruke.WARNING, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.BROJ_IGRACA_KLUPA:
                    {
                        posaljiNotifikaciju("Klupa mora imati 9 igrača", TipPoruke.WARNING, snackbar, forma);
                        break;
                    }
                case TipNotifikacije.IGRAC_DODAN_U_SASTAV:
                    {
                        posaljiNotifikaciju("Igrač se nalazi u sastavu!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.BEZ_UTAKMICA:
                    {
                        posaljiNotifikaciju("Nema odigranih utakmica!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.TopCenter);
                        break;
                    }
                case TipNotifikacije.IGRAC_OCJENJEN:
                    {
                        posaljiNotifikaciju("Igrač je već ocjenjen!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.POPUNJENA_PRVA_POSTAVA:
                    {
                        posaljiNotifikaciju("Prva postava može imati maksimalno 11 igrača!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.POPUNJENA_KLUPA:
                    {
                        posaljiNotifikaciju("Klupa može imati maksimalno 9 igrača!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.SASTAV_ODABRAN:
                    {
                        posaljiNotifikaciju("Sastav je uspješno odabran!", TipPoruke.INFO, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.IGRAC_USPJESNO_DODAN_U_SASTAV:
                    {
                        posaljiNotifikaciju("Igrač uspješno dodan u sastav!", TipPoruke.SUCCESS, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.IGRAC_USPJESNO_OCJENJEN:
                    {
                        posaljiNotifikaciju("Igrač uspješno ocjenjen!", TipPoruke.SUCCESS, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.IZMJENA_USPJEŠNO_EVIDENTIRANA:
                    {
                        posaljiNotifikaciju("Izmjena uspješno evidentirana!", TipPoruke.SUCCESS, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.IZMJENA_VEC_EVIDENTIRANA:
                    {
                        posaljiNotifikaciju("Izmjena je već evidentirana!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.FORMA_VALIDACIJA:
                    {
                        posaljiNotifikaciju("Podaci nisu ispravni!", TipPoruke.WARNING, snackbar, forma, BunifuSnackbar.Positions.BottomRight);
                        break;
                    }
                case TipNotifikacije.BEZ: break;
            }
        }
        public static void posaljiNotifikaciju(string sadrzajNotifikacije, TipPoruke tipNotifikacije, BunifuSnackbar snackbar, System.Windows.Forms.Form forma, Bunifu.UI.WinForms.BunifuSnackbar.Positions pozicija = BunifuSnackbar.Positions.BottomRight)
        {
            switch (tipNotifikacije)
            {
                case TipPoruke.SUCCESS:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                        3000, "", pozicija);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.success);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.WARNING:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
                        3000, "", pozicija);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.warning);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.INFO:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
                        3000, "", pozicija);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.info);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.ERROR:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                        3000, "", pozicija);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.error);
                        simpleSound.Play();
                        break;
                    }
                default: break;
            }
        }
    }
}
