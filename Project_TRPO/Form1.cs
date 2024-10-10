using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TRPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string username = textBox1.Text; // получение строки из текстбокса
        //    string password = textBox2.Text; // получение строки из текстбокса

        //    int hashedUsername = SimpleHash(username); // хэширование имени пользователя
        //    int hashedPassword = SimpleHash(password); // хэширование пароля

        //    try
        //    {
        //        string json = File.ReadAllText(@"C:\FilesC++\users.json"); // чтение из JSON файла
        //        var users = JsonConvert.DeserializeObject<User[]>(json); // десериализация JSON в массив объектов User
        //        bool isAuthenticated = users.Any(user => user.Username == hashedUsername && user.Password == hashedPassword); // проверка на совпадение

        //        if (isAuthenticated)
        //        {
        //            MessageBox.Show("Authentication successful!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Authentication failed.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}
        //    public class User
        //    {
        //        public int Username { get; set; }
        //        public int Password { get; set; }
        //    }

        //    private int SimpleHash(string input)
        //    {
        //        int hash = 0;
        //        foreach (char c in input)
        //        {
        //            hash += (int)c;
        //        }
        //        return hash;
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide(); // Скрыть первое окно
        }
    }
}
