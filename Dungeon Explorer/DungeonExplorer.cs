using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DungeonExplorer : Form
    {
        Player player; //create player object
        Game game; //create game object
        Weapon[] weapons = new Weapon[5];
        Enemy[] enemies = new Enemy[3];

        public DungeonExplorer()
        {
            InitializeComponent();
            InitializeGame();
            InitializeEnemy();
            InitializePlayer();
            InitializeWeapons();
        }

        public void InitializePlayer()
        {
            player = new Player();
            // intialize this DungeonExplorer Object
            player.dungeon = this;
            // intialize other Player attributes
            playerImage.Visible = true;
            player.health = 20;
            player.hero = playerImage;
            // initialize Enemy List
            player.enemyList = new List<Enemy>();
            player.enemyList.Add(enemies[0]);
            player.enemyList.Add(enemies[1]);
            player.enemyList.Add(enemies[2]);
            //update Stats
            updateStats();
            
        }

        public void InitializeEnemy()
        {
            //create and assign enemies
            enemies[0] = new Enemy(6, 2, 5, batImage, "bat");//Bat
            enemies[1] = new Enemy(8, 3, 5, ghostImage, "ghost");//Ghost
            enemies[2] = new Enemy(10, 4, 5, ghoulImage, "ghoul");//Ghoul
            // intialize their dungeon object
            for (int a = 0; a < 3; a++)
            {
                enemies.ElementAt(a).dungeon = this;
            }
        }

        public void InitializeGame()
        {
            game = new Game();
            // initialize this DungeonExplorer Object
            game.dungeon = this;
            // initialize images
            game.ghost = ghostImage;
            game.ghoul = ghoulImage;
            game.bat = batImage;
            game.sword = swordImage;
            game.mace = maceImage;
            game.axe = battleAxeImage;
            game.bluePot = potionBlueImage;
            game.redPot = potionRedImage;
            game.player = playerImage;
            game.swordinv = swordInventory;
            game.maceinv = maceInventory;
            game.axeinv = battleAxeInventory;
            game.blueinv = potionBlueInventory;
            game.redinv = potionRedInventory;
            // initialize level
            game.level = 1;
            game.updateLevel(game.level);
        }

        public void InitializeWeapons()
        {
            weapons[0] = new Weapon(swordImage, player, swordInventory);
            weapons[1] = new Weapon(battleAxeImage, player, battleAxeInventory);
            weapons[2] = new Weapon(maceImage, player, maceInventory);
            weapons[3] = new Weapon(potionBlueImage, player, potionBlueInventory);
            weapons[4] = new Weapon(potionRedImage, player, potionRedInventory);
        }

        public void updateVisibility(PictureBox image, Boolean boo)
        {
            image.Visible = boo;
        }

        public void updateStats()// method placed in every button event handler so that way it updates every turn
        {
            playerHealth.Text = player.health.ToString();
            batHealth.Text = enemies[0].health.ToString();
            ghostHealth.Text = enemies[1].health.ToString();
            ghoulHealth.Text = enemies[2].health.ToString();
        }

        //change interface for when weapons are equipped
        public void EquipWeapon()
        {
            AttackLabel.Text = "Attack:";
            aRight.Text = "Right";
            aUp.Text = "Up";
            aLeft.Text = "Left";
            aDown.Text = "Down";
        }
        
        // change interface for when potions are equipped
        public void EquipPotion()
        {
            AttackLabel.Text = "Heal:";
            aRight.Text = "Heal";
            aUp.Text = "Heal";
            aLeft.Text = "Heal";
            aDown.Text = "Heal";
        }
        
        // removes potions from inventory (called by player attack method)
        public void removePotionFromInventory(string potion)
        {
            if(potion.Equals("redPot"))
            {
                potionRedInventory.Visible = false;
                // keeps you from having infinite heals (below)
                EquipWeapon();
                player.equip(1);
                swordInventory.BorderStyle = BorderStyle.FixedSingle;
            }
            if (potion.Equals("bluePot"))
            {
                potionBlueInventory.Visible = false;
                // keeps you from having infinite heals (below)
                EquipWeapon();
                player.equip(1);
                swordInventory.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        
        //resets all items visibility to false.
        public void resetItemVisibility()
        {
            // all items that can be picked up
            potionRedImage.Visible = false;
            potionBlueImage.Visible = false;
            swordImage.Visible = false;
            maceImage.Visible = false;
            battleAxeImage.Visible = false;
        }

        public void updateInventory(PictureBox inventoryImage)
        {
            inventoryImage.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void mUp_Click(object sender, EventArgs e)
        {
            player.Move(1);
            checkForWeaponPickup();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void mRight_Click(object sender, EventArgs e)
        {
            player.Move(2);
            checkForWeaponPickup();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void mDown_Click(object sender, EventArgs e)
        {
            player.Move(3);
            checkForWeaponPickup();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void mLeft_Click(object sender, EventArgs e)
        {
            player.Move(4);
            checkForWeaponPickup();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void aUp_Click(object sender, EventArgs e)
        {
            player.attack("up");
            checkForDeadEnemies();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void aRight_Click(object sender, EventArgs e)
        {
            player.attack("right");
            checkForDeadEnemies();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void aDown_Click(object sender, EventArgs e)
        {
            player.attack("down");
            checkForDeadEnemies();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void aLeft_Click(object sender, EventArgs e)
        {
            player.attack("left");
            checkForDeadEnemies();
            EnemyMove();
            player.checkIfHit();
            updateStats();
        }

        private void swordInventory_Click(object sender, EventArgs e)
        {
            resetInventoryBorderStyle();// removes borderstyle effects from all inventory items
            player.equip(1);// equip sword
            swordInventory.BorderStyle = BorderStyle.FixedSingle;// change border style so it looks equipped

        }
        
        private void potionBlueInventory_Click(object sender, EventArgs e)
        {
            resetInventoryBorderStyle();// removes borderstyle effects from all inventory items
            player.equip(4);//blue pot
            potionBlueInventory.BorderStyle = BorderStyle.FixedSingle;// change border stlye so it looks equipped
        }
        
        // does what it says
        private void resetInventoryBorderStyle()
        {
            swordInventory.BorderStyle = BorderStyle.None;
            maceInventory.BorderStyle = BorderStyle.None;
            battleAxeInventory.BorderStyle = BorderStyle.None;
            potionBlueInventory.BorderStyle = BorderStyle.None;
            potionRedInventory.BorderStyle = BorderStyle.None;
        }

        private void battleAxeInventory_Click(object sender, EventArgs e)
        {
            resetInventoryBorderStyle();// removes borderstyle effects from all inventory items
            player.equip(2);//battle axe
            battleAxeInventory.BorderStyle = BorderStyle.FixedSingle;// change border stlye so it looks equipped
        }

        private void maceInventory_Click(object sender, EventArgs e)
        {
            resetInventoryBorderStyle();// removes borderstyle effects from all inventory items
            player.equip(3);//mace
            maceInventory.BorderStyle = BorderStyle.FixedSingle;// change border stlye so it looks equipped
        }

        private void potionRedInventory_Click(object sender, EventArgs e)
        {
            resetInventoryBorderStyle();// removes borderstyle effects from all inventory items
            player.equip(5);//blue pot
            potionRedInventory.BorderStyle = BorderStyle.FixedSingle;// change border stlye so it looks equipped
        }
        
        // checks if all enemies are dead (not visible) and updates level
        public void checkForDeadEnemies()
        {
            if (player.health < 1)// if player dies restart game.
            {
                game.level = 1;
                game.updateLevel(game.level);
            }
            if (player.levelProgression(player.enemyList))// if all enemies are dead
            {
                game.level++;
                game.updateLevel(game.level);// move to next level
            }
        }

        // check to see if their is a weapon that needs to be picked up
        public void checkForWeaponPickup()
        {
            for (int a = 0; a < weapons.Length; a++)// runs through all possible weapons and checks if they need to be picked up
            {
                weapons[a].pickUpWeapon();
            }
        }

        // moves enemies
        public void EnemyMove()
        {
            for (int a = 0; a < enemies.Length; a++)
            {
                enemies.ElementAt(a).moveEnemy(playerImage);
            }
        }
    }
}
