using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Polygon
    {
        //Auto-Property
        public int NumberOfSides { get; set; }
        
        //Parameterlös konstruktor
        public Polygon()
        {
            NumberOfSides = 0;
        }

        //Konstruktor med parameter
        public Polygon(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
