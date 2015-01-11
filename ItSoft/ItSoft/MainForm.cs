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
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void изходToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void авториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authors = new AuthorForm();
            authors.ShowDialog();
        }

        private void информацияЗаСлужителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmpInf = new EmployeeInfo();
            EmpInf.ShowDialog();
        }

        private void заПродуктаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
