namespace Agrii_1._0._0._0._1
{
    partial class Frm_StockEntry
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
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_batch = new System.Windows.Forms.Label();
            this.lbl_Expiry = new System.Windows.Forms.Label();
            this.lab_GST = new System.Windows.Forms.Label();
            this.cmb_ProductEN = new System.Windows.Forms.ComboBox();
            this.cmb_HSN = new System.Windows.Forms.ComboBox();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.cmb_Batch = new System.Windows.Forms.ComboBox();
            this.cmb_GSTper = new System.Windows.Forms.ComboBox();
            this.cmb_Expiry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_ProductEntryDetails = new System.Windows.Forms.DataGridView();
            this.DTP_EntryDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProductEntryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(346, 21);
            this.lbl_Heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(190, 24);
            this.lbl_Heading.TabIndex = 0;
            this.lbl_Heading.Text = "Product Entry Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Batch No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EXP. Date";
            // 
            // lbl_batch
            // 
            this.lbl_batch.AutoSize = true;
            this.lbl_batch.Location = new System.Drawing.Point(622, 89);
            this.lbl_batch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_batch.Name = "lbl_batch";
            this.lbl_batch.Size = new System.Drawing.Size(57, 13);
            this.lbl_batch.TabIndex = 7;
            this.lbl_batch.Text = "Open Cost";
            // 
            // lbl_Expiry
            // 
            this.lbl_Expiry.AutoSize = true;
            this.lbl_Expiry.Location = new System.Drawing.Point(50, 167);
            this.lbl_Expiry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Expiry.Name = "lbl_Expiry";
            this.lbl_Expiry.Size = new System.Drawing.Size(35, 13);
            this.lbl_Expiry.TabIndex = 9;
            this.lbl_Expiry.Text = "Expiry";
            // 
            // lab_GST
            // 
            this.lab_GST.AutoSize = true;
            this.lab_GST.Location = new System.Drawing.Point(169, 167);
            this.lab_GST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_GST.Name = "lab_GST";
            this.lab_GST.Size = new System.Drawing.Size(37, 13);
            this.lab_GST.TabIndex = 11;
            this.lab_GST.Text = "GST%";
            // 
            // cmb_ProductEN
            // 
            this.cmb_ProductEN.FormattingEnabled = true;
            this.cmb_ProductEN.Location = new System.Drawing.Point(52, 114);
            this.cmb_ProductEN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_ProductEN.Name = "cmb_ProductEN";
            this.cmb_ProductEN.Size = new System.Drawing.Size(149, 21);
            this.cmb_ProductEN.TabIndex = 13;
            // 
            // cmb_HSN
            // 
            this.cmb_HSN.FormattingEnabled = true;
            this.cmb_HSN.Location = new System.Drawing.Point(249, 114);
            this.cmb_HSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_HSN.Name = "cmb_HSN";
            this.cmb_HSN.Size = new System.Drawing.Size(149, 21);
            this.cmb_HSN.TabIndex = 14;
            // 
            // cmb_Company
            // 
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(428, 114);
            this.cmb_Company.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(149, 21);
            this.cmb_Company.TabIndex = 15;
            // 
            // cmb_Batch
            // 
            this.cmb_Batch.FormattingEnabled = true;
            this.cmb_Batch.Location = new System.Drawing.Point(620, 114);
            this.cmb_Batch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Batch.Name = "cmb_Batch";
            this.cmb_Batch.Size = new System.Drawing.Size(149, 21);
            this.cmb_Batch.TabIndex = 16;
            // 
            // cmb_GSTper
            // 
            this.cmb_GSTper.FormattingEnabled = true;
            this.cmb_GSTper.Location = new System.Drawing.Point(172, 192);
            this.cmb_GSTper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_GSTper.Name = "cmb_GSTper";
            this.cmb_GSTper.Size = new System.Drawing.Size(85, 21);
            this.cmb_GSTper.TabIndex = 17;
            // 
            // cmb_Expiry
            // 
            this.cmb_Expiry.FormattingEnabled = true;
            this.cmb_Expiry.Location = new System.Drawing.Point(52, 192);
            this.cmb_Expiry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Expiry.Name = "cmb_Expiry";
            this.cmb_Expiry.Size = new System.Drawing.Size(74, 21);
            this.cmb_Expiry.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Qty";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 20;
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(394, 193);
            this.txt_Rate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(52, 20);
            this.txt_Rate.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Basic Rate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 193);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rate";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(584, 193);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(52, 20);
            this.txt_Amount.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Amount";
            // 
            // DGV_ProductEntryDetails
            // 
            this.DGV_ProductEntryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ProductEntryDetails.Location = new System.Drawing.Point(22, 284);
            this.DGV_ProductEntryDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_ProductEntryDetails.Name = "DGV_ProductEntryDetails";
            this.DGV_ProductEntryDetails.RowHeadersWidth = 82;
            this.DGV_ProductEntryDetails.RowTemplate.Height = 33;
            this.DGV_ProductEntryDetails.Size = new System.Drawing.Size(778, 263);
            this.DGV_ProductEntryDetails.TabIndex = 27;
            // 
            // DTP_EntryDate
            // 
            this.DTP_EntryDate.Location = new System.Drawing.Point(693, 193);
            this.DTP_EntryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTP_EntryDate.Name = "DTP_EntryDate";
            this.DTP_EntryDate.Size = new System.Drawing.Size(102, 20);
            this.DTP_EntryDate.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "ENTRY DATE";
            // 
            // Frm_StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_EntryDate);
            this.Controls.Add(this.DGV_ProductEntryDetails);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Expiry);
            this.Controls.Add(this.cmb_GSTper);
            this.Controls.Add(this.cmb_Batch);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.cmb_HSN);
            this.Controls.Add(this.cmb_ProductEN);
            this.Controls.Add(this.lab_GST);
            this.Controls.Add(this.lbl_Expiry);
            this.Controls.Add(this.lbl_batch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Heading);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_StockEntry";
            this.Text = "Frm_StockEntry";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ProductEntryDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_batch;
        private System.Windows.Forms.Label lbl_Expiry;
        private System.Windows.Forms.Label lab_GST;
        private System.Windows.Forms.ComboBox cmb_ProductEN;
        private System.Windows.Forms.ComboBox cmb_HSN;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.ComboBox cmb_Batch;
        private System.Windows.Forms.ComboBox cmb_GSTper;
        private System.Windows.Forms.ComboBox cmb_Expiry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_ProductEntryDetails;
        private System.Windows.Forms.DateTimePicker DTP_EntryDate;
        private System.Windows.Forms.Label label8;
    }
}