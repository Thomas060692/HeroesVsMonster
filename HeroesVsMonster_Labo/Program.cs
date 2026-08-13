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

            Character c1 = new Human(d6);
            int test1 = c1.Strike(d4);
            Console.WriteLine();
        }
    }
}
