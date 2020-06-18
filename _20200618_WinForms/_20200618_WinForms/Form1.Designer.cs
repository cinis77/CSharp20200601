namespace _20200618_WinForms
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
            this.BMygtukoPavadimas = new System.Windows.Forms.Button();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PswText = new System.Windows.Forms.TextBox();
            this.LUserName = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.GroupBox();
            this.DuomenuAtvaizdavimas = new System.Windows.Forms.DataGridView();
            this.CBManoPavadinimas = new System.Windows.Forms.CheckBox();
            this.PBNuotrauka = new System.Windows.Forms.PictureBox();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DuomenuAtvaizdavimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNuotrauka)).BeginInit();
            this.SuspendLayout();
            // 
            // BMygtukoPavadimas
            // 
            this.BMygtukoPavadimas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BMygtukoPavadimas.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BMygtukoPavadimas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BMygtukoPavadimas.Location = new System.Drawing.Point(784, 557);
            this.BMygtukoPavadimas.Name = "BMygtukoPavadimas";
            this.BMygtukoPavadimas.Size = new System.Drawing.Size(319, 153);
            this.BMygtukoPavadimas.TabIndex = 0;
            this.BMygtukoPavadimas.Text = "Mano tekstas";
            this.BMygtukoPavadimas.UseVisualStyleBackColor = false;
            this.BMygtukoPavadimas.Click += new System.EventHandler(this.BMygtukoPavadimas_Click);
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(173, 65);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(296, 29);
            this.UserText.TabIndex = 1;
            // 
            // PswText
            // 
            this.PswText.Location = new System.Drawing.Point(173, 122);
            this.PswText.Name = "PswText";
            this.PswText.PasswordChar = '1';
            this.PswText.Size = new System.Drawing.Size(296, 29);
            this.PswText.TabIndex = 2;
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(20, 65);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(105, 25);
            this.LUserName.TabIndex = 3;
            this.LUserName.Text = "UserName";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(25, 122);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(98, 25);
            this.LPassword.TabIndex = 4;
            this.LPassword.Text = "Password";
            // 
            // Login
            // 
            this.Login.Controls.Add(this.LPassword);
            this.Login.Controls.Add(this.UserText);
            this.Login.Controls.Add(this.LUserName);
            this.Login.Controls.Add(this.PswText);
            this.Login.Location = new System.Drawing.Point(49, 39);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(615, 284);
            this.Login.TabIndex = 5;
            this.Login.TabStop = false;
            this.Login.Text = "Login duomenys";
            // 
            // DuomenuAtvaizdavimas
            // 
            this.DuomenuAtvaizdavimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DuomenuAtvaizdavimas.Location = new System.Drawing.Point(49, 346);
            this.DuomenuAtvaizdavimas.Name = "DuomenuAtvaizdavimas";
            this.DuomenuAtvaizdavimas.RowHeadersWidth = 72;
            this.DuomenuAtvaizdavimas.RowTemplate.Height = 31;
            this.DuomenuAtvaizdavimas.Size = new System.Drawing.Size(692, 364);
            this.DuomenuAtvaizdavimas.TabIndex = 6;
            // 
            // CBManoPavadinimas
            // 
            this.CBManoPavadinimas.AutoSize = true;
            this.CBManoPavadinimas.Location = new System.Drawing.Point(727, 60);
            this.CBManoPavadinimas.Name = "CBManoPavadinimas";
            this.CBManoPavadinimas.Size = new System.Drawing.Size(106, 29);
            this.CBManoPavadinimas.TabIndex = 7;
            this.CBManoPavadinimas.Text = "Varnele";
            this.CBManoPavadinimas.UseVisualStyleBackColor = true;
            // 
            // PBNuotrauka
            // 
            this.PBNuotrauka.Location = new System.Drawing.Point(1187, 39);
            this.PBNuotrauka.Name = "PBNuotrauka";
            this.PBNuotrauka.Size = new System.Drawing.Size(530, 490);
            this.PBNuotrauka.TabIndex = 8;
            this.PBNuotrauka.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 841);
            this.Controls.Add(this.PBNuotrauka);
            this.Controls.Add(this.CBManoPavadinimas);
            this.Controls.Add(this.DuomenuAtvaizdavimas);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.BMygtukoPavadimas);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Mano programa";
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DuomenuAtvaizdavimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNuotrauka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BMygtukoPavadimas;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PswText;
        private System.Windows.Forms.Label LUserName;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.DataGridView DuomenuAtvaizdavimas;
        private System.Windows.Forms.CheckBox CBManoPavadinimas;
        private System.Windows.Forms.PictureBox PBNuotrauka;
    }
}

