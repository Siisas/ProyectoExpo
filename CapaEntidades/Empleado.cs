using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerData
{
    public class Empleado
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String NroDocumento { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }
        public Empleado()
        { }
        public Empleado(int ID, String Nombre, String NroDocumento, String Usuario, String Clave)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.NroDocumento = NroDocumento;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

    }
}
