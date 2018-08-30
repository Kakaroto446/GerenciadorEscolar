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
    public partial class RegistroMencaoAluno : Form
    {
        //obter conexao da classe de conexão
        OleDbConnection conn = Conexao.obterConn();

        //dr e ds para a tabela aluno
        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();
        //dr e ds para a tabela disciplina
        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();
        //dr e ds para a tabela menção
        OleDbDataReader dr_menc;
        BindingSource bs_menc = new BindingSource();
        //dr e ds para o grid (inner join)
        OleDbDataReader dr_reg_notas;
        BindingSource bs_reg_notas = new BindingSource();

        //cria a variável que receberá a query
        String _query;

        private void carregar_aluno()
        {
            //Determine a query desejada
            _query = "SELECT * from Alunos order by nome";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataComand = new OleDbCommand(_query, conn);
            //execute o metodo ExecuteReader que retornará um DataReader preenchido com a query
            dr_alu = _dataComand.ExecuteReader();
            //Teste para verificar se retornará linhas
            if (dr_alu.HasRows == true)
            {
                bs_alu.DataSource = dr_alu;
                cmb_aluno.DataSource = bs_alu;
                cmb_aluno.DisplayMember = "nome";
                cmb_aluno.ValueMember = "matricula";
                lblMat.Text = cmb_aluno.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Sem esse aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_disc()
        {
            //Determine a query desejada
            _query = "SELECT * from Disciplinas order by cod_disciplina";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataComand = new OleDbCommand(_query, conn);
            //execute o metodo ExecuteReader que retornará um DataReader preenchido com a query
            dr_disc = _dataComand.ExecuteReader();
            //Teste para verificar se retornará linhas
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                cmb_disc.DataSource = bs_disc;
                cmb_disc.DisplayMember = "descricao";
                cmb_disc.ValueMember = "cod_disciplina";
                lblCod.Text = cmb_disc.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Sem essa disciplina", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_mencao()
        {
            //Determine a query desejada
            _query = "SELECT * from Registro_Mencoes order by mencao";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataComand = new OleDbCommand(_query, conn);
            //execute o metodo ExecuteReader que retornará um DataReader preenchido com a query
            dr_menc = _dataComand.ExecuteReader();
            //Teste para verificar se retornará linhas
            if (dr_alu.HasRows == true)
            {
                bs_menc.DataSource = dr_menc;
                cmb_mencao.DataSource = bs_menc;
                cmb_mencao.DisplayMember = "mencao";
                cmb_mencao.ValueMember = "mencao";
                //lblMat.Text = cmb_aluno.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Sem esse aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void carregar_grid()
        {
            //determinar o comando sql
            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";

            //data command para executar
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //executa o data
            dr_reg_notas = _dataCommand.ExecuteReader();

            //teste
            if (dr_reg_notas.HasRows == true)
            {
                bs_reg_notas.DataSource = dr_reg_notas;
                dgv.DataSource = bs_reg_notas;
                //igualar_text();
            }
            else
            {
                MessageBox.Show("Sem aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public RegistroMencaoAluno()
        {
            InitializeComponent();
        }

        private void RegistroMencaoAluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
            carregar_aluno();
            carregar_disc();
            carregar_mencao();
        }

        /*private void cmb_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_aluno();
        }
        private void cmb_disc_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_disc();
        }
        private void cmb_mencao_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_mencao();
        }*/

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Insert into Registro_Mencoes (matricula, cod_disciplina, mencao) values ";
                _query += "('" + lblMat.Text + "','" + lblCod.Text + "','" + cmb_mencao.Text + "')";
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
            if (cmb_aluno.Text == "")
            {
                MessageBox.Show("Insira o nome do aluno desejado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_aluno.Focus();
            }
            else if (cmb_disc.Text == "")
            {
                MessageBox.Show("Insira a disciplina desejada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_disc.Focus();
            }
            else if (cmb_mencao.Text == "")
            {
                MessageBox.Show("Insira a menção do aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_mencao.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }
    }
}
