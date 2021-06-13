﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
    class ActivoDTO
    {
        public int IdActivo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoActivo { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
        public string Estado { get; set; }
        public string InformacionAdicional { get; set; }
        public byte[] Img { get; set; }
    }
}
