using LayerBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        LayerBusinessElementos Cn = new LayerBusinessElementos();
        public string Usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LblUsuario.Text == ""  )
            {
                if (Convert.ToString( Session["Usuario"]) != "")
                {
                    LblUsuario.Text = Convert.ToString(Session["Usuario"]);
                }
               
            }

            if (!IsPostBack)
            {
         
            }

        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }

        public void UsuarioSesion()
        {
         
        }
    }
}