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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] pictures;
        Point[] firstLocations = new Point[9];
        int sayac = 0;

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

        }
        private void btnStartRestart_Click(object sender, EventArgs e)
        {
            btnStartRestart.Text = "Yeniden Oyna!";
            sayac = 0;
            pbBos.Visible = false;

            foreach (var picture in pictures)
            {
                picture.Enabled = true;
            }
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int pictureNo = random.Next(8);
                movePicture(pictures[pictureNo]);
                sayac = -1;
            }

        }

        private void pbSolUst_Click(object sender, EventArgs e)
        {
            movePicture((PictureBox)sender);

            int temp = 0;
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
                    MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                }
            }
        }
        
        private void movePicture(PictureBox picture)
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

    }
}
