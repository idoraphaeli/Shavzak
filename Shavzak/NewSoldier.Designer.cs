using System.Drawing;

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
            this.Text = "Add New Soldier";
            this.AddNewSoldierTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewSoldierTitle
            // 
            this.AddNewSoldierTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewSoldierTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.AddNewSoldierTitle.Location = new System.Drawing.Point(0, 0);
            this.AddNewSoldierTitle.Name = "AddNewSoldierTitle";
            this.AddNewSoldierTitle.TabIndex = 0;
            this.AddNewSoldierTitle.Text = "Add New Soldier";
            this.AddNewSoldierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNewSoldierTitle.Resize += new System.EventHandler(this.NewSoldier_Resize);
            this.Controls.Add(this.AddNewSoldierTitle);
            // 
            // NewSoldier
            // 
            this.Name = "NewSoldier";
            this.Load += new System.EventHandler(this.NewSoldier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AddNewSoldierTitle;
        private System.Windows.Forms.PictureBox picSoldier;
        private System.Windows.Forms.Label label2;
    }
}