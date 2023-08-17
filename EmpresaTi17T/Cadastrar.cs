using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpresaTi17T
{
    public partial class cadastrar : Form
    {
        DAO conectar;
        public cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();// ligando o formulario ao conector do banco de dados 

        }// fim do construtor

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string result = conectar.Inserir(Convert.ToInt64(codigo.Text), Nome.Text,
                    telefone.Text, cidade.Text, UF.Text, "Pessoa");
                MessageBox.Show(result);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }
        }// fim do botao inserir

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }// cadastrar nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// cadastrar telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }// cadastrar cidade

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cadastrar UF

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// cadastrar cpf
    }// fim da classe
}// fim do projeto
