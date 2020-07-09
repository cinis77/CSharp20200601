namespace _20200707_Zodynelis
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
            this.CommentText = new System.Windows.Forms.TextBox();
            this.NewTab = new System.Windows.Forms.Button();
            this.Tabai = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(41, 41);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(262, 117);
            this.CommentText.TabIndex = 0;
            this.CommentText.TextChanged += new System.EventHandler(this.CommentText_TextChanged);
            // 
            // NewTab
            // 
            this.NewTab.Location = new System.Drawing.Point(41, 194);
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(100, 59);
            this.NewTab.TabIndex = 1;
            this.NewTab.Text = "Naujas";
            this.NewTab.UseVisualStyleBackColor = true;
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // Tabai
            // 
            this.Tabai.Location = new System.Drawing.Point(333, 41);
            this.Tabai.Name = "Tabai";
            this.Tabai.SelectedIndex = 0;
            this.Tabai.Size = new System.Drawing.Size(833, 552);
            this.Tabai.TabIndex = 2;
            this.Tabai.SelectedIndexChanged += new System.EventHandler(this.Tabai_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 759);
            this.Controls.Add(this.Tabai);
            this.Controls.Add(this.NewTab);
            this.Controls.Add(this.CommentText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommentText;
        private System.Windows.Forms.Button NewTab;
        private System.Windows.Forms.TabControl Tabai;
    }
}

