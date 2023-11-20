using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Horarios
    {
        public int HorarioId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

        public Horarios()
        {
        }
    }
}
