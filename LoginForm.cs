using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa_Systeem
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        public class Employee
        {
            string name { get; set; }
            string id { get; set; }

            public Employee(string name, string id) 
            {
                name = this.name;
                id = this.id;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName_login.Text;
            string password = password_login.Text;
            if (username == "Casper" && password == "B1E")
            {
                Program.MainForm = new MainForm();
                Program.MainForm.Show();
                this.Hide();
            }

        }

        private void userName_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
