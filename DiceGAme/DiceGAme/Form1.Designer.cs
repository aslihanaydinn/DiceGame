namespace DiceGAme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_oyuncu1 = new System.Windows.Forms.Button();
            this.button_oyuncu2 = new System.Windows.Forms.Button();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_oyuncu1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_oyuncu2 = new System.Windows.Forms.Label();
            this.button_tekrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "OYUN KAÇ PUANDA BİTSİN?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(546, 9);
            this.txtPuan.Multiline = true;
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(198, 39);
            this.txtPuan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(445, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button_oyuncu1
            // 
            this.button_oyuncu1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_oyuncu1.Location = new System.Drawing.Point(17, 390);
            this.button_oyuncu1.Name = "button_oyuncu1";
            this.button_oyuncu1.Size = new System.Drawing.Size(299, 47);
            this.button_oyuncu1.TabIndex = 4;
            this.button_oyuncu1.Text = "Oyuncu1";
            this.button_oyuncu1.UseVisualStyleBackColor = true;
            this.button_oyuncu1.Click += new System.EventHandler(this.button_oyuncu1_Click);
            // 
            // button_oyuncu2
            // 
            this.button_oyuncu2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_oyuncu2.Location = new System.Drawing.Point(445, 390);
            this.button_oyuncu2.Name = "button_oyuncu2";
            this.button_oyuncu2.Size = new System.Drawing.Size(299, 47);
            this.button_oyuncu2.TabIndex = 5;
            this.button_oyuncu2.Text = "Oyuncu2";
            this.button_oyuncu2.UseVisualStyleBackColor = true;
            this.button_oyuncu2.Click += new System.EventHandler(this.button_oyuncu2_Click);
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(13, 358);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(72, 20);
            this.label_4.TabIndex = 6;
            this.label_4.Text = "Oyuncu1";
            // 
            // label_oyuncu1
            // 
            this.label_oyuncu1.AutoSize = true;
            this.label_oyuncu1.Location = new System.Drawing.Point(265, 358);
            this.label_oyuncu1.Name = "label_oyuncu1";
            this.label_oyuncu1.Size = new System.Drawing.Size(18, 20);
            this.label_oyuncu1.TabIndex = 7;
            this.label_oyuncu1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oyuncu2";
            // 
            // label_oyuncu2
            // 
            this.label_oyuncu2.AutoSize = true;
            this.label_oyuncu2.Location = new System.Drawing.Point(693, 358);
            this.label_oyuncu2.Name = "label_oyuncu2";
            this.label_oyuncu2.Size = new System.Drawing.Size(18, 20);
            this.label_oyuncu2.TabIndex = 9;
            this.label_oyuncu2.Text = "0";
            // 
            // button_tekrar
            // 
            this.button_tekrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tekrar.Location = new System.Drawing.Point(252, 470);
            this.button_tekrar.Name = "button_tekrar";
            this.button_tekrar.Size = new System.Drawing.Size(299, 47);
            this.button_tekrar.TabIndex = 10;
            this.button_tekrar.Text = "Oyuna Tekrar Başla";
            this.button_tekrar.UseVisualStyleBackColor = true;
            this.button_tekrar.Click += new System.EventHandler(this.button_tekrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oyuncu1 Kazandı";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_tekrar);
            this.Controls.Add(this.label_oyuncu2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_oyuncu1);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.button_oyuncu2);
            this.Controls.Add(this.button_oyuncu1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_oyuncu1;
        private System.Windows.Forms.Button button_oyuncu2;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_oyuncu1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_oyuncu2;
        private System.Windows.Forms.Button button_tekrar;
        private System.Windows.Forms.Label label2;
    }
}

