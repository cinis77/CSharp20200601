namespace _20200730_SaugojimasSlaptazodziu
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
            this.label1 = new System.Windows.Forms.Label();
            this.md5text = new System.Windows.Forms.TextBox();
            this.TekstasTxt = new System.Windows.Forms.TextBox();
            this.md5Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SHA1Txt = new System.Windows.Forms.TextBox();
            this.Sha1btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaltedHash = new System.Windows.Forms.TextBox();
            this.HashSaltextTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "md5";
            // 
            // md5text
            // 
            this.md5text.Location = new System.Drawing.Point(169, 104);
            this.md5text.Name = "md5text";
            this.md5text.Size = new System.Drawing.Size(299, 29);
            this.md5text.TabIndex = 1;
            // 
            // TekstasTxt
            // 
            this.TekstasTxt.Location = new System.Drawing.Point(169, 31);
            this.TekstasTxt.Name = "TekstasTxt";
            this.TekstasTxt.Size = new System.Drawing.Size(190, 29);
            this.TekstasTxt.TabIndex = 2;
            // 
            // md5Btn
            // 
            this.md5Btn.Location = new System.Drawing.Point(597, 99);
            this.md5Btn.Name = "md5Btn";
            this.md5Btn.Size = new System.Drawing.Size(143, 53);
            this.md5Btn.TabIndex = 3;
            this.md5Btn.Text = "md5";
            this.md5Btn.UseVisualStyleBackColor = true;
            this.md5Btn.Click += new System.EventHandler(this.md5Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "SHA1";
            // 
            // SHA1Txt
            // 
            this.SHA1Txt.Location = new System.Drawing.Point(169, 207);
            this.SHA1Txt.Name = "SHA1Txt";
            this.SHA1Txt.Size = new System.Drawing.Size(305, 29);
            this.SHA1Txt.TabIndex = 5;
            // 
            // Sha1btn
            // 
            this.Sha1btn.Location = new System.Drawing.Point(597, 207);
            this.Sha1btn.Name = "Sha1btn";
            this.Sha1btn.Size = new System.Drawing.Size(143, 52);
            this.Sha1btn.TabIndex = 6;
            this.Sha1btn.Text = "SHA1";
            this.Sha1btn.UseVisualStyleBackColor = true;
            this.Sha1btn.Click += new System.EventHandler(this.Sha1btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salted";
            // 
            // SaltedHash
            // 
            this.SaltedHash.Location = new System.Drawing.Point(169, 310);
            this.SaltedHash.Name = "SaltedHash";
            this.SaltedHash.Size = new System.Drawing.Size(305, 29);
            this.SaltedHash.TabIndex = 8;
            // 
            // HashSaltextTxt
            // 
            this.HashSaltextTxt.Location = new System.Drawing.Point(597, 297);
            this.HashSaltextTxt.Name = "HashSaltextTxt";
            this.HashSaltextTxt.Size = new System.Drawing.Size(143, 63);
            this.HashSaltextTxt.TabIndex = 9;
            this.HashSaltextTxt.Text = "Hash with salt";
            this.HashSaltextTxt.UseVisualStyleBackColor = true;
            this.HashSaltextTxt.Click += new System.EventHandler(this.HashSaltextTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 673);
            this.Controls.Add(this.HashSaltextTxt);
            this.Controls.Add(this.SaltedHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sha1btn);
            this.Controls.Add(this.SHA1Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.md5Btn);
            this.Controls.Add(this.TekstasTxt);
            this.Controls.Add(this.md5text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox md5text;
        private System.Windows.Forms.TextBox TekstasTxt;
        private System.Windows.Forms.Button md5Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SHA1Txt;
        private System.Windows.Forms.Button Sha1btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SaltedHash;
        private System.Windows.Forms.Button HashSaltextTxt;
    }
}

