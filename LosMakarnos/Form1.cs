namespace LosMakarnos
{

    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Masalar masalar = new Masalar();
            masalar.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}