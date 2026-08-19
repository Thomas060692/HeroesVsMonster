using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsMonster_Labo.Interface
{
    internal interface ICharacter
    {
        public int Endurance { get; }
        public int Strength { get; }

        public int Strike(Dice dice);

        public void SubscribeToCombat();

        public void InvokeOnCalcutaleLifeEvent(int end);
    }
}
