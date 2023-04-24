// Agustín Castro De Troya
// Pablo Cao Calvo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Meditics
{
    public sealed partial class EndGame : Page
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void FromEndToLobbyButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lobby));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            VictoryGrid.Visibility = Visibility.Collapsed;
            DefeatGrid.Visibility = Visibility.Collapsed;
            if(e.Parameter is true)
            {
                VictoryGrid.Visibility = Visibility.Visible;
            }
            else
            {
                DefeatGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
