namespace Tema_5_Practica4._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            changeFont(FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {   
           changeFont(FontStyle.Italic);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            changeFont(FontStyle.Underline);
        }
        private void changeFont(FontStyle style)
        {
           label1.Font = new Font(label1.Font, style);
        }

    }
}