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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }
        public void SalvarAluno()
        {

        }
        public void AddResp()
        {
            frmResponsavel frm = new frmResponsavel();
            frm.ShowDialog();
        }
        public void AddMod()
        {

        }
        public void ExMod()
        {

        }

        private void BtnSalvarAluno_Click(object sender, EventArgs e)
        {
            SalvarAluno();
        }

        private void BtnAAddResponsavel_Click(object sender, EventArgs e)
        {
            string n = null;
            AddResp();
        }

        private void BtnAddMod_Click(object sender, EventArgs e)
        {
            AddMod();
        }

        private void BtnExMod_Click(object sender, EventArgs e)
        {
            ExMod();
        }
    }
}
