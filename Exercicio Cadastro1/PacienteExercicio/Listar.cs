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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.IsMdiContainer = false;
            ini.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.IsMdiContainer = false;
            cad.Show();
            this.Close();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacienteDataSet.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.pacienteDataSet.Pacientes);
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToOrderColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cabeçalho
            if (e.RowIndex == -1) return;            
            if (dataGridView1.Rows[e.RowIndex].Cells["Detalhes"].Selected)
            {
                //var valor = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                var id = dataGridView1.Rows[e.RowIndex].Cells["IdPaciente"].Value;
                var nome = dataGridView1.Rows[e.RowIndex].Cells["NomePaciente"].Value;
                var idade = dataGridView1.Rows[e.RowIndex].Cells["IdadePaciente"].Value;
                var sexo = dataGridView1.Rows[e.RowIndex].Cells["SexoPaciente"].Value;
                var telefone = dataGridView1.Rows[e.RowIndex].Cells["TelefonePaciente"].Value;
                var celular = dataGridView1.Rows[e.RowIndex].Cells["CelularPaciente"].Value;
                var email = dataGridView1.Rows[e.RowIndex].Cells["EmailPaciente"].Value;
                var resp = dataGridView1.Rows[e.RowIndex].Cells["RespPaciente"].Value;
                frmPacienteDetalhe frm = new frmPacienteDetalhe();
                
                frm.CarregarPaciente(Convert.ToInt32(id), Convert.ToString(nome), Convert.ToInt32(idade), Convert.ToString(sexo), Convert.ToString(telefone), Convert.ToString(celular), Convert.ToString(email), Convert.ToString(resp));
                frm.ShowDialog();
            }
            this.pacientesTableAdapter.Fill(this.pacienteDataSet.Pacientes);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                e.Value = (Convert.ToInt64(e.Value)).ToString("(00) 0000-0000");
                e.FormattingApplied = true;
            }

            if (e.ColumnIndex == 5)
            {
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                if (e.Value != "")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                {
                    e.Value = (Convert.ToInt64(e.Value)).ToString("(00) 00000-0000");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.FormattingApplied = false;
                }
            }
        }
    }
}
