using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Exercicio_Cadastro
{
    public partial class _Listar : Page
    {
        public string conn = ConfigurationManager.ConnectionStrings["devConnection"].ToString();
        protected void CarregaGrid()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmmd = new SqlCommand("SELECT * FROM PACIENTES", con);
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdPaciente.DataSource = ds;
                grdPaciente.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                grdPaciente.DataSource = ds;
                grdPaciente.DataBind();
                int columncount = grdPaciente.Rows[0].Cells.Count;
                grdPaciente.Rows[0].Cells.Clear();
                grdPaciente.Rows[0].Cells.Add(new TableCell());
                grdPaciente.Rows[0].Cells[0].ColumnSpan = columncount;
                grdPaciente.Rows[0].Cells[0].Text = "Nenhum Registro Encontrado!";
            }
        }

        protected void Pesquisa()
        {
            int idpaciente = 0;
            try { idpaciente = int.Parse(txtId.Text); } catch (Exception) { lblMsgPesquisa.Text = "Favor digitar um ID para busca!"; }
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmmd = new SqlCommand("SELECT * FROM PACIENTES WHERE IdPaciente = '" + idpaciente + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdPaciente.DataSource = ds;
                grdPaciente.DataBind();


            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                grdPaciente.DataSource = ds;
                grdPaciente.DataBind();
                int columncount = grdPaciente.Rows[0].Cells.Count;
                grdPaciente.Rows[0].Cells.Clear();
                grdPaciente.Rows[0].Cells.Add(new TableCell());
                grdPaciente.Rows[0].Cells[0].ColumnSpan = columncount;
                grdPaciente.Rows[0].Cells[0].Text = "Nenhum Registro Encontrado!";
                txtId.Text = String.Empty;
            }
        }
        protected void grdPaciente_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                SqlConnection con = new SqlConnection(conn);
                GridViewRow row = (GridViewRow)grdPaciente.Rows[e.RowIndex];
                System.Web.UI.WebControls.Label IdPaciente = (System.Web.UI.WebControls.Label)row.FindControl("IdPaciente");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Pacientes WHERE IdPaciente='" + Convert.ToInt32(grdPaciente.DataKeys[e.RowIndex].Value.ToString()) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                CarregaGrid();
            }
        }
        protected void grdPaciente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdPaciente.EditIndex = e.NewEditIndex;
            CarregaGrid();


        }
        protected void grdPaciente_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            int idpaciente = (Convert.ToInt32(grdPaciente.DataKeys[e.RowIndex].Value.ToString()));
            GridViewRow row = grdPaciente.Rows[e.RowIndex];
            System.Web.UI.WebControls.Label IdPaciente = (System.Web.UI.WebControls.Label)row.FindControl("IdPaciente");
            System.Web.UI.WebControls.TextBox txtNome = (System.Web.UI.WebControls.TextBox)row.Cells[1].Controls[0];
            System.Web.UI.WebControls.TextBox txtIdade = (System.Web.UI.WebControls.TextBox)row.Cells[2].Controls[0];
            System.Web.UI.WebControls.TextBox txtSexo = (System.Web.UI.WebControls.TextBox)row.Cells[3].Controls[0];
            System.Web.UI.WebControls.TextBox txtTelefone = (System.Web.UI.WebControls.TextBox)row.Cells[4].Controls[0];
            System.Web.UI.WebControls.TextBox txtCelular = (System.Web.UI.WebControls.TextBox)row.Cells[5].Controls[0];
            System.Web.UI.WebControls.TextBox txtEmail = (System.Web.UI.WebControls.TextBox)row.Cells[6].Controls[0];
            System.Web.UI.WebControls.TextBox txtResp = (System.Web.UI.WebControls.TextBox)row.Cells[7].Controls[0];
            int idade = int.Parse(txtIdade.Text);
            long telefone = long.Parse(txtTelefone.Text);
            long celular = long.Parse(txtCelular.Text);
            grdPaciente.EditIndex = -1;
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pacientes SET NomePaciente = '" + txtNome.Text + "', IdadePaciente = '" + idade + "', SexoPaciente = '" + txtSexo.Text + "', TelefonePaciente = '" + telefone + "', CelularPaciente = '" + celular + "', EmailPaciente = '" + txtEmail.Text + "', RespPaciente = '" + txtResp.Text + "' WHERE IdPaciente = '" + idpaciente + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            CarregaGrid();
        }

        protected void grdPaciente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPaciente.PageIndex = e.NewPageIndex;
            CarregaGrid();
        }

        protected void grdPaciente_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            grdPaciente.EditIndex = -1;
            CarregaGrid();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            lblMsgPesquisa.Text = String.Empty;
        }

        protected void btnEditar_Command(object sender, CommandEventArgs e)
        {

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            lblMsgPesquisa.Text = String.Empty;
            Pesquisa();
        }
    }
}