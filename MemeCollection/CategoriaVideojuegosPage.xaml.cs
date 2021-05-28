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
    public sealed partial class CategoriaVideojuegosPage : Page
    {
        public CategoriaVideojuegosPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Correr";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme1.jpg"));
            this.meme2.titulo = "Bob Esponja y empresas";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme2.jpg"));
            this.meme3.titulo = "Tetris";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme3.jpg"));
            this.meme4.titulo = "Work/After Work";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme4.jpg"));
            this.meme5.titulo = "Pokemon Go";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme5.jpg"));
            this.meme6.titulo = "Pared sospechosa";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Videojuegos/meme6.jpg"));
        }
    }
}
