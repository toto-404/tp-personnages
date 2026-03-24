namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PERSONNAGE");
        Personnage p1 = new Personnage("Hulk", 800);
        p1.RecevoirDegats(50);
        p1.Afficher();

        //guerrier
        Console.WriteLine("GUERRIER");
        Guerrier g1 = new Guerrier("Arthur", 100, 20);
        g1.Afficher();


        //Magicien
        Console.WriteLine("MAGICIEN");
        Magicien m1 = new Magicien("Merlin", 80, 50);
        m1.Afficher();
    }
}
