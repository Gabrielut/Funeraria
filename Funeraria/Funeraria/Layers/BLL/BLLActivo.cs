using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLActivo : IBLLActivo
    {
        public List<Activo> GetAllActivos()
        {
            IDALActivo _IIDALActivo = new DALActivo();

            return _IIDALActivo.GetAllActivos();
        }
      
    }
}
