using TPVecteurs;

Console.WriteLine("****Vecteur2D****");
Console.WriteLine("Vecteur 1 :");
Console.Write("Donnez X : ");
int X = 1;
Console.Write("Donnez Y : ");
int Y = 2;
Vecteur2D v1 = new Vecteur2D(X, Y);
Console.WriteLine(v1);
Console.WriteLine("La norme est : " + v1.Norme());

Console.WriteLine("Vecteur 2 :");
Console.Write("Donnez X : ");
X = 2;
Console.Write("Donnez Y : ");
Y = 3;
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
X = 1;
Console.Write("Donnez Y : ");
Y = 2;
Console.Write("Donnez Z : ");
int Z = 3;
Vecteur2D v3 = new Vecteur3D(X, Y, Z);
Console.WriteLine(v3);
Console.WriteLine("La norme est : " + v3.Norme());

Console.WriteLine("Vecteur 2 :");
Console.Write("Donnez X : ");
X = 2;
Console.Write("Donnez Y : ");
Y = 3;
Console.Write("Donnez Z : ");
Z = 4;
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

Console.WriteLine("Le nombre de vecteurs créés est : " + Vecteur2D.CompteurVecteurs);
Console.WriteLine("Le nombre de vecteurs créés est : " + Vecteur3D.CompteurVecteurs);

List<Vecteur2D> vecteurs = new List<Vecteur2D>();

vecteurs.Add(v4);
vecteurs.Add(v2);
vecteurs.Add(v3);
vecteurs.Add(v1);
Console.WriteLine("Avant le tri :");
foreach (Vecteur2D item in vecteurs)
{
    Console.WriteLine(item);
    Console.WriteLine("N : " + item.Norme());
}
vecteurs.Sort();
Console.WriteLine("Après le tri :");
foreach (Vecteur2D item in vecteurs)
{
    Console.WriteLine(item);
    Console.WriteLine("N : " + item.Norme());

}