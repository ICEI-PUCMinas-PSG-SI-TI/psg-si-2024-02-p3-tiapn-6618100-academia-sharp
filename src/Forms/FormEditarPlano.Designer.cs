namespace BodyShape_TI.Forms
{
    partial class FormEditarPlano
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
            txtTipoPlano = new TextBox();
            label1 = new Label();
            txtValorPlano = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            button2 = new Button();
            txtPlanoID = new TextBox();
            label2 = new Label();
            listViewPlanos = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(22, 334);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 51);
            btnCancelar.TabIndex = 134;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTipoPlano
            // 
            txtTipoPlano.Location = new Point(267, 287);
            txtTipoPlano.Name = "txtTipoPlano";
            txtTipoPlano.Size = new Size(170, 27);
            txtTipoPlano.TabIndex = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(267, 259);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 129;
            label1.Text = "Tipo do Plano:";
            // 
            // txtValorPlano
            // 
            txtValorPlano.Location = new Point(36, 287);
            txtValorPlano.Name = "txtValorPlano";
            txtValorPlano.Size = new Size(170, 27);
            txtValorPlano.TabIndex = 127;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(36, 259);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 22);
            lblNome.TabIndex = 128;
            lblNome.Text = "Valor Plano:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 43);
            panel1.TabIndex = 126;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(443, 12);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(22, 21);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(13, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(95, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar Plano";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(310, 334);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(127, 51);
            button2.TabIndex = 137;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtPlanoID
            // 
            txtPlanoID.Location = new Point(183, 65);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(54, 27);
            txtPlanoID.TabIndex = 135;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(165, 22);
            label2.TabIndex = 136;
            label2.Text = "Informe o ID do Plano:";
            // 
            // listViewPlanos
            // 
            listViewPlanos.Location = new Point(36, 113);
            listViewPlanos.Margin = new Padding(3, 4, 3, 4);
            listViewPlanos.Name = "listViewPlanos";
            listViewPlanos.Size = new Size(401, 133);
            listViewPlanos.TabIndex = 138;
            listViewPlanos.UseCompatibleStateImageBehavior = false;
            listViewPlanos.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // FormEditarPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 416);
            Controls.Add(listViewPlanos);
            Controls.Add(button2);
            Controls.Add(txtPlanoID);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(txtTipoPlano);
            Controls.Add(label1);
            Controls.Add(txtValorPlano);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEditarPlano";
            Text = "FormEditarPlano";
            Load += FormEditarPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtTipoPlano;
        private Label label1;
        private TextBox txtValorPlano;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private Button button2;
        private TextBox txtPlanoID;
        private Label label2;
        private ListView listViewPlanos;
    }
}