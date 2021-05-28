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
    public sealed partial class CategoriaPeliculasPage : Page
    {
        public CategoriaPeliculasPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Batman";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme1.jpg"));
            this.meme2.titulo = "La Roca";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme2.jpg"));
            this.meme3.titulo = "Vengadores";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme3.jpg"));
            this.meme4.titulo = "A todo gas onda vital";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme4.jpg"));
            this.meme5.titulo = "Insectos";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme5.jpg"));
            this.meme6.titulo = "Zombies";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme6.jpg"));
            this.meme7.titulo = "Marty McFly con fibre";
            this.meme7.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme7.jpg"));
            this.meme8.titulo = "Mortal Kombat";
            this.meme8.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Peliculas/meme8.jpg"));
        }
    }
}
