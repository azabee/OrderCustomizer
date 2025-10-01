namespace OrderCustomizer
{
    partial class Form1
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
            sandwichTypeGroupBox = new GroupBox();
            veggieRadioButton = new RadioButton();
            TurkeyRadioButton = new RadioButton();
            HamRadioButton = new RadioButton();
            extrasGroupBox = new GroupBox();
            LettuceRadioButton = new RadioButton();
            tomatoRadioButton = new RadioButton();
            cheeseRadioButton = new RadioButton();
            orderButton = new Button();
            exitButton = new Button();
            sandwichTypeGroupBox.SuspendLayout();
            extrasGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // sandwichTypeGroupBox
            // 
            sandwichTypeGroupBox.Controls.Add(veggieRadioButton);
            sandwichTypeGroupBox.Controls.Add(TurkeyRadioButton);
            sandwichTypeGroupBox.Controls.Add(HamRadioButton);
            sandwichTypeGroupBox.Location = new Point(30, 41);
            sandwichTypeGroupBox.Name = "sandwichTypeGroupBox";
            sandwichTypeGroupBox.Size = new Size(336, 281);
            sandwichTypeGroupBox.TabIndex = 0;
            sandwichTypeGroupBox.TabStop = false;
            sandwichTypeGroupBox.Text = "Sandwich Type";
            // 
            // veggieRadioButton
            // 
            veggieRadioButton.AutoSize = true;
            veggieRadioButton.Location = new Point(0, 236);
            veggieRadioButton.Name = "veggieRadioButton";
            veggieRadioButton.Size = new Size(147, 45);
            veggieRadioButton.TabIndex = 2;
            veggieRadioButton.TabStop = true;
            veggieRadioButton.Text = "Veggie";
            veggieRadioButton.UseVisualStyleBackColor = true;
            // 
            // TurkeyRadioButton
            // 
            TurkeyRadioButton.AutoSize = true;
            TurkeyRadioButton.Location = new Point(0, 162);
            TurkeyRadioButton.Name = "TurkeyRadioButton";
            TurkeyRadioButton.Size = new Size(144, 45);
            TurkeyRadioButton.TabIndex = 1;
            TurkeyRadioButton.TabStop = true;
            TurkeyRadioButton.Text = "Turkey";
            TurkeyRadioButton.UseVisualStyleBackColor = true;
            // 
            // HamRadioButton
            // 
            HamRadioButton.AutoSize = true;
            HamRadioButton.Location = new Point(0, 85);
            HamRadioButton.Name = "HamRadioButton";
            HamRadioButton.Size = new Size(117, 45);
            HamRadioButton.TabIndex = 0;
            HamRadioButton.TabStop = true;
            HamRadioButton.Text = "Ham";
            HamRadioButton.UseVisualStyleBackColor = true;
            // 
            // extrasGroupBox
            // 
            extrasGroupBox.Controls.Add(LettuceRadioButton);
            extrasGroupBox.Controls.Add(tomatoRadioButton);
            extrasGroupBox.Controls.Add(cheeseRadioButton);
            extrasGroupBox.Location = new Point(414, 41);
            extrasGroupBox.Name = "extrasGroupBox";
            extrasGroupBox.Size = new Size(336, 281);
            extrasGroupBox.TabIndex = 1;
            extrasGroupBox.TabStop = false;
            extrasGroupBox.Text = "Extras";
            // 
            // LettuceRadioButton
            // 
            LettuceRadioButton.AutoSize = true;
            LettuceRadioButton.Location = new Point(0, 236);
            LettuceRadioButton.Name = "LettuceRadioButton";
            LettuceRadioButton.Size = new Size(152, 45);
            LettuceRadioButton.TabIndex = 5;
            LettuceRadioButton.TabStop = true;
            LettuceRadioButton.Text = "Lettuce";
            LettuceRadioButton.UseVisualStyleBackColor = true;
            // 
            // tomatoRadioButton
            // 
            tomatoRadioButton.AutoSize = true;
            tomatoRadioButton.Location = new Point(0, 162);
            tomatoRadioButton.Name = "tomatoRadioButton";
            tomatoRadioButton.Size = new Size(155, 45);
            tomatoRadioButton.TabIndex = 4;
            tomatoRadioButton.TabStop = true;
            tomatoRadioButton.Text = "Tomato";
            tomatoRadioButton.UseVisualStyleBackColor = true;
            // 
            // cheeseRadioButton
            // 
            cheeseRadioButton.AutoSize = true;
            cheeseRadioButton.Location = new Point(0, 85);
            cheeseRadioButton.Name = "cheeseRadioButton";
            cheeseRadioButton.Size = new Size(152, 45);
            cheeseRadioButton.TabIndex = 3;
            cheeseRadioButton.TabStop = true;
            cheeseRadioButton.Text = "Cheese";
            cheeseRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(116, 392);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(250, 67);
            orderButton.TabIndex = 2;
            orderButton.Text = "Show Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(414, 392);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(250, 67);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(exitButton);
            Controls.Add(orderButton);
            Controls.Add(extrasGroupBox);
            Controls.Add(sandwichTypeGroupBox);
            Name = "Form1";
            Text = "Form1";
            sandwichTypeGroupBox.ResumeLayout(false);
            sandwichTypeGroupBox.PerformLayout();
            extrasGroupBox.ResumeLayout(false);
            extrasGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox sandwichTypeGroupBox;
        private RadioButton veggieRadioButton;
        private RadioButton TurkeyRadioButton;
        private RadioButton HamRadioButton;
        private GroupBox extrasGroupBox;
        private RadioButton LettuceRadioButton;
        private RadioButton tomatoRadioButton;
        private RadioButton cheeseRadioButton;
        private Button orderButton;
        private Button exitButton;
    }
}
