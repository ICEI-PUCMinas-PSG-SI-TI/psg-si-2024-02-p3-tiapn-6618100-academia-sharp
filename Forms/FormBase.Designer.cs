namespace BS_Projeto
{
    partial class FormBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            pnlnavegacao = new Panel();
            pnlSair = new Panel();
            pictureBox1 = new PictureBox();
            lblSair = new Label();
            pnlBotao4 = new Panel();
            pnlBtnAulas = new Panel();
            btnPlanos = new Button();
            pnlBotao3 = new Panel();
            pnlBtnPlanos = new Panel();
            btnProfissionais = new Button();
            pnlBotao2 = new Panel();
            pnlBtnProf = new Panel();
            btnAlunos = new Button();
            pnlBotao1 = new Panel();
            pnlBtnAlunos = new Panel();
            btnPerfil = new Button();
            pnlLogo = new Panel();
            pictureLogo = new PictureBox();
            pnlnavegacao.SuspendLayout();
            pnlSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBotao4.SuspendLayout();
            pnlBotao3.SuspendLayout();
            pnlBotao2.SuspendLayout();
            pnlBotao1.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlnavegacao
            // 
            pnlnavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlnavegacao.BackColor = Color.FromArgb(36, 44, 50);
            pnlnavegacao.Controls.Add(pnlSair);
            pnlnavegacao.Controls.Add(pnlBotao4);
            pnlnavegacao.Controls.Add(pnlBotao3);
            pnlnavegacao.Controls.Add(pnlBotao2);
            pnlnavegacao.Controls.Add(pnlBotao1);
            pnlnavegacao.Controls.Add(pnlLogo);
            pnlnavegacao.Location = new Point(-3, -4);
            pnlnavegacao.Margin = new Padding(3, 4, 3, 4);
            pnlnavegacao.MinimumSize = new Size(141, 855);
            pnlnavegacao.Name = "pnlnavegacao";
            pnlnavegacao.Size = new Size(141, 855);
            pnlnavegacao.TabIndex = 3;
            // 
            // pnlSair
            // 
            pnlSair.Controls.Add(pictureBox1);
            pnlSair.Controls.Add(lblSair);
            pnlSair.Cursor = Cursors.Hand;
            pnlSair.Location = new Point(9, 766);
            pnlSair.Margin = new Padding(3, 4, 3, 4);
            pnlSair.Name = "pnlSair";
            pnlSair.Size = new Size(114, 69);
            pnlSair.TabIndex = 15;
            pnlSair.Click += pnlSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 14);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pnlSair_Click;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSair.ForeColor = SystemColors.Control;
            lblSair.Location = new Point(47, 12);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(60, 35);
            lblSair.TabIndex = 0;
            lblSair.Text = "Sair";
            lblSair.Click += pnlSair_Click;
            // 
            // pnlBotao4
            // 
            pnlBotao4.Controls.Add(pnlBtnAulas);
            pnlBotao4.Controls.Add(btnPlanos);
            pnlBotao4.Location = new Point(3, 344);
            pnlBotao4.Margin = new Padding(3, 4, 3, 4);
            pnlBotao4.Name = "pnlBotao4";
            pnlBotao4.Size = new Size(138, 56);
            pnlBotao4.TabIndex = 4;
            // 
            // pnlBtnAulas
            // 
            pnlBtnAulas.BackColor = Color.Aquamarine;
            pnlBtnAulas.Location = new Point(131, 0);
            pnlBtnAulas.Margin = new Padding(3, 4, 3, 4);
            pnlBtnAulas.Name = "pnlBtnAulas";
            pnlBtnAulas.Size = new Size(10, 55);
            pnlBtnAulas.TabIndex = 10;
            pnlBtnAulas.Visible = false;
            // 
            // btnPlanos
            // 
            btnPlanos.Cursor = Cursors.Hand;
            btnPlanos.FlatAppearance.BorderSize = 0;
            btnPlanos.FlatStyle = FlatStyle.Popup;
            btnPlanos.Font = new Font("Impact", 13.8F);
            btnPlanos.ForeColor = SystemColors.ButtonHighlight;
            btnPlanos.Location = new Point(12, 5);
            btnPlanos.Margin = new Padding(3, 4, 3, 4);
            btnPlanos.Name = "btnPlanos";
            btnPlanos.Size = new Size(95, 45);
            btnPlanos.TabIndex = 3;
            btnPlanos.Text = "Planos";
            btnPlanos.UseVisualStyleBackColor = true;
            btnPlanos.Click += btnFichasAluno_Click;
            // 
            // pnlBotao3
            // 
            pnlBotao3.Controls.Add(pnlBtnPlanos);
            pnlBotao3.Controls.Add(btnProfissionais);
            pnlBotao3.Location = new Point(3, 288);
            pnlBotao3.Margin = new Padding(3, 4, 3, 4);
            pnlBotao3.Name = "pnlBotao3";
            pnlBotao3.Size = new Size(138, 56);
            pnlBotao3.TabIndex = 3;
            // 
            // pnlBtnPlanos
            // 
            pnlBtnPlanos.BackColor = Color.Aquamarine;
            pnlBtnPlanos.Location = new Point(131, -1);
            pnlBtnPlanos.Margin = new Padding(3, 4, 3, 4);
            pnlBtnPlanos.Name = "pnlBtnPlanos";
            pnlBtnPlanos.Size = new Size(10, 55);
            pnlBtnPlanos.TabIndex = 12;
            pnlBtnPlanos.Visible = false;
            // 
            // btnProfissionais
            // 
            btnProfissionais.Cursor = Cursors.Hand;
            btnProfissionais.FlatAppearance.BorderSize = 0;
            btnProfissionais.FlatStyle = FlatStyle.Popup;
            btnProfissionais.Font = new Font("Impact", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfissionais.ForeColor = SystemColors.ButtonHighlight;
            btnProfissionais.Location = new Point(12, 4);
            btnProfissionais.Margin = new Padding(3, 4, 3, 4);
            btnProfissionais.Name = "btnProfissionais";
            btnProfissionais.Size = new Size(95, 45);
            btnProfissionais.TabIndex = 2;
            btnProfissionais.Text = "Profissionais";
            btnProfissionais.UseVisualStyleBackColor = true;
            btnProfissionais.Click += btnPlanos_Click;
            // 
            // pnlBotao2
            // 
            pnlBotao2.Controls.Add(pnlBtnProf);
            pnlBotao2.Controls.Add(btnAlunos);
            pnlBotao2.Location = new Point(3, 231);
            pnlBotao2.Margin = new Padding(3, 4, 3, 4);
            pnlBotao2.Name = "pnlBotao2";
            pnlBotao2.Size = new Size(138, 56);
            pnlBotao2.TabIndex = 2;
            // 
            // pnlBtnProf
            // 
            pnlBtnProf.BackColor = Color.Aquamarine;
            pnlBtnProf.Location = new Point(131, -1);
            pnlBtnProf.Margin = new Padding(3, 4, 3, 4);
            pnlBtnProf.Name = "pnlBtnProf";
            pnlBtnProf.Size = new Size(10, 55);
            pnlBtnProf.TabIndex = 11;
            pnlBtnProf.Visible = false;
            // 
            // btnAlunos
            // 
            btnAlunos.Cursor = Cursors.Hand;
            btnAlunos.FlatAppearance.BorderSize = 0;
            btnAlunos.FlatStyle = FlatStyle.Popup;
            btnAlunos.Font = new Font("Impact", 13.8F);
            btnAlunos.ForeColor = SystemColors.ButtonHighlight;
            btnAlunos.Location = new Point(15, 5);
            btnAlunos.Margin = new Padding(3, 4, 3, 4);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(95, 45);
            btnAlunos.TabIndex = 1;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = true;
            btnAlunos.Click += btnProfissionais_Click;
            // 
            // pnlBotao1
            // 
            pnlBotao1.Controls.Add(pnlBtnAlunos);
            pnlBotao1.Controls.Add(btnPerfil);
            pnlBotao1.Location = new Point(3, 175);
            pnlBotao1.Margin = new Padding(3, 4, 3, 4);
            pnlBotao1.Name = "pnlBotao1";
            pnlBotao1.Size = new Size(138, 56);
            pnlBotao1.TabIndex = 1;
            // 
            // pnlBtnAlunos
            // 
            pnlBtnAlunos.BackColor = Color.Aquamarine;
            pnlBtnAlunos.Location = new Point(131, 0);
            pnlBtnAlunos.Margin = new Padding(3, 4, 3, 4);
            pnlBtnAlunos.Name = "pnlBtnAlunos";
            pnlBtnAlunos.Size = new Size(13, 55);
            pnlBtnAlunos.TabIndex = 11;
            pnlBtnAlunos.Visible = false;
            // 
            // btnPerfil
            // 
            btnPerfil.Cursor = Cursors.Hand;
            btnPerfil.FlatAppearance.BorderColor = Color.White;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Popup;
            btnPerfil.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPerfil.ForeColor = SystemColors.ButtonHighlight;
            btnPerfil.Location = new Point(12, 5);
            btnPerfil.Margin = new Padding(3, 4, 3, 4);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(95, 45);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnAlunos_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureLogo);
            pnlLogo.Location = new Point(15, 19);
            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(123, 122);
            pnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(13, 4);
            pictureLogo.Margin = new Padding(3, 4, 3, 4);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(95, 119);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(934, 850);
            Controls.Add(pnlnavegacao);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(934, 850);
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body Sharp";
            pnlnavegacao.ResumeLayout(false);
            pnlSair.ResumeLayout(false);
            pnlSair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBotao4.ResumeLayout(false);
            pnlBotao3.ResumeLayout(false);
            pnlBotao2.ResumeLayout(false);
            pnlBotao1.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlnavegacao;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlBotao4;
        private System.Windows.Forms.Panel pnlBotao3;
        private System.Windows.Forms.Panel pnlBotao2;
        private System.Windows.Forms.Panel pnlBotao1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel pnlBtnAulas;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnProfissionais;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Panel pnlBtnPlanos;
        private System.Windows.Forms.Panel pnlBtnProf;
        private System.Windows.Forms.Panel pnlBtnAlunos;
        private System.Windows.Forms.Panel pnlSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSair;
    }
}

