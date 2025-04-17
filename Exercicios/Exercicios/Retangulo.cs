using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios
{
    class Retangulo
    {
        public double Largura;
        public Double Altura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            double D = (Altura * Altura) + (Largura * Largura);
            return Math.Sqrt(D);
        }
        public override string ToString()
        {
            return "A área do retângulo é " + Area().ToString("f2", CultureInfo.InvariantCulture) + 
                ", o perímetro é " +
                Perimetro().ToString("F2", CultureInfo.InvariantCulture) + " e a diagonal é " + 
                Diagonal().ToString("f2", CultureInfo.InvariantCulture);
         }
    }
}
