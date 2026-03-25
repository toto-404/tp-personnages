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

        //test method degats reduction

        m1.Afficher();
        Console.WriteLine($"Après dégats: {m1.RecevoirDegats(50)}");
        Console.WriteLine($"Après réduction et dégats: {m1.RecevoirDegats(50,20)}");

        m1.LancerSort();
        g1.Attaquer();

        //creation de liste de personnage p7
        Console.WriteLine("=====polymorph test======");
        List <Personnage> personnages = new List<Personnage>();
        personnages.Add(new Magicien("Loko le magicien", 300, 100));
        personnages.Add(new Guerrier("Hluk le guerrier",1500,500));

        foreach(Personnage personnage in personnages)
        {
            personnage.Afficher();
        }
    }
}
