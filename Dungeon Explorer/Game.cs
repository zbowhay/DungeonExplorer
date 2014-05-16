using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Game
    {
        public int level; // tracks current level
        //private int x, y; // for point generation
        public DungeonExplorer dungeon;
        public PictureBox bat, ghost, ghoul, sword, axe, mace, redPot, bluePot, player, swordinv, maceinv, axeinv, blueinv, redinv;
        private Point p;
        private Random rand = new Random();

        public void updateLevel(int currentLevel)
        {
            dungeon.resetItemVisibility();// makes sure that if any items weren't picked up on a level they will dissapear on the next level.
            if (level == 1)
            {
                MessageBox.Show("Level 1");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(bat, true);
                dungeon.updateVisibility(sword, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(bat, rand);
                generateRandomLocation(sword, rand);
            }
            if (level == 2)
            {
                MessageBox.Show("Level 2");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(ghost, true);
                dungeon.updateVisibility(bluePot, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(ghost, rand);
                generateRandomLocation(bluePot, rand);
            }
            if (level == 3)
            {
                MessageBox.Show("Level 3");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(ghoul, true);
                dungeon.updateVisibility(mace, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(ghoul, rand);
                generateRandomLocation(mace, rand);
            }
            if (level == 4)
            {
                MessageBox.Show("Level 4");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(bat, true);
                dungeon.updateVisibility(ghost, true);
                if (maceinv.Visible)// if mace picked up on level 3...
                {
                    dungeon.updateVisibility(bluePot, true);// spawn blue pot
                    generateRandomLocation(bluePot, rand);
                }
                if (!maceinv.Visible)// if mace not picked up on level 3...
                {
                    dungeon.updateVisibility(mace, true);// spawn mace
                    generateRandomLocation(mace, rand);
                }
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(bat, rand);
                generateRandomLocation(ghost, rand);
            }
            if (level == 5)
            {
                MessageBox.Show("Level 5");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(ghoul, true);
                dungeon.updateVisibility(bat, true);
                dungeon.updateVisibility(redPot, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(ghoul, rand);
                generateRandomLocation(bat, rand);
                generateRandomLocation(redPot, rand);
            }
            if (level == 6)
            {
                MessageBox.Show("Level 6");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(ghoul, true);
                dungeon.updateVisibility(ghost, true);
                dungeon.updateVisibility(axe, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(ghoul, rand);
                generateRandomLocation(ghost, rand);
                generateRandomLocation(axe, rand);
            }
            if (level == 7)
            {
                MessageBox.Show("Level 7");
                // set visibility
                dungeon.updateVisibility(player, true);
                dungeon.updateVisibility(bat, true);
                dungeon.updateVisibility(ghoul, true);
                dungeon.updateVisibility(ghost, true);
                // set location
                generateRandomLocation(player, rand);
                generateRandomLocation(bat, rand);
                generateRandomLocation(ghoul, rand);
                generateRandomLocation(ghost, rand);
                if (axeinv.Visible)// if Battle Axe picked up on level 6...
                {
                    dungeon.updateVisibility(redPot, true);// spawn red pot
                    generateRandomLocation(redPot, rand);
                }
                if(!axeinv.Visible)// if Battle Axe not picked up on level 6...
                {
                    dungeon.updateVisibility(axe, true);// spawn battle axe
                    generateRandomLocation(axe, rand);
                }
            }
            if (level == 8)// declare victory and exit
            {
                MessageBox.Show("You Won!");
                Application.Exit();
            }
        }

        public void generateRandomLocation(PictureBox image, Random rand)
        {
            int x = rand.Next(77, 490);// keep x coord within vertical borders.
            int y = rand.Next(61,210);// keep y coord within horizontal borders.
            p = new Point(x, y);
            image.Location = p;
        }
        
    }
}
