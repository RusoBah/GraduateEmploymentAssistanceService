using GraduateEmploymentAssistanceService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateEmploymentAssistanceService
{
    public partial class MainForm : Form
    {
        private Form activeForms;
        private readonly CheckUser _user;
        public MainForm(CheckUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _user.Status.ToString();
        }

        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {

            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            // Проверка на активность формы
            if (activeForms != null)
            {
                activeForms.Close();

            }
            ActivateButton(btnSender);
            activeForms = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.ForestGreen;
            childForm.Size = activeForms.Size;

            this.splitContainer1.Panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
           Close();
            
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(_user);
            mainForm.Show();
            this.Hide();
            //mainForm.panel1.Hide();
            //mainForm.splitContainer1.Panel1.Hide();
            //OpenChildForm(mainForm, sender);
            //Header.Text = btnMainForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthForm(), sender);
            Header.Text = button1.Text;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLaborMarket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LaborMarket(), sender);
            Header.Text = btnLaborMarket.Text;
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEvent_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Events(), sender);
            Header.Text = btnEvent.Text;
        }
    }
}
