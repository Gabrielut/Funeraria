﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    public interface IDALUsuarios
    {
        List<Usuarios> GetAllUsuarios();
        Usuarios GetUsuariosById(string correo);
        Usuarios SaveUsuarios(Usuarios pUsuarios);
        List<Usuarios> GetUsuariosByFilter(string pDescripcion);
        bool DeleteUsuarios(string pId);
    }
}
