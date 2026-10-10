using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UIPShared
{
    public enum ValidationType
    {
        Code,
        Alphabets,
        Alphanumeric,
        WholeNumber,
        NegativeNumber,
        DecimalNumber,
        Address,
        PhoneNo,
        Email,
        Url,
        Password,
        None
    }
    public class Test
    {

    }
    public static class ValidationLibrary
    {
        private static string msg = string.Empty;
        /// <summary>
        /// Check whether the TextBox input is valid or not.
        /// </summary>
        /// <param name="vt">Validation type enumeration. Value might be (Code, Alphabets, Alphanumeric, WholeNumber, DecimalNumber, Address, PhoneNo, Email, Url, None)</param>
        /// <param name="filedName">Field name. For example: Phone number</param>
        /// <param name="tb">Name of the TextBox control.</param>
        /// <param name="isMandatory">Set whether the filed is mandatory or not.</param>
        /// <returns>If valid, returns true, otherwise false.</returns>
        public static bool IsValid(ValidationType vt, string filedName, TextBox tb, bool isMandatory)
        {
            string input = tb.Text.Trim();

            string pattern = string.Empty;
            if (!isMandatory && input.Length == 0)
                return true;
            Regex expression = new Regex("^[~!@#%&*();,._+-]+$");
            msg = filedName + " contains only special characters.";
            if (expression.IsMatch(input))
            {
                if (tb.Enabled)
                {
                    Shared.DisplayError(msg);

                    tb.Focus();
                    tb.SelectAll();
                }
                return false;
            }

            switch (vt)
            {
                case ValidationType.Code:
                    pattern = "^[0-9a-zA-Z-]+$";
                    break;
                case ValidationType.Alphabets:
                    pattern = "^[a-zA-Z-_.)(& ]+$";
                    break;
                case ValidationType.Alphanumeric:
                    pattern = "^[0-9a-zA-Z .-]+$";
                    break;
                case ValidationType.WholeNumber:
                    pattern = "^[0-9]+$";
                    break;
                case ValidationType.NegativeNumber:
                    pattern = "^[0-9-]+$";
                    break;
                case ValidationType.DecimalNumber:
                    pattern = "^[0-9.]+$";
                    break;
                case ValidationType.Address:
                    pattern = "^[0-9a-zA-Z .(-//) ,;#% &\n\r]+$";
                    break;
                case ValidationType.PhoneNo:
                    pattern = "^[0-9,+\\- ]+$";
                    break;
                case ValidationType.Email:
                    if (input.IndexOf('_') == 0)
                    {
                        msg = "Email id do not begin with underscore(_).";
                        Shared.DisplayError(msg);
                        return false;
                    }
                    pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
                    break;
                case ValidationType.Url:
                    pattern = @"[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~])*";
                    break;
                case ValidationType.None:
                    return isEmpty(filedName, tb);
            }

            if (input.Length > 0)
            {
                expression = new Regex(pattern);
                if (!expression.IsMatch(input))
                {
                    msg = filedName + " contain some invalid character(s) or invalid format.";
                    Shared.DisplayError(msg);
                    tb.Focus();
                    return false;
                }
            }
            else
            {
                return isEmpty(filedName, tb);

            }

            return true;

        }


        public static bool IsValid(ValidationType vt, string filedName, string inputString, bool isMandatory)
        {
            string input = inputString.Trim();

            string pattern = string.Empty;
            if (!isMandatory && input.Length == 0)
                return true;
            Regex expression = new Regex("^[~!@#%&*();,._+-]+$");
            msg = filedName + " contains only special characters.";
            if (expression.IsMatch(input))
            {
                Shared.DisplayError(msg);
                return false;
            }

            switch (vt)
            {
                case ValidationType.Code:
                    pattern = "^[0-9a-zA-Z-]+$";
                    break;
                case ValidationType.Alphabets:
                    pattern = "^[a-zA-Z-_.)(& ]+$";
                    break;
                case ValidationType.Alphanumeric:
                    pattern = "^[0-9a-zA-Z .-]+$";
                    break;
                case ValidationType.Password:
                    pattern = "^[0-9a-zA-Z .-@!$#%]+$";
                    break;
                case ValidationType.WholeNumber:
                    pattern = "^[0-9]+$";
                    break;
                case ValidationType.NegativeNumber:
                    pattern = "^[0-9-]+$";
                    break;
                case ValidationType.DecimalNumber:
                    pattern = "^[0-9.]+$";
                    break;
                case ValidationType.Address:
                    pattern = "^[0-9a-zA-Z .(-//) ,;#% &\n\r]+$";
                    break;
                case ValidationType.PhoneNo:
                    pattern = "^[0-9,+\\- ]+$";
                    break;
                case ValidationType.Email:
                    if (input.IndexOf('_') == 0)
                    {
                        msg = "Email id do not begin with underscore(_).";
                        Shared.DisplayError(msg);
                        return false;
                    }
                    pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
                    break;
                case ValidationType.Url:
                    pattern = @"[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~])*";
                    break;
                case ValidationType.None:
                    return isEmpty(filedName, input);
            }

            if (input.Length > 0)
            {
                expression = new Regex(pattern);
                if (!expression.IsMatch(input))
                {
                    msg = filedName + " contain some invalid character(s) or invalid format.";
                    Shared.DisplayError(msg);
                    return false;
                }
            }
            else
            {
                return isEmpty(filedName, input);

            }
            return true;
        }


        /// <summary>
        /// Check whether the item is selected or not from the dropdown list.
        /// </summary>
        /// <param name="fileName">Field name.</param>
        /// <param name="cb">Name of the ComboBox control.</param>
        /// <param name="isMandatory">Set whether the filed is mandatory or not.</param>
        /// <returns>If valid, returns true, otherwise false.</returns>
        public static bool IsSelected(string fileName, ComboBox cb, bool isMandatory)
        {
            if (!isMandatory)
                return true;
            if (cb.SelectedIndex == 0)
            {
                if (cb.Text == "--Select--")
                {
                    Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                    cb.Focus();
                    return false;
                }
                else if (cb.Text.Length == 0)
                {
                    Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                    cb.Focus();
                    return false;
                }
            }
            if (cb.SelectedIndex == -1)
            {
                if (cb.Text == "--Select--")
                {
                    Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                    cb.Focus();
                    return false;
                }
                else if (cb.Text.Length == 0)
                {
                    Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                    cb.Focus();
                    return false;
                }
            }
            if (cb.Text == "--Select--")
            {
                Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                cb.Focus();
                return false;
            }
            else if (cb.Text.Length == 0)
            {
                Shared.DisplayError("Select the " + fileName.ToLower() + " from the list.");
                cb.Focus();
                return false;
            }



            return true;

        }
        /// <summary>
        /// This is private Helper method.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool isEmpty(string fieldName, TextBox tb)
        {

            if (tb.Text.Trim().Length == 0)
            {
                msg = fieldName + " is empty. Required field cannot be left blank.";

                Shared.DisplayError(msg);
                tb.Focus();
                return false;
            }
            else
            {

                return true;
            }

        }
        public static bool isEmpty(string fieldName, string inputString)
        {

            if (inputString.Trim().Length == 0)
            {
                msg = fieldName + " is empty. Required field cannot be left blank.";
                Shared.DisplayError(msg);
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Change the TextBox backcolor to Red
        /// </summary>
        /// <param name="tb"></param>




        /// <summary>
        /// Check whether the given item is exist in item collection.
        /// </summary>
        /// <param name="cboInput">Name of the ComboBox.</param>
        public static bool IsItemExist(ComboBox cboInput)
        {
            if (cboInput.Text.Trim().Length == 0)
            {
                return true;
            }
            else
            {
                if (cboInput.FindStringExact(cboInput.Text) == -1)
                {
                    Shared.DisplayError("Given value ('" + cboInput.Text + "') doesn't exist in collection.");
                    cboInput.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Validate the given text box percentage value.  if value exceeds 100, it will clear the text box content.
        /// </summary>
        /// <param name="tb">Name of the TextBox</param>
        /// <param name="fieldName">Name of the field.</param>
        public static bool ValidatePercentage(TextBox tb, string fieldName)
        {
            decimal discount = Convert.ToDecimal(tb.Text);
            if (discount > 100)
            {
                Shared.DisplayError(fieldName + " percentage can't exceed 100");
                tb.Clear();
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool ValidateZero(TextBox tb, string fieldName)
        {
            if (tb.Text.Trim() == "0")
            {
                Shared.DisplayError(fieldName + " should be greater than zero");
                tb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
