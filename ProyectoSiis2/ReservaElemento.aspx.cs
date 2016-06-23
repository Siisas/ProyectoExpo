using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSiis2
{
    public partial class ReservaElemento : System.Web.UI.Page
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
            TxtFecha_Reserva.Text = CalendarIng.SelectedDate.ToShortDateString();
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
                    oLB.InsertarReserva(TxtId_Reserva.Text,TxtNombre_Solicitante.Text, Convert.ToInt64(TxtFk_Id_Elemento.Text), Convert.ToDateTime(TxtFecha_Reserva.Text), TxtObservaciones.Text, TxtFk_Id_Categoria.Text, TxtFk_Id_Estado.Text);
                    mensaje.Text = "Reserva realizada con Exito";
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