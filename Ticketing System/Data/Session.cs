using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System.Data
{
    //La clase se creo para guardar la informacion del usuario logueado durante todo el tiempo que la apliacion que esta abierta.
    //Al momento de cerrar sesion, la informacion se borra
    internal static class Session
    {
        public static int id;
        public static string name;
        public static string role;
        public static string email;

        public enum Role
        {
            Admin,
            Tecnico,
            Cliente
        }

        public static Role confirmRole(string role)
        {
            if(role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                return Role.Admin;
            if (role.Equals("tecnico", StringComparison.OrdinalIgnoreCase))
                return Role.Tecnico;

            return Role.Cliente;
        }

    }
}
