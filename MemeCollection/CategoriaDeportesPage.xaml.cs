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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemeCollection
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CategoriaDeportesPage : Page
    {
        public CategoriaDeportesPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Baloncesto y hamburguesa";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme1.jpg"));
            this.meme2.titulo = "Baloncesto profesional";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme2.jpg"));
            this.meme3.titulo = "Hazard";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme3.jpg"));
            this.meme4.titulo = "Pelota de Basket";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme4.jpg"));
            this.meme5.titulo = "PSG";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme5.jpg"));
            this.meme6.titulo = "Sevilla";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme6.jpg"));
            this.meme7.titulo = "Wii Basket";
            this.meme7.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Deportes/meme7.jpg"));
        }
    }
}
