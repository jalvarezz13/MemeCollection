using Microsoft.Toolkit.Uwp.Notifications;
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
        
        string root;
     
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
            set { imgArticuloPrincipal.Source = value; }
        }

        public string ruta_string
        {
            get { return root; }
            set { this.root = value;}
        }

        public tiendaUserControl()
        {
            this.InitializeComponent();
            txtLikes.Text = String.Format("{0}", new Random().Next(0, 1000));
            cbTallas.Items.Add("Talla S");
            cbTallas.Items.Add("Talla M");
            cbTallas.Items.Add("Talla L");
            cbTallas.Items.Add("Talla XL");
            cbTallas.SelectedIndex = 0;
            

        }

        private void pulsarLike(object sender, PointerRoutedEventArgs e)
        {
            if (imgLikeOnTiendaButton.Visibility == Visibility.Collapsed)
            {
                imgLikeOnTiendaButton.Visibility = Visibility.Visible;
                imgLikeOffTiendaButton.Visibility = Visibility.Collapsed;
                txtLikes.Text = "" + (Convert.ToInt32(txtLikes.Text.ToString()) + 1);
            }
            else
            {
                imgLikeOffTiendaButton.Visibility = Visibility.Visible;
                imgLikeOnTiendaButton.Visibility = Visibility.Collapsed;
                txtLikes.Text = "" + (Convert.ToInt32(txtLikes.Text.ToString()) - 1);
            }
        }

       
      
    }
}
