namespace _20200702_SandėlioValdymas
{
    partial class CreateNewItemForm
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
            this.Elektronine = new System.Windows.Forms.CheckBox();
            this.Apyvuoko = new System.Windows.Forms.CheckBox();
            this.Baldas = new System.Windows.Forms.CheckBox();
            this.NameOfItem = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveItem = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Elektronine
            // 
            this.Elektronine.AutoSize = true;
            this.Elektronine.Location = new System.Drawing.Point(45, 44);
            this.Elektronine.Name = "Elektronine";
            this.Elektronine.Size = new System.Drawing.Size(191, 29);
            this.Elektronine.TabIndex = 0;
            this.Elektronine.Text = "Elektronine Preke";
            this.Elektronine.UseVisualStyleBackColor = true;
            this.Elektronine.CheckedChanged += new System.EventHandler(this.Elektronine_CheckedChanged);
            // 
            // Apyvuoko
            // 
            this.Apyvuoko.AutoSize = true;
            this.Apyvuoko.Location = new System.Drawing.Point(277, 44);
            this.Apyvuoko.Name = "Apyvuoko";
            this.Apyvuoko.Size = new System.Drawing.Size(190, 29);
            this.Apyvuoko.TabIndex = 1;
            this.Apyvuoko.Text = "Apyvuokos preke";
            this.Apyvuoko.UseVisualStyleBackColor = true;
            this.Apyvuoko.CheckedChanged += new System.EventHandler(this.Apyvuoko_CheckedChanged);
            // 
            // Baldas
            // 
            this.Baldas.AutoSize = true;
            this.Baldas.Location = new System.Drawing.Point(502, 44);
            this.Baldas.Name = "Baldas";
            this.Baldas.Size = new System.Drawing.Size(98, 29);
            this.Baldas.TabIndex = 2;
            this.Baldas.Text = "Baldas";
            this.Baldas.UseVisualStyleBackColor = true;
            this.Baldas.CheckedChanged += new System.EventHandler(this.Baldas_CheckedChanged);
            // 
            // NameOfItem
            // 
            this.NameOfItem.Location = new System.Drawing.Point(224, 113);
            this.NameOfItem.Name = "NameOfItem";
            this.NameOfItem.Size = new System.Drawing.Size(228, 29);
            this.NameOfItem.TabIndex = 3;
            this.NameOfItem.Visible = false;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(224, 168);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(228, 29);
            this.PriceText.TabIndex = 4;
            this.PriceText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of item";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            this.label2.Visible = false;
            // 
            // SaveItem
            // 
            this.SaveItem.Location = new System.Drawing.Point(646, 333);
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(142, 66);
            this.SaveItem.TabIndex = 7;
            this.SaveItem.Text = "Create";
            this.SaveItem.UseVisualStyleBackColor = true;
            this.SaveItem.Visible = false;
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(493, 333);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(147, 66);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.NameOfItem);
            this.Controls.Add(this.Baldas);
            this.Controls.Add(this.Apyvuoko);
            this.Controls.Add(this.Elektronine);
            this.Name = "CreateNewItemForm";
            this.ShowIcon = false;
            this.Text = "Create new";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Elektronine;
        private System.Windows.Forms.CheckBox Apyvuoko;
        private System.Windows.Forms.CheckBox Baldas;
        private System.Windows.Forms.TextBox NameOfItem;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveItem;
        private System.Windows.Forms.Button Cancel;
    }
}