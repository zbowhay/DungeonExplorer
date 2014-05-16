using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Weapon
    {
        // Sword = 1, battle axe = 2, mace = 3, bluepot = 4, redpot = 5;
        public PictureBox weaponImage, heroImage, weaponInventory;
        public bool pickedUp = false;
        public Player player;
        
        
        public Weapon(PictureBox wep, Player p, PictureBox wepInv)
        {
            weaponImage = wep;
            weaponInventory = wepInv;
            player = p;
            heroImage = player.hero;// assigns heroImage to image of player
        }

        public void pickUpWeapon()
        {
            if (isTouching(weaponImage, heroImage) && weaponImage.Visible)// make sure item is visible and touching hero
            {
                pickedUp = true;// not used yet....
                weaponImage.Visible = false;
                player.addWeapon(this);// adds this Weapon object to player's weaponList
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
