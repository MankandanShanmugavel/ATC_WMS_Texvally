namespace ATC_WMS.Master
{
    partial class frmMRPBarcode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMRP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblTrolleyRef = new System.Windows.Forms.Label();
            this.lblInvoiceRef = new System.Windows.Forms.Label();
            this.lblDeliveryOrder = new System.Windows.Forms.Label();
            this.lblSORef = new System.Windows.Forms.Label();
            this.txtSORef = new System.Windows.Forms.TextBox();
            this.txtDeliveryOrder = new System.Windows.Forms.TextBox();
            this.txtInvoiceRef = new System.Windows.Forms.TextBox();
            this.txtTrolleyRef = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.GVData = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeliveryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoDocEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutwardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrollyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrollyQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.GVData);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 475);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(936, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "&RePrint";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(936, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 30);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblMRP, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1010, 35);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // lblMRP
            // 
            this.lblMRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(105)))), ((int)(((byte)(5)))));
            this.lblMRP.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(49)))));
            this.lblMRP.Location = new System.Drawing.Point(3, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(1004, 35);
            this.lblMRP.TabIndex = 1;
            this.lblMRP.Text = "MRP Label Generation";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.48936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblState, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomer, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTrolleyRef, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInvoiceRef, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDeliveryOrder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSORef, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSORef, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDeliveryOrder, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtInvoiceRef, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTrolleyRef, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomer, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboState, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 67);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(807, 3);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 16);
            this.lblState.TabIndex = 26;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(642, 3);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(70, 16);
            this.lblCustomer.TabIndex = 25;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrolleyRef
            // 
            this.lblTrolleyRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrolleyRef.AutoSize = true;
            this.lblTrolleyRef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrolleyRef.Location = new System.Drawing.Point(489, 3);
            this.lblTrolleyRef.Name = "lblTrolleyRef";
            this.lblTrolleyRef.Size = new System.Drawing.Size(77, 16);
            this.lblTrolleyRef.TabIndex = 24;
            this.lblTrolleyRef.Text = "Trolley Ref";
            this.lblTrolleyRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInvoiceRef
            // 
            this.lblInvoiceRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvoiceRef.AutoSize = true;
            this.lblInvoiceRef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceRef.Location = new System.Drawing.Point(337, 3);
            this.lblInvoiceRef.Name = "lblInvoiceRef";
            this.lblInvoiceRef.Size = new System.Drawing.Size(81, 16);
            this.lblInvoiceRef.TabIndex = 23;
            this.lblInvoiceRef.Text = "Invoice Ref";
            this.lblInvoiceRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeliveryOrder
            // 
            this.lblDeliveryOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeliveryOrder.AutoSize = true;
            this.lblDeliveryOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryOrder.Location = new System.Drawing.Point(175, 3);
            this.lblDeliveryOrder.Name = "lblDeliveryOrder";
            this.lblDeliveryOrder.Size = new System.Drawing.Size(102, 16);
            this.lblDeliveryOrder.TabIndex = 22;
            this.lblDeliveryOrder.Text = "Delivery Order";
            this.lblDeliveryOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSORef
            // 
            this.lblSORef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSORef.AutoSize = true;
            this.lblSORef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSORef.Location = new System.Drawing.Point(50, 3);
            this.lblSORef.Name = "lblSORef";
            this.lblSORef.Size = new System.Drawing.Size(51, 16);
            this.lblSORef.TabIndex = 21;
            this.lblSORef.Text = "SO Ref";
            this.lblSORef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSORef
            // 
            this.txtSORef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSORef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSORef.Location = new System.Drawing.Point(3, 33);
            this.txtSORef.Name = "txtSORef";
            this.txtSORef.Size = new System.Drawing.Size(145, 23);
            this.txtSORef.TabIndex = 0;
            // 
            // txtDeliveryOrder
            // 
            this.txtDeliveryOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeliveryOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryOrder.Location = new System.Drawing.Point(154, 33);
            this.txtDeliveryOrder.Name = "txtDeliveryOrder";
            this.txtDeliveryOrder.Size = new System.Drawing.Size(145, 23);
            this.txtDeliveryOrder.TabIndex = 1;
            // 
            // txtInvoiceRef
            // 
            this.txtInvoiceRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceRef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceRef.Location = new System.Drawing.Point(305, 33);
            this.txtInvoiceRef.Name = "txtInvoiceRef";
            this.txtInvoiceRef.Size = new System.Drawing.Size(145, 23);
            this.txtInvoiceRef.TabIndex = 2;
            // 
            // txtTrolleyRef
            // 
            this.txtTrolleyRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrolleyRef.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrolleyRef.Location = new System.Drawing.Point(456, 33);
            this.txtTrolleyRef.Name = "txtTrolleyRef";
            this.txtTrolleyRef.Size = new System.Drawing.Size(143, 23);
            this.txtTrolleyRef.TabIndex = 3;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(605, 33);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(145, 23);
            this.txtCustomer.TabIndex = 4;
            // 
            // cboState
            // 
            this.cboState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "TN",
            "KL",
            "AP",
            "TS",
            "KA",
            "PY"});
            this.cboState.Location = new System.Drawing.Point(756, 33);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(146, 24);
            this.cboState.TabIndex = 5;
            // 
            // GVData
            // 
            this.GVData.AllowUserToAddRows = false;
            this.GVData.AllowUserToDeleteRows = false;
            this.GVData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.Select,
            this.DeliveryNo,
            this.InvoiceNo,
            this.CustomerName,
            this.Code,
            this.State,
            this.SaleOrder,
            this.DoDocEntry,
            this.OutwardId,
            this.PickId,
            this.TrollyNo,
            this.TrollyQuantity});
            this.GVData.Location = new System.Drawing.Point(10, 136);
            this.GVData.Name = "GVData";
            this.GVData.RowHeadersVisible = false;
            this.GVData.Size = new System.Drawing.Size(1002, 336);
            this.GVData.TabIndex = 16;
            this.GVData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVData_CellClick_1);
            // 
            // SNo
            // 
            this.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No";
            this.SNo.Name = "SNo";
            this.SNo.Width = 56;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.DataPropertyName = "Select";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            this.Select.DefaultCellStyle = dataGridViewCellStyle1;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Print";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.Text = "Print";
            this.Select.ToolTipText = "Print";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 34;
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeliveryNo.DataPropertyName = "DeliveryNo";
            this.DeliveryNo.HeaderText = "DC No";
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Width = 47;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Inv. No";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Width = 50;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Card Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 78;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 57;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.Width = 57;
            // 
            // SaleOrder
            // 
            this.SaleOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleOrder.DataPropertyName = "SaleOrder";
            this.SaleOrder.HeaderText = "SO No";
            this.SaleOrder.Name = "SaleOrder";
            this.SaleOrder.Width = 47;
            // 
            // DoDocEntry
            // 
            this.DoDocEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DoDocEntry.DataPropertyName = "DoDocEntry";
            this.DoDocEntry.HeaderText = "Do DocEntry";
            this.DoDocEntry.Name = "DoDocEntry";
            this.DoDocEntry.Visible = false;
            // 
            // OutwardId
            // 
            this.OutwardId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutwardId.DataPropertyName = "OutwardId";
            this.OutwardId.HeaderText = "Order Id";
            this.OutwardId.Name = "OutwardId";
            this.OutwardId.Width = 65;
            // 
            // PickId
            // 
            this.PickId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PickId.DataPropertyName = "PickId";
            this.PickId.HeaderText = "Picking Id";
            this.PickId.Name = "PickId";
            this.PickId.Width = 73;
            // 
            // TrollyNo
            // 
            this.TrollyNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrollyNo.DataPropertyName = "TrollyNo";
            this.TrollyNo.HeaderText = "Trolley No";
            this.TrollyNo.Name = "TrollyNo";
            this.TrollyNo.Width = 74;
            // 
            // TrollyQuantity
            // 
            this.TrollyQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrollyQuantity.DataPropertyName = "TrollyQuantity";
            this.TrollyQuantity.HeaderText = "Trolley Quantity";
            this.TrollyQuantity.Name = "TrollyQuantity";
            this.TrollyQuantity.Width = 96;
            // 
            // frmMRPBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 479);
            this.Controls.Add(this.panel1);
            this.Name = "frmMRPBarcode";
            this.Text = "frmMRPBarcode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMRPBarcode_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GVData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtTrolleyRef;
        private System.Windows.Forms.TextBox txtInvoiceRef;
        private System.Windows.Forms.TextBox txtSORef;
        private System.Windows.Forms.TextBox txtDeliveryOrder;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblTrolleyRef;
        private System.Windows.Forms.Label lblInvoiceRef;
        private System.Windows.Forms.Label lblDeliveryOrder;
        private System.Windows.Forms.Label lblSORef;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoDocEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutwardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrollyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrollyQuantity;
        private System.Windows.Forms.Button button1;
    }
}