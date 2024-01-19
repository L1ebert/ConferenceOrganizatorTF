using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ConferenceOrganizatorTF.ApplicationData
{
    internal class BlockApplication
    {
        //Таймер
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        //Время блокировки
        TimeSpan blockTime = new TimeSpan(0, 0, 5);

        //Текущуу окно для блокировки
        Window currentWindow = new Window();

        public void Start(Window window)
        {
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1.0);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();

            currentWindow = window;

            MessageBox.Show($"Система заблокирована на {blockTime.Seconds} сек.");
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            blockTime = blockTime - new TimeSpan(0, 0, 1);

            if (blockTime != TimeSpan.Zero)
            {
                currentWindow.IsEnabled = false;
            }

            dispatcherTimer.Stop();
            currentWindow.IsEnabled = true;
        }
    }
}
