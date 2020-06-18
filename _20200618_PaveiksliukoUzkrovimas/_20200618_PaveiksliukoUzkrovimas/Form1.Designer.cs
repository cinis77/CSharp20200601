namespace _20200618_PaveiksliukoUzkrovimas
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
            this.KeliasText = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.Paveiksliukas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Paveiksliukas)).BeginInit();
            this.SuspendLayout();
            // 
            // KeliasText
            // 
            this.KeliasText.Location = new System.Drawing.Point(24, 24);
            this.KeliasText.Name = "KeliasText";
            this.KeliasText.Size = new System.Drawing.Size(535, 29);
            this.KeliasText.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(623, 24);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(182, 67);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Užkrauti";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Paveiksliukas
            // 
            this.Paveiksliukas.Location = new System.Drawing.Point(13, 110);
            this.Paveiksliukas.Name = "Paveiksliukas";
            this.Paveiksliukas.Size = new System.Drawing.Size(916, 580);
            this.Paveiksliukas.TabIndex = 2;
            this.Paveiksliukas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 714);
            this.Controls.Add(this.Paveiksliukas);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.KeliasText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Paveiksliukas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeliasText;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.PictureBox Paveiksliukas;
    }
}

