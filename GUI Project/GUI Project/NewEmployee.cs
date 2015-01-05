using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
            professionText.Items.Add("QA инженер");
            professionText.Items.Add("стажант");
            professionText.Items.Add("системен администратор");
            professionText.Items.Add("Java програмист");
            professionText.Items.Add("Web програмист");
            professionText.Items.Add("Android програмист");
            professionText.Items.Add("Java програмист");

            departmentText.Items.Add("качество по кода");
            departmentText.Items.Add("техническа поддръжка");
            departmentText.Items.Add("мениджмънт");
            departmentText.Items.Add("IT разработка");
            departmentText.Items.Add("UNIT тестване");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string egn = egnText.Text;
            string name = nameText.Text;
            string middleName = middleNameText.Text;
            string familyName = familyNameText.Text;
            string profession = professionText.Text;
            string department = departmentText.Text;
            string payment = paymentText.Text;
            string date = startDateText.SelectionRange.Start.ToString();

            const string sPath = "employees.txt";

            string employee = egn + "%" + name + "%" + middleName + "%" + familyName + "%" + profession + "%" + department + "%" + payment + "%" + date;
            //File.AppendAllText(sPath, employee);
            TextWriter tw = new StreamWriter(sPath, true);
            tw.WriteLine(employee);
            tw.Close();
            

            //SaveFile.Close();

            MessageBox.Show("Employee saved!");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void startDateText_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

    }
}
