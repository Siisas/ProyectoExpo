using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace LayerData
{
    
    public class EmpleadoDao
    {
        
        #region "PATRON SINGLETON"
        private static EmpleadoDao DaoEmpleado = null;

        
        private EmpleadoDao() { }
    public static EmpleadoDao getInstance()
    {
        if (DaoEmpleado == null)
        {
            DaoEmpleado = new EmpleadoDao();
        }
        return DaoEmpleado;
    }


        // metodo que se puede colocar en la layer data
    #endregion
    public Empleado AccesoSistema(string user, string password)
    {
        SqlConnection conexion = null;
        SqlCommand cdm = null;
        Empleado objEmpleado = null;
        SqlDataReader dr = null;
        try
        {
            conexion = Data_Usuario.getInstance().conexionBD();
            cdm = new SqlCommand("spAccesoSistema", conexion);
            cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@prmUser", user);
            cdm.Parameters.AddWithValue("@prmPass", password);
            conexion.Open();
            dr = cdm.ExecuteReader();
            if (dr.Read())
            {
                objEmpleado = new Empleado();
                objEmpleado.ID = Convert.ToInt32(dr["idEmpleado"].ToString());
                objEmpleado.Usuario = dr["usuario"].ToString();
                objEmpleado.Clave = dr["clave"].ToString();

            }
        }
        catch (Exception ex)
        {
            objEmpleado = null;
            throw ex;
        }
        finally
        {
            conexion.Close();
        }
        return objEmpleado;
    }
}
}