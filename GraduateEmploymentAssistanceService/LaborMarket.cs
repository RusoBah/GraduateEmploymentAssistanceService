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
        public LaborMarket()
        {
            InitializeComponent();
        }

        private void bankOfVacanciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankOfVacanciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void LaborMarket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.CooperatingEnterprises". При необходимости она может быть перемещена или удалена.
            this.cooperatingEnterprisesTableAdapter.Fill(this.baseDataSet.CooperatingEnterprises);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.BankOfVacancies". При необходимости она может быть перемещена или удалена.
            this.bankOfVacanciesTableAdapter.Fill(this.baseDataSet.BankOfVacancies);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bankOfVacanciesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
