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
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "ЕГН";
            dataGridView1.Columns[1].Name = "Име";
            dataGridView1.Columns[2].Name = "Презиме";
            dataGridView1.Columns[3].Name = "Фамилия";
            dataGridView1.Columns[4].Name = "Професия";
            dataGridView1.Columns[5].Name = "Отдел";
            dataGridView1.Columns[6].Name = "Заплата";
            dataGridView1.Columns[7].Name = "Дата на постъпване";

            StreamReader sr = new StreamReader("employees.txt");
            string allData = sr.ReadToEnd();
            string[] employeesData = allData.Split('\n');
            foreach (var data in employeesData)
            {
                string[] employee = data.Split('%');
                dataGridView1.Rows.Add(employee);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
