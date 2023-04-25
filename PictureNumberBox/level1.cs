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

        PictureBox[] pictures; // level1
        PictureBox[] pictures2; // level2

        Point[] firstLocations = new Point[9]; // level1 lokasyonu
        Point[] firstLocations2 = new Point[16]; // level2 lokasyonu

        int sayac = 0;
        bool level2Aktif = false; // level2 açık kapalı olması

        private void Form1_Load(object sender, EventArgs e)
        {
            //level1 resimlerin gruplanması
            pictures = new PictureBox[] 
            { 
                pbSolUst, pbOrtaUst, pbSagUst, pbSolOrta, pbOrtaOrta, pbSagOrta, pbSolAlt, pbOrtaAlt, pbSolAlt,pbBos 
            };
            pbBos.Visible = false; //level1 boş olan resim

            //level1 resimlere tıklamayı pasif etme
            foreach (var picture in pictures)
            {
                picture.Enabled = false;
            }

            //level1 resimlerin ilk lokasyonunu kayıt etme
            for (int i = 0; i < 9; i++)
            {
                firstLocations[i] = pictures[i].Location;
            }

            //level2 resimleri gruplanması
            pictures2 = new PictureBox[]
            {
                pbA1,pbA2,pbA3,pbA4,pbB1,pbB2,pbB3,pbB4,pbC1,pbC2,pbC3,pbC4,pbD1,pbD2,pbD3,pbD4
            };
            
            //level2 resimlerin ilk konumlarını kayıt etme
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
                //level1 resimlere tıklamayı aktif etme
                foreach (var picture in pictures)
                {
                    picture.Enabled = true;
                }

                //level1 resimleri karıştırma
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
                pbD4.Visible = false; // level2 boş olan resim

                //level2 resimleri karıştırma
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
            movePicture((PictureBox)sender); //tıklanılan resmi hareket ettirme metodu

            int temp = 0;

            //level1 lokasyon doğrulama
            if (!level2Aktif)
            {
                for (int i = 0; i < 9; i++)
                {
                    //level1 birer birer lokasyon kontrolü
                    if (firstLocations[i] == pictures[i].Location)
                    {
                        temp++;
                    }
                    if (temp==9) //level1 lokasyonların hepsi doğru konumdaysa girilir
                    {
                        //level1 resimlere tıklamanın kapanması
                        foreach (var picture in pictures)
                        {
                        picture.Enabled = false;
                        }
                        pbBos.Visible = true; //boş olan resmin gözükmesi
                        lblNextLevel.Visible = true; //2.seviye  butonunun görünmesi
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);    
                    }
                }
            }
            else
            {
                //level2 lokasyon kontrolü
                for (int i = 0; i < 16; i++)
                {
                    //level2 birer birer lokasyon kontrolü
                    if (firstLocations2[i] == pictures2[i].Location)
                    {
                        temp++;
                    }
                    if (temp == 16) //level2 lokasyonların hepsi doğru konumdaysa girilir
                    {
                        //level2 resimlerin tıklmasının kapatılması
                        foreach (var picture in pictures2)
                        {
                            picture.Enabled = false;
                        }
                        pbD4.Visible = true; //level2 boş olan resmin gözükmesi
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
        }
        
        public void movePicture(PictureBox picture) //resimleri hareket ettirme
        {
            if (!level2Aktif)
            {
                //level1 tıklanılan resmin dört bir yanınında boş bölme kontrolü
                if (
                picture.Left + 120 == pbBos.Left && picture.Top == pbBos.Top ||
                picture.Left - 120 == pbBos.Left && picture.Top == pbBos.Top ||
                picture.Left == pbBos.Left && picture.Top - 120 == pbBos.Top ||
                picture.Left == pbBos.Left && picture.Top + 120 == pbBos.Top
               )
                {
                    //geçiçi lokasyon aktarımı
                    Point temp = picture.Location;      
                    picture.Location = pbBos.Location;  
                    pbBos.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }
            else
            {
                //level2 tıklanılan resmin dört bir yanınında boş bölme kontrolü
                if (
                picture.Left + 90 == pbD4.Left && picture.Top == pbD4.Top ||
                picture.Left - 90 == pbD4.Left && picture.Top == pbD4.Top ||
                picture.Left == pbD4.Left && picture.Top - 90 == pbD4.Top ||
                picture.Left == pbD4.Left && picture.Top + 90 == pbD4.Top
               )
                {
                    //geçiçi lokasyon aktarımı
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
            level2Aktif = true; //level2 butonu aktif
            btnStartRestart.Text = "Başla";
            
            //level1 resimleri kapanır
            foreach (var picture in pictures)
            {
                picture.Visible = false;
            }

            //level2 resimleri açılır
            foreach (var picture in pictures2)
            {
                picture.Visible = true;
            }
            lblNextLevel.Visible = false; //level2 butonu gizlenir
        }

        //level2 butonu stilleştirme
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
