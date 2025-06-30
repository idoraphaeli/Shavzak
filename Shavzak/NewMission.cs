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
using static Shavzak.Logic.Constraint;
using static Shavzak.Soldier;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shavzak
{
    public partial class NewMission : BaseForm
    {
        public NewMission()
        {
            InitializeComponent();
        }

        private void NewMission_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shavzak.Logic.Mission.TaskType taskType = (Shavzak.Logic.Mission.TaskType)comboBox1.SelectedItem;
            int hourPerShift = int.Parse(comboBox2.SelectedItem.ToString());
            int soldierPerShift = int.Parse(comboBox3.SelectedItem.ToString());

            Mission mission = new Mission(taskType, hourPerShift, soldierPerShift);

            MessageBox.Show($"Created mission:\nMission: {mission.Type}\nHour Per Shift: {mission.HoursPerShift}\nSoldier Per Shift: {mission.SoldiersPerShift}");
            AppState.CurrentDeployment.AddMission(mission);

            this.Close();
        }
    }
}
