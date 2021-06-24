using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Paquete
    {
        public int IdPaquete { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public TipoPaquete IdTipoPaquete { get; set; }
        public bool Estado { get; set; }
    }
}
