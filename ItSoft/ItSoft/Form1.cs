using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void новСлужителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewEmplo f1 = new FormNewEmplo();
            f1.ShowDialog();
        }

        private void изходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
