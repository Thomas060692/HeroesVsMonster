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
            Console.WriteLine();
        }
    }
}
