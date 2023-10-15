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

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string companyName = textBox1.Text;
            string companyAddress = textBox4.Text;
            string Date = dateTimePicker1.Text;
            string companySUMM = textBox2.Text;


            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyAddress) || string.IsNullOrEmpty(companySUMM))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Создание строки с данными компании
            string companyData = $"Название компании: {companyName}\r\nАдрес компании: {companyAddress}\r\nДата Создания: {Date}\r\nСумма компании: {companySUMM}$\r\n ";

            try
            {
                // Запись данных в текстовый файл
                string filePath = "company_data.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(companyData);
                }

                MessageBox.Show("Компания успешно зарегистрирована.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации компании: {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
         char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
