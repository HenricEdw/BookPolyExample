using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon poly = new Polygon(4);

            Square square = new Square(2.0f);
            

            Polygon square2 = new Square(8.0f); //<-- Detta funkar för att square är en TYP AV polygon

            Polygon[] polygons = new Polygon[2];

            polygons[0] = poly;
            polygons[1] = square;

            if (square is Polygon)
            {
                Console.WriteLine($"Square är en typ av Polygon {square.NumberOfSides}");
            }

            if (poly is Square)
            {
                Console.WriteLine("Men hit kommer vi aldrig, för Polygon är inte en Square");
            }

            Console.ReadLine();
        }
    }
}
