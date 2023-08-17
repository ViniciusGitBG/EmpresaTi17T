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
    public partial class atualizar : Form
    {
        DAO atu;

        public atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }

        private void atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "Nome", nome.Text);// atualizar o nome
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "telefone",telefone.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "Cidade", cidade.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "UF", UF.Text);
            MessageBox.Show("Dados Atualizar com Sucesso!");
        }// fim do atualizar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim cpf

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }// fim nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }// fim cidade

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim UF
    }//fim da classe
}// fim do projeto
