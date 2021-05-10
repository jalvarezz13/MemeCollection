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
    public sealed partial class TiendaFavoritosPage : Page
    {
        public TiendaFavoritosPage()
        {
            this.InitializeComponent();
            cbTienda.Items.Add("Menores de 50€");
            cbTienda.Items.Add("Menores de 30€");
            cbTienda.Items.Add("Menores de 15€");
            cbTienda.Items.Add("Mejores Valorados");
            cbTienda.Items.Add("Peores Valorados");
            cargarProductos();
        }
        private void cargarProductos()
        {
            this.producto1.titulo = "Camiseta blanco y negro";
            this.producto1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos1.jpg"));
            this.producto1.precio = "19,99€";
            this.producto2.titulo = "Blanca poker";
            this.producto2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos2.jpg"));
            this.producto2.precio = "14,99€";
            this.producto3.titulo = "Gorra rosa";
            this.producto3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos3.jpg"));
            this.producto3.precio = "12,99€";
            this.producto4.titulo = "Taza narco";
            this.producto4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos4.jpg"));
            this.producto4.precio = "14,99€";
            this.producto5.titulo = "Taza multicolor";
            this.producto5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos5.jpg"));
            this.producto5.precio = "7,99€";
            this.producto6.titulo = "Taza cervantes";
            this.producto6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos6.jpg"));
            this.producto6.precio = "6,99€";
            this.producto7.titulo = "Gorra negra";
            this.producto7.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Favoritos/Favoritos6.jpg"));
            this.producto7.precio = "5,99€";
        }
    }
}
