﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Barrios
    {
        public int BarrioId { get; set; }
        public string NombreBarrio { get; set; }

        public Barrios(int barrioId, string nombreBarrio)
        {
            BarrioId=barrioId;
            NombreBarrio=nombreBarrio;

        }

        public Barrios() { }
    }
}
