namespace _20200720_WinFormsDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label vardasLabel;
            System.Windows.Forms.Label pavardeLabel;
            System.Windows.Forms.Label gimimoDienaLabel;
            System.Windows.Forms.Label emailLabel;
            this.vartotojaiDataSet = new _20200720_WinFormsDB.VartotojaiDataSet();
            this.klientaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientaiTableAdapter = new _20200720_WinFormsDB.VartotojaiDataSetTableAdapters.KlientaiTableAdapter();
            this.tableAdapterManager = new _20200720_WinFormsDB.VartotojaiDataSetTableAdapters.TableAdapterManager();
            this.klientaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.klientaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klientaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.vardasTextBox = new System.Windows.Forms.TextBox();
            this.pavardeTextBox = new System.Windows.Forms.TextBox();
            this.gimimoDienaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            vardasLabel = new System.Windows.Forms.Label();
            pavardeLabel = new System.Windows.Forms.Label();
            gimimoDienaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingNavigator)).BeginInit();
            this.klientaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vartotojaiDataSet
            // 
            this.vartotojaiDataSet.DataSetName = "VartotojaiDataSet";
            this.vartotojaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientaiBindingSource
            // 
            this.klientaiBindingSource.DataMember = "Klientai";
            this.klientaiBindingSource.DataSource = this.vartotojaiDataSet;
            // 
            // klientaiTableAdapter
            // 
            this.klientaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientaiTableAdapter = this.klientaiTableAdapter;
            this.tableAdapterManager.UpdateOrder = _20200720_WinFormsDB.VartotojaiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klientaiBindingNavigator
            // 
            this.klientaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klientaiBindingNavigator.BindingSource = this.klientaiBindingSource;
            this.klientaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klientaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klientaiBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.klientaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klientaiBindingNavigatorSaveItem});
            this.klientaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klientaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klientaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klientaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klientaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klientaiBindingNavigator.Name = "klientaiBindingNavigator";
            this.klientaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klientaiBindingNavigator.Size = new System.Drawing.Size(1674, 38);
            this.klientaiBindingNavigator.TabIndex = 0;
            this.klientaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // klientaiBindingNavigatorSaveItem
            // 
            this.klientaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klientaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klientaiBindingNavigatorSaveItem.Image")));
            this.klientaiBindingNavigatorSaveItem.Name = "klientaiBindingNavigatorSaveItem";
            this.klientaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 32);
            this.klientaiBindingNavigatorSaveItem.Text = "Save Data";
            this.klientaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.klientaiBindingNavigatorSaveItem_Click);
            // 
            // klientaiDataGridView
            // 
            this.klientaiDataGridView.AutoGenerateColumns = false;
            this.klientaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klientaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.klientaiDataGridView.DataSource = this.klientaiBindingSource;
            this.klientaiDataGridView.Location = new System.Drawing.Point(12, 61);
            this.klientaiDataGridView.Name = "klientaiDataGridView";
            this.klientaiDataGridView.RowHeadersWidth = 72;
            this.klientaiDataGridView.RowTemplate.Height = 31;
            this.klientaiDataGridView.Size = new System.Drawing.Size(1124, 448);
            this.klientaiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vardas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vardas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pavarde";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pavarde";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GimimoDiena";
            this.dataGridViewTextBoxColumn5.HeaderText = "GimimoDiena";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(1239, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientaiBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1385, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 29);
            this.idTextBox.TabIndex = 3;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(1239, 105);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(116, 25);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientaiBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(1385, 102);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.userNameTextBox.TabIndex = 5;
            // 
            // vardasLabel
            // 
            vardasLabel.AutoSize = true;
            vardasLabel.Location = new System.Drawing.Point(1239, 140);
            vardasLabel.Name = "vardasLabel";
            vardasLabel.Size = new System.Drawing.Size(81, 25);
            vardasLabel.TabIndex = 6;
            vardasLabel.Text = "Vardas:";
            // 
            // vardasTextBox
            // 
            this.vardasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientaiBindingSource, "Vardas", true));
            this.vardasTextBox.Location = new System.Drawing.Point(1385, 137);
            this.vardasTextBox.Name = "vardasTextBox";
            this.vardasTextBox.Size = new System.Drawing.Size(200, 29);
            this.vardasTextBox.TabIndex = 7;
            // 
            // pavardeLabel
            // 
            pavardeLabel.AutoSize = true;
            pavardeLabel.Location = new System.Drawing.Point(1239, 175);
            pavardeLabel.Name = "pavardeLabel";
            pavardeLabel.Size = new System.Drawing.Size(91, 25);
            pavardeLabel.TabIndex = 8;
            pavardeLabel.Text = "Pavarde:";
            // 
            // pavardeTextBox
            // 
            this.pavardeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientaiBindingSource, "Pavarde", true));
            this.pavardeTextBox.Location = new System.Drawing.Point(1385, 172);
            this.pavardeTextBox.Name = "pavardeTextBox";
            this.pavardeTextBox.Size = new System.Drawing.Size(200, 29);
            this.pavardeTextBox.TabIndex = 9;
            // 
            // gimimoDienaLabel
            // 
            gimimoDienaLabel.AutoSize = true;
            gimimoDienaLabel.Location = new System.Drawing.Point(1239, 211);
            gimimoDienaLabel.Name = "gimimoDienaLabel";
            gimimoDienaLabel.Size = new System.Drawing.Size(140, 25);
            gimimoDienaLabel.TabIndex = 10;
            gimimoDienaLabel.Text = "Gimimo Diena:";
            // 
            // gimimoDienaDateTimePicker
            // 
            this.gimimoDienaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klientaiBindingSource, "GimimoDiena", true));
            this.gimimoDienaDateTimePicker.Location = new System.Drawing.Point(1385, 207);
            this.gimimoDienaDateTimePicker.Name = "gimimoDienaDateTimePicker";
            this.gimimoDienaDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.gimimoDienaDateTimePicker.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(1239, 245);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientaiBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(1385, 242);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 29);
            this.emailTextBox.TabIndex = 13;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(119, 25);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(64, 19);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 715);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(vardasLabel);
            this.Controls.Add(this.vardasTextBox);
            this.Controls.Add(pavardeLabel);
            this.Controls.Add(this.pavardeTextBox);
            this.Controls.Add(gimimoDienaLabel);
            this.Controls.Add(this.gimimoDienaDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.klientaiDataGridView);
            this.Controls.Add(this.klientaiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingNavigator)).EndInit();
            this.klientaiBindingNavigator.ResumeLayout(false);
            this.klientaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VartotojaiDataSet vartotojaiDataSet;
        private System.Windows.Forms.BindingSource klientaiBindingSource;
        private VartotojaiDataSetTableAdapters.KlientaiTableAdapter klientaiTableAdapter;
        private VartotojaiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klientaiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton klientaiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView klientaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox vardasTextBox;
        private System.Windows.Forms.TextBox pavardeTextBox;
        private System.Windows.Forms.DateTimePicker gimimoDienaDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

