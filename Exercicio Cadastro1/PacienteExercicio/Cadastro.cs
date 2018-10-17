using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacienteExercicio
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpaCampo()
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtCel.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtResp.Text = String.Empty;
            if(rdbMasc.Checked || rdbFem.Checked)
            {
                rdbFem.Checked = false;
                rdbMasc.Checked = false;
            }
        }

        public bool validaForm()
        {
            int idade;
            Int32.TryParse(txtIdade.Text, out idade);
            if (txtNome.Text == String.Empty || txtIdade.Text == String.Empty || txtTel.Text == String.Empty || txtEmail.Text == String.Empty || (rdbMasc.Checked == false && rdbFem.Checked == false))
            {
                MessageBox.Show("Os campos: Nome, Idade, Sexo, Telefone e E-mail são de preenchimento obrigatórios!");
                return false;
            }else if(idade < 18 && txtResp.Text == String.Empty)
            {
                MessageBox.Show("Paciente menor de idade! Favor preencher o responsável!");
                return false;
            }else if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Favor inserir um Nome valido!");
                return false;
            }
            else if (txtTel.Text.Length != 10)
            {
                MessageBox.Show("Favor inserir um Telefone valido! Incluindo o DDD");
                return false;
            }
            else if (txtCel.Text.Length > 0 && txtCel.Text.Length !=11)
            {
                MessageBox.Show("Favor inserir um Celular valido! Incluindo o DDD");
                return false;
            }
            else if (idade > 125)
            {
                MessageBox.Show("Favor inserir uma idade valida!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validaForm() != false)
            {
                GestaoPacienteService.PacienteService service = new GestaoPacienteService.PacienteService();
                GestaoPacienteService.VOL.Paciente paciente = new GestaoPacienteService.VOL.Paciente();
                paciente.Nome = txtNome.Text;
                paciente.Idade = int.Parse(txtIdade.Text);
                if (rdbMasc.Checked)
                {
                    paciente.Sexo = "Masculino";
                }
                else
                {
                    paciente.Sexo = "Feminino";
                }
                paciente.Telefone = txtTel.Text;
                paciente.Celular = txtCel.Text;
                paciente.Email = txtEmail.Text;
                paciente.Responsavel = txtResp.Text;

                GestaoPacienteService.VOL.PacienteResultado result = service.CriaPaciente(paciente);
                if (result.Sucesso)
                {
                    limpaCampo();
                }
                lblMsg.Text = result.Mensagem;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.IsMdiContainer = false;
            ini.Show();
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar list = new Listar();
            list.IsMdiContainer = false;
            list.Show();
            this.Close();
        }
    }
}
