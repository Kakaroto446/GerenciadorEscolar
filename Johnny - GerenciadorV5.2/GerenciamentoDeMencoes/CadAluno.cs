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
    public partial class CadAluno : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConn();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_alunos;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_alunos = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        /*private void carregar_grid()
        {
            //determinar o comando sql
            _query = "Select * from Alunos";

            //data command para executar
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //executa o data
            dr_alunos = _dataCommand.ExecuteReader();

            //teste
            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
                dgv_alunos.DataSource = bs_alunos;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Sem alunos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }*/

        private void carregar_grid()
        {
            //determinar o comando sql
            _query = "Select * from Alunos";

            //data command para executar
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //executa o data
            dr_alunos = _dataCommand.ExecuteReader();

            //teste
            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
                dgv_aluno.DataSource = bs_alunos;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Sem aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblMat.DataBindings.Add("Text", bs_alunos, "Matricula");
            lblMat.DataBindings.Clear();
            txtNome.DataBindings.Add("Text", bs_alunos, "Nome");
            txtNome.DataBindings.Clear();
            txtEnd.DataBindings.Add("Text", bs_alunos, "Endereco");
            txtEnd.DataBindings.Clear();
            txtNum.DataBindings.Add("Text", bs_alunos, "numero");
            txtNum.DataBindings.Clear();
            txtBairro.DataBindings.Add("Text", bs_alunos, "bairro");
            txtBairro.DataBindings.Clear();
            txtCid.DataBindings.Add("Text", bs_alunos, "cidade");
            txtCid.DataBindings.Clear();
            txtCEP.DataBindings.Add("Text", bs_alunos, "cep");
            txtCEP.DataBindings.Clear();
            txtRG.DataBindings.Add("Text", bs_alunos, "RG");
            txtRG.DataBindings.Clear();
            txtFone.DataBindings.Add("Text", bs_alunos, "telefone");
            txtFone.DataBindings.Clear();
            txtCPF.DataBindings.Add("Text", bs_alunos, "cpf");
            txtCPF.DataBindings.Clear();
            txtSexo.DataBindings.Add("Text", bs_alunos, "sexo");
            txtSexo.DataBindings.Clear();
        }

        private void CadAluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        public CadAluno()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Insert into Alunos (Nome,Nasc,Endereco,numero,bairro,cidade,cep,RG,telefone,cpf,sexo) values ";
                _query += "('" + txtNome.Text + "','" + txtNasc.Text + "','" + txtEnd.Text + "','" + txtNum.Text + "','" + txtBairro.Text + "','" + txtCid.Text + "','" + txtCEP.Text + "','" + txtRG.Text + "','" + txtFone.Text + "','" + txtCPF.Text + "','" + txtSexo.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na Inclusão", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool valida()
        {
            bool erro = true;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira o nome do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else if (txtRG.Text == "")
            {
                MessageBox.Show("Insira o RG do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRG.Focus();
            }
            else if (txtCEP.Text == "")
            {
                MessageBox.Show("Insira o CEP do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCEP.Focus();
            }
            else if (txtNum.Text == "")
            {
                MessageBox.Show("Insira o número do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNum.Focus();
            }
            else if (txtFone.Text == "")
            {
                MessageBox.Show("Insira o telefone do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFone.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void limpar()
        {
            lblMat.Text = "";
            txtNome.Clear();
            //txtNasc.Clear();
            txtEnd.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            txtCid.Clear();
            txtCEP.Clear();
            txtRG.Clear();
            txtFone.Clear();
            txtCPF.Clear();
            txtSexo.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void dgv_aluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            igualar_text();
        }

        private void dgv_aluno_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txb_pesquisar_TextChanged(object sender, EventArgs e)
        {

            _query = "Select * from Alunos where nome like '" + txb_pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_alunos = _dataCommand.ExecuteReader();

            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
            }
            else
            {
                MessageBox.Show("Não temos isso ai", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_pesquisar.Text = "";
            }
            igualar_text();
        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            //ponteiro --> primeiro registro
            bs_alunos.MoveFirst();

            //iguala os dados
            igualar_text();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            //ponteiro --> ultimo registro
            bs_alunos.MoveLast();

            //iguala os dados
            igualar_text();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (bs_alunos.Position == 0)
                MessageBox.Show("Primeiro arquivo :/", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bs_alunos.MovePrevious();
                igualar_text();
            }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (bs_alunos.Count == bs_alunos.Position + 1)
                MessageBox.Show("Último arquivo :/", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bs_alunos.MoveNext();
                igualar_text();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limpar();
            txtNome.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Alunos where Matricula like '" + lblMat.Text + "'";
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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Update Alunos set Nome ='" + txtNome.Text + "',";
                _query += "Nasc = '" + txtNasc.Text + "',";
                _query += "Endereco = '" + txtEnd.Text + "',";
                _query += "numero = '" + txtNum.Text + "',";
                _query += "bairro = '" + txtBairro.Text + "',";
                _query += "cidade = '" + txtCid.Text + "',";
                _query += "cep = '" + txtCEP.Text + "',";
                _query += "RG = '" + txtRG.Text + "',";
                _query += "telefone = '" + txtFone.Text + "',";
                _query += "cpf = '" + txtCPF.Text + "',";
                _query += "sexo = '" + txtSexo.Text + "' where Matricula like '" + lblMat.Text + "'";
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

        private void lbl_pesquisar_Click(object sender, EventArgs e)
        {

        }        
    }
}
