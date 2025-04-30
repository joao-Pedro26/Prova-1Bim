using System;
using System.Windows.Forms;

namespace Prova1Bim
{
    public partial class frmTemperatura : Form
    {
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double temperatura = double.Parse(txtTemperatura.Text);
                double percentual = (double)numPercentualAcrescimo.Value;

                double resultado = temperatura + (temperatura * (percentual / 100));

                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira uma temperatura válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            txtTemperatura.Clear();
            numPercentualAcrescimo.Value = 0;
            txtTemperatura.Focus();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}