﻿using TPVecteurs;

Console.WriteLine("****Vecteur2D****");
Console.WriteLine("Vecteur 1 :");
Console.Write("Donnez X : ");
int X = int.Parse(Console.ReadLine());
Console.Write("Donnez Y : ");
int Y = int.Parse(Console.ReadLine());
Vecteur2D v1 = new Vecteur2D(X, Y);
Console.WriteLine(v1);
Console.WriteLine("La norme est : " + v1.Norme());

Console.WriteLine("Vecteur 2 :");
Console.Write("Donnez X : ");
X = int.Parse(Console.ReadLine());
Console.Write("Donnez Y : ");
Y = int.Parse(Console.ReadLine());
Vecteur2D v2 = new Vecteur2D(X, Y);
Console.WriteLine(v2);
Console.WriteLine("La norme est : " + v2.Norme());

if (v1.Equals(v2))
{
    Console.WriteLine("Les deux vecteurs sont identiques.");
}
else
{
    Console.WriteLine("Les deux vecteurs sont différents.");
}

Console.WriteLine("****Vecteur3D****");
Console.WriteLine("Vecteur 1 :");
Console.Write("Donnez X : ");
X = int.Parse(Console.ReadLine());
Console.Write("Donnez Y : ");
Y = int.Parse(Console.ReadLine());
Console.Write("Donnez Z : ");
int Z = int.Parse(Console.ReadLine());
Vecteur2D v3 = new Vecteur3D(X, Y, Z);
Console.WriteLine(v3);
Console.WriteLine("La norme est : " + v3.Norme());

Console.WriteLine("Vecteur 2 :");
Console.Write("Donnez X : ");
X = int.Parse(Console.ReadLine());
Console.Write("Donnez Y : ");
Y = int.Parse(Console.ReadLine());
Console.Write("Donnez Z : ");
Z = int.Parse(Console.ReadLine());
Vecteur2D v4 = new Vecteur3D(X, Y, Z);
Console.WriteLine(v4);
Console.WriteLine("La norme est : " + v4.Norme());

if (v3.Equals(v4))
{
    Console.WriteLine("Les deux vecteurs sont identiques.");
}
else
{
    Console.WriteLine("Les deux vecteurs sont différents.");
}