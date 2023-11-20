using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class TipoSalas
    {
        public int TipoSalasId { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public TipoSalas()
        {
        }
    }
}
