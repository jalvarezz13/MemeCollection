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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace MemeCollection
{
    public sealed partial class tiendaUserControl : UserControl
    {
        int likes;
        public string titulo
        {
            get { return txtProducto.Text; }
            set { this.txtProducto.Text = value; }
        }

        public string like
        {
            get { return txtLikes.Text; }
            set { this.txtLikes.Text = value; }
        }

        public string precio
        {
            get { return txtPrecio.Text; }
            set { this.txtPrecio.Text = value; }
        }

        public BitmapImage ruta
        {
            get { return new BitmapImage(new Uri(imgArticuloPrincipal.Source.ToString())); }
            set { imgArticuloPrincipal.Source = value; }
        }
        public tiendaUserControl()
        {
            this.InitializeComponent();
            likes = new Random().Next(1000, 10000);
            txtLikes.Text =""+ likes;
        }

        private void anadirCarrito(object sender, PointerRoutedEventArgs e)
        {
            
        }

        private void darLike(object sender, PointerRoutedEventArgs e)
        {
            //No tiene en cuenta este if no detecta al pinchar la foto origen. Si lo podeis mirar
            if (imgLikeTiendaButton.Source == new BitmapImage(new Uri("ms-appx:///Images/imgLikesDado.png")))
            {
                imgLikeTiendaButton.Source = new BitmapImage(new Uri("ms-appx:///Images/imgLikes.png"));
                likes -= 1;
                txtLikes.Text = "" + likes;
            }
            imgLikeTiendaButton.Source = new BitmapImage(new Uri("ms-appx:///Images/imgLikesDado.png"));
            likes += 1;
            txtLikes.Text = ""+likes;
        }
    }
}
