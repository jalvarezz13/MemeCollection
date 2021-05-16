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
    public sealed partial class TiendaCamisetasPage : Page
    {
        public TiendaCamisetasPage()
        {
            this.InitializeComponent();

            cbTienda.Items.Add("Ordenar de mayor coste a menos");
            cbTienda.Items.Add("Ordenar de menor coste a mayor");
            cbTienda.Items.Add("Ordenar de mejor valorados a peor");
            cbTienda.Items.Add("Ordenar de peor valorados a mejor");

            cargarProductos();

        }
        private void cargarProductos()
        {
            this.producto1.titulo = "Camiseta Blanca llorando";
            this.producto1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta1.jpg"));
            this.producto1.precio = "9.99€";
            this.producto2.titulo = "Camiseta Blanca riendo";
            this.producto2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta2.jpg"));
            this.producto2.precio = "8.99€";
            this.producto3.titulo = "Camiseta Blanca troll";
            this.producto3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta3.jpg"));
            this.producto3.precio = "14.99€";
            this.producto4.titulo = "Camiseta Amarilla LoL";
            this.producto4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta4.jpg"));
            this.producto4.precio = "12.99€";
            this.producto5.titulo = "Camiseta Azul marino";
            this.producto5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta5.jpg"));
            this.producto5.precio = "11.99€";
            this.producto6.titulo = "Camiseta Roja pensativo";
            this.producto6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta6.jpg"));
            this.producto6.precio = "7.99€";
        }

        private void ordenarProductos(object sender, SelectionChangedEventArgs e)
        {
            List<tiendaUserControl> productos = new List<tiendaUserControl>
            {
                producto1,
                producto2,
                producto3,
                producto4,
                producto5,
                producto6
            };
            if (cbTienda.SelectedItem != null)
            {
                List<tiendaUserControl> ordenPrecio = productos.OrderBy(x => x.precio).ToList();
                List<tiendaUserControl> ordenLike = productos.OrderBy(y => y.like).ToList();

                switch (cbTienda.SelectedItem.ToString())
                {

                    case "Ordenar de mayor coste a menos":

                        this.producto6 = ordenPrecio.ElementAt(0);
                        this.producto5 = ordenPrecio.ElementAt(1);
                        this.producto4 = ordenPrecio.ElementAt(2);
                        this.producto3 = ordenPrecio.ElementAt(3);
                        this.producto2 = ordenPrecio.ElementAt(4);
                        this.producto1 = ordenPrecio.ElementAt(5);
                        txtCompras.Text = ordenPrecio.ElementAt(0).titulo;

                        break;
                    case "Ordenar de menor coste a mayor":

                        this.producto1 = ordenPrecio.ElementAt(0);
                        this.producto2 = ordenPrecio.ElementAt(1);
                        this.producto3 = ordenPrecio.ElementAt(2);
                        this.producto4 = ordenPrecio.ElementAt(3);
                        this.producto5 = ordenPrecio.ElementAt(4);
                        this.producto6 = ordenPrecio.ElementAt(5);
                        txtCompras.Text = ordenPrecio.ElementAt(0).titulo + ordenPrecio.ElementAt(1).titulo + ordenPrecio.ElementAt(2).titulo;
                        break;
                    case "Ordenar de mejor valorados a peor":

                        this.producto6 = ordenLike.ElementAt(0);
                        this.producto5 = ordenLike.ElementAt(1);
                        this.producto4 = ordenLike.ElementAt(2);
                        this.producto3 = ordenLike.ElementAt(3);
                        this.producto2 = ordenLike.ElementAt(4);
                        this.producto1 = ordenLike.ElementAt(5);
                        break;
                    case "Ordenar de peor valorados a mejor":

                        this.producto1 = ordenLike.ElementAt(0);
                        this.producto2 = ordenLike.ElementAt(1);
                        this.producto3 = ordenLike.ElementAt(2);
                        this.producto4 = ordenLike.ElementAt(3);
                        this.producto5 = ordenLike.ElementAt(4);
                        this.producto6 = ordenLike.ElementAt(5);
                        txtCompras.Text = ordenLike.ElementAt(0).titulo;

                        break;

                }

            }
        }
    }
}
