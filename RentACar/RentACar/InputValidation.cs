using System;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjekatTVP
{
    internal class InputValidation
    {
        public static bool TextBoxesNotEmpty(Form form)
        {
            foreach (var control in form.Controls)
            {
                if (control is TextBox tb)
                {
                    if (string.IsNullOrEmpty(tb.Text))
                    {
                        MessageBox.Show("Morate popuniti sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        public static void ValidateString(Label showErrorString, TextBox inputString)
        {
           if (!string.IsNullOrEmpty(inputString.Text) && !Regex.IsMatch(inputString.Text, @"^[a-zA-Z\s]+$"))
            {
                showErrorString.Visible = true;
                showErrorString.Text = "Polje sme sadržati samo slova.";
            }
            else
            {
                showErrorString.Visible = false;
            }
        }
      
        //public static void ValidatePassword(Label showErrorPassword, TextBox inputPassword, Label? showConfirmErrorPassword2 = null, TextBox? confirmInputPassword2 = null)
        //{
        //    if (!string.IsNullOrEmpty(inputPassword.Text))
        //    {
        //        if (inputPassword.Text.Length < 6)
        //        {
        //            showErrorPassword.Visible = true;
        //            showErrorPassword.Text = "Lozinka mora sadržati najmanje 6 karaktera!";
        //        }
        //        else
        //        {
        //            showErrorPassword.Visible = false;
        //        }
        //    }

        //    if (showConfirmErrorPassword2 != null && confirmInputPassword2 != null && confirmInputPassword2.Focused)
        //    {
        //        if (!string.IsNullOrWhiteSpace(confirmInputPassword2.Text) && !string.IsNullOrWhiteSpace(inputPassword.Text))
        //        {
        //            if (inputPassword.Text != confirmInputPassword2.Text)
        //            {
        //                showConfirmErrorPassword2.Visible = true;
        //                showConfirmErrorPassword2.Text = "Lozinke se ne podudaraju!";
        //            }
        //            else
        //            {
        //                showConfirmErrorPassword2.Visible = false;
        //            }
        //        }
        //    }

        //}
        public static void ValidateIntegerNumber(Label showErrorInteger, TextBox inputInteger)
        {
            int parsedValue = 0;
            if (!string.IsNullOrEmpty(inputInteger.Text) && !int.TryParse(inputInteger.Text, out parsedValue))
            {
                showErrorInteger.Text = "Polje sme sadržati samo broj!";
                showErrorInteger.Visible = true;
                return;
            }
            else if (parsedValue < 0)
            {
                showErrorInteger.Text = "Broj mora biti pozitivan!";
                showErrorInteger.Visible = true;
                return;
            }
            else
                showErrorInteger.Visible = false;

        }
        public static void ValidateDoubleNumber(Label showErrorDouble, TextBox inputDouble)
        {
            Double parsedValue = 0; 
            if (!string.IsNullOrEmpty(inputDouble.Text) && !Double.TryParse(inputDouble.Text, out parsedValue))
            {
                showErrorDouble.Text = "Polje sme sadržati samo broj!";
                showErrorDouble.Visible = true;
                return;
            }
            else if (parsedValue < 0)
            {
                showErrorDouble.Text = "Broj mora biti pozitivan!";
                showErrorDouble.Visible = true;
                return;
            }
            else
                showErrorDouble.Visible = false;

        }
        public static void ValidateAddress(Label showErrorAddress, TextBox inputAddress)
        {
            string addressPattern = @"^[A-Za-z\s]+ \d+[1-9]\d*, [A-Za-z\s]+$";
            if (!string.IsNullOrEmpty(inputAddress.Text) && !Regex.IsMatch(inputAddress.Text, addressPattern))
            {
                showErrorAddress.Text = "Neispravan format. ";
                showErrorAddress.Visible = true;
                return;
            }
            else
            {
                showErrorAddress.Visible = false; 
            }
        }
        public static void ValidatePhoneNumber(Label showErrorPhone, TextBox inputPhone)
        {
            string phonePattern = @"^\+\d{1,4}\s\d{1,4}\s\d{4,14}$";
            if (!string.IsNullOrEmpty(inputPhone.Text) && !Regex.IsMatch(inputPhone.Text, phonePattern))
            {
                showErrorPhone.Text = "Neispravan format. ";
                showErrorPhone.Visible = true;
                return;
            }
            else
            {
                showErrorPhone.Visible = false;
            }
        }
        public static void ValidateStringInteger(Label showErrorStringInteger, TextBox inputStringInteger)
        {
            if (!string.IsNullOrEmpty(inputStringInteger.Text) && !Regex.IsMatch(inputStringInteger.Text, @"^[a-zA-Z\s\d-]+$"))
            {
                showErrorStringInteger.Visible = true;
                showErrorStringInteger.Text = "Nedozvoljen karakter.";
            }
            else
            {
                showErrorStringInteger.Visible = false;
            }
        }
        public static bool ValidDateRange(DateTimePicker pocetak, DateTimePicker kraj)
        {
            if (pocetak.Value > kraj.Value)
            {
                MessageBox.Show("Datum kraja ne sme biti pre datuma početka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
