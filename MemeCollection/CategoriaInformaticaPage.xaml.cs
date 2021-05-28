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
    public sealed partial class CategoriaInformaticaPage : Page
    {
        public CategoriaInformaticaPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Actualizar movil al abuelo";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme1.jpg"));
            this.meme2.titulo = "Tom y Jerry";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme2.jpg"));
            this.meme3.titulo = "Antivirus";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme3.jpg"));
            this.meme4.titulo = "SSD vs HDD";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme4.jpg"));
            this.meme5.titulo = "Las profes vs los profes";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme5.jpg"));
            this.meme6.titulo = "RAM antes vs ahora";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Informatica/meme6.jpg"));
        }
    }
}
