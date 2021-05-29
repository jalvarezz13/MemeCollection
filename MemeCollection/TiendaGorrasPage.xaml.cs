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
        tiendaUserControl aux1 = new tiendaUserControl();
        tiendaUserControl aux2 = new tiendaUserControl();
        tiendaUserControl aux3 = new tiendaUserControl();
        tiendaUserControl aux4 = new tiendaUserControl();
        tiendaUserControl aux5 = new tiendaUserControl();
        tiendaUserControl aux6 = new tiendaUserControl();

        public TiendaGorrasPage()
        {
            this.InitializeComponent();
            cbTienda.Items.Add("Seleccione ...");
            cbTienda.Items.Add("Ordenar de mayor a menor precio");
            cbTienda.Items.Add("Ordenar de menor a mayor precio");
            cbTienda.Items.Add("Ordenar de mas gustados a menos gustados");
            cbTienda.Items.Add("Ordenar de menos gustados a mas gustados");
            cbTienda.SelectedIndex = 0;
            cargarProductos();

        }
        private void cargarProductos()
        {
            this.producto1.titulo = "Gorra AZ";
            this.producto1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra1.jpg"));
            this.producto1.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra1.jpg";
            this.producto1.precio = "2.99";

            this.producto2.titulo = "Gorra LoL";
            this.producto2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra2.jpg"));
            this.producto2.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra2.jpg";
            this.producto2.precio = "9.99";

            this.producto3.titulo = "Gorra Cool";
            this.producto3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra3.jpg"));
            this.producto3.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra3.jpg";
            this.producto3.precio = "7.99";

            this.producto4.titulo = "Gorra Gustavo";
            this.producto4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra4.jpg"));
            this.producto4.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra4.jpg";
            this.producto4.precio = "15.99";

            this.producto5.titulo = "Gorra Gris";
            this.producto5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra5.jpg"));
            this.producto5.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra5.jpg";
            this.producto5.precio = "4.99";

            this.producto6.titulo = "Gorra Riliy";
            this.producto6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Gorras/Gorra6.jpg"));
            this.producto6.ruta_string = "ms-appx:///Images/Productos/Gorras/Gorra6.jpg";
            this.producto6.precio = "13.99";
        }
        private void ordenarProductos(object sender, SelectionChangedEventArgs e)
        {
            cargarProductos();
            List<tiendaUserControl> productos = new List<tiendaUserControl> { producto1, producto2, producto3, producto4, producto5, producto6 };

            if (cbTienda.SelectedItem != null)
            {
                List<tiendaUserControl> ordenPrecio = productos.OrderBy(x => Convert.ToDouble(x.precio)).ToList();
                //txtCompras.Text = ordenPrecio.ElementAt(0).titulo + " " + ordenPrecio.ElementAt(1).titulo + " " + ordenPrecio.ElementAt(2).titulo+ ordenPrecio.ElementAt(3).titulo+ ordenPrecio.ElementAt(4).titulo+ ordenPrecio.ElementAt(5).titulo;
                List<tiendaUserControl> ordenLike = productos.OrderBy(y => Convert.ToInt32(y.like)).ToList();

                switch (cbTienda.SelectedIndex)
                {
                    case 1:
                        aux1.titulo = ordenPrecio.ElementAt(5).titulo;
                        aux1.ruta_string = ordenPrecio.ElementAt(5).ruta_string;
                        aux1.precio = Convert.ToString(ordenPrecio.ElementAt(5).precio);
                        aux1.like = Convert.ToString(ordenPrecio.ElementAt(5).like);

                        aux2.titulo = ordenPrecio.ElementAt(4).titulo;
                        aux2.ruta_string = ordenPrecio.ElementAt(4).ruta_string;
                        aux2.precio = Convert.ToString(ordenPrecio.ElementAt(4).precio);
                        aux2.like = Convert.ToString(ordenPrecio.ElementAt(4).like);

                        aux3.titulo = ordenPrecio.ElementAt(3).titulo;
                        aux3.ruta_string = ordenPrecio.ElementAt(3).ruta_string;
                        aux3.precio = Convert.ToString(ordenPrecio.ElementAt(3).precio);
                        aux3.like = Convert.ToString(ordenPrecio.ElementAt(3).like);

                        aux4.titulo = ordenPrecio.ElementAt(2).titulo;
                        aux4.ruta_string = ordenPrecio.ElementAt(2).ruta_string;
                        aux4.precio = Convert.ToString(ordenPrecio.ElementAt(2).precio);
                        aux4.like = Convert.ToString(ordenPrecio.ElementAt(2).like);

                        aux5.titulo = ordenPrecio.ElementAt(1).titulo;
                        aux5.ruta_string = ordenPrecio.ElementAt(1).ruta_string;
                        aux5.precio = Convert.ToString(ordenPrecio.ElementAt(1).precio);
                        aux5.like = Convert.ToString(ordenPrecio.ElementAt(1).like); ;

                        aux6.titulo = ordenPrecio.ElementAt(0).titulo;
                        aux6.ruta_string = ordenPrecio.ElementAt(0).ruta_string;
                        aux6.precio = Convert.ToString(ordenPrecio.ElementAt(0).precio);
                        aux6.like = Convert.ToString(ordenPrecio.ElementAt(0).like);

                        actualizarOrden();
                        break;

                    case 2:
                        aux1.titulo = ordenPrecio.ElementAt(0).titulo;
                        aux1.ruta_string = ordenPrecio.ElementAt(0).ruta_string;
                        aux1.precio = Convert.ToString(ordenPrecio.ElementAt(0).precio);
                        aux1.like = Convert.ToString(ordenPrecio.ElementAt(0).like);

                        aux2.titulo = ordenPrecio.ElementAt(1).titulo;
                        aux2.ruta_string = ordenPrecio.ElementAt(1).ruta_string;
                        aux2.precio = Convert.ToString(ordenPrecio.ElementAt(1).precio);
                        aux2.like = Convert.ToString(ordenPrecio.ElementAt(1).like);

                        aux3.titulo = ordenPrecio.ElementAt(2).titulo;
                        aux3.ruta_string = ordenPrecio.ElementAt(2).ruta_string;
                        aux3.precio = Convert.ToString(ordenPrecio.ElementAt(2).precio);
                        aux3.like = Convert.ToString(ordenPrecio.ElementAt(2).like);

                        aux4.titulo = ordenPrecio.ElementAt(3).titulo;
                        aux4.ruta_string = ordenPrecio.ElementAt(3).ruta_string;
                        aux4.precio = Convert.ToString(ordenPrecio.ElementAt(3).precio);
                        aux4.like = Convert.ToString(ordenPrecio.ElementAt(3).like);

                        aux5.titulo = ordenPrecio.ElementAt(4).titulo;
                        aux5.ruta_string = ordenPrecio.ElementAt(4).ruta_string;
                        aux5.precio = Convert.ToString(ordenPrecio.ElementAt(4).precio);
                        aux5.like = Convert.ToString(ordenPrecio.ElementAt(4).like); ;

                        aux6.titulo = ordenPrecio.ElementAt(5).titulo;
                        aux6.ruta_string = ordenPrecio.ElementAt(5).ruta_string;
                        aux6.precio = Convert.ToString(ordenPrecio.ElementAt(5).precio);
                        aux6.like = Convert.ToString(ordenPrecio.ElementAt(5).like);

                        actualizarOrden();
                        break;

                    case 3:
                        aux1.titulo = ordenLike.ElementAt(5).titulo;
                        aux1.ruta_string = ordenLike.ElementAt(5).ruta_string;
                        aux1.precio = Convert.ToString(ordenLike.ElementAt(5).precio);
                        aux1.like = Convert.ToString(ordenLike.ElementAt(5).like);

                        aux2.titulo = ordenLike.ElementAt(4).titulo;
                        aux2.ruta_string = ordenLike.ElementAt(4).ruta_string;
                        aux2.precio = Convert.ToString(ordenLike.ElementAt(4).precio);
                        aux2.like = Convert.ToString(ordenLike.ElementAt(4).like);

                        aux3.titulo = ordenLike.ElementAt(3).titulo;
                        aux3.ruta_string = ordenLike.ElementAt(3).ruta_string;
                        aux3.precio = Convert.ToString(ordenLike.ElementAt(3).precio);
                        aux3.like = Convert.ToString(ordenLike.ElementAt(3).like);

                        aux4.titulo = ordenLike.ElementAt(2).titulo;
                        aux4.ruta_string = ordenLike.ElementAt(2).ruta_string;
                        aux4.precio = Convert.ToString(ordenLike.ElementAt(2).precio);
                        aux4.like = Convert.ToString(ordenLike.ElementAt(2).like);

                        aux5.titulo = ordenLike.ElementAt(1).titulo;
                        aux5.ruta_string = ordenLike.ElementAt(1).ruta_string;
                        aux5.precio = Convert.ToString(ordenLike.ElementAt(1).precio);
                        aux5.like = Convert.ToString(ordenLike.ElementAt(1).like); ;

                        aux6.titulo = ordenLike.ElementAt(0).titulo;
                        aux6.ruta_string = ordenLike.ElementAt(0).ruta_string;
                        aux6.precio = Convert.ToString(ordenLike.ElementAt(0).precio);
                        aux6.like = Convert.ToString(ordenLike.ElementAt(0).like);

                        actualizarOrden();
                        break;

                    case 4:
                        aux1.titulo = ordenLike.ElementAt(0).titulo;
                        aux1.ruta_string = ordenLike.ElementAt(0).ruta_string;
                        aux1.precio = Convert.ToString(ordenLike.ElementAt(0).precio);
                        aux1.like = Convert.ToString(ordenLike.ElementAt(0).like);

                        aux2.titulo = ordenLike.ElementAt(1).titulo;
                        aux2.ruta_string = ordenLike.ElementAt(1).ruta_string;
                        aux2.precio = Convert.ToString(ordenLike.ElementAt(1).precio);
                        aux2.like = Convert.ToString(ordenLike.ElementAt(1).like);

                        aux3.titulo = ordenLike.ElementAt(2).titulo;
                        aux3.ruta_string = ordenLike.ElementAt(2).ruta_string;
                        aux3.precio = Convert.ToString(ordenLike.ElementAt(2).precio);
                        aux3.like = Convert.ToString(ordenLike.ElementAt(2).like);

                        aux4.titulo = ordenLike.ElementAt(3).titulo;
                        aux4.ruta_string = ordenLike.ElementAt(3).ruta_string;
                        aux4.precio = Convert.ToString(ordenLike.ElementAt(3).precio);
                        aux4.like = Convert.ToString(ordenLike.ElementAt(3).like);

                        aux5.titulo = ordenLike.ElementAt(4).titulo;
                        aux5.ruta_string = ordenLike.ElementAt(4).ruta_string;
                        aux5.precio = Convert.ToString(ordenLike.ElementAt(4).precio);
                        aux5.like = Convert.ToString(ordenLike.ElementAt(4).like); ;

                        aux6.titulo = ordenLike.ElementAt(5).titulo;
                        aux6.ruta_string = ordenLike.ElementAt(5).ruta_string;
                        aux6.precio = Convert.ToString(ordenLike.ElementAt(5).precio);
                        aux6.like = Convert.ToString(ordenLike.ElementAt(5).like);

                        actualizarOrden();
                        break;

                }

            }
        }

        private void actualizarOrden()
        {
            this.producto1.titulo = aux1.titulo;
            this.producto1.ruta = new BitmapImage(new Uri(aux1.ruta_string));
            this.producto1.precio = aux1.precio;
            this.producto1.like = aux1.like;

            this.producto2.titulo = aux2.titulo;
            this.producto2.ruta = new BitmapImage(new Uri(aux2.ruta_string));
            this.producto2.precio = aux2.precio;
            this.producto2.like = aux2.like;

            this.producto3.titulo = aux3.titulo;
            this.producto3.ruta = new BitmapImage(new Uri(aux3.ruta_string));
            this.producto3.precio = aux3.precio;
            this.producto3.like = aux3.like;

            this.producto4.titulo = aux4.titulo;
            this.producto4.ruta = new BitmapImage(new Uri(aux4.ruta_string));
            this.producto4.precio = aux4.precio;
            this.producto4.like = aux4.like;

            this.producto5.titulo = aux5.titulo;
            this.producto5.ruta = new BitmapImage(new Uri(aux5.ruta_string));
            this.producto5.precio = aux5.precio;
            this.producto5.like = aux5.like;

            this.producto6.titulo = aux6.titulo;
            this.producto6.ruta = new BitmapImage(new Uri(aux6.ruta_string));
            this.producto6.precio = aux6.precio;
            this.producto6.like = aux6.like;
        }
    }
}
