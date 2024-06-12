using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgency
{
    public partial class Form1 : Form
    {
        DBHelper dbHelper;
        public Form1()
        {
            InitializeComponent();

            dbHelper = new DBHelper("localhost", "tourAgencyDB", "postgres", "3409");
            customTextFieldLog.SetTextBox("Логин", 2);
            customTextFieldPass.SetTextBox("Пароль", 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customTextFieldLog.AnalyzeResult();
            customTextFieldPass.AnalyzeResult();

            if(customTextFieldLog.IsFullfilled() && customTextFieldPass.IsFullfilled())
            {
                string login = customTextFieldLog.GetText();
                string password = customTextFieldPass.GetText();
                int? roleId;
                string full_name;
                var result = dbHelper.LoginAcception(login, password, out roleId, out full_name);
                if (result)
                {
                    MessageBox.Show(
                   $"Добро пожаловать, {full_name} {roleId}",
                   "Asas",
                   MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(
                "Логин должен быть не короче 4 и не длинне 32 символов. Пароль должен быть не короче 8 и не длиннее 32 символов. Проверьте введенные данные.",
                "Неверные данные для входа",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
