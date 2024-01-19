using ConferenceOrganizatorTF.Model;
using ConferenceOrganizatorTF.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConferenceOrganizatorTF.ApplicationData
{
    class Authorization
    {
        /// <summary>
        /// Хранит пользователя, который вошел в систему.
        /// Если пользователь отсутвует, хранит значение null.
        /// </summary>
        public static User currentUser = new User();
        /// <summary>
        /// Фиксирует количество попыток входа в систему.
        /// </summary>
        static int incorrectInputCounts = 0;

        public static bool Check(int idNumber, string password)
        {
            currentUser = App.context.User.FirstOrDefault(user => user.Id == idNumber && user.Password == password);

            if(currentUser != null)
            {
                //Проверка авторизации

                //Captcha.
                CaptchaWindow captchaWindow = new CaptchaWindow();

                if (captchaWindow.ShowDialog() == true)
                {
                    //Открытие окна в зависимости от роли.
                    switch (currentUser.RoleId)
                    {
                        case 1:
                            //Открытие окна для участников.
                            ParticipantWindow participantWindow = new ParticipantWindow();
                            participantWindow.Show();
                            break;
                        case 2:
                            //Открытие окна для модератора.
                            ModeratorWindow moderatorWindow = new ModeratorWindow();
                            moderatorWindow.Show();
                            break;
                        case 3:
                            //Открытие окна для организатора
                            OrganizationWindow organizationWindow = new OrganizationWindow();
                            organizationWindow.Show();
                            break;
                        case 4:
                            //Открытие окна для жюри.
                            JuryWindow juryWindow = new JuryWindow();
                            juryWindow.Show();
                            break;
                    }
                }
                return true;
            }
            else
            {
                //Сообщение об ошибке
                incorrectInputCounts++;

                if(incorrectInputCounts > 3)
                {
                    //Блокирование системы.
                    BlockApplication blockApplication = new BlockApplication();
                    blockApplication.Start(Application.Current.MainWindow);
                    incorrectInputCounts = 0;
                }
                else
                {
                    MessageBox.Show($"Неправильно идентификатор пользователя или пароль! Попытка:{incorrectInputCounts} из 3");
                }

            }

            //Медот возварщает false. Пользователь не был найден.
            //В окне авторизации никак не обрабатывается значение false.
            //Пользователь вводит данные дальше.

            return false;
        }
    }
}
