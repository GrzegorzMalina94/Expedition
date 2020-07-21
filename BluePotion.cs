using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wyprawa
{
    class BluePotion : Weapon, IPotion
    {
        bool used;
        public bool Used { get { return used; } }

        public BluePotion(Game game, Point location, int iconHeight, int iconWidth)
            : base(game, location, iconHeight, iconWidth)
        {
            used = false;
        }

        public override string Name { get { return "Niebieska mikstura"; } }

        public override void Attack (Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}
