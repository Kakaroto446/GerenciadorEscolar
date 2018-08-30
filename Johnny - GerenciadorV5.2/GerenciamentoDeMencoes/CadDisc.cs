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
    public partial class CadDisc : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConn();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_disc;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_disc = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

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
                igualar_text();
            }
            else
            {
                MessageBox.Show("Sem alunos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblCod.DataBindings.Add("Text", bs_disc, "cod_disciplina");
            lblCod.DataBindings.Clear();
            txtDesc.DataBindings.Add("Text", bs_disc, "descricao");
            txtDesc.DataBindings.Clear();
            txtSigla.DataBindings.Add("Text", bs_disc, "sigla");
            txtSigla.DataBindings.Clear();
            txtSerie.DataBindings.Add("Text", bs_disc, "série");
            txtSerie.DataBindings.Clear();
        }

        public CadDisc()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Insert into Disciplinas (descricao,sigla,série) values ";
                _query += "('" + txtDesc.Text + "','" + txtSigla.Text + "','" + txtSerie.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    //carregar_grid();
                    MessageBox.Show("Incluso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na Inclusão", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void limpar()
        {
            lblCod.Text = "";
            txtDesc.Clear();
            txtSigla.Clear();
            txtSerie.Clear();
        }

        private bool valida()
        {
            bool erro = true;
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesc.Focus();
            }
            else if (txtSigla.Text == "")
            {
                MessageBox.Show("Insira a sigla", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSigla.Focus();
            }
            else if (txtSerie.Text == "")
            {
                MessageBox.Show("Insira a série", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSerie.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void CadDisc_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void dgv_disc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            igualar_text();
        }

        private void dgv_disc_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txb_pesquisar_TextChanged(object sender, EventArgs e)
        {
            igualar_text();
            _query = "Select * from Disciplinas where cod_disciplina like '" + txb_pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();
            igualar_text();
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }
            /*else
            {
                MessageBox.Show("Não temos essa disciplina", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_pesquisar.Text = "";
            }/*/
        }

        private void btn_primeiro_Click_1(object sender, EventArgs e)
        {
            //ponteiro --> primeiro registro
            bs_disc.MoveFirst();

            //iguala os dados
            igualar_text();
        }

        private void btn_ultimo_Click_1(object sender, EventArgs e)
        {
            //ponteiro --> ultimo registro
            bs_disc.MoveLast();

            //iguala os dados
            igualar_text();
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            if (bs_disc.Position == 0)
                MessageBox.Show("Primeiro arquivo :/", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bs_disc.MovePrevious();
                igualar_text();
            }
        }

        private void btn_proximo_Click_1(object sender, EventArgs e)
        {
            if (bs_disc.Count == bs_disc.Position + 1)
                MessageBox.Show("Último arquivo :/", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bs_disc.MoveNext();
                igualar_text();
            }
        }

        private void btn_novo_Click_1(object sender, EventArgs e)
        {
            limpar();
            txtDesc.Focus();
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            _query = "delete from Disciplinas where cod_disciplina like '" + lblCod.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Update Disciplinas set descricao ='" + txtDesc.Text + "',";
                _query += "sigla = '" + txtSigla.Text + "',";
                _query += "série = '" + txtSerie.Text + "' where cod_disciplina like '" + lblCod.Text + "'";
                igualar_text();
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show(_query, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
