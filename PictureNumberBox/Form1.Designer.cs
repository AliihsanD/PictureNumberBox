
namespace PictureNumberBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartRestart = new System.Windows.Forms.Button();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSkorNumber = new System.Windows.Forms.Label();
            this.pnAlan = new System.Windows.Forms.Panel();
            this.pbBos = new System.Windows.Forms.PictureBox();
            this.pbOrtaUst = new System.Windows.Forms.PictureBox();
            this.pbSagUst = new System.Windows.Forms.PictureBox();
            this.pbSolOrta = new System.Windows.Forms.PictureBox();
            this.pbSolAlt = new System.Windows.Forms.PictureBox();
            this.pbSagOrta = new System.Windows.Forms.PictureBox();
            this.pbOrtaAlt = new System.Windows.Forms.PictureBox();
            this.pbOrtaOrta = new System.Windows.Forms.PictureBox();
            this.pbSolUst = new System.Windows.Forms.PictureBox();
            this.pnAlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSagUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolOrta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSagOrta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaOrta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolUst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartRestart
            // 
            this.btnStartRestart.BackColor = System.Drawing.Color.Olive;
            this.btnStartRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartRestart.FlatAppearance.BorderSize = 0;
            this.btnStartRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartRestart.Location = new System.Drawing.Point(48, 65);
            this.btnStartRestart.Name = "btnStartRestart";
            this.btnStartRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartRestart.Size = new System.Drawing.Size(360, 44);
            this.btnStartRestart.TabIndex = 0;
            this.btnStartRestart.Text = "Başla";
            this.btnStartRestart.UseVisualStyleBackColor = false;
            this.btnStartRestart.Click += new System.EventHandler(this.btnStartRestart_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.Transparent;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(44, 552);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(124, 39);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "Skor : ";
            // 
            // lblSkorNumber
            // 
            this.lblSkorNumber.AutoSize = true;
            this.lblSkorNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSkorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorNumber.Location = new System.Drawing.Point(161, 552);
            this.lblSkorNumber.Name = "lblSkorNumber";
            this.lblSkorNumber.Size = new System.Drawing.Size(37, 39);
            this.lblSkorNumber.TabIndex = 3;
            this.lblSkorNumber.Text = "0";
            // 
            // pnAlan
            // 
            this.pnAlan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnAlan.Controls.Add(this.pbBos);
            this.pnAlan.Controls.Add(this.pbOrtaUst);
            this.pnAlan.Controls.Add(this.pbSagUst);
            this.pnAlan.Controls.Add(this.pbSolOrta);
            this.pnAlan.Controls.Add(this.pbSolAlt);
            this.pnAlan.Controls.Add(this.pbSagOrta);
            this.pnAlan.Controls.Add(this.pbOrtaAlt);
            this.pnAlan.Controls.Add(this.pbOrtaOrta);
            this.pnAlan.Controls.Add(this.pbSolUst);
            this.pnAlan.Location = new System.Drawing.Point(48, 151);
            this.pnAlan.Name = "pnAlan";
            this.pnAlan.Size = new System.Drawing.Size(360, 360);
            this.pnAlan.TabIndex = 4;
            // 
            // pbBos
            // 
            this.pbBos.Image = ((System.Drawing.Image)(resources.GetObject("pbBos.Image")));
            this.pbBos.Location = new System.Drawing.Point(240, 240);
            this.pbBos.Margin = new System.Windows.Forms.Padding(0);
            this.pbBos.Name = "pbBos";
            this.pbBos.Size = new System.Drawing.Size(120, 120);
            this.pbBos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBos.TabIndex = 8;
            this.pbBos.TabStop = false;
            this.pbBos.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbOrtaUst
            // 
            this.pbOrtaUst.Image = ((System.Drawing.Image)(resources.GetObject("pbOrtaUst.Image")));
            this.pbOrtaUst.Location = new System.Drawing.Point(120, 0);
            this.pbOrtaUst.Margin = new System.Windows.Forms.Padding(0);
            this.pbOrtaUst.Name = "pbOrtaUst";
            this.pbOrtaUst.Size = new System.Drawing.Size(120, 120);
            this.pbOrtaUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrtaUst.TabIndex = 7;
            this.pbOrtaUst.TabStop = false;
            this.pbOrtaUst.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbSagUst
            // 
            this.pbSagUst.Image = ((System.Drawing.Image)(resources.GetObject("pbSagUst.Image")));
            this.pbSagUst.Location = new System.Drawing.Point(240, 0);
            this.pbSagUst.Margin = new System.Windows.Forms.Padding(0);
            this.pbSagUst.Name = "pbSagUst";
            this.pbSagUst.Size = new System.Drawing.Size(120, 120);
            this.pbSagUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSagUst.TabIndex = 6;
            this.pbSagUst.TabStop = false;
            this.pbSagUst.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbSolOrta
            // 
            this.pbSolOrta.Image = ((System.Drawing.Image)(resources.GetObject("pbSolOrta.Image")));
            this.pbSolOrta.Location = new System.Drawing.Point(0, 120);
            this.pbSolOrta.Margin = new System.Windows.Forms.Padding(0);
            this.pbSolOrta.Name = "pbSolOrta";
            this.pbSolOrta.Size = new System.Drawing.Size(120, 120);
            this.pbSolOrta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSolOrta.TabIndex = 5;
            this.pbSolOrta.TabStop = false;
            this.pbSolOrta.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbSolAlt
            // 
            this.pbSolAlt.Image = ((System.Drawing.Image)(resources.GetObject("pbSolAlt.Image")));
            this.pbSolAlt.Location = new System.Drawing.Point(0, 240);
            this.pbSolAlt.Margin = new System.Windows.Forms.Padding(0);
            this.pbSolAlt.Name = "pbSolAlt";
            this.pbSolAlt.Size = new System.Drawing.Size(120, 120);
            this.pbSolAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSolAlt.TabIndex = 4;
            this.pbSolAlt.TabStop = false;
            this.pbSolAlt.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbSagOrta
            // 
            this.pbSagOrta.Image = ((System.Drawing.Image)(resources.GetObject("pbSagOrta.Image")));
            this.pbSagOrta.Location = new System.Drawing.Point(240, 120);
            this.pbSagOrta.Margin = new System.Windows.Forms.Padding(0);
            this.pbSagOrta.Name = "pbSagOrta";
            this.pbSagOrta.Size = new System.Drawing.Size(120, 120);
            this.pbSagOrta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSagOrta.TabIndex = 3;
            this.pbSagOrta.TabStop = false;
            this.pbSagOrta.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbOrtaAlt
            // 
            this.pbOrtaAlt.Image = ((System.Drawing.Image)(resources.GetObject("pbOrtaAlt.Image")));
            this.pbOrtaAlt.Location = new System.Drawing.Point(120, 240);
            this.pbOrtaAlt.Margin = new System.Windows.Forms.Padding(0);
            this.pbOrtaAlt.Name = "pbOrtaAlt";
            this.pbOrtaAlt.Size = new System.Drawing.Size(120, 120);
            this.pbOrtaAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrtaAlt.TabIndex = 2;
            this.pbOrtaAlt.TabStop = false;
            this.pbOrtaAlt.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbOrtaOrta
            // 
            this.pbOrtaOrta.Image = ((System.Drawing.Image)(resources.GetObject("pbOrtaOrta.Image")));
            this.pbOrtaOrta.Location = new System.Drawing.Point(120, 120);
            this.pbOrtaOrta.Margin = new System.Windows.Forms.Padding(0);
            this.pbOrtaOrta.Name = "pbOrtaOrta";
            this.pbOrtaOrta.Size = new System.Drawing.Size(120, 120);
            this.pbOrtaOrta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrtaOrta.TabIndex = 1;
            this.pbOrtaOrta.TabStop = false;
            this.pbOrtaOrta.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // pbSolUst
            // 
            this.pbSolUst.Image = ((System.Drawing.Image)(resources.GetObject("pbSolUst.Image")));
            this.pbSolUst.Location = new System.Drawing.Point(0, 0);
            this.pbSolUst.Margin = new System.Windows.Forms.Padding(0);
            this.pbSolUst.Name = "pbSolUst";
            this.pbSolUst.Size = new System.Drawing.Size(120, 120);
            this.pbSolUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSolUst.TabIndex = 0;
            this.pbSolUst.TabStop = false;
            this.pbSolUst.Click += new System.EventHandler(this.pbSolUst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 660);
            this.Controls.Add(this.pnAlan);
            this.Controls.Add(this.lblSkorNumber);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.btnStartRestart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(472, 699);
            this.MinimumSize = new System.Drawing.Size(472, 699);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnAlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSagUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolOrta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSagOrta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrtaOrta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartRestart;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSkorNumber;
        private System.Windows.Forms.Panel pnAlan;
        private System.Windows.Forms.PictureBox pbOrtaUst;
        private System.Windows.Forms.PictureBox pbSagUst;
        private System.Windows.Forms.PictureBox pbSolOrta;
        private System.Windows.Forms.PictureBox pbSolAlt;
        private System.Windows.Forms.PictureBox pbSagOrta;
        private System.Windows.Forms.PictureBox pbOrtaAlt;
        private System.Windows.Forms.PictureBox pbOrtaOrta;
        private System.Windows.Forms.PictureBox pbSolUst;
        private System.Windows.Forms.PictureBox pbBos;
    }
}

