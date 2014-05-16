namespace WindowsFormsApplication1
{
    partial class DungeonExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonExplorer));
            this.dungeon = new System.Windows.Forms.PictureBox();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.swordImage = new System.Windows.Forms.PictureBox();
            this.potionBlueImage = new System.Windows.Forms.PictureBox();
            this.potionRedImage = new System.Windows.Forms.PictureBox();
            this.battleAxeImage = new System.Windows.Forms.PictureBox();
            this.maceImage = new System.Windows.Forms.PictureBox();
            this.ghostImage = new System.Windows.Forms.PictureBox();
            this.batImage = new System.Windows.Forms.PictureBox();
            this.ghoulImage = new System.Windows.Forms.PictureBox();
            this.controlContainer = new System.Windows.Forms.PictureBox();
            this.swordInventory = new System.Windows.Forms.PictureBox();
            this.battleAxeInventory = new System.Windows.Forms.PictureBox();
            this.maceInventory = new System.Windows.Forms.PictureBox();
            this.potionRedInventory = new System.Windows.Forms.PictureBox();
            this.potionBlueInventory = new System.Windows.Forms.PictureBox();
            this.statsWindow = new System.Windows.Forms.TableLayoutPanel();
            this.playerHealth = new System.Windows.Forms.Label();
            this.batHealth = new System.Windows.Forms.Label();
            this.ghostHealth = new System.Windows.Forms.Label();
            this.ghoulHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.mUp = new System.Windows.Forms.Button();
            this.mLeft = new System.Windows.Forms.Button();
            this.mRight = new System.Windows.Forms.Button();
            this.mDown = new System.Windows.Forms.Button();
            this.aDown = new System.Windows.Forms.Button();
            this.aRight = new System.Windows.Forms.Button();
            this.aLeft = new System.Windows.Forms.Button();
            this.aUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dungeon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleAxeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleAxeInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueInventory)).BeginInit();
            this.statsWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dungeon
            // 
            this.dungeon.BackColor = System.Drawing.Color.Transparent;
            this.dungeon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dungeon.BackgroundImage")));
            this.dungeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dungeon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dungeon.Location = new System.Drawing.Point(0, 0);
            this.dungeon.Margin = new System.Windows.Forms.Padding(2);
            this.dungeon.Name = "dungeon";
            this.dungeon.Size = new System.Drawing.Size(450, 325);
            this.dungeon.TabIndex = 0;
            this.dungeon.TabStop = false;
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerImage.BackgroundImage")));
            this.playerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerImage.Location = new System.Drawing.Point(58, 10);
            this.playerImage.Margin = new System.Windows.Forms.Padding(2);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(26, 28);
            this.playerImage.TabIndex = 1;
            this.playerImage.TabStop = false;
            this.playerImage.Visible = false;
            // 
            // swordImage
            // 
            this.swordImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swordImage.BackgroundImage")));
            this.swordImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordImage.Location = new System.Drawing.Point(88, 10);
            this.swordImage.Margin = new System.Windows.Forms.Padding(2);
            this.swordImage.Name = "swordImage";
            this.swordImage.Size = new System.Drawing.Size(26, 28);
            this.swordImage.TabIndex = 2;
            this.swordImage.TabStop = false;
            this.swordImage.Visible = false;
            // 
            // potionBlueImage
            // 
            this.potionBlueImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionBlueImage.BackgroundImage")));
            this.potionBlueImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionBlueImage.Location = new System.Drawing.Point(150, 10);
            this.potionBlueImage.Margin = new System.Windows.Forms.Padding(2);
            this.potionBlueImage.Name = "potionBlueImage";
            this.potionBlueImage.Size = new System.Drawing.Size(26, 28);
            this.potionBlueImage.TabIndex = 4;
            this.potionBlueImage.TabStop = false;
            this.potionBlueImage.Visible = false;
            // 
            // potionRedImage
            // 
            this.potionRedImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionRedImage.BackgroundImage")));
            this.potionRedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionRedImage.Location = new System.Drawing.Point(119, 10);
            this.potionRedImage.Margin = new System.Windows.Forms.Padding(2);
            this.potionRedImage.Name = "potionRedImage";
            this.potionRedImage.Size = new System.Drawing.Size(26, 28);
            this.potionRedImage.TabIndex = 3;
            this.potionRedImage.TabStop = false;
            this.potionRedImage.Visible = false;
            // 
            // battleAxeImage
            // 
            this.battleAxeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("battleAxeImage.BackgroundImage")));
            this.battleAxeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.battleAxeImage.Location = new System.Drawing.Point(210, 10);
            this.battleAxeImage.Margin = new System.Windows.Forms.Padding(2);
            this.battleAxeImage.Name = "battleAxeImage";
            this.battleAxeImage.Size = new System.Drawing.Size(26, 28);
            this.battleAxeImage.TabIndex = 6;
            this.battleAxeImage.TabStop = false;
            this.battleAxeImage.Visible = false;
            // 
            // maceImage
            // 
            this.maceImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maceImage.BackgroundImage")));
            this.maceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maceImage.Location = new System.Drawing.Point(179, 10);
            this.maceImage.Margin = new System.Windows.Forms.Padding(2);
            this.maceImage.Name = "maceImage";
            this.maceImage.Size = new System.Drawing.Size(26, 28);
            this.maceImage.TabIndex = 5;
            this.maceImage.TabStop = false;
            this.maceImage.Visible = false;
            // 
            // ghostImage
            // 
            this.ghostImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghostImage.BackgroundImage")));
            this.ghostImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostImage.Location = new System.Drawing.Point(271, 10);
            this.ghostImage.Margin = new System.Windows.Forms.Padding(2);
            this.ghostImage.Name = "ghostImage";
            this.ghostImage.Size = new System.Drawing.Size(26, 28);
            this.ghostImage.TabIndex = 8;
            this.ghostImage.TabStop = false;
            this.ghostImage.Visible = false;
            // 
            // batImage
            // 
            this.batImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batImage.BackgroundImage")));
            this.batImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batImage.Location = new System.Drawing.Point(240, 10);
            this.batImage.Margin = new System.Windows.Forms.Padding(2);
            this.batImage.Name = "batImage";
            this.batImage.Size = new System.Drawing.Size(26, 28);
            this.batImage.TabIndex = 7;
            this.batImage.TabStop = false;
            this.batImage.Visible = false;
            // 
            // ghoulImage
            // 
            this.ghoulImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghoulImage.BackgroundImage")));
            this.ghoulImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghoulImage.Location = new System.Drawing.Point(302, 10);
            this.ghoulImage.Margin = new System.Windows.Forms.Padding(2);
            this.ghoulImage.Name = "ghoulImage";
            this.ghoulImage.Size = new System.Drawing.Size(26, 28);
            this.ghoulImage.TabIndex = 9;
            this.ghoulImage.TabStop = false;
            this.ghoulImage.Visible = false;
            // 
            // controlContainer
            // 
            this.controlContainer.BackColor = System.Drawing.Color.Lavender;
            this.controlContainer.Location = new System.Drawing.Point(450, 0);
            this.controlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(151, 325);
            this.controlContainer.TabIndex = 10;
            this.controlContainer.TabStop = false;
            // 
            // swordInventory
            // 
            this.swordInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.swordInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swordInventory.BackgroundImage")));
            this.swordInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordInventory.Location = new System.Drawing.Point(59, 262);
            this.swordInventory.Margin = new System.Windows.Forms.Padding(2);
            this.swordInventory.Name = "swordInventory";
            this.swordInventory.Size = new System.Drawing.Size(38, 41);
            this.swordInventory.TabIndex = 11;
            this.swordInventory.TabStop = false;
            this.swordInventory.Visible = false;
            this.swordInventory.Click += new System.EventHandler(this.swordInventory_Click);
            // 
            // battleAxeInventory
            // 
            this.battleAxeInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.battleAxeInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("battleAxeInventory.BackgroundImage")));
            this.battleAxeInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.battleAxeInventory.Location = new System.Drawing.Point(101, 262);
            this.battleAxeInventory.Margin = new System.Windows.Forms.Padding(2);
            this.battleAxeInventory.Name = "battleAxeInventory";
            this.battleAxeInventory.Size = new System.Drawing.Size(38, 41);
            this.battleAxeInventory.TabIndex = 12;
            this.battleAxeInventory.TabStop = false;
            this.battleAxeInventory.Visible = false;
            this.battleAxeInventory.Click += new System.EventHandler(this.battleAxeInventory_Click);
            // 
            // maceInventory
            // 
            this.maceInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.maceInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maceInventory.BackgroundImage")));
            this.maceInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maceInventory.Location = new System.Drawing.Point(143, 262);
            this.maceInventory.Margin = new System.Windows.Forms.Padding(2);
            this.maceInventory.Name = "maceInventory";
            this.maceInventory.Size = new System.Drawing.Size(38, 41);
            this.maceInventory.TabIndex = 13;
            this.maceInventory.TabStop = false;
            this.maceInventory.Visible = false;
            this.maceInventory.Click += new System.EventHandler(this.maceInventory_Click);
            // 
            // potionRedInventory
            // 
            this.potionRedInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.potionRedInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionRedInventory.BackgroundImage")));
            this.potionRedInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionRedInventory.Location = new System.Drawing.Point(185, 262);
            this.potionRedInventory.Margin = new System.Windows.Forms.Padding(2);
            this.potionRedInventory.Name = "potionRedInventory";
            this.potionRedInventory.Size = new System.Drawing.Size(38, 41);
            this.potionRedInventory.TabIndex = 14;
            this.potionRedInventory.TabStop = false;
            this.potionRedInventory.Visible = false;
            this.potionRedInventory.Click += new System.EventHandler(this.potionRedInventory_Click);
            // 
            // potionBlueInventory
            // 
            this.potionBlueInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.potionBlueInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionBlueInventory.BackgroundImage")));
            this.potionBlueInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionBlueInventory.Location = new System.Drawing.Point(227, 262);
            this.potionBlueInventory.Margin = new System.Windows.Forms.Padding(2);
            this.potionBlueInventory.Name = "potionBlueInventory";
            this.potionBlueInventory.Size = new System.Drawing.Size(38, 41);
            this.potionBlueInventory.TabIndex = 15;
            this.potionBlueInventory.TabStop = false;
            this.potionBlueInventory.Visible = false;
            this.potionBlueInventory.Click += new System.EventHandler(this.potionBlueInventory_Click);
            // 
            // statsWindow
            // 
            this.statsWindow.BackColor = System.Drawing.Color.Lavender;
            this.statsWindow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.statsWindow.ColumnCount = 2;
            this.statsWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.22222F));
            this.statsWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.77778F));
            this.statsWindow.Controls.Add(this.playerHealth, 1, 0);
            this.statsWindow.Controls.Add(this.batHealth, 1, 1);
            this.statsWindow.Controls.Add(this.ghostHealth, 1, 2);
            this.statsWindow.Controls.Add(this.ghoulHealth, 1, 3);
            this.statsWindow.Controls.Add(this.label1, 0, 0);
            this.statsWindow.Controls.Add(this.label2, 0, 1);
            this.statsWindow.Controls.Add(this.label3, 0, 2);
            this.statsWindow.Controls.Add(this.label4, 0, 3);
            this.statsWindow.Location = new System.Drawing.Point(458, 218);
            this.statsWindow.Margin = new System.Windows.Forms.Padding(2);
            this.statsWindow.Name = "statsWindow";
            this.statsWindow.RowCount = 4;
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.statsWindow.Size = new System.Drawing.Size(135, 104);
            this.statsWindow.TabIndex = 16;
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.Location = new System.Drawing.Point(48, 3);
            this.playerHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(66, 13);
            this.playerHealth.TabIndex = 4;
            this.playerHealth.Text = "playerHealth";
            // 
            // batHealth
            // 
            this.batHealth.AutoSize = true;
            this.batHealth.Location = new System.Drawing.Point(48, 28);
            this.batHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batHealth.Name = "batHealth";
            this.batHealth.Size = new System.Drawing.Size(53, 13);
            this.batHealth.TabIndex = 5;
            this.batHealth.Text = "batHealth";
            // 
            // ghostHealth
            // 
            this.ghostHealth.AutoSize = true;
            this.ghostHealth.Location = new System.Drawing.Point(48, 53);
            this.ghostHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ghostHealth.Name = "ghostHealth";
            this.ghostHealth.Size = new System.Drawing.Size(64, 13);
            this.ghostHealth.TabIndex = 6;
            this.ghostHealth.Text = "ghostHealth";
            // 
            // ghoulHealth
            // 
            this.ghoulHealth.AutoSize = true;
            this.ghoulHealth.Location = new System.Drawing.Point(48, 78);
            this.ghoulHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ghoulHealth.Name = "ghoulHealth";
            this.ghoulHealth.Size = new System.Drawing.Size(64, 13);
            this.ghoulHealth.TabIndex = 7;
            this.ghoulHealth.Text = "ghoulHealth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.BackColor = System.Drawing.Color.Lavender;
            this.MoveLabel.Location = new System.Drawing.Point(455, 7);
            this.MoveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(37, 13);
            this.MoveLabel.TabIndex = 17;
            this.MoveLabel.Text = "Move:";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.BackColor = System.Drawing.Color.Lavender;
            this.AttackLabel.Location = new System.Drawing.Point(454, 113);
            this.AttackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(41, 13);
            this.AttackLabel.TabIndex = 18;
            this.AttackLabel.Text = "Attack:";
            // 
            // mUp
            // 
            this.mUp.Location = new System.Drawing.Point(497, 33);
            this.mUp.Margin = new System.Windows.Forms.Padding(2);
            this.mUp.Name = "mUp";
            this.mUp.Size = new System.Drawing.Size(56, 19);
            this.mUp.TabIndex = 19;
            this.mUp.Text = "Up";
            this.mUp.UseVisualStyleBackColor = true;
            this.mUp.Click += new System.EventHandler(this.mUp_Click);
            // 
            // mLeft
            // 
            this.mLeft.Location = new System.Drawing.Point(458, 57);
            this.mLeft.Margin = new System.Windows.Forms.Padding(2);
            this.mLeft.Name = "mLeft";
            this.mLeft.Size = new System.Drawing.Size(56, 19);
            this.mLeft.TabIndex = 20;
            this.mLeft.Text = "Left";
            this.mLeft.UseVisualStyleBackColor = true;
            this.mLeft.Click += new System.EventHandler(this.mLeft_Click);
            // 
            // mRight
            // 
            this.mRight.Location = new System.Drawing.Point(536, 57);
            this.mRight.Margin = new System.Windows.Forms.Padding(2);
            this.mRight.Name = "mRight";
            this.mRight.Size = new System.Drawing.Size(56, 19);
            this.mRight.TabIndex = 21;
            this.mRight.Text = "Right";
            this.mRight.UseVisualStyleBackColor = true;
            this.mRight.Click += new System.EventHandler(this.mRight_Click);
            // 
            // mDown
            // 
            this.mDown.Location = new System.Drawing.Point(497, 80);
            this.mDown.Margin = new System.Windows.Forms.Padding(2);
            this.mDown.Name = "mDown";
            this.mDown.Size = new System.Drawing.Size(56, 19);
            this.mDown.TabIndex = 22;
            this.mDown.Text = "Down";
            this.mDown.UseVisualStyleBackColor = true;
            this.mDown.Click += new System.EventHandler(this.mDown_Click);
            // 
            // aDown
            // 
            this.aDown.Location = new System.Drawing.Point(497, 179);
            this.aDown.Margin = new System.Windows.Forms.Padding(2);
            this.aDown.Name = "aDown";
            this.aDown.Size = new System.Drawing.Size(56, 19);
            this.aDown.TabIndex = 26;
            this.aDown.Text = "Down";
            this.aDown.UseVisualStyleBackColor = true;
            this.aDown.Click += new System.EventHandler(this.aDown_Click);
            // 
            // aRight
            // 
            this.aRight.Location = new System.Drawing.Point(536, 155);
            this.aRight.Margin = new System.Windows.Forms.Padding(2);
            this.aRight.Name = "aRight";
            this.aRight.Size = new System.Drawing.Size(56, 19);
            this.aRight.TabIndex = 25;
            this.aRight.Text = "Right";
            this.aRight.UseVisualStyleBackColor = true;
            this.aRight.Click += new System.EventHandler(this.aRight_Click);
            // 
            // aLeft
            // 
            this.aLeft.Location = new System.Drawing.Point(458, 155);
            this.aLeft.Margin = new System.Windows.Forms.Padding(2);
            this.aLeft.Name = "aLeft";
            this.aLeft.Size = new System.Drawing.Size(56, 19);
            this.aLeft.TabIndex = 24;
            this.aLeft.Text = "Left";
            this.aLeft.UseVisualStyleBackColor = true;
            this.aLeft.Click += new System.EventHandler(this.aLeft_Click);
            // 
            // aUp
            // 
            this.aUp.Location = new System.Drawing.Point(497, 132);
            this.aUp.Margin = new System.Windows.Forms.Padding(2);
            this.aUp.Name = "aUp";
            this.aUp.Size = new System.Drawing.Size(56, 19);
            this.aUp.TabIndex = 23;
            this.aUp.Text = "Up";
            this.aUp.UseVisualStyleBackColor = true;
            this.aUp.Click += new System.EventHandler(this.aUp_Click);
            // 
            // DungeonExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(599, 324);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.aDown);
            this.Controls.Add(this.aRight);
            this.Controls.Add(this.aLeft);
            this.Controls.Add(this.aUp);
            this.Controls.Add(this.mDown);
            this.Controls.Add(this.mRight);
            this.Controls.Add(this.mLeft);
            this.Controls.Add(this.mUp);
            this.Controls.Add(this.AttackLabel);
            this.Controls.Add(this.MoveLabel);
            this.Controls.Add(this.statsWindow);
            this.Controls.Add(this.potionBlueInventory);
            this.Controls.Add(this.potionRedInventory);
            this.Controls.Add(this.maceInventory);
            this.Controls.Add(this.battleAxeInventory);
            this.Controls.Add(this.swordInventory);
            this.Controls.Add(this.controlContainer);
            this.Controls.Add(this.swordImage);
            this.Controls.Add(this.maceImage);
            this.Controls.Add(this.battleAxeImage);
            this.Controls.Add(this.potionRedImage);
            this.Controls.Add(this.potionBlueImage);
            this.Controls.Add(this.batImage);
            this.Controls.Add(this.ghostImage);
            this.Controls.Add(this.ghoulImage);
            this.Controls.Add(this.dungeon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DungeonExplorer";
            this.Text = "Dungeon Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dungeon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleAxeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleAxeInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueInventory)).EndInit();
            this.statsWindow.ResumeLayout(false);
            this.statsWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dungeon;
        private System.Windows.Forms.PictureBox swordImage;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox potionBlueImage;
        private System.Windows.Forms.PictureBox potionRedImage;
        private System.Windows.Forms.PictureBox battleAxeImage;
        private System.Windows.Forms.PictureBox maceImage;
        private System.Windows.Forms.PictureBox ghostImage;
        private System.Windows.Forms.PictureBox batImage;
        private System.Windows.Forms.PictureBox ghoulImage;
        private System.Windows.Forms.PictureBox controlContainer;
        private System.Windows.Forms.PictureBox swordInventory;
        private System.Windows.Forms.PictureBox battleAxeInventory;
        private System.Windows.Forms.PictureBox maceInventory;
        private System.Windows.Forms.PictureBox potionRedInventory;
        private System.Windows.Forms.PictureBox potionBlueInventory;
        private System.Windows.Forms.TableLayoutPanel statsWindow;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Button mUp;
        private System.Windows.Forms.Button mLeft;
        private System.Windows.Forms.Button mRight;
        private System.Windows.Forms.Button mDown;
        private System.Windows.Forms.Button aDown;
        private System.Windows.Forms.Button aRight;
        private System.Windows.Forms.Button aLeft;
        private System.Windows.Forms.Button aUp;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.Label batHealth;
        private System.Windows.Forms.Label ghostHealth;
        private System.Windows.Forms.Label ghoulHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

