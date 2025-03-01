using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApicacionRay.Data
{
    public static class SesionActual
    {
        public static string NombreUsuario { get; private set; }

        public static void IniciarSesion(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
    }
}
