using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoList
{
 
    public partial class Form1 : Form
    {
        // caminho do bd
        string path = "data_table.db";
        string cs = @"URI=file: " + Application.StartupPath + "\\data_table.db"; // criação do banco de dados
        Database db = new Database();

        string titleValue;
        string dateValue;
        string descriptionValue;
        string statusValue;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.createDB();
            db.dataShow(dataGridView1);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                dataGridView1.Rows[e.RowIndex].Selected = true;

                var selectedRow = dataGridView1.Rows[e.RowIndex];



                if (dataGridView1.Columns.Contains("Title") && selectedRow.Cells["Title"].Value != null)
                {
                    txtTitle.Text = selectedRow.Cells["Title"].FormattedValue.ToString();
                    titleValue = txtTitle.Text;
                }

                if (dataGridView1.Columns.Contains("Date") && selectedRow.Cells["Date"].Value != null)
                {
                    txtDate.Text = selectedRow.Cells["Date"].FormattedValue.ToString();
                    dateValue = txtDate.Text;
                }

                if (dataGridView1.Columns.Contains("Description") && selectedRow.Cells["Description"].Value != null)
                {
                    txtDescription.Text = selectedRow.Cells["Description"].FormattedValue.ToString();
                    descriptionValue = txtDescription.Text;
                }
                if (dataGridView1.Columns.Contains("Description") && selectedRow.Cells["Description"].Value != null)
                {
                    txtDescription.Text = selectedRow.Cells["Description"].FormattedValue.ToString();
                    descriptionValue = txtDescription.Text;
                }
                if (dataGridView1.Columns.Contains("Status") && selectedRow.Cells["Status"].Value != null)
                {
                    string statusC = selectedRow.Cells["Status"].FormattedValue.ToString();
                    statusValue = statusC;
                    if (statusC == "Done")
                    {
                        checkDone.Checked = true;
                    }
                    else
                    {
                        checkDone.Checked = false;
                    }
                }

            }
        }

        private string check()
        {
            if (checkDone.Checked)
            {
                return "Done";
            }
            else
            {
                return "Not done";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string date = txtDate.Text;
            string description = txtDescription.Text;
            string status = check();

            if (!title.Equals("") && !date.Equals("") && !description.Equals(""))
            {
                if (date.Length == 10 && IsValidDate(date))
                {
                    
                    db.insert(title, date, description, status);

                    try
                    {

                        if (dataGridView1.Columns.Count == 0)
                        {
                            dataGridView1.Columns.Add("Title", "Título");
                            dataGridView1.Columns.Add("Date", "Data");
                            dataGridView1.Columns.Add("Description", "Descrição");
                            dataGridView1.Columns.Add("Status", "Status");
                        }

                        
                        string[] row = new string[] { title, date, description, status };
                        dataGridView1.Rows.Add(row);

                        
                        txtTitle.Clear();
                        txtDate.Clear();
                        txtDescription.Clear();
                        txtTitle.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar a tarefa no grid." + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the date correctly");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields correctly.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string date = txtDate.Text;
            string description = txtDescription.Text;
            string status = check();
            int id = db.searchId(title, date, description, status);

            if (!title.Equals("") && !date.Equals("") && !description.Equals(""))
            {
                bool found = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow)
                    {
                        continue;
                    }

                    string titleValue = row.Cells["Title"].Value?.ToString();
                    string dateValue = row.Cells["Date"].Value?.ToString();
                    string descriptionValue = row.Cells["Description"].Value?.ToString();
                    string statusValue = row.Cells["Status"].Value?.ToString();

                    if (titleValue == title &&
                        dateValue == date &&
                        descriptionValue == description &&
                        statusValue == status)
                    {
                        found = true;
                        int rowIndex = row.Index;
                        dataGridView1.Rows.RemoveAt(rowIndex); 
                        db.remove(id,title, date, description, status);
                        txtTitle.Clear();
                        txtDate.Clear();
                        txtDescription.Clear();
                        checkDone.Checked = false;
                        break; 
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Row not found");
                }
            }
            else
            {
                MessageBox.Show("To remove a row, click on the corresponding line in the grid and press the remove button");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string date = txtDate.Text;
            string description = txtDescription.Text;

            if (!title.Equals("") && !date.Equals("") && !description.Equals(""))
            {
                string status = check();
                int id = db.searchId(titleValue, dateValue, descriptionValue, statusValue);
                db.update(id, title, date, description, status);
                dataGridView1.Rows.Clear();
                db.dataShow(dataGridView1); 
            }
            else
            {
                MessageBox.Show("To update a row, click on the corresponding line in the grid and press the update button");
            }


        }

        private void checkDone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtTitle.Text.Trim();
            string searchDate = txtDate.Text.Trim();

            if (string.IsNullOrEmpty(searchTitle) && string.IsNullOrEmpty(searchDate))
            {
                MessageBox.Show("Please enter a title or a date to search.");
                return; 
            }

            bool found = false; 

            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (dataGridView1.Columns.Contains("Title") &&
                    row.Cells["Title"].Value != null &&
                    row.Cells["Title"].FormattedValue.ToString().Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    found = true; 
                    break;
                }


                if (dataGridView1.Columns.Contains("Date") &&
                    row.Cells["Date"].Value != null &&
                    row.Cells["Date"].FormattedValue.ToString().Equals(searchDate, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    found = true; 
                    break; 
                }
            }


            if (!found)
            {
                MessageBox.Show("No match found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            string text = txtDate.Text.Replace("/", ""); 
            text = new string(text.Where(char.IsDigit).ToArray()); 

            if (text.Length > 8) text = text.Substring(0, 8); 

            if (text.Length > 4) text = text.Insert(4, "/");
            if (text.Length > 2) text = text.Insert(2, "/");

            txtDate.TextChanged -= txtDate_TextChanged; 
            txtDate.Text = text; 
            txtDate.TextChanged += txtDate_TextChanged;

            txtDate.SelectionStart = txtDate.Text.Length; 
        }
        private bool IsValidDate(string date)
        {
            string[] parts = date.Split('/');
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);

            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                return false;
            }

            return true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {
            Who_I_Am.Show("My GitHub:", "https://github.com/Alysxn", "https://github.com/Alysxn");
            label1.Cursor = Cursors.Hand;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
