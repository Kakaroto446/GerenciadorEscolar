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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            CadAluno alu = new CadAluno();
            alu.Show();
            Close();
        }

        private void btnCadDisc_Click(object sender, EventArgs e)
        {
            CadDisc disc = new CadDisc();
            disc.Show();
            Close();
        }
    }
}
