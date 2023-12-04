using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVecteurs
{
    public class Vecteur3D : Vecteur2D 
    {
        public int Z { get; set; }

        public Vecteur3D() : base()
        {
            Z = 0;
        }
        public Vecteur3D(int x, int y, int z) : base(x,y)
        {
            Z = z;
        }

        public override string? ToString()
        {
            return base.ToString() + $", Z={Z}";
        }

        public override double Norme()
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

        public override bool Equals(object? obj)
        {
            return obj is Vecteur3D d &&
                   X == d.X &&
                   Y == d.Y &&
                   Z == d.Z;
        }
    }
}
