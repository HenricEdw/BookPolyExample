using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Square : Polygon //<-- efter kolon anger man klassnamnet på den klass man vill ärva IFRÅN
    {
        //Auto-property
        public float Size { get; set; }

        public Square(float size) : base(4) //<-- här anropar vi basklassens konsytruktor för att sätta antal sidor. De är alltid 4 för en Square
        {
            Size = size;  
        }
    }
}
