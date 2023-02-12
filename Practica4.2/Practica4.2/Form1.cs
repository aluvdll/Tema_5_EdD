namespace Practica4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxInt.Text);
            int b = a * 2;
            int z = a / 2;
            textBox3.Text = b.ToString();
            textBox4.Text = z.ToString();


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox2.Text);
            float b = a*2;
            float z = a / 2;
            textBox3.Text= b.ToString();
            textBox4.Text= z.ToString();

        }
    }
}