using HomeApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApplication.Pages
{
    public partial class DeviceListPage : ContentPage
    {
        /// <summary>
        /// Ссылка на выбранный объект
        /// </summary>
         HomeDevice SelectedDevice;
        public ObservableCollection<HomeDevice> Devices { get; set; } = new ObservableCollection<HomeDevice>();

        public DeviceListPage()
        {
            InitializeComponent();

            // Заполняем список устройств
            Devices.Add(new HomeDevice("Чайник", description: "LG, объем 2л."));
            Devices.Add(new HomeDevice("Стиральная машина", description: "BOSCH"));
            Devices.Add(new HomeDevice("Посудомоечная машина", description: "Gorenje"));
            Devices.Add(new HomeDevice("Мультиварка", description: "Philips"));

            BindingContext = this;
        }

        /// <summary>
        /// Обработчик нажатия
        /// </summary>
        private void deviceList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // распаковка модели из объекта
            var tappedDevice = (HomeDevice)e.Item;
            // уведомление
            DisplayAlert("Нажатие", $"Вы нажали на элемент {tappedDevice.Name} ", "OK"); ; ;
        }

        /// <summary>
        /// Обработчик выбора
        /// </summary>
        private void deviceList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // распаковка модели из объекта
            SelectedDevice = (HomeDevice)e.SelectedItem;
        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            // Возврат на первую страницу стека навигации (корневую страницу приложения) - экран логина
            await Navigation.PopAsync();
        }

        private async void DeviceButton_Clicked(object sender, EventArgs e)
        {
            // Переход на следующую страницу - страницу нового устройства (и помещение её в стек навигации)
            await Navigation.PushAsync(new DevicePage());
        }
        private async void EditDeviceButton_Clicked(object sender, EventArgs e)
        {
            // проверяем, выбрал ли пользователь устройство из списка
            if (SelectedDevice == null)
            {
                await DisplayAlert(null, $"Пожалуйста, выберите устройство!", "OK");
                return;
            }
        }
    }
}