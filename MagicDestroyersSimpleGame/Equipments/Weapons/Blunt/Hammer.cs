using System;
using MagicDestroyersSimpleGame.Equipment.Interfaces;

namespace MagicDestroyersSimpleGame.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt, ISpecialItemAbility
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public override void SpecialAbility()
        {
            this.Stun();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}