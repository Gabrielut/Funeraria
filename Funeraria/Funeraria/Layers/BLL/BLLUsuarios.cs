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
    class BLLUsuarios : IBLLUsuarios
    {
        public bool DaleteUsuarios(string pId)
        {
            IDALUsuarios _DalUsuarios = new DALUsuarios();
            return _DalUsuarios.DeleteUsuarios(pId);
        }

        public List<Usuarios> GetAllUsuarios()
        {
            IDALUsuarios _DALUsuarios = new DALUsuarios();
            return _DALUsuarios.GetAllUsuarios();
        }

        public List<Usuarios> GetUsuariosByFilter(string pDescripcion)
        {
            IDALUsuarios _DALUsuarios = new DALUsuarios();
            return _DALUsuarios.GetUsuariosByFilter(pDescripcion);
        }

        public Usuarios GetUsuariosById(string correo)
        {
            IDALUsuarios _DALUsuarios = new DALUsuarios();
            return _DALUsuarios.GetUsuariosById(correo);
        }

        public Usuarios SaveUsuarios(Usuarios pUsuarios)
        {
            IDALUsuarios _DALUsuarios = new DALUsuarios();
            return _DALUsuarios.SaveUsuarios(pUsuarios);
        }
    }
}
