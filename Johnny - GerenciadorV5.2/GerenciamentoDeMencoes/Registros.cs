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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            RegistroMencaoAluno reg = new RegistroMencaoAluno();
            reg.Show();
        }
    }
}
