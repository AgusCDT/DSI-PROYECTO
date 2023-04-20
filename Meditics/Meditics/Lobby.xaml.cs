using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Meditics
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Lobby : Page
    {       
        public Lobby()
        {
            InitializeComponent();
            // Leer el valor del volumen desde la configuración
            //double volumen = (double)ApplicationData.Current.LocalSettings.Values["Volumen"];
            //MusicPlayer.Volume = volumen;
           
            VideoLobby.TransportControls.Height = 50;
            VideoLobby.TransportControls.VerticalAlignment= VerticalAlignment.Bottom;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                string userText = e.Parameter.ToString();
                User.Text = userText;
            }
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Options));
        }

        private void SelectGameButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GameSelection));
        }

        private void MusicPlayer_VolumeChanged(object sender, RoutedEventArgs e)
        {
            double volumen = (double)ApplicationData.Current.LocalSettings.Values["Volumen"];
            MusicPlayer.Volume = volumen;
        }
    }
}
