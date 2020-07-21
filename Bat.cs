using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location, int iconHeight, int iconWidth)
            : base(game, location, 6, iconHeight, iconWidth)
        { }
        
        public override void Move(Random random)
        {
            if(HitPoints >= 1)
            {
                if(random.Next(2) == 1)
                {
                    location = (this as Mover).Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(2, random);
                }
                else
                    location = (this as Mover).Move((Direction)random.Next(4), game.Boundaries);
            }
            
        }
    }
}
