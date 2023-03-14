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
    public partial class MasaAdisyon : Form
    {
        private int[] indexData;
        private int masaNo;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private ListBox listBox1;


        public MasaAdisyon(int[] indexData)
        {
            InitializeComponent();
            this.indexData = indexData;
            masaNo = indexData[0] * 10 + indexData[1] + 1;
            label1.Text = masaNo.ToString();

            DummyData dummyData = new DummyData();
            

            int numButtons = dummyData.Kategoriler.Count;

            flowLayoutPanel1 = new FlowLayoutPanel();

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.BackColor = Color.Black;

            this.Controls.Add(flowLayoutPanel1);


            for (int i = 0; i < numButtons; i++)
            {
                Button button = new Button();

                button.Text = dummyData.Kategoriler[i].KategoriAd;
                button.Tag = dummyData.Kategoriler[i];

                button.Width = flowLayoutPanel1.Width * 12 / 13;
                button.Height = flowLayoutPanel1.Height / 6;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.Black;
                button.Click += new EventHandler(Button_Click);

                flowLayoutPanel1.Controls.Add(button);



            }


        }
        private void Button_Click(object sender, EventArgs e)
        {
            Kategori kategori = (Kategori)((Button)sender).Tag;
            List<Urun> urunler = new List<Urun>();

            DummyData dummyData = new DummyData();
            foreach (var item in dummyData.Urunler)
            {
                if (item.KategoriID == kategori.KategoriID)
                {
                    urunler.Add(item);
                }
            }
            flowLayoutPanel2 = new FlowLayoutPanel();

            flowLayoutPanel2.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel2.AutoSize = true;
            int maxFlowPanel2Width = this.Width - flowLayoutPanel1.Width - 400;
            flowLayoutPanel2.MaximumSize = new Size(maxFlowPanel2Width, 0);
            flowLayoutPanel2.WrapContents = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.BackColor = Color.Black;

            flowLayoutPanel2.Location = new Point(flowLayoutPanel1.Width + 10, 0);

            this.Controls.Add(flowLayoutPanel2);

            int numColumns = 3; // Number of columns
            int buttonWidth = (flowLayoutPanel2.ClientSize.Width - (numColumns + 1) * flowLayoutPanel2.Margin.Horizontal) / (numColumns - 2);



            foreach (var product in urunler)
            {
                Button button = new Button();

                button.Text = product.UrunAd;
                button.Width = buttonWidth;
                button.Margin = new Padding(10); // Set margin between buttons

                button.Height = 100;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.Black;

                // Attach event handler to button
                button.Click += new EventHandler(ProductButton_Click);

                flowLayoutPanel2.Controls.Add(button);
            }
            Button buttonKapa = new Button();
            buttonKapa.Click += new EventHandler(ButtonKapa_Click);
            buttonKapa.Text = "geri";
            buttonKapa.Width = 220;
            buttonKapa.Height = 150;
            buttonKapa.BackColor = Color.IndianRed;
            buttonKapa.ForeColor = Color.Black;
            flowLayoutPanel2.Controls.Add(buttonKapa);

            if (listBox1 == null)
            {
                listBox1 = new ListBox();

                listBox1.Location = new Point(flowLayoutPanel2.Right + 10, flowLayoutPanel2.Top);
                listBox1.Width = 380;
                listBox1.Height = flowLayoutPanel2.Height;
                listBox1.BorderStyle = BorderStyle.FixedSingle;
                listBox1.BackColor = Color.LightGray;
                listBox1.ForeColor = Color.DarkBlue;
                listBox1.Items.Add("Item 1");
                listBox1.Items.Add("Item 2");
                listBox1.Items.Add("Item 3");
                listBox1.SelectionMode = SelectionMode.MultiExtended;

                this.Controls.Add(listBox1);
                Button listedenSil = new Button();
                listedenSil.Location = new Point(listBox1.Left, listBox1.Bottom + 10);
                listedenSil.Text = "Sil";
                listedenSil.Width = 220;
                listedenSil.Height = 150;
                listedenSil.BackColor = Color.IndianRed;
                listedenSil.ForeColor = Color.Black;
                listedenSil.Click += new EventHandler(listedenSil_Click);

                this.Controls.Add(listedenSil);
            }



        }

        private void ProductButton_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            string urunAd = button.Text;

            listBox1.Items.Add(urunAd);
        }

        private void ButtonKapa_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            FlowLayoutPanel panel = (FlowLayoutPanel)button.Parent;
            panel.Controls.Remove(button);
            this.Controls.Remove(panel);
        }

        private void MasaAdisyon_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void listedenSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // check if an item is selected
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // remove the selected item
            }
        }
    }
}
