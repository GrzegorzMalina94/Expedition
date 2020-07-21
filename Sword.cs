using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wyprawa
{
    class Sword : Weapon
    {
        private const int maxDamage = 3;
        private const int range = 30;

        public Sword(Game game, Point location, int iconHeight, int iconWidth)
            : base (game, location, iconHeight, iconWidth) { }

        public override string Name { get { return "Miecz"; } }

        public override void Attack(Direction direction, Random random)
        {
            switch(direction)
            {
                case Direction.Up:
                    if (DamageEnemy(Direction.Right, range, maxDamage, random))
                        return;
                    if (DamageEnemy(Direction.Up, range, maxDamage, random))
                        return;
                    DamageEnemy(Direction.Left, range, maxDamage, random);
                    break;
                case Direction.Right:
                    if (DamageEnemy(Direction.Down, range, maxDamage, random))
                        return;
                    if (DamageEnemy(Direction.Right, range, maxDamage, random))
                        return;
                    DamageEnemy(Direction.Up, range, maxDamage, random);
                    break;
                case Direction.Down:
                    if (DamageEnemy(Direction.Left, range, maxDamage, random))
                        return;
                    if (DamageEnemy(Direction.Down, range, maxDamage, random))
                        return;
                    DamageEnemy(Direction.Right, range, maxDamage, random);
                    break;
                case Direction.Left:
                    if (DamageEnemy(Direction.Down, range, maxDamage, random))
                        return;
                    if (DamageEnemy(Direction.Left, range, maxDamage, random))
                        return;
                    DamageEnemy(Direction.Up, range, maxDamage, random);
                    break;
            }
        }
    }
}
