using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacienteService.VOL
{
    public class DatabaseParametro
    {
        public String NomeParametro { get; set; }
        public Object ValorParametro { get; set; }

        public TipoParametro TipoParametro { get; set; }

        public DatabaseParametro(string nomeParametro, Object valorParametro, TipoParametro tipo)
        {
            this.NomeParametro = nomeParametro;
            this.ValorParametro = valorParametro;
            this.TipoParametro = tipo;
        }
    }

    public enum TipoParametro
    {
        String,
        Int
    }


    public class Database
    {
        public string connenctionString { get; set; }

        public Database()
        {
            this.connenctionString = ConfigurationManager.ConnectionStrings["devConnection"].ToString();
        }

        public Database(string connectionString)
        {
            this.connenctionString = connenctionString;
        }


        /*public DataTable ExecuteDataTable(string comSQL)
        {
            SqlConnection conn = new SqlConnection(this.connenctionString);
            conn.Open();
            SqlCommand command = new SqlCommand(comSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }

        public List<DataTable> ExecuteDataTables(string comSQL)
        {
            SqlConnection conn = new SqlConnection(this.connenctionString);
            conn.Open();

            SqlCommand command = new SqlCommand(comSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            List<DataTable> listDataTable = new List<DataTable>();
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                listDataTable.Add(ds.Tables[i]);
            }

            return listDataTable;
        }*/

        public void ExecuteNonQuery(string comandoSql, List<DatabaseParametro> parametros)
        {
            SqlConnection conn = new SqlConnection(this.connenctionString);
            conn.Open();
            SqlCommand command = new SqlCommand(comandoSql, conn);
            command.Parameters.AddRange(RecuperarParametros(parametros));
            command.ExecuteNonQuery();
            conn.Close();
        }

        private SqlParameter[] RecuperarParametros(List<DatabaseParametro> parametros)
        {
            List<SqlParameter> parametrosSql = new List<SqlParameter>();

            foreach (var param in parametros)
            {
                SqlDbType sqlDbType = SqlDbType.VarChar;

                switch (param.TipoParametro)
                {
                    case TipoParametro.Int:
                        sqlDbType = SqlDbType.Int;

                        break;
                }

                parametrosSql.Add(new SqlParameter { ParameterName = param.NomeParametro, Value = param.ValorParametro, SqlDbType = sqlDbType });

            }
            return parametrosSql.ToArray();
        }
    }
}
