// Agustín Castro De Troya
// Pablo Cao Calvo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Playback;
using Windows.Media.Protection.PlayReady;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Meditics
{
    public sealed partial class Options : Page
    {
        private float volume;
      
        public Options()
        {
            InitializeComponent();                       
            var currentApp = Application.Current as App;
            MusicSlider.Value = (float)currentApp.music.Volume * 100;          
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {           
            Frame.Navigate(typeof(MainPage));         
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var currentApp = Application.Current as App;
            volume = (float)currentApp.music.Volume;
            if (currentApp.music != null)
            {
                volume = (float)e.NewValue / 100.0f;
            }

            currentApp.music.Volume = volume; // Actualizo el volumen del MediaPlayer         
        }       
    }
}
