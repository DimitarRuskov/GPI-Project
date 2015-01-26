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

        private void departmentText_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton_Click();
        }

        public void saveButton_Click()
        {
             if (!validateFields())
            {
                return;    
            }

            string egn = egnText.Text;
            string name = nameText.Text;
            string middleName = middleNameText.Text;
            string familyName = familyNameText.Text;
            string profession = professionText.Text;
            string department = departmentText.Text;
            var payment = paymentText.Text;
            string dateStart = dateTimePicker1.Text;

            const string sPath = "employees.txt";

            string employee = egn + "%" + name + "%" + middleName + "%" + familyName + "%" + profession + "%" + department + "%" + payment + "%" + dateStart;
            TextWriter tw = new StreamWriter(sPath, true);
            tw.WriteLine(employee);
            tw.Close();

            MessageBox.Show("Служителят записан успешно!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validateFields()
        {
            if (nameText.Text.Length <= 2)
            {
                MessageBox.Show("Стойността на полето 'Име' е под минималната дължина! Моля коригирайте!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (middleNameText.Text.Length <= 2)
            {
                MessageBox.Show("Стойността на полето 'Презиме' е под минималната дължина! Моля коригирайте!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (familyNameText.Text.Length <= 2)
            {
                MessageBox.Show("Стойността на полето 'Фамилия' е под минималната дължина! Моля коригирайте!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (egnText.Text.Length != 10)
            {
                MessageBox.Show("Стойността на полето 'ЕГН' трябва да бъде точно 10 символа! Моля коригирайте!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (paymentText.Text.Length < 1)
            {
                MessageBox.Show("Моля попълнете полето със стойност 'Заплата'!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if(Double.Parse(paymentText.Text) < 350)
            {
                MessageBox.Show("Минималната заплата е 350лв!", "Предупреждение ИТСофт", MessageBoxButtons.OK,MessageBoxIcon.Information);

                return false;
            }
            if (professionText.Text.Length <= 0)
            {
                MessageBox.Show("Моля изберете длъжност!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (departmentText.Text.Length <= 0)
            {
                MessageBox.Show("Моля изберете отдел!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void egnText_TextChanged(object sender, EventArgs e)
        {
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
                MessageBox.Show("Въведете коректни стойности за поле 'Заплата'", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxDateOfStart_TextChanged(object sender, EventArgs e)
        {
        }

        private void startDateText_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void ID_Click(object sender, EventArgs e)
        {
        }

        private void middleNameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void familyNameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void egnText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
        }

        private void nameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Моля въведи коректни символи !", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameText.Clear();
            }
            

        }

        private void middleNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Моля въведи коректни символи !", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                middleNameText.Clear();
            }
        }

        private void familyNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Моля въведи коректни символи !", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familyNameText.Clear();
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInfo empinf = new EmployeeInfo();
            empinf.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDDeleteForm delEmplo = new IDDeleteForm();
            delEmplo.Show();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm autfrm = new AuthorForm();
            autfrm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareForm softFrm = new SoftwareForm();
            softFrm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveButton_Click();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewEmplo newEmp = new FormNewEmplo();
            newEmp.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
    }
}