namespace BS_Projeto
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnAdicionarBioimpedancia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(175, 66);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 40);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(308, 66);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 40);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPesquisar.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(175, 113);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(323, 28);
            this.txtPesquisar.TabIndex = 16;
            this.txtPesquisar.Text = "Pesquisar...";
            // 
            // btnAdicionarBioimpedancia
            // 
            this.btnAdicionarBioimpedancia.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarBioimpedancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarBioimpedancia.Font = new System.Drawing.Font("Impact", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarBioimpedancia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarBioimpedancia.Location = new System.Drawing.Point(504, 106);
            this.btnAdicionarBioimpedancia.Name = "btnAdicionarBioimpedancia";
            this.btnAdicionarBioimpedancia.Size = new System.Drawing.Size(166, 40);
            this.btnAdicionarBioimpedancia.TabIndex = 17;
            this.btnAdicionarBioimpedancia.Text = "Adicionar bioimpedância";
            this.btnAdicionarBioimpedancia.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Impact", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(676, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Adicionar ficha";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 382);
            this.dataGridView1.TabIndex = 19;
            // 
            // FormAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdicionarBioimpedancia);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormAlunos";
            this.Text = "FormAlunos";
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnAdicionarBioimpedancia, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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