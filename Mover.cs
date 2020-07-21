using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        public Point CenterLocation { get { return new Point(location.X + iconWidth / 2, location.Y + iconHeight / 2); } }
        protected Game game;
        private int iconHeight;
        private int iconWidth;

        public Mover(Game game, Point location, int iconHeight, int iconWidth)
        {
            this.game = game;
            this.location = location;
            this.iconHeight = iconHeight;
            this.iconWidth = iconWidth;
        }

        /// <summary>
        /// Check if the given location is in the given distance from the center point of the instance's icon.
        /// </summary>
        /// <param name="locationToCheck">As name suggests.</param>
        /// <param name="distance">See in the method main description.</param>
        /// <returns></returns>
        public bool Nearby(Point locationToCheck, int distance)
        {
            if(Math.Abs(CenterLocation.X - locationToCheck.X) < distance &&
               (Math.Abs(CenterLocation.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Check if the given location is in the given direction and in the given distance from the center point of instance.
        /// </summary>
        /// <param name="direction">Up, right, down or left.</param>
        /// <param name="locationToCheck">As name suggests.</param>
        /// <param name="distance">See in the method main description.</param>
        /// <returns></returns>
        public bool Nearby(Direction direction, Point locationToCheck, int distance)
        {
            switch(direction)
            {
                case Direction.Up:
                    //if y > -|x|
                    if (locationToCheck.Y - CenterLocation.Y > -Math.Abs(locationToCheck.X - CenterLocation.X))
                        return false;
                    break;
                case Direction.Right:
                    //if |y| > x
                    if(Math.Abs(locationToCheck.Y - CenterLocation.Y) > locationToCheck.X - CenterLocation.X)
                        return false;
                    break;
                case Direction.Down:
                    //if y < |x|
                    if (locationToCheck.Y - CenterLocation.Y > -Math.Abs(locationToCheck.X - CenterLocation.X))
                        return false;
                    break;
                case Direction.Left:
                    //if |y| > -x
                    if (Math.Abs(locationToCheck.Y - CenterLocation.Y) > -(locationToCheck.X - CenterLocation.X))
                        return false;
                    break;
            }

            double a2 = Math.Pow(Math.Abs(CenterLocation.X - locationToCheck.X), 2);
            double b2 = Math.Pow(Math.Abs(CenterLocation.Y - locationToCheck.Y), 2);
            if (Math.Sqrt(a2+b2) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction directon, Rectangle boundaries)
        {
            Point newLocation = location;
            switch(directon)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }        
    }
}
