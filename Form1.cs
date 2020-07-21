using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(70, 50, 420, 160));
            game.NewLevel(random);
            batHitPoints.Text = "";
            ghostHitPoints.Text = "";
            ghoulHitPoints.Text = "";
            UpdateCharacters();
        }

        private void InventorySword_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                inventorySword.BorderStyle = BorderStyle.FixedSingle;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
            }
        }

        private void InventoryBow_Click(object sender, EventArgs e)
        {
            game.Equip("Łuk");
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.FixedSingle;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
        }

        private void InventoryMace_Click(object sender, EventArgs e)
        {
            game.Equip("Buława");
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.FixedSingle;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
        }

        private void InventoryBluePotion_Click(object sender, EventArgs e)
        {
            game.Equip("Niebieska mikstura");
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
        }

        private void InventoryRedPotion_Click(object sender, EventArgs e)
        {
            game.Equip("Czerwona mikstura");
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
        }

        private void MoveLeftBtn_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackLeftBtn_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void AttackUpBtn_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackRightBtn_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void AttackDownBtn_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            //Player data
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            
            //Enemies location and visibility data updating
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            
            int shownEnemies = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        shownEnemies++;
                    }
                }
                else if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        shownEnemies++;
                    }
                }
                else
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        shownEnemies++;
                    }
                }
            }
            

            //Enemies visibility and hit points info updating
            if(showBat==true)
            {
                bat.Visible = true;                
            }
            else
            {
                bat.Visible = false;
            }

            if (showGhost == true)
            {
                ghost.Visible = true;                
            }
            else
            {
                ghost.Visible = false;
            }

            if (showGhoul == true)
            {
                ghoul.Visible = true;
            }
            else
            {
                ghoul.Visible = false;
            }


            //Weapon in room (Bühnewaffe) visibility updating
            bühneBluePotion.Visible = false;
            bühneRedPotion.Visible = false;
            bühneSword.Visible = false;
            bühneBow.Visible = false;
            bühneMace.Visible = false;
            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Niebieska mikstura":
                    weaponControl = bühneBluePotion; break;
                case "Czerwona mikstura":
                    weaponControl = bühneRedPotion; break;
                case "Miecz":
                    weaponControl = bühneSword; break;
                case "Łuk":
                    weaponControl = bühneBow; break;
                case "Buława":
                    weaponControl = bühneMace; break;
            }

            weaponControl.Visible = true;


            //Inventory weapons updating
            if (game.CheckPlayerInventory("Niebieska mikstura"))
                inventoryBluePotion.Visible = true;
            else inventoryBluePotion.Visible = false;

            if (game.CheckPlayerInventory("Czerwona mikstura"))
                inventoryRedPotion.Visible = true;
            else inventoryRedPotion.Visible = false;

            if (game.CheckPlayerInventory("Miecz"))
                inventorySword.Visible = true;
            else inventorySword.Visible = false;

            if (game.CheckPlayerInventory("Łuk"))
                inventoryBow.Visible = true;
            else inventoryBow.Visible = false;

            if (game.CheckPlayerInventory("Buława"))
                inventoryMace.Visible = true;
            else inventoryMace.Visible = false;

            //Updating Bühnewaffe data
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            //Handling "'Chłopek' is dead" event.
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Chłopek zostoł zabity");
                Application.Exit();
            }

            //Handling "all enemies are dead (level is completed)" event
            if (shownEnemies < 1)
            {
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        //Für tests:
        private void testButton_Click(object sender, EventArgs e)
        {
            if (game.player.Nearby(Direction.Right, new Point(testButton.Location.X + 15, testButton.Location.Y + 15), 30))
                MessageBox.Show("Ja, sięgosz mie.");
        }
    }
}
