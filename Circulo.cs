using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forma01;

namespace Circulo01
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

    // Construtor
    public Circulo(double raio)
    {
        Raio = raio;
    }


        // Adiciona o metodo pra calcular a area
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}