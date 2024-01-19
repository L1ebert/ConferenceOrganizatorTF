using ConferenceOrganizatorTF.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConferenceOrganizatorTF.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        Captcha captcha = new Captcha();
        public CaptchaWindow()
        {
            InitializeComponent();
            CaptchaTbl.Text = captcha.Generate();
        }

        private void CaptchaCheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (captcha.Check(CaptchaInputTb, CaptchaTbl) == true)
            {
                DialogResult = true;
            }
        }
    }
}
