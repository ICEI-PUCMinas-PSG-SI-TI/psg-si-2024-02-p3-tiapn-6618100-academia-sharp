﻿namespace BS_Projeto
{
    partial class FormAlunos
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
            btnCadastrar = new Button();
            btnEditar = new Button();
            txtPesquisar = new TextBox();
            btnAdicionarBioimpedancia = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(175, 82);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(127, 50);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(308, 82);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 50);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.ScrollBar;
            txtPesquisar.Font = new Font("Impact", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(175, 141);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(442, 28);
            txtPesquisar.TabIndex = 16;
            txtPesquisar.Text = "Pesquisar...";
            // 
            // btnAdicionarBioimpedancia
            // 
            btnAdicionarBioimpedancia.BackColor = Color.Black;
            btnAdicionarBioimpedancia.Cursor = Cursors.Hand;
            btnAdicionarBioimpedancia.Font = new Font("Impact", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarBioimpedancia.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionarBioimpedancia.Location = new Point(623, 132);
            btnAdicionarBioimpedancia.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarBioimpedancia.Name = "btnAdicionarBioimpedancia";
            btnAdicionarBioimpedancia.Size = new Size(166, 50);
            btnAdicionarBioimpedancia.TabIndex = 17;
            btnAdicionarBioimpedancia.Text = "Adicionar bioimpedância";
            btnAdicionarBioimpedancia.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(795, 132);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(127, 50);
            button2.TabIndex = 18;
            button2.Text = "Adicionar ficha";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(747, 478);
            dataGridView1.TabIndex = 19;
            // 
            // FormAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 850);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(btnAdicionarBioimpedancia);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormAlunos";
            Text = "FormAlunos";
            Controls.SetChildIndex(btnCadastrar, 0);
            Controls.SetChildIndex(btnEditar, 0);
            Controls.SetChildIndex(txtPesquisar, 0);
            Controls.SetChildIndex(btnAdicionarBioimpedancia, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnAdicionarBioimpedancia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}