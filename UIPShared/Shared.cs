using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace UIPShared
{
    public static class Shared
    {
        public static string SAVE_CONFIRMATION = "Do you want to save?";

        public static string UPDATE_CONFIRMATION = "Do you want to update?";

        public static string DELETE_CONFIRMATION = "The selected entry will be deleted.Do you want to continue?";

        public static string MESSAGEBOX_TITLE = "DWMS";

        public static string NOT_SYNCHRONIZED = "Synchronization is not yet done.";

        public static string ERROR_OCCURRED = "An error has occurred ";

        public static string SAVE = "&Save";
        public static string UPDATE = "&Update";

        public static string ERRORMSG_REPORT = "No data found in given criteria.";


        #region validation Patterns
        #endregion

        private static string connectionstring;

        public static string Connectionstring
        {
            get { return Shared.connectionstring; }
            set { Shared.connectionstring = value; }
        }
        private static string port;

        public static string Port
        {
            get { return Shared.port; }
            set { Shared.port = value; }
        }
        private static string bitRate;

        public static string BitRate
        {
            get { return Shared.bitRate; }
            set { Shared.bitRate = value; }
        }
        private static string databit;

        public static string Databit
        {
            get { return Shared.databit; }
            set { Shared.databit = value; }
        }
        private static string readTimeout;

        public static string ReadTimeout
        {
            get { return Shared.readTimeout; }
            set { Shared.readTimeout = value; }
        }
        private static string writeTimeout;

        public static string WriteTimeout
        {
            get { return Shared.writeTimeout; }
            set { Shared.writeTimeout = value; }
        }


        private static int orderid;

        public static int Orderid
        {
            get { return Shared.orderid; }
            set { Shared.orderid = value; }
        }


        private static DataTable roleActionDt;

        public static DataTable RoleActionDt
        {
            get { return Shared.roleActionDt; }
            set { Shared.roleActionDt = value; }
        }
        # region User Settings

        private static int _UserId;
        /// <summary>
        /// Gets or Sets the user Id.
        /// </summary>
        public static int UserId
        {
            get { return Shared._UserId; }
            set { Shared._UserId = value; }
        }
        private static string _PlantName;
        /// <summary>
        /// Gets or Sets the user Id.
        /// </summary>
        public static string PlantName
        {
            get { return Shared._PlantName; }
            set { Shared._PlantName = value; }
        }
        private static string shiftName;

        public static string ShiftName
        {
            get { return Shared.shiftName; }
            set { Shared.shiftName = value; }
        }


        private static string rolename;

        public static string Rolename
        {
            get { return Shared.rolename; }
            set { Shared.rolename = value; }
        }
        private static int shiftid;

        public static int Shiftid
        {
            get { return Shared.shiftid; }
            set { Shared.shiftid = value; }
        }

        private static long bUId;

        public static long BUId
        {
            get { return Shared.bUId; }
            set { Shared.bUId = value; }
        }


        private static int testid;

        public static int Testid
        {
            get { return Shared.testid; }
            set { Shared.testid = value; }
        }

        private static int _Plantid;
        /// <summary>
        /// Gets or Sets the user Id.
        /// </summary>
        public static int Plantid
        {
            get { return Shared._Plantid; }
            set { Shared._Plantid = value; }
        }
        private static string _UserName;

        /// <summary>
        /// Gets or Sets the Username.
        /// </summary>
        public static string UserName
        {
            get { return Shared._UserName; }
            set { Shared._UserName = value; }
        }

        private static int _RoleId;

        /// <summary>
        /// Gets or Sets the Username.
        /// </summary>
        public static int RoleId
        {
            get { return Shared._RoleId; }
            set { Shared._RoleId = value; }
        }

        private static string _Password;

        /// <summary>
        /// Gets or Sets the password.
        /// </summary>
        public static string Password
        {
            get { return Shared._Password; }
            set { Shared._Password = value; }
        }
        private static string _PanPassword;

        /// <summary>
        /// Gets or Sets the password.
        /// </summary>
        public static string PanPassword
        {
            get { return Shared._PanPassword; }
            set { Shared._PanPassword = value; }
        }
        private static string _EmployeeName;

        /// <summary>
        /// Gets or Sets the password.
        /// </summary>
        public static string EmployeeName
        {
            get { return Shared._EmployeeName; }
            set { Shared._EmployeeName = value; }
        }
        private static int yearId;

        public static int YearId
        {
            get { return Shared.yearId; }
            set { Shared.yearId = value; }
        }
        private static string yearname;

        public static string Yearname
        {
            get { return Shared.yearname; }
            set { Shared.yearname = value; }
        }

        private static string companyName;

        public static string CompanyName
        {
            get { return Shared.companyName; }
            set { Shared.companyName = value; }
        }

        private static string companyId;

        public static string CompanyId
        {
            get { return Shared.companyId; }
            set { Shared.companyId = value; }
        }

        private static string category;

        public static string Category
        {
            get { return Shared.category; }
            set { Shared.category = value; }
        }
        private static string locationid;

        public static string Locationid
        {
            get { return Shared.locationid; }
            set { Shared.locationid = value; }
        }


        private static string locationname;

        public static string Locationname
        {
            get { return Shared.locationname; }
            set { Shared.locationname = value; }
        }
        private static Color bGColor;

        public static Color BGColor
        {
            get { return Shared.bGColor; }
            set { Shared.bGColor = value; }
        }


        private static Color panColor;

        public static Color PanColor
        {
            get { return Shared.panColor; }
            set { Shared.panColor = value; }
        }
        private static Color panFColor;

        public static Color PanFColor
        {
            get { return Shared.panFColor; }
            set { Shared.panFColor = value; }
        }
        private static Color fColor;

        public static Color FColor
        {
            get { return Shared.fColor; }
            set { Shared.fColor = value; }
        }
        private static Font fFont;

        public static Font FFont
        {
            get { return Shared.fFont; }
            set { Shared.fFont = value; }
        }

        private static Color hColor;

        public static Color HColor
        {
            get { return Shared.hColor; }
            set { Shared.hColor = value; }
        }
        private static Font hFont;

        public static Font HFont
        {
            get { return Shared.hFont; }
            set { Shared.hFont = value; }
        }

        private static int dayid;

        public static int Dayid
        {
            get { return Shared.dayid; }
            set { Shared.dayid = value; }
        }

        private static Color footbcolor;

        public static Color Footbcolor
        {
            get { return Shared.footbcolor; }
            set { Shared.footbcolor = value; }
        }

        private static Color footFcolor;
        public static Color FootFcolor
        {
            get { return Shared.footFcolor; }
            set { Shared.footFcolor = value; }
        }

        private static Font footfont;

        public static Font Footfont
        {
            get { return Shared.footfont; }
            set { Shared.footfont = value; }
        }
        private static Color errorcolor;

        public static Color Errorcolor
        {
            get { return Shared.errorcolor; }
            set { Shared.errorcolor = value; }
        }

        private static Color sucesscolor;

        public static Color Sucesscolor
        {
            get { return Shared.sucesscolor; }
            set { Shared.sucesscolor = value; }
        }


        #endregion

        private static string _ApplicationPath;

        public static string ApplicationPath
        {
            get { return _ApplicationPath; }
            set { _ApplicationPath = value; }
        }
        private static int _Flag;

        public static int Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        private static string dvtime;

        public static string Dvtime
        {
            get { return Shared.dvtime; }
            set { Shared.dvtime = value; }
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }




        public static int GetSelectedRowCellValue(DataGridView dgv, int rowToSearch)
        {
            if (dgv.RowCount > 0)
            {
                DataGridViewRow row = dgv.CurrentRow;
                if (row != null)
                {
                    return Convert.ToInt32(row.Cells[rowToSearch].Value);

                }
                else
                {
                    return -1;
                }

            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Get confirmation dialog result.
        /// </summary>
        /// <returns>Returns True or False</returns>
        public static bool IsUpdateConfirmed()
        {
            if (MessageBox.Show(Shared.UPDATE_CONFIRMATION, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Get the Delete Confirmation.
        /// </summary>
        /// <returns>Returns True or False</returns>
        public static bool IsDeleteConfirmed()
        {
            if (MessageBox.Show(Shared.DELETE_CONFIRMATION, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;
            else
                return true;
        }


        public static bool IsConfirmed(string msg)
        {
            if (MessageBox.Show(msg, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;
            else
                return true;
        }

        public static bool IsSaveConfirmed()
        {
            if (MessageBox.Show(Shared.SAVE_CONFIRMATION, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Get Remove All Confiormation
        /// </summary>
        /// <returns></returns>
        public static bool IsRemoveAllConfirmed()
        {
            if (MessageBox.Show("Do you want to remove all items?", Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return false;
            else
                return true;
        }

        public static bool IsCreateConfirmed()
        {
            if (MessageBox.Show("Do you want to create now?", Shared.MESSAGEBOX_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;
            else
                return true;
        }


        public static bool IsTextBoxEmpty(TextBox txtInput)
        {
            if (txtInput.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }
        public static bool IsComboBoxEmpty(ComboBox cboInput)
        {
            if (cboInput.Text.Trim().Length == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Format the amount value the return formatted amount string
        /// </summary>
        /// <param name="amount">Amout value to Format</param>
        /// <returns>Formatted string</returns>
        public static string FormatAmount(decimal amount)
        {
            return string.Format("{0:0.000}", amount);
        }
        /// <summary>
        /// Format the amount value the return formatted amount string
        /// </summary>
        /// <param name="amount">Amount to Format.</param>
        /// <returns>Formatted string</returns>
        public static string FormatAmount(string amount)
        {
            decimal amt = Convert.ToDecimal(amount.Length == 0 ? 0 : Convert.ToDecimal(amount));
            return string.Format("{0:0.00}", amt);
        }


        public static string FormatDate(DateTime fromDate, DateTime toDate)
        {
            return "(FROM " + fromDate.ToString("dd/MMM/yyyy") + " TO " + toDate.ToString("dd/MMM/yyyy") + ")";
        }
        public static string FormatMonth(DateTime fromDate, DateTime toDate)
        {
            return "(FROM " + fromDate.ToString("MMM/yyyy") + " TO " + toDate.ToString("MMM/yyyy") + ")";
        }
        public static string FormatYear(DateTime fromDate, DateTime toDate)
        {
            return "(FROM " + fromDate.ToString("yyyy") + " TO " + toDate.ToString("yyyy") + ")";
        }
        /// <summary>
        /// Round up amount value
        /// </summary>
        /// <param name="amount">Amount to round up</param>
        /// <returns>Returns rounded up amount value.</returns>
        public static string RoundupAmount(string amount)
        {
            decimal amt = Convert.ToDecimal(amount.Length == 0 ? 0 : Convert.ToDecimal(amount));
            return string.Format("{0:0.00}", Math.Round(amt));
        }

        public static string FormatPercent(string percent)
        {
            decimal pt = Convert.ToDecimal(percent.Length == 0 ? 0 : Convert.ToDecimal(percent));
            return string.Format("{0:0}", pt);
        }

        /// <summary>
        /// Get the Integer value.
        /// </summary>
        /// <param name="txtCode">Name of the TextBox to retrieve value</param>
        /// <returns>Converted integer value.</returns>
        public static int GetInteger(TextBox txtCode)
        {
            return Convert.ToInt32(txtCode.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtCode.Text));
        }

        /// <summary>
        /// Get the Integer value.
        /// </summary>
        /// <param name="lblCode">Name of the Label to Retrieve value</param>
        /// <returns>Converted integer value.</returns>
        public static int GetInteger(Label lblCode)
        {
            return Convert.ToInt32(lblCode.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(lblCode.Text));
        }
        /// <summary>
        /// Get the Integer value.
        /// </summary>
        /// <param name="input">String to convert as Integer</param>
        /// <returns>Converted Integer value</returns>
        public static int GetInteger(string input)
        {
            return Convert.ToInt32(input.Trim().Length == 0 ? 0 : Convert.ToInt32(input));
        }

        /// <summary>
        /// Convert Input into decimal value
        /// </summary>
        /// <param name="txtCode">Name of the TextBox to retrive decimal value</param>
        /// <returns>Converted decimal value.</returns>
        public static decimal GetDecimalValue(TextBox txtCode)
        {
            return Convert.ToDecimal(txtCode.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(txtCode.Text));
        }
        /// <summary>
        /// Convert input into decimal value.
        /// </summary>
        /// <param name="input">String to convert as integer</param>
        /// <returns>Converted decimal value.</returns>
        public static decimal GetDecimalValue(string input)
        {
            return Convert.ToDecimal(input.Trim().Length == 0 ? 0 : Convert.ToDecimal(input));
        }

        public static string ParseColumnSize(string size)
        {
            return size.Replace("#", ".");
        }


        public static void CheckExistance(ComboBox cboInput)
        {
            if (cboInput.Text.Trim().Length == 0)
            {
                return;
            }
            else
            {
                if (cboInput.FindStringExact(cboInput.Text) == -1)
                {
                    Shared.DisplayError("Given value ['" + cboInput.Text + "'] doesn't exist in collection.");
                    cboInput.Focus();
                    return;
                }
                else
                {
                    return;
                }
            }
        }


        public static void SetDatePickerValue(DateTimePicker dtp)
        {

            dtp.Value = Convert.ToDateTime("01/" + DateTime.Today.Month + "/" + DateTime.Today.Year);

        }
        public static void DisplayError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ex.Message);
            WriteLog.CreateLog(ex);
            MessageBox.Show(sb.ToString(), Shared.MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayError(Exception ex, string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ex.Message);
            WriteLog.CreateLog(ex);
            MessageBox.Show(message, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayError(string msg)
        {
            try
            {
                MessageBox.Show(msg, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public static void DisplaySaveFailed(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ex.Message);
            WriteLog.CreateLog(ex);
            MessageBox.Show(sb.ToString(), Shared.MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayInformation(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(msg);
            MessageBox.Show(msg, Shared.MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DisplayUnhandledError(Exception ex)
        {
            WriteLog.CreateLog(ex);
        }

        public static void BindComboBox(ComboBox cboControl, DataTable dt, string field1, string field2)
        {



            for (int rowIndex = 0; rowIndex <= dt.Rows.Count - 1; rowIndex++)
            {
                cboControl.Items.Add(dt.Rows[rowIndex][field1].ToString());
            }
            if (dt.Rows.Count > 1)
                cboControl.SelectedIndex = 0;

        }
        public static void BindComboxsource(ComboBox Control, DataTable dt, string field1, string field2)
        {
            DataRow newCustomersRow = dt.NewRow();

            newCustomersRow[field1] = "0";
            newCustomersRow[field2] = "--Select--";
            dt.Rows.InsertAt(newCustomersRow, 0);
            Control.DataSource = dt;
            Control.DisplayMember = field2;
            Control.ValueMember = field1;
            //listControl.Items.Add("--Select--");

        }


        public static void BindComboxsourceAll(ComboBox Control, DataTable dt, string field1, string field2)
        {
            DataRow newCustomersRow = dt.NewRow();

            newCustomersRow[field1] = "0";
            newCustomersRow[field2] = "All";
            dt.Rows.InsertAt(newCustomersRow, 0);
            Control.DataSource = dt;
            Control.DisplayMember = field2;
            Control.ValueMember = field1;
            //listControl.Items.Add("--Select--");

        }
        public static void BindCombox(ComboBox Control, DataTable dt, string field1, string field2)
        {



            Control.DataSource = dt;
            Control.DisplayMember = field2;
            Control.ValueMember = field1;
            //listControl.Items.Add("--Select--");

        }


        public static DataTable SelectDistinct(DataTable SourceTable, params string[] FieldNames)
        {
            object[] lastValues;
            DataTable newTable;
            DataRow[] orderedRows;

            if (FieldNames == null || FieldNames.Length == 0)
                throw new ArgumentNullException("FieldNames");

            lastValues = new object[FieldNames.Length];
            newTable = new DataTable();

            foreach (string fieldName in FieldNames)
                newTable.Columns.Add(fieldName, SourceTable.Columns[fieldName].DataType);

            orderedRows = SourceTable.Select("", string.Join(", ", FieldNames));

            foreach (DataRow row in orderedRows)
            {
                if (!fieldValuesAreEqual(lastValues, row, FieldNames))
                {
                    newTable.Rows.Add(createRowClone(row, newTable.NewRow(), FieldNames));

                    setLastValues(lastValues, row, FieldNames);
                }
            }

            return newTable;
        }
        private static void setLastValues(object[] lastValues, DataRow sourceRow, string[] fieldNames)
        {
            for (int i = 0; i < fieldNames.Length; i++)
                lastValues[i] = sourceRow[fieldNames[i]];
        }

        private static bool fieldValuesAreEqual(object[] lastValues, DataRow currentRow, string[] fieldNames)
        {
            bool areEqual = true;

            for (int i = 0; i < fieldNames.Length; i++)
            {
                if (lastValues[i] == null || !lastValues[i].Equals(currentRow[fieldNames[i]]))
                {
                    areEqual = false;
                    break;
                }
            }

            return areEqual;
        }

        private static DataRow createRowClone(DataRow sourceRow, DataRow newRow, string[] fieldNames)
        {
            foreach (string field in fieldNames)
                newRow[field] = sourceRow[field];

            return newRow;
        }





        public static void BindListBox(ListBox listControl, DataTable dt, string field1, string field2)
        {
            listControl.DataSource = dt;
            listControl.DisplayMember = field1;
            listControl.ValueMember = field2;
            //listControl.Items.Add("--Select--");
        }


        /// <summary>
        /// Bind the combobox with the data source.
        /// </summary>
        /// <param name="cbo">Name of the ComboBox</param>
        /// <param name="data">List of bindingObjects</param>
        /// <param name="displayField">Name of the display field.</param>
        /// <param name="valueField">Name of the value field.</param>


        //Binding Items in Combobox
        public static void BindCollection(ComboBox cbo, DataView dv, string displayField)
        {
            cbo.Items.Add("<Select>");

            for (int itemIndex = 0; itemIndex <= dv.Count - 1; itemIndex++)
            {
                cbo.Items.Add(dv[itemIndex][displayField].ToString());
            }

            cbo.SelectedIndex = 0;

        }
        /// <summary>
        /// Bind the item if ComboBox not contins the item.
        /// </summary>
        /// <param name="cbo">Name of the ComboBox</param>
        /// <param name="newItem">The text to add the ComboBox.</param>
        public static void BindItem(ComboBox cbo, string newItem)
        {
            if (newItem.Trim().Length > 0)
            {
                if (!cbo.Items.Contains(newItem))
                {
                    cbo.Items.Add(newItem);
                }
                cbo.Text = newItem;
            }

        }
        /// <summary>
        /// Bind the control to auto suggest string collection.
        /// </summary>
        /// <param name="tb">Name of the TextBox.</param>
        /// <param name="dv">Dataview to extract data</param>
        /// <param name="fieldName">Name of the field to extract</param>
        /// <returns></returns>
        public static AutoCompleteStringCollection BindAutoCompleteStringCollection(TextBox tb, DataView dv, string fieldName)
        {
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            for (int index = 0; index < dv.Count; index++)
            {
                sc.Add(dv[index][fieldName].ToString());
            }

            tb.AutoCompleteCustomSource = sc;
            return sc;
        }
        public static AutoCompleteStringCollection BindAutoCompleteStringCollectionCombo(ComboBox tb, DataView dv, string fieldName)
        {
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            for (int index = 0; index < dv.Count; index++)
            {
                sc.Add(dv[index][fieldName].ToString());
            }

            tb.AutoCompleteCustomSource = sc;
            return sc;
        }

        /// <summary>
        /// Set the DateTimePicker controls year start date.
        /// </summary>
        /// <param name="dtp">Name of the DateTimePicker control.</param>
        public static void SetYearStartDate(DateTimePicker dtp)
        {
            //By default set date criteria to year to date.
            int days = DateTime.Now.DayOfYear - 1;
            dtp.Value = DateTime.Now.AddDays(-days);
        }

        public static void SetMonthToDate(DateTimePicker dtp)
        {
            //By default set date criteria to month to date.
            int days = DateTime.Now.Day - 1;
            dtp.Value = DateTime.Now.AddDays(-days);
        }
    }
}
