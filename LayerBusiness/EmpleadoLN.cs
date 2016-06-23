using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerData ;
using System.Data;
using LayerBusiness;


namespace LayerBusiness
{
    public class EmpleadoLN
    {
     //   LayerData.LayerDataElementos Empleado = new LayerData.LayerDataElementos();
        #region "PATRON SINGLETON"
        private static EmpleadoLN objEmpleado = null;
        private EmpleadoLN() { }
        public static EmpleadoLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }
            return objEmpleado;
        }

//       LayerData.LayerDataElementos oEmpleadoDao = new LayerData.LayerDataElementos();
        #endregion
        public EmpleadoLN AccesoSistema(string user, string password)
        {
            try
            {
                return EmpleadoLN.getInstance().AccesoSistema(user, password);
                         
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}