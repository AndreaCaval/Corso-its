using System;

namespace class_es_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1;
        }

        class Point3D
        {
            public double X { get; private set; }

            public double Y { get; private set; }

            public double Z { get; private set; }

            public string Name { get; private set; }

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Point3D(double x, double y, double z, string name) : this(x, y, z)
            {
                Name = name;
            }
        }
    }
}
