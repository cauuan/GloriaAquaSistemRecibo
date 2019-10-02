using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAquaRecibo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frm = new frmAluno();
            frm.ShowDialog();
        }

        private void ModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModalidade frm = new frmModalidade();
            frm.ShowDialog();
        }

        private void ResponsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsavel frm = new frmResponsavel();
            frm.ShowDialog();
        }
    }
}
