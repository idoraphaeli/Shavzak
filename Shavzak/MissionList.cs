using Shavzak.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shavzak
{
    public partial class MissionList : BaseForm
    {
        public MissionList()
        {
            InitializeComponent();
        }

        private void MissionList_Load(object sender, EventArgs e)
        {
            List<Mission> missions = AppState.CurrentDeployment.Missions;

            dataGridView1.DataSource = missions;

            // עיצוב עמודות
            if (dataGridView1.Columns["Shifts"] != null)
            {
                dataGridView1.Columns["Shifts"].Visible = false;
            }
            dataGridView1.Columns["Type"].HeaderText = "Mission Type";
            dataGridView1.Columns["HoursPerShift"].HeaderText = "Hours per Shift";
            dataGridView1.Columns["SoldiersPerShift"].HeaderText = "Soldiers per Shift";

            // מניעת עריכה/הוספה
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }
}
