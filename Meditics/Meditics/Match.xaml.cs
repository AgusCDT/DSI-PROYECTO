// Agustín Castro De Troya
// Pablo Cao Calvo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Match : Page
    {
        public Match()
        {
            InitializeComponent();
        }

        private void PlayersButton_Click(object sender, RoutedEventArgs e)
        {
            if (MiStackPanel.Visibility == Visibility.Collapsed)
            {
                MiStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                MiStackPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void Victory_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EndGame), true);
        }

        private void Defeat_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EndGame), false);
        }

        private void Image_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            int numchilds = Terreno.Children.Count();
            for (int i = 0; i < numchilds; i++)
            {
                Grid child = Terreno.Children[i] as Grid;
                child.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            }
        }

        private void Image_DropCompleted(UIElement sender, DropCompletedEventArgs args)
        {
            int numchilds = Terreno.Children.Count();
            for (int i = 0;i < numchilds; i++) 
            {
                Grid child= Terreno.Children[i] as Grid;
                child.Background= new SolidColorBrush(Windows.UI.Colors.Transparent);
            }
        }
    }
}
