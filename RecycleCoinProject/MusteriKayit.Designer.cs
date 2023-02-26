namespace RecycleCoinProject
{
    partial class MusteriKayit
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
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmusteritoplam = new System.Windows.Forms.Label();
            this.lblOncekiSha = new System.Windows.Forms.Label();
            this.lblsha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnkayıtyap.Location = new System.Drawing.Point(215, 270);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(179, 49);
            this.btnkayıtyap.TabIndex = 31;
            this.btnkayıtyap.Text = "Kayıt Yap";
            this.btnkayıtyap.UseVisualStyleBackColor = false;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(215, 204);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(179, 36);
            this.txtsifre.TabIndex = 23;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(215, 120);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(179, 36);
            this.txtsoyad.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(215, 79);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(179, 36);
            this.txtad.TabIndex = 19;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(215, 162);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(179, 36);
            this.msktc.TabIndex = 21;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "TC Kimlik No:";
            // 
            // lblmusteritoplam
            // 
            this.lblmusteritoplam.AutoSize = true;
            this.lblmusteritoplam.Location = new System.Drawing.Point(10, 347);
            this.lblmusteritoplam.Name = "lblmusteritoplam";
            this.lblmusteritoplam.Size = new System.Drawing.Size(142, 28);
            this.lblmusteritoplam.TabIndex = 32;
            this.lblmusteritoplam.Text = "Musteri Sayisi";
            this.lblmusteritoplam.Visible = false;
            // 
            // lblOncekiSha
            // 
            this.lblOncekiSha.AutoSize = true;
            this.lblOncekiSha.Location = new System.Drawing.Point(8, 375);
            this.lblOncekiSha.Name = "lblOncekiSha";
            this.lblOncekiSha.Size = new System.Drawing.Size(144, 28);
            this.lblOncekiSha.TabIndex = 33;
            this.lblOncekiSha.Text = "oncekini Shası";
            this.lblOncekiSha.Visible = false;
            // 
            // lblsha
            // 
            this.lblsha.AutoSize = true;
            this.lblsha.Location = new System.Drawing.Point(28, 422);
            this.lblsha.Name = "lblsha";
            this.lblsha.Size = new System.Drawing.Size(62, 28);
            this.lblsha.TabIndex = 35;
            this.lblsha.Text = "Shası";
            this.lblsha.Visible = false;
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(453, 479);
            this.Controls.Add(this.lblsha);
            this.Controls.Add(this.lblOncekiSha);
            this.Controls.Add(this.lblmusteritoplam);
            this.Controls.Add(this.btnkayıtyap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusteriKayit";
            this.Text = "MusteriKayit";
            this.Load += new System.EventHandler(this.MusteriKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayıtyap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmusteritoplam;
        private System.Windows.Forms.Label lblOncekiSha;
        private System.Windows.Forms.Label lblsha;
    }
}