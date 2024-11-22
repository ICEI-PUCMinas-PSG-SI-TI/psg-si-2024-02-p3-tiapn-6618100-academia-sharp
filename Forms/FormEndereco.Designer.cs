namespace BodyShape_TI.Forms
{
    partial class FormEndereco
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
            lblNome = new Label();
            txtLogradouro = new TextBox();
            label1 = new Label();
            maskedCEP = new MaskedTextBox();
            btnProcurar = new Button();
            txtBairro = new TextBox();
            label2 = new Label();
            txtLocalidade = new TextBox();
            label3 = new Label();
            txtUF = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            panel1.Size = new Size(415, 32);
            panel1.TabIndex = 1;
            // 
            // lblSair
            // 
            lblSair.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(374, 8);
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
            lblTitulo.Size = new Size(133, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Pesquisar Endereço";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(20, 57);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(34, 19);
            lblNome.TabIndex = 34;
            lblNome.Text = "CEP:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(20, 113);
            txtLogradouro.Margin = new Padding(3, 2, 3, 2);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.ReadOnly = true;
            txtLogradouro.Size = new Size(478, 23);
            txtLogradouro.TabIndex = 741;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(20, 94);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 36;
            label1.Text = "Logradouro:";
            // 
            // maskedCEP
            // 
            maskedCEP.Location = new Point(60, 57);
            maskedCEP.Margin = new Padding(3, 2, 3, 2);
            maskedCEP.Mask = "00000-000";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(110, 23);
            maskedCEP.TabIndex = 1;
            maskedCEP.Leave += maskedCEP_Leave;
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.WhiteSmoke;
            btnProcurar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcurar.Location = new Point(183, 57);
            btnProcurar.Margin = new Padding(3, 2, 3, 2);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(82, 22);
            btnProcurar.TabIndex = 39;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(20, 166);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(478, 23);
            txtBairro.TabIndex = 742;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(21, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 41;
            label2.Text = "Bairro:";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocalidade.Location = new Point(19, 220);
            txtLocalidade.Margin = new Padding(3, 2, 3, 2);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.ReadOnly = true;
            txtLocalidade.Size = new Size(372, 23);
            txtLocalidade.TabIndex = 743;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 10.8F);
            label3.Location = new Point(19, 201);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 43;
            label3.Text = "Localidade:";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUF.Location = new Point(299, 220);
            txtUF.Margin = new Padding(3, 2, 3, 2);
            txtUF.Name = "txtUF";
            txtUF.ReadOnly = true;
            txtUF.Size = new Size(199, 23);
            txtUF.TabIndex = 744;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 10.8F);
            label4.Location = new Point(299, 201);
            label4.Name = "label4";
            label4.Size = new Size(26, 19);
            label4.TabIndex = 45;
            label4.Text = "UF:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(21, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 746;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(275, 266);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 38);
            btnSalvar.TabIndex = 745;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 325);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtUF);
            Controls.Add(label4);
            Controls.Add(txtLocalidade);
            Controls.Add(label3);
            Controls.Add(txtBairro);
            Controls.Add(label2);
            Controls.Add(btnProcurar);
            Controls.Add(maskedCEP);
            Controls.Add(txtLogradouro);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEndereco";
            Text = "FormEndereco";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtLogradouro;
        private Label label1;
        private MaskedTextBox maskedCEP;
        private Button btnProcurar;
        private TextBox txtBairro;
        private Label label2;
        private TextBox txtLocalidade;
        private Label label3;
        private TextBox txtUF;
        private Label label4;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}