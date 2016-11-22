﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Conclave vaticano = 5;
            Cardenal c1 = new Cardenal("Ángelo", "Pío XIII", ENacionalidades.Italiano);
            Cardenal c2 = new Cardenal("Roberto", "Juan XIV");
            Cardenal c3 = new Cardenal("Roberto", "Juan XIV");
            Cardenal c4 = new Cardenal("Juan", "Mateo I", ENacionalidades.Español);
            Cardenal c5 = new Cardenal("Mario", "Francisco I", ENacionalidades.Argentino);
            Cardenal c6 = new Cardenal("John", "Peter II", ENacionalidades.Nigeriano);
            Cardenal c7 = new Cardenal("John", "Peter II", ENacionalidades.Polaco);

            //AGREGO CARDENALES AL CONCLAVE

            vaticano += c1;
            vaticano += c2;
            vaticano += c3;
            vaticano += c4;
            vaticano += c5;
            vaticano += c6;
            vaticano += c7;

            //MUESTRO EL CONCLAVE
            Console.WriteLine(vaticano.Mostrar());

            //PROCESO DE VOTACION
            do
            {
                Conclave.VotarPapa(vaticano);
                Conclave.cantidadVotaciones++;
            } while (!(bool)vaticano);

            //MUESTRO EL RESULTADO DEL CONCLAVE
            Console.WriteLine(vaticano.Mostrar());

            Console.ReadLine();
        }
    }
}
