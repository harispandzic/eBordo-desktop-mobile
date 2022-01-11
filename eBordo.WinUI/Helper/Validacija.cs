using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBordo.WinUI.Helper
{
    public class Validacija
    {
        public static bool ValidirajInputString(BunifuTextBox kontrola, BunifuLabel label = null, Field polje = Field.BEZ)
        {
            bool isValidiran = true;

            switch (polje)
            {
                case Field.IME:
                    {
                        if(isPrazanString(kontrola,label) || 
                            isMinimalnoKaraktera(kontrola,label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label) ||
                                    isSadrziBroj(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.PREZIME:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label) ||
                                    isSadrziBroj(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.ADRESA:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.TELEFON:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isOdredjenBrojKaraktera(kontrola, label, 11) ||
                            isBrojevi(kontrola,label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.EMAIL:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 10) ||
                                isIspravanMail(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.VISINA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isBrojevi(kontrola, label) ||
                                    isOdredjenBrojKaraktera(kontrola, label, 3) ||
                                        isInRange(kontrola, label, 120, 250))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.TEZINA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isBrojevi(kontrola, label) ||
                                    isOdredjenBrojKaraktera(kontrola, label, 2) ||
                                        isInRange(kontrola, label, 55, 100))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DRES:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isBrojevi(kontrola, label) ||
                                    isMinimalnoKaraktera(kontrola, label, 1) ||
                                        isInRange(kontrola, label, 1, 99))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.TRZISNA_VRIJEDNOST:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isBrojevi(kontrola, label) ||
                                    isMinimalnoKaraktera(kontrola, label, 1) ||
                                        isInRange(kontrola, label, 1, 100000000))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.OPIS_UTAKMICE:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isPocinjeBrojem(kontrola, label) ||
                                        isMinimalnoKaraktera(kontrola, label, 10))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.SATNICA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                ValidirajSatnicu(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.SUDIJA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isMinimalnoKaraktera(kontrola, label, 5) ||
                                    isSadrziBroj(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.MINUTA_IZMJENA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isBrojevi(kontrola, label) ||
                                    isInRange(kontrola, label, 1, 120))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.FOKUS_TRENINGA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isMinimalnoKaraktera(kontrola, label, 15))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.TRAJANJE_TRENERA:
                    {
                        if (isPrazanString(kontrola, label) ||
                                isOdredjenBrojKaraktera(kontrola, label, 1) || 
                                    isBrojevi(kontrola, label) ||
                                        isInRange(kontrola, label, 1, 4))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.KORISNICKO_IME:
                    {
                        if (isPrazanString(kontrola, label, polje) ||
                                isMinimalnoKaraktera(kontrola, label, 4, polje) ||
                                    isIspravanMail(kontrola, label, polje) ||
                                        isSarajevoEMail(kontrola, label, polje))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.PASSWORD:
                    {
                        if (isPrazanString(kontrola, label, polje) ||
                                isMinimalnoKaraktera(kontrola, label, 4, polje) ||
                                    ValidacijaPAssword(kontrola, label, polje))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.NAZIV_DRZAVE:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label) ||
                                    isSadrziBroj(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.NAZIV_TAKMICENJA:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label) ||
                                    isSadrziBroj(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.NAZIV_KLUBA:
                    {
                        if (isPrazanString(kontrola, label) ||
                            isMinimalnoKaraktera(kontrola, label, 2) ||
                                isPrvoSlovoVeliko(kontrola, label))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                default:break;
            }
            if (isValidiran)
            {
                if (polje == Field.KORISNICKO_IME || polje == Field.PASSWORD)
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_success_izvjestaj;
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_success_notification;
                }
                label.Text = "";
                isValidiran = true;
            }
            return isValidiran;
        }
        public static bool ValidirajOcjene(BunifuTextBox kontrola, Field polje)
        {
            bool isValidiran = true;

            switch (polje)
            {
                case Field.MINUTE:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola,null,1,120))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.GOLOVI:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 20))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.ASISTENCIJE:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 20))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.ZUTI_KARTONI:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 2))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.CRVENI_KARTONI:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 1))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.GOLOVI_DOMACIN:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 20))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.GOLOVI_GOST:
                    {
                        if (isPrazanString(kontrola) ||
                                isBrojevi(kontrola) ||
                                    isInRange(kontrola, null, 0, 20))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                default: break;
            }
            if (isValidiran)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_success_izvjestaj;
                isValidiran = true;
            }
            return isValidiran;
        }
        public static bool ValidirajSliku(Image image, PictureBox pictureValidator, Field polje)
        {
            bool isValidiran = true;
            switch (polje)
            {
                case Field.SLIKA_AVATAR:
                    {
                        if (isUcitanaSlika(image,pictureValidator))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.SLIKA_PANEL:
                    {
                        if (isUcitanaSlika(image, pictureValidator))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.SLIKA_UTAKMICA:
                    {
                        if (isUcitanaSlika(image, pictureValidator))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                default: break;
            }

            if (isValidiran)
            {
                pictureValidator.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureValidator.BackgroundImageLayout = ImageLayout.Zoom;
                isValidiran = true;
            }
            return isValidiran;
        }
        public static bool ValidirajDatum(DateTime datum, BunifuLabel labelValidator, PictureBox pictureValidator, Field polje)
        {
            bool isValidiran = true;
            switch (polje)
            {
                case Field.DATUM_RODJENJA_IGRAC:
                    {
                        if (isDatumDanasnji(datum, labelValidator, pictureValidator) ||
                            isDatumInRange(datum, labelValidator, pictureValidator, new DateTime(1975, 1, 1), new DateTime(2010, 1, 1)))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DATUM_RODJENJA_TRENER:
                    {
                        if (isDatumDanasnji(datum, labelValidator, pictureValidator) ||
                            isDatumInRange(datum, labelValidator, pictureValidator, new DateTime(1965, 1, 1), new DateTime(1990, 1, 1)))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DATUM_POTPISA:
                    {
                        if (isDatumInRangeDays(datum, labelValidator, pictureValidator, 5))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DATUM_ZAVRSETKA:
                    {
                        if (isDatumInRange(datum, labelValidator, pictureValidator, DateTime.Now, DateTime.Now.AddYears(5)))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DATUM_ODIGRAVANJA:
                    {
                        if (isDatumDanasnji(datum, labelValidator, pictureValidator) ||
                            isDatumInNarednih30Dana(datum, labelValidator, pictureValidator, 30))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                case Field.DATUM_ODRZAVANJA:
                    {
                        if (isDatumDanasnji(datum, labelValidator, pictureValidator) ||
                            isDatumInNarednih30Dana(datum, labelValidator, pictureValidator, 3))
                        {
                            isValidiran = false;
                        }
                        break;
                    }
                default: break;
            }

            if (isValidiran)
            {
                pictureValidator.BackgroundImage = Properties.Resources.eBordo_success_notification;
                pictureValidator.BackgroundImageLayout = ImageLayout.Zoom;
                labelValidator.Text = "";
                isValidiran = true;
            }
            return isValidiran;
        }
        private static bool isUcitanaSlika(Image image, PictureBox pictureValidator)
        {
            bool flag = false;

            if (image == null)
            {
                pictureValidator.BackgroundImage = Properties.Resources.eBordo_error_notification;
                pictureValidator.BackgroundImageLayout = ImageLayout.Zoom;
                flag = false;
            }

            return flag;
        }
        private static bool isDatumInNarednih30Dana(DateTime datum, BunifuLabel labelValidator, PictureBox slikaValidator, int brojDana)
        {
            bool flag = false;
            if (datum.Date > DateTime.Now.AddDays(brojDana + 1) || datum.Date < DateTime.Now.Date)
            {
                slikaValidator.BackgroundImage = Properties.Resources.eBordo_error_notification;
                slikaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                labelValidator.Text = "Datum mora biti u okviru narednih " + brojDana + " dana";
                flag = true;
            }
            return flag;
        }
        private static bool isDatumDanasnji(DateTime datum, BunifuLabel labelValidator, PictureBox slikaValidator)
        {
            bool flag = false;
            if (datum.Date == DateTime.Now.Date)
            {
                slikaValidator.BackgroundImage = Properties.Resources.eBordo_error_notification;
                slikaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                labelValidator.Text = "Datum ne može biti današnji!";
                flag = true;
            }
            return flag;
        }
        private static bool isDatumInRangeDays(DateTime datum, BunifuLabel labelValidator, PictureBox slikaValidator,int brojDana)
        {
            bool flag = false;
            if (datum.Date < DateTime.Now.AddDays(-brojDana) || datum.Date > DateTime.Now)
            {
                slikaValidator.BackgroundImage = Properties.Resources.eBordo_error_notification;
                slikaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                labelValidator.Text = "Datum mora biti u okviru zadnjih " + brojDana + " dana";
                flag = true;
            }
            return flag;
        }
        private static bool isDatumInRange(DateTime datum, BunifuLabel labelValidator, PictureBox slikaValidator, DateTime datum1, DateTime datum2)
        {
            bool flag = false;
            if (datum.Date < datum1.Date || datum.Date > datum2.Date)
            {
                slikaValidator.BackgroundImage = Properties.Resources.eBordo_error_notification;
                slikaValidator.BackgroundImageLayout = ImageLayout.Zoom;
                labelValidator.Text = "Datum mora biti u rangu od " + datum1.Date.Year + " godine do " + datum2.Date.Year;
                flag = true;
            }
            return flag;
        }
        private static bool isPrazanString(BunifuTextBox kontrola, BunifuLabel label = null, Field polje = Field.BEZ)
        {
            bool flag = false;
            if (kontrola.Text.Length == 0)
            {
                if(label != null)
                {
                    if(polje == Field.KORISNICKO_IME || polje == Field.PASSWORD)
                    {
                        kontrola.RightIcon.Image = Properties.Resources.eBordo_required_izvjestaj2;
                    }
                    else
                    {
                        kontrola.RightIcon.Image = Properties.Resources.eBordo_required3;
                    }
                    label.Text = "Polje je obavezno";
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_required_izvjestaj2;
                }
                flag = true;
            }
            return flag;
        }
        private static bool isMinimalnoKaraktera(BunifuTextBox kontrola, BunifuLabel label = null, int brojKaraktera = 0, Field polje = Field.BEZ)
        {
            bool flag = false;
            if (kontrola.Text.Length < brojKaraktera)
            {
                if(label != null)
                {
                    if (polje == Field.KORISNICKO_IME || polje == Field.PASSWORD)
                    {
                        kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                    }
                    else
                    {
                        kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                    }
                    label.Text = "Nedovoljan broj karaktera";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isOdredjenBrojKaraktera(BunifuTextBox kontrola, BunifuLabel label = null, int brojKaraktera = 0)
        {
            bool flag = false;
            if (kontrola.Text.Length != brojKaraktera)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                if(label != null)
                {
                    label.Text = "Unos mora imati " + brojKaraktera + " karaktera";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isPrvoSlovoVeliko(BunifuTextBox kontrola, BunifuLabel label = null)
        {
            bool flag = false;
            if (!char.IsUpper(kontrola.Text[0]))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                if(label != null)
                {
                    label.Text = "Unos mora počinjati velikim slovom";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isPocinjeBrojem(BunifuTextBox kontrola, BunifuLabel label = null)
        {
            bool flag = false;
            if (!char.IsDigit(kontrola.Text[0]))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                if(label != null)
                {
                    label.Text = "Unos mora počinjati brojem";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isSadrziBroj(BunifuTextBox kontrola, BunifuLabel label = null)
        {
            bool flag = false;
            if (kontrola.Text.Any(char.IsDigit))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                if(label != null)
                {
                    label.Text = "Unos ne smije imati broj";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isBrojevi(BunifuTextBox kontrola, BunifuLabel label = null)
        {
            bool flag = false;
            if (!kontrola.Text.All(char.IsDigit))
            {
                if(label != null)
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                    label.Text = "Unos ne smije sadržavati slova";
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                }
                flag = true;
            }
            return flag;
        }
        private static bool isSarajevoEMail(BunifuTextBox kontrola, BunifuLabel label = null, Field polje = Field.BEZ)
        {
            bool flag = false;
            if (!kontrola.Text.Contains("fksarajevo.ba"))
            {
                if (polje == Field.KORISNICKO_IME)
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                }
                if (label != null)
                {
                    label.Text = "Mail mora biti na @fksarajevo.ba domeni";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isIspravanMail(BunifuTextBox kontrola, BunifuLabel label = null, Field polje = Field.BEZ)
        {
            var foo = new EmailAddressAttribute();
            bool flag = false;
            if (!foo.IsValid(kontrola.Text))
            {
                if (polje == Field.KORISNICKO_IME)
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                }
                if (label != null)
                {
                    label.Text = "Neispravan format";
                }
                flag = true;
            }
            return flag;
        }
        private static bool ValidacijaPAssword(BunifuTextBox kontrola, BunifuLabel label = null, Field polje = Field.BEZ)
        {
            bool flag = false;
            if (!kontrola.Text.Any(char.IsDigit))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                if (label != null)
                {
                    label.Text = "Lozinka mora uključivati brojeve";
                }
                flag = true;
            }
            if (!kontrola.Text.Any(char.IsUpper))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                if (label != null)
                {
                    label.Text = "Lozinka mora uključivati velika slova";
                }
                flag = true;
            }
            if (!kontrola.Text.Any(char.IsLower))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                if (label != null)
                {
                    label.Text = "Lozinka mora uključivati mala slova";
                }
                flag = true;
            }
            if (isSadrziSPecijalniKarakter(kontrola.Text))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                if (label != null)
                {
                    label.Text = "Lozinka mora uključivati specijalne karaktere";
                }
                flag = true;
            }
            return flag;
        }
        private static bool isSadrziSPecijalniKarakter(string tekst)
        {
            int brojac = 0;
            char[] specialCharacters = { '!', '@', '£', '$', '%', '^', '&', '*', '(', ')', '#', '€' };
            for (int i = 0; i < specialCharacters.Length; i++)
            {
                if (tekst.Contains(specialCharacters[i]))
                {
                    brojac++;
                }
            }
            if(brojac > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool isInRange(BunifuTextBox kontrola, BunifuLabel label = null, int broj1 = 0, int broj2 = 0)
        {
            bool flag = false;
            int praviBroj = Int32.Parse(kontrola.Text);
            if ((praviBroj < broj1 || praviBroj > broj2))
            {
                if(label != null)
                {
                    label.Text = "Unos mora biti u rangu od " + broj1 + " do " + broj2;
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                }
                else
                {
                    kontrola.RightIcon.Image = Properties.Resources.eBordo_error_izvjestaj;
                }
                flag = true;
            }
            return flag;
        }
        private static bool ValidirajSatnicu(BunifuTextBox kontrola, BunifuLabel label = null)
        {
            bool flag = false;
            if (kontrola.Text.Length != 5 || (!char.IsDigit(kontrola.Text[0]) || Int32.Parse(kontrola.Text[0].ToString()) > 2) ||
                (!char.IsDigit(kontrola.Text[1]) || Int32.Parse(kontrola.Text[1].ToString()) > 3) ||
                kontrola.Text[2].ToString() != ":" ||
                (!char.IsDigit(kontrola.Text[3]) || Int32.Parse(kontrola.Text[3].ToString()) > 5) ||
                (!char.IsDigit(kontrola.Text[4]) || Int32.Parse(kontrola.Text[4].ToString()) > 9))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                if(label != null)
                {
                    label.Text = "Neispravan format. Ispravan format je 00:00 - 23:59";
                }
                flag = true;
            }
            return flag;
        }
    }
}
