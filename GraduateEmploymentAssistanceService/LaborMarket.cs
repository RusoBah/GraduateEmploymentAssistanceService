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
    public partial class LaborMarket : Form
    {
        // поле для принятия значения статуса пользователя. Только для чтения
        private readonly bool _isUser;
        public LaborMarket(bool isUser)
        {
            InitializeComponent();
            _isUser = isUser;
        }

        private void bankOfVacanciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankOfVacanciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }
        private void CheckAccess()
        {
            // Имя нужного элемента / Видимый  = _isUser(Полученный пользователь) и если у него в статусе значени "true"(т.е. админ). Для него доступен этот элемент
            bindingNavigatorDeleteItem.Enabled = _isUser == true;
            textTextBox.Enabled = _isUser == true;
            postTextBox.Enabled = _isUser == true;
            enterprisesTextBox.Enabled = _isUser == true;
            bindingNavigator1.Enabled = _isUser == true;
            nameTextBox.Enabled = _isUser == true;
            addressTextBox.Enabled = _isUser == true;
        }

        private void LaborMarket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.CooperatingEnterprises". При необходимости она может быть перемещена или удалена.
            this.cooperatingEnterprisesTableAdapter.Fill(this.baseDataSet.CooperatingEnterprises);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.BankOfVacancies". При необходимости она может быть перемещена или удалена.
            this.bankOfVacanciesTableAdapter.Fill(this.baseDataSet.BankOfVacancies);

            // При загрузки формы, не забываем вызвать метод
            CheckAccess();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bankOfVacanciesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
