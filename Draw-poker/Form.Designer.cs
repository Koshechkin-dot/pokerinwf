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
            BotLabel = new Label();
            PlayerLabel = new Label();
            PlayerCards = new ListView();
            BotCards = new ListView();
            Compare = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // BotLabel
            // 
            BotLabel.AutoSize = true;
            BotLabel.Location = new Point(12, 9);
            BotLabel.Name = "BotLabel";
            BotLabel.Size = new Size(25, 15);
            BotLabel.TabIndex = 0;
            BotLabel.Text = "Bot";
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Location = new Point(317, 9);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(39, 15);
            PlayerLabel.TabIndex = 2;
            PlayerLabel.Text = "Player";
            // 
            // PlayerCards
            // 
            PlayerCards.Location = new Point(317, 27);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.Size = new Size(299, 97);
            PlayerCards.TabIndex = 3;
            PlayerCards.UseCompatibleStateImageBehavior = false;
            PlayerCards.View = View.List;
            // 
            // BotCards
            // 
            BotCards.Location = new Point(12, 27);
            BotCards.Name = "BotCards";
            BotCards.Size = new Size(299, 97);
            BotCards.TabIndex = 4;
            BotCards.UseCompatibleStateImageBehavior = false;
            BotCards.View = View.List;
            // 
            // Compare
            // 
            Compare.Location = new Point(12, 130);
            Compare.Name = "Compare";
            Compare.Size = new Size(75, 23);
            Compare.TabIndex = 5;
            Compare.Text = "Compare";
            Compare.UseVisualStyleBackColor = true;
            Compare.Click += Compare_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(12, 156);
            Result.Name = "Result";
            Result.Size = new Size(39, 15);
            Result.TabIndex = 6;
            Result.Text = "Result";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(624, 441);
            Controls.Add(Result);
            Controls.Add(Compare);
            Controls.Add(BotCards);
            Controls.Add(PlayerCards);
            Controls.Add(PlayerLabel);
            Controls.Add(BotLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(640, 480);
            Name = "Form";
            Text = "Draw Poker";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BotLabel;
        private Label PlayerLabel;
        private ListView PlayerCards;
        private ListView BotCards;
        private Button Compare;
        private Label Result;
    }
}
