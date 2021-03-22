namespace Assessment_2_Flip_Cards
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.CardText = new System.Windows.Forms.RichTextBox();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.RandomCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(425, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(85, 57);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(163, 301);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(100, 35);
            this.PreviousButton.TabIndex = 5;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(501, 301);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 35);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Location = new System.Drawing.Point(336, 301);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(100, 35);
            this.FlipButton.TabIndex = 7;
            this.FlipButton.Text = "Flip";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // CardText
            // 
            this.CardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CardText.Location = new System.Drawing.Point(163, 104);
            this.CardText.Name = "CardText";
            this.CardText.Size = new System.Drawing.Size(438, 128);
            this.CardText.TabIndex = 8;
            this.CardText.Text = "";
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(49, 104);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(85, 56);
            this.ShuffleButton.TabIndex = 9;
            this.ShuffleButton.Text = "Shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // RandomCardButton
            // 
            this.RandomCardButton.Location = new System.Drawing.Point(49, 176);
            this.RandomCardButton.Name = "RandomCardButton";
            this.RandomCardButton.Size = new System.Drawing.Size(85, 56);
            this.RandomCardButton.TabIndex = 10;
            this.RandomCardButton.Text = "Random Card";
            this.RandomCardButton.UseVisualStyleBackColor = true;
            this.RandomCardButton.Click += new System.EventHandler(this.RandomCardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomCardButton);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.CardText);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.RichTextBox CardText;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Button RandomCardButton;
    }
}

