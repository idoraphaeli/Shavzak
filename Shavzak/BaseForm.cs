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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = new Icon("soldier-icon.ico");
            this.Size = new Size(682, 592);
            this.MinimumSize = new Size(682, 592);
            this.Size = this.MinimumSize;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
