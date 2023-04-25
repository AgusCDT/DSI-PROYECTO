﻿// Agustín Castro De Troya
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

        private void RefreshB_Click(object sender, RoutedEventArgs e)
        {
            messagePopup.IsOpen = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (s, args) =>
            {
                // Set the IsOpen property of the popup to false when the timer ticks
                messagePopup.IsOpen = false;

                // Stop the timer
                timer.Stop();
            };
            timer.Start();
        }

        private void EXPB_Click(object sender, RoutedEventArgs e)
        {
            messagePopup.IsOpen = true;

            // Create a dispatcher timer and start it with an interval of 3 seconds
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (s, args) =>
            {
                // Set the IsOpen property of the popup to false when the timer ticks
                messagePopup.IsOpen = false;

                // Stop the timer
                timer.Stop();
            };
            timer.Start();
        }

        private void syn2_Click(object sender, RoutedEventArgs e)
        {
            synopup.IsOpen = true;
            TextBlock myTextBlock = (TextBlock)synopup.FindName("synText");
            myTextBlock.Text = "Al tener 4 o más herreros en tu terreno de juego se otorgará a todos tus personajes:\n+20% Velocidad de ataque\n+15% Daño físico";
        }

        private void syn1_Click(object sender, RoutedEventArgs e)
        {
            synopup.IsOpen = true;
            TextBlock myTextBlock = (TextBlock)synopup.FindName("synText");
            myTextBlock.Text = "Al tener 3 o más magos en tu terreno de juego se otorgará a todos tus personajes:\n+10% Daño mágico\n-10% Tiempo de habilidad";
        }

        private void syn3_Click(object sender, RoutedEventArgs e)
        {
            synopup.IsOpen = true;
            TextBlock myTextBlock = (TextBlock)synopup.FindName("synText");
            myTextBlock.Text = "Al tener 2 o más guardianes en tu terreno de juego se otorgará a todos tus personajes:\n+5% Resistencia física\n+5% Resistencia mágica\n+10% Salud máxima";

        }

        private void syn_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            synopup.IsOpen = false;
        }
    }
}
