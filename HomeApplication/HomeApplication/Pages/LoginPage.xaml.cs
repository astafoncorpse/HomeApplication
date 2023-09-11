using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApplication.Pages
{
    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCouner = 0;

        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// По клику "логинимся" на главный экран приложения
        /// </summary>
        private async void Login_Click(object sender, EventArgs e)
        {
            loginButton.Text = $"Выполняется вход..";
            // Имитация задержки (приложение загружает данные с сервера)
            await Task.Delay(150);

            // Переход на следующую страницу - страницу списка устройств
            await Navigation.PushAsync(new DeviceListPage());
            // Восстановим первоначальный текст на кнопке (на случай, если пользователь вернется на этот экран чтобы выполнить вход снова)
            loginButton.Text = BUTTON_TEXT;
        }
    }
}