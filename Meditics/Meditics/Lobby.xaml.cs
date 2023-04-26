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
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Meditics
{
    public sealed partial class Lobby : Page
    {       
        public Lobby()
        {
            InitializeComponent();
  
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
            Frame.Navigate(typeof(Profile),User.Text);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Options));
        }

        private void SelectGameButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GameSelection));
        }

        private void Lobby_Click(object sender, RoutedEventArgs e)
        {
            Tienda.Visibility= Visibility.Collapsed;
            Inventario.Visibility= Visibility.Collapsed;
            TIENDAB.Background = new SolidColorBrush(color: Colors.DarkCyan);
            INVENTARIOB.Background = new SolidColorBrush(color: Colors.DarkCyan);
            LOBBYB.Background = new SolidColorBrush(color: Colors.Cyan);
        }
        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            Tienda.Visibility = Visibility.Visible;
            Inventario.Visibility = Visibility.Collapsed;
            TIENDAB.Background = new SolidColorBrush(color: Colors.Cyan);
            INVENTARIOB.Background = new SolidColorBrush(color: Colors.DarkCyan);
            LOBBYB.Background = new SolidColorBrush(color: Colors.DarkCyan);
        }
        private void Inventario_Click(object sender, RoutedEventArgs e)
        {
            Tienda.Visibility = Visibility.Collapsed;
            Inventario.Visibility = Visibility.Visible;
            TIENDAB.Background = new SolidColorBrush(color: Colors.DarkCyan);
            INVENTARIOB.Background = new SolidColorBrush(color: Colors.Cyan);
            LOBBYB.Background = new SolidColorBrush(color: Colors.DarkCyan);
        }

        private void Buy_Click(object sender, RoutedEventArgs e) 
        {
            Button button = sender as Button;
            Grid childGrid = button.Parent as Grid;
            Grid parentGrid = childGrid.Parent as Grid;

            TextBlock costText = childGrid.Children.OfType<TextBlock>().Last<TextBlock>();
            Image costImage = childGrid.Children.OfType<Image>().Last<Image>();

            childGrid.Children.Remove(button); //primero le quitamos el boton
            childGrid.Children.Remove(costText); //le quitamos el precio
            childGrid.Children.Remove(costImage); //y por ultimo la imagen del dinero

            parentGrid.Children.Remove(childGrid); //lo quitamos de la tienda

            if (parentGrid.Name== "PersonajesShop")
            {
                PersonajesInv.Children.Add(childGrid);
            }


        }
    }
}
