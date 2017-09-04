using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor
{
    public class Tarea
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Fecha { get; set; }
        public bool Activa { get; set; }
        public string Programacion { get; set; }
        public string Formato { get; set; }
    }
}