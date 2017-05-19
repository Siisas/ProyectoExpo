using LayerBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2.RegistroUsuario
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        LayerBusinessElementos Dll = new LayerBusinessElementos(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearUsuario(TxtNombre.Text, TxtPassword.Text);
            if (Mensaje.Text == "")
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("Usuario " + TxtNombre.Text + " Ya existe");
            }
        }
        public string CrearUsuario(string usuario, string Pass)
        {
            Dll.CrearUsuario(usuario, Pass);
            return Mensaje.Text = Dll.Mensaje;
        }
    }
}