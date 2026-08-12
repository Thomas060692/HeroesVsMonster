using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsMonster_Labo.Characters
{
    internal abstract class Monster : Character
    {
        protected Monster(Dice dice) : base(dice)
        {
        }
    }
}
