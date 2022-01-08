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
        public static bool ValidirajInputString(BunifuTextBox kontrola, BunifuLabel label, Field polje)
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
                default:break;
            }
            if (isValidiran)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_success_notification;
                label.Text = "";
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
        public static bool ValidirajDatum(DateTime datum, BunifuLabel labelValidator, PictureBox pictureValidator, Field polje)
        {
            bool isValidiran = true;
            switch (polje)
            {
                case Field.DATUM_RODJENJA:
                    {
                        if (isDatumInRange(datum, labelValidator, pictureValidator, new DateTime(1975, 1, 1), new DateTime(2010, 1, 1)))
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
        private static bool isPrazanString(BunifuTextBox kontrola, BunifuLabel label)
        {
            bool flag = false;
            if (kontrola.Text.Length == 0)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_required3;
                label.Text = "Polje je obavezno";
                flag = true;
            }
            return flag;
        }
        private static bool isMinimalnoKaraktera(BunifuTextBox kontrola, BunifuLabel label, int brojKaraktera)
        {
            bool flag = false;
            if (kontrola.Text.Length < brojKaraktera)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Nedovoljan broj karaktera";
                flag = true;
            }
            return flag;
        }
        private static bool isOdredjenBrojKaraktera(BunifuTextBox kontrola, BunifuLabel label, int brojKaraktera)
        {
            bool flag = false;
            if (kontrola.Text.Length != brojKaraktera)
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                string poruka = "Broj mora imati " + brojKaraktera + " brojeva";
                label.Text = poruka;
                flag = true;
            }
            return flag;
        }
        private static bool isPrvoSlovoVeliko(BunifuTextBox kontrola, BunifuLabel label)
        {
            bool flag = false;
            if (!char.IsUpper(kontrola.Text[0]))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Unos mora počinjati velikim slovom";
                flag = true;
            }
            return flag;
        }
        private static bool isSadrziBroj(BunifuTextBox kontrola, BunifuLabel label)
        {
            bool flag = false;
            if (kontrola.Text.Any(char.IsDigit))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Unos ne smije imati broj";
                flag = true;
            }
            return flag;
        }
        private static bool isBrojevi(BunifuTextBox kontrola, BunifuLabel label)
        {
            bool flag = false;
            if (!kontrola.Text.All(char.IsDigit))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Unos ne smije sadržavati slova";
                flag = true;
            }
            return flag;
        }
        private static bool isIspravanMail(BunifuTextBox kontrola, BunifuLabel label)
        {
            var foo = new EmailAddressAttribute();
            bool flag = false;
            if (!foo.IsValid(kontrola.Text))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Neispravan format";
                flag = true;
            }
            return flag;
        }
        private static bool isInRange(BunifuTextBox kontrola, BunifuLabel label, int broj1, int broj2)
        {
            bool flag = false;
            int praviBroj = Int32.Parse(kontrola.Text);
            if ((praviBroj < broj1 || praviBroj > broj2))
            {
                kontrola.RightIcon.Image = Properties.Resources.eBordo_error_notification;
                label.Text = "Unos mora biti u rangu od " + broj1 + " do " + broj2;
                flag = true;
            }
            return flag;
        }
    }
}
