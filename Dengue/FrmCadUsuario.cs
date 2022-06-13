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

            Usuario usuario = new Usuario();

            usuario.Nome = tbNome.Text;
            usuario.Telefone = tbTelefone.Text;
            usuario.Email = tbEmail.Text;
            UsuarioServicos.NovoUsuario(usuario);
            MessageBox.Show("dados salvos!!");


            Endereco endereco = new Endereco();

            endereco.Logradouro = tbLagradouro.Text;
            endereco.Bairro = tbBairro.Text;
            endereco.Cep = tbCep.Text;
            EndereçoServiços.NovoEndereco(endereco);
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            string vqueryCidade = @" SELECT Id, Nome FROM Cidade";
            cboCidade.Items.Clear();
            cboCidade.DataSource = CidadeServiços.dql(vqueryCidade);
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
            tbLagradouro.Clear();
            tbBairro.Clear();
            tbCep.Clear();
            tbNome.Focus();


        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
    
    

