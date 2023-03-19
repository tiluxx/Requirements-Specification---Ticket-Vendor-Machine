
namespace Search_Destination__TVM_
{
    partial class SelectTripForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTripForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tripSelectedGrd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creditCardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qrCodeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripSelectedGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tripSelectedGrd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your selected trip";
            // 
            // tripSelectedGrd
            // 
            this.tripSelectedGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tripSelectedGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tripSelectedGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripSelectedGrd.Location = new System.Drawing.Point(6, 21);
            this.tripSelectedGrd.Name = "tripSelectedGrd";
            this.tripSelectedGrd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tripSelectedGrd.RowTemplate.Height = 24;
            this.tripSelectedGrd.Size = new System.Drawing.Size(1062, 134);
            this.tripSelectedGrd.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qrCodeBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.creditCardBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1074, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // creditCardBtn
            // 
            this.creditCardBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.creditCardBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.creditCardBtn.Location = new System.Drawing.Point(398, 38);
            this.creditCardBtn.Name = "creditCardBtn";
            this.creditCardBtn.Size = new System.Drawing.Size(295, 38);
            this.creditCardBtn.TabIndex = 3;
            this.creditCardBtn.Text = "Credit Card";
            this.creditCardBtn.UseVisualStyleBackColor = false;
            this.creditCardBtn.Click += new System.EventHandler(this.creditCardBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose payment method";
            // 
            // qrCodeBtn
            // 
            this.qrCodeBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.qrCodeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.qrCodeBtn.Location = new System.Drawing.Point(398, 82);
            this.qrCodeBtn.Name = "qrCodeBtn";
            this.qrCodeBtn.Size = new System.Drawing.Size(295, 38);
            this.qrCodeBtn.TabIndex = 5;
            this.qrCodeBtn.Text = "Pay with QR Code";
            this.qrCodeBtn.UseVisualStyleBackColor = false;
            this.qrCodeBtn.Click += new System.EventHandler(this.qrCodeBtn_Click);
            // 
            // SelectTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectTripForm";
            this.Text = "Ticket Vendor Maching - Select Trip";
            this.Load += new System.EventHandler(this.SelectTripForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tripSelectedGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tripSelectedGrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button creditCardBtn;
        private System.Windows.Forms.Button qrCodeBtn;
        private System.Windows.Forms.Label label1;
    }
}