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
    public partial class Form1 : Form
    {

        cadastrar cad;
        consultar con;
        atualizar atu;
        excluir exc;

        public Form1()
        {
            InitializeComponent();
            cad = new cadastrar();
            con = new consultar();
            atu = new atualizar();
            exc = new excluir();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//cadastrar

        private void button5_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();

        }//excluir

        private void button4_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();

        }//atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();

        }//consultar
    }
}
