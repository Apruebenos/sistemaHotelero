﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosHoteles.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_Clientes;Data Source=.";
            //return "Data Source=H45-17;Initial Catalog=BD_Clientes;Integrated Security=SSPI;";

        }
    }
}