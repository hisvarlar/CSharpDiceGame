using System.Reflection;
using System.Windows.Forms.VisualStyles;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {

        string path = new DirectoryInfo("../../../images/").FullName;


        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int sum1 = 0;
        int sum2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);
            sum1 = sum1 + a + b;
            label4.Text = sum1.ToString();

            pictureBox1.ImageLocation = path + a.ToString() + ".jpg";
            pictureBox2.ImageLocation = path + b.ToString() + ".jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = rnd.Next(1, 7);
            int d = rnd.Next(1, 7);
            sum2 = sum2 + c + d;
            label5.Text = sum2.ToString();

            pictureBox3.ImageLocation = path + c.ToString() + ".jpg";
            pictureBox4.ImageLocation = path + d.ToString() + ".jpg";

            if (sum1 > 49 || sum2 > 49)
            {
                if (sum1 > sum2)
                {
                    label7.Text = "PLAYER 1";
                    button3.Visible = true;
                    button1.Enabled = false;
                }
                if (sum2 > sum1)
                {
                    label7.Text = "PLAYER 2";
                    button3.Visible = true;
                    button1.Enabled = false;
                }
                if (sum1 == sum2)
                {
                    label7.Text = "EQUALITY";
                    button3.Visible = true;
                    button1.Enabled = false;
                    label6.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Enabled = true;

            sum1 = 0;
            sum2 = 0;
            label4.Text = sum1.ToString();
            label5.Text = sum2.ToString();

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;

            label6.Visible = true;

            label7.Text = null;
        }
    }
}