﻿using System;
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
    public sealed partial class memeUserControl : UserControl
    {
        public memeUserControl()
        {
            this.InitializeComponent();
            txtVistas.Text = String.Format("{0}", new Random().Next(1000, 10000));
            txtLikes.Text = String.Format("{0}", new Random().Next(0, 1000));
        }

        private void pulsarLike(object sender, PointerRoutedEventArgs e)
        {

            imgLikeButton.Source = new BitmapImage(new Uri("ms-appx:///Images/imgLikeOn.png"));
        }
    }
}
