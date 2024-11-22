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
            txtNumero = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblDataNascimento = new Label();
            lblGenero = new Label();
            txtDataNasc = new MaskedTextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtTelefone = new MaskedTextBox();
            txtLogradouro = new TextBox();
            lblEndereco = new Label();
            txtGenero = new TextBox();
            txtBairro = new TextBox();
            label2 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtEstado = new TextBox();
            label4 = new Label();
            txtComplemento = new TextBox();
            label5 = new Label();
            txtIDAtendente = new TextBox();
            button1 = new Button();
            btnEditarPlano = new Button();
            button2 = new Button();
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
            panel1.TabIndex = 0;
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
            lblTitulo.Size = new Size(123, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Aluno";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(44, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 19);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(44, 59);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(365, 23);
            txtNome.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumero.Location = new Point(44, 221);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Impact", 10.8F);
            lblEmail.Location = new Point(46, 198);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Numero:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Impact", 10.8F);
            lblTelefone.Location = new Point(193, 315);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 19);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(44, 88);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(138, 19);
            lblDataNascimento.TabIndex = 11;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Impact", 10.8F);
            lblGenero.Location = new Point(271, 88);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(93, 19);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Gênero (M/F):";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(44, 109);
            txtDataNasc.Margin = new Padding(3, 2, 3, 2);
            txtDataNasc.Mask = "00/00/0000";
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(137, 23);
            txtDataNasc.TabIndex = 5;
            txtDataNasc.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(307, 315);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 17;
            label1.Text = "Atendente(ID):";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(44, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(298, 368);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 38);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(193, 334);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(103, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(44, 164);
            txtLogradouro.Margin = new Padding(3, 2, 3, 2);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(365, 23);
            txtLogradouro.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Impact", 10.8F);
            lblEndereco.Location = new Point(44, 143);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(84, 19);
            lblEndereco.TabIndex = 24;
            lblEndereco.Text = "Logradouro:";
            lblEndereco.Click += lblEndereco_Click;
            // 
            // txtGenero
            // 
            txtGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGenero.Location = new Point(271, 109);
            txtGenero.Margin = new Padding(3, 2, 3, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(138, 23);
            txtGenero.TabIndex = 101;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(141, 221);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(268, 23);
            txtBairro.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(141, 199);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 103;
            label2.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.Location = new Point(44, 276);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(224, 23);
            txtCidade.TabIndex = 104;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 10.8F);
            label3.Location = new Point(46, 253);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 105;
            label3.Text = "Cidade:";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEstado.Location = new Point(289, 276);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(120, 23);
            txtEstado.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 10.8F);
            label4.Location = new Point(289, 253);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 107;
            label4.Text = "Estado:";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComplemento.Location = new Point(44, 334);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(137, 23);
            txtComplemento.TabIndex = 108;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 10.8F);
            label5.Location = new Point(46, 313);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 109;
            label5.Text = "Complemento:";
            // 
            // txtIDAtendente
            // 
            txtIDAtendente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDAtendente.Location = new Point(307, 340);
            txtIDAtendente.Margin = new Padding(3, 2, 3, 2);
            txtIDAtendente.Name = "txtIDAtendente";
            txtIDAtendente.Size = new Size(99, 23);
            txtIDAtendente.TabIndex = 110;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(171, 430);
            button1.Name = "button1";
            button1.Size = new Size(111, 51);
            button1.TabIndex = 126;
            button1.Text = "Excluir um aluno";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditarPlano
            // 
            btnEditarPlano.BackColor = Color.Yellow;
            btnEditarPlano.Cursor = Cursors.Hand;
            btnEditarPlano.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPlano.ForeColor = Color.Black;
            btnEditarPlano.Location = new Point(48, 430);
            btnEditarPlano.Name = "btnEditarPlano";
            btnEditarPlano.Size = new Size(111, 51);
            btnEditarPlano.TabIndex = 125;
            btnEditarPlano.Text = "Editar um aluno";
            btnEditarPlano.UseVisualStyleBackColor = false;
            btnEditarPlano.Click += btnEditarPlano_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(298, 430);
            button2.Name = "button2";
            button2.Size = new Size(111, 51);
            button2.TabIndex = 127;
            button2.Text = "Associar aluno a um plano";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 493);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEditarPlano);
            Controls.Add(txtIDAtendente);
            Controls.Add(txtComplemento);
            Controls.Add(label5);
            Controls.Add(txtEstado);
            Controls.Add(label4);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtBairro);
            Controls.Add(label2);
            Controls.Add(txtGenero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtDataNasc);
            Controls.Add(lblGenero);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblTelefone);
            Controls.Add(txtNumero);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroAluno";
            Text = "Cadastro Aluno";
            Load += FormCadastroAluno_Load;
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
        private TextBox txtNumero;
        private Label lblEmail;
        private TextBox txtBairro;
        private Label lblTelefone;
        private TextBox txtCidade;
        private Label lblDataNascimento;
        private TextBox txtEstado;
        private Label lblGenero;
        private MaskedTextBox txtDataNasc;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private MaskedTextBox txtTelefone;
        private TextBox txtLogradouro;
        private Label lblEndereco;
        private TextBox txtGenero;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtComplemento;
        private Label label5;
        private TextBox txtIDAtendente;
        private Button button1;
        private Button btnEditarPlano;
        private Button button2;
    }
}