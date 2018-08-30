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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Home Hom = new Home();
            Hom.MdiParent = this;
            Hom.Show();
            lblData.Text = "Data :" + DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora :" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAluno alu = new CadAluno();
            alu.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadDisc disc = new CadDisc();
            disc.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair??", "Título ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
