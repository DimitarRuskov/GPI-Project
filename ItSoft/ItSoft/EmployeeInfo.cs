using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ItSoft
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
            ReadFromFile();
        }

        public void ReadFromFile()
        {
        }

        private void addRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Add(this.dataGridView1.SelectedRows.Count);
            }
        }

        private void cutRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Insert(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void deleteRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
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
            employeer.Columns.Add(new DataColumn("Заплата*", typeof(int)));
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
            MessageBox.Show("Наистина ли искате да излезните от приложението", "Предупреждение ИТСофт", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton_Click();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton_Click();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveButton_Click();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Add(this.dataGridView1.SelectedRows.Count);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportButton_Click();
        }

        private void ExportButton_Click()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
            saveDlg.InitialDirectory = @"C:\";
            saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveDlg.FileName;
                xlWorkBook.SaveCopyAs(path);
                xlWorkBook.Saved = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
        }

        public void SaveButton_Click()
        {
            //Here is start creating file to Export.
            MessageBox.Show("Искате ли да запишите промените !", "Предупреждение ИТСофт", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            StreamWriter SaveFile = new StreamWriter("employees.txt", false);
            try
            {
                string Line = "";
                var Rows = dataGridView1.Rows.Count;
                var Columns = dataGridView1.Columns.Count;
                for (int i = 0; i <= Rows - 1; i++)
                {
                    //This  loop loops through each column, and row number
                    for (int j = 0; j <= Columns - 1; j++)
                    {
                        Line = Line + dataGridView1.Rows[i].Cells[j].Value;
                        if (j != Columns - 1)
                        {
                            //This is a char text delimiter !
                            Line = Line + "%";
                        }
                    }
                    SaveFile.WriteLine(Line);
                    Line = "";
                }
                SaveFile.Close();
                System.Windows.Forms.MessageBox.Show("Промените са записани успешно.", "ИТСофт Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaveFile.Close();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Insert(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authors = new AuthorForm();
            authors.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}