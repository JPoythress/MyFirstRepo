using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Square : Polygon
    {
        public float Size { get; set; }

        public Square(float size)
        {
            Size = size;
            NumberOfSides = 4;
        }
    }
}