using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerData
{
    public class TipoEmpleado
    {
        public int ID { get; set; }
        public String Descripcion { get; set; }
        public bool Estado { get; set; }

        public TipoEmpleado()
        { }
        public TipoEmpleado(int ID, String Descripcion, bool Esatdo)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }
    }
}
