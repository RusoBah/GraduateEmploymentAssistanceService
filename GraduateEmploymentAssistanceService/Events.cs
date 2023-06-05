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
        public Events()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.baseDataSet.Events);

        }
    }
}
