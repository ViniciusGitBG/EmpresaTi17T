using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmpresaTi17T
{
     class DAO
    {
        public MySqlConnection  conexao;
        public long[] codigo;
        public string[] Nome;
        public string[] telefone;
        public string[] Cidade;
        public string[] UF;
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=empresaTi17T;uid=root;password=");

            try{
                conexao.Open();
                MessageBox.Show("Conectado!");

            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);

            }

        }// fim construtor

        //metodo inserção
        public string Inserir(long codigo, string Nome, string telefone,string Cidade, string cpf, string UF, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(codigo,Nome,telefone, Cidade, cpf,UF) values('{codigo}','{Nome}','{telefone}','{Cidade}','{UF}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";

            return resultado;

        }// fim do método inserir


        public void preencherVetor()
        {
            string query = "Select * from Pessoa";

            //Instanciar
            this.codigo    = new long[100];
            this.Nome      = new string[100];
            this.telefone  = new string[100];
            this.Cidade    = new string[100];
            this.UF        = new string[100];

            //preparar o comando

            MySqlCommand sql = new MySqlCommand(query, conexao);

            //leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt64(leitura["codigo"]);
                Nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"]+ "";
                Cidade[i] = leitura["Cidade"] + "";
                UF[i] = leitura["UF"] +"";
                i++;
                contador++;


            }// fim do while

            //encerro a comunicação com o banco 

            leitura.Close();

        }//fim do método preencher

        public int quantidadeDados()
        {
            return contador;
        }// fim do método quantidade de dados

        public string Atualizar(long codigo, string nomeTabela,string campo, string dado)
        {
            string query = $"update{nomeTabela}set {campo} ='{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado";

            return resultado;
        }// fim do método atualizar

        public string Excluir(long codigo, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!";
            return resultado;
        }// fim do método Excluir
    }// fim da classe
}//fim do projeto
