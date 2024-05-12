namespace tpmodul12_1302223027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Nol";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else
            {
                return "negatif";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tanda = CariTandaBilangan(int.Parse(textBox1.Text));
                label1.Text = tanda;

            }catch (Exception ex)
            {
                label1.Text="input harus int";
            }
        }
    }


}