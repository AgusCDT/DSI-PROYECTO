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
    public sealed partial class GameSelection : Page
    {
        public GameSelection()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void TutorialButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tutorial));
        }

        private void MatchButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Match));
        }

        private void BlockButton_Click(object sender, RoutedEventArgs e)
        {
            playMessage.IsOpen = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (s, args) =>
            {
                playMessage.IsOpen = false;
                timer.Stop();
            };
            timer.Start();
        }
    }
}
