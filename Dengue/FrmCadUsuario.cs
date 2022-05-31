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
            //Popular o resto

            new UsuarioServicos().Inserir(usuario);
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Carregar o Combo
            cboCidade.DataSource = new CidadeServicos().FindAll();
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";

        }
    }
}
