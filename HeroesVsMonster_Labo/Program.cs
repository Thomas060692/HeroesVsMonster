using HeroesVsMonster_Labo.Characters;

namespace HeroesVsMonster_Labo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice d6 = new Dice(1, 6);
            Dice d4 = new Dice(1, 4);

            Character c = new Nain(d6);
            int test = c.Strike(d4);
            c.SubscribeToCombat();

            Character c1 = new Human(d6);
            int test1 = c1.Strike(d4);
            c1.SubscribeToCombat();

            c1.InvokeOnCalcutaleLifeEvent(c.Strike(d4));

            Monster wolf = new Wolf(d6);
            ((Human)c1).Loot(wolf, d4, d6);

            Monster wyrmling = new Wyrmling(d6);
            ((Human)c1).Loot(wyrmling, d4, d6);

            Monster ork = new Ork(d6);
            ((Human)c1).Loot(ork, d4, d6);

            Console.WriteLine();
        }
    }
}
