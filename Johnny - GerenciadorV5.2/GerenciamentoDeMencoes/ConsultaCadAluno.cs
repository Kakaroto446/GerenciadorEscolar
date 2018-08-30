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
    public partial class ConsultaCadAluno : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConn();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_aluno;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_aluno = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        public ConsultaCadAluno()
        {
            InitializeComponent();
        }

        private void carregar_grid()
        {
            //determinar o comando sql
            _query = "Select * from Alunos";

            //data command para executar
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //executa o data
            dr_aluno = _dataCommand.ExecuteReader();

            //teste
            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
                dgv_aluno.DataSource = bs_aluno;
            }
            else
            {
                MessageBox.Show("Sem esse aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConsultaCadAluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cmbCampo.Text == "Matricula")
            {
                _query = "Select * from Alunos where Matricula like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "Nome")
            {
                _query = "Select * from Alunos where Nome like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "Nasc")
            {
                _query = "Select * from Alunos where Nasc like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "Endereco")
            {
                _query = "Select * from Alunos where Endereco like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "numero")
            {
                _query = "Select * from Alunos where numero like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "bairro")
            {
                _query = "Select * from Alunos where bairro like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "cidade")
            {
                _query = "Select * from Alunos where cidade like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "cep")
            {
                _query = "Select * from Alunos where cep like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "RG")
            {
                _query = "Select * from Alunos where RG like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "telefone")
            {
                _query = "Select * from Alunos where telefone like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "cpf")
            {
                _query = "Select * from Alunos where cpf like '" + txt_pesquisar.Text + "%'";
            }
            else if (cmbCampo.Text == "sexo")
            {
                _query = "Select * from Alunos where sexo like '" + txt_pesquisar.Text + "%'";
            }
            else
            {
                MessageBox.Show("Sem nada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCampo.Focus();
            }

            txt_pesquisar.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_aluno = _dataCommand.ExecuteReader();

            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
            }
            else
            {
                MessageBox.Show("Sem essa disciplina", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesquisar.Clear();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgv_aluno.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("favicon2.ICO"), 50, 25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE ALUNO", new System.Drawing.Font("Times new roman", 16, FontStyle.Bold), Brushes.Black, 400, 143);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 169, 800, 169);
            //Matrícula
            e.Graphics.DrawString("MATRÍCULA DO ALUNO: " + linha.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 175);
            //Nome
            e.Graphics.DrawString("NOME: " + linha.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 195);
            //Endereço
            e.Graphics.DrawString("ENDEREÇO: " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 215);
            // código
            e.Graphics.DrawString("NÚMERO: " + linha.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 235);
            // descrição
            e.Graphics.DrawString("BAIRRO: " + linha.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 255);
            // sigla
            e.Graphics.DrawString("CIDADE: " + linha.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 275);

            e.Graphics.DrawString("CEP: " + linha.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 295);
            // descrição
            e.Graphics.DrawString("RG: " + linha.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 315);
            // sigla
            e.Graphics.DrawString("TELEFONE: " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 335);

            e.Graphics.DrawString("CPF: " + linha.Cells["cpf"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 355);
            //linha do rodapé
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
