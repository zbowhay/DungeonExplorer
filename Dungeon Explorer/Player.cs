using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Player
    {
        public PictureBox hero;
        public int health;
        List<Weapon> weaponList = new List<Weapon>();
        public List<Enemy> enemyList;
        public DungeonExplorer dungeon;
        protected int damage, itemEquipped;

        // used to check if level progression is necessary.
        public bool levelProgression(List<Enemy> enemies)
        {
            for (int a = 0; a < enemies.Count; a++)
            {
                if (enemies.ElementAt(a).monsterImage.Visible)// if any monster is still visible don't progress.
                    return false;
            }
            return true;// if no monsters are visible progress.
        }

        // used to see if hero has been hit by a visible monster. also restarts game upon death
        public void checkIfHit()
        {
            for (int a = 0; a < enemyList.Count; a++)
            {
                if (enemyList.ElementAt(a).monsterImage.Visible)// make sure only visible monsters can do damage
                {
                    int x, y;
                    x = (enemyList.ElementAt(a).monsterImage.Location.X - 20);// increase width of damage area by 20 pixel
                    y = (enemyList.ElementAt(a).monsterImage.Location.Y - 20);// increase height of damage area by 20 pixel
                    Point p = new Point(x, y);
                    PictureBox monsterDamageRadius = new PictureBox();
                    monsterDamageRadius.Location = p;
                    // gives the monsters a 20 pixel damage radius around the peremeter of their respective 35x35 PictureBoxes
                    monsterDamageRadius.Width = 80;
                    monsterDamageRadius.Height = 80;
                    if (isTouching(hero, monsterDamageRadius))// if hit by monster
                    {
                        health -= enemyList.ElementAt(a).damage;
                        if (health < 1)// if hero health drops below 1
                        {
                            hero.Visible = false;
                            MessageBox.Show("Game over!");
                            Application.Exit();
                            /**reset();// reset inventory!
                            health = 20;// reset health**/
                        }
                    }
                }
            }
        }

        // handles attacking and healing!
        public void attack(string direction)
        {
            for (int a = 0; a < enemyList.Count; a++)
            {
                if (enemyList.ElementAt(a).monsterImage.Visible)// makes sure monster is visible before doing damage
                {
                    //WEAPONS

                    if (itemEquipped == 1)//sword equipped
                    {
                        if (enemyList.ElementAt(a).DetectSwordDamage(hero, direction))// check for sword collision
                        {
                            enemyList.ElementAt(a).health -= damage;// deal damage based on what weapon is equipped
                            enemyList.ElementAt(a).updateHealth();// update enemey health
                            
                        }
                    }
                    if (itemEquipped == 2)//Battle Axe equipped
                    {
                        if (enemyList.ElementAt(a).DetectAxeDamage(hero))// check for Battle Axe collision
                        {
                            enemyList.ElementAt(a).health -= damage;// deal damage based on what weapon is equipped
                            enemyList.ElementAt(a).updateHealth();// update enemey health

                        }
                    }
                    if (itemEquipped == 3)//mace equipped
                    {
                        if (enemyList.ElementAt(a).DetectMaceDamage(hero))// check for mace collision
                        {
                            enemyList.ElementAt(a).health -= damage;// deal damage based on what weapon is equipped
                            enemyList.ElementAt(a).updateHealth();// update enemey health

                        }
                    }

                    //POTIONS

                    if (itemEquipped == 4)//blue potion equipped
                    {
                        health += 5;// heals for amount that blue potions heal for (5)
                        dungeon.removePotionFromInventory("bluePot");
                    }
                    if (itemEquipped == 5)//red potion equipped
                    {
                        health += 10;// heals for amount that red potion heal for (10)
                        dungeon.removePotionFromInventory("redPot");
                    }
                    // add other weapon attacks here...

                    
                    
                }
            }
        }

        // equipping items
        public void equip(int item)
        {
            if (item == 1)//sword
            {
                dungeon.EquipWeapon();
                damage = 3;
                itemEquipped = 1;
            }
            if (item == 2)//battle axe
            {
                dungeon.EquipWeapon();
                damage = 7;
                itemEquipped = 2;
            }
            if (item == 3)//mace
            {
                dungeon.EquipWeapon();
                damage = 5;
                itemEquipped = 3;
            }
            if (item == 4)//blue potion
            {
                dungeon.EquipPotion();
                // heal for 5
                itemEquipped = 4;
            }
            if (item == 5)//red potion
            {
                dungeon.EquipPotion();
                //heal for 10;
                itemEquipped = 5;
            }
        }
        
       /** // remove all weapons from screen and weaponList. also resets monster visibility
        public void reset()
        {
            for (int b = (weaponList.Count - 1); b >= 0; b--)// take items out of weaponList
            {
                weaponList.Remove(weaponList.ElementAt(b));// remove all items from weaponList
            }
            for (int a = 0; a < enemyList.Count; a++)// set all enemies visibility to false
            {
                enemyList.ElementAt(a).setVisibility(false);
            }
            dungeon.removeWeaponsFromHero();
            dungeon.checkForDeadEnemies();
        }**/
        
        // add weapon to inventory!
        public void addWeapon(Weapon wep)
        {
            weaponList.Add(wep);// adds weapon to weaponList
            dungeon.updateInventory(weaponList[weaponList.Count - 1].weaponInventory); // makes weapons appear in inventory.
        }
        
        // controls player movement
        public void Move(int direction)
        {
            if (direction == 1)// North
            {          
                int y = hero.Location.Y;
                int x = hero.Location.X;
                y -= 5;
                if (y < 61)// top border of dungeon floor (Location of Y Coord)
                {
                    y = 61;// cant go past top border
                }
                Point p = new Point(x,y);
                hero.Location = p;
            }
            if (direction == 2)// East
            {
                int y = hero.Location.Y;
                int x = hero.Location.X;
                x += 5;
                if (x > 490)//  right border of dungeon floor (Location of X Coord)
                {
                    x = 490;// can't go past right border
                }
                Point p = new Point(x, y);
                hero.Location = p;
            }
            if (direction == 3)// South
            {
                int y = hero.Location.Y;
                int x = hero.Location.X;
                y += 5;
                if (y >= 210)// bottom border of dungeon floor (location of Y Coord)
                {
                    y = 210;// cant go past bottom border
                }
                Point p = new Point(x, y);
                hero.Location = p;
            }
            if (direction == 4)// West
            {
                int y = hero.Location.Y;
                int x = hero.Location.X;
                x -= 5;
                if (x < 77)// Left border of dungeon floor (Location of X Coord)
                {
                    x = 77;// cant go past left border
                }
                Point p = new Point(x, y);
                hero.Location = p;
            }
        }

        public bool isTouching(PictureBox p1, PictureBox p2)// check to see if two images are touching eachother
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p1.Height < p1.Location.Y)
                return false;
            return true;
        }
    }
}
