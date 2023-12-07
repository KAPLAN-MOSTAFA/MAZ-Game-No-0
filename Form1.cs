using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yon = 0; /* Yön (1 den 4) oyuncu görüntüsünün gerekli hareket yönünü
 blitmek için*/
        int X = 16; // Oyuncunun görüntüsünün X koordinatları
        int y = 200; // Oyuncunun görüntüsünün y koordinatları
        int puan = 0; // Puan sayısı
        Random Rastgeleyon = new Random();
        DialogResult cevep;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true; // timer çalışmak için
            yon = Rastgeleyon.Next(1, 5); // Rastgele bir hareket yönü oluştur
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            puan++; // Puan sayısını arttır
            int aldı_yol = puan / 6;
            textBox1.Text = aldı_yol.ToString();/* Puan sayısını textBox1 göstermesı
 için*/
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Enabled = false;
                cevep = MessageBox.Show("aldınız puan " + aldı_yol + " " +
                "KAZANDINIZ", "TEKREAR OYANAMAKISTERMISIN", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question); ;
                {
                }
                if (cevep == DialogResult.Yes)
                {
                    X = 16;
                    y = 200;

                    pictureBox1.Location = new Point(X, y);
                }
                else if (cevep == DialogResult.No)
                {
                    this.Close();
                }
            } /* pıcharBox1 pıcharBox2 dokundısya timer durdur ve oyuncu sor bird 
 //daha oynamak istiyor musun ? Evetsa picharBox1 başlancıtş nota getir 
Hayırsa uyonu
 kapat*/
            pictureBox1.Location = new Point(X, y);
            if (yon == 1)
            {
                X = X + 10;
            }
            else if (yon == 2)
            {
                y = y - 10;
            }
            else if (yon == 3)
            {
                X = X - 10;
            }
            else if (yon == 4)
            {
                y = y + 10;
            }
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                
                yon = 4;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label2.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label3.Bounds))
            {
                yon = 3;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label4.Bounds))
            {
                yon = 1;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label5.Bounds))
            {
                yon = 1;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label6.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label7.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label8.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label9.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label10.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label11.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label12.Bounds))
            {
                yon = 1;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label13.Bounds))
            {
                yon = 1;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label14.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label15.Bounds))
            {
                yon = 2;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label16.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label17.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label18.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label19.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label20.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label21.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label22.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label23.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label24.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label25.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label26.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label19.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label20.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label21.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label22.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label23.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label24.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label25.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label26.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label27.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label28.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label29.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label30.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label31.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label32.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label33.Bounds))
            {
                yon = 4;
            }
            else if (pictureBox1.Bounds.IntersectsWith(label34.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label35.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label36.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label37.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
            else if (pictureBox1.Bounds.IntersectsWith(label38.Bounds))
            {
                yon = Rastgeleyon.Next(1, 5);
            }
        }/* Çarpışma yapısını değiştirmek için oyuncuların oyundaki diğer öğelerle 
 çarpışıp çarpışmadığını kontrol edin Ona göre yon değiştir
 Bu kısım tüm elemanlar için tekrarlanır (label1'den label38'e kadar)*/
        private void label21_Click(object sender, EventArgs e)
        {
        }
    }
}