using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    public struct Point
    {
        int x;
        int y;
        int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }

        public override string ToString()
        {
            return string.Format("X: {0}, " + "Y: {1}, " + "Z: {2}", x, y, z);
        }
    }
}
