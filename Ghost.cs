using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wyprawa
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location, int iconHeight, int iconWidth)
            : base (game, location, 8, iconHeight, iconWidth)
        { }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(3) == 1)
                {
                    location = (this as Mover).Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                }                
            }
        }
    }    
}
