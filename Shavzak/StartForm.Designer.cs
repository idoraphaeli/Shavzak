using System.Windows.Forms;

namespace Shavzak
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnSoldiers = new System.Windows.Forms.Button();
            this.SoldierOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSoldiersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSoldierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSoldierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMissions = new System.Windows.Forms.Button();
            this.btnBuildShavzak = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.MissionOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMissionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoldiersPhoto = new System.Windows.Forms.PictureBox();
            this.SoldierOptions.SuspendLayout();
            this.MissionOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoldiersPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoldiers
            // 
            this.btnSoldiers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoldiers.ContextMenuStrip = this.SoldierOptions;
            this.btnSoldiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSoldiers.Location = new System.Drawing.Point(110, 273);
            this.btnSoldiers.Name = "btnSoldiers";
            this.btnSoldiers.Size = new System.Drawing.Size(464, 50);
            this.btnSoldiers.TabIndex = 0;
            this.btnSoldiers.Text = "Soldiers";
            this.btnSoldiers.UseVisualStyleBackColor = true;
            this.btnSoldiers.Click += new System.EventHandler(this.btnSoldiers_Click);
            // 
            // SoldierOptions
            // 
            this.SoldierOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SoldierOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSoldiersListToolStripMenuItem,
            this.addNewSoldierToolStripMenuItem,
            this.removeSoldierToolStripMenuItem});
            this.SoldierOptions.Name = "contextMenuStrip1";
            this.SoldierOptions.Size = new System.Drawing.Size(198, 76);
            this.SoldierOptions.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showSoldiersListToolStripMenuItem
            // 
            this.showSoldiersListToolStripMenuItem.AutoSize = false;
            this.showSoldiersListToolStripMenuItem.Name = "showSoldiersListToolStripMenuItem";
            this.showSoldiersListToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showSoldiersListToolStripMenuItem.Text = "Show Soldiers List";
            this.showSoldiersListToolStripMenuItem.Click += new System.EventHandler(this.showSoldiersListToolStripMenuItem_Click);
            // 
            // addNewSoldierToolStripMenuItem
            // 
            this.addNewSoldierToolStripMenuItem.AutoSize = false;
            this.addNewSoldierToolStripMenuItem.Name = "addNewSoldierToolStripMenuItem";
            this.addNewSoldierToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewSoldierToolStripMenuItem.Text = "Add New Soldier";
            this.addNewSoldierToolStripMenuItem.Click += new System.EventHandler(this.addNewSoldierToolStripMenuItem_Click);
            // 
            // removeSoldierToolStripMenuItem
            // 
            this.removeSoldierToolStripMenuItem.AutoSize = false;
            this.removeSoldierToolStripMenuItem.Name = "removeSoldierToolStripMenuItem";
            this.removeSoldierToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeSoldierToolStripMenuItem.Text = "Remove Soldier";
            this.removeSoldierToolStripMenuItem.Click += new System.EventHandler(this.removeSoldierToolStripMenuItem_Click);
            // 
            // btnMissions
            // 
            this.btnMissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMissions.Location = new System.Drawing.Point(110, 341);
            this.btnMissions.Name = "btnMissions";
            this.btnMissions.Size = new System.Drawing.Size(464, 50);
            this.btnMissions.TabIndex = 1;
            this.btnMissions.Text = "Missions";
            this.btnMissions.UseVisualStyleBackColor = true;
            this.btnMissions.Click += new System.EventHandler(this.btnMissions_Click);
            // 
            // btnBuildShavzak
            // 
            this.btnBuildShavzak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildShavzak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBuildShavzak.Location = new System.Drawing.Point(110, 204);
            this.btnBuildShavzak.Name = "btnBuildShavzak";
            this.btnBuildShavzak.Size = new System.Drawing.Size(464, 50);
            this.btnBuildShavzak.TabIndex = 2;
            this.btnBuildShavzak.Text = "Build Shavzak!";
            this.btnBuildShavzak.UseVisualStyleBackColor = true;
            this.btnBuildShavzak.Resize += new System.EventHandler(this.StartForm_Resize);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDownload.Location = new System.Drawing.Point(110, 419);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(464, 50);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download Status";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // MissionOptions
            // 
            this.MissionOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MissionOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMissionsListToolStripMenuItem,
            this.addNewMissionToolStripMenuItem,
            this.removeMissionToolStripMenuItem});
            this.MissionOptions.Name = "MissionOptions";
            this.MissionOptions.Size = new System.Drawing.Size(201, 76);
            this.MissionOptions.Opening += new System.ComponentModel.CancelEventHandler(this.missionOption_Opening);
            // 
            // showMissionsListToolStripMenuItem
            // 
            this.showMissionsListToolStripMenuItem.Name = "showMissionsListToolStripMenuItem";
            this.showMissionsListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.showMissionsListToolStripMenuItem.Text = "Show Missions List";
            this.showMissionsListToolStripMenuItem.Click += new System.EventHandler(this.showMissionsListToolStripMenuItem_Click);
            // 
            // addNewMissionToolStripMenuItem
            // 
            this.addNewMissionToolStripMenuItem.Name = "addNewMissionToolStripMenuItem";
            this.addNewMissionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.addNewMissionToolStripMenuItem.Text = "Add New Mission";
            this.addNewMissionToolStripMenuItem.Click += new System.EventHandler(this.addNewMissionToolStripMenuItem_Click);
            // 
            // removeMissionToolStripMenuItem
            // 
            this.removeMissionToolStripMenuItem.Name = "removeMissionToolStripMenuItem";
            this.removeMissionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.removeMissionToolStripMenuItem.Text = "Remove Mission";
            this.removeMissionToolStripMenuItem.Click += new System.EventHandler(this.removeMissionToolStripMenuItem_Click);
            // 
            // SoldiersPhoto
            // 
            this.SoldiersPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoldiersPhoto.Image = ((System.Drawing.Image)(resources.GetObject("SoldiersPhoto.Image")));
            this.SoldiersPhoto.Location = new System.Drawing.Point(0, 29);
            this.SoldiersPhoto.Name = "SoldiersPhoto";
            this.SoldiersPhoto.Size = new System.Drawing.Size(663, 220);
            this.SoldiersPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoldiersPhoto.TabIndex = 5;
            this.SoldiersPhoto.TabStop = false;
            this.SoldiersPhoto.Click += new System.EventHandler(this.SoldiersPhoto_Click);
            this.SoldiersPhoto.Resize += new System.EventHandler(this.SoldiersPhoto_Resize);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 545);
            this.Controls.Add(this.SoldiersPhoto);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBuildShavzak);
            this.Controls.Add(this.btnMissions);
            this.Controls.Add(this.btnSoldiers);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.startForm_Load);
            this.Resize += new System.EventHandler(this.StartForm_Resize);
            this.SoldierOptions.ResumeLayout(false);
            this.MissionOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoldiersPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoldiers;
        private System.Windows.Forms.Button btnMissions;
        private System.Windows.Forms.Button btnBuildShavzak;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ContextMenuStrip SoldierOptions;
        private System.Windows.Forms.ToolStripMenuItem showSoldiersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSoldierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSoldierToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MissionOptions;
        private System.Windows.Forms.ToolStripMenuItem showMissionsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMissionToolStripMenuItem;
        private System.Windows.Forms.PictureBox SoldiersPhoto;
    }
}