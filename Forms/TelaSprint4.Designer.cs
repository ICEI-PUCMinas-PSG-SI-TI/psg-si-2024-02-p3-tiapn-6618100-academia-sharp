namespace BodyShape_TI.Forms
{
    partial class TelaSprint4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSprint4));
            pnlnavegacao = new Panel();
            pnlSair = new Panel();
            button1 = new Button();
            pnlLogo = new Panel();
            pictureLogo = new PictureBox();
            label2 = new Label();
            OP3 = new Button();
            OP2 = new Button();
            OP1 = new Button();
            pnlnavegacao.SuspendLayout();
            pnlSair.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlnavegacao
            // 
            pnlnavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlnavegacao.BackColor = Color.FromArgb(36, 44, 50);
            pnlnavegacao.Controls.Add(pnlSair);
            pnlnavegacao.Controls.Add(pnlLogo);
            pnlnavegacao.Location = new Point(1, 2);
            pnlnavegacao.MinimumSize = new Size(123, 641);
            pnlnavegacao.Name = "pnlnavegacao";
            pnlnavegacao.Size = new Size(123, 726);
            pnlnavegacao.TabIndex = 4;
            // 
            // pnlSair
            // 
            pnlSair.Controls.Add(button1);
            pnlSair.Cursor = Cursors.Hand;
            pnlSair.Location = new Point(8, 574);
            pnlSair.Name = "pnlSair";
            pnlSair.Size = new Size(100, 52);
            pnlSair.TabIndex = 15;
            pnlSair.Paint += pnlSair_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(13, 11);
            button1.Name = "button1";
            button1.Size = new Size(76, 29);
            button1.TabIndex = 142;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureLogo);
            pnlLogo.Location = new Point(10, 14);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(108, 92);
            pnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(11, 3);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(83, 86);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 137);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 144;
            label2.Text = "OPÇÕES";
            // 
            // OP3
            // 
            OP3.BackColor = Color.Aqua;
            OP3.Location = new Point(331, 348);
            OP3.Name = "OP3";
            OP3.Size = new Size(260, 46);
            OP3.TabIndex = 143;
            OP3.Text = "Associar aluno a um plano";
            OP3.UseVisualStyleBackColor = false;
            OP3.Click += OP3_Click_1;
            // 
            // OP2
            // 
            OP2.BackColor = Color.Aqua;
            OP2.Location = new Point(331, 273);
            OP2.Name = "OP2";
            OP2.Size = new Size(260, 46);
            OP2.TabIndex = 142;
            OP2.Text = "Cadastrar Plano";
            OP2.UseVisualStyleBackColor = false;
            OP2.Click += OP2_Click;
            // 
            // OP1
            // 
            OP1.BackColor = Color.Aqua;
            OP1.Location = new Point(331, 196);
            OP1.Name = "OP1";
            OP1.Size = new Size(260, 46);
            OP1.TabIndex = 141;
            OP1.Text = "Cadastrar Aluno";
            OP1.UseVisualStyleBackColor = false;
            OP1.Click += OP1_Click;
            // 
            // TelaSprint4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(label2);
            Controls.Add(OP3);
            Controls.Add(OP2);
            Controls.Add(OP1);
            Controls.Add(pnlnavegacao);
            Name = "TelaSprint4";
            Text = "TelaSprint4";
            pnlnavegacao.ResumeLayout(false);
            pnlSair.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlnavegacao;
        private Panel pnlSair;
        private Panel pnlLogo;
        private PictureBox pictureLogo;
        private Label label2;
        private Button OP3;
        private Button OP2;
        private Button OP1;
        private Button button1;
    }
}