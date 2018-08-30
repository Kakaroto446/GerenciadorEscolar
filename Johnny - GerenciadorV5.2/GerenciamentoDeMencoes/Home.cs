using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciamentoDeMencoes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Cadastros Cad = new Cadastros();
            Cad.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas Consu = new Consultas();
            Consu.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistraMencao_Click(object sender, EventArgs e)
        {
            RegistroMencaoAluno reg = new RegistroMencaoAluno();
            reg.Show();
        }
    }
}
