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
    public sealed partial class TiendaGorrasPage : Page
    {
        public TiendaGorrasPage()
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
            this.producto1.titulo = "Gorra AZ";
            this.producto1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra1.jpg"));
            this.producto1.precio = "2,99€";
            this.producto2.titulo = "Gorra LoL";
            this.producto2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra2.jpg"));
            this.producto2.precio = "9,99€";
            this.producto3.titulo = "Gorra Cool";
            this.producto3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra3.jpg"));
            this.producto3.precio = "7,99€";
            this.producto4.titulo = "GOrra Gustavo";
            this.producto4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra4.jpg"));
            this.producto4.precio = "15,99€";
            this.producto5.titulo = "Gorra Gris";
            this.producto5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra5.jpg"));
            this.producto5.precio = "4,99€";
            this.producto6.titulo = "Gorra Riliy";
            this.producto6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra6.jpg"));
            this.producto6.precio = "13,99€";
        }
    }
}
