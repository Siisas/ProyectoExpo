using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerBusiness;


namespace ProyectoSiis2
{
    public partial class LoginSiis : System.Web.UI.Page
    {
        public EmpleadoLN objEmpleado { get; private set; }

        // Inventory_Bussines.EmpleadoLN oLB = new Inventory_Bussines.EmpleadoLN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {

             objEmpleado = EmpleadoLN.getInstance().AccesoSistema(txtUsuario.Text, txtContraseña.Text);
            if (objEmpleado != null)
            {
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            }

        }
    }
}
