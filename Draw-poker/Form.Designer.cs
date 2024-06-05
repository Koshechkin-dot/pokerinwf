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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            FoldB = new Button();
            CallB = new Button();
            RaiseB = new Button();
            Player0 = new Label();
            Cards0 = new ListView();
            Cards1 = new ListView();
            Player1 = new Label();
            Cards2 = new ListView();
            Player2 = new Label();
            Cards3 = new ListView();
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
            SuspendLayout();
            // 
            // FoldB
            // 
            FoldB.Location = new Point(12, 406);
            FoldB.Name = "FoldB";
            FoldB.Size = new Size(75, 23);
            FoldB.TabIndex = 0;
            FoldB.Text = "Fold";
            FoldB.UseVisualStyleBackColor = true;
            FoldB.Click += FoldB_Click;
            // 
            // CallB
            // 
            CallB.Location = new Point(93, 406);
            CallB.Name = "CallB";
            CallB.Size = new Size(75, 23);
            CallB.TabIndex = 1;
            CallB.Text = "Call";
            CallB.UseVisualStyleBackColor = true;
            CallB.Click += CallB_Click;
            // 
            // RaiseB
            // 
            RaiseB.Location = new Point(174, 406);
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
            // Cards0
            // 
            Cards0.Location = new Point(12, 27);
            Cards0.Name = "Cards0";
            Cards0.Size = new Size(237, 53);
            Cards0.TabIndex = 4;
            Cards0.UseCompatibleStateImageBehavior = false;
            // 
            // Cards1
            // 
            Cards1.Location = new Point(12, 101);
            Cards1.Name = "Cards1";
            Cards1.Size = new Size(237, 53);
            Cards1.TabIndex = 6;
            Cards1.UseCompatibleStateImageBehavior = false;
            // 
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Location = new Point(12, 83);
            Player1.Name = "Player1";
            Player1.Size = new Size(39, 15);
            Player1.TabIndex = 5;
            Player1.Text = "Player";
            // 
            // Cards2
            // 
            Cards2.Location = new Point(12, 175);
            Cards2.Name = "Cards2";
            Cards2.Size = new Size(237, 53);
            Cards2.TabIndex = 8;
            Cards2.UseCompatibleStateImageBehavior = false;
            // 
            // Player2
            // 
            Player2.AutoSize = true;
            Player2.Location = new Point(12, 157);
            Player2.Name = "Player2";
            Player2.Size = new Size(39, 15);
            Player2.TabIndex = 7;
            Player2.Text = "Player";
            // 
            // Cards3
            // 
            Cards3.Location = new Point(12, 249);
            Cards3.Name = "Cards3";
            Cards3.Size = new Size(237, 53);
            Cards3.TabIndex = 10;
            Cards3.UseCompatibleStateImageBehavior = false;
            // 
            // Player3
            // 
            Player3.AutoSize = true;
            Player3.Location = new Point(12, 231);
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
            Cash1.Location = new Point(57, 83);
            Cash1.Name = "Cash1";
            Cash1.Size = new Size(38, 15);
            Cash1.TabIndex = 12;
            Cash1.Text = "label6";
            // 
            // Cash2
            // 
            Cash2.AutoSize = true;
            Cash2.Location = new Point(57, 157);
            Cash2.Name = "Cash2";
            Cash2.Size = new Size(38, 15);
            Cash2.TabIndex = 13;
            Cash2.Text = "label7";
            // 
            // Cash3
            // 
            Cash3.AutoSize = true;
            Cash3.Location = new Point(57, 231);
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
            Bet1.Location = new Point(101, 83);
            Bet1.Name = "Bet1";
            Bet1.Size = new Size(44, 15);
            Bet1.TabIndex = 16;
            Bet1.Text = "label10";
            // 
            // Bet2
            // 
            Bet2.AutoSize = true;
            Bet2.Location = new Point(101, 157);
            Bet2.Name = "Bet2";
            Bet2.Size = new Size(44, 15);
            Bet2.TabIndex = 17;
            Bet2.Text = "label11";
            // 
            // Bet3
            // 
            Bet3.AutoSize = true;
            Bet3.Location = new Point(101, 231);
            Bet3.Name = "Bet3";
            Bet3.Size = new Size(44, 15);
            Bet3.TabIndex = 18;
            Bet3.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 305);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 19;
            label13.Text = "Bank";
            // 
            // Bank
            // 
            Bank.AutoSize = true;
            Bank.Location = new Point(51, 305);
            Bank.Name = "Bank";
            Bank.Size = new Size(44, 15);
            Bank.TabIndex = 20;
            Bank.Text = "label14";
            // 
            // RaiseValue
            // 
            RaiseValue.Location = new Point(255, 407);
            RaiseValue.Name = "RaiseValue";
            RaiseValue.Size = new Size(74, 23);
            RaiseValue.TabIndex = 21;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(624, 441);
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
            Controls.Add(Cards3);
            Controls.Add(Player3);
            Controls.Add(Cards2);
            Controls.Add(Player2);
            Controls.Add(Cards1);
            Controls.Add(Player1);
            Controls.Add(Cards0);
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
        private ListView Cards0;
        private ListView Cards1;
        private Label Player1;
        private ListView Cards2;
        private Label Player2;
        private ListView Cards3;
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
    }
}
