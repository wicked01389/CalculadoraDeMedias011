namespace CalculadoraDeMedias011
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNP1;
        private System.Windows.Forms.TextBox txtNP2;
        private System.Windows.Forms.TextBox txtPIM;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.Label lblMediaSemestral;
        private System.Windows.Forms.Label lblMediaFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimparSemestral;
        private System.Windows.Forms.Button btnSemestral;
        private System.Windows.Forms.Button btnLimparFinal;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNP1;
        private System.Windows.Forms.Label lblNP2;
        private System.Windows.Forms.Label lblPIM;
        private System.Windows.Forms.Label lblSemestral;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Panel panelSemestral;
        private System.Windows.Forms.Panel panelFinal;
        private System.Windows.Forms.Panel panelStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNP1 = new System.Windows.Forms.TextBox();
            this.txtNP2 = new System.Windows.Forms.TextBox();
            this.txtPIM = new System.Windows.Forms.TextBox();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.lblMediaSemestral = new System.Windows.Forms.Label();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimparSemestral = new System.Windows.Forms.Button();
            this.btnSemestral = new System.Windows.Forms.Button();
            this.btnLimparFinal = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNP1 = new System.Windows.Forms.Label();
            this.lblNP2 = new System.Windows.Forms.Label();
            this.lblPIM = new System.Windows.Forms.Label();
            this.lblSemestral = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.panelSemestral = new System.Windows.Forms.Panel();
            this.panelFinal = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelSemestral.SuspendLayout();
            this.panelFinal.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();

            // ========== FORMULÁRIO PRINCIPAL ==========
            this.Text = "Cálculo de Médias e Status | ESWA+POO";
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ========== TÍTULO PRINCIPAL ==========
            this.lblTitulo.Text = "📊 Cálculo de Médias e Status";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Size = new System.Drawing.Size(480, 35);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ========== PAINEL SEMESTRAL ==========
            this.panelSemestral.BackColor = System.Drawing.Color.White;
            this.panelSemestral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSemestral.Location = new System.Drawing.Point(20, 70);
            this.panelSemestral.Size = new System.Drawing.Size(480, 200);
            this.panelSemestral.Padding = new System.Windows.Forms.Padding(15);

            // Título do painel
            System.Windows.Forms.Label lblPainelSemestral = new System.Windows.Forms.Label();
            lblPainelSemestral.Text = "▶ MÉDIA SEMESTRAL";
            lblPainelSemestral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPainelSemestral.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblPainelSemestral.Location = new System.Drawing.Point(15, 5);
            lblPainelSemestral.Size = new System.Drawing.Size(200, 25);
            this.panelSemestral.Controls.Add(lblPainelSemestral);

            // Labels e TextBoxes do painel semestral
            this.lblNP1.Text = "NP1:";
            this.lblNP1.Location = new System.Drawing.Point(15, 40);
            this.lblNP1.Size = new System.Drawing.Size(50, 25);

            this.txtNP1.Location = new System.Drawing.Point(70, 38);
            this.txtNP1.Size = new System.Drawing.Size(120, 27);
            this.txtNP1.Text = "0";
            this.txtNP1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtNP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblNP2.Text = "NP2:";
            this.lblNP2.Location = new System.Drawing.Point(15, 75);
            this.lblNP2.Size = new System.Drawing.Size(50, 25);

            this.txtNP2.Location = new System.Drawing.Point(70, 73);
            this.txtNP2.Size = new System.Drawing.Size(120, 27);
            this.txtNP2.Text = "0";
            this.txtNP2.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtNP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPIM.Text = "PIM:";
            this.lblPIM.Location = new System.Drawing.Point(15, 110);
            this.lblPIM.Size = new System.Drawing.Size(50, 25);

            this.txtPIM.Location = new System.Drawing.Point(70, 108);
            this.txtPIM.Size = new System.Drawing.Size(120, 27);
            this.txtPIM.Text = "0";
            this.txtPIM.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtPIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblSemestral.Text = "Média Semestral:";
            this.lblSemestral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSemestral.Location = new System.Drawing.Point(220, 40);
            this.lblSemestral.Size = new System.Drawing.Size(120, 25);

            this.lblMediaSemestral.Text = "0,0";
            this.lblMediaSemestral.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMediaSemestral.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblMediaSemestral.Location = new System.Drawing.Point(350, 35);
            this.lblMediaSemestral.Size = new System.Drawing.Size(100, 35);
            this.lblMediaSemestral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMediaSemestral.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblMediaSemestral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Botões do painel semestral
            this.btnSemestral.Text = "✓ CALCULAR";
            this.btnSemestral.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSemestral.ForeColor = System.Drawing.Color.White;
            this.btnSemestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemestral.FlatAppearance.BorderSize = 0;
            this.btnSemestral.Location = new System.Drawing.Point(220, 80);
            this.btnSemestral.Size = new System.Drawing.Size(120, 35);
            this.btnSemestral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.btnLimparSemestral.Text = "🗑 LIMPAR";
            this.btnLimparSemestral.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLimparSemestral.ForeColor = System.Drawing.Color.White;
            this.btnLimparSemestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparSemestral.FlatAppearance.BorderSize = 0;
            this.btnLimparSemestral.Location = new System.Drawing.Point(220, 125);
            this.btnLimparSemestral.Size = new System.Drawing.Size(120, 35);
            this.btnLimparSemestral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // ========== PAINEL FINAL ==========
            this.panelFinal.BackColor = System.Drawing.Color.White;
            this.panelFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFinal.Location = new System.Drawing.Point(20, 290);
            this.panelFinal.Size = new System.Drawing.Size(480, 130);
            this.panelFinal.Padding = new System.Windows.Forms.Padding(15);

            System.Windows.Forms.Label lblPainelFinal = new System.Windows.Forms.Label();
            lblPainelFinal.Text = "▶ MÉDIA FINAL (EXAME)";
            lblPainelFinal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPainelFinal.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            lblPainelFinal.Location = new System.Drawing.Point(15, 5);
            lblPainelFinal.Size = new System.Drawing.Size(200, 25);
            this.panelFinal.Controls.Add(lblPainelFinal);

            this.lblExame.Text = "Exame:";
            this.lblExame.Location = new System.Drawing.Point(15, 45);
            this.lblExame.Size = new System.Drawing.Size(60, 25);

            this.txtExame.Location = new System.Drawing.Point(80, 43);
            this.txtExame.Size = new System.Drawing.Size(120, 27);
            this.txtExame.Text = "0";
            this.txtExame.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtExame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblFinal.Text = "Média Final:";
            this.lblFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinal.Location = new System.Drawing.Point(220, 45);
            this.lblFinal.Size = new System.Drawing.Size(100, 25);

            this.lblMediaFinal.Text = "0,0";
            this.lblMediaFinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMediaFinal.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblMediaFinal.Location = new System.Drawing.Point(330, 40);
            this.lblMediaFinal.Size = new System.Drawing.Size(100, 35);
            this.lblMediaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMediaFinal.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.lblMediaFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnFinal.Text = "✓ CALCULAR FINAL";
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.Location = new System.Drawing.Point(220, 85);
            this.btnFinal.Size = new System.Drawing.Size(120, 35);
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.btnLimparFinal.Text = "🗑 LIMPAR EXAME";
            this.btnLimparFinal.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnLimparFinal.ForeColor = System.Drawing.Color.White;
            this.btnLimparFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFinal.FlatAppearance.BorderSize = 0;
            this.btnLimparFinal.Location = new System.Drawing.Point(350, 85);
            this.btnLimparFinal.Size = new System.Drawing.Size(110, 35);
            this.btnLimparFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // ========== PAINEL STATUS ==========
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.panelStatus.Location = new System.Drawing.Point(20, 440);
            this.panelStatus.Size = new System.Drawing.Size(480, 60);

            this.lblStatusTitle.Text = "STATUS DO ALUNO:";
            this.lblStatusTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStatusTitle.Size = new System.Drawing.Size(130, 25);

            this.lblStatus.Text = "EM ANDAMENTO";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(170, 18);
            this.lblStatus.Size = new System.Drawing.Size(280, 30);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Adicionar controles aos painéis
            this.panelSemestral.Controls.Add(this.lblNP1);
            this.panelSemestral.Controls.Add(this.txtNP1);
            this.panelSemestral.Controls.Add(this.lblNP2);
            this.panelSemestral.Controls.Add(this.txtNP2);
            this.panelSemestral.Controls.Add(this.lblPIM);
            this.panelSemestral.Controls.Add(this.txtPIM);
            this.panelSemestral.Controls.Add(this.lblSemestral);
            this.panelSemestral.Controls.Add(this.lblMediaSemestral);
            this.panelSemestral.Controls.Add(this.btnSemestral);
            this.panelSemestral.Controls.Add(this.btnLimparSemestral);

            this.panelFinal.Controls.Add(this.lblExame);
            this.panelFinal.Controls.Add(this.txtExame);
            this.panelFinal.Controls.Add(this.lblFinal);
            this.panelFinal.Controls.Add(this.lblMediaFinal);
            this.panelFinal.Controls.Add(this.btnFinal);
            this.panelFinal.Controls.Add(this.btnLimparFinal);

            this.panelStatus.Controls.Add(this.lblStatusTitle);
            this.panelStatus.Controls.Add(this.lblStatus);

            // Adicionar ao formulário
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelSemestral);
            this.Controls.Add(this.panelFinal);
            this.Controls.Add(this.panelStatus);

            this.panelSemestral.ResumeLayout(false);
            this.panelSemestral.PerformLayout();
            this.panelFinal.ResumeLayout(false);
            this.panelFinal.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}