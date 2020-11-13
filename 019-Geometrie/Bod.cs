using System;
using System.Collections.Generic;
using System.Text;

namespace _019_Geometrie
{
    class Bod
    {
        public double x { get; set; }
        public double y { get; set; }

        public Bod (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public bool JeShodnyS(Bod jinyBod)
        {
            return this.x == jinyBod.x && this.y == jinyBod.y;
        }
        public double VzdalenostOd(Bod jinyBod)
        {
            double dx = this.x - jinyBod.x;
            double dy = this.y - jinyBod.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override string ToString()
        {
            return $"Bod [{x}, {y}]";
        }
    }
}
