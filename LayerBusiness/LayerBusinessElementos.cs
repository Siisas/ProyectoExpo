using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LayerBusiness
{
    public class LayerBusinessElementos
    {
        LayerData.LayerDataElementos ObjBS = new LayerData.LayerDataElementos();
        public int SpIngreso_Elemento(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, Int64 Categoria_Id_Categoria, DateTime Fecha_Ingreso, Int64 Estado_Id_Estado, string Nombre_Elemento,Int64 FK_Id_Empleado)


        {
            try
            {
                return ObjBS.SpIngreso_Elemento(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Categoria_Id_Categoria, Fecha_Ingreso, Estado_Id_Estado, Nombre_Elemento,FK_Id_Empleado);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }


        public DataTable SpMostrarElemento()
        {
            try
            {
                return ObjBS.SpMostrarElemento();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }

        }

        public int SpEditarElemento(Int64 Id_Elemento, string N_placa, string N_Serial, string Marca, string Modelo, Int64 Categoria_Id_Categoria, DateTime Fecha_Ingreso, Int64 Estado_Id_Estado, string Nombre_Elemento)

        {
            try
            {
                return ObjBS.SpEditarElemento(Id_Elemento, N_placa, N_Serial, Marca, Modelo, Categoria_Id_Categoria, Fecha_Ingreso, Estado_Id_Estado, Nombre_Elemento);

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }
        }

      
        public int EliminarElemento(Int64 IdElemento)
        {
            try
            {
                return ObjBS.SpEliminarElemento(IdElemento);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                ObjBS = null;
            }

        }



        //Insertar reserva
        public int InsertarReserva(string Id_Reserva, string Nombre_Solicitante, Int64 Fk_Id_Elemento, DateTime Fecha_Reserva, string Observaciones, string Fk_Id_Categoria, string Fk_Id_Estado)
        {
            try
            {
                return ObjBS.InsertarReserva(Id_Reserva, Nombre_Solicitante, Fk_Id_Elemento, Fecha_Reserva, Observaciones, Fk_Id_Categoria, Fk_Id_Estado);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }

        


        //Mostrar Reserva

        public DataTable MostrarReserva()
        {
            try
            {
                return ObjBS.MostrarReserva();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }



        //Insertar Prestamo


        public int InsertarPrestamo(Int64 Id_Prestamo, string Nombre_Solicitante, Int64 Fk_Id_Elemento, DateTime Fecha_Prestamo, string Observaciones, string Fk_Id_Estado, string Fk_Id_Categoria)
        {
            try
            {
                return ObjBS.InsertarPrestamo(Id_Prestamo, Nombre_Solicitante, Fk_Id_Elemento, Fecha_Prestamo, Observaciones, Fk_Id_Estado, Fk_Id_Categoria);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ObjBS = null;
            }
        }

        
    }
}