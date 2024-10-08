using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Добавьте эту строку

namespace praktika
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string medkarta = textBox1.Text;
            string password = textBox2.Text;

            // Строка подключения к MySQL
            string connectionString = "server=localhost;database=clinic;Uid=root;Pwd=34neverdXe!451219S!;";

            // Проверка авторизации
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE Medkarta = @medkarta AND Parol = @password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@medkarta", medkarta);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Пользователь найден, проверяем тип
                                string role = reader["Kodovoeslovo"].ToString();

                                if (role == "Пациент")
                                {
                                    MessageBox.Show("Авторизация успешна! Добро пожаловать, Пациент!", "Авторизация");
                                    // Открыть форму для клиента
                                    Form3 newForm = new Form3();
                                    newForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка: Неверный тип пользователя!", "Авторизация");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: Неверный логин или пароль!", "Авторизация");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message, "Ошибка");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
