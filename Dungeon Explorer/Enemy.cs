using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Enemy
    {
        public int health, damage, velocity;
        public string identifier;
        public PictureBox monsterImage;
        public DungeonExplorer dungeon;
        private Random rand = new Random();

        public Enemy(int h, int d, int v, PictureBox p, string id)
        {
            health = h;
            damage = d; 
            velocity = v;
            monsterImage = p;
            identifier = id;
        }

        public void setVisibility(bool visible)
        {
            monsterImage.Visible = visible;

        }
        public bool DetectSwordDamage(PictureBox hero, string direction)// sword hits enemies to the left, in front, and to the right of player depending on direction
        {
            if(direction.Equals("up"))
            {
                int x, y;
                x = (hero.Location.X - 25);
                y = (hero.Location.Y - 25);
                Point p = new Point(x,y);
                PictureBox swordSwing = new PictureBox();
                swordSwing.Location = p;
                swordSwing.Width = 85;
                swordSwing.Height = 60;
                if (isTouching(monsterImage, swordSwing))// if sword hit
                {
                    return true;
                }
            }
            if (direction.Equals("right"))
            {
                int x, y;
                x = hero.Location.X;
                y = hero.Location.Y - 25;
                Point p = new Point(x, y);
                PictureBox swordSwing = new PictureBox();
                swordSwing.Location = p;
                swordSwing.Width = 60;
                swordSwing.Height = 85;
                if (isTouching(monsterImage, swordSwing))// if sword hit
                {
                    return true;
                }
            }
            if (direction.Equals("down"))
            {
                int x, y;
                x = hero.Location.X - 25;
                y = hero.Location.Y;
                Point p = new Point(x, y);
                PictureBox swordSwing = new PictureBox();
                swordSwing.Location = p;
                swordSwing.Size = new Size(85,60);
                swordSwing.Show();
                if (isTouching(monsterImage, swordSwing))// if sword hit
                {
                    return true;
                }
            }
            if (direction.Equals("left"))
            {
                int x, y;
                x = hero.Location.X - 25;
                y = hero.Location.Y - 25;
                Point p = new Point(x, y);
                PictureBox swordSwing = new PictureBox();
                swordSwing.Location = p;
                swordSwing.Width = 60;
                swordSwing.Height = 85;
                if (isTouching(monsterImage, swordSwing))// if sword hit
                {
                    return true;
                }
            }
            return false;
        }

        //detect if monster has been hit by a mace
        public bool DetectMaceDamage(PictureBox hero)// mace has a full swing with the same area as sword
        {
            int x, y;
            x = hero.Location.X - 25;
            y = hero.Location.Y - 25;
            Point p = new Point(x, y);
            PictureBox maceSwing = new PictureBox();// mace swing is a full square area around hero
            maceSwing.Location = p;
            maceSwing.Width = 85;
            maceSwing.Height = 85;
            if (isTouching(monsterImage, maceSwing))// if mace hit
            {
                return true;
            }
            return false;
        }

        // detect if monster has been hit by a Battle Axe
        public bool DetectAxeDamage(PictureBox hero)// axe has a wider swing than mace
        {
            int x, y;
            x = hero.Location.X - 30;
            y = hero.Location.Y - 30;
            Point p = new Point(x, y);
            PictureBox axeSwing = new PictureBox();// axe swing is a full square area around hero
            axeSwing.Location = p;
            axeSwing.Width = 95;
            axeSwing.Height = 95;
            if (isTouching(monsterImage, axeSwing))// if axe hit
            {
                return true;
            }
            return false;
        }

        public void updateHealth()
        {              
            dungeon.updateStats();
            if (health < 1)
            {
                monsterImage.Visible = false;// kill the monster
                // reset health after dieing
                if(identifier.Equals("bat"))
                    health = 6;
                if (identifier.Equals("ghost"))
                    health = 8;
                if (identifier.Equals("ghoul"))
                    health = 10;
            }
            
        }

        public void moveEnemy(PictureBox target)
        {
            Point p;
            int x, y;
            bool toward;// determines if enemies move toward or away from target
            
            // Control Bat Movement

            if (identifier.Equals("bat"))
            {
                x = monsterImage.Location.X;
                y = monsterImage.Location.Y;
                toward = forward(5);// chance to move forward is 50%
                // move monster toward target location
                if (toward)
                {
                    if (monsterImage.Location.X > target.Location.X)
                        x -= 5;
                    if (monsterImage.Location.X < target.Location.X)
                        x += 5;
                    if (monsterImage.Location.Y > target.Location.Y)
                        y -= 5;
                    if (monsterImage.Location.Y < target.Location.Y)
                        y += 5;
                }
                // move monster away from target location
                if (!toward)
                {
                    if (monsterImage.Location.X > target.Location.X)
                        x += 5;
                    if (monsterImage.Location.X < target.Location.X)
                        x -= 5;
                    if (monsterImage.Location.Y > target.Location.Y)
                        y += 5;
                    if (monsterImage.Location.Y < target.Location.Y)
                        y -= 5;
                }
                // create and set new location for bat
                p = new Point(x, y);
                monsterImage.Location = p;
            }

            // Control Ghost Movement

            if (identifier.Equals("ghost"))
            {
                x = monsterImage.Location.X;
                y = monsterImage.Location.Y;
                toward = forward(3);// 33% chance of moving forward
                if (toward)// move toward target
                {
                    if (monsterImage.Location.X > target.Location.X)
                        x -= 5;
                    if (monsterImage.Location.X < target.Location.X)
                        x += 5;
                    if (monsterImage.Location.Y > target.Location.Y)
                        y -= 5;
                    if (monsterImage.Location.Y < target.Location.Y)
                        y += 5;
                }
                if (!toward)
                {
                    // do nothing. stand still
                }
                // create and set new location for ghost
                p = new Point(x, y);
                monsterImage.Location = p;
            }

            // Control Ghoul Movement

            if (identifier.Equals("ghoul"))
            {
                x = monsterImage.Location.X;
                y = monsterImage.Location.Y;
                toward = forward(7);// roughly 66% chance of moving forward
                if (toward)// move toward target
                {
                    if (monsterImage.Location.X > target.Location.X)
                        x -= 5;
                    if (monsterImage.Location.X < target.Location.X)
                        x += 5;
                    if (monsterImage.Location.Y > target.Location.Y)
                        y -= 5;
                    if (monsterImage.Location.Y < target.Location.Y)
                        y += 5;              
                }
                if (!toward)
                {
                    // do nothing. stand still
                }
                // create and set new location for ghoul
                p = new Point(x, y);
                monsterImage.Location = p;
            }
        }

        public bool forward(int odds)// odds is out of 10. EX: 50% forward or back you would enter 5.  70% forward or back you would enter 7
        {
            if (rand.Next(10) <= odds)
            {
                return true;
            }
            else
            {
                return false;
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
