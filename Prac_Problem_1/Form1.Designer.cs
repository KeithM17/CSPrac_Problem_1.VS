namespace Prac_Problem_1
{
    partial class frmConverter
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.lblConverter = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvert.Location = new System.Drawing.Point(95, 208);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(126, 44);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbx2
            // 
            this.cbx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx2.Enabled = false;
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Location = new System.Drawing.Point(205, 160);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(87, 26);
            this.cbx2.TabIndex = 1;
            this.cbx2.SelectedIndexChanged += new System.EventHandler(this.cbx2_SelectedIndexChanged);
            // 
            // cbx1
            // 
            this.cbx1.AllowDrop = true;
            this.cbx1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Items.AddRange(new object[] {
            "ZAR",
            "USD",
            "EUR"});
            this.cbx1.Location = new System.Drawing.Point(27, 160);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(87, 24);
            this.cbx1.TabIndex = 3;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // lblConverter
            // 
            this.lblConverter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConverter.BackColor = System.Drawing.SystemColors.Control;
            this.lblConverter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConverter.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConverter.Location = new System.Drawing.Point(7, 9);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(306, 37);
            this.lblConverter.TabIndex = 4;
            this.lblConverter.Text = "Currency Converter";
            this.lblConverter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCurrency.Location = new System.Drawing.Point(114, 121);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(91, 23);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency:";
            // 
            // txbAmount
            // 
            this.txbAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbAmount.Location = new System.Drawing.Point(63, 83);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(190, 24);
            this.txbAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(114, 60);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(78, 20);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOutput.Location = new System.Drawing.Point(5, 10);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblOutput);
            this.panel1.Location = new System.Drawing.Point(16, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 43);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(137, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Into";
            // 
            // lblSymbol
            // 
            this.lblSymbol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(45, 86);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(0, 18);
            this.lblSymbol.TabIndex = 15;
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 322);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmConverter";
            this.Text = "Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSymbol;
    }
}

