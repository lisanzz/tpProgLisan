using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CineCordobaBack.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection cnn;


        private HelperDao() 
        {
            cnn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Cordoba_Cine_GRUPO_N92;Integrated Security=True");
            
        
        }

        public static HelperDao ObtenerInstancia()
        { 
            if (instancia == null) 
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        { return cnn; }

        public int EjecutarSp(string spNombre, List<Parametro> listaParametros)
        {
            int filasAfectadas = 0;
            SqlTransaction t = null;

            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();


            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spNombre, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                if (listaParametros != null)
                {
                    foreach (Parametro oParametro in listaParametros)
                    {
                        cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                    }
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return filasAfectadas;
        }

        public DataTable ConsultaTabla(string spNombre, List<Parametro> listaParametros)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (listaParametros != null)
            {
                foreach (Parametro oParametro in listaParametros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }




    }
}
