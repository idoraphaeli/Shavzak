using System.Drawing;
using System.Windows.Forms;

namespace Shavzak
{
    partial class RemoveSoldier
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
            this.SelectSoldierToRemoveLable = new System.Windows.Forms.Label();
            this.RemoveSoldierBtn = new System.Windows.Forms.Button();
            this.comboBoxRemoveSoldier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddNewSoldierTitle
            // 
            this.AddNewSoldierTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewSoldierTitle.AutoSize = true;
            this.AddNewSoldierTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewSoldierTitle.Location = new System.Drawing.Point(150, 15);
            this.AddNewSoldierTitle.Name = "AddNewSoldierTitle";
            this.AddNewSoldierTitle.Size = new System.Drawing.Size(249, 34);
            this.AddNewSoldierTitle.TabIndex = 0;
            this.AddNewSoldierTitle.Text = "Remove Soldier";
            this.AddNewSoldierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectSoldierToRemoveLable
            // 
            this.SelectSoldierToRemoveLable.AutoSize = true;
            this.SelectSoldierToRemoveLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SelectSoldierToRemoveLable.Location = new System.Drawing.Point(210, 70);
            this.SelectSoldierToRemoveLable.Name = "SelectSoldierToRemoveLable";
            this.SelectSoldierToRemoveLable.Size = new System.Drawing.Size(139, 25);
            this.SelectSoldierToRemoveLable.TabIndex = 1;
            this.SelectSoldierToRemoveLable.Text = "Select Soldier:";
            // 
            // RemoveSoldierBtn
            // 
            this.RemoveSoldierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.RemoveSoldierBtn.Location = new System.Drawing.Point(200, 220);
            this.RemoveSoldierBtn.Name = "RemoveSoldierBtn";
            this.RemoveSoldierBtn.Size = new System.Drawing.Size(180, 65);
            this.RemoveSoldierBtn.TabIndex = 2;
            this.RemoveSoldierBtn.Text = "Remove";
            this.RemoveSoldierBtn.UseVisualStyleBackColor = true;
            this.RemoveSoldierBtn.Click += new System.EventHandler(this.RemoveSoldierBtn_Click);
            // 
            // comboBoxRemoveSoldier
            // 
            this.comboBoxRemoveSoldier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRemoveSoldier.FormattingEnabled = true;
            this.comboBoxRemoveSoldier.Location = new System.Drawing.Point(182, 126);
            this.comboBoxRemoveSoldier.Name = "comboBoxRemoveSoldier";
            this.comboBoxRemoveSoldier.Size = new System.Drawing.Size(300, 24);
            this.comboBoxRemoveSoldier.TabIndex = 3;
            // 
            // RemoveSoldier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.comboBoxRemoveSoldier);
            this.Controls.Add(this.RemoveSoldierBtn);
            this.Controls.Add(this.SelectSoldierToRemoveLable);
            this.Controls.Add(this.AddNewSoldierTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "RemoveSoldier";
            this.Text = "Remove Soldier";
            this.Load += new System.EventHandler(this.RemoveSoldier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewSoldierTitle;
        private System.Windows.Forms.Label SelectSoldierToRemoveLable;
        private System.Windows.Forms.Button RemoveSoldierBtn;
        private ComboBox comboBoxRemoveSoldier;
    }
}