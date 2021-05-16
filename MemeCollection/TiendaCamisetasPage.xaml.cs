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
       // List<tiendaUserControl> productos = new List<tiendaUserControl> { };
        public TiendaCamisetasPage()
        {
            this.InitializeComponent();

            cbTienda.Items.Add("Ordenar de mayor a menor precio");
            cbTienda.Items.Add("Ordenar de menor a mayor precio");
            cbTienda.Items.Add("Ordenar de mas gustados a menos gustados");
            cbTienda.Items.Add("Ordenar de menos gustados a mas gustados");

            cargarProductos();
            //productos = new List<tiendaUserControl>{producto1, producto2, producto3, producto4, producto5, producto6 };

           

        }
        private void cargarProductos()
        {
            this.producto1.titulo = "Camiseta Blanca llorando";
            this.producto1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta1.jpg"));
            this.producto1.precio = "9.99";
            this.producto2.titulo = "Camiseta Blanca riendo";
            this.producto2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta2.jpg"));
            this.producto2.precio = "8.99";
            this.producto3.titulo = "Camiseta Blanca troll";
            this.producto3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta3.jpg"));
            this.producto3.precio = "14.99";
            this.producto4.titulo = "Camiseta Amarilla LoL";
            this.producto4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta4.jpg"));
            this.producto4.precio = "12.99";
            this.producto5.titulo = "Camiseta Azul marino";
            this.producto5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta5.jpg"));
            this.producto5.precio = "11.99";
            this.producto6.titulo = "Camiseta Roja pensativo";
            this.producto6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Productos/Camisetas/Camiseta6.jpg"));
            this.producto6.precio = "7.99";
        }

        private void ordenarProductos(object sender, SelectionChangedEventArgs e)
        {
            List<tiendaUserControl> productos = new List<tiendaUserControl> {producto1, producto2, producto3, producto4, producto5, producto6 };

            if (cbTienda.SelectedItem != null)
            {
                List<tiendaUserControl> ordenPrecio = productos.OrderBy(x => Convert.ToDouble(x.precio)).ToList();
                txtCompras.Text = ordenPrecio.ElementAt(0).titulo + " " + ordenPrecio.ElementAt(1).titulo + " " + ordenPrecio.ElementAt(2).titulo+ ordenPrecio.ElementAt(3).titulo+ ordenPrecio.ElementAt(4).titulo+ ordenPrecio.ElementAt(5).titulo;
                List<tiendaUserControl> ordenLike = productos.OrderBy(y => Convert.ToInt32(y.like)).ToList();

                switch (cbTienda.SelectedIndex)
                {
                    case 0:
                        this.producto1.titulo = ordenPrecio.ElementAt(5).titulo;
                        //this.producto1.ruta = ordenPrecio.ElementAt(5).ruta;
                        this.producto1.precio = Convert.ToString(ordenPrecio.ElementAt(5).precio);
                        this.producto1.like = Convert.ToString(ordenPrecio.ElementAt(5).like);


                        this.producto2.titulo = ordenPrecio.ElementAt(4).titulo;
                        //this.producto2.ruta = ordenPrecio.ElementAt(4).ruta;
                        this.producto2.precio = Convert.ToString(ordenPrecio.ElementAt(4).precio);
                        this.producto2.like = Convert.ToString(ordenPrecio.ElementAt(4).like);

                        this.producto3.titulo = ordenPrecio.ElementAt(3).titulo;
                        //this.producto3.ruta = ordenPrecio.ElementAt(3).ruta;
                        this.producto3.precio = Convert.ToString(ordenPrecio.ElementAt(3).precio);
                        this.producto3.like = Convert.ToString(ordenPrecio.ElementAt(3).like);

                        this.producto4.titulo = ordenPrecio.ElementAt(2).titulo;
                        //this.producto4.ruta = ordenPrecio.ElementAt(2).ruta;
                        this.producto4.precio = Convert.ToString(ordenPrecio.ElementAt(2).precio);
                        this.producto4.like = Convert.ToString(ordenPrecio.ElementAt(2).like);

                        this.producto5.titulo = ordenPrecio.ElementAt(1).titulo;
                        //this.producto5.ruta = ordenPrecio.ElementAt(1).ruta;
                        this.producto5.precio = Convert.ToString(ordenPrecio.ElementAt(1).precio);
                        this.producto5.like = Convert.ToString(ordenPrecio.ElementAt(1).like);

                        this.producto6.titulo = ordenPrecio.ElementAt(0).titulo;
                        //this.producto6.ruta = ordenPrecio.ElementAt(0).ruta;
                        this.producto6.precio = Convert.ToString(ordenPrecio.ElementAt(0).precio);
                        this.producto6.like = Convert.ToString(ordenPrecio.ElementAt(0).like);

                       
                       

                        break;

                    case 1:
                        this.producto1.titulo = ordenPrecio.ElementAt(0).titulo;
                        //this.producto1.ruta = ordenPrecio.ElementAt(5).ruta;
                        this.producto1.precio = Convert.ToString(ordenPrecio.ElementAt(0).precio);
                        this.producto1.like = Convert.ToString(ordenPrecio.ElementAt(0).like);

                        this.producto2.titulo = ordenPrecio.ElementAt(1).titulo;
                        //this.producto2.ruta = ordenPrecio.ElementAt(4).ruta;
                        this.producto2.precio = Convert.ToString(ordenPrecio.ElementAt(1).precio);
                        this.producto2.like = Convert.ToString(ordenPrecio.ElementAt(1).like);

                        this.producto3.titulo = ordenPrecio.ElementAt(2).titulo;
                        //this.producto3.ruta = ordenPrecio.ElementAt(3).ruta;
                        this.producto3.precio = Convert.ToString(ordenPrecio.ElementAt(2).precio);
                        this.producto3.like = Convert.ToString(ordenPrecio.ElementAt(2).like);

                        this.producto4.titulo = ordenPrecio.ElementAt(3).titulo;
                        //this.producto4.ruta = ordenPrecio.ElementAt(2).ruta;
                        this.producto4.precio = Convert.ToString(ordenPrecio.ElementAt(3).precio);
                        this.producto4.like = Convert.ToString(ordenPrecio.ElementAt(3).like);

                        this.producto5.titulo = ordenPrecio.ElementAt(4).titulo;
                        //this.producto5.ruta = ordenPrecio.ElementAt(1).ruta;
                        this.producto5.precio = Convert.ToString(ordenPrecio.ElementAt(4).precio);
                        this.producto5.like = Convert.ToString(ordenPrecio.ElementAt(4).like);

                        this.producto6.titulo = ordenPrecio.ElementAt(5).titulo;
                        //this.producto6.ruta = ordenPrecio.ElementAt(0).ruta;
                        this.producto6.precio = Convert.ToString(ordenPrecio.ElementAt(5).precio);
                        this.producto6.like = Convert.ToString(ordenPrecio.ElementAt(5).like);

                        break;

                    case 2:
                        this.producto1.titulo = ordenLike.ElementAt(5).titulo;
                        //this.producto1.ruta = ordenLike.ElementAt(5).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(5).precio);

                        this.producto2.titulo = ordenLike.ElementAt(4).titulo;
                        //this.producto2.ruta = ordenLike.ElementAt(4).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(4).precio);

                        this.producto3.titulo = ordenLike.ElementAt(3).titulo;
                        //this.producto3.ruta = ordenLike.ElementAt(3).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(3).precio);

                        this.producto4.titulo = ordenLike.ElementAt(2).titulo;
                        //this.producto4.ruta = ordenLike.ElementAt(2).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(2).precio);

                        this.producto5.titulo = ordenLike.ElementAt(1).titulo;
                        //this.producto5.ruta = ordenLike.ElementAt(1).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(1).precio);

                        this.producto6.titulo = ordenLike.ElementAt(0).titulo;
                        //this.producto6.ruta = ordenLike.ElementAt(0).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(0).precio);
                        break;

                    case 3:
                        this.producto1.titulo = ordenLike.ElementAt(0).titulo;
                        //this.producto1.ruta = ordenLike.ElementAt(0).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(0).precio);

                        this.producto2.titulo = ordenLike.ElementAt(1).titulo;
                        //this.producto2.ruta = ordenLike.ElementAt(1).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(1).precio);

                        this.producto3.titulo = ordenLike.ElementAt(2).titulo;
                        //this.producto3.ruta = ordenLike.ElementAt(2).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(2).precio);

                        this.producto4.titulo = ordenLike.ElementAt(3).titulo;
                        //this.producto4.ruta = ordenLike.ElementAt(3).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(3).precio);


                        this.producto5.titulo = ordenLike.ElementAt(4).titulo;
                        //this.producto5.ruta = ordenLike.ElementAt(4).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(4).precio);

                        this.producto6.titulo = ordenLike.ElementAt(5).titulo;
                        //this.producto6.ruta = ordenLike.ElementAt(5).ruta;
                        this.producto1.precio = Convert.ToString(ordenLike.ElementAt(5).precio);
                        break;

                }

            }
        }
    }
}