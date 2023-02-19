namespace Calculator
{
    partial class CalcWindow
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
            this.numBox = new System.Windows.Forms.TextBox();
            this.oneButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numBox
            // 
            this.numBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numBox.Location = new System.Drawing.Point(53, 35);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(204, 23);
            this.numBox.TabIndex = 0;
            this.numBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numBox_KeyDown);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(53, 84);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(37, 42);
            this.oneButton.TabIndex = 1;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(96, 228);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(37, 42);
            this.zeroButton.TabIndex = 2;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(139, 180);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(37, 42);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(96, 180);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(37, 42);
            this.eightButton.TabIndex = 4;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(53, 180);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(37, 42);
            this.sevenButton.TabIndex = 5;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(139, 132);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(37, 42);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(96, 132);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(37, 42);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(53, 132);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(37, 42);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(139, 84);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(37, 42);
            this.threeButton.TabIndex = 9;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(96, 84);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(37, 42);
            this.twoButton.TabIndex = 10;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(220, 132);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(37, 42);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(220, 180);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multiplyButton.Size = new System.Drawing.Size(37, 42);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(220, 228);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(37, 42);
            this.divideButton.TabIndex = 13;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(139, 228);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(37, 42);
            this.dotButton.TabIndex = 14;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(53, 337);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(204, 42);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(220, 84);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(37, 42);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(53, 289);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(204, 42);
            this.equalsButton.TabIndex = 17;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // CalcWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 391);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.numBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 430);
            this.MinimumSize = new System.Drawing.Size(320, 430);
            this.Name = "CalcWindow";
            this.Text = "Colby\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numBox;
        private Button oneButton;
        private Button zeroButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button threeButton;
        private Button twoButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button dotButton;
        private Button clearButton;
        private Button plusButton;
        private Button equalsButton;
    }
}