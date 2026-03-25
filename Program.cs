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
        Console.WriteLine($"Après réduction et dégats: {m1.RecevoirDegats(50, 20)}");

        m1.LancerSort();
        g1.Attaquer();

        //creation de liste de personnage p7
        Console.WriteLine("=====polymorph test======");
        List<Personnage> personnages = new List<Personnage>();
        personnages.Add(new Magicien("Loko le magicien", 300, 100));
        personnages.Add(new Guerrier("Hluk le guerrier", 1500, 500));
        personnages.Add(new Archer("Arch", 500, 10));


        foreach (Personnage personnage in personnages)
        {
            personnage.Afficher();
            //teste avec une autr méthode p8
            // personnage.Attaquer(); //erreur de compilation

            // Console.WriteLine("=====polymorph foreach test======");

            //casting sans securisation

            // Guerrier g = (Guerrier)personnage;
            // g.Attaquer();

            // Magicien m = (Magicien)personnage;
            // m.LancerSort();

            if (personnage is Magicien m)
            {
                m.LancerSort();
                m.ToString();
                Console.WriteLine(m.ToString());

            }
            else if (personnage is Guerrier g)
            {
                g.Attaquer();
                Console.WriteLine(g.ToString());
            }
            else if(personnage is Archer a)
            {
                a.Tirer();
            }
        }
    }
}
