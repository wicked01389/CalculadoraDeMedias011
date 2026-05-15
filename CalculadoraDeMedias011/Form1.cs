using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ESWA011CalculadoraDeMedias;

namespace CalculadoraDeMedias011
{
    public partial class Form1 : Form
    {
        private MediaCalculator _mediaCalc;
        private StatusService _statusService;
        private double _mediaSemestralAtual;
        private bool _emExame;

        public Form1()
        {
            InitializeComponent();
            _mediaCalc = new MediaCalculator();
            _statusService = new StatusService();
            _mediaSemestralAtual = 0;
            _emExame = false;

            btnSemestral.Click += BtnSemestral_Click;
            btnFinal.Click += BtnFinal_Click;
            btnLimparSemestral.Click += BtnLimparSemestral_Click;
            btnLimparFinal.Click += BtnLimparFinal_Click;

            txtNP1.KeyPress += Txt_KeyPress;
            txtNP2.KeyPress += Txt_KeyPress;
            txtPIM.KeyPress += Txt_KeyPress;
            txtExame.KeyPress += Txt_KeyPress;

            ConfigurarEstadoInicial();
        }

        private void ConfigurarEstadoInicial()
        {
            txtNP1.Text = "0";
            txtNP2.Text = "0";
            txtPIM.Text = "0";
            txtExame.Text = "0";

            lblMediaSemestral.Text = "0,0";
            lblMediaFinal.Text = "0,0";
            lblStatus.Text = "Em Andamento";
            lblStatus.ForeColor = Color.Black;

            btnLimparFinal.Enabled = false;
            btnFinal.Enabled = false;

            _mediaSemestralAtual = 0;
            _emExame = false;
        }

        private double ObterNotaDoTextBox(TextBox txt)
        {
            if (txt == null) return 0;
            string texto = txt.Text.Trim();
            if (double.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                return _mediaCalc.Arredondar(valor);
            return 0;
        }

        private void BtnSemestral_Click(object sender, EventArgs e)
        {
            try
            {
                double np1 = ObterNotaDoTextBox(txtNP1);
                double np2 = ObterNotaDoTextBox(txtNP2);
                double pim = ObterNotaDoTextBox(txtPIM);

                _mediaSemestralAtual = _mediaCalc.CalcularMediaSemestral(np1, np2, pim);
                lblMediaSemestral.Text = _mediaSemestralAtual.ToString("F1");

                string status = _statusService.DefinirStatusSemestral(_mediaSemestralAtual);
                lblStatus.Text = status;
                lblStatus.ForeColor = _statusService.ObterCorStatus(status);

                if (status == "Em Exame")
                {
                    _emExame = true;
                    btnLimparFinal.Enabled = true;
                    btnFinal.Enabled = true;
                }
                else
                {
                    _emExame = false;
                    btnLimparFinal.Enabled = false;
                    btnFinal.Enabled = false;
                    lblMediaFinal.Text = "0,0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cálculo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFinal_Click(object sender, EventArgs e)
        {
            if (!_emExame)
            {
                MessageBox.Show("Você não está em exame. Calcule a média semestral primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                double exame = ObterNotaDoTextBox(txtExame);
                double mediaFinal = _mediaCalc.CalcularMediaFinal(_mediaSemestralAtual, exame);
                lblMediaFinal.Text = mediaFinal.ToString("F1");

                string status = _statusService.DefinirStatusFinal(mediaFinal);
                lblStatus.Text = status;
                lblStatus.ForeColor = _statusService.ObterCorStatus(status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cálculo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimparSemestral_Click(object sender, EventArgs e)
        {
            ConfigurarEstadoInicial();
        }

        private void BtnLimparFinal_Click(object sender, EventArgs e)
        {
            txtExame.Text = "0";
            lblMediaFinal.Text = "0,0";
            lblStatus.Text = "Em Exame";
            lblStatus.ForeColor = Color.Orange;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos, vírgula, ponto e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas uma vírgula OU um ponto (não ambos)
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}