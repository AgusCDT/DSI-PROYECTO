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
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/mapa.png",
                Text = "Meditics es un juego de género Auto-Battler en el que la estrategia" +
                " y la gestión de recursos juegan un papel muy importante. Ahora vamos a explicar los diferentes elementos a tener en cuenta."
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga2.jpeg",
                Text = "El primer elemento sería la lista de jugadores, y es que en Meditics" +
                "no estás solo. Siempre podrás jugar vs IA o vs jugadores en línea. Esta lista muestra los usuarios que hay en la partida además de la vida de la que disponen"
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "La siguiente barra nos muestra el estado de la partida. Al principio tienes tiempo" +
                "para pensar tu jugada, luego empieza la autobatalla entre tus unidades y las del enemigo y así sucesivamente"
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "El tablero de juego, en el que deberemos colocar nuestras unidades de forma estratégica. Pero, ¿cómo conseguimos unidades?"           
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "La tienda, en la que podremos obtener personajes para colocarlos en el tablero. Necesitaremos monedas, que se consiguen en las rondas" +
                "de juego"
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "El botón de reroll, con el cual por una cantidad de dinero podemos cambiar el contenido de la tienda"
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "El botón de subir nivel, con el cual por una cantidad de dinero podemos subir de nivel para así aumentar la cantidad de tropas que " +
                "podemos colocar en el campo de batalla"
            });
            items.Add(new FlipViewItem
            {
                ImagePath = "Assets/pantallacarga3.jpeg",
                Text = "Las sinergias: son elementos importantes dentro del juego. Los personajes tienen distintas sinergias que los hacen más poderosos." +
                "Si combinas varias obtendrás un gran poder de combate"
            });
            Tutorial_FlipView.ItemsSource = items;
        }
      
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }
    }
}
