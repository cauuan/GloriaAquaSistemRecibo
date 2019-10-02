using Controllers.Repositorios;
using Entidades;
using System;
using System.Windows.Forms;

namespace SistemaAquaRecibo
{
    public partial class frmAluno : Form
    {
        AlunoResp objResp = null;
        Aluno objEnti = null;
        public frmAluno()
        {
            InitializeComponent();
        }
        public void SalvarAluno()
        {
            objEnti = new Aluno();
            objResp = new AlunoResp();
            objEnti.Id = Convert.ToInt32(lblIdAluno.Text);
            objEnti.matricula = txtMatricula.Text;
            objEnti.nome = txtNome.Text;
            objEnti.nascimento = DateTime.Parse(mkbNascimento.Text);
            objEnti.cpf = mkbCPF.Text;
            objEnti.rg = txtRG.Text;
            objEnti.naturalidade = txtNaturalidade.Text;
            objEnti.nacionalidade = txtNacionalidade.Text;
            objEnti.endereco = txtEndereco.Text;
            objEnti.email = txtEmail.Text;
            objEnti.numero = txtNumero.Text;
            objEnti.cep = txtCEP.Text;
            objEnti.fone = txtFone.Text;
            objEnti.whatsapp = txtWhatsapp.Text;
            objEnti.vencimento = cbVencimento.Text;


            //aEnti.sexo = cbSexo.Text;
            if (objEnti.Id == 0)
            {
                objResp.Novo(objEnti);
            }
            else
            {
                objResp.Editar(objEnti);
            }
            

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
