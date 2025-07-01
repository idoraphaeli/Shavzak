namespace Shavzak
{
    partial class RemoveMission
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
            this.RemoveMissionTitle = new System.Windows.Forms.Label();
            this.labelSelectMission = new System.Windows.Forms.Label();
            this.comboBoxRemoveMission = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveMissionTitle
            // 
            this.RemoveMissionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveMissionTitle.AutoSize = true;
            this.RemoveMissionTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMissionTitle.Location = new System.Drawing.Point(150, 15);
            this.RemoveMissionTitle.Name = "RemoveMissionTitle";
            this.RemoveMissionTitle.Size = new System.Drawing.Size(257, 34);
            this.RemoveMissionTitle.TabIndex = 0;
            this.RemoveMissionTitle.Text = "Remove Mission";
            this.RemoveMissionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectMission
            // 
            this.labelSelectMission.AutoSize = true;
            this.labelSelectMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectMission.Location = new System.Drawing.Point(210, 70);
            this.labelSelectMission.Name = "labelSelectMission";
            this.labelSelectMission.Size = new System.Drawing.Size(145, 25);
            this.labelSelectMission.TabIndex = 1;
            this.labelSelectMission.Text = "Select Mission:";
            // 
            // comboBoxRemoveMission
            // 
            this.comboBoxRemoveMission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRemoveMission.FormattingEnabled = true;
            this.comboBoxRemoveMission.Location = new System.Drawing.Point(182, 126);
            this.comboBoxRemoveMission.Name = "comboBoxRemoveMission";
            this.comboBoxRemoveMission.Size = new System.Drawing.Size(300, 24);
            this.comboBoxRemoveMission.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRemove.Location = new System.Drawing.Point(200, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.comboBoxRemoveMission);
            this.Controls.Add(this.labelSelectMission);
            this.Controls.Add(this.RemoveMissionTitle);
            this.Name = "RemoveMission";
            this.Text = "RemoveMission";
            this.Load += new System.EventHandler(this.RemoveMission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemoveMissionTitle;
        private System.Windows.Forms.Label labelSelectMission;
        private System.Windows.Forms.ComboBox comboBoxRemoveMission;
        private System.Windows.Forms.Button btnRemove;
    }
}