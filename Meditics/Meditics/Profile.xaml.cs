// Agustín Castro De Troya
// Pablo Cao Calvo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Meditics
{   
    public sealed partial class Profile : Page
    {
        bool visibleT= false;
        bool visibleA= false;
        public Profile()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Lobby), UserTextBlock.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserTextBlock.Text = UserTextBox.Text;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {            
            UserTextBlock.Text=e.Parameter.ToString();
        }

        private void ChangeUserButton_Click(object sender, RoutedEventArgs e)
        {
            if(!visibleT)
            {
                UserTextBlock.Visibility= Visibility.Collapsed;
                UserTextBox.Visibility = Visibility.Visible;
                visibleT = true;
            }
            else
            {
                UserTextBox.Visibility = Visibility.Collapsed;
                UserTextBlock.Visibility = Visibility.Visible;
                visibleT = false;
            }         
        }

        private void ChangeAvatarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!visibleA)
            {
                AvatarScroller.Visibility = Visibility.Visible;
                visibleA = true;
            }
            else
            {
                AvatarScroller.Visibility = Visibility.Collapsed;
                visibleA = false;
            }           
        }

        private void Avatares_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var img = (Image)((ListViewItem)Avatares.SelectedItem).Content;
            Avatar.Source = img.Source;
        }
    }
}
