namespace _20200721_DuomenuBazesUzduotis
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
            this.OrderNumberTxtbx = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowDataInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderNumberTxtbx
            // 
            this.OrderNumberTxtbx.Location = new System.Drawing.Point(25, 43);
            this.OrderNumberTxtbx.Name = "OrderNumberTxtbx";
            this.OrderNumberTxtbx.Size = new System.Drawing.Size(236, 29);
            this.OrderNumberTxtbx.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(309, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 76);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowDataInfo
            // 
            this.ShowDataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataInfo.Location = new System.Drawing.Point(25, 154);
            this.ShowDataInfo.Name = "ShowDataInfo";
            this.ShowDataInfo.RowHeadersWidth = 72;
            this.ShowDataInfo.RowTemplate.Height = 31;
            this.ShowDataInfo.Size = new System.Drawing.Size(1359, 569);
            this.ShowDataInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 764);
            this.Controls.Add(this.ShowDataInfo);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OrderNumberTxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderNumberTxtbx;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ShowDataInfo;
    }
}

