namespace _20200713_Viesbutis
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
            this.Kambariai = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BrangiausiB = new System.Windows.Forms.Button();
            this.NeuzimtiB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kambariai)).BeginInit();
            this.SuspendLayout();
            // 
            // Kambariai
            // 
            this.Kambariai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kambariai.Location = new System.Drawing.Point(12, 12);
            this.Kambariai.Name = "Kambariai";
            this.Kambariai.RowHeadersWidth = 72;
            this.Kambariai.RowTemplate.Height = 31;
            this.Kambariai.Size = new System.Drawing.Size(548, 436);
            this.Kambariai.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pigiausi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrangiausiB
            // 
            this.BrangiausiB.Location = new System.Drawing.Point(604, 89);
            this.BrangiausiB.Name = "BrangiausiB";
            this.BrangiausiB.Size = new System.Drawing.Size(180, 59);
            this.BrangiausiB.TabIndex = 2;
            this.BrangiausiB.Text = "Brangiausi";
            this.BrangiausiB.UseVisualStyleBackColor = true;
            this.BrangiausiB.Click += new System.EventHandler(this.BrangiausiB_Click);
            // 
            // NeuzimtiB
            // 
            this.NeuzimtiB.Location = new System.Drawing.Point(604, 173);
            this.NeuzimtiB.Name = "NeuzimtiB";
            this.NeuzimtiB.Size = new System.Drawing.Size(180, 57);
            this.NeuzimtiB.TabIndex = 3;
            this.NeuzimtiB.Text = "Neuzimti";
            this.NeuzimtiB.UseVisualStyleBackColor = true;
            this.NeuzimtiB.Click += new System.EventHandler(this.NeuzimtiB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 616);
            this.Controls.Add(this.NeuzimtiB);
            this.Controls.Add(this.BrangiausiB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kambariai);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Kambariai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Kambariai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BrangiausiB;
        private System.Windows.Forms.Button NeuzimtiB;
    }
}

