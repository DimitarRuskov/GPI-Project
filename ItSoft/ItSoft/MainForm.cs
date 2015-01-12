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

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            FormNewEmplo f1 = new FormNewEmplo();
            f1.ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void авториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authors = new AuthorForm();
            authors.ShowDialog();
        }

        private void EmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmpInf = new EmployeeInfo();
            EmpInf.ShowDialog();
        }

        private void ProductInfo_Click(object sender, EventArgs e)
        {

        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void License_Click(object sender, EventArgs e)
        {

        }

        private void EditMenu_Click(object sender, EventArgs e)
        {

        }

        private void HomeMenu_Click(object sender, EventArgs e)
        {

        }

        private void ExportMenu_Click(object sender, EventArgs e)
        {

        }

        private void Authors_Click(object sender, EventArgs e)
        {

        }

        private void ChangeSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
