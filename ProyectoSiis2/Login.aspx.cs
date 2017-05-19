using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerBusiness;
namespace ProyectoSiis2
{
    public partial class Login : System.Web.UI.Page
    {

        LayerBusinessElementos Cn = new LayerBusinessElementos();
        public string Valor { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void IniciarSesion_Click(object sender, EventArgs e)
        {
            Authenticate(TxtUsuario.Text, TxtPassword.Text);
            if (Cn.Valor == "Si")
            {
                FormsAuthentication.RedirectFromLoginPage
                  (TxtUsuario.Text, false);
                //Session.Add("Perfil", Cn.Valor);


                Response.Redirect("~/Home.aspx");
                //Response.Write(ViewState["Prueba"]);
                //Response.Write((string)(Session["Perfil"]));
            }
            else
            {
                Response.Write("No");
            }
        }
        public string Authenticate(string nombre, string Pass)
        {
            Cn.VerificarLogin(nombre, Pass);
            return Cn.Valor;
        }

    }
}
