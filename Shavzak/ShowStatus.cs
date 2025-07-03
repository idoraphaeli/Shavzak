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
    public partial class ShowStatus : BaseForm
    {
        public ShowStatus()
        {
            InitializeComponent();
        }

        private void ShowStatus_Load(object sender, EventArgs e)
        {
            LoadSoldierStatus();
            ResizeForm();
        }

        private void ResizeForm()
        {
            int totalWidth = dataGridViewStatus.RowHeadersVisible ? dataGridViewStatus.RowHeadersWidth : 0;
            int totalHeight = dataGridViewStatus.ColumnHeadersVisible ? dataGridViewStatus.ColumnHeadersHeight : 0;

            foreach (DataGridViewColumn col in dataGridViewStatus.Columns)
            {
                totalWidth += col.Width;
            }

            foreach (DataGridViewRow row in dataGridViewStatus.Rows)
            {
                totalHeight += row.Height;
            }

            this.ClientSize = new Size(totalWidth + 5, totalHeight + 20);
            this.CenterToScreen();
        }

        private void LoadSoldierStatus()
        {
            var soldiers = AppState.CurrentDeployment.Company.GetSoldiers();
            var taskTypes = Enum.GetValues(typeof(Mission.TaskType)).Cast<Mission.TaskType>().ToList();

            dataGridViewStatus.Columns.Clear();
            dataGridViewStatus.Rows.Clear();

            dataGridViewStatus.Columns.Add("Name", "Name");
            dataGridViewStatus.Columns.Add("Role", "Role");

            foreach (var taskType in taskTypes)
            {
                dataGridViewStatus.Columns.Add(taskType.ToString(), taskType.ToString());
            }

            foreach (var soldier in soldiers)
            {
                var row = new List<string>
                {
                    soldier.FullName,
                    soldier.SoldierRole.ToString()
                };

                foreach (var taskType in taskTypes)
                {
                    int count = soldier.TaskTypeCounts.ContainsKey(taskType) ? soldier.TaskTypeCounts[taskType] : 0;
                    row.Add(count.ToString());
                }

                dataGridViewStatus.Rows.Add(row.ToArray());
            }

            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridViewStatus.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewStatus.AutoResizeColumn(column.Index, DataGridViewAutoSizeColumnMode.AllCells);
            }
        }
    }
}
