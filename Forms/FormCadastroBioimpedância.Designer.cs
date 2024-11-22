namespace BodyShape_TI.Forms
{
    partial class FormCadastroBioimpedância
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
            txtGordura = new TextBox();
            lblAltura = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtIDAtendente = new TextBox();
            label1 = new Label();
            lblEducadorFisico = new Label();
            txtIdAluno = new TextBox();
            lblIdAluno = new Label();
            txtAltura = new MaskedTextBox();
            txtPeso = new MaskedTextBox();
            lblPeso = new Label();
            txtIdEducador = new TextBox();
            lblGordura = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
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
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(11, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Bioimpedância";
            // 
            // txtGordura
            // 
            txtGordura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGordura.Location = new Point(40, 226);
            txtGordura.Margin = new Padding(3, 2, 3, 2);
            txtGordura.Name = "txtGordura";
            txtGordura.Size = new Size(154, 23);
            txtGordura.TabIndex = 45;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Impact", 10.8F);
            lblAltura.Location = new Point(40, 140);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(49, 19);
            lblAltura.TabIndex = 44;
            lblAltura.Text = "Altura:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(40, 348);
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
            btnSalvar.Location = new Point(295, 348);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 38);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtIDAtendente
            // 
            txtIDAtendente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDAtendente.Location = new Point(40, 295);
            txtIDAtendente.Margin = new Padding(3, 2, 3, 2);
            txtIDAtendente.Name = "txtIDAtendente";
            txtIDAtendente.ReadOnly = true;
            txtIDAtendente.Size = new Size(154, 23);
            txtIDAtendente.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(40, 274);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 37;
            label1.Text = "Atendente:";
            // 
            // lblEducadorFisico
            // 
            lblEducadorFisico.AutoSize = true;
            lblEducadorFisico.BackColor = Color.Transparent;
            lblEducadorFisico.Font = new Font("Impact", 10.8F);
            lblEducadorFisico.Location = new Point(220, 73);
            lblEducadorFisico.Name = "lblEducadorFisico";
            lblEducadorFisico.Size = new Size(124, 19);
            lblEducadorFisico.TabIndex = 30;
            lblEducadorFisico.Text = "ID Educador Físico:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdAluno.Location = new Point(40, 92);
            txtIdAluno.Margin = new Padding(3, 2, 3, 2);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.ReadOnly = true;
            txtIdAluno.Size = new Size(154, 23);
            txtIdAluno.TabIndex = 29;
            // 
            // lblIdAluno
            // 
            lblIdAluno.AutoSize = true;
            lblIdAluno.BackColor = Color.Transparent;
            lblIdAluno.Font = new Font("Impact", 10.8F);
            lblIdAluno.Location = new Point(40, 73);
            lblIdAluno.Name = "lblIdAluno";
            lblIdAluno.Size = new Size(62, 19);
            lblIdAluno.TabIndex = 28;
            lblIdAluno.Text = "ID Aluno:";
            // 
            // txtAltura
            // 
            txtAltura.Culture = new System.Globalization.CultureInfo("");
            txtAltura.Location = new Point(40, 159);
            txtAltura.Margin = new Padding(3, 2, 3, 2);
            txtAltura.Mask = "0.00";
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(154, 23);
            txtAltura.TabIndex = 46;
            // 
            // txtPeso
            // 
            txtPeso.Culture = new System.Globalization.CultureInfo("");
            txtPeso.Location = new Point(220, 159);
            txtPeso.Margin = new Padding(3, 2, 3, 2);
            txtPeso.Mask = "0.00";
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(186, 23);
            txtPeso.TabIndex = 48;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Impact", 10.8F);
            lblPeso.Location = new Point(220, 140);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(43, 19);
            lblPeso.TabIndex = 47;
            lblPeso.Text = "Peso:";
            // 
            // txtIdEducador
            // 
            txtIdEducador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdEducador.Location = new Point(220, 92);
            txtIdEducador.Margin = new Padding(3, 2, 3, 2);
            txtIdEducador.Name = "txtIdEducador";
            txtIdEducador.ReadOnly = true;
            txtIdEducador.Size = new Size(186, 23);
            txtIdEducador.TabIndex = 49;
            // 
            // lblGordura
            // 
            lblGordura.AutoSize = true;
            lblGordura.BackColor = Color.Transparent;
            lblGordura.Font = new Font("Impact", 10.8F);
            lblGordura.Location = new Point(40, 207);
            lblGordura.Name = "lblGordura";
            lblGordura.Size = new Size(62, 19);
            lblGordura.TabIndex = 50;
            lblGordura.Text = "Gordura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(220, 207);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 52;
            label2.Text = "Gordura:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(220, 226);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 51;
            // 
            // FormCadastroBioimpedância
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 399);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(lblGordura);
            Controls.Add(txtIdEducador);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtGordura);
            Controls.Add(lblAltura);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtIDAtendente);
            Controls.Add(label1);
            Controls.Add(lblEducadorFisico);
            Controls.Add(txtIdAluno);
            Controls.Add(lblIdAluno);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroBioimpedância";
            Text = "FormCadastroBioimpedância";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox txtGordura;
        private Label lblAltura;
        private MaskedTextBox maskedTextBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtIDAtendente;
        private Label label1;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEducadorFisico;
        private TextBox txtIdAluno;
        private Label lblIdAluno;
        private MaskedTextBox txtAltura;
        private MaskedTextBox txtPeso;
        private Label lblPeso;
        private TextBox txtIdEducador;
        private Label lblGordura;
        private Label label2;
        private TextBox textBox1;
    }
}