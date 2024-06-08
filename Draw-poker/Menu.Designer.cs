namespace Draw_poker
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            NameBox = new TextBox();
            Label = new Label();
            StartB = new Button();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(320, 190);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 23);
            NameBox.TabIndex = 28;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(357, 172);
            Label.Name = "Label";
            Label.Size = new Size(78, 15);
            Label.TabIndex = 29;
            Label.Text = "Введите имя:";
            // 
            // StartB
            // 
            StartB.Location = new Point(320, 219);
            StartB.Name = "StartB";
            StartB.Size = new Size(150, 23);
            StartB.TabIndex = 30;
            StartB.Text = "Начать игру";
            StartB.UseVisualStyleBackColor = true;
            StartB.Click += StartB_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 553);
            Controls.Add(StartB);
            Controls.Add(Label);
            Controls.Add(NameBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Draw Poker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private Label Label;
        private Button StartB;
    }
}