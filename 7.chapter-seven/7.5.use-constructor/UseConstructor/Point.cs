using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseConstructor
{
    class Point
    {
        private int x, y;
        public Point()
        {
            this.x = -1;
            this.y = -1;
            Console.WriteLine("Defaule init");
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Assignment");
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;

            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;  
        }

        public void Deconstruct(out int x,out int y)
        {
            x = this.x;
            y = this.y;
        }
    }
}
