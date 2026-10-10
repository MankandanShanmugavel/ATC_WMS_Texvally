namespace ATC_WMS.Master
{
    partial class frmMRPAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRPAuto));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTrolley = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtPartyType = new System.Windows.Forms.TextBox();
            this.PartyType = new System.Windows.Forms.Label();
            this.cboTableAssign = new System.Windows.Forms.ComboBox();
            this.txtDcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrolley = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDCDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRePrint = new System.Windows.Forms.Button();
            this.cbExport = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCNum = new System.Windows.Forms.TextBox();
            this.txtSAPDocnum = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxSTSelect = new System.Windows.Forms.CheckBox();
            this.txtOrderType = new System.Windows.Forms.TextBox();
            this.GVData = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurPackUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QULT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAPDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrolleyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxPrintSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BoxPrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1600, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTrolley
            // 
            this.lblTrolley.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrolley.AutoSize = true;
            this.lblTrolley.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrolley.Location = new System.Drawing.Point(361, 15);
            this.lblTrolley.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrolley.Name = "lblTrolley";
            this.lblTrolley.Size = new System.Drawing.Size(136, 29);
            this.lblTrolley.TabIndex = 5;
            this.lblTrolley.Text = "Trolley No";
            // 
            // lblMRP
            // 
            this.lblMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMRP.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.ForeColor = System.Drawing.Color.Yellow;
            this.lblMRP.Location = new System.Drawing.Point(4, 6);
            this.lblMRP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(1917, 62);
            this.lblMRP.TabIndex = 2;
            this.lblMRP.Text = "DC MRP Barcode Print";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.070707F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.775029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.36631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.009423F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.892815F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72085F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.07538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTable, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPartyType, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PartyType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTrolley, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboTableAssign, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDcNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboTrolley, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Code, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.State, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtState, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDCDate, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRePrint, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbExport, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 75);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1910, 129);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(4, 80);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(127, 29);
            this.lblYear.TabIndex = 30;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTable
            // 
            this.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(748, 15);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(119, 29);
            this.lblTable.TabIndex = 27;
            this.lblTable.Text = "Table No";
            // 
            // txtPartyType
            // 
            this.txtPartyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartyType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyType.Location = new System.Drawing.Point(505, 77);
            this.txtPartyType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPartyType.Name = "txtPartyType";
            this.txtPartyType.ReadOnly = true;
            this.txtPartyType.Size = new System.Drawing.Size(209, 35);
            this.txtPartyType.TabIndex = 4;
            // 
            // PartyType
            // 
            this.PartyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartyType.AutoSize = true;
            this.PartyType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyType.Location = new System.Drawing.Point(338, 80);
            this.PartyType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PartyType.Name = "PartyType";
            this.PartyType.Size = new System.Drawing.Size(159, 29);
            this.PartyType.TabIndex = 3;
            this.PartyType.Text = "PartyType";
            this.PartyType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTableAssign
            // 
            this.cboTableAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTableAssign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableAssign.FormattingEnabled = true;
            this.cboTableAssign.Location = new System.Drawing.Point(875, 13);
            this.cboTableAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTableAssign.Name = "cboTableAssign";
            this.cboTableAssign.Size = new System.Drawing.Size(162, 34);
            this.cboTableAssign.TabIndex = 2;
            // 
            // txtDcNo
            // 
            this.txtDcNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDcNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDcNo.Location = new System.Drawing.Point(139, 12);
            this.txtDcNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDcNo.Name = "txtDcNo";
            this.txtDcNo.Size = new System.Drawing.Size(136, 35);
            this.txtDcNo.TabIndex = 0;
            this.txtDcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDcNo_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "DC No";
            // 
            // cboTrolley
            // 
            this.cboTrolley.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrolley.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrolley.FormattingEnabled = true;
            this.cboTrolley.Location = new System.Drawing.Point(505, 13);
            this.cboTrolley.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrolley.Name = "cboTrolley";
            this.cboTrolley.Size = new System.Drawing.Size(209, 34);
            this.cboTrolley.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Code.AutoSize = true;
            this.Code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(1045, 80);
            this.Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(191, 29);
            this.Code.TabIndex = 6;
            this.Code.Text = "Price Code";
            this.Code.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // State
            // 
            this.State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(722, 80);
            this.State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(145, 29);
            this.State.TabIndex = 5;
            this.State.Text = "State";
            this.State.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(875, 77);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(162, 35);
            this.txtState.TabIndex = 7;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(1244, 77);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(145, 35);
            this.txtCode.TabIndex = 8;
            // 
            // CBYear
            // 
            this.CBYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Location = new System.Drawing.Point(139, 77);
            this.CBYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(136, 34);
            this.CBYear.TabIndex = 31;
            this.CBYear.SelectedIndexChanged += new System.EventHandler(this.CBYear_SelectedIndexChanged);
            this.CBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBYear_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1045, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "DC Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDCDate
            // 
            this.dtpDCDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDCDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDCDate.Location = new System.Drawing.Point(1243, 14);
            this.dtpDCDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDCDate.Name = "dtpDCDate";
            this.dtpDCDate.Size = new System.Drawing.Size(237, 32);
            this.dtpDCDate.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(1756, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Print";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRePrint
            // 
            this.btnRePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRePrint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePrint.ForeColor = System.Drawing.Color.White;
            this.btnRePrint.Location = new System.Drawing.Point(1756, 70);
            this.btnRePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(150, 49);
            this.btnRePrint.TabIndex = 5;
            this.btnRePrint.Text = "Reprint";
            this.btnRePrint.UseVisualStyleBackColor = false;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // cbExport
            // 
            this.cbExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbExport.AutoSize = true;
            this.cbExport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExport.Location = new System.Drawing.Point(1629, 78);
            this.cbExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(119, 33);
            this.cbExport.TabIndex = 28;
            this.cbExport.Text = "Export";
            this.cbExport.UseVisualStyleBackColor = true;
            this.cbExport.CheckedChanged += new System.EventHandler(this.cbExport_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.GVData);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblMRP);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1928, 754);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.28866F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.71134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDCNum, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSAPDocnum, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCardName, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbBoxSTSelect, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtOrderType, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 212);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1907, 52);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Order Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDCNum
            // 
            this.txtDCNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDCNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCNum.Location = new System.Drawing.Point(201, 8);
            this.txtDCNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDCNum.Name = "txtDCNum";
            this.txtDCNum.ReadOnly = true;
            this.txtDCNum.Size = new System.Drawing.Size(337, 35);
            this.txtDCNum.TabIndex = 34;
            // 
            // txtSAPDocnum
            // 
            this.txtSAPDocnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSAPDocnum.AutoSize = true;
            this.txtSAPDocnum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAPDocnum.Location = new System.Drawing.Point(4, 11);
            this.txtSAPDocnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSAPDocnum.Name = "txtSAPDocnum";
            this.txtSAPDocnum.Size = new System.Drawing.Size(189, 29);
            this.txtSAPDocnum.TabIndex = 33;
            this.txtSAPDocnum.Text = "DC NO";
            this.txtSAPDocnum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCardName
            // 
            this.txtCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(1667, 8);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.ReadOnly = true;
            this.txtCardName.Size = new System.Drawing.Size(236, 35);
            this.txtCardName.TabIndex = 2;
            this.txtCardName.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1524, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // cbBoxSTSelect
            // 
            this.cbBoxSTSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbBoxSTSelect.AutoSize = true;
            this.cbBoxSTSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxSTSelect.Location = new System.Drawing.Point(1374, 9);
            this.cbBoxSTSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoxSTSelect.Name = "cbBoxSTSelect";
            this.cbBoxSTSelect.Size = new System.Drawing.Size(142, 33);
            this.cbBoxSTSelect.TabIndex = 32;
            this.cbBoxSTSelect.Text = "SelectAll";
            this.cbBoxSTSelect.UseVisualStyleBackColor = true;
            // 
            // txtOrderType
            // 
            this.txtOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderType.Location = new System.Drawing.Point(735, 8);
            this.txtOrderType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderType.Name = "txtOrderType";
            this.txtOrderType.ReadOnly = true;
            this.txtOrderType.Size = new System.Drawing.Size(431, 35);
            this.txtOrderType.TabIndex = 36;
            // 
            // GVData
            // 
            this.GVData.AllowUserToAddRows = false;
            this.GVData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.PurPackUn,
            this.LineNum,
            this.CardName,
            this.QULT,
            this.ItemCode,
            this.SAPDocNum,
            this.Quantity,
            this.TrolleyCode,
            this.DeliveryNo,
            this.Size,
            this.MRP,
            this.BoxQuantity,
            this.Pack_Qty,
            this.PrinterName,
            this.BoxPrintSelect,
            this.BoxPrinterName});
            this.GVData.Location = new System.Drawing.Point(3, 265);
            this.GVData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GVData.Name = "GVData";
            this.GVData.RowHeadersVisible = false;
            this.GVData.RowHeadersWidth = 62;
            this.GVData.Size = new System.Drawing.Size(1927, 475);
            this.GVData.TabIndex = 5;
            this.GVData.TabStop = false;
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SNo.DataPropertyName = "SNO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.SNo.HeaderText = "SNo";
            this.SNo.MinimumWidth = 2;
            this.SNo.Name = "SNo";
            this.SNo.Width = 76;
            // 
            // PurPackUn
            // 
            this.PurPackUn.DataPropertyName = "PurPackUn";
            this.PurPackUn.HeaderText = "PurPackUn";
            this.PurPackUn.MinimumWidth = 8;
            this.PurPackUn.Name = "PurPackUn";
            this.PurPackUn.Visible = false;
            // 
            // LineNum
            // 
            this.LineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LineNum.DataPropertyName = "LineNum";
            this.LineNum.HeaderText = "Line Num";
            this.LineNum.MinimumWidth = 8;
            this.LineNum.Name = "LineNum";
            this.LineNum.Width = 112;
            // 
            // CardName
            // 
            this.CardName.DataPropertyName = "CardName";
            this.CardName.HeaderText = "Card Name";
            this.CardName.MinimumWidth = 8;
            this.CardName.Name = "CardName";
            // 
            // QULT
            // 
            this.QULT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QULT.DataPropertyName = "QULT";
            this.QULT.HeaderText = "Item Name";
            this.QULT.MinimumWidth = 8;
            this.QULT.Name = "QULT";
            this.QULT.Width = 123;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 8;
            this.ItemCode.Name = "ItemCode";
            // 
            // SAPDocNum
            // 
            this.SAPDocNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SAPDocNum.DataPropertyName = "SAPDocNum";
            this.SAPDocNum.HeaderText = "DC No";
            this.SAPDocNum.MinimumWidth = 8;
            this.SAPDocNum.Name = "SAPDocNum";
            this.SAPDocNum.Width = 92;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 104;
            // 
            // TrolleyCode
            // 
            this.TrolleyCode.DataPropertyName = "TrolleyCode";
            this.TrolleyCode.HeaderText = "Trolly No";
            this.TrolleyCode.MinimumWidth = 8;
            this.TrolleyCode.Name = "TrolleyCode";
            this.TrolleyCode.Visible = false;
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.DataPropertyName = "DCId";
            this.DeliveryNo.HeaderText = "Delivery ID";
            this.DeliveryNo.MinimumWidth = 8;
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Visible = false;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size.DataPropertyName = "Sizes";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 8;
            this.Size.Name = "Size";
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MRP.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MRP.DefaultCellStyle = dataGridViewCellStyle3;
            this.MRP.HeaderText = "MRP";
            this.MRP.MinimumWidth = 8;
            this.MRP.Name = "MRP";
            this.MRP.Width = 80;
            // 
            // BoxQuantity
            // 
            this.BoxQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BoxQuantity.DataPropertyName = "boxQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.BoxQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.BoxQuantity.HeaderText = "Box Qty";
            this.BoxQuantity.MinimumWidth = 8;
            this.BoxQuantity.Name = "BoxQuantity";
            // 
            // Pack_Qty
            // 
            this.Pack_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pack_Qty.DataPropertyName = "Pack_Qty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Pack_Qty.DefaultCellStyle = dataGridViewCellStyle5;
            this.Pack_Qty.HeaderText = "Pack_Qty";
            this.Pack_Qty.MinimumWidth = 8;
            this.Pack_Qty.Name = "Pack_Qty";
            this.Pack_Qty.Width = 113;
            // 
            // PrinterName
            // 
            this.PrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrinterName.DataPropertyName = "PrinterName";
            this.PrinterName.HeaderText = "Printer Name";
            this.PrinterName.MinimumWidth = 8;
            this.PrinterName.Name = "PrinterName";
            // 
            // BoxPrintSelect
            // 
            this.BoxPrintSelect.HeaderText = "Box Print Select";
            this.BoxPrintSelect.MinimumWidth = 8;
            this.BoxPrintSelect.Name = "BoxPrintSelect";
            // 
            // BoxPrinterName
            // 
            this.BoxPrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BoxPrinterName.DataPropertyName = "PrinterName1";
            this.BoxPrinterName.HeaderText = "Box Printer Name";
            this.BoxPrinterName.MinimumWidth = 8;
            this.BoxPrinterName.Name = "BoxPrinterName";
            // 
            // frmMRPAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 762);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMRPAuto";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTrolley;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GVData;
        private System.Windows.Forms.TextBox txtDcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrolley;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRePrint;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cboTableAssign;
        private System.Windows.Forms.CheckBox cbExport;
        private System.Windows.Forms.Label PartyType;
        private System.Windows.Forms.TextBox txtPartyType;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDCDate;
        private System.Windows.Forms.ComboBox CBYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDCNum;
        private System.Windows.Forms.Label txtSAPDocnum;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbBoxSTSelect;
        private System.Windows.Forms.TextBox txtOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurPackUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QULT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAPDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrolleyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrinterName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BoxPrintSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxPrinterName;
    }
}