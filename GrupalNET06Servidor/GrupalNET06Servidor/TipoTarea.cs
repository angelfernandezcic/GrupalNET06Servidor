using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor
{
    public class TipoTarea
    {
        public long Id { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public bool Repetitivo { get; set; }
        public bool Silenciable { get; set; }
        public bool Automatico { get; set; }
    }
}