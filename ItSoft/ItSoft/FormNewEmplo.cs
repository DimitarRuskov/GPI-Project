using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class FormNewEmplo : Form
    {
        public FormNewEmplo()
        {
            InitializeComponent();
        }

        private void professionText_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void departmentText_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
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
            var payment = paymentText.Text;
            //string dateStart = textBoxDateOfStart.Text;
            string dateStart = dateTimePicker1.Text;

            const string sPath = "employees.txt";

            string employee = egn + "%" + name + "%" + middleName + "%" + familyName + "%" + profession + "%" + department + "%" + payment + "%" + dateStart;
            TextWriter tw = new StreamWriter(sPath, true);
            tw.WriteLine(employee);
            tw.Close();

            MessageBox.Show("Служителят записан успешно!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void egnText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long EGN;
                EGN = long.Parse(egnText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Въведете коректно ЕГН");
            }
            //egnText.Clear();
        }

        private void paymentText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Payment;
                Payment = int.Parse(paymentText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Въведете коректни стойности");
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(nameText.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Моля въведете само позволени символи");
                // nameText.Text.Remove(nameText.Text.Length - 1);
            }
        }

        private void textBoxDateOfStart_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void startDateText_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void ID_Click(object sender, EventArgs e)
        {
        }

        private void nameText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void middleNameText_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(middleNameText.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Моля въведете само позволени символи");
            }
        }

        private void familyNameText_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(familyNameText.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Моля въведете само позволени символи");
            }
        }
    }
}