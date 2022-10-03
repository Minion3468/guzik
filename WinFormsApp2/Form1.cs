using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        readonly Random l;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            l = new Random();
            punkty = 0;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 12;
            int maxY = this.Size.Height - button1.Size.Height - 12;
            Point o = new Point();
            o.X = l.Next(0, maxX);
            o.Y = l.Next(12, maxY);
            button1.Location = o;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}