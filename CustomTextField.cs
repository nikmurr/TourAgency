using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgency
{
    public partial class CustomTextField : UserControl
    {
        string labelText = "Text";
        int type = 0;
        bool isFullfilled = false;

        //0 - ничего
        //1 - на заполненность
        //2 - логин (32 + симв)
        //3 - пароль (64 + симв)
        //4 - 

        public CustomTextField()
        {
            InitializeComponent();
        }

        public void SetTextBox(string labelText, int type)
        {
            this.labelText = labelText;
            this.type = type;

            label1.Text= labelText;

            if(type == 3) textBox1.PasswordChar= '*';
        }

        private void SetFunction(KeyEventHandler handler)
        {
            this.textBox1.KeyDown+= handler;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isFullfilled)
                {
                    MessageBox.Show(
                    "Логин должен быть не короче 4 и не длинне 32 символов. Пароль должен быть не короче 8 и не длиннее 32 символов. Проверьте введенные данные.",
                    "Неверные данные для входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                }
            }
        }

        public void AnalyzeResult()
        {
            string text = textBox1.Text;
            if(type != 0)
            {
                if(!String.IsNullOrEmpty(text))
                {
                    if (type == 2 || type == 3)
                    {
                        Regex regex;
                        if (type == 2) regex = new Regex(@"^[a-zA-Z0-9]{4,32}$");
                        else regex = new Regex(@"^[a-zA-Z0-9~!@#$%^&*_]{8,64}$");

                        if (regex.IsMatch(text))
                        {
                            isFullfilled = true;
                        }
                        else
                        {
                            isFullfilled = false;
                        }
                    }
                    else
                    {
                        isFullfilled = true;
                    }
                }
                else
                {
                    isFullfilled = false;
                }
            }
            else
            {
                isFullfilled = true;
            }
        }

        public bool IsFullfilled()
        {
            return isFullfilled;
        }

        public string GetText()
        {
            return textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AnalyzeResult();
        }
    }
}
