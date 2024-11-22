using BodyShape_TI.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BS_Projeto
{

    //TODO: Retirar plano e ID aluno da tela
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*ConexaoBD conexaoDB = new ConexaoBD();

            string query = @"INSERT INTO tbl_aluno
             (nome, dataNasc, sexo, logradouro, numero, complemento, bairro, cidade, estado, telefone, tbl_Atendente_tbl_Funcionario_id)
             VALUES 
             (@nome, @dataNasc, @sexo, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @telefone, @tbl_Atendente_tbl_Funcionario_id);";


            try
            {

                if (!DateTime.TryParse(txtDataNasc.Text, out DateTime dataNascimento))
                {
                    MessageBox.Show("Data de nascimento inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                if (cboxGenero.Text != "M" && cboxGenero.Text != "F")
                {
                    MessageBox.Show("O campo Sexo deve ser 'M' ou 'F'.");
                    return;
                }

                if (!long.TryParse(txtTelefone.Text, out long telefone) || txtTelefone.Text.Length < 10)
                {
                    MessageBox.Show("O número de telefone é inválido. Deve conter pelo menos 10 dígitos.");
                    return;
                }

                // Inicialização do comando
                using (MySqlCommand insert = new MySqlCommand(query, conexaoDB.IniciaConexaoBD()))
                {

                    insert.Parameters.AddWithValue("@nome", txtNome.Text);
                    insert.Parameters.AddWithValue("@data_nascimento", dataNascimento.ToString("yyyy-MM-dd"));
                    insert.Parameters.AddWithValue("@sexo", cboxGenero.Text);
                    insert.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                    insert.Parameters.AddWithValue("@numero", int.TryParse(txtNumero.Text, out int numero) ? numero : 0);
                    insert.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    insert.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    insert.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    insert.Parameters.AddWithValue("@estado", txtEstado.Text);
                    insert.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    insert.Parameters.AddWithValue("@tbl_Atendente_tbl_Funcionario_id", txtidAtendente.Text);

                    conexaoDB.conexao.Open();
                    insert.ExecuteNonQuery();
                    conexaoDB.conexao.Close();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir os dados: {ex.Message}");
            }*/
        }
    }
}
