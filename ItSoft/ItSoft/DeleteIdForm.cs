using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class IDDeleteForm : Form
    {
        public IDDeleteForm()
        {
            InitializeComponent();
            string egn = idToDelete.Text;

            //string[] lineOfContents = File.ReadAllLines("employees.txt");
            //foreach (var line in lineOfContents)
            //{
            //    string[] tokens = line.Split('%');
            //    if (tokens.Length >= 1)
            //        comboBox1.Items.Add(tokens[0]);
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void IDDelete_Click(object sender, System.EventArgs e)
        {
            
            string idDelete = idToDelete.Text;
            if (idDelete.Length <= 3)
            {
                MessageBox.Show("ЕГН-то, което въведохте е прекалено кратко!");
                return;
            }

            StreamReader sr = new StreamReader("employees.txt");
            string allData = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter("employees.txt", false);
            string[] employeesData = allData.Split('\n');
            bool isMatch = false;

            foreach (var data in employeesData)
            {
                string[] employee = data.Split('%');

                if (employee[0] != idDelete)
                {
                    sw.WriteLine(data);
                }
                else
                {
                    isMatch = true;
                }
            }

            sw.Close();
            if (isMatch)
            {
                MessageBox.Show("Вие успешно премахнахте служител с ЕГН: " + idDelete);
            }
            else
            {
                MessageBox.Show("Служител с ЕГН: " + idDelete + " не е открит!");
            }
            
        }

        private void IDDeleteForm_Load(object sender, System.EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}