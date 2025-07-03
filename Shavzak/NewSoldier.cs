using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shavzak.Logic.Validation;
using static Shavzak.Logic.Constraint;
using static Shavzak.Soldier;


namespace Shavzak
{
    public partial class NewSoldier : BaseForm
    {
        public NewSoldier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;

            if(!nameValid(fullName)) return;

            Role selectedRole = (Role)comboBox1.SelectedItem;
            ConstraintType selectedConstraint = (ConstraintType)comboBox2.SelectedItem;
            PlatoonNumber PlatoonNum = (PlatoonNumber)comboBox3.SelectedItem;

            Soldier newSoldier = new Soldier(fullName, selectedRole, selectedConstraint, PlatoonNum);

            MessageBox.Show($"Created soldier:\nName: {newSoldier.FullName}\nRole: {newSoldier.SoldierRole}\nConstraint: {newSoldier.Constraint} \n Platoon Number: {newSoldier.PlatoonNum}");
            AppState.CurrentDeployment.Company.AddSoldier(newSoldier);

            this.Close();
        }

        private bool nameValid(string fullName)
        {
            bool valid = true;

            if (!FullNameValidation(fullName, out string error))
            {
                MessageBox.Show(error, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }

            bool nameExists = AppState.CurrentDeployment.Company.GetSoldiers()
                .Any(s => s.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase));

            if (nameExists)
            {
                MessageBox.Show("A soldier with this name already exists. Please enter a unique name.",
                    "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }

            return valid;
        }

        private void NewSoldier_Load(object sender, EventArgs e)
        {

        }
    }
}
