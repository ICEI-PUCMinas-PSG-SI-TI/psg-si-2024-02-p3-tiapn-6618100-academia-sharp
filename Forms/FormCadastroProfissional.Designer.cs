namespace BodyShape_TI
{
    partial class FormCadastroProfissional
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
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            maskedTextBox1 = new MaskedTextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cboxSetor = new ComboBox();
            lblSetor = new Label();
            txtDataNasc = new MaskedTextBox();
            lblDataNascimento = new Label();
            lblTelefone = new Label();
            lblIdProfissional = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtIdProfissional = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 32);
            panel1.TabIndex = 1;
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
            lblSair.Click += lblSair_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(11, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(163, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Profissional";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(252, 186);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "(99) 99999-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(103, 23);
            maskedTextBox1.TabIndex = 43;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(38, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(292, 292);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 38);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboxSetor
            // 
            cboxSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxSetor.FormattingEnabled = true;
            cboxSetor.Location = new Point(252, 242);
            cboxSetor.Margin = new Padding(3, 2, 3, 2);
            cboxSetor.Name = "cboxSetor";
            cboxSetor.Size = new Size(151, 23);
            cboxSetor.TabIndex = 40;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.BackColor = Color.Transparent;
            lblSetor.Font = new Font("Impact", 10.8F);
            lblSetor.Location = new Point(252, 223);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(46, 19);
            lblSetor.TabIndex = 39;
            lblSetor.Text = "Setor:";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(38, 186);
            txtDataNasc.Margin = new Padding(3, 2, 3, 2);
            txtDataNasc.Mask = "00/00/0000";
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(137, 23);
            txtDataNasc.TabIndex = 35;
            txtDataNasc.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(38, 167);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(138, 19);
            lblDataNascimento.TabIndex = 33;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Impact", 10.8F);
            lblTelefone.Location = new Point(252, 167);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 19);
            lblTelefone.TabIndex = 32;
            lblTelefone.Text = "Telefone:";
            // 
            // lblIdProfissional
            // 
            lblIdProfissional.AutoSize = true;
            lblIdProfissional.BackColor = Color.Transparent;
            lblIdProfissional.Font = new Font("Impact", 10.8F);
            lblIdProfissional.Location = new Point(38, 110);
            lblIdProfissional.Name = "lblIdProfissional";
            lblIdProfissional.Size = new Size(102, 19);
            lblIdProfissional.TabIndex = 28;
            lblIdProfissional.Text = "ID Profissional:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(38, 71);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(365, 23);
            txtNome.TabIndex = 27;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(38, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 19);
            lblNome.TabIndex = 26;
            lblNome.Text = "Nome:";
            // 
            // txtIdProfissional
            // 
            txtIdProfissional.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdProfissional.Location = new Point(38, 131);
            txtIdProfissional.Margin = new Padding(3, 2, 3, 2);
            txtIdProfissional.Name = "txtIdProfissional";
            txtIdProfissional.ReadOnly = true;
            txtIdProfissional.Size = new Size(365, 23);
            txtIdProfissional.TabIndex = 45;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.BackColor = Color.Transparent;
            lblSalario.Font = new Font("Impact", 10.8F);
            lblSalario.Location = new Point(38, 223);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(57, 19);
            lblSalario.TabIndex = 44;
            lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSalario.Location = new Point(38, 244);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.Name = "txtSalario";
            txtSalario.ReadOnly = true;
            txtSalario.Size = new Size(138, 23);
            txtSalario.TabIndex = 46;
            // 
            // FormCadastroProfissional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 349);
            Controls.Add(txtSalario);
            Controls.Add(txtIdProfissional);
            Controls.Add(lblSalario);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboxSetor);
            Controls.Add(lblSetor);
            Controls.Add(txtDataNasc);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblTelefone);
            Controls.Add(lblIdProfissional);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroProfissional";
            Text = "FomCadastroProfissional";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private MaskedTextBox maskedTextBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cboxSetor;
        private Label lblSetor;
        private MaskedTextBox txtDataNasc;
        private Label lblDataNascimento;
        private Label lblTelefone;
        private Label lblIdProfissional;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtIdProfissional;
        private Label lblSalario;
        private TextBox txtSalario;
    }
}