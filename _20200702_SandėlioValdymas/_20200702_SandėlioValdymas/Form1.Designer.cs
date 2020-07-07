namespace _20200702_SandėlioValdymas
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
            this.NewItemCreateButton = new System.Windows.Forms.Button();
            this.SandelioVaizdas = new System.Windows.Forms.DataGridView();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).BeginInit();
            this.SuspendLayout();
            // 
            // NewItemCreateButton
            // 
            this.NewItemCreateButton.Location = new System.Drawing.Point(1061, 307);
            this.NewItemCreateButton.Name = "NewItemCreateButton";
            this.NewItemCreateButton.Size = new System.Drawing.Size(145, 73);
            this.NewItemCreateButton.TabIndex = 0;
            this.NewItemCreateButton.Text = "nauja...";
            this.NewItemCreateButton.UseVisualStyleBackColor = true;
            this.NewItemCreateButton.Click += new System.EventHandler(this.NewItemCreateButton_Click);
            // 
            // SandelioVaizdas
            // 
            this.SandelioVaizdas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SandelioVaizdas.Location = new System.Drawing.Point(31, 32);
            this.SandelioVaizdas.Name = "SandelioVaizdas";
            this.SandelioVaizdas.RowHeadersWidth = 72;
            this.SandelioVaizdas.RowTemplate.Height = 31;
            this.SandelioVaizdas.Size = new System.Drawing.Size(909, 793);
            this.SandelioVaizdas.TabIndex = 1;
            this.SandelioVaizdas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SandelioVaizdas_CellContentClick);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(1106, 134);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 29);
            this.PriceText.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(974, 134);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(69, 25);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Kaina:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Location = new System.Drawing.Point(1106, 75);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(19, 25);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "-";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1066, 218);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(140, 61);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Atnaujinti";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1061, 404);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(145, 79);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Ištrinti";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1118);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.SandelioVaizdas);
            this.Controls.Add(this.NewItemCreateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewItemCreateButton;
        private System.Windows.Forms.DataGridView SandelioVaizdas;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

