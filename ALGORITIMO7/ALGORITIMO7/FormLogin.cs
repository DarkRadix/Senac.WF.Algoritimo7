using System.Diagnostics;

namespace ALGORITIMO7
{
    public partial class FormLogin : Form
    {
        // Variáveis globais
        private string senhaReal = "";  // Para armazenar a senha real
        private bool atualizandoTexto = false;  // Evitar loop infinito ao atualizar o texto

        public FormLogin()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Método para fechar o aplicativo
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento TextChanged do TextBox para esconder a senha
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Evita que o código entre em loop infinito
            if (atualizandoTexto) return;

            // Marca que estamos atualizando o texto
            atualizandoTexto = true;


            string textoDigitado = textBox2.Text;


            int tamanhoDigitado = textoDigitado.Length;
            int tamanhoReal = senhaReal.Length;

            if (tamanhoDigitado < tamanhoReal)
            {

                senhaReal = senhaReal.Substring(0, tamanhoDigitado);
            }
            else if (tamanhoDigitado > tamanhoReal)
            {

                char novoChar = textoDigitado[^1];
                senhaReal += novoChar;
            }


            if (senhaReal.Length == 0)
            {
                textBox2.Text = "";
            }
            else if (senhaReal.Length == 1)
            {
                textBox2.Text = senhaReal;
            }
            else
            {
                string visivel = new string('*', senhaReal.Length - 1) + senhaReal[^1];
                textBox2.Text = visivel;
            }


            textBox2.SelectionStart = textBox2.Text.Length;

            atualizandoTexto = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://senac.blackboard.com/webapps/blackboard/password",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
                textBox1.Text = string.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            var resposta = MessageBox.Show("Você deseja fechar está aplicação ?",
                "Sair",
                MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else { e.Cancel = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormPrincipal = new FormPrincipal();
            FormPrincipal.Show();
        }
    }
}
    
