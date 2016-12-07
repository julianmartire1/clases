using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalLaboratorio
{
    public static class ClasePila
    {
        //Punto 2
        public static Stack<double> OrdenAlreves(Stack<Double> stack)
        {
            Stack<Double> stackNuevo = new Stack<double>();

            while (stack.Count >= 1)
                stackNuevo.Push(stack.Pop());

            return stackNuevo;
        }
    }
}
