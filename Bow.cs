using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Bow : Weapon
    {
        private const int maxDamage = 1;
        private const int range = 50;

        public Bow(Game game, Point location, int iconHeight, int iconWidth)
            : base(game, location, iconHeight, iconWidth) { }

        public override string Name { get { return "Łuk"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, range, maxDamage, random);
        }
    }
}
