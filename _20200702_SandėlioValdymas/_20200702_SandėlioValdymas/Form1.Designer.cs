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
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).BeginInit();
            this.SuspendLayout();
            // 
            // NewItemCreateButton
            // 
            this.NewItemCreateButton.Location = new System.Drawing.Point(1063, 32);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1118);
            this.Controls.Add(this.SandelioVaizdas);
            this.Controls.Add(this.NewItemCreateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SandelioVaizdas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewItemCreateButton;
        private System.Windows.Forms.DataGridView SandelioVaizdas;
    }
}

