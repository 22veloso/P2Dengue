using Models;
using Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2Dengue
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Endereco endereco = new Endereco();
            endereco.Logradouro = tbLagradouro.Text;
            endereco.Bairro = new Bairro() { Id = int.Parse(cboBairro.SelectedValue.ToString()) };
            endereco.Cidade = new Cidade() { NomeCidade = txtCidade.Text };
            endereco.Cep = tbCep.Text;
            long idEndereco = EndereçoServiços.NovoEndereco(endereco);

            Usuario usuario = new Usuario();
            usuario.Nome = tbNome.Text;
            usuario.Telefone = tbTelefone.Text;
            usuario.Email = tbEmail.Text;
            usuario.Endereco = new Endereco() { Id = (int)idEndereco };
            usuario.Status = cbStatus.Text;
            UsuarioServicos.NovoUsuario(usuario);
            MessageBox.Show("dados salvos!!");
            
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

            string vqueryBairro = @" SELECT Id, Descricao FROM Bairro ORDER BY Descricao";
            cboBairro.Items.Clear();
            cboBairro.DataSource = BairroServicos.dql(vqueryBairro);
            cboBairro.ValueMember = "Id";
            cboBairro.DisplayMember = "Descricao";

            Dictionary<string, string> caso = new Dictionary<string, string>();
            caso.Add("TestePositivo", "SIM");
            caso.Add("TesteNegativo", "NAO");
            cbStatus.Items.Clear();
            cbStatus.DataSource = new BindingSource(caso, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";

            dgvUsuario.DataSource = EndereçoServiços.ObterTodosEnderecos();
            

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e) { 
            DataTable dt = new DataTable();
           string Descricao = txtPesquisa.Text;
            if(Descricao == "")
            {
                MessageBox.Show("Bairro nao encontrado!");
                txtPesquisa.Focus();
                return;
            }

            string sql = @" SELECT Descricao FROM Bairro WHERE Descricao= '" + txtPesquisa.Text+ "'";
            dgvUsuario.DataSource = BairroServicos.ObterBairro(sql);




        }

   
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
            tbLagradouro.Clear();
            txtCidade.Clear();
            tbCep.Clear();
            tbNome.Focus();


        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = EndereçoServiços.ObterTodosEnderecos();
        }

        private void cboBairro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

