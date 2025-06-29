using System;
using static Shavzak.Soldier;
using static Shavzak.Logic.Constraint;


namespace Shavzak
{
    partial class NewSoldier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewSoldierTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddNewSoldierTitle
            // 
            this.AddNewSoldierTitle.AutoSize = true;
            this.AddNewSoldierTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewSoldierTitle.Location = new System.Drawing.Point(200, 50);
            this.AddNewSoldierTitle.Name = "AddNewSoldierTitle";
            this.AddNewSoldierTitle.Size = new System.Drawing.Size(264, 34);
            this.AddNewSoldierTitle.TabIndex = 0;
            this.AddNewSoldierTitle.Text = "Add New Soldier";
            this.AddNewSoldierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Constraints:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(320, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 32);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = new Shavzak.Soldier.Role[] {
            Shavzak.Soldier.Role.Fighter,
            Shavzak.Soldier.Role.Medic,
            Shavzak.Soldier.Role.Driver,
            Shavzak.Soldier.Role.Squad_Commander,
            Shavzak.Soldier.Role.Sergeant,
            Shavzak.Soldier.Role.Platoon_Commander,
            Shavzak.Soldier.Role.Deputy_Logistics_Sergeant,
            Shavzak.Soldier.Role.Logistics_Sergeant,
            Shavzak.Soldier.Role.Deputy_Company_Commander,
            Shavzak.Soldier.Role.Company_Commander};
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = new Shavzak.Logic.Constraint.ConstraintType[] {
            Shavzak.Logic.Constraint.ConstraintType.None,
            Shavzak.Logic.Constraint.ConstraintType.No_Kitchen,
            Shavzak.Logic.Constraint.ConstraintType.Static_Only};
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(320, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(220, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Soldier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Platoon Number:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = new Shavzak.Soldier.PlatoonNumber[] {
            Shavzak.Soldier.PlatoonNumber.One,
            Shavzak.Soldier.PlatoonNumber.Two,
            Shavzak.Soldier.PlatoonNumber.Three,
            Shavzak.Soldier.PlatoonNumber.Headquarters};
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(320, 335);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // NewSoldier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 545);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewSoldierTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "NewSoldier";
            this.Text = "Add New Soldier";
            this.Load += new System.EventHandler(this.NewSoldier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewSoldierTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}