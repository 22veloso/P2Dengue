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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usuario = new FrmCadUsuario();
            usuario.MdiParent = this;
            usuario.Show();
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarUsuario us =new FrmListarUsuario();
            us.MdiParent = this;
            us.Show();
          
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar2_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
