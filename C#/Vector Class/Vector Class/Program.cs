using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector V0 = new Vector(1, 2, 3);

            Console.WriteLine(V0.X);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// represents a three dimentional vector
    /// </summary>
    public class Vector
    {
        //properties
        public double X  { get;set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //constructors
        public Vector(double x, double y, double z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
