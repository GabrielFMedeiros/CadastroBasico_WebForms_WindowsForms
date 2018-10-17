using GestaoPacienteService.VOL;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacienteService
{
    public class PacienteService
    {        
        //string conn = ConfigurationManager.ConnectionStrings["devConnection"].ToString();

        public PacienteResultado CriaPaciente(Paciente paciente)
        {
            bool incluidoSucesso = false;
            string mensagem = "";

            try
            {
                Database database = new Database();
                List<DatabaseParametro> parametros = new List<DatabaseParametro>();
                parametros.Add(new DatabaseParametro("NOMEPACIENTE", paciente.Nome, TipoParametro.String));
                parametros.Add(new DatabaseParametro("IDADEPACIENTE", paciente.Idade, TipoParametro.Int));
                parametros.Add(new DatabaseParametro("SEXOPACIENTE", paciente.Sexo, TipoParametro.String));
                parametros.Add(new DatabaseParametro("TELEFONEPACIENTE", paciente.Telefone, TipoParametro.String));
                parametros.Add(new DatabaseParametro("CELULARPACIENTE", paciente.Celular, TipoParametro.String));
                parametros.Add(new DatabaseParametro("EMAILPACIENTE", paciente.Email, TipoParametro.String));
                parametros.Add(new DatabaseParametro("RESPPACIENTE", paciente.Responsavel, TipoParametro.String));
                string sql = "INSERT INTO Pacientes (NOMEPACIENTE, IDADEPACIENTE, SEXOPACIENTE, TELEFONEPACIENTE, CELULARPACIENTE, EMAILPACIENTE, RESPPACIENTE) VALUES (@NOMEPACIENTE, @IDADEPACIENTE, @SEXOPACIENTE, @TELEFONEPACIENTE, @CELULARPACIENTE, @EMAILPACIENTE, @RESPPACIENTE)";
                database.ExecuteNonQuery(sql, parametros);


                /*

                string sql = "INSERT INTO Pacientes (NOMEPACIENTE, IDADEPACIENTE, SEXOPACIENTE, TELEFONEPACIENTE, CELULARPACIENTE, EMAILPACIENTE, RESPPACIENTE) VALUES (@NOMEPACIENTE, @IDADEPACIENTE, @SEXOPACIENTE, @TELEFONEPACIENTE, @CELULARPACIENTE, @EMAILPACIENTE, @RESPPACIENTE)";

                

                SqlParameter paramNome = new SqlParameter("@NOMEPACIENTE", System.Data.SqlDbType.NVarChar);
                paramNome.Value = paciente.Nome;

                SqlParameter paramIdade = new SqlParameter("@IDADEPACIENTE", System.Data.SqlDbType.NVarChar);
                paramIdade.Value = paciente.Idade;

                                
                SqlCommand cmmd = new SqlCommand(sql, con);
                cmmd.Parameters.Add(paramIdade);
                cmmd.Parameters.Add(paramNome);

                

                con.Open();
                cmmd.ExecuteNonQuery();
                con.Close();
                */
                mensagem = "Paciente Cadastrado Com Sucesso!";
                incluidoSucesso = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro no cadastro do Paciente! "+ex;                
            }
            
            return new PacienteResultado(paciente, incluidoSucesso, mensagem);
        }

        
    }

}

