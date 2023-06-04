namespace GraduateEmploymentAssistanceService
{
    partial class LaborMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaborMarket));
            System.Windows.Forms.Label textLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label enterprisesLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.baseDataSet = new GraduateEmploymentAssistanceService.BaseDataSet();
            this.bankOfVacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankOfVacanciesTableAdapter = new GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.BankOfVacanciesTableAdapter();
            this.tableAdapterManager = new GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.TableAdapterManager();
            this.bankOfVacanciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bankOfVacanciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bankOfVacanciesDataGridView = new System.Windows.Forms.DataGridView();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.enterprisesTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            textLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            enterprisesLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesBindingNavigator)).BeginInit();
            this.bankOfVacanciesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage1.Controls.Add(this.bankOfVacanciesBindingNavigator);
            this.tabPage1.Controls.Add(textLabel);
            this.tabPage1.Controls.Add(this.textTextBox);
            this.tabPage1.Controls.Add(postLabel);
            this.tabPage1.Controls.Add(this.postTextBox);
            this.tabPage1.Controls.Add(enterprisesLabel);
            this.tabPage1.Controls.Add(this.enterprisesTextBox);
            this.tabPage1.Controls.Add(this.bankOfVacanciesDataGridView);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ВАКАНСИИ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ПРЕДПРИЯТИЯ";
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankOfVacanciesBindingSource
            // 
            this.bankOfVacanciesBindingSource.DataMember = "BankOfVacancies";
            this.bankOfVacanciesBindingSource.DataSource = this.baseDataSet;
            // 
            // bankOfVacanciesTableAdapter
            // 
            this.bankOfVacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankOfVacanciesTableAdapter = this.bankOfVacanciesTableAdapter;
            this.tableAdapterManager.CooperatingEnterprisesTableAdapter = null;
            this.tableAdapterManager.EmploymentOfGraduatesTableAdapter = null;
            this.tableAdapterManager.EnterprisesTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankOfVacanciesBindingNavigator
            // 
            this.bankOfVacanciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankOfVacanciesBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bankOfVacanciesBindingNavigator.BindingSource = this.bankOfVacanciesBindingSource;
            this.bankOfVacanciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankOfVacanciesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankOfVacanciesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bankOfVacanciesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bankOfVacanciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bankOfVacanciesBindingNavigatorSaveItem});
            this.bankOfVacanciesBindingNavigator.Location = new System.Drawing.Point(3, 334);
            this.bankOfVacanciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankOfVacanciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankOfVacanciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankOfVacanciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankOfVacanciesBindingNavigator.Name = "bankOfVacanciesBindingNavigator";
            this.bankOfVacanciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankOfVacanciesBindingNavigator.Size = new System.Drawing.Size(341, 27);
            this.bankOfVacanciesBindingNavigator.TabIndex = 1;
            this.bankOfVacanciesBindingNavigator.Text = "bindingNavigator1";
            this.bankOfVacanciesBindingNavigator.RefreshItems += new System.EventHandler(this.bankOfVacanciesBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bankOfVacanciesBindingNavigatorSaveItem
            // 
            this.bankOfVacanciesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankOfVacanciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankOfVacanciesBindingNavigatorSaveItem.Image")));
            this.bankOfVacanciesBindingNavigatorSaveItem.Name = "bankOfVacanciesBindingNavigatorSaveItem";
            this.bankOfVacanciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bankOfVacanciesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bankOfVacanciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankOfVacanciesBindingNavigatorSaveItem_Click);
            // 
            // bankOfVacanciesDataGridView
            // 
            this.bankOfVacanciesDataGridView.AutoGenerateColumns = false;
            this.bankOfVacanciesDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.bankOfVacanciesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankOfVacanciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankOfVacanciesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bankOfVacanciesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankOfVacanciesDataGridView.DataSource = this.bankOfVacanciesBindingSource;
            this.bankOfVacanciesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bankOfVacanciesDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.bankOfVacanciesDataGridView.Location = new System.Drawing.Point(3, 364);
            this.bankOfVacanciesDataGridView.Name = "bankOfVacanciesDataGridView";
            this.bankOfVacanciesDataGridView.RowHeadersWidth = 51;
            this.bankOfVacanciesDataGridView.RowTemplate.Height = 24;
            this.bankOfVacanciesDataGridView.Size = new System.Drawing.Size(1244, 304);
            this.bankOfVacanciesDataGridView.TabIndex = 0;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(54, 26);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(70, 27);
            textLabel.TabIndex = 1;
            textLabel.Text = "Текст:";
            // 
            // textTextBox
            // 
            this.textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankOfVacanciesBindingSource, "Text", true));
            this.textTextBox.Location = new System.Drawing.Point(197, 26);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTextBox.Size = new System.Drawing.Size(346, 251);
            this.textTextBox.TabIndex = 2;
            // 
            // postLabel
            // 
            postLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            postLabel.AutoSize = true;
            postLabel.Location = new System.Drawing.Point(615, 62);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(126, 27);
            postLabel.TabIndex = 3;
            postLabel.Text = "Должность:";
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankOfVacanciesBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(585, 116);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(343, 35);
            this.postTextBox.TabIndex = 4;
            // 
            // enterprisesLabel
            // 
            enterprisesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            enterprisesLabel.AutoSize = true;
            enterprisesLabel.Location = new System.Drawing.Point(615, 177);
            enterprisesLabel.Name = "enterprisesLabel";
            enterprisesLabel.Size = new System.Drawing.Size(141, 27);
            enterprisesLabel.TabIndex = 5;
            enterprisesLabel.Text = "Предприятие:";
            // 
            // enterprisesTextBox
            // 
            this.enterprisesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankOfVacanciesBindingSource, "Enterprises", true));
            this.enterprisesTextBox.Location = new System.Drawing.Point(585, 223);
            this.enterprisesTextBox.Name = "enterprisesTextBox";
            this.enterprisesTextBox.Size = new System.Drawing.Size(343, 35);
            this.enterprisesTextBox.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn1.HeaderText = "Текст";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Enterprises";
            this.dataGridViewTextBoxColumn3.HeaderText = "Предприятие";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // LaborMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 711);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LaborMarket";
            this.Text = "LaborMarket";
            this.Load += new System.EventHandler(this.LaborMarket_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesBindingNavigator)).EndInit();
            this.bankOfVacanciesBindingNavigator.ResumeLayout(false);
            this.bankOfVacanciesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankOfVacanciesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource bankOfVacanciesBindingSource;
        private BaseDataSetTableAdapters.BankOfVacanciesTableAdapter bankOfVacanciesTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankOfVacanciesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bankOfVacanciesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.TextBox enterprisesTextBox;
        private System.Windows.Forms.DataGridView bankOfVacanciesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}