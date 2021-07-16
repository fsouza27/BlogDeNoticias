using System;
using System.Collections.Generic;

namespace BlogDeNoticias
{
    public partial class TbNoticia
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTimeOffset DtCriado { get; set; }
        public DateTimeOffset DtModificado { get; set; }
        public int IdAutor { get; set; }
        public int IdCategoria { get; set; }
    }
}
