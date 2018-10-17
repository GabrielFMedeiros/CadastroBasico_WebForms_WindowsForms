using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacienteExercicio
{
    public partial class frmPacienteDetalhe : Form
    {
        public frmPacienteDetalhe()
        {
            InitializeComponent();
        }

        public void CarregarPaciente(int id, string nome, int idade, string sexo, string telefone, string celular, string email, string resp)
        {
            Listar list = new Listar();
            txtIdPaciente.Text = id.ToString();
            txtNome.Text = nome;
            txtIdade.Text = idade.ToString();
            switch (sexo)
            {
                case "Masculino":
                    rdbMasc.Checked = true;
                    sexo = "Masculino";
                    break;
                case "Feminino":
                    rdbFem.Checked = true;
                    sexo = "Feminino";
                    break;
            }
            txtTel.Text = telefone;
            txtCel.Text = celular;
            txtEmail.Text = email;
            txtResp.Text = resp;
        }

        public bool validaForm()
        {
            int idade;
            int.TryParse(txtIdade.Text, out idade);
            if (txtNome.Text == String.Empty || txtIdade.Text == String.Empty || txtTel.Text == String.Empty || txtEmail.Text == String.Empty || (rdbMasc.Checked == false && rdbFem.Checked == false))
            {
                MessageBox.Show("Os campos: Nome, Idade, Sexo, Telefone e E-mail são de preenchimento obrigatório!");
                return false;
            } else if (idade < 18 && txtResp.Text == String.Empty)
            {
                MessageBox.Show("Paciente menor de idade! Favor informar o Responsável!");
                return false;
            }
            else if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Favor inserir um Nome valido!");
                return false;
            }
            else if (txtTel.Text.Length != 10)
            {
                MessageBox.Show("Favor inserir um Telefone valido! Incluindo o DDD");
                return false;
            }
            else if (txtCel.Text.Length > 0 && txtCel.Text.Length != 11)
            {
                MessageBox.Show("Favor inserir um Celular valido! Incluindo o DDD");
                return false;
            }else if(idade > 125)
            {
                MessageBox.Show("Favor inserir uma idade valida!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbMasc.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Feminino";
            }
            int id = int.Parse(txtIdPaciente.Text);
            int idade;
            if (validaForm() != false)
            {
                try
                {
                    int.TryParse(txtIdade.Text, out idade);
                    GestaoPacienteService.VOL.Database db = new GestaoPacienteService.VOL.Database();
                    SqlConnection con = new SqlConnection(db.connenctionString);
                    con.Open();
                    SqlCommand cmmd = new SqlCommand("UPDATE Pacientes SET NomePaciente = @Nome ,IdadePaciente = '" + idade + "', SexoPaciente = '" + sexo + "', TelefonePaciente = '" + txtTel.Text + "', CelularPaciente = '" + txtCel.Text + "', EmailPaciente = '" + txtEmail.Text + "', RespPaciente = '" + txtResp.Text + "' WHERE IdPaciente = '" + id + "' ", con);
                    cmmd.Parameters.Add("@Nome", SqlDbType.Char);
                    cmmd.Parameters["@Nome"].Value = txtNome.Text;
                    cmmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na alteração de dados do paciente!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPaciente.Text);
            if (MessageBox.Show("Deseja realmente excluir?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                try
                {
                    GestaoPacienteService.VOL.Database db = new GestaoPacienteService.VOL.Database();
                    SqlConnection con = new SqlConnection(db.connenctionString);
                    con.Open();
                    SqlCommand cmmd = new SqlCommand("DELETE FROM Pacientes WHERE IdPaciente = '" + id + "'",con);
                    cmmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Erro na exclusão do paciente!");
                }
            }
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
    }
}
