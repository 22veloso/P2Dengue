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
    public partial class FrmListarUsuario : Form
    {
        public FrmListarUsuario()
        {
            InitializeComponent();
        }

        private void dgv_listarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            dgv_listarUsuario.DataSource = UsuarioServicos.ObterTodosUsuarios();
        }

        private void btn_fechar2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
