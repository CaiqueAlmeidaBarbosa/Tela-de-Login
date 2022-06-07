namespace WinFormsApp1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*validação com um login

            if (textBox1.Text == "Caique" && textBox2.Text == "1234")
            {
                MessageBox.Show("Bem Vindo ao Sistema !");
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos !");
            } 
            */

            // Estrutura de validação para três Logins diferentes //
           if (textBox1.Text == "Caique" && textBox2.Text == "1234" || textBox1.Text == "Fernanda" && textBox2.Text == "4321" || textBox1.Text == "Kleber" && textBox2.Text == "5678")
           {
                  MessageBox.Show("Bem Vindo ao Sistema !");
           }
            else
           {
                 MessageBox.Show("Login ou senha inválidos !");
           }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}