using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class DevolucionElemento : System.Web.UI.Page
    {

        LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDatos();
            }
            //if (!IsPostBack)
            //{
            //    LlenarDatos1();
            //}


        }
        public void LlenarDatos()
        {
            LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();

            //DropDownList1.DataSource = oLB.SpMostrarElemento();
            //DropDownList1.DataTextField = "id_Empleado";
            //DropDownList1.DataValueField = "id_empleado";

            //DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, new ListItem("--Selecciones Id del Prestamo", "0"));


            //GridView1.DataSource = oLB.SpMostrarElemento();
            //GridView1.DataBind();
            

            //DropDownList1.DataSource = oLB.SpMostrarInventario();
            //DropDownList1.DataTextField = "Id_Elemento";
            //DropDownList1.DataValueField = "Id_Elemento";

            //DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, new ListItem("--Selecciones Id del Prestamo", "0"));


        }

        //public void LlenarDatos1()
        //{
        //    LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();

        //    DropDownList1.DataSource = oLB.MostrarElemento();
        //    DropDownList1.DataTextField = "Id_Prestamo";
        //    DropDownList1.DataValueField = "Id_Prestamo";

        //    DropDownList1.DataBind();
        //    DropDownList1.Items.Insert(0, new ListItem("--Selecciones Id del Prestamo", "0"));






        //}


        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                LlenarDatos();
            }

            else
            {
                try
                {

                    GridView1.DataSource = oLB.SpMostrarElemento();
                    GridView1.DataBind();

                }
                catch (Exception exc)
                {
                    mensaje.Text = exc.Message.ToString();
                }
                finally
                {
                    oLB = null;
                }



            }

        }



        protected void GVDatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();

            Int64 Id_Empleado = Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value.ToString());
            try
            {
                oLB.EliminarElemento(Id_Empleado);
                mensaje.Text = "Elemento ELiminado";
                LlenarDatos();
            }
            catch (Exception exc)
            {
                mensaje.Text = exc.Message.ToString();
            }
            finally
            {
                oLB = null;
            }
        }
    }
}