namespace Sınıf_Atama
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
            System.Windows.Forms.Label dersKoduLabel;
            System.Windows.Forms.Label ders_AdiLabel;
            this.dATA2DataSet = new Sınıf_Atama.DATA2DataSet();
            this.derslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derslerTableAdapter = new Sınıf_Atama.DATA2DataSetTableAdapters.DerslerTableAdapter();
            this.tableAdapterManager = new Sınıf_Atama.DATA2DataSetTableAdapters.TableAdapterManager();
            this.derslerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.derslerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.derslerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKoduTextBox = new System.Windows.Forms.TextBox();
            this.ders_AdiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            dersKoduLabel = new System.Windows.Forms.Label();
            ders_AdiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dATA2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingNavigator)).BeginInit();
            this.derslerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dATA2DataSet
            // 
            this.dATA2DataSet.DataSetName = "DATA2DataSet";
            this.dATA2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derslerBindingSource
            // 
            this.derslerBindingSource.DataMember = "Dersler";
            this.derslerBindingSource.DataSource = this.dATA2DataSet;
            // 
            // derslerTableAdapter
            // 
            this.derslerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DerslerTableAdapter = this.derslerTableAdapter;
            this.tableAdapterManager.OgrenciTableAdapter = null;
            this.tableAdapterManager.SınıflarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sınıf_Atama.DATA2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // derslerBindingNavigator
            // 
            this.derslerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.derslerBindingNavigator.BindingSource = this.derslerBindingSource;
            this.derslerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.derslerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.derslerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.derslerBindingNavigatorSaveItem});
            this.derslerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.derslerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.derslerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.derslerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.derslerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.derslerBindingNavigator.Name = "derslerBindingNavigator";
            this.derslerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.derslerBindingNavigator.Size = new System.Drawing.Size(1468, 25);
            this.derslerBindingNavigator.TabIndex = 0;
            this.derslerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // derslerBindingNavigatorSaveItem
            // 
            this.derslerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.derslerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("derslerBindingNavigatorSaveItem.Image")));
            this.derslerBindingNavigatorSaveItem.Name = "derslerBindingNavigatorSaveItem";
            this.derslerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.derslerBindingNavigatorSaveItem.Text = "Save Data";
            this.derslerBindingNavigatorSaveItem.Click += new System.EventHandler(this.DerslerBindingNavigatorSaveItem_Click);
            // 
            // derslerDataGridView
            // 
            this.derslerDataGridView.AutoGenerateColumns = false;
            this.derslerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.derslerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.derslerDataGridView.DataSource = this.derslerBindingSource;
            this.derslerDataGridView.Location = new System.Drawing.Point(12, 86);
            this.derslerDataGridView.Name = "derslerDataGridView";
            this.derslerDataGridView.Size = new System.Drawing.Size(399, 305);
            this.derslerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DersKodu";
            this.dataGridViewTextBoxColumn1.HeaderText = "DersKodu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ders_Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ders_Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dersKoduLabel
            // 
            dersKoduLabel.AutoSize = true;
            dersKoduLabel.Location = new System.Drawing.Point(712, 152);
            dersKoduLabel.Name = "dersKoduLabel";
            dersKoduLabel.Size = new System.Drawing.Size(60, 13);
            dersKoduLabel.TabIndex = 2;
            dersKoduLabel.Text = "Ders Kodu:";
            // 
            // dersKoduTextBox
            // 
            this.dersKoduTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.derslerBindingSource, "DersKodu", true));
            this.dersKoduTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.derslerBindingSource, "DersKodu", true));
            this.dersKoduTextBox.Location = new System.Drawing.Point(778, 149);
            this.dersKoduTextBox.Name = "dersKoduTextBox";
            this.dersKoduTextBox.Size = new System.Drawing.Size(149, 20);
            this.dersKoduTextBox.TabIndex = 3;
            // 
            // ders_AdiLabel
            // 
            ders_AdiLabel.AutoSize = true;
            ders_AdiLabel.Location = new System.Drawing.Point(722, 194);
            ders_AdiLabel.Name = "ders_AdiLabel";
            ders_AdiLabel.Size = new System.Drawing.Size(50, 13);
            ders_AdiLabel.TabIndex = 4;
            ders_AdiLabel.Text = "Ders Adi:";
            // 
            // ders_AdiTextBox
            // 
            this.ders_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.derslerBindingSource, "Ders_Adi", true));
            this.ders_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.derslerBindingSource, "Ders_Adi", true));
            this.ders_AdiTextBox.Location = new System.Drawing.Point(778, 191);
            this.ders_AdiTextBox.Name = "ders_AdiTextBox";
            this.ders_AdiTextBox.Size = new System.Drawing.Size(149, 20);
            this.ders_AdiTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(ders_AdiLabel);
            this.Controls.Add(this.ders_AdiTextBox);
            this.Controls.Add(dersKoduLabel);
            this.Controls.Add(this.dersKoduTextBox);
            this.Controls.Add(this.derslerDataGridView);
            this.Controls.Add(this.derslerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dATA2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingNavigator)).EndInit();
            this.derslerBindingNavigator.ResumeLayout(false);
            this.derslerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derslerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DATA2DataSet dATA2DataSet;
        private System.Windows.Forms.BindingSource derslerBindingSource;
        private DATA2DataSetTableAdapters.DerslerTableAdapter derslerTableAdapter;
        private DATA2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator derslerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton derslerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView derslerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox dersKoduTextBox;
        private System.Windows.Forms.TextBox ders_AdiTextBox;
        private System.Windows.Forms.Button button1;
    }
}

