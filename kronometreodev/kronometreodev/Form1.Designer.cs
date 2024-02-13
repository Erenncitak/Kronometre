namespace kronometreodev
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
            this.btn_basla = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.btn_tur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_dakikasay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_saniyesay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_salisesay = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_salise = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_basla
            // 
            this.btn_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.Location = new System.Drawing.Point(27, 136);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(110, 48);
            this.btn_basla.TabIndex = 0;
            this.btn_basla.Text = "Başla";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durdur.Location = new System.Drawing.Point(143, 136);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(110, 48);
            this.btn_durdur.TabIndex = 1;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıfırla.Location = new System.Drawing.Point(259, 136);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(110, 48);
            this.btn_sıfırla.TabIndex = 2;
            this.btn_sıfırla.Text = "Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // btn_tur
            // 
            this.btn_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tur.Location = new System.Drawing.Point(375, 136);
            this.btn_tur.Name = "btn_tur";
            this.btn_tur.Size = new System.Drawing.Size(110, 48);
            this.btn_tur.TabIndex = 3;
            this.btn_tur.Text = "Tur";
            this.btn_tur.UseVisualStyleBackColor = true;
            this.btn_tur.Click += new System.EventHandler(this.btn_tur_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(458, 173);
            this.listBox1.TabIndex = 4;
            // 
            // lbl_dakikasay
            // 
            this.lbl_dakikasay.AutoSize = true;
            this.lbl_dakikasay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakikasay.Location = new System.Drawing.Point(103, 41);
            this.lbl_dakikasay.Name = "lbl_dakikasay";
            this.lbl_dakikasay.Size = new System.Drawing.Size(24, 25);
            this.lbl_dakikasay.TabIndex = 5;
            this.lbl_dakikasay.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // lbl_saniyesay
            // 
            this.lbl_saniyesay.AutoSize = true;
            this.lbl_saniyesay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniyesay.Location = new System.Drawing.Point(231, 41);
            this.lbl_saniyesay.Name = "lbl_saniyesay";
            this.lbl_saniyesay.Size = new System.Drawing.Size(24, 25);
            this.lbl_saniyesay.TabIndex = 7;
            this.lbl_saniyesay.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(304, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // lbl_salisesay
            // 
            this.lbl_salisesay.AutoSize = true;
            this.lbl_salisesay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_salisesay.Location = new System.Drawing.Point(362, 41);
            this.lbl_salisesay.Name = "lbl_salisesay";
            this.lbl_salisesay.Size = new System.Drawing.Size(24, 25);
            this.lbl_salisesay.TabIndex = 9;
            this.lbl_salisesay.Text = "0";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(79, 83);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(78, 25);
            this.lbl_dakika.TabIndex = 10;
            this.lbl_dakika.Text = "Dakika";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(206, 83);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(78, 25);
            this.lbl_saniye.TabIndex = 11;
            this.lbl_saniye.Text = "Saniye";
            // 
            // lbl_salise
            // 
            this.lbl_salise.AutoSize = true;
            this.lbl_salise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_salise.Location = new System.Drawing.Point(334, 83);
            this.lbl_salise.Name = "lbl_salise";
            this.lbl_salise.Size = new System.Drawing.Size(71, 25);
            this.lbl_salise.TabIndex = 12;
            this.lbl_salise.Text = "Salise";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.lbl_salise);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_salisesay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_saniyesay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dakikasay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_tur);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_basla);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Button btn_sıfırla;
        private System.Windows.Forms.Button btn_tur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_dakikasay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_saniyesay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_salisesay;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_salise;
        private System.Windows.Forms.Timer timer1;
    }
}

