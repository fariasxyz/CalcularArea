using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forma01;

namespace Quadrado01
{
    public class Quadrado : Forma
    {
        public double Lado { get; set;}
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
    }
}