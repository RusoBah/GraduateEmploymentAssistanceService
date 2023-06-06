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
    public partial class Events : Form
    {
        // поле для принятия значения статуса пользователя. Только для чтения
        private readonly bool _isUser;
      
        // При инициализации(т.е активации формы) мы предаём значаение статуса пользователя из главной формы.
        public Events(bool isUser)
        {
            // Присваиваем к полю для взаимодействия
            _isUser = isUser;
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        // Проверка прав пользователя. 
        private void CheckAccess()
        {
            // Имя нужного элемента / Видимый  = _isUser(Полученный пользователь) и если у него в статусе значени "true"(т.е. админ). Для него доступен этот элемент
            eventsBindingNavigator.Enabled = _isUser == true;
            eventTextBox.Enabled = _isUser == true;
            dateOfTheEventDateTimePicker.Enabled = _isUser == true;
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.baseDataSet.Events);

            CheckAccess();
        }
    }
}
