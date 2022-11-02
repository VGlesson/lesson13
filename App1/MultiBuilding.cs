using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class MultiBuilding:Building
    {
        string flors;
        int Flors
        {
            get
            {
                return Flors;
            }
            set
            {
                if (value > 0)
                    Flors = value;
                else
                    throw new Exception("Отрицательная этажность");
            }
        }

        public MultiBuilding(string direction, int length, int width, int height, string flors)
            :base (direction, length, width, height)
        {
            this.flors = flors;
        }

        public string Print()
        {
            string result = base.Print();
            result += $"{flors}";
            return result;

        }
    }
}
