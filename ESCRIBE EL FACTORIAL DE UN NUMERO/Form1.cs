namespace ESCRIBE_EL_FACTORIAL_DE_UN_NUMERO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, ulong factorial)
        {
            ulong numero; 
            ulong factorial =
            numero = ulong.Parse(textBox1.Text);
            
            for (ulong i = 1; i <= numero; i++)
            {
                listBox1.Items.Add(i);
                factorial=factorial* i;
            }
            textBox2.Text = numero.ToString();
            textBox3.Text = factorial.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}