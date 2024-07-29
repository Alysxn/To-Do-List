using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    internal class Database
    {
        static string path = Path.Combine(Application.StartupPath, "data_table.db");
        static string cs = @"URI=file:" + path;

        SQLiteConnection connect;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public void createDB()
        {
            if (!File.Exists(path))
            {
                try
                {
                    SQLiteConnection.CreateFile(path);
                    using (var sqlite = new SQLiteConnection(cs))
                    {
                        sqlite.Open();
                        string sql = @"
                                                CREATE TABLE IF NOT EXISTS ToDoList (
                                                    id INTEGER PRIMARY KEY,
                                                    title TEXT,
                                                    date TEXT,
                                                    description TEXT,
                                                    status TEXT
                                                                    );";
                        SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível criar o arquivo do banco de dados: " + ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        public void dataShow(DataGridView dataGridView1)
        {
            try
            {
                using (var connect = new SQLiteConnection(cs))
                {
                    connect.Open();
                    string stm = "SELECT title, date, description, status FROM ToDoList";
                    var cmd = new SQLiteCommand(stm, connect);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Insert(0, reader.GetString(0), reader.GetString(1), reader.GetString(2),reader.GetString(3));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível localizar o arquivo do banco de dados: " + ex.Message);
            }
        }

        public void insert(string title, string date, string description,string status)
        {
            try
            {
                using (var connect = new SQLiteConnection(cs))
                {
                    connect.Open();
                    var cmd = new SQLiteCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "INSERT INTO ToDoList(title, date, description,status) VALUES(@title, @date, @description,@status)";
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar a tarefa no banco de dados: " + ex.Message);
            }
        }
        public bool remove(int id,string title, string date, string description, string status)
        {
            try
            {
                using (var connect = new SQLiteConnection(cs))
                {
                    connect.Open();
                    var cmd = new SQLiteCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "DELETE FROM ToDoList WHERE id =@id AND title = @title AND date = @date AND description = @description AND status = @status";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Linha correspondente no banco de dados NÃO encontrada.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível remover a linha do banco de dados. " + ex.Message);
                return false;
            }
        }

        public int searchId(string title, string date, string description, string status)
        {
            try
            {
                using (var connect = new SQLiteConnection(cs))
                {
                    connect.Open();
                    var cmd = new SQLiteCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT id FROM ToDoList WHERE title = @title AND date = @date AND description = @description AND status = @status";
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);

                    var result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        return id;
                    }
                    else
                    {
                        return -1; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o ID no banco de dados: " + ex.Message);
                return -1;
            }
        }
        public bool update(int id, string title, string date, string description, string status)
        {
            try
            {
                using (var connect = new SQLiteConnection(cs))
                {
                    connect.Open();
                    var cmd = new SQLiteCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "UPDATE ToDoList SET title = @title, date = @date, description = @description, status = @status WHERE id = @id";
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar o registro no banco de dados: " + ex.Message);
                return false;
            }
        }


    }
}