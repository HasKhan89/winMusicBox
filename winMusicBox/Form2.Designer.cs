namespace winMusicBox
{
    partial class Form2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstResimler = new System.Windows.Forms.ListBox();
            this.pnlResimler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnArkaplanYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 243);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstResimler
            // 
            this.lstResimler.FormattingEnabled = true;
            this.lstResimler.Location = new System.Drawing.Point(12, 12);
            this.lstResimler.Name = "lstResimler";
            this.lstResimler.Size = new System.Drawing.Size(155, 225);
            this.lstResimler.TabIndex = 1;
            // 
            // pnlResimler
            // 
            this.pnlResimler.Location = new System.Drawing.Point(173, 12);
            this.pnlResimler.Name = "pnlResimler";
            this.pnlResimler.Size = new System.Drawing.Size(418, 323);
            this.pnlResimler.TabIndex = 2;
            // 
            // btnArkaplanYap
            // 
            this.btnArkaplanYap.Location = new System.Drawing.Point(11, 243);
            this.btnArkaplanYap.Name = "btnArkaplanYap";
            this.btnArkaplanYap.Size = new System.Drawing.Size(75, 23);
            this.btnArkaplanYap.TabIndex = 0;
            this.btnArkaplanYap.Text = "Seç";
            this.btnArkaplanYap.UseVisualStyleBackColor = true;
            this.btnArkaplanYap.Click += new System.EventHandler(this.btnArkaplanYap_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 347);
            this.Controls.Add(this.pnlResimler);
            this.Controls.Add(this.lstResimler);
            this.Controls.Add(this.btnArkaplanYap);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstResimler;
        private System.Windows.Forms.FlowLayoutPanel pnlResimler;
        private System.Windows.Forms.Button btnArkaplanYap;
    }
}