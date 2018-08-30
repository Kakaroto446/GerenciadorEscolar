using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GerenciamentoDeMencoes
{
    public partial class ConsultaCadDisc : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConn();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_disc;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_disc = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        public ConsultaCadDisc()
        {
            InitializeComponent();
        }

        private void carregar_grid()
        {
            //determinar o comando sql
            _query = "Select * from Disciplinas";

            //data command para executar
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //executa o data
            dr_disc = _dataCommand.ExecuteReader();

            //teste
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                dgv_disc.DataSource = bs_disc;
            }
            else
            {
                MessageBox.Show("Sem disciplina", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConsultaCadDisc_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.Text == "Sigla")
            {
                _query = "Select * from Disciplinas where sigla like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "Descrição")
            {
                _query = "Select * from Disciplinas where descricao like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "Código")
            {
                _query = "Select * from Disciplinas where cod_disciplina like '" + txt_pesquisar.Text + "%'";
            }
            else
            {
                MessageBox.Show("Sem nada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCampo.Focus();
            }

            txt_pesquisar.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }
            else
            {
                MessageBox.Show("Sem essa disciplina", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesquisar.Clear();
            }
        }

        private void btnQuant_Click(object sender, EventArgs e)
        {
            int a = bs_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgv_disc.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("favicon2.ICO"), 50, 25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE DISCIPLINA", new System.Drawing.Font("Times new roman", 16, FontStyle.Bold), Brushes.Black, 400, 143);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 169, 800, 169);
            // código
            e.Graphics.DrawString("CÓDIGO DA DISCIPLINA: " + linha.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 175);
            // descrição
            e.Graphics.DrawString("DESCRIÇÃO: " + linha.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 195);
            // sigla
            e.Graphics.DrawString("SIGLA: " + linha.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 215);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 1100, 800, 1100);

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Text = "Visualizando a impressão";   // título da janela
            printPreviewDialog1.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog1.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog1.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();
        }
    }
}
