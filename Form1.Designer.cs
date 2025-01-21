namespace TaşKağıtMakasOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTaş = new System.Windows.Forms.Button();
            this.btnKağıt = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblGeriSay = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTekrarBaşlat = new System.Windows.Forms.Button();
            this.zamanSay = new System.Windows.Forms.Timer(this.components);
            this.pictureBilgisayar = new System.Windows.Forms.PictureBox();
            this.pictureOyuncu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOyuncu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaş
            // 
            this.btnTaş.Location = new System.Drawing.Point(61, 72);
            this.btnTaş.Name = "btnTaş";
            this.btnTaş.Size = new System.Drawing.Size(75, 23);
            this.btnTaş.TabIndex = 0;
            this.btnTaş.Text = "Taş";
            this.btnTaş.UseVisualStyleBackColor = true;
            this.btnTaş.Click += new System.EventHandler(this.btnTaş_Click);
            // 
            // btnKağıt
            // 
            this.btnKağıt.Location = new System.Drawing.Point(61, 150);
            this.btnKağıt.Name = "btnKağıt";
            this.btnKağıt.Size = new System.Drawing.Size(82, 27);
            this.btnKağıt.TabIndex = 1;
            this.btnKağıt.Text = "Kağıt";
            this.btnKağıt.UseVisualStyleBackColor = true;
            this.btnKağıt.Click += new System.EventHandler(this.btnKağıt_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.Location = new System.Drawing.Point(61, 221);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(75, 23);
            this.btnMakas.TabIndex = 2;
            this.btnMakas.Text = "Makas";
            this.btnMakas.UseVisualStyleBackColor = true;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(170, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oyuncu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.Location = new System.Drawing.Point(436, 72);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(208, 44);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "Oyıncu: 0-0 Bilgisayar";
            this.lblSkor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGeriSay
            // 
            this.lblGeriSay.Location = new System.Drawing.Point(436, 141);
            this.lblGeriSay.Name = "lblGeriSay";
            this.lblGeriSay.Size = new System.Drawing.Size(100, 23);
            this.lblGeriSay.TabIndex = 6;
            this.lblGeriSay.Text = "5";
            this.lblGeriSay.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTur
            // 
            this.lblTur.Location = new System.Drawing.Point(436, 261);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(100, 23);
            this.lblTur.TabIndex = 7;
            this.lblTur.Text = "Tur:3";
            this.lblTur.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(686, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilgisayar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnTekrarBaşlat
            // 
            this.btnTekrarBaşlat.Location = new System.Drawing.Point(757, 351);
            this.btnTekrarBaşlat.Name = "btnTekrarBaşlat";
            this.btnTekrarBaşlat.Size = new System.Drawing.Size(142, 51);
            this.btnTekrarBaşlat.TabIndex = 10;
            this.btnTekrarBaşlat.Text = "Tekrar Başlat";
            this.btnTekrarBaşlat.UseVisualStyleBackColor = true;
            this.btnTekrarBaşlat.Click += new System.EventHandler(this.btnTekrarBaşlat_Click);
            // 
            // zamanSay
            // 
            this.zamanSay.Interval = 5000;
            this.zamanSay.Tick += new System.EventHandler(this.ZamanSayEvent);
            // 
            // pictureBilgisayar
            // 
            this.pictureBilgisayar.Image = global::TaşKağıtMakasOyunu.Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;
            this.pictureBilgisayar.Location = new System.Drawing.Point(689, 79);
            this.pictureBilgisayar.Name = "pictureBilgisayar";
            this.pictureBilgisayar.Size = new System.Drawing.Size(210, 212);
            this.pictureBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBilgisayar.TabIndex = 8;
            this.pictureBilgisayar.TabStop = false;
            // 
            // pictureOyuncu
            // 
            this.pictureOyuncu.Image = global::TaşKağıtMakasOyunu.Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;
            this.pictureOyuncu.Location = new System.Drawing.Point(173, 61);
            this.pictureOyuncu.Name = "pictureOyuncu";
            this.pictureOyuncu.Size = new System.Drawing.Size(227, 222);
            this.pictureOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOyuncu.TabIndex = 3;
            this.pictureOyuncu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.btnTekrarBaşlat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBilgisayar);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblGeriSay);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureOyuncu);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKağıt);
            this.Controls.Add(this.btnTaş);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOyuncu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaş;
        private System.Windows.Forms.Button btnKağıt;
        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.PictureBox pictureOyuncu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblGeriSay;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBilgisayar;
        private System.Windows.Forms.Button btnTekrarBaşlat;
        private System.Windows.Forms.Timer zamanSay;
    }
}

