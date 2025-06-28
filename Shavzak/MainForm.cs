using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shavzak
{
    public partial class MainForm : Form
    {
        private Soldier currentSoldier;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = new Icon("soldier-icon.ico");
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Shavzak";
            Image defaultImage = Properties.Resources.soldier_icon;
            picSoldier.Image = CreateCircularImage(defaultImage);
            picSoldier.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private Image CreateCircularImage(Image original)
        {
            Bitmap circularImage = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(circularImage))
            {
                using (Brush brush = new TextureBrush(original))
                {
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, original.Width, original.Height);
                    g.FillPath(brush, path);
                }
            }
            return circularImage;
        }

        private void picSoldier_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
