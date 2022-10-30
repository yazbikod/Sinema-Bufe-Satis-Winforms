namespace Sinema_Bufe_Satis_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        int kasatoplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int su, cay, kahve, toplam;
            su = Convert.ToInt32(textBox1.Text);
            cay = Convert.ToInt32(textBox2.Text);   
            kahve = Convert.ToInt32(textBox3.Text);

            toplam = su * 2 + cay * 3 + kahve * 4;
            textBox7.Text = Convert.ToString(toplam);

            kasatoplam = kasatoplam + toplam;
            label9.Text = Convert.ToString(kasatoplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}