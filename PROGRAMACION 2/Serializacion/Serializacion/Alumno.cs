﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Alumno : Persona
    {
        public int legajo;

        public Alumno()
        {
 
        }

        public Alumno(string nombre, int legajo)
            : base(nombre)
        {
            this.legajo = legajo;
        }
    }
}
