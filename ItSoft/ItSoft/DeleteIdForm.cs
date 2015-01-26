using System.IO;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class IDDeleteForm : Form
    {
        public IDDeleteForm()
        {
            InitializeComponent();
            string egn = idToDelete.Text;
        }

        public void EmployerrDelete()
        {
            string idDelete = idToDelete.Text;
            if (idDelete.Length <= 3)
            {
                MessageBox.Show("ЕГН-то, което въведохте е прекалено кратко!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Вие успешно премахнахте служител с ЕГН: " + idDelete, "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Служител с ЕГН: " + idDelete + " не е открит!", "Предупреждение ИТСофт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void IDDelete_Click(object sender, System.EventArgs e)
        {
            EmployerrDelete();
        }

        private void IDDeleteForm_Load(object sender, System.EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void idToDelete_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AuthorForm formAut = new AuthorForm();
            formAut.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            EmployerrDelete();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void InfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void EmployeerInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            EmployeeInfo emploInfo = new EmployeeInfo();
            emploInfo.Show();
        }
    }
}