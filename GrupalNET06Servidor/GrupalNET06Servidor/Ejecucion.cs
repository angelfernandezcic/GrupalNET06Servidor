using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor
{
    public class Ejecucion
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public double ConsumoMemoria { get; set; }
        public double ConsumoRed { get; set; }
    }
}