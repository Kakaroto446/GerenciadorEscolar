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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void btnCadDisc_Click(object sender, EventArgs e)
        {
            ConsultaCadDisc consul = new ConsultaCadDisc();
            consul.Show();
            Close();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            ConsultaCadAluno consul = new ConsultaCadAluno();
            consul.Show();
            Close();
        }
    }
}
