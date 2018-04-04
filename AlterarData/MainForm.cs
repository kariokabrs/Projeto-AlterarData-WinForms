using System;
using System.Data;
using System.Windows.Forms;

namespace AlterarData
{
    // Teste que converter a data e hora em minutos, depois pega-se os minutos e acrescenta ou decrescenta pelos minutos fornecidos por um usuário e depois volta com a quantidade total em minutos para o formato de data e hora novamente baseamdo o MARCO 0 sendo o ANO  = 0 e FEVEREIRO tendo 28 dias sempre ou seja, 1 ANO = 365 dias sempre  
    public partial class MainForm : Form
    {
        Data novaData = new Data();
        public MainForm()
        {
            InitializeComponent();
        }
        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }
        private void TxtDia_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtDia.Text != String.Empty) && (txtDia.Text != "0") && !(novaData.ValidarDiaTextBox(Convert.ToInt32(txtDia.Text))))
            {
                MessageBox.Show("Fora dos dias permitidos!");
                txtDia.Text = String.Empty;
                e.Handled = true;
            }
            else
            {
                if ((txtDia.TextLength == 2))
                {
                    txtMes.Enabled = true;
                    txtMes.Focus();
                }
            }
        }
        private void txtDia_Leave(object sender, EventArgs e)
        {
            //txtDia.Text = txtDia.Text.PadLeft(2, '0');
        }
        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }
        private void txtMes_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtMes.TextLength == 2) && (!(novaData.ValidarMesTextBox(Convert.ToInt32(txtMes.Text)))))
            {
                MessageBox.Show("Fora dos meses permitidos!");
                txtMes.Text = String.Empty;
                e.Handled = true;
            }
            else
            {
                if ((txtMes.TextLength == 2) && (!(novaData.ValidarDiaMes(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text)))))
                {
                    MessageBox.Show("Este dia não existe para este mês!");
                    txtMes.Text = String.Empty;
                    e.Handled = true;
                }
                else
                {
                    if ((txtMes.TextLength == 2))
                    {
                        txtAno.Enabled = true;
                        txtAno.Focus();
                    }
                }
            }
        }
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }
        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtAno.TextLength == 4))
            {
                txtHora.Enabled = true;
                txtHora.Focus();
            }
        }
        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }
        private void txtHora_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtHora.Text != String.Empty) && !(novaData.ValidarHoraTextBox(Convert.ToInt32(txtHora.Text))))
            {
                MessageBox.Show("Fora das horas permitidas!");
                txtHora.Text = String.Empty;
                e.Handled = true;
            }
            else
            {
                if ((txtHora.TextLength == 2))
                {
                    txtMinutos.Enabled = true;
                    txtMinutos.Focus();
                }
            }
        }
        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }
        private void txtMinutos_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtMinutos.Text != String.Empty) && !(novaData.ValidarMinutosTextBox(Convert.ToInt32(txtMinutos.Text))))
            {
                MessageBox.Show("Fora dos minutos permitidos!");
                txtMinutos.Text = String.Empty;
                e.Handled = true;
            }
            else
            {
                if ((txtMinutos.TextLength == 2))
                {
                    cbOperacao.Enabled = true;
                    cbOperacao.Focus();
                }
            }
        }
        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOperacao.Text != String.Empty)
            {
                txtMinutosAlterar.Enabled = true;
                txtMinutosAlterar.Focus();
            }
        }

        private void txtMinutosAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números permitidos!");
                e.Handled = true;
            }
        }

        private void txtMinutosAlterar_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtMinutosAlterar.TextLength == 1))
            {
                btnCalcular.Enabled = true;
            }
        }
        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            string dia = txtDia.Text;
            string mes = txtMes.Text;
            string ano = txtAno.Text;
            string hora = txtHora.Text;
            string minutos = txtMinutos.Text;

            string dataCompleta = String.Format("{0}/{1}/{2} {3}:{4}", dia, mes, ano, hora, minutos);
            char operacao = Convert.ToChar(cbOperacao.Text);
            long minutosAlterar = Convert.ToInt64(txtMinutosAlterar.Text);

            // Chamar o método princiapal da classe Data
            lblCalculo.Text = novaData.ChangeDate(dataCompleta, operacao, minutosAlterar);
        }
    }
}
