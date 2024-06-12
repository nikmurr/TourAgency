using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgency.DataClasses;

namespace TourAgency
{
    internal class DBHelper {

        private string connectionString;
        private NpgsqlConnection connection;

        public DBHelper(string host, string database, string username, string password) {
            try {
                connectionString = $"Host={host};Database={database};Username={username};Password={password}";
                connection = new NpgsqlConnection(connectionString);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    $"Произошла ошибка данных. Текст ошибки:\n " + ex.Message, 
                    "Ошибка подключения!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }

        public void AddUser()
        {
            string password1 = Tools.Hasher("admin");
            string password2 = Tools.Hasher("dazaikinn");
            string password3 = Tools.Hasher("alyonka");
            string password4 = Tools.Hasher("dimadima");
            string password5 = Tools.Hasher("qwertyqwerty");
            ExecuteNonQuery($"INSERT INTO users(user_role_id, full_name, login, password) VALUES (1, 'Грачевский Олег Иванович', 'admin', '{password1}')");
            ExecuteNonQuery($"INSERT INTO users(user_role_id, full_name, login, password) VALUES (3, 'Семёнова Елена Олеговна', 'dazaikinn', '{password2}')");
            ExecuteNonQuery($"INSERT INTO users(user_role_id, full_name, login, password) VALUES (3, 'Надеждина Алёна Дмитриевна', 'alyonka', '{password3}')");
            ExecuteNonQuery($"INSERT INTO users(user_role_id, full_name, login, password) VALUES (3, 'Дмитриев Дмитрий Дмитриевич', 'dimadima', '{password4}')");
            ExecuteNonQuery($"INSERT INTO users(user_role_id, full_name, login, password) VALUES (2, 'Путешественница Дарья Рюкзаковна', 'darya78', '{password5}')");

        }

        public bool LoginAcception(string login, string password, out int? roleID, out string fullName)
        {
            string hashedPassword = "";
            roleID = null;
            fullName = null;
            try { 

                connection.Open();
                hashedPassword = Tools.Hasher(password);
                string query = $"SELECT user_role_id, full_name, login, password FROM users WHERE login = @LOGIN AND password = @PASSWORD;";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LOGIN", login);
                    command.Parameters.AddWithValue("@PASSWORD", hashedPassword);

                    // Выполнение запроса и обработка результата
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Проверка наличия строк
                        {
                            roleID = reader.GetInt32(0); // Получение role_id
                            fullName = reader.GetString(1); // Получение full_name

                            return true; // Пользователь найден
                        }
                        else
                        {
                            // Пользователь не найден
                            throw new Exception("Пользователь не найден.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Пользователь не найден. Пожалуйста, проверьте правильность ввода логина и пароля. Логин: {login}, Пароль: {password}, {hashedPassword}, {ex.Message}",
                    "Ошибка входа!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"{ex.Message}",
                    "Ошибка входа!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool ExecuteNonQuery(string nonQuery)
        {
            try
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(nonQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show(
                    "Успешно!",
                    "Отчёт об операции с данными",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Произошла ошибка данных. Текст ошибки:\n " + $"ex",
                    "Ошибка подключения!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        //public List<RequestModel> getAllRequests()
        //{
        //    try
        //    {
        //        connection.Open();
        //        string query
        //        using (NpgsqlCommand cmd = new NpgsqlCommand(nonQuery, connection))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //        MessageBox.Show(
        //            "Успешно!",
        //            "Отчёт об операции с данными",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information
        //        );
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            "Произошла ошибка данных. Текст ошибки:\n " + $"ex",
        //            "Ошибка подключения!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //        );
        //        return false;
        //    }
        //    finally
        //    {
        //        if (connection.State == System.Data.ConnectionState.Open)
        //            connection.Close();
        //    }
        //}

    
    }
}
