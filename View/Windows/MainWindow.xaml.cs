using ConferenceOrganizatorTF.Model;
using ConferenceOrganizatorTF.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConferenceOrganizatorTF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Direction> directions = new List<Direction>();
        public MainWindow()
        {
            InitializeComponent();

            //Заполнение нашего ComboBox.
            directions = App.context.Direction.ToList();
            directions.Insert(0, new Direction { Name = "Все направления" });
            DirectionCmb.ItemsSource = directions;
        }

        private void DirectionCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DirectionCmb.SelectedIndex == 0)
            {
                //В ListView EventLv загружаем все записи из таблицы Event
                EventLv.ItemsSource = App.context.Event.ToList();
            }
            else
            {
                EventLv.ItemsSource = App.context.Event.Where(ev => ev.DirectionId == DirectionCmb.SelectedIndex).ToList();
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.ShowDialog();
        }

        private void DateDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateDp.SelectedDate == null)
            {
                //В ListView EventLv загружаем все записи из таблицы Event
                EventLv.ItemsSource = App.context.Event.ToList();
            }
            else
            {
                EventLv.ItemsSource = App.context.Event.Where(ev => ev.Date == DateDp.SelectedDate).ToList();
            }
        }
    }
}
