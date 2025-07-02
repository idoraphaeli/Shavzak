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
    public partial class ShavzakOutput : BaseForm
    {
        public class ScheduleRow
        {
            public string MissionType { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public string Soldiers { get; set; }
        }

        public ShavzakOutput()
        {
            InitializeComponent();
        }

        private void ShavzakOutput_Load(object sender, EventArgs e)
        {
            List<ScheduleRow> rows = new List<ScheduleRow>();
            Scheduler.AssignSoldiers(AppState.CurrentDeployment);

            foreach (var mission in AppState.CurrentDeployment.Missions)
            {
                foreach (var shift in mission.Shifts)
                {
                    string soldierNames = string.Join(", ", shift.AssignedSoldiers.Select(s => s.FullName));
                    rows.Add(new ScheduleRow
                    {
                        MissionType = mission.Type.ToString(),
                        StartTime = shift.StartTime.ToString(@"hh\:mm"),
                        EndTime = shift.EndTime.ToString(@"hh\:mm"),
                        Soldiers = soldierNames
                    });
                }
            }

            dataGridViewSchedule.DataSource = rows;

            dataGridViewSchedule.ReadOnly = true;
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.AllowUserToDeleteRows = false;
            dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
