namespace ATC_WMS
{
    partial class frmDecodeEncode
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
            this.txtResulted = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDecoded = new System.Windows.Forms.Button();
            this.btnEncoded = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResulted
            // 
            this.txtResulted.Location = new System.Drawing.Point(241, 145);
            this.txtResulted.Name = "txtResulted";
            this.txtResulted.Size = new System.Drawing.Size(100, 20);
            this.txtResulted.TabIndex = 0;
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(55, 61);
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(100, 20);
            this.txtEncoded.TabIndex = 1;
            // 
            // txtDecoded
            // 
            this.txtDecoded.Location = new System.Drawing.Point(464, 64);
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(100, 20);
            this.txtDecoded.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDecoded);
            this.panel2.Controls.Add(this.btnEncoded);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtResulted);
            this.panel2.Controls.Add(this.txtEncoded);
            this.panel2.Controls.Add(this.txtDecoded);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 268);
            this.panel2.TabIndex = 3;
            // 
            // btnDecoded
            // 
            this.btnDecoded.Location = new System.Drawing.Point(489, 90);
            this.btnDecoded.Name = "btnDecoded";
            this.btnDecoded.Size = new System.Drawing.Size(75, 23);
            this.btnDecoded.TabIndex = 7;
            this.btnDecoded.Text = "Decode";
            this.btnDecoded.UseVisualStyleBackColor = true;
            this.btnDecoded.Click += new System.EventHandler(this.btnDecoded_Click);
            // 
            // btnEncoded
            // 
            this.btnEncoded.Location = new System.Drawing.Point(55, 87);
            this.btnEncoded.Name = "btnEncoded";
            this.btnEncoded.Size = new System.Drawing.Size(75, 23);
            this.btnEncoded.TabIndex = 6;
            this.btnEncoded.Text = "Encode";
            this.btnEncoded.UseVisualStyleBackColor = true;
            this.btnEncoded.Click += new System.EventHandler(this.btnEncoded_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decode";
            // 
            // frmDecodeEncode
            // 
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.panel2);
            this.Name = "frmDecodeEncode";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Decode;
        private System.Windows.Forms.Label lblEncode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResulted;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecoded;
        private System.Windows.Forms.Button btnEncoded;
    }
}