namespace Draw_poker
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            FoldB = new Button();
            CallB = new Button();
            RaiseB = new Button();
            Player0 = new Label();
            BotBet = new Label();
            PlayerBet = new Label();
            label13 = new Label();
            Bank = new Label();
            RaiseValue = new TextBox();
            playerHand = new ImageList(components);
            Card0 = new CheckBox();
            Card1 = new CheckBox();
            Card2 = new CheckBox();
            Card3 = new CheckBox();
            Card4 = new CheckBox();
            PlayerCash = new Label();
            Player3 = new Label();
            BotCash = new Label();
            SuspendLayout();
            // 
            // FoldB
            // 
            FoldB.Location = new Point(12, 526);
            FoldB.Name = "FoldB";
            FoldB.Size = new Size(75, 23);
            FoldB.TabIndex = 0;
            FoldB.Text = "Fold";
            FoldB.UseVisualStyleBackColor = true;
            FoldB.Click += FoldB_Click;
            // 
            // CallB
            // 
            CallB.Location = new Point(93, 526);
            CallB.Name = "CallB";
            CallB.Size = new Size(75, 23);
            CallB.TabIndex = 1;
            CallB.Text = "Call";
            CallB.UseVisualStyleBackColor = true;
            CallB.Click += CallB_Click;
            // 
            // RaiseB
            // 
            RaiseB.Location = new Point(174, 526);
            RaiseB.Name = "RaiseB";
            RaiseB.Size = new Size(75, 23);
            RaiseB.TabIndex = 2;
            RaiseB.Text = "Raise";
            RaiseB.UseVisualStyleBackColor = true;
            RaiseB.Click += RaiseB_Click;
            // 
            // Player0
            // 
            Player0.AutoSize = true;
            Player0.Location = new Point(12, 9);
            Player0.Name = "Player0";
            Player0.Size = new Size(39, 15);
            Player0.TabIndex = 3;
            Player0.Text = "Player";
            // 
            // BotBet
            // 
            BotBet.AutoSize = true;
            BotBet.Location = new Point(101, 9);
            BotBet.Name = "BotBet";
            BotBet.Size = new Size(38, 15);
            BotBet.TabIndex = 15;
            BotBet.Text = "label9";
            // 
            // PlayerBet
            // 
            PlayerBet.AutoSize = true;
            PlayerBet.Location = new Point(101, 54);
            PlayerBet.Name = "PlayerBet";
            PlayerBet.Size = new Size(44, 15);
            PlayerBet.TabIndex = 18;
            PlayerBet.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 508);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 19;
            label13.Text = "Bank";
            // 
            // Bank
            // 
            Bank.AutoSize = true;
            Bank.Location = new Point(51, 508);
            Bank.Name = "Bank";
            Bank.Size = new Size(44, 15);
            Bank.TabIndex = 20;
            Bank.Text = "label14";
            // 
            // RaiseValue
            // 
            RaiseValue.Location = new Point(255, 527);
            RaiseValue.Name = "RaiseValue";
            RaiseValue.Size = new Size(74, 23);
            RaiseValue.TabIndex = 21;
            // 
            // playerHand
            // 
            playerHand.ColorDepth = ColorDepth.Depth32Bit;
            playerHand.ImageStream = (ImageListStreamer)resources.GetObject("playerHand.ImageStream");
            playerHand.TransparentColor = Color.Transparent;
            playerHand.Images.SetKeyName(0, "2_of_clubs.png");
            playerHand.Images.SetKeyName(1, "4_of_diamonds.png");
            playerHand.Images.SetKeyName(2, "king_of_clubs2.png");
            playerHand.Images.SetKeyName(3, "ace_of_spades.png");
            playerHand.Images.SetKeyName(4, "10_of_spades.png");
            // 
            // Card0
            // 
            Card0.AutoSize = true;
            Card0.Enabled = false;
            Card0.ImageIndex = 0;
            Card0.ImageList = playerHand;
            Card0.Location = new Point(692, 12);
            Card0.Name = "Card0";
            Card0.Size = new Size(80, 94);
            Card0.TabIndex = 22;
            Card0.UseVisualStyleBackColor = true;
            // 
            // Card1
            // 
            Card1.AutoSize = true;
            Card1.Enabled = false;
            Card1.ImageIndex = 2;
            Card1.ImageList = playerHand;
            Card1.Location = new Point(692, 118);
            Card1.Name = "Card1";
            Card1.Size = new Size(80, 94);
            Card1.TabIndex = 23;
            Card1.UseVisualStyleBackColor = true;
            // 
            // Card2
            // 
            Card2.AutoSize = true;
            Card2.Enabled = false;
            Card2.ImageIndex = 4;
            Card2.ImageList = playerHand;
            Card2.Location = new Point(692, 318);
            Card2.Name = "Card2";
            Card2.Size = new Size(80, 94);
            Card2.TabIndex = 24;
            Card2.UseVisualStyleBackColor = true;
            // 
            // Card3
            // 
            Card3.AutoSize = true;
            Card3.Enabled = false;
            Card3.ImageIndex = 1;
            Card3.ImageList = playerHand;
            Card3.Location = new Point(692, 218);
            Card3.Name = "Card3";
            Card3.Size = new Size(80, 94);
            Card3.TabIndex = 25;
            Card3.UseVisualStyleBackColor = true;
            // 
            // Card4
            // 
            Card4.AutoSize = true;
            Card4.Enabled = false;
            Card4.ImageIndex = 3;
            Card4.ImageList = playerHand;
            Card4.Location = new Point(692, 418);
            Card4.Name = "Card4";
            Card4.Size = new Size(80, 94);
            Card4.TabIndex = 26;
            Card4.UseVisualStyleBackColor = true;
            // 
            // PlayerCash
            // 
            PlayerCash.AutoSize = true;
            PlayerCash.Location = new Point(57, 54);
            PlayerCash.Name = "PlayerCash";
            PlayerCash.Size = new Size(38, 15);
            PlayerCash.TabIndex = 14;
            PlayerCash.Text = "label8";
            // 
            // Player3
            // 
            Player3.AutoSize = true;
            Player3.Location = new Point(12, 54);
            Player3.Name = "Player3";
            Player3.Size = new Size(39, 15);
            Player3.TabIndex = 9;
            Player3.Text = "Player";
            // 
            // BotCash
            // 
            BotCash.AutoSize = true;
            BotCash.Location = new Point(57, 9);
            BotCash.Name = "BotCash";
            BotCash.Size = new Size(38, 15);
            BotCash.TabIndex = 27;
            BotCash.Text = "label9";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 561);
            Controls.Add(BotCash);
            Controls.Add(Card4);
            Controls.Add(Card3);
            Controls.Add(Card2);
            Controls.Add(Card1);
            Controls.Add(Card0);
            Controls.Add(RaiseValue);
            Controls.Add(Bank);
            Controls.Add(label13);
            Controls.Add(PlayerBet);
            Controls.Add(BotBet);
            Controls.Add(PlayerCash);
            Controls.Add(Player3);
            Controls.Add(Player0);
            Controls.Add(RaiseB);
            Controls.Add(CallB);
            Controls.Add(FoldB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(640, 480);
            Name = "Form";
            Text = "Draw Poker";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FoldB;
        private Button CallB;
        private Button RaiseB;
        private Label Player0;
        private Label Player1;
        private Label Player2;
        private Label Cash0;
        private Label Cash1;
        private Label Cash2;
        private Label Cash3;
        private Label BotBet;
        private Label Bet1;
        private Label Bet2;
        private Label PlayerBet;
        private Label label13;
        private Label Bank;
        private TextBox RaiseValue;
        public ImageList playerHand;
        private CheckBox Card0;
        private CheckBox Card1;
        private CheckBox Card2;
        private CheckBox Card3;
        private CheckBox Card4;
        private Label PlayerCash;
        private Label Player3;
        private Label BotCash;
    }
}
