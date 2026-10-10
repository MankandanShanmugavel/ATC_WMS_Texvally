namespace ATC_WMS.Master
{
    partial class frmSampleRequestRePrint
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
            this.txtSAPDocNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Code = new System.Windows.Forms.Label();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSmallSticker = new System.Windows.Forms.RadioButton();
            this.rbMediumSticker = new System.Windows.Forms.RadioButton();
            this.rbLargeSticker = new System.Windows.Forms.RadioButton();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkPercentage = new System.Windows.Forms.CheckBox();
            this.chkMRP = new System.Windows.Forms.CheckBox();
            this.chkFR = new System.Windows.Forms.CheckBox();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.GVData = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SAPDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrolleyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSAPDocNo
            // 
            this.txtSAPDocNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSAPDocNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAPDocNo.Location = new System.Drawing.Point(91, 10);
            this.txtSAPDocNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAPDocNo.Name = "txtSAPDocNo";
            this.txtSAPDocNo.Size = new System.Drawing.Size(81, 30);
            this.txtSAPDocNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bill No";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Location = new System.Drawing.Point(1348, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(180, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(780, 10);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(129, 30);
            this.txtCode.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.46741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.98569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.42072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Code, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSAPDocNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBYear, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1502, 50);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // Code
            // 
            this.Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Code.AutoSize = true;
            this.Code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(619, 13);
            this.Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(153, 24);
            this.Code.TabIndex = 31;
            this.Code.Text = "Price Code";
            this.Code.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBYear
            // 
            this.CBYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Location = new System.Drawing.Point(388, 9);
            this.CBYear.Margin = new System.Windows.Forms.Padding(4);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(121, 31);
            this.CBYear.TabIndex = 36;
            // 
            // lblMRP
            // 
            this.lblMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMRP.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.ForeColor = System.Drawing.Color.Yellow;
            this.lblMRP.Location = new System.Drawing.Point(0, 3);
            this.lblMRP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(1505, 50);
            this.lblMRP.TabIndex = 3;
            this.lblMRP.Text = "Sample Request RePrint";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.GVData);
            this.panel1.Controls.Add(this.lblMRP);
            this.panel1.Location = new System.Drawing.Point(4, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 530);
            this.panel1.TabIndex = 28;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.78471F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.11469F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.rbSmallSticker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbMediumSticker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbLargeSticker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkSelectAll, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 115);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 39);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // rbSmallSticker
            // 
            this.rbSmallSticker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbSmallSticker.AutoSize = true;
            this.rbSmallSticker.Checked = true;
            this.rbSmallSticker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallSticker.Location = new System.Drawing.Point(281, 5);
            this.rbSmallSticker.Margin = new System.Windows.Forms.Padding(4);
            this.rbSmallSticker.Name = "rbSmallSticker";
            this.rbSmallSticker.Size = new System.Drawing.Size(87, 28);
            this.rbSmallSticker.TabIndex = 32;
            this.rbSmallSticker.TabStop = true;
            this.rbSmallSticker.Text = "Small";
            this.rbSmallSticker.UseVisualStyleBackColor = true;
            // 
            // rbMediumSticker
            // 
            this.rbMediumSticker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbMediumSticker.AutoSize = true;
            this.rbMediumSticker.Checked = true;
            this.rbMediumSticker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumSticker.Location = new System.Drawing.Point(128, 5);
            this.rbMediumSticker.Margin = new System.Windows.Forms.Padding(4);
            this.rbMediumSticker.Name = "rbMediumSticker";
            this.rbMediumSticker.Size = new System.Drawing.Size(112, 28);
            this.rbMediumSticker.TabIndex = 31;
            this.rbMediumSticker.TabStop = true;
            this.rbMediumSticker.Text = "Medium";
            this.rbMediumSticker.UseVisualStyleBackColor = true;
            // 
            // rbLargeSticker
            // 
            this.rbLargeSticker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbLargeSticker.AutoSize = true;
            this.rbLargeSticker.Checked = true;
            this.rbLargeSticker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLargeSticker.Location = new System.Drawing.Point(4, 5);
            this.rbLargeSticker.Margin = new System.Windows.Forms.Padding(4);
            this.rbLargeSticker.Name = "rbLargeSticker";
            this.rbLargeSticker.Size = new System.Drawing.Size(88, 28);
            this.rbLargeSticker.TabIndex = 30;
            this.rbLargeSticker.TabStop = true;
            this.rbLargeSticker.Text = "Large";
            this.rbLargeSticker.UseVisualStyleBackColor = true;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.Location = new System.Drawing.Point(408, 5);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(86, 28);
            this.chkSelectAll.TabIndex = 33;
            this.chkSelectAll.Text = "Select";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.chkPercentage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkMRP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkFR, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkExport, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(890, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(608, 42);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // chkPercentage
            // 
            this.chkPercentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkPercentage.AutoSize = true;
            this.chkPercentage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPercentage.Location = new System.Drawing.Point(169, 7);
            this.chkPercentage.Name = "chkPercentage";
            this.chkPercentage.Size = new System.Drawing.Size(132, 28);
            this.chkPercentage.TabIndex = 28;
            this.chkPercentage.Text = "Percentage";
            this.chkPercentage.UseVisualStyleBackColor = true;
            // 
            // chkMRP
            // 
            this.chkMRP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkMRP.AutoSize = true;
            this.chkMRP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMRP.Location = new System.Drawing.Point(79, 7);
            this.chkMRP.Name = "chkMRP";
            this.chkMRP.Size = new System.Drawing.Size(70, 28);
            this.chkMRP.TabIndex = 27;
            this.chkMRP.Text = "MRP";
            this.chkMRP.UseVisualStyleBackColor = true;
            // 
            // chkFR
            // 
            this.chkFR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkFR.AutoSize = true;
            this.chkFR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFR.Location = new System.Drawing.Point(399, 7);
            this.chkFR.Name = "chkFR";
            this.chkFR.Size = new System.Drawing.Size(54, 28);
            this.chkFR.TabIndex = 29;
            this.chkFR.Text = "FR";
            this.chkFR.UseVisualStyleBackColor = true;
            // 
            // chkExport
            // 
            this.chkExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkExport.AutoSize = true;
            this.chkExport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExport.Location = new System.Drawing.Point(516, 7);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(89, 28);
            this.chkExport.TabIndex = 30;
            this.chkExport.Text = "Export";
            this.chkExport.UseVisualStyleBackColor = true;
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
            this.Select,
            this.SAPDocNum,
            this.quality,
            this.ItemCode,
            this.quantity,
            this.TrolleyCode,
            this.DeliveryNo,
            this.u_size,
            this.TotalMRP,
            this.boxqty,
            this.Pack_Qty});
            this.GVData.Location = new System.Drawing.Point(0, 161);
            this.GVData.Margin = new System.Windows.Forms.Padding(4);
            this.GVData.Name = "GVData";
            this.GVData.RowHeadersVisible = false;
            this.GVData.Size = new System.Drawing.Size(1501, 347);
            this.GVData.TabIndex = 6;
            this.GVData.TabStop = false;
            this.GVData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVData_CellContentClick);
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
            this.SNo.ReadOnly = true;
            this.SNo.Width = 64;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 53;
            // 
            // SAPDocNum
            // 
            this.SAPDocNum.DataPropertyName = "SAPDocNum";
            this.SAPDocNum.HeaderText = "SAP_DocNum";
            this.SAPDocNum.Name = "SAPDocNum";
            this.SAPDocNum.Visible = false;
            // 
            // quality
            // 
            this.quality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quality.DataPropertyName = "quality";
            this.quality.HeaderText = "Item Name";
            this.quality.MinimumWidth = 8;
            this.quality.Name = "quality";
            this.quality.ReadOnly = true;
            this.quality.Width = 96;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 90;
            // 
            // TrolleyCode
            // 
            this.TrolleyCode.DataPropertyName = "TrolleyCode";
            this.TrolleyCode.HeaderText = "Trolly No";
            this.TrolleyCode.Name = "TrolleyCode";
            this.TrolleyCode.Visible = false;
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.DataPropertyName = "DCId";
            this.DeliveryNo.HeaderText = "Delivery ID";
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Visible = false;
            // 
            // u_size
            // 
            this.u_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.u_size.DataPropertyName = "u_size";
            this.u_size.HeaderText = "Size";
            this.u_size.Name = "u_size";
            this.u_size.ReadOnly = true;
            // 
            // TotalMRP
            // 
            this.TotalMRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalMRP.DataPropertyName = "TotalMRP";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalMRP.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalMRP.HeaderText = "MRP";
            this.TotalMRP.Name = "TotalMRP";
            this.TotalMRP.ReadOnly = true;
            this.TotalMRP.Width = 67;
            // 
            // boxqty
            // 
            this.boxqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.boxqty.DataPropertyName = "boxqty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.boxqty.DefaultCellStyle = dataGridViewCellStyle4;
            this.boxqty.HeaderText = "Box Qty/PrintQuantity";
            this.boxqty.Name = "boxqty";
            this.boxqty.Width = 157;
            // 
            // Pack_Qty
            // 
            this.Pack_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pack_Qty.DataPropertyName = "Pack_Qty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Pack_Qty.DefaultCellStyle = dataGridViewCellStyle5;
            this.Pack_Qty.HeaderText = "Pack_Qty";
            this.Pack_Qty.Name = "Pack_Qty";
            this.Pack_Qty.Visible = false;
            // 
            // frmSampleRequestRePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSampleRequestRePrint";
            this.Text = "frmSampleRequestRePrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSAPDocNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbSmallSticker;
        private System.Windows.Forms.RadioButton rbMediumSticker;
        private System.Windows.Forms.RadioButton rbLargeSticker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkPercentage;
        private System.Windows.Forms.CheckBox chkMRP;
        private System.Windows.Forms.CheckBox chkFR;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.DataGridView GVData;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAPDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrolleyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack_Qty;
        private System.Windows.Forms.ComboBox CBYear;
    }
}