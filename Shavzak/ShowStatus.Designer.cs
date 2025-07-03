namespace Shavzak
{
    partial class ShowStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.AllowUserToAddRows = false;
            this.dataGridViewStatus.AllowUserToDeleteRows = false;
            this.dataGridViewStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStatus.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.RowHeadersWidth = 51;
            this.dataGridViewStatus.RowTemplate.Height = 24;
            this.dataGridViewStatus.Size = new System.Drawing.Size(664, 545);
            this.dataGridViewStatus.TabIndex = 0;
            // 
            // ShowStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 545);
            this.Controls.Add(this.dataGridViewStatus);
            this.Name = "ShowStatus";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.ShowStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatus;
    }
}