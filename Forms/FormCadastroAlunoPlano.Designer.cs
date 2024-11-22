namespace BodyShape_TI.Forms
{
    partial class FormCadastroAlunoPlano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            txtAlunoID = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            txtPlanoID = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            txtDataInicioPlano = new MaskedTextBox();
            lblDataNascimento = new Label();
            txtDataFimPlano = new MaskedTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(208, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 134;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtAlunoID
            // 
            txtAlunoID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlunoID.Location = new Point(417, 73);
            txtAlunoID.Margin = new Padding(3, 2, 3, 2);
            txtAlunoID.Name = "txtAlunoID";
            txtAlunoID.Size = new Size(149, 23);
            txtAlunoID.TabIndex = 132;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(455, 187);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 38);
            btnSalvar.TabIndex = 130;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(417, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 129;
            label1.Text = "Aluno (ID):";
            // 
            // txtPlanoID
            // 
            txtPlanoID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlanoID.Location = new Point(208, 73);
            txtPlanoID.Margin = new Padding(3, 2, 3, 2);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(149, 23);
            txtPlanoID.TabIndex = 127;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(208, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(73, 19);
            lblNome.TabIndex = 128;
            lblNome.Text = "Plano (ID):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(162, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 32);
            panel1.TabIndex = 126;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(416, 8);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(18, 18);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(11, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Associar aluno a um plano";
            // 
            // txtDataInicioPlano
            // 
            txtDataInicioPlano.Location = new Point(210, 141);
            txtDataInicioPlano.Margin = new Padding(3, 2, 3, 2);
            txtDataInicioPlano.Mask = "00/00/0000";
            txtDataInicioPlano.Name = "txtDataInicioPlano";
            txtDataInicioPlano.Size = new Size(137, 23);
            txtDataInicioPlano.TabIndex = 135;
            txtDataInicioPlano.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(210, 120);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(98, 19);
            lblDataNascimento.TabIndex = 136;
            lblDataNascimento.Text = "Data de início:";
            // 
            // txtDataFimPlano
            // 
            txtDataFimPlano.Location = new Point(429, 141);
            txtDataFimPlano.Margin = new Padding(3, 2, 3, 2);
            txtDataFimPlano.Mask = "00/00/0000";
            txtDataFimPlano.Name = "txtDataFimPlano";
            txtDataFimPlano.Size = new Size(137, 23);
            txtDataFimPlano.TabIndex = 137;
            txtDataFimPlano.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(429, 120);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 138;
            label2.Text = "Data de fim:";
            // 
            // FormCadastroAlunoPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDataFimPlano);
            Controls.Add(label2);
            Controls.Add(txtDataInicioPlano);
            Controls.Add(lblDataNascimento);
            Controls.Add(btnCancelar);
            Controls.Add(txtAlunoID);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtPlanoID);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Name = "FormCadastroAlunoPlano";
            Text = "FormCadastroAlunoPlano";
            Load += FormCadastroAlunoPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtAlunoID;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtPlanoID;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private MaskedTextBox txtDataInicioPlano;
        private Label lblDataNascimento;
        private MaskedTextBox txtDataFimPlano;
        private Label label2;
    }
}