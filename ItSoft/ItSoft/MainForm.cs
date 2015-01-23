using System;
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

        private void EmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmpInf = new EmployeeInfo();
            EmpInf.ShowDialog();
        }

        private void ProductInfo_Click(object sender, EventArgs e)
        {
            SoftwareForm SoftForm = new SoftwareForm();
            SoftForm.ShowDialog();
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            IDDeleteForm IDRemove = new IDDeleteForm();
            IDRemove.ShowDialog();
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
            AuthorForm authors = new AuthorForm();
            authors.ShowDialog();
        }

        private void ChangeSalary_Click(object sender, EventArgs e)
        {
        }

        private void License_Click(object sender, EventArgs e)
        {
        }
    }
}