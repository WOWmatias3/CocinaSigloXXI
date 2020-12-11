using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        int id_usuario { get; set; }
        string nom_usuario { get; set; }
        string clave { get; set; }
        string rol { get; set; }

        public UsuarioBLL()
        {
        }
        public UsuarioBLL(int id_usuario, string nom_usuario, string clave, string rol)
        {
            this.id_usuario = id_usuario;
            this.nom_usuario = nom_usuario;
            this.clave = clave;
            this.rol = rol;
        }

        public bool getLogin(string nombreuser, string password)
        {
            UsuarioDAL usrdal = new UsuarioDAL();
            return usrdal.getLogin(nombreuser, password);
        }


    }
}
