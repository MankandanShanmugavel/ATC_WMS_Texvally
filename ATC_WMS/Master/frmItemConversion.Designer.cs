namespace ATC_WMS.Master
{
    partial class frmItemConversion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GVData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtConversionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromRecQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalPrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxPrinterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblMRP);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 283);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.GVData);
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 192);
            this.panel2.TabIndex = 5;
            // 
            // GVData
            // 
            this.GVData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.FromDesc,
            this.FromCode,
            this.FromRecQty,
            this.ToDesc,
            this.ToCode,
            this.RecQty,
            this.NormalPrinterName,
            this.BoxPrinterName});
            this.GVData.Location = new System.Drawing.Point(0, 3);
            this.GVData.Name = "GVData";
            this.GVData.Size = new System.Drawing.Size(979, 189);
            this.GVData.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.21112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.51817F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtConversionId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSelectAll, 3, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 39);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(273, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtConversionId
            // 
            this.txtConversionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversionId.Location = new System.Drawing.Point(134, 6);
            this.txtConversionId.Name = "txtConversionId";
            this.txtConversionId.Size = new System.Drawing.Size(133, 27);
            this.txtConversionId.TabIndex = 5;
            this.txtConversionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConversionId_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conversion Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(354, 8);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(104, 23);
            this.cbSelectAll.TabIndex = 8;
            this.cbSelectAll.Text = "Select";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // lblMRP
            // 
            this.lblMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMRP.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.ForeColor = System.Drawing.Color.Yellow;
            this.lblMRP.Location = new System.Drawing.Point(0, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(985, 41);
            this.lblMRP.TabIndex = 3;
            this.lblMRP.Text = "Item to Item Conversion";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No";
            this.SNo.Name = "SNo";
            this.SNo.Width = 56;
            // 
            // FromDesc
            // 
            this.FromDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FromDesc.DataPropertyName = "FromDesc";
            this.FromDesc.HeaderText = "From Item Name";
            this.FromDesc.Name = "FromDesc";
            // 
            // FromCode
            // 
            this.FromCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FromCode.DataPropertyName = "FromCode";
            this.FromCode.HeaderText = "From Item Code";
            this.FromCode.Name = "FromCode";
            this.FromCode.Width = 97;
            // 
            // FromRecQty
            // 
            this.FromRecQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FromRecQty.DataPropertyName = "FromRecQty";
            this.FromRecQty.HeaderText = "From Item Qty";
            this.FromRecQty.Name = "FromRecQty";
            this.FromRecQty.Width = 75;
            // 
            // ToDesc
            // 
            this.ToDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ToDesc.DataPropertyName = "ToDesc";
            this.ToDesc.HeaderText = "To Item Name";
            this.ToDesc.Name = "ToDesc";
            this.ToDesc.Width = 91;
            // 
            // ToCode
            // 
            this.ToCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ToCode.DataPropertyName = "ToCode";
            this.ToCode.HeaderText = "To Item Code";
            this.ToCode.Name = "ToCode";
            this.ToCode.Width = 88;
            // 
            // RecQty
            // 
            this.RecQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RecQty.DataPropertyName = "RecQty";
            this.RecQty.HeaderText = "To Item Qty";
            this.RecQty.Name = "RecQty";
            this.RecQty.Width = 80;
            // 
            // NormalPrinterName
            // 
            this.NormalPrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NormalPrinterName.DataPropertyName = "NormalPrinterName";
            this.NormalPrinterName.HeaderText = "Normal Printer Name";
            this.NormalPrinterName.Name = "NormalPrinterName";
            this.NormalPrinterName.Width = 93;
            // 
            // BoxPrinterName
            // 
            this.BoxPrinterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BoxPrinterName.DataPropertyName = "BoxPrinterName";
            this.BoxPrinterName.HeaderText = "Box Printer Name";
            this.BoxPrinterName.Name = "BoxPrinterName";
            this.BoxPrinterName.Width = 105;
            // 
            // frmItemConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmItemConversion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConversionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GVData;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromRecQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalPrinterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxPrinterName;
    }
}