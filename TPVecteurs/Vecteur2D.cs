using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVecteurs
{
    public class Vecteur2D
    {
        public Vecteur2D()
        {
            X = 0;
            Y = 0;
            CompteurVecteurs++;
        }
        public Vecteur2D(int x, int y)
        {
            X = x;
            Y = y;
            CompteurVecteurs++;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static int CompteurVecteurs { get; private set; }

        public override string? ToString()
        {
            return $"X={X}, Y={Y}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Vecteur2D d &&
                   X == d.X &&
                   Y == d.Y;
        }

        public virtual double Norme()
        {
            return Math.Sqrt((X * X) + (Y * Y));
        }
    }
}
