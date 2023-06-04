using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GraduateEmploymentAssistanceService
{
    public class AuthUser
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-R8IMC7R; Initial Catalog = Base; Integrated Security=True");



        public void ConnectionBase(string login, string password)
        {
            string queryString = $"select id, login, password, isUser from admins where phone = '{login}' and password = '{password}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                // Принимает логин - номер телефона; isUser
                var user = new CheckUser(dataTable.Rows[0][1].ToString(), Convert.ToBoolean(dataTable.Rows[0][3]));

                MessageBox.Show("Вы успешно вошли!", "Уведомление");
                
                MainForm main = new MainForm(user);
                main.Show();
                

            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Уведомление");
        }

        //public void Auth(string table, string login, string password)
        //{
        //    string queryString = $"select id, phone, password from {table} where phone = '{login}' and password = '{password}'";
        //    ConnectionBase(queryString);

        //}

    }
}
