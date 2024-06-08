namespace Draw_poker
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            FoldB = new Button();
            CallB = new Button();
            RaiseB = new Button();
            BotName = new Label();
            BotBet = new Label();
            PlayerBet = new Label();
            label13 = new Label();
            Bank = new Label();
            RaiseValue = new TextBox();
            playerHand = new ImageList(components);
            PlayerCash = new Label();
            PlayerName = new Label();
            BotCash = new Label();
            ReplaceB = new Button();
            PlayerCheckBox = new CheckedListBox();
            BotCheckBox = new CheckedListBox();
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
            // BotName
            // 
            BotName.AutoSize = true;
            BotName.Location = new Point(12, 9);
            BotName.Name = "BotName";
            BotName.Size = new Size(25, 15);
            BotName.TabIndex = 3;
            BotName.Text = "Bot";
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
            // PlayerCash
            // 
            PlayerCash.AutoSize = true;
            PlayerCash.Location = new Point(57, 54);
            PlayerCash.Name = "PlayerCash";
            PlayerCash.Size = new Size(38, 15);
            PlayerCash.TabIndex = 14;
            PlayerCash.Text = "label8";
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Location = new Point(12, 54);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(39, 15);
            PlayerName.TabIndex = 9;
            PlayerName.Text = "Player";
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
            // ReplaceB
            // 
            ReplaceB.Enabled = false;
            ReplaceB.Location = new Point(12, 262);
            ReplaceB.Name = "ReplaceB";
            ReplaceB.Size = new Size(75, 23);
            ReplaceB.TabIndex = 33;
            ReplaceB.Text = "Replace";
            ReplaceB.UseVisualStyleBackColor = true;
            // 
            // PlayerCheckBox
            // 
            PlayerCheckBox.FormattingEnabled = true;
            PlayerCheckBox.Location = new Point(12, 162);
            PlayerCheckBox.Name = "PlayerCheckBox";
            PlayerCheckBox.Size = new Size(120, 94);
            PlayerCheckBox.TabIndex = 34;
            // 
            // BotCheckBox
            // 
            BotCheckBox.FormattingEnabled = true;
            BotCheckBox.Location = new Point(174, 162);
            BotCheckBox.Name = "BotCheckBox";
            BotCheckBox.SelectionMode = SelectionMode.None;
            BotCheckBox.Size = new Size(120, 94);
            BotCheckBox.TabIndex = 35;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 561);
            Controls.Add(BotCheckBox);
            Controls.Add(PlayerCheckBox);
            Controls.Add(ReplaceB);
            Controls.Add(BotCash);
            Controls.Add(RaiseValue);
            Controls.Add(Bank);
            Controls.Add(label13);
            Controls.Add(PlayerBet);
            Controls.Add(BotBet);
            Controls.Add(PlayerCash);
            Controls.Add(PlayerName);
            Controls.Add(BotName);
            Controls.Add(RaiseB);
            Controls.Add(CallB);
            Controls.Add(FoldB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(640, 480);
            Name = "GameForm";
            Text = "Draw Poker";
            FormClosed += GameForm_FormClosed;
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FoldB;
        private Button CallB;
        private Button RaiseB;
        private Label BotName;
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
        private Label PlayerCash;
        private Label PlayerName;
        private Label BotCash;
        private Button ReplaceB;
        private CheckedListBox PlayerCheckBox;
        private CheckedListBox BotCheckBox;
    }
}
