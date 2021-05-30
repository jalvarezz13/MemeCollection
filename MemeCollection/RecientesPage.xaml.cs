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
    public sealed partial class RecientesPage : Page
    {
        public RecientesPage()
        {
            this.InitializeComponent();
           // this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Rajoy";
            this.meme1.ruta =  new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme1.jpg"));
            this.meme2.titulo = "Abuela";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme2.jpg"));
            this.meme3.titulo = "Adam Sadler";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme3.jpg"));
            this.meme4.titulo = "Tom y Jerry";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme4.jpg"));
            this.meme5.titulo = "Batman";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme5.jpg"));
            this.meme6.titulo = "Correr";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme6.jpg"));
            this.meme7.titulo = "Einstein";
            this.meme7.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme7.jpg"));
            this.meme8.titulo = "Marty McFly con fibre";
            this.meme8.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme8.jpg"));
            this.meme9.titulo = "Nuggets";
            this.meme9.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme9.jpg"));
            this.meme10.titulo = "Sevilla";
            this.meme10.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Recientes/meme10.jpg"));
        }
    }
}
