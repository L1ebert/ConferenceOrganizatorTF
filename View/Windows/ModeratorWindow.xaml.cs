using ConferenceOrganizatorTF.Model;
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
    /// Логика взаимодействия для ModeratorWindow.xaml
    /// </summary>
    public partial class ModeratorWindow : Window
    {
        public ModeratorWindow()
        {
            InitializeComponent();
            GenderCmb.SelectedValuePath = "ID";
            GenderCmb.DisplayMemberPath = "Name";
            GenderCmb.ItemsSource = App.context.Gender.ToList();

            RoleCmb.SelectedValuePath = "ID";
            RoleCmb.DisplayMemberPath = "Name";
            RoleCmb.ItemsSource = App.context.Role.ToList();

            EventCmb.SelectedValuePath = "ID";
            EventCmb.DisplayMemberPath = "Name";
            EventCmb.ItemsSource = App.context.Event.ToList();
        }

        private void GenderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedGC = Convert.ToInt32(GenderCmb.SelectedValue);
            GenderCmb.ItemsSource = App.context.Gender.Where(x => x.Id == selectedGC).ToList();
        }

        private void RoleCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void EventCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(IdNumberTb.Text))
                mes += "Введите идентификатор\n";
            if (string.IsNullOrWhiteSpace(FIOTb.Text))
                mes += "Введите ФИО\n";
            if (string.IsNullOrWhiteSpace(GenderCmb.Text))
                mes += "Выберите пол\n";
            if (string.IsNullOrWhiteSpace(RoleCmb.Text))
                mes += "Выберите роль\n";
            if (string.IsNullOrWhiteSpace(EmailTb.Text))
                mes += "Введите почту\n";
            if (string.IsNullOrWhiteSpace(NumberTb.Text))
                mes += "Введите телефон\n";
            if (string.IsNullOrWhiteSpace(ActivityTb.Text))
                mes += "Введите направление\n";
            if (string.IsNullOrWhiteSpace(EventCmb.Text))
                mes += "Выберите мероприятие\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            User user = new User
            {
                GenderId = (GenderCmb.SelectedItem as Gender).Id,
                RoleId = (RoleCmb.SelectedItem as Role).Id,
                EventId = (EventCmb.SelectedItem as Event).Id
            };
        }
    }
}
