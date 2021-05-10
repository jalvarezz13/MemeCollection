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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemeCollection
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CategoriaFamososPage : Page
    {
        public CategoriaFamososPage()
        {
            this.InitializeComponent();
            cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Pato Donald";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme1.jpg"));
            this.meme2.titulo = "Einstein";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme2.jpg"));
            this.meme3.titulo = "Adam Sadler";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme3.jpg"));
            this.meme4.titulo = "Ibai";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme4.jpg"));
            this.meme5.titulo = "Leonardo DiCaprio";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme5.jpg"));
            this.meme6.titulo = "Messi";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Famosos/meme6.jpg"));
        }
    }
}
