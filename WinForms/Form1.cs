using ClassLibrary;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string current_time = Date.Now();
            label2.Text = $"{current_time} Hello,  {username}!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}