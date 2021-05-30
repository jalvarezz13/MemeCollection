using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
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
    public sealed partial class memeUserControl : UserControl
    {
        string root;
        public string titulo
        {
            get { return txtMemePrincipal.Text; }
            set { this.txtMemePrincipal.Text = value; }
        }

        public string categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public int calificacion
        {
            get { return this.calificacion; }
            set { this.calificacion = value; }
        }

        public BitmapImage ruta
        {
            set { imgMemePrincipal.Source = value; }
            
        }

        public string ruta_string
        {
            get { return root; }
            set { this.root = value; }
        }

        public memeUserControl()
        {
            this.InitializeComponent();
            txtVistas.Text = String.Format("{0}", new Random().Next(1000, 10000));
            txtLikes.Text = String.Format("{0}", new Random().Next(0, 1000));
            
        }

        private void pulsarLike(object sender, PointerRoutedEventArgs e)
        {
            if (imgLikeOnButton.Visibility == Visibility.Collapsed)
            {
                imgLikeOnButton.Visibility = Visibility.Visible;
                imgLikeOffButton.Visibility = Visibility.Collapsed;
                imgLikes.Source = new BitmapImage(new Uri("ms-appx:///Images/imgLikesDado.png"));
                txtLikes.Text = "" + (Convert.ToInt32(txtLikes.Text.ToString()) + 1);
            }
            else
            {
                imgLikeOffButton.Visibility = Visibility.Visible;
                imgLikeOnButton.Visibility = Visibility.Collapsed;
                imgLikes.Source = new BitmapImage(new Uri("ms-appx:///Images/imgLikes.png"));
                txtLikes.Text = "" + (Convert.ToInt32(txtLikes.Text.ToString()) - 1);
            }
        }

        private void guardarMeme(object sender, PointerRoutedEventArgs e)
        {
            
            new ToastContentBuilder().AddArgument("action", "Guardar").AddInlineImage(new Uri("ms-appx:///Assets/iconoApp.png")).AddArgument("conversationId", 9813).AddText("Tu meme se guardado correctamente.").Show();
           
        }
       
    }
}


