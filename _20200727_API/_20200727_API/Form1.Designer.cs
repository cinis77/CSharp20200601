namespace _20200727_API
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
            this.jokeBtn = new System.Windows.Forms.Button();
            this.JokeText = new System.Windows.Forms.TextBox();
            this.TypeOfJoke = new System.Windows.Forms.ComboBox();
            this.FactGenerate = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jokeBtn
            // 
            this.jokeBtn.Location = new System.Drawing.Point(35, 38);
            this.jokeBtn.Name = "jokeBtn";
            this.jokeBtn.Size = new System.Drawing.Size(183, 82);
            this.jokeBtn.TabIndex = 0;
            this.jokeBtn.Text = "Generate Joke";
            this.jokeBtn.UseVisualStyleBackColor = true;
            this.jokeBtn.Click += new System.EventHandler(this.jokeBtn_Click);
            // 
            // JokeText
            // 
            this.JokeText.Location = new System.Drawing.Point(35, 239);
            this.JokeText.Multiline = true;
            this.JokeText.Name = "JokeText";
            this.JokeText.Size = new System.Drawing.Size(817, 225);
            this.JokeText.TabIndex = 1;
            // 
            // TypeOfJoke
            // 
            this.TypeOfJoke.FormattingEnabled = true;
            this.TypeOfJoke.Location = new System.Drawing.Point(35, 142);
            this.TypeOfJoke.Name = "TypeOfJoke";
            this.TypeOfJoke.Size = new System.Drawing.Size(156, 32);
            this.TypeOfJoke.TabIndex = 2;
            // 
            // FactGenerate
            // 
            this.FactGenerate.Location = new System.Drawing.Point(258, 38);
            this.FactGenerate.Name = "FactGenerate";
            this.FactGenerate.Size = new System.Drawing.Size(172, 82);
            this.FactGenerate.TabIndex = 3;
            this.FactGenerate.Text = "Fact";
            this.FactGenerate.UseVisualStyleBackColor = true;
            this.FactGenerate.Click += new System.EventHandler(this.FactGenerate_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(258, 145);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(166, 29);
            this.SearchBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 577);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.FactGenerate);
            this.Controls.Add(this.TypeOfJoke);
            this.Controls.Add(this.JokeText);
            this.Controls.Add(this.jokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeBtn;
        private System.Windows.Forms.TextBox JokeText;
        private System.Windows.Forms.ComboBox TypeOfJoke;
        private System.Windows.Forms.Button FactGenerate;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

