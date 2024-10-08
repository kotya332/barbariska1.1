using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Необходимая библиотека

namespace praktika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из формы
                string imya = textBox1.Text;
                string familiya = textBox2.Text;
                string telefon = textBox3.Text;
                string medkarta = textBox4.Text;
                string parol = textBox5.Text;
                string kodovoeslovo = textBox6.Text;
                // Проверка на пустые поля
                if (string.IsNullOrEmpty(imya) || string.IsNullOrEmpty(familiya) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(medkarta) ||
                    string.IsNullOrEmpty(parol) || string.IsNullOrEmpty(kodovoeslovo))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                // Создание соединения с базой данных
                string connectionString = "Server=localhost;Database=clinic;Uid=root;Pwd=34neverdXe!451219S!;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Создание команды INSERT
                    string query = "INSERT INTO Users (Imya, Familiya, Telefon, Medkarta, Parol, Kodovoeslovo) VALUES (@Imya, @Familiya, @Telefon, @Medkarta, @Parol, @Kodovoeslovo)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Добавление параметров к команде
                        command.Parameters.AddWithValue("@Imya", imya);
                        command.Parameters.AddWithValue("@Familiya", familiya);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@Medkarta", medkarta);
                        command.Parameters.AddWithValue("@Parol", parol);
                        command.Parameters.AddWithValue("@Kodovoeslovo", kodovoeslovo);

                        // Выполнение команды INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно зарегистрирован!");
                            // Очистка полей формы
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации пользователя.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации пользователя: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
