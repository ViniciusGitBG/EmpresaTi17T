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
    public partial class excluir : Form
    {
        DAO exc;
        public excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "Pessoa");
            MessageBox.Show(result);
        }//Botão excluir

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// fim do cpf
    }
}
