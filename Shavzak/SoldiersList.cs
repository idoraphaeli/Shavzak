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
    public partial class SoldiersList : BaseForm
    {
        public SoldiersList()
        {
            InitializeComponent();
        }

        private void DisplaySoldiers()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Index", "#");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Role", "Role");
            dataGridView1.Columns.Add("Platoon", "Platoon");
            dataGridView1.Columns.Add("Constraint", "Constraint");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            List<Soldier> soldiers = AppState.CurrentDeployment.Company.GetSoldiers();

            int index = 1;
            foreach (Soldier soldier in soldiers)
            {
                dataGridView1.Rows.Add(
                    index++,
                    soldier.FullName,
                    soldier.SoldierRole.ToString().Replace('_', ' '),
                    soldier.PlatoonNum.ToString().Replace('_', ' '),
                    soldier.Constraint.ToString().Replace('_', ' ')
                );
            }
        }

        private void SoldiersList_Load(object sender, EventArgs e)
        {
            DisplaySoldiers();
        }

    }
}
