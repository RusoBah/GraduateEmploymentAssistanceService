namespace GraduateEmploymentAssistanceService
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            System.Windows.Forms.Label eventLabel;
            System.Windows.Forms.Label dateOfTheEventLabel;
            this.baseDataSet = new GraduateEmploymentAssistanceService.BaseDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.EventsTableAdapter();
            this.tableAdapterManager = new GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.TableAdapterManager();
            this.eventsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.dateOfTheEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            eventLabel = new System.Windows.Forms.Label();
            dateOfTheEventLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).BeginInit();
            this.eventsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.baseDataSet;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankOfVacanciesTableAdapter = null;
            this.tableAdapterManager.CooperatingEnterprisesTableAdapter = null;
            this.tableAdapterManager.EmploymentOfGraduatesTableAdapter = null;
            this.tableAdapterManager.EnterprisesTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = this.eventsTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GraduateEmploymentAssistanceService.BaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventsBindingNavigator
            // 
            this.eventsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventsBindingNavigator.BindingSource = this.eventsBindingSource;
            this.eventsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.eventsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventsBindingNavigatorSaveItem});
            this.eventsBindingNavigator.Location = new System.Drawing.Point(0, 375);
            this.eventsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventsBindingNavigator.Name = "eventsBindingNavigator";
            this.eventsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.eventsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventsBindingNavigator.Size = new System.Drawing.Size(388, 27);
            this.eventsBindingNavigator.TabIndex = 0;
            this.eventsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // eventsBindingNavigatorSaveItem
            // 
            this.eventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventsBindingNavigatorSaveItem.Image")));
            this.eventsBindingNavigatorSaveItem.Name = "eventsBindingNavigatorSaveItem";
            this.eventsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eventsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.eventsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventsBindingNavigatorSaveItem_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.AutoGenerateColumns = false;
            this.eventsDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.eventsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.eventsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventsDataGridView.DataSource = this.eventsBindingSource;
            this.eventsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eventsDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsDataGridView.Location = new System.Drawing.Point(0, 422);
            this.eventsDataGridView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.RowHeadersWidth = 51;
            this.eventsDataGridView.RowTemplate.Height = 24;
            this.eventsDataGridView.Size = new System.Drawing.Size(1424, 227);
            this.eventsDataGridView.TabIndex = 1;
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.ForeColor = System.Drawing.SystemColors.Control;
            eventLabel.Location = new System.Drawing.Point(51, 68);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new System.Drawing.Size(89, 27);
            eventLabel.TabIndex = 2;
            eventLabel.Text = "Event:";
            // 
            // eventTextBox
            // 
            this.eventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Event", true));
            this.eventTextBox.Location = new System.Drawing.Point(322, 68);
            this.eventTextBox.Multiline = true;
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(310, 113);
            this.eventTextBox.TabIndex = 3;
            // 
            // dateOfTheEventLabel
            // 
            dateOfTheEventLabel.AutoSize = true;
            dateOfTheEventLabel.ForeColor = System.Drawing.SystemColors.Control;
            dateOfTheEventLabel.Location = new System.Drawing.Point(42, 270);
            dateOfTheEventLabel.Name = "dateOfTheEventLabel";
            dateOfTheEventLabel.Size = new System.Drawing.Size(251, 27);
            dateOfTheEventLabel.TabIndex = 4;
            dateOfTheEventLabel.Text = "Date Of The Event:";
            // 
            // dateOfTheEventDateTimePicker
            // 
            this.dateOfTheEventDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventsBindingSource, "DateOfTheEvent", true));
            this.dateOfTheEventDateTimePicker.Location = new System.Drawing.Point(322, 261);
            this.dateOfTheEventDateTimePicker.Name = "dateOfTheEventDateTimePicker";
            this.dateOfTheEventDateTimePicker.Size = new System.Drawing.Size(310, 35);
            this.dateOfTheEventDateTimePicker.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Event";
            this.dataGridViewTextBoxColumn1.HeaderText = "Мероприятия";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateOfTheEvent";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата проведения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 649);
            this.Controls.Add(eventLabel);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(dateOfTheEventLabel);
            this.Controls.Add(this.dateOfTheEventDateTimePicker);
            this.Controls.Add(this.eventsDataGridView);
            this.Controls.Add(this.eventsBindingNavigator);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).EndInit();
            this.eventsBindingNavigator.ResumeLayout(false);
            this.eventsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private BaseDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private BaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.DateTimePicker dateOfTheEventDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}