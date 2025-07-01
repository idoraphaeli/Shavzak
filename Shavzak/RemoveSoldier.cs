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
    public partial class RemoveSoldier : BaseForm
    {
        public RemoveSoldier()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void RemoveSoldier_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(450, 300);
            this.Size = this.MinimumSize;
            this.comboBoxRemoveSoldier.DataSource = null;
            this.comboBoxRemoveSoldier.DataSource = AppState.CurrentDeployment.Company.GetSoldiers();
            this.MaximizeBox = false;
        }

        private void RemoveSoldierBtn_Click(object sender, EventArgs e)
        {
            Soldier selectedSoldier = (Soldier)this.comboBoxRemoveSoldier.SelectedItem;
            string nameToRemove = selectedSoldier.FullName;

            if (string.IsNullOrEmpty(nameToRemove))
            {
                MessageBox.Show("please enter a name.");
                return;
            }

            bool success = AppState.CurrentDeployment.Company.RemoveSoldierByName(nameToRemove);

            if (success)
            {
                MessageBox.Show("Soldier removed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Soldier not found.");
            }
        }
    }
}
