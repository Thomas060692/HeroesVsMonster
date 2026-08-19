using HeroesVsMonster_Labo.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsMonster_Labo.Interface
{
    internal interface ILoot
    {
        public void Loot(Monster mob, Dice d4, Dice d6);
    }
}
