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
            Player1 = new Label();
            Player2 = new Label();
            Player3 = new Label();
            Cash0 = new Label();
            Cash1 = new Label();
            Cash2 = new Label();
            Cash3 = new Label();
            Bet0 = new Label();
            Bet1 = new Label();
            Bet2 = new Label();
            Bet3 = new Label();
            label13 = new Label();
            Bank = new Label();
            RaiseValue = new TextBox();
            playerHand = new ImageList(components);
            Card0 = new CheckBox();
            Card1 = new CheckBox();
            Card2 = new CheckBox();
            Card3 = new CheckBox();
            Card4 = new CheckBox();
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
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Location = new Point(12, 24);
            Player1.Name = "Player1";
            Player1.Size = new Size(39, 15);
            Player1.TabIndex = 5;
            Player1.Text = "Player";
            // 
            // Player2
            // 
            Player2.AutoSize = true;
            Player2.Location = new Point(12, 39);
            Player2.Name = "Player2";
            Player2.Size = new Size(39, 15);
            Player2.TabIndex = 7;
            Player2.Text = "Player";
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
            // Cash0
            // 
            Cash0.AutoSize = true;
            Cash0.Location = new Point(57, 9);
            Cash0.Name = "Cash0";
            Cash0.Size = new Size(38, 15);
            Cash0.TabIndex = 11;
            Cash0.Text = "label5";
            // 
            // Cash1
            // 
            Cash1.AutoSize = true;
            Cash1.Location = new Point(57, 24);
            Cash1.Name = "Cash1";
            Cash1.Size = new Size(38, 15);
            Cash1.TabIndex = 12;
            Cash1.Text = "label6";
            // 
            // Cash2
            // 
            Cash2.AutoSize = true;
            Cash2.Location = new Point(57, 39);
            Cash2.Name = "Cash2";
            Cash2.Size = new Size(38, 15);
            Cash2.TabIndex = 13;
            Cash2.Text = "label7";
            // 
            // Cash3
            // 
            Cash3.AutoSize = true;
            Cash3.Location = new Point(57, 54);
            Cash3.Name = "Cash3";
            Cash3.Size = new Size(38, 15);
            Cash3.TabIndex = 14;
            Cash3.Text = "label8";
            // 
            // Bet0
            // 
            Bet0.AutoSize = true;
            Bet0.Location = new Point(101, 9);
            Bet0.Name = "Bet0";
            Bet0.Size = new Size(38, 15);
            Bet0.TabIndex = 15;
            Bet0.Text = "label9";
            // 
            // Bet1
            // 
            Bet1.AutoSize = true;
            Bet1.Location = new Point(101, 24);
            Bet1.Name = "Bet1";
            Bet1.Size = new Size(44, 15);
            Bet1.TabIndex = 16;
            Bet1.Text = "label10";
            // 
            // Bet2
            // 
            Bet2.AutoSize = true;
            Bet2.Location = new Point(101, 39);
            Bet2.Name = "Bet2";
            Bet2.Size = new Size(44, 15);
            Bet2.TabIndex = 17;
            Bet2.Text = "label11";
            // 
            // Bet3
            // 
            Bet3.AutoSize = true;
            Bet3.Location = new Point(101, 54);
            Bet3.Name = "Bet3";
            Bet3.Size = new Size(44, 15);
            Bet3.TabIndex = 18;
            Bet3.Text = "label12";
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
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 561);
            Controls.Add(Card4);
            Controls.Add(Card3);
            Controls.Add(Card2);
            Controls.Add(Card1);
            Controls.Add(Card0);
            Controls.Add(RaiseValue);
            Controls.Add(Bank);
            Controls.Add(label13);
            Controls.Add(Bet3);
            Controls.Add(Bet2);
            Controls.Add(Bet1);
            Controls.Add(Bet0);
            Controls.Add(Cash3);
            Controls.Add(Cash2);
            Controls.Add(Cash1);
            Controls.Add(Cash0);
            Controls.Add(Player3);
            Controls.Add(Player2);
            Controls.Add(Player1);
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
        private Label Player3;
        private Label Cash0;
        private Label Cash1;
        private Label Cash2;
        private Label Cash3;
        private Label Bet0;
        private Label Bet1;
        private Label Bet2;
        private Label Bet3;
        private Label label13;
        private Label Bank;
        private TextBox RaiseValue;
        public ImageList playerHand;
        private CheckBox Card0;
        private CheckBox Card1;
        private CheckBox Card2;
        private CheckBox Card3;
        private CheckBox Card4;
    }
}
