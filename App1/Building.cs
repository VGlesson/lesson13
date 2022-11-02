using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Building
    {
        string direction;
        int length;
        int width;
        int height;

        public Building (string direction, int length, int width, int height)
        {
            this.direction = direction;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $"{direction} {length} {width} {height}";
        }
    }
}
