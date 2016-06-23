using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class IngresoELemento : System.Web.UI.Page
    {
        LayerBusiness.LayerBusinessElementos oLB = new LayerBusiness.LayerBusinessElementos();
        protected void Page_Load(object sender, EventArgs e)
        
            {

                if (!IsPostBack)
                {
                    CalendarIng.Visible = false;
                }

            }


      

        protected void ImagenCal_Click(object sender, ImageClickEventArgs e)
        {
            if (CalendarIng.Visible)
            {
                CalendarIng.Visible = false;
            }
            else
            {
                CalendarIng.Visible = true;
            }
        }

        protected void CalendarIng_SelectionChanged(object sender, EventArgs e)//asignandole a la casilla txt fecha lo q se escoge en calendario 
        {
            TxtFecha_Ingreso.Text = CalendarIng.SelectedDate.ToShortDateString();
            CalendarIng.Visible = false;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (!Page.IsValid)
            {
                return;
            }
            else
            {
                try
                {
                    oLB.SpIngreso_Elemento(Convert.ToInt64(TxtIdElemento.Text), TxtNumeroPlaca.Text, TxtNumeroSerial.Text, TxtMarca.Text, TxtModelo.Text, Convert.ToInt64(TxtCategoria.Text),Convert.ToDateTime(TxtFecha_Ingreso.Text),Convert.ToInt64(TxtEstado.Text), TxtNombreElemento.Text, Convert.ToInt64(TxtFK_Id_Empleado.Text));
                    mensaje.Text = "Elemento Ingresado con Exito";
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
}
