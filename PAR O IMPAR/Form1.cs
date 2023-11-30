namespace PAR_O_IMPAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(Texbox.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + " Par");
            }
            else
            {
                listBox1.Items.Add(numero + " Impar");
            }
            Texbox.Text = " ";
            Texbox.Focus();
        }

        private void VERIFICAR_TextChanged(object sender, EventArgs e)
        {
        }
    }
}