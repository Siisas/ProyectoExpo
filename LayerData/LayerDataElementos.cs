using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Configuration;

namespace LayerData
{
    public class LayerDataElementos
    {
        //public string strconn = @"Data Source = ufkadqmy3n.database.windows.net,1433; Initial Catalog = bdproyecto; Persist Security Info=True;User ID = pruebanomina; Password=AZUre2016";
        public int Retorna { get; set; }
        public string Mensaje { get; set; }
        public string Valor { get; set; }
        public string Usuario { get; set; }

        private SqlConnection cx;
        private void Conexion()
        {
            string cone = ConfigurationManager.ConnectionStrings["ProyectoSiisConnectionString"].ToString();
            cx = new SqlConnection(cone);
        }

        public string CrearUsuario(string Usuario, string Password)
        {
            Conexion();
            try
            {
                SqlCommand cmd = new SqlCommand("SpNewUsers", cx);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter("Select * from Login where @NombreUsuario", NombreUsuario);
                string PasswordEncriptado = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
                cx.Open();
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@PassWord", PasswordEncriptado);
                Retorna = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                if (Retorna == -1)
                {
                    return Mensaje = "Ya existe";
                }
                else
                {
                    return Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string VerificarLogin(string usuario, string Password)
        {
            Conexion();
            SqlCommand cmd = new SqlCommand("select * from Usuario where  Password  = @Password and Usuario = @Nombre  ", cx);
  
            string PasswordEncriptado = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
            cx.Open();
            cmd.Parameters.AddWithValue("@PassWord", PasswordEncriptado);
            cmd.Parameters.AddWithValue("@Nombre", usuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt.Tables[0].Rows.Count >0)
            {
                DataRow row = dt.Tables[0].Rows[0];
                Usuario = row[1].ToString();
                return Valor = "Si";
            }
            else
            {
                return Valor = "No";
            }

            

            //DataRow row = dt.Tables[0].Rows[0];
            //int valor = Convert.ToInt32(row[0]);
            //if (valor > 0)
            //{
            //    return Valor = "Si";
            //}
            //else
            //{
            //    return Valor = "No";
            //}

        }

        //prueba
        public int SpIngreso_Elemento(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, Int64 Categoria_Id_Categoria, DateTime Fecha_Ingreso, Int64 Estado_Id_Estado, string Nombre_Elemento, Int64 FK_Id_Empleado)
        {


            Conexion();
            SqlCommand OrdenSQL = new SqlCommand("SpIngreso_Elemento", cx);
            cx.Open();
            OrdenSQL.CommandType = CommandType.StoredProcedure;
            try
            {
                OrdenSQL.Parameters.AddWithValue("@Id_Elemento", Id_Elemento);
                OrdenSQL.Parameters.AddWithValue("@N_Placa", N_placa);
                OrdenSQL.Parameters.AddWithValue("@N_Serial", N_Serial);
                OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
                OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
                OrdenSQL.Parameters.AddWithValue("@Categoria_Id_Categoria", Categoria_Id_Categoria);
                OrdenSQL.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);
                OrdenSQL.Parameters.AddWithValue("@Estado_Id_Estado", Estado_Id_Estado);
                OrdenSQL.Parameters.AddWithValue("@Nombre_Elemento", Nombre_Elemento);
                OrdenSQL.Parameters.AddWithValue("@FK_Id_Empleado", FK_Id_Empleado);
                return OrdenSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cx.Close();
                cx.Dispose();
                OrdenSQL.Dispose();
            }

        }



        public DataTable SpMostrarElemento()
        {
            Conexion();

            cx.Open();
            SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpMostrarInventario", cx);
            ObjMostrar.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            try
            {
                ObjMostrar.Fill(ds, "Table");
                return ds.Tables["Table"];

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {


                cx.Close();
                cx.Dispose();
                ObjMostrar.Dispose();
                ds.Dispose();
            }

        }


        //Objeto para el drop

        public DataTable SpMostrarInventario()
        {

            Conexion();
            cx.Open();
            SqlDataAdapter ObjMostrar = new SqlDataAdapter("Select Id_Elemento, Id_Elemento FROM Ingreso_Elemento", cx);
            ObjMostrar.SelectCommand.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            try
            {
                ObjMostrar.Fill(ds, "Table");
                return ds.Tables["Table"];

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {


                cx.Close();
                cx.Dispose();
                ObjMostrar.Dispose();
                ds.Dispose();
            }
        }
    }


}


//public DataTable MostrarElemento()
//{

//Conexion();
//        cx.Open();
//        SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpInsertarPrestamo", cx);
//        ObjMostrar.SelectCommand.CommandType = CommandType.Text;
//        DataSet ds = new DataSet();
//        try
//        {
//            ObjMostrar.Fill(ds, "Table");
//            return ds.Tables["Table"];

//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {


//            cx.Close();
//            cx.Dispose();
//            ObjMostrar.Dispose();
//            ds.Dispose();
//        }
//    }
//}





//public int SpEditarElemento(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, Int64 Categoria_Id_Categoria, DateTime Fecha_Ingreso, Int64 Estado_Id_Estado, string Nombre_Elemento, Int64 FK_Id_Empleado)
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();

//        SqlCommand OrdenSQL = new SqlCommand("SpEditarElemento", cnx);
//        OrdenSQL.CommandType = CommandType.StoredProcedure;

//        try
//        {
//            OrdenSQL.Parameters.AddWithValue("@Id_Elemento", Id_Elemento);
//            OrdenSQL.Parameters.AddWithValue("@N_Placa", N_placa);
//            OrdenSQL.Parameters.AddWithValue("@N_Serial", N_Serial);
//            OrdenSQL.Parameters.AddWithValue("@Marca", Marca);
//            OrdenSQL.Parameters.AddWithValue("@Modelo", Modelo);
//            OrdenSQL.Parameters.AddWithValue("@Categoria_Id_Categoria", Categoria_Id_Categoria);
//            OrdenSQL.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);
//            OrdenSQL.Parameters.AddWithValue("@Estado_Id_Estado", Estado_Id_Estado);
//            OrdenSQL.Parameters.AddWithValue("@Nombre_Elemento", Nombre_Elemento);
//            OrdenSQL.Parameters.AddWithValue("@FK_Id_Empleado", FK_Id_Empleado);
//            return OrdenSQL.ExecuteNonQuery();


//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            cnx.Close();
//            cnx.Dispose();
//            OrdenSQL.Dispose();
//        }
//    }
//}
//public int SpEliminarElemento(Int64 Id_Elemento)
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();

//        SqlCommand OrdenSql = new SqlCommand("SpEliminarElemento", cnx);
//        OrdenSql.CommandType = CommandType.StoredProcedure;

//        try
//        {
//            OrdenSql.Parameters.AddWithValue("@Id_Elemento", Id_Elemento);
//            return OrdenSql.ExecuteNonQuery();


//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            cnx.Close();
//            cnx.Dispose();
//            OrdenSql.Dispose();
//        }
//    }
//}


////LayerData de Reservas Para la Pagina reserva
//public int InsertarReserva(string Id_Reserva, string Nombre_Solicitante, Int64 Fk_Id_Elemento, DateTime Fecha_Reserva, string Observaciones, string Fk_Id_Categoria, string Fk_Id_Estado)
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();
//        SqlCommand Ordensql = new SqlCommand("SpInsertarReserva", cnx);
//        Ordensql.CommandType = CommandType.StoredProcedure;

//        try
//        {
//            Ordensql.Parameters.AddWithValue("@Id_Reserva", Id_Reserva);
//            Ordensql.Parameters.AddWithValue("@Nombre_Solicitante", Nombre_Solicitante);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Elemento", Fk_Id_Elemento);
//            Ordensql.Parameters.AddWithValue("@Fecha_Reserva", Fecha_Reserva);
//            Ordensql.Parameters.AddWithValue("@Observaciones", Observaciones);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Categoria", Fk_Id_Categoria);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Estado", Fk_Id_Estado);
//            return Ordensql.ExecuteNonQuery();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            cnx.Close();
//            cnx.Dispose();
//            Ordensql.Dispose();
//        }
//    }
//}

////Mostrar Reserva para la pagina Gestion

//public DataTable MostrarReserva()
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();
//        SqlDataAdapter dAd = new SqlDataAdapter("SpMostrarReserva", cnx);
//        dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
//        DataSet ds = new DataSet();

//        try
//        {
//            dAd.Fill(ds, "Table");
//            return ds.Tables["Table"];
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            cnx.Close();
//            cnx.Dispose();
//            dAd.Dispose();
//            ds.Dispose();
//        }
//    }
//}

////LayerData Mostrar Prestamo
//public DataTable MostrarPrestamo()
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();
//        SqlDataAdapter ObjMostrar = new SqlDataAdapter("SpInsertarPrestamo", cnx);
//        ObjMostrar.SelectCommand.CommandType = CommandType.StoredProcedure;
//        DataSet ds = new DataSet();
//        try
//        {
//            ObjMostrar.Fill(ds, "TablePrestamo");
//            return ds.Tables["TablePrestamo"];

//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {


//            cnx.Close();
//            cnx.Dispose();
//            ObjMostrar.Dispose();
//            ds.Dispose();
//        }
//    }
//}


////Insertar Prestamo


//public int InsertarPrestamo(Int64 Id_Prestamo, string Nombre_Solicitante, Int64 Fk_Id_Elemento, DateTime Fecha_Prestamo, string Observaciones, string Fk_Id_Estado, string Fk_Id_Categoria)
//{
//    using (SqlConnection cnx = new SqlConnection(strconn))
//    {
//        cnx.Open();
//        SqlCommand Ordensql = new SqlCommand("SpInsertarPrestamo", cnx);
//        Ordensql.CommandType = CommandType.StoredProcedure;

//        try
//        {
//            Ordensql.Parameters.AddWithValue("@Id_Prestamo", Id_Prestamo);
//            Ordensql.Parameters.AddWithValue("@Nombre_Solicitante", Nombre_Solicitante);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Elemento", Fk_Id_Elemento);
//            Ordensql.Parameters.AddWithValue("@Fecha_Prestamo", Fecha_Prestamo);
//            Ordensql.Parameters.AddWithValue("@Observaciones", Observaciones);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Estado", Fk_Id_Estado);
//            Ordensql.Parameters.AddWithValue("@Fk_Id_Categoria", Fk_Id_Categoria);
//            return Ordensql.ExecuteNonQuery();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//        finally
//        {
//            cnx.Close();
//            cnx.Dispose();
//            Ordensql.Dispose();
//        }
//    }
//}
