using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LayerData
{
    public class Data_Usuario
    {

        #region "PATRON SINGLETON"
        private static Data_Usuario conexion = null;
        private Data_Usuario()
        { }
        public static Data_Usuario getInstance()
        {
            if (conexion == null)
            {
                conexion = new Data_Usuario();
            }
            return conexion;
        }

        #endregion
        public SqlConnection conexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=FELIPEPC;Initial Catalog=WebFormsIdentity;Integrated Security=True";
            return conexion;
        }
        /* public string strconn = @"Data Source=FELIPEPC;Initial Catalog=BDInventario;Integrated Security=True";

         public Data_Usuario() { }
         public int ValidarUsuario(string Usuario,string Contraseña)
         {
             SqlConnection cnx = new SqlConnection();
           cnx.ConnectionString = ConfigurationManager.ConnectionStrings["strconn"].ConnectionString;

             cnx.Open();
                 SqlCommand OrdenSql = new SqlCommand("SpValidarUsuario", cnx);
                 OrdenSql.CommandType = CommandType.StoredProcedure;
                 OrdenSql.Parameters.Add("@usuario", SqlDbType.VarChar,50).Value = Usuario;
                 OrdenSql.Parameters.Add("@contraseña",SqlDbType.VarChar,50).Value = Contraseña;
                 SqlParameter p1 = new SqlParameter("ret", SqlDbType.Int);
                 p1.Direction = ParameterDirection.ReturnValue;
                 OrdenSql.Parameters.Add(p1);

                  // OrdenSql.Parameters.AddWithValue("@error",error).Direction = ParameterDirection.Output;
                    OrdenSql.ExecuteNonQuery();
                     Int32 k;
                     k = Convert.ToInt32(OrdenSql.Parameters["ret"].Value);
                      cnx.Dispose();
                      return k;



                 }
          */
    }
}




