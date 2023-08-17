using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTi17T
{
    public partial class consultar : Form
    {
        DAO consul;
        public consultar()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas(); //nomear os títulos das colunas
            AdicionarDados();// preenchendo o dataGridView1
            consul = new DAO();
        }// fim do construtor

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "codigo";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";

        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false; // adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//remensionar colunas
            dataGridView1.AllowUserToResizeRows = false;//remensionar linhas
            dataGridView1.ColumnCount = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }// fim 

        public void AdicionarDados()
        {
            consul.preencherVetor();//preenchendo os vetores
            for (int i = 0; i < consul.quantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.Nome[i], consul.telefone[i], consul.Cidade[i], consul.UF[i]);
            }
            
        }//fim do método

    }//fim da classe
}// fim do projeto
