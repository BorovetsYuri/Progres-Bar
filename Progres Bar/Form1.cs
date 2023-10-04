namespace Progres_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;

            if (button1.Visible == false)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            button1.Visible = true;
            label1.Text = "";

            if (button1.Visible == false)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }

            if (button1.Text == "Start")
            {
                button3.Text = "Pause";
            }
            else
            {
                button3.Text = "Continue";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

            label1.Text = progressBar1.Value.ToString() + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Pause")
            {
                timer1.Stop();
                button3.Text = "Continue";
            }
            else
            {
                timer1.Start();
                button3.Text = "Pause";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}