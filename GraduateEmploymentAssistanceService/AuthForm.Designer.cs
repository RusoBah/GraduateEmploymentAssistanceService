namespace GraduateEmploymentAssistanceService.Model
{
    partial class AuthForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printLogin = new System.Windows.Forms.TextBox();
            this.printPassword = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_printLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_printPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_printPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_printFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите логин:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите пароль:";
            // 
            // printLogin
            // 
            this.printLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printLogin.BackColor = System.Drawing.Color.MistyRose;
            this.printLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printLogin.ForeColor = System.Drawing.Color.DimGray;
            this.printLogin.Location = new System.Drawing.Point(329, 32);
            this.printLogin.Multiline = true;
            this.printLogin.Name = "printLogin";
            this.printLogin.Size = new System.Drawing.Size(532, 35);
            this.printLogin.TabIndex = 6;
            // 
            // printPassword
            // 
            this.printPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.printPassword.BackColor = System.Drawing.Color.MistyRose;
            this.printPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printPassword.ForeColor = System.Drawing.Color.DimGray;
            this.printPassword.Location = new System.Drawing.Point(329, 216);
            this.printPassword.Multiline = true;
            this.printPassword.Name = "printPassword";
            this.printPassword.PasswordChar = '*';
            this.printPassword.Size = new System.Drawing.Size(532, 35);
            this.printPassword.TabIndex = 7;
            // 
            // btnAuth
            // 
            this.btnAuth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAuth.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Location = new System.Drawing.Point(252, 334);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(226, 59);
            this.btnAuth.TabIndex = 8;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(595, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 97);
            this.button1.TabIndex = 9;
            this.button1.Text = "Авторизация администратора";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 691);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage1.Controls.Add(this.printLogin);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAuth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.printPassword);
            this.tabPage1.Font = new System.Drawing.Font("Perpetua Titling MT", 16F);
            this.tabPage1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "АВТОРИЗАЦИЯ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox_printFullName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_printPhone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_printPassword);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_printLogin);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "РЕГИСТРАЦИЯ";
            // 
            // textBox_printLogin
            // 
            this.textBox_printLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_printLogin.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_printLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_printLogin.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_printLogin.Location = new System.Drawing.Point(486, 55);
            this.textBox_printLogin.Multiline = true;
            this.textBox_printLogin.Name = "textBox_printLogin";
            this.textBox_printLogin.Size = new System.Drawing.Size(532, 35);
            this.textBox_printLogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите логин:";
            // 
            // textBox_printPassword
            // 
            this.textBox_printPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_printPassword.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_printPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_printPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_printPassword.Location = new System.Drawing.Point(486, 128);
            this.textBox_printPassword.Multiline = true;
            this.textBox_printPassword.Name = "textBox_printPassword";
            this.textBox_printPassword.Size = new System.Drawing.Size(532, 35);
            this.textBox_printPassword.TabIndex = 10;
            this.textBox_printPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите пароль:";
            // 
            // textBox_printPhone
            // 
            this.textBox_printPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_printPhone.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_printPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_printPhone.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_printPhone.Location = new System.Drawing.Point(486, 213);
            this.textBox_printPhone.Multiline = true;
            this.textBox_printPhone.Name = "textBox_printPhone";
            this.textBox_printPhone.Size = new System.Drawing.Size(532, 35);
            this.textBox_printPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите номер телефона:";
            // 
            // textBox_printFullName
            // 
            this.textBox_printFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_printFullName.BackColor = System.Drawing.Color.MistyRose;
            this.textBox_printFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_printFullName.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_printFullName.Location = new System.Drawing.Point(486, 295);
            this.textBox_printFullName.Multiline = true;
            this.textBox_printFullName.Name = "textBox_printFullName";
            this.textBox_printFullName.Size = new System.Drawing.Size(532, 35);
            this.textBox_printFullName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите ФИО:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(486, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 59);
            this.button2.TabIndex = 15;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1051, 691);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printLogin;
        private System.Windows.Forms.TextBox printPassword;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_printFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_printPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_printPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_printLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}