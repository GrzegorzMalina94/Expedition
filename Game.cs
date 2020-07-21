using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Wyprawa
{
    class Game
    {
        public List<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        //Für tests: private -> public
        public Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public Point PlayerCenterLocation { get { return player.CenterLocation; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }
        public bool PotionEquipped = false;
        private int level = 0;
        private int Level { get { return Level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70), 30, 30);
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);            
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left +
                random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top +
                random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random), 30, 30);
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random), 30, 30);
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random), 30, 30);
                    break;
                case 4:
                    Weapon levelsWeapon;
                    if (PlayerWeapons.Contains("Łuk") && PlayerWeapons.Contains("Niebieska mikstura"))
                        levelsWeapon = null;
                    else if(PlayerWeapons.Contains("Łuk"))
                        levelsWeapon = new BluePotion(this, GetRandomLocation(random), 30, 30);
                    else
                        levelsWeapon = new Bow(this, GetRandomLocation(random), 30, 30);
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), 30, 30));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = levelsWeapon;
                    break;
                case 5:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), 30, 30));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random), 30, 30);
                    break;
                case 6:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), 30, 30));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random), 30, 30);
                    break;
                case 7:
                    if (PlayerWeapons.Contains("Buława") && PlayerWeapons.Contains("Czerwona mikstura"))
                        levelsWeapon = null;
                    else if (PlayerWeapons.Contains("Buława"))
                        levelsWeapon = new RedPotion(this, GetRandomLocation(random), 30, 30);
                    else
                        levelsWeapon = new Mace(this, GetRandomLocation(random), 30, 30);
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), 30, 30));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), 30, 30));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), 30, 30));
                    WeaponInRoom = levelsWeapon;
                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }



}
