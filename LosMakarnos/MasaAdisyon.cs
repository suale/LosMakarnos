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
        public MasaAdisyon(int[] indexData)
        {
            InitializeComponent();
            this.indexData = indexData;
            masaNo = indexData[0] * 10 + indexData[1] + 1;
            label1.Text = masaNo.ToString();

            DummyData dummyData = new DummyData();

         ;

            int numButtons = dummyData.Kategoriler.Count;

            // Create a new FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();

            // Set the FlowLayoutPanel's properties
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.BackColor = Color.Black;
            
            this.Controls.Add(flowLayoutPanel1);

            //Button btn1 = new Button();
            //btn1.Text = "deneme";
            //flowLayoutPanel1.Controls.Add(btn1);
            for (int i = 0; i < numButtons; i++)
            {
                // Create a new button
                Button button = new Button();

                // Set the button properties
                button.Text = dummyData.Kategoriler[i].KategoriAd;
                button.Width = flowLayoutPanel1.Width*12/ 13;
                button.Height = flowLayoutPanel1.Height / 6;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.Black;
                // Add the button to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(button);

                // Add a Click event handler to the button
                
            }


        }

        private void MasaAdisyon_Load(object sender, EventArgs e)
        {


        }

        
    }
}
