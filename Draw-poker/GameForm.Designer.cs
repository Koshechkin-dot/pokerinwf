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
            PlayerCash = new Label();
            PlayerName = new Label();
            BotCash = new Label();
            ReplaceB = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            PlayerCard1 = new PictureBox();
            PlayerCard2 = new PictureBox();
            PlayerCard3 = new PictureBox();
            PlayerCard4 = new PictureBox();
            PlayerCard5 = new PictureBox();
            BotCard5 = new PictureBox();
            BotCard4 = new PictureBox();
            BotCard3 = new PictureBox();
            BotCard2 = new PictureBox();
            BotCard1 = new PictureBox();
            NextRound = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotCard1).BeginInit();
            SuspendLayout();
            // 
            // FoldB
            // 
            FoldB.Location = new Point(11, 69);
            FoldB.Name = "FoldB";
            FoldB.Size = new Size(75, 23);
            FoldB.TabIndex = 0;
            FoldB.Text = "Fold";
            FoldB.UseVisualStyleBackColor = true;
            FoldB.Click += FoldB_Click;
            // 
            // CallB
            // 
            CallB.Location = new Point(11, 40);
            CallB.Name = "CallB";
            CallB.Size = new Size(75, 23);
            CallB.TabIndex = 1;
            CallB.Text = "Call";
            CallB.UseVisualStyleBackColor = true;
            CallB.Click += CallB_Click;
            // 
            // RaiseB
            // 
            RaiseB.Location = new Point(11, 11);
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
            BotName.Location = new Point(172, 301);
            BotName.Name = "BotName";
            BotName.Size = new Size(25, 15);
            BotName.TabIndex = 3;
            BotName.Text = "Bot";
            // 
            // BotBet
            // 
            BotBet.AutoSize = true;
            BotBet.Location = new Point(261, 301);
            BotBet.Name = "BotBet";
            BotBet.Size = new Size(38, 15);
            BotBet.TabIndex = 15;
            BotBet.Text = "label9";
            // 
            // PlayerBet
            // 
            PlayerBet.AutoSize = true;
            PlayerBet.Location = new Point(261, 12);
            PlayerBet.Name = "PlayerBet";
            PlayerBet.Size = new Size(44, 15);
            PlayerBet.TabIndex = 18;
            PlayerBet.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(532, 217);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 19;
            label13.Text = "Bank";
            // 
            // Bank
            // 
            Bank.AutoSize = true;
            Bank.Location = new Point(571, 217);
            Bank.Name = "Bank";
            Bank.Size = new Size(13, 15);
            Bank.TabIndex = 20;
            Bank.Text = "0";
            // 
            // RaiseValue
            // 
            RaiseValue.Location = new Point(92, 12);
            RaiseValue.Name = "RaiseValue";
            RaiseValue.Size = new Size(74, 23);
            RaiseValue.TabIndex = 21;
            // 
            // PlayerCash
            // 
            PlayerCash.AutoSize = true;
            PlayerCash.Location = new Point(217, 12);
            PlayerCash.Name = "PlayerCash";
            PlayerCash.Size = new Size(38, 15);
            PlayerCash.TabIndex = 14;
            PlayerCash.Text = "label8";
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Location = new Point(172, 12);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(39, 15);
            PlayerName.TabIndex = 9;
            PlayerName.Text = "Player";
            // 
            // BotCash
            // 
            BotCash.AutoSize = true;
            BotCash.Location = new Point(217, 301);
            BotCash.Name = "BotCash";
            BotCash.Size = new Size(38, 15);
            BotCash.TabIndex = 27;
            BotCash.Text = "label9";
            // 
            // ReplaceB
            // 
            ReplaceB.Enabled = false;
            ReplaceB.Location = new Point(234, 142);
            ReplaceB.Name = "ReplaceB";
            ReplaceB.Size = new Size(75, 23);
            ReplaceB.TabIndex = 33;
            ReplaceB.Text = "Replace";
            ReplaceB.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlDark;
            checkBox1.Location = new Point(315, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 36;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ControlDark;
            checkBox2.Location = new Point(417, 126);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 37;
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ControlDark;
            checkBox3.Location = new Point(519, 126);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 38;
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.ControlDark;
            checkBox4.Location = new Point(621, 126);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 39;
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = SystemColors.ControlDark;
            checkBox5.Location = new Point(723, 126);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(15, 14);
            checkBox5.TabIndex = 40;
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // PlayerCard1
            // 
            PlayerCard1.Location = new Point(315, 12);
            PlayerCard1.Name = "PlayerCard1";
            PlayerCard1.Size = new Size(96, 128);
            PlayerCard1.TabIndex = 41;
            PlayerCard1.TabStop = false;
            // 
            // PlayerCard2
            // 
            PlayerCard2.Location = new Point(417, 12);
            PlayerCard2.Name = "PlayerCard2";
            PlayerCard2.Size = new Size(96, 128);
            PlayerCard2.TabIndex = 42;
            PlayerCard2.TabStop = false;
            // 
            // PlayerCard3
            // 
            PlayerCard3.Location = new Point(519, 12);
            PlayerCard3.Name = "PlayerCard3";
            PlayerCard3.Size = new Size(96, 128);
            PlayerCard3.TabIndex = 43;
            PlayerCard3.TabStop = false;
            // 
            // PlayerCard4
            // 
            PlayerCard4.Location = new Point(621, 12);
            PlayerCard4.Name = "PlayerCard4";
            PlayerCard4.Size = new Size(96, 128);
            PlayerCard4.TabIndex = 44;
            PlayerCard4.TabStop = false;
            // 
            // PlayerCard5
            // 
            PlayerCard5.Location = new Point(723, 12);
            PlayerCard5.Name = "PlayerCard5";
            PlayerCard5.Size = new Size(96, 128);
            PlayerCard5.TabIndex = 45;
            PlayerCard5.TabStop = false;
            // 
            // BotCard5
            // 
            BotCard5.Location = new Point(723, 301);
            BotCard5.Name = "BotCard5";
            BotCard5.Size = new Size(96, 128);
            BotCard5.TabIndex = 50;
            BotCard5.TabStop = false;
            // 
            // BotCard4
            // 
            BotCard4.Location = new Point(621, 301);
            BotCard4.Name = "BotCard4";
            BotCard4.Size = new Size(96, 128);
            BotCard4.TabIndex = 49;
            BotCard4.TabStop = false;
            // 
            // BotCard3
            // 
            BotCard3.Location = new Point(519, 301);
            BotCard3.Name = "BotCard3";
            BotCard3.Size = new Size(96, 128);
            BotCard3.TabIndex = 48;
            BotCard3.TabStop = false;
            // 
            // BotCard2
            // 
            BotCard2.Location = new Point(417, 301);
            BotCard2.Name = "BotCard2";
            BotCard2.Size = new Size(96, 128);
            BotCard2.TabIndex = 47;
            BotCard2.TabStop = false;
            // 
            // BotCard1
            // 
            BotCard1.Location = new Point(315, 301);
            BotCard1.Name = "BotCard1";
            BotCard1.Size = new Size(96, 128);
            BotCard1.TabIndex = 46;
            BotCard1.TabStop = false;
            // 
            // NextRound
            // 
            NextRound.Enabled = false;
            NextRound.Location = new Point(11, 209);
            NextRound.Name = "NextRound";
            NextRound.Size = new Size(75, 23);
            NextRound.TabIndex = 51;
            NextRound.Text = "NextRound";
            NextRound.UseVisualStyleBackColor = true;
            NextRound.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(858, 441);
            Controls.Add(NextRound);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(BotCard5);
            Controls.Add(BotCard4);
            Controls.Add(BotCard3);
            Controls.Add(BotCard2);
            Controls.Add(BotCard1);
            Controls.Add(PlayerCard5);
            Controls.Add(PlayerCard4);
            Controls.Add(PlayerCard3);
            Controls.Add(PlayerCard2);
            Controls.Add(PlayerCard1);
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
            ((System.ComponentModel.ISupportInitialize)PlayerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotCard1).EndInit();
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
        private Label PlayerCash;
        private Label PlayerName;
        private Label BotCash;
        private Button ReplaceB;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private PictureBox PlayerCard1;
        private PictureBox PlayerCard2;
        private PictureBox PlayerCard3;
        private PictureBox PlayerCard4;
        private PictureBox PlayerCard5;
        private PictureBox BotCard5;
        private PictureBox BotCard4;
        private PictureBox BotCard3;
        private PictureBox BotCard2;
        private PictureBox BotCard1;
        private Button NextRound;
    }
}
