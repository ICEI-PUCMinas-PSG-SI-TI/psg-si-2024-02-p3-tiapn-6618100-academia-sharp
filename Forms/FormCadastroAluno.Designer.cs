namespace BS_Projeto
{
    partial class FormCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtIdAluno = new TextBox();
            lblIdAluno = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblDataNascimento = new Label();
            lblGenero = new Label();
            txtDataNasc = new MaskedTextBox();
            cboxGenero = new ComboBox();
            label1 = new Label();
            txtIDAtendente = new TextBox();
            lblPlano = new Label();
            cboxPlano = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            lblEndereco = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 42);
            panel1.TabIndex = 0;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(475, 11);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(22, 21);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            lblSair.Click += lblSair_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(13, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Aluno";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(50, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(50, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 27);
            txtNome.TabIndex = 4;
            // 
            // txtIdAluno
            // 
            txtIdAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdAluno.Location = new Point(50, 173);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.ReadOnly = true;
            txtIdAluno.Size = new Size(417, 27);
            txtIdAluno.TabIndex = 6;
            // 
            // lblIdAluno
            // 
            lblIdAluno.AutoSize = true;
            lblIdAluno.BackColor = Color.Transparent;
            lblIdAluno.Font = new Font("Impact", 10.8F);
            lblIdAluno.Location = new Point(50, 151);
            lblIdAluno.Name = "lblIdAluno";
            lblIdAluno.Size = new Size(73, 22);
            lblIdAluno.TabIndex = 5;
            lblIdAluno.Text = "ID Aluno:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(50, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Impact", 10.8F);
            lblEmail.Location = new Point(50, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 22);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Impact", 10.8F);
            lblTelefone.Location = new Point(340, 226);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 22);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(50, 376);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(156, 22);
            lblDataNascimento.TabIndex = 11;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Impact", 10.8F);
            lblGenero.Location = new Point(240, 376);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(66, 22);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Gênero:";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(50, 398);
            txtDataNasc.Mask = "00/00/0000";
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(156, 27);
            txtDataNasc.TabIndex = 15;
            txtDataNasc.ValidatingType = typeof(DateTime);
            // 
            // cboxGenero
            // 
            cboxGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Location = new Point(240, 397);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(227, 28);
            cboxGenero.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(50, 451);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 17;
            label1.Text = "Atendente:";
            // 
            // txtIDAtendente
            // 
            txtIDAtendente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDAtendente.Location = new Point(50, 473);
            txtIDAtendente.Name = "txtIDAtendente";
            txtIDAtendente.ReadOnly = true;
            txtIDAtendente.Size = new Size(156, 27);
            txtIDAtendente.TabIndex = 18;
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.BackColor = Color.Transparent;
            lblPlano.Font = new Font("Impact", 10.8F);
            lblPlano.Location = new Point(240, 451);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(55, 22);
            lblPlano.TabIndex = 19;
            lblPlano.Text = "Plano:";
            // 
            // cboxPlano
            // 
            cboxPlano.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxPlano.FormattingEnabled = true;
            cboxPlano.Location = new Point(240, 472);
            cboxPlano.Name = "cboxPlano";
            cboxPlano.Size = new Size(227, 28);
            cboxPlano.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(50, 533);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 50);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(340, 533);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(340, 251);
            maskedTextBox1.Mask = "(99) 99999-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(117, 27);
            maskedTextBox1.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(50, 321);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 27);
            textBox1.TabIndex = 25;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Impact", 10.8F);
            lblEndereco.Location = new Point(50, 299);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(81, 22);
            lblEndereco.TabIndex = 24;
            lblEndereco.Text = "Endereço:";
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 605);
            Controls.Add(textBox1);
            Controls.Add(lblEndereco);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboxPlano);
            Controls.Add(lblPlano);
            Controls.Add(txtIDAtendente);
            Controls.Add(label1);
            Controls.Add(cboxGenero);
            Controls.Add(txtDataNasc);
            Controls.Add(lblGenero);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtIdAluno);
            Controls.Add(lblIdAluno);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroAluno";
            Text = "Cadastro Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label lblSair;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtIdAluno;
        private Label lblIdAluno;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox textBox3;
        private Label lblTelefone;
        private TextBox textBox4;
        private Label lblDataNascimento;
        private TextBox textBox5;
        private Label lblGenero;
        private MaskedTextBox txtDataNasc;
        private ComboBox cboxGenero;
        private Label label1;
        private TextBox txtIDAtendente;
        private Label lblPlano;
        private ComboBox cboxPlano;
        private Button btnCancelar;
        private Button btnSalvar;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label lblEndereco;
    }
}