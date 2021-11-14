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
                        posaljiNotifikaciju("Promjene uspješno sačuvane!", TipPoruke.SUCCESS, snackbar, forma);
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
                case TipNotifikacije.BEZ: break;
            }
        }
        public static void posaljiNotifikaciju(string sadrzajNotifikacije, TipPoruke tipNotifikacije, BunifuSnackbar snackbar, System.Windows.Forms.Form forma)
        {
            switch (tipNotifikacije)
            {
                case TipPoruke.SUCCESS:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                        3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.success);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.WARNING:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning,
                        3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.warning);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.INFO:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,
                        3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.info);
                        simpleSound.Play();
                        break;
                    }
                case TipPoruke.ERROR:
                    {
                        snackbar.Show(forma,
                        sadrzajNotifikacije,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                        3000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomRight);
                        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.error);
                        simpleSound.Play();
                        break;
                    }
                default: break;
            }
        }
    }
}
