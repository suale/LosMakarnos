using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosMakarnos
{
    public partial class Masalar : Form
    {

        public Masalar()
        {
            InitializeComponent();
            this.Load += new EventHandler(Masalar_Load);

        }

       

        private void Masalar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int masaNo = 0;

             void Button_Click(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                int[] indexData = (int[])button.Tag;
                MasaAdisyon masaAdisyon = new MasaAdisyon(indexData);
                masaAdisyon.Show();
            }
            int top = 0, left = 0;
           

            Button[,] buttonsSalon = new Button[2, 10];
            for (int i = 0; i <= buttonsSalon.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttonsSalon.GetUpperBound(1); j++)
                {
                    buttonsSalon[i, j] = new Button();
                    buttonsSalon[i, j].Height = 120;
                    buttonsSalon[i, j].Width = 120;
                    buttonsSalon[i, j].Left = left;
                    buttonsSalon[i, j].Top = top;
                    buttonsSalon[i,j].Tag= new int[] { i, j };
                    left += 130;
                    this.Controls.Add(buttonsSalon[i, j]);
                    buttonsSalon[i, j].Text = $"Salon {i * 10 + j + 1}";
                    if (MasaListesi.Liste.Count < 25)
                    {
                        Masa masa = new Masa();
                        masa.MasaDurum = false;
                        masa.MasaNo = i * 10 + j + 1;
                        masa.MasaAd = $"Salon {i * 10 + j + 1}";
                        MasaListesi.Liste.Add(masa);
                    }
                    buttonsSalon[i, j].Click += new EventHandler(Button_Click);





                }
                left = 0;
                top += 130;
            }
           

            top += 65;
            Button[,] buttonsBahce = new Button[1, 5];
            for (int i = 0; i <= buttonsBahce.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttonsBahce.GetUpperBound(1); j++)
                {
                    buttonsBahce[i, j] = new Button();
                    buttonsBahce[i, j].Height = 120;
                    buttonsBahce[i, j].Width = 120;
                    buttonsBahce[i, j].Left = left;
                    buttonsBahce[i, j].Top = top;
                    left += 130;
                    buttonsBahce[i, j].Tag = new int[] { i+2, j };

                    this.Controls.Add(buttonsBahce[i, j]);
                    buttonsBahce[i, j].Text = $"Bahçe {i * 10 + j + 1}";
                    if (MasaListesi.Liste.Count < 25)
                    {
                        Masa masa = new Masa();
                        masa.MasaDurum = false;
                        masa.MasaNo = i * 10 + j + 21;
                        masa.MasaAd = $"Bahçe {i * 10 + j + 1}";
                        MasaListesi.Liste.Add(masa);
                    }
                    buttonsBahce[i, j].Click += new EventHandler(Button_Click);

                }
                left = 0;
                top += 130;
            }



    }


    }
}
