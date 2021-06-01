﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLUsuarios : IBLLUsuarios
    {
        public List<Usuarios> GetAllUsuarios()
        {
            IDALUsuarios _DALUsuarios = new DALUsuarios();
            return _DALUsuarios.GetAllUsuarios();
        }
    }
}
