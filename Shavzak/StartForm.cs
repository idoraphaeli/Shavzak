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
    public partial class StartForm : BaseForm
    {
        public StartForm()
        {
            InitializeComponent();
            Text = "Shavzak";
            this.Icon = new Icon("soldier-icon.ico");
        }

        private void StartForm_Resize(object sender, EventArgs e)
        {
            int btnSpace = 12; // Space between buttons
            int btnNum = 4; // Number of buttons

            btnBuildShavzak.Left = (this.ClientSize.Width - btnBuildShavzak.Width) / 2;
            btnBuildShavzak.Top = (this.ClientSize.Height - btnBuildShavzak.Height) / 2;
            btnBuildShavzak.Height = (this.ClientSize.Height - btnBuildShavzak.Top - btnNum * btnSpace)/ btnNum;
            btnBuildShavzak.Width = (int)(this.ClientSize.Width * 0.7);

            btnMissions.Left = btnBuildShavzak.Left;
            btnMissions.Top = btnBuildShavzak.Top + btnBuildShavzak.Height + btnSpace;
            btnMissions.Height = btnBuildShavzak.Height;
            btnMissions.Width = btnBuildShavzak.Width;

            btnSoldiers.Left = btnBuildShavzak.Left;
            btnSoldiers.Top = btnBuildShavzak.Top + (btnBuildShavzak.Height + btnSpace) * 2;
            btnSoldiers.Height = btnBuildShavzak.Height;
            btnSoldiers.Width = btnBuildShavzak.Width;

            btnDownload.Left = btnBuildShavzak.Left;
            btnDownload.Top = btnBuildShavzak.Top + (btnBuildShavzak.Height + btnSpace) * 3;
            btnDownload.Height = btnBuildShavzak.Height;
            btnDownload.Width = btnBuildShavzak.Width;
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            this.StartForm_Resize(sender, e);
        }

        private void btnSoldiers_Click(object sender, EventArgs e)
        {
            int desiredWidth = btnSoldiers.Width;

            foreach (ToolStripItem item in SoldierOptions.Items)
            {
                item.AutoSize = false;
                item.Width = desiredWidth;
            }

            SoldierOptions.Show(btnSoldiers, new Point(0, btnSoldiers.Height));
        }

        private void addNewSoldierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewSoldier();
            form.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            SoldierOptions.AutoSize = false;
            SoldierOptions.Width = btnSoldiers.Width;

            foreach (ToolStripItem item in SoldierOptions.Items)
            {
                item.AutoSize = false;
                item.Width = SoldierOptions.Width;
                item.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void missionOption_Opening(object sender, CancelEventArgs e)
        {
            MissionOptions.AutoSize = false;
            MissionOptions.Width = btnSoldiers.Width;

            foreach (ToolStripItem item in MissionOptions.Items)
            {
                item.AutoSize = false;
                item.Width = MissionOptions.Width;
                item.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MissionOptions_Opening(object sender, CancelEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMissions_Click(object sender, EventArgs e)
        {
            int desiredWidth = btnMissions.Width;

            foreach (ToolStripItem item in MissionOptions.Items)
            {
                item.AutoSize = false;
                item.Width = desiredWidth;
            }

            MissionOptions.Show(btnMissions, new Point(0, btnMissions.Height));
        }

        private void SoldiersPhoto_Click(object sender, EventArgs e)
        {

        }

        private void SoldiersPhoto_Resize(object sender, EventArgs e)
        {
            SoldiersPhoto.Width = this.ClientSize.Width;
            SoldiersPhoto.Height = (int)(this.ClientSize.Height / 2.9);
            SoldiersPhoto.Left = 0;
            SoldiersPhoto.Top = 30;
        }

        private void showMissionsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentDeployment.Missions.Count == 0)
            {
                MessageBox.Show("No missions available. Please add missions first.");
                return;
            }
            MissionList missionList = new MissionList();
            missionList.ShowDialog(this);
        }

        private void showSoldiersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AppState.CurrentDeployment.Company.GetSoldiers().Count == 0)
            {
                MessageBox.Show("No soldiers available. Please add soldiers first.");
                return;
            }
            SoldiersList soldierList = new SoldiersList();
            soldierList.ShowDialog(this);
        }

        private void removeSoldierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentDeployment.Company.GetSoldiers().Count == 0)
            {
                MessageBox.Show("No soldiers available to remove. Please add soldiers first.");
                return;
            }
            RemoveSoldier removeSoldier = new RemoveSoldier();
            removeSoldier.ShowDialog(this);
        }

        private void searchSoldierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentDeployment.Company.GetSoldiers().Count == 0)
            {
                MessageBox.Show("No soldiers available to remove. Please add soldiers first.");
                return;
            }
            RemoveSoldier removeSoldier = new RemoveSoldier();
            removeSoldier.ShowDialog(this);
        }

        private void addNewMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMission newMission = new NewMission();
            newMission.ShowDialog(this);
        }

        private void removeMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentDeployment.Missions.Count == 0)
            {
                MessageBox.Show("No missions available to remove. Please add missions first.");
                return;
            }
            RemoveMission removeMission = new RemoveMission();
            removeMission.ShowDialog(this);
        }

        private void btnBuildShavzak_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentDeployment.Missions.Count == 0)
            {
                MessageBox.Show("No missions available. Please add missions first.");
                return;
            }
            else if (AppState.CurrentDeployment.Company.GetSoldiers().Count == 0)
            {
                MessageBox.Show("No soldiers available. Please add soldiers first.");
                return;
            }
            else
            {
                ShavzakOutput shavzakOutput = new ShavzakOutput();
                shavzakOutput.ShowDialog(this);
            }
        }
    }
}
