using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wyprawa
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location, int iconHeight, int iconWidth)
            : base(game, location, iconHeight, iconWidth)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        /// <summary>
        /// Used to update position of weapons which belong to inventory of player.
        /// </summary>
        public void UpdatePosition()
        {
            location = game.PlayerLocation;
        }

        protected bool DamageEnemy(Direction direction, int radius,
                                    int damage, Random random)
        {
            foreach(Enemy enemy in game.Enemies)
            {
                if (Nearby(direction, enemy.CenterLocation, radius))
                {
                    enemy.Hit(damage, random);
                    return true;
                }                    
            }
            return false;
            
        }
    }
}
