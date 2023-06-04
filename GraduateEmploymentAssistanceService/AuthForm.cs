using GraduateEmploymentAssistanceService.BaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateEmploymentAssistanceService.Model
{
    public partial class AuthForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-R8IMC7R; Initial Catalog = Base; Integrated Security=True");

        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = printLogin.Text;
            string password = printLogin.Text;

            string queryString = $"select id, login, password, isUser from students where phone = '{login}' and password = '{password}'";
           
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                // Принимает логин; isUser
                var user = new CheckUser(dataTable.Rows[0][1].ToString(), Convert.ToBoolean(dataTable.Rows[0][3]));

                MessageBox.Show("Вы успешно вошли!", "Уведомление");

                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Уведомление");

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = printLogin.Text;
            string password = printLogin.Text;

            string queryString = $"select id, login, password, isUser from admins where phone = '{login}' and password = '{password}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                // Принимает логин; isUser
                var user = new CheckUser(dataTable.Rows[0][1].ToString(), Convert.ToBoolean(dataTable.Rows[0][3]));

                MessageBox.Show("Вы успешно вошли!", "Уведомление");

                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Уведомление");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string commandString = @"INSERT INTO students (fullName, phone, password, login, isUser) " +
               "VALUES(@fullName, @phone, @password, @post, 1)";
            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-R8IMC7R; Initial Catalog = Base; Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                command.Parameters.AddWithValue("@fullName", textBox_printFullName.Text);
                command.Parameters.AddWithValue("@phone", textBox_printPhone.Text);
                command.Parameters.AddWithValue("@password", textBox_printPassword.Text);
                command.Parameters.AddWithValue("@login", textBox_printLogin.Text);
                

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан!", "Уведомление");
                }
            }
        }
    }
}
