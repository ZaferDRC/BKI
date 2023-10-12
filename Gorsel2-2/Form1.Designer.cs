namespace Gorsel2_2
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
            this.label_Kilo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_Erkek = new System.Windows.Forms.RadioButton();
            this.textBox_Kilo = new System.Windows.Forms.TextBox();
            this.picture_Zayif = new System.Windows.Forms.PictureBox();
            this.label_Boy = new System.Windows.Forms.Label();
            this.textBox_Boy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_Kadin = new System.Windows.Forms.RadioButton();
            this.label_Bki = new System.Windows.Forms.Label();
            this.picture_Obez = new System.Windows.Forms.PictureBox();
            this.picture_Normal = new System.Windows.Forms.PictureBox();
            this.picture_Kilolu = new System.Windows.Forms.PictureBox();
            this.label_Durum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Zayif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Obez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Kilolu)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Kilo
            // 
            this.label_Kilo.AutoSize = true;
            this.label_Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kilo.Location = new System.Drawing.Point(209, 104);
            this.label_Kilo.Name = "label_Kilo";
            this.label_Kilo.Size = new System.Drawing.Size(56, 25);
            this.label_Kilo.TabIndex = 0;
            this.label_Kilo.Text = "Kilo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(321, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_Erkek
            // 
            this.radio_Erkek.AutoSize = true;
            this.radio_Erkek.Location = new System.Drawing.Point(468, 109);
            this.radio_Erkek.Name = "radio_Erkek";
            this.radio_Erkek.Size = new System.Drawing.Size(63, 20);
            this.radio_Erkek.TabIndex = 2;
            this.radio_Erkek.TabStop = true;
            this.radio_Erkek.Text = "Erkek";
            this.radio_Erkek.UseVisualStyleBackColor = true;
            // 
            // textBox_Kilo
            // 
            this.textBox_Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kilo.Location = new System.Drawing.Point(321, 108);
            this.textBox_Kilo.Name = "textBox_Kilo";
            this.textBox_Kilo.Size = new System.Drawing.Size(100, 30);
            this.textBox_Kilo.TabIndex = 3;
            this.textBox_Kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kilo_KeyPress);
            // 
            // picture_Zayif
            // 
            this.picture_Zayif.Image = global::Gorsel2_2.Properties.Resources.zayif1;
            this.picture_Zayif.Location = new System.Drawing.Point(430, 332);
            this.picture_Zayif.Name = "picture_Zayif";
            this.picture_Zayif.Size = new System.Drawing.Size(100, 50);
            this.picture_Zayif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Zayif.TabIndex = 4;
            this.picture_Zayif.TabStop = false;
            // 
            // label_Boy
            // 
            this.label_Boy.AutoSize = true;
            this.label_Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Boy.Location = new System.Drawing.Point(209, 164);
            this.label_Boy.Name = "label_Boy";
            this.label_Boy.Size = new System.Drawing.Size(106, 25);
            this.label_Boy.TabIndex = 5;
            this.label_Boy.Text = "Boy (cm):";
            // 
            // textBox_Boy
            // 
            this.textBox_Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Boy.Location = new System.Drawing.Point(321, 164);
            this.textBox_Boy.Name = "textBox_Boy";
            this.textBox_Boy.Size = new System.Drawing.Size(100, 30);
            this.textBox_Boy.TabIndex = 6;
            this.textBox_Boy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Boy_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(209, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "DURUM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(209, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "BKİ:";
            // 
            // radio_Kadin
            // 
            this.radio_Kadin.AutoSize = true;
            this.radio_Kadin.Location = new System.Drawing.Point(468, 164);
            this.radio_Kadin.Name = "radio_Kadin";
            this.radio_Kadin.Size = new System.Drawing.Size(62, 20);
            this.radio_Kadin.TabIndex = 9;
            this.radio_Kadin.TabStop = true;
            this.radio_Kadin.Text = "Kadın";
            this.radio_Kadin.UseVisualStyleBackColor = true;
            // 
            // label_Bki
            // 
            this.label_Bki.AutoSize = true;
            this.label_Bki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Bki.Location = new System.Drawing.Point(337, 299);
            this.label_Bki.Name = "label_Bki";
            this.label_Bki.Size = new System.Drawing.Size(24, 25);
            this.label_Bki.TabIndex = 10;
            this.label_Bki.Text = "0";
            // 
            // picture_Obez
            // 
            this.picture_Obez.Image = global::Gorsel2_2.Properties.Resources.obez2;
            this.picture_Obez.Location = new System.Drawing.Point(431, 332);
            this.picture_Obez.Name = "picture_Obez";
            this.picture_Obez.Size = new System.Drawing.Size(100, 50);
            this.picture_Obez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Obez.TabIndex = 11;
            this.picture_Obez.TabStop = false;
            // 
            // picture_Normal
            // 
            this.picture_Normal.Image = global::Gorsel2_2.Properties.Resources.normal;
            this.picture_Normal.Location = new System.Drawing.Point(431, 332);
            this.picture_Normal.Name = "picture_Normal";
            this.picture_Normal.Size = new System.Drawing.Size(100, 50);
            this.picture_Normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Normal.TabIndex = 12;
            this.picture_Normal.TabStop = false;
            // 
            // picture_Kilolu
            // 
            this.picture_Kilolu.Image = global::Gorsel2_2.Properties.Resources.kilolu2;
            this.picture_Kilolu.Location = new System.Drawing.Point(431, 332);
            this.picture_Kilolu.Name = "picture_Kilolu";
            this.picture_Kilolu.Size = new System.Drawing.Size(100, 50);
            this.picture_Kilolu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Kilolu.TabIndex = 15;
            this.picture_Kilolu.TabStop = false;
            // 
            // label_Durum
            // 
            this.label_Durum.AutoSize = true;
            this.label_Durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Durum.Location = new System.Drawing.Point(337, 349);
            this.label_Durum.Name = "label_Durum";
            this.label_Durum.Size = new System.Drawing.Size(24, 25);
            this.label_Durum.TabIndex = 16;
            this.label_Durum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Durum);
            this.Controls.Add(this.picture_Kilolu);
            this.Controls.Add(this.picture_Normal);
            this.Controls.Add(this.picture_Obez);
            this.Controls.Add(this.label_Bki);
            this.Controls.Add(this.radio_Kadin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Boy);
            this.Controls.Add(this.label_Boy);
            this.Controls.Add(this.picture_Zayif);
            this.Controls.Add(this.textBox_Kilo);
            this.Controls.Add(this.radio_Erkek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Kilo);
            this.Name = "Form1";
            this.Text = "Beden Kitle Endeksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Zayif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Obez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Kilolu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Kilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_Erkek;
        private System.Windows.Forms.TextBox textBox_Kilo;
        private System.Windows.Forms.PictureBox picture_Zayif;
        private System.Windows.Forms.Label label_Boy;
        private System.Windows.Forms.TextBox textBox_Boy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_Kadin;
        private System.Windows.Forms.Label label_Bki;
        private System.Windows.Forms.PictureBox picture_Obez;
        private System.Windows.Forms.PictureBox picture_Normal;
        private System.Windows.Forms.PictureBox picture_Kilolu;
        private System.Windows.Forms.Label label_Durum;
    }
}

