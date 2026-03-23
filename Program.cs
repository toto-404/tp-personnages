namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Hulk", 800);
        p1.RecevoirDegats(50);
        p1.Afficher();
    }
}
