using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestaoPacienteService.VOL;

namespace Exercicio_Cadastro
{
    public partial class _Cadastrar : Page
    {
        
        private void vLimpaCampos()
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtSexo.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtCel.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtResp.Text = String.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region

        private void CriarPaciente()
        {
            GestaoPacienteService.PacienteService service = new GestaoPacienteService.PacienteService();
            Paciente paciente = new Paciente();
            paciente.Nome = txtNome.Text;
            paciente.Idade = int.Parse(txtIdade.Text);
            paciente.Sexo = txtSexo.Text;
            paciente.Telefone = txtTel.Text;
            paciente.Celular = txtCel.Text;
            paciente.Email = txtEmail.Text;
            paciente.Responsavel = txtResp.Text;

            PacienteResultado result = service.CriaPaciente(paciente);

            if (result.Sucesso)
            {
                vLimpaCampos();
            }
            
            lblMsg.Text = result.Mensagem;
        }
        #endregion
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            CriarPaciente();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            vLimpaCampos();
        }
    }
}