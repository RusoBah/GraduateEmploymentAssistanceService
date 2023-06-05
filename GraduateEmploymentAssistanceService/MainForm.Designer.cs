namespace GraduateEmploymentAssistanceService
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLaborMarket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEvent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 91);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1072, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 28);
            this.textBox1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1274, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(567, 25);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(297, 39);
            this.Header.TabIndex = 0;
            this.Header.Text = "Главная страница";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.ForestGreen;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(0, 91);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEvent);
            this.splitContainer1.Panel1.Controls.Add(this.btnLaborMarket);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnMainForm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1361, 710);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnLaborMarket
            // 
            this.btnLaborMarket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaborMarket.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLaborMarket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaborMarket.FlatAppearance.BorderSize = 0;
            this.btnLaborMarket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLaborMarket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLaborMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaborMarket.Location = new System.Drawing.Point(33, 126);
            this.btnLaborMarket.Name = "btnLaborMarket";
            this.btnLaborMarket.Size = new System.Drawing.Size(226, 59);
            this.btnLaborMarket.TabIndex = 2;
            this.btnLaborMarket.Text = "Рынок труда";
            this.btnLaborMarket.UseVisualStyleBackColor = false;
            this.btnLaborMarket.Click += new System.EventHandler(this.btnLaborMarket_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(33, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Окно авторизации";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainForm.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainForm.FlatAppearance.BorderSize = 0;
            this.btnMainForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainForm.Location = new System.Drawing.Point(33, 24);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(226, 59);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "Главная страница";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 327);
            this.label6.MaximumSize = new System.Drawing.Size(680, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(632, 189);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.MaximumSize = new System.Drawing.Size(680, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 135);
            this.label5.TabIndex = 4;
            this.label5.Text = "Техникум осуществляет обучение по образовательным программам\r\n среднего профессио" +
    "нального образования\r\n подготовки квалифицированных рабочих, служащих и\r\n специа" +
    "листов среднего звена.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "О техникуме";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Директор ГАПОУ ПО КТПТП\r\n Гришаков Вячеслав Геннадьевич";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(23, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 81);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добро пожаловать! \r\nГосударственное автономное профессиональное образовательное у" +
    "чреждение Пензенской области\r\n «Каменский техникум промышленных технологий и пре" +
    "дпринимательства»";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEvent
            // 
            this.btnEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Location = new System.Drawing.Point(33, 229);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(226, 59);
            this.btnEvent.TabIndex = 3;
            this.btnEvent.Text = "Мероприятия";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GraduateEmploymentAssistanceService.Properties.Resources.direktor;
            this.pictureBox1.Location = new System.Drawing.Point(693, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 801);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLaborMarket;
        private System.Windows.Forms.Button btnEvent;
    }
}

