using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Triangle : Polygon
    {
        public float Size { get; set; }

        public Triangle(float size)
        {
            Size = size;
            NumberOfSides = 3;
        }
    }
}