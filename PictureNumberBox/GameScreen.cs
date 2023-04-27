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
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
            
        }

        PictureBox[] picturesLevel1; //Level 1 resimleri   3x3
        PictureBox[] picturesLevel2; //Level 2 resimleri   3x4
        PictureBox[] picturesLevel3; //Level 3 resimleri   4x4
        PictureBox[] picturesLevel4; //Level 4 resimleri   5x5

        Point[] firstLocationLevel1 = new Point[9];  //Level 1 ilk konum 
        Point[] firstLocationLevel2 = new Point[12]; //Level 2 ilk konum
        Point[] firstLocationLevel3 = new Point[16]; //Level 3 ilk konum
        Point[] firstLocationLevel4 = new Point[25]; //Level 4 ilk konum

        int sayac = 0;

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Resimleri Gruplandırma
            //Level 1 3x3
            picturesLevel1 = new PictureBox[]
            {
                pbLvl1A1, pbLvl1A2, pbLvl1A3,
                pbLvl1B1, pbLvl1B2, pbLvl1B3,
                pbLvl1C1, pbLvl1C2, pbLvl1Empty // <--Boş kutucuk
            };
            //Level 2 3x4
            picturesLevel2 = new PictureBox[]
            {
                pbLvl2A1, pbLvl2A2, pbLvl2A3, pbLvl2A4,
                pbLvl2B1, pbLvl2B2, pbLvl2B3, pbLvl2B4,
                pbLvl2C1, pbLvl2C2, pbLvl2C3, pbLvl2Empty // <--Boş kutucuk
            };
            //Level 3 4x4
            picturesLevel3 = new PictureBox[]
            {
                pbLvl3A1, pbLvl3A2, pbLvl3A3, pbLvl3A4,
                pbLvl3B1, pbLvl3B2, pbLvl3B3, pbLvl3B4,
                pbLvl3C1, pbLvl3C2, pbLvl3C3, pbLvl3C4,
                pbLvl3D1, pbLvl3D2, pbLvl3D3, pbLvl3Empty // <--Boş kutucuk
            };
            //level 3 5x5
            picturesLevel4 = new PictureBox[]
            {
                pbLvl4A1, pbLvl4A2, pbLvl4A3, pbLvl4A4, pbLvl4A5,
                pbLvl4B1, pbLvl4B2, pbLvl4B3, pbLvl4B4, pbLvl4B5,
                pbLvl4C1, pbLvl4C2, pbLvl4C3, pbLvl4C4, pbLvl4C5,
                pbLvl4D1, pbLvl4D2, pbLvl4D3, pbLvl4D4, pbLvl4D5,
                pbLvl4E1, pbLvl4E2, pbLvl4E3, pbLvl4E4, pbLvl4Empty // <--Boş kutucuk
            };
            locationSave(); //İlk lokasyonu kayıt etme
            allLevelsVisible(); // <--- Tüm levelleri gizleme
            //Level 1 açma
            foreach (var picture in picturesLevel1)
            {
                picture.Visible = true;
            }
            closeEnable();
        }
        public void locationSave()
        {
            for (int i = 0; i < 25; i++)
            {
                if (i<9)
                {
                    firstLocationLevel1[i] = picturesLevel1[i].Location; //Level 1 lokasyonu
                }
                if (i<12)
                {
                    firstLocationLevel2[i] = picturesLevel2[i].Location; //Level 2 lokasyonu
                }
                if (i<16)
                {
                    firstLocationLevel3[i] = picturesLevel3[i].Location; //Level 3 lokasyonu
                }
                firstLocationLevel4[i] = picturesLevel4[i].Location;     //Level 4 lokasyonu
            }
        }
        public void btnStartRestart_Click(object sender, EventArgs e)
        {
            btnStartRestart.Text = "Yeniden Oyna!";
            resetGame();
            //Son kutuları boşaltma
            pbLvl1Empty.Visible = false;
            pbLvl2Empty.Visible = false;
            pbLvl3Empty.Visible = false;
            pbLvl4Empty.Visible = false;
            sayac = 0;
            lblSkorNumber.Text = sayac.ToString();
            openEnable();
            mixPicture();
        }
        private void mixPicture()
        {
            Random random = new Random();
            int lvlcheck = levelCheck();
            if (lvlcheck == 1)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(8);
                    movePicture(picturesLevel1[pictureNo]); //1000 kere rastgele oynuyor
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }        //Level 1 karıştır
            else if (lvlcheck == 2)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(11);
                    movePicture(picturesLevel2[pictureNo]); //1000 kere rastgele oynuyor
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }   //Level 2 karıştır
            else if (lvlcheck == 3)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(15);
                    movePicture(picturesLevel3[pictureNo]); //1000 kere rastgele oynuyor
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }   //Level 3 karıştır
            else if (lvlcheck == 4)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int pictureNo = random.Next(24);
                    movePicture(picturesLevel4[pictureNo]); //1000 kere rastgele oynuyor
                }
                sayac = 0;
                lblSkorNumber.Text = sayac.ToString();
            }   //Level 4 karıştır
        } //Resimleri karıştırır
        public void pictureClick(object sender,EventArgs e)
        {
            movePicture((PictureBox)sender);

            int temp = 0;
            int lvlcheck = levelCheck();
            if (lvlcheck == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (firstLocationLevel1[i] == picturesLevel1[i].Location)
                    {
                        temp++;
                    }
                    if (temp==9)
                    {
                        closeEnable();
                        pbLvl1Empty.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
            else if (lvlcheck == 2)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (firstLocationLevel2[i] == picturesLevel2[i].Location)
                    {
                        temp++;
                    }
                    if (temp == 12)
                    {
                        closeEnable();
                        pbLvl2Empty.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
            else if (lvlcheck == 3)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (firstLocationLevel3[i] == picturesLevel3[i].Location)
                    {
                        temp++;
                    }
                    if (temp == 16)
                    {
                        closeEnable();
                        pbLvl3Empty.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
            else if (lvlcheck == 4)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (firstLocationLevel4[i] == picturesLevel4[i].Location)
                    {
                        temp++;
                    }
                    if (temp == 25)
                    {
                        closeEnable();
                        pbLvl4Empty.Visible = true;
                        MessageBox.Show("Tebrikler Skorunuz : " + lblSkorNumber.Text);
                    }
                }
            }
        }
        public void movePicture(PictureBox picture) //Resimleri hareket ettirme metodu
        {
            int lvlcheck = levelCheck();     //Level sorgusu
            if (lvlcheck == 1)
            {
                if (
                picture.Left + 120 == pbLvl1Empty.Left && picture.Top == pbLvl1Empty.Top || //üst sağ sol aşağı boş kutucu kontrolü
                picture.Left - 120 == pbLvl1Empty.Left && picture.Top == pbLvl1Empty.Top ||
                picture.Left == pbLvl1Empty.Left && picture.Top - 120 == pbLvl1Empty.Top ||
                picture.Left == pbLvl1Empty.Left && picture.Top + 120 == pbLvl1Empty.Top
                )
                {
                    Point temp = picture.Location; // geçiçi lokasyon aktarımı
                    picture.Location = pbLvl1Empty.Location;
                    pbLvl1Empty.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }            //Level 1 Hareket
            else if (lvlcheck == 2)
            {
                if (
                picture.Left + 90 == pbLvl2Empty.Left && picture.Top == pbLvl2Empty.Top || //üst sağ sol aşağı boş kutucu kontrolü
                picture.Left - 90 == pbLvl2Empty.Left && picture.Top == pbLvl2Empty.Top ||
                picture.Left == pbLvl2Empty.Left && picture.Top - 120 == pbLvl2Empty.Top ||
                picture.Left == pbLvl2Empty.Left && picture.Top + 120 == pbLvl2Empty.Top
                )
                {
                    Point temp = picture.Location; // geçiçi lokasyon aktarımı
                    picture.Location = pbLvl2Empty.Location;
                    pbLvl2Empty.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }       //Level 2 Hareket
            else if (lvlcheck == 3)
            {
                if (
                picture.Left + 90 == pbLvl3Empty.Left && picture.Top == pbLvl3Empty.Top || //üst sağ sol aşağı boş kutucu kontrolü
                picture.Left - 90 == pbLvl3Empty.Left && picture.Top == pbLvl3Empty.Top ||
                picture.Left == pbLvl3Empty.Left && picture.Top - 90 == pbLvl3Empty.Top ||
                picture.Left == pbLvl3Empty.Left && picture.Top + 90 == pbLvl3Empty.Top
                )
                {
                    Point temp = picture.Location; // geçiçi lokasyon aktarımı
                    picture.Location = pbLvl3Empty.Location;
                    pbLvl3Empty.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }       //Level 3 Hareket
            else if (lvlcheck == 4)
            {
                if (
                picture.Left + 72 == pbLvl4Empty.Left && picture.Top == pbLvl4Empty.Top || //üst sağ sol aşağı boş kutucu kontrolü
                picture.Left - 72 == pbLvl4Empty.Left && picture.Top == pbLvl4Empty.Top ||
                picture.Left == pbLvl4Empty.Left && picture.Top - 72 == pbLvl4Empty.Top ||
                picture.Left == pbLvl4Empty.Left && picture.Top + 72 == pbLvl4Empty.Top
                )
                {
                    Point temp = picture.Location; // geçiçi lokasyon aktarımı
                    picture.Location = pbLvl4Empty.Location;
                    pbLvl4Empty.Location = temp;
                    sayac++;
                    lblSkorNumber.Text = sayac.ToString();
                }
            }       //Level 4 Hareket

        }
        private void allLevelsVisible()
        {
            //Level 1 gizleme
            foreach (var picture in picturesLevel1)
            {
                picture.Visible = false;
            }
            //Level 2 gizleme
            foreach (var picture in picturesLevel2)
            {
                picture.Visible = false;
            }
            //Level 3 gizleme
            foreach (var picture in picturesLevel3)
            {
                picture.Visible = false;
            }
            //Level 4 gizleme
            foreach (var picture in picturesLevel4)
            {
                picture.Visible = false;
            }
        }
        private void lblNext_Click(object sender, EventArgs e)
        {
            if (lblLevelName.Text != "Level 4") // Son sayfada çalışma
            {
                allLevelsVisible(); // <-- Tüm levelleri gizleme
                sayac = 0; // Sayacı sıfırla
                lblSkorNumber.Text = sayac.ToString();
            }
            // Hangi sayfaya geçiceği bulunma
            if (lblLevelName.Text == "Level 1")
            {
                foreach (var picture in picturesLevel2)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 2";
                resetGame(); //Oyunu sıfırla
            }
            else if (lblLevelName.Text == "Level 2")
            {
                foreach (var picture in picturesLevel3)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 3";
                resetGame(); //Oyunu sıfırla
            }
            else if (lblLevelName.Text == "Level 3")
            {
                foreach (var picture in picturesLevel4)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 4";
                resetGame(); //Oyunu sıfırla
            }
        }
        private int levelCheck()
        {
            if (lblLevelName.Text == "Level 1")
            {
                return 1;
            }
            else if (lblLevelName.Text == "Level 2")
            {
                return 2;
            }
            else if (lblLevelName.Text == "Level 3")
            {
                return 3;
            }
            else if (lblLevelName.Text == "Level 4")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private void openEnable()  //Resimlerin tıklamasını açma
        {
            foreach (var picture in picturesLevel1)
            {
                picture.Enabled = true;
            }
            foreach (var picture in picturesLevel2)
            {
                picture.Enabled = true;
            }
            foreach (var picture in picturesLevel3)
            {
                picture.Enabled = true;
            }
            foreach (var picture in picturesLevel4)
            {
                picture.Enabled = true;
            }
        }
        private void closeEnable() //Resimlerin tıklaması kapama
        {
            foreach (var picture in picturesLevel1)
            {
                picture.Enabled = false;
            }
            foreach (var picture in picturesLevel2)
            {
                picture.Enabled = false;
            }
            foreach (var picture in picturesLevel3)
            {
                picture.Enabled = false;
            }
            foreach (var picture in picturesLevel4)
            {
                picture.Enabled = false;
            }
        }
        private void lblPervious_Click(object sender, EventArgs e)
        {
            if (lblLevelName.Text != "Level 1") // İlk sayfada çalışma
            {
                allLevelsVisible(); // <-- Tüm levelleri gizleme
                sayac = 0; // Sayacı sıfırla
                lblSkorNumber.Text = sayac.ToString();
            }
            // Hangi sayfaya geçiceği bulunma
            if (lblLevelName.Text == "Level 2")
            {
                foreach (var picture in picturesLevel1)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 1";
                resetGame(); //Oyunu sıfırla
            }
            else if (lblLevelName.Text == "Level 3")
            {
                foreach (var picture in picturesLevel2)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 2";
                resetGame(); //Oyunu sıfırla
            }
            else if (lblLevelName.Text == "Level 4")
            {
                foreach (var picture in picturesLevel3)
                {
                    picture.Visible = true;
                }
                lblLevelName.Text = "Level 3";
                resetGame(); //Oyunu sıfırla
            }
        }
        private void resetGame() //Lokasyon sıfırlama
        {
            for (int i = 0; i < 9; i++)
            {
                picturesLevel1[i].Location = firstLocationLevel1[i]; //Level 1 lokasyon sıfırla
            }
            for (int i = 0; i < 12; i++)
            {
                picturesLevel2[i].Location = firstLocationLevel2[i]; //Level 2 lokasyon sıfırla
            }
            for (int i = 0; i < 16; i++)
            {
                picturesLevel3[i].Location = firstLocationLevel3[i]; //Level 3 lokasyon sıfırla
            }
            for (int i = 0; i < 25; i++)
            {
                picturesLevel4[i].Location = firstLocationLevel4[i]; //Level 4 lokasyon sıfırla
            }
        }
    }
}
