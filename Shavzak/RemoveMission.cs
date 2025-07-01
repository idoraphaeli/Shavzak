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
    public partial class RemoveMission : Form
    {
        public RemoveMission()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void RemoveMission_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(450, 300);
            this.Size = this.MinimumSize;
            this.comboBoxRemoveMission.DataSource = null;
            this.comboBoxRemoveMission.DataSource = AppState.CurrentDeployment.Missions;
            comboBoxRemoveMission.DisplayMember = "Type";
            this.comboBoxRemoveMission.Size = new System.Drawing.Size(160, 24);
            this.MaximizeBox = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Mission selectedMission = (Mission)this.comboBoxRemoveMission.SelectedItem;
            string nameToRemove = selectedMission.Type.ToString();

            if (string.IsNullOrEmpty(nameToRemove))
            {
                MessageBox.Show("please enter a name.");
                return;
            }

            bool success = AppState.CurrentDeployment.Missions.Remove(selectedMission);

            if (success)
            {
                MessageBox.Show("Mission removed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mission not found.");
            }
        }
    }
}
