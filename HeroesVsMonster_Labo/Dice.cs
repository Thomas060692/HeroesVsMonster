using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsMonster_Labo
{
    internal class Dice
    {
        Random rdn = new Random();

        public int Min { get; private set; }
        public int Max { get; private set; }

        public Dice(int min, int max)
        {
            Min = min;
            Max = max + 1;
        }

        public int Throw()
        {
            return rdn.Next(Min, Max);
        }
    }
}
