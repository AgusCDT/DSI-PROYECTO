// Agustín Castro De Troya
// Pablo Cao Calvo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;


namespace Meditics
{
    public sealed partial class MainPage : Page
    {
        private string userText = null; 
                        
        public MainPage()
        {
            InitializeComponent();          
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            
            if (userText == null || Password.Password != "meditics")
            {
                await new MessageDialog("Necesitas un usuario y poner como contraseña: 'meditics'.").ShowAsync();
                return;
            }
            else
            {
                userText = User.Text;               
                Frame.Navigate(typeof(Lobby), userText);
            }         
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void User_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(User?.Text))
            {
                userText = null;
                return;
            }
            else
            {
                userText= User.Text;
            }            
        }
    }
}
