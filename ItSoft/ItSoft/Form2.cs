using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //professionText.Items.Add("QA инженер");
            //professionText.Items.Add("стажант");
            //professionText.Items.Add("системен администратор");
            //professionText.Items.Add("Java програмист");
            //professionText.Items.Add("Web програмист");
            //professionText.Items.Add("Android програмист");
            //professionText.Items.Add("Java програмист");
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

        private void textBoxDateOfStart_TextChanged(object sender, EventArgs e)
        {
            var picker = new DateTimePicker();
            Form f = new Form();
            f.Controls.Add(picker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void egnText_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                int EGN; 
                EGN= int.Parse(egnText.Text);

            }
            catch (FormatException)
            {

                MessageBox.Show("Въведете коректно ЕГН");
                egnText.Clear();
            }
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
            try
            {
                string name;
                name = nameText.Text;

            }
            catch (FormatException)
            {

                MessageBox.Show("Въведете коректно ИМЕ !");
            }
        }
    }
}
