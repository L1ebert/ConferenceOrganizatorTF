using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConferenceOrganizatorTF.ApplicationData
{
    /// <summary>
    /// Генерирует случайную капчу.
    /// </summary>
    class Captcha
    {
        //Генератор случайных чисел
        Random random = new Random();

        //Итоговое строковое значение

        string value = string.Empty;

        public string Generate()
        {
            while (value.Length < 4)
            {
                value += Convert.ToChar(random.Next(33, 122));
            }
            return value;
        }

        public bool Check(TextBox inputTb, TextBlock outputTbl)
        {
            if (inputTb.Text == outputTbl.Text)
            {
                MessageBox.Show("Вы не робот");

                return true;
            }
            else
            {
                value = string.Empty;
                MessageBox.Show("CAPTCHA введена неверно");
                outputTbl.Text = Generate();
                inputTb.Clear();

                return false;
            }
        }
    } 
}
