using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Building
    {
        string direction { get; set; }
        int length { get; set; }
        int width { get; set; }
        int height { get; set; }

        public Building (string direction, int length, int width, int height)
        {
            this.direction = direction;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public Building(string v)
        {
        }

        public string Print()
        {
            return $"{direction} {length} {width} {height}";
        }
    }
}
