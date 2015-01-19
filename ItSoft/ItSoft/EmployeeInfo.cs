using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
            ReadFromFile();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void ReadFromFile()
        {
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            DataTable employeer = new DataTable("Employeer");

            employeer.Columns.Add(new DataColumn("ЕГН", typeof(long)));
            employeer.Columns.Add(new DataColumn("Име", typeof(string)));
            employeer.Columns.Add(new DataColumn("Презиме", typeof(string)));
            employeer.Columns.Add(new DataColumn("Фамилия", typeof(string)));
            employeer.Columns.Add(new DataColumn("Професия", typeof(string)));
            employeer.Columns.Add(new DataColumn("Отдел", typeof(string)));
            employeer.Columns.Add(new DataColumn("Заплата", typeof(int)));
            employeer.Columns.Add(new DataColumn("Дата на постъпване", typeof(int)));

            DataSet ds = new DataSet();
            ds.Tables.Add(employeer);

            StreamReader sr = new StreamReader("employees.txt");
            string allData = sr.ReadToEnd();
            string[] employeesData = allData.Split('\n');
            foreach (var data in employeesData)
            {
                string[] employee = data.Split('%');
                dataGridView1.Rows.Add(employee);
            }
            //deleting empty rows from Datagrid after loading text file
            for (int i = 1; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }
            }

            sr.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //  const string sPath = "employees.txt";
            //This line of code creates a text file for the data export.

            StreamWriter file = new StreamWriter("employees.txt", false);
            try
            {
                string Line = "";
                var Rows = dataGridView1.Rows.Count;
                var Columns = dataGridView1.Columns.Count;
                for (int i = 0; i <= Rows - 1; i++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int j = 0; j <= Columns - 1; j++)
                    {
                        Line = Line + dataGridView1.Rows[i].Cells[j].Value;
                        if (j != Columns - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            Line = Line + "%";
                        }
                    }
                    file.WriteLine(Line);
                    Line = "";
                }
                file.Close();
                System.Windows.Forms.MessageBox.Show("Промените са записани успешно.", "ИТСофт Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}