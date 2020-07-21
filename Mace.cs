using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wyprawa
{
    class Mace : Weapon
    {
        private const int maxDamage = 6;
        private const int range = 40;

        public Mace(Game game, Point location, int iconHeight, int iconWidth)
            : base(game, location, iconHeight, iconWidth) { }

        public override string Name { get { return "Buława"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Up, range, maxDamage, random);
            DamageEnemy(Direction.Right, range, maxDamage, random);
            DamageEnemy(Direction.Down, range, maxDamage, random);
            DamageEnemy(Direction.Left, range, maxDamage, random);
        }
    }
}
