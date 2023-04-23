using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureNumberBox
{
    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
            
        }

        PictureBox[] pictures;
        PictureBox[] pictures2;

        Point[] firstLocations = new Point[9];
        Point[] firstLocations2 = new Point[16];

        int sayac = 0;
        bool level2Aktif = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictures = new PictureBox[] 
            { 
                pbSolUst, pbOrtaUst, pbSagUst, pbSolOrta, pbOrtaOrta, pbSagOrta, pbSolAlt, pbOrtaAlt, pbSolAlt,pbBos 
            };
            pbBos.Visible = false;
            foreach (var picture in pictures)
            {
                picture.Enabled = false;
            }
            for (int i = 0; i < 9; i++)
            {
                firstLocations[i] = pictures[i].Location;
            }

            pictures2 = new PictureBox[]
            {
                pbA1,pbA2,pbA3,pbA4,pbB1,pbB2,pbB3,pbB4,pbC1,pbC2,pbC3,pbC4,pbD1,pbD2,pbD3,pbD4
            };
            foreach (var picture in pictures)
            {
                picture.Enabled = false;
            }
            for (int i = 0; i < 9; i++)
            {
                firstLocations[i] = pictures[i].Location;
            }
            for (int i = 0; i < 16; i++)
            {
                firstLocations2[i] = pictures2[i].Location;
            }

        }
        public void btnStartRestart_Click(object sender, EventArgs e)
        {
            btnStartRestart.Text = "Yeniden Oyna!";
            Random random = new Random();
            if (!level2Aktif)
            {
                pbBos.Visible = false;

                foreach (var picture in pictures)
                {
                    picture.Enabled = true;
                }
                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(8);
                    movePicture(pictures[pictureNo]);
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }
            else
            {
                pbD4.Visible = false;

                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(15);
                    movePicture(pictures2[pictureNo]);
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }
            

        }

        public void pbSolUst_Click(object sender, EventArgs e)
        {
            movePicture((PictureBox)sender);

            int temp = 0;
            if (!level2Aktif)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (firstLocations[i] == pictures[i].Location)
                    {
                        temp++;
                    }
                    if (temp==9)
                    {
                        foreach (var picture in pictures)
                        {
                        picture.Enabled = false;
                        }
                        pbBos.Visible = true;
                        lblNextLevel.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);    
                    }
                }
            }
            else
            {
                for (int i = 0; i < 16; i++)
                {
                    if (firstLocations2[i] == pictures2[i].Location)
                    {
                        temp++;
                    }
                    if (temp == 16)
                    {
                        foreach (var picture in pictures2)
                        {
                            picture.Enabled = false;
                        }
                        pbD4.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
        }
        
        public void movePicture(PictureBox picture)
        {
            if (!level2Aktif)
            {
                if (
                picture.Left + 120 == pbBos.Left && picture.Top == pbBos.Top ||
                picture.Left - 120 == pbBos.Left && picture.Top == pbBos.Top ||
                picture.Left == pbBos.Left && picture.Top - 120 == pbBos.Top ||
                picture.Left == pbBos.Left && picture.Top + 120 == pbBos.Top
               )
                {
                    Point temp = picture.Location;
                    picture.Location = pbBos.Location;
                    pbBos.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }
            else
            {
                if (
                picture.Left + 90 == pbD4.Left && picture.Top == pbD4.Top ||
                picture.Left - 90 == pbD4.Left && picture.Top == pbD4.Top ||
                picture.Left == pbD4.Left && picture.Top - 90 == pbD4.Top ||
                picture.Left == pbD4.Left && picture.Top + 90 == pbD4.Top
               )
                {
                    Point temp = picture.Location;
                    picture.Location = pbD4.Location;
                    pbD4.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }
        }

        private void lblNextLevel_Click(object sender, EventArgs e)
        {
            level2Aktif = true;
            btnStartRestart.Text = "Başla";
            foreach (var picture in pictures)
            {
                picture.Visible = false;
            }
            foreach (var picture in pictures2)
            {
                picture.Visible = true;
            }
            lblNextLevel.Visible = false;
        }

        private void lblNextLevel_MouseHover(object sender, EventArgs e)
        {
            lblNextLevel.ForeColor = Color.Green;
        }

        private void lblNextLevel_MouseLeave(object sender, EventArgs e)
        {
            lblNextLevel.ForeColor = Color.Black;
        }
    }
}
