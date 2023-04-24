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
    public sealed partial class Tutorial : Page
    {
        public Tutorial()
        {
            InitializeComponent();
            List<FlipViewItem> items = new List<FlipViewItem>();
            items.Add(new FlipViewItem { ImagePath = "Assets/mapa.png", Text = "Meditics es un juego...." });
            items.Add(new FlipViewItem { ImagePath = "Assets/pantallacarga2.jpeg", Text = "Texto de la imagen 2" });
            items.Add(new FlipViewItem { ImagePath = "Assets/pantallacarga3.jpeg", Text = "Texto de la imagen 3" });
            Tutorial_FlipView.ItemsSource = items;
        }
      
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }
    }
}
