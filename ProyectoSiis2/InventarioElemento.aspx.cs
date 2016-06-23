using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{

    public partial class InventarioElemento : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
//        protected void Page_Load(object sender, EventArgs e)

  //      { }

        //protected void BtnMostrar_Click(object sender, EventArgs e)
        //{
        //    if (!Page.IsValid)
        //    {
        //        LlenarDatos();
        //    }

        //    else
        //    {
        //        try
        //        {

        //            GridView1.DataSource = oLB.SpMostrarElemento();
        //            GridView1.DataBind();

        //        }
        //        catch (Exception exc)
        //        {
        //            mensaje.Text = exc.Message.ToString();
        //        }
        //        finally
        //        {
        //            oLB = null;
        //        }





        //    }










        //protected void BtnMostrarReserva_Click(object sender, EventArgs e)
        //{
        //    if (!Page.IsValid)
        //    {
        //        LlenarDatos();
        //    }

        //    else
        //    {
        //        try
        //        {

        //            GridView2.DataSource = oLB.MostrarReserva();
        //            GridView2.DataBind();

        //        }
        //        catch (Exception exc)
        //        {
        //            mensaje.Text = exc.Message.ToString();
        //        }
        //        finally
        //        {
        //            oLB = null;
        //        }



        //    }







    

    //public void LlenarDatos()
    // {
    //GridView1.DataSource = oLB.SpMostrarElemento();
    //GridView1.DataBind();

    ////En la busqueda debe aparecer los 2 id id
    //DropDownList1.DataSource = oLB.MostrarEmpleados();
    ////DropDownList1.DataTextField = "id";
    ////DropDownList1.DataValueField = "id";
    //DropDownList1.DataTextField = "Apellidos";
    //DropDownList1.DataValueField = "Apellidos";
    ////DropDownList1.DataTextField = "Nombres";
    ////DropDownList1.DataValueField = "Nombres";
    ////DropDownList1.DataTextField = "HorasTrabajadas";
    ////DropDownList1.DataValueField = "HorasTrabajadas";
    ////DropDownList1.DataTextField = "SueldoXHora";
    ////DropDownList1.DataValueField = "SueldoXHora";


    //DropDownList1.DataBind();
    //DropDownList1.Items.Insert(0, new ListItem("--Selecciones empleado", "0"));
    //   }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LlenarDatos();
        }

    }


    public void LlenarDatos()
        {

            GVDatos.DataSource = oLB.SpMostrarElemento();
            GVDatos.DataBind();
        }

        protected void GVDatos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVDatos.EditIndex = -1;
            LlenarDatos();
        }

        protected void GVDatos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVDatos.EditIndex = e.NewEditIndex;
            LlenarDatos();

        }

        protected void GVDatos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
            Int64 Id_Elemento = Convert.ToInt64(GVDatos.DataKeys[e.RowIndex].Value.ToString());
            
            

            int result = 0;

            GridViewRow row = GVDatos.Rows[e.RowIndex];
            TextBox TNP = (TextBox)row.FindControl("TxtNumeroPlaca");
            TextBox TNS = (TextBox)row.FindControl("TxtNumeroSerial");
            TextBox TM = (TextBox)row.FindControl("TxtMarca");
            TextBox TMO = (TextBox)row.FindControl("TxtModelo");
            TextBox TC = (TextBox)row.FindControl("TxtCategoria");
            TextBox TFI = (TextBox)row.FindControl("TxtFecha_Ingreso");
            TextBox TE = (TextBox)row.FindControl("TxtEstado");
            TextBox TNE = (TextBox)row.FindControl("TxtNombreElemento");
          
          
            




            try
            {
                result = oLB.SpEditarElemento(Id_Elemento, TNP.Text, TNS.Text, TM.Text, TMO.Text, Int64.Parse(TC.Text), Convert.ToDateTime(TFI.Text), Int64.Parse(TE.Text),TNE.Text);
                if (result > 0)
                {
                    LblMsg.Text = "EMpleado Editado";
                }
                else
                {
                    LblMsg.Text = "Empleado NO Editado";
                }
            }
            catch (Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();
            }
            finally
            {
                oLB = null;
            }
            GVDatos.EditIndex = -1;
            LlenarDatos();
        }
    }
}

    
