using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IBLLActivo
    {
        List<ActivoDTO> GetAllActivos();
        Activo GetActivoById(int pActivo);
        Activo SaveActivo(Activo pActivo);
        List<Activo> GetActivoByFilter(string pDescripcion);
        bool DaleteActivo(int pId);
        int GetNextNumeroActivo();
    }
}
