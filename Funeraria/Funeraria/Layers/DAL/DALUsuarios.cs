using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.Layers.DAL
{
   public class DALUsuarios : IDALUsuarios
    {
        Usuarios _Usuario = new Usuarios();
        public DALUsuarios()
        {
            _Usuario.Correo = Settings.Default.Login;
            _Usuario.Contrasenna = Settings.Default.Password;
        }
        public List<Usuarios> GetAllUsuarios()
        {
            DataSet ds = null;
            List<Usuarios> lista = new List<Usuarios>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Usuarios WITH (NOLOCK)";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                // esto se hace cuando se utiliza un store procedure en la base de datos
                // command.CommandText = "usp_SELECT_Cliente_All";
                // command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Correo, _Usuario.Contrasenna)))
                {
                    ds = db.ExecuteReader(command, "query");

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Usuarios oUsarios = new Usuarios();
                        oUsarios.IDUsuario = dr["IDUsuario"].ToString();
                        oUsarios.Nombre = dr["Nombre"].ToString();
                        oUsarios.PrimerApellido = dr["PrimerApellido"].ToString();
                        oUsarios.SegundoApellido = dr["SegundoApellido"].ToString();
                        oUsarios.Correo = dr["Correo"].ToString();
                        oUsarios.Telefono = dr["Telefono"].ToString();
                        oUsarios.IdRol = (int)dr["IDRol"];
                        oUsarios.Contrasenna = dr["Contrasenna"].ToString();
                        oUsarios.Estado = (bool)dr["Estado"];
                        oUsarios.Sexo = (bool)dr["Sexo"];
                        oUsarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());

                        lista.Add(oUsarios);
                    }
                } 
            }
            catch (Exception er)
            {
               
            }
            return lista;
        }
    }
}
