﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Privado : Avion
    {
        public Privado(double precio, double velMax)
            : base(precio, velMax)
        {
 
        }
    }
}
