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
    public sealed partial class CategoriaComidaPage : Page
    {
        public CategoriaComidaPage()
        {
            this.InitializeComponent(); cargarMemes();
        }

        private void cargarMemes()
        {
            this.meme1.titulo = "Abuela";
            this.meme1.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme1.jpg"));
            this.meme2.titulo = "ADN";
            this.meme2.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme2.jpg"));
            this.meme3.titulo = "Gato y Grasa";
            this.meme3.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme3.jpg"));
            this.meme4.titulo = "Ensalada";
            this.meme4.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme4.jpg"));
            this.meme5.titulo = "Nuggets";
            this.meme5.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme5.jpg"));
            this.meme6.titulo = "Pizza";
            this.meme6.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme6.jpg"));
            this.meme7.titulo = "Perro y Pringle";
            this.meme7.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme7.jpg"));
            this.meme8.titulo = "Estrés";
            this.meme8.ruta = new BitmapImage(new Uri("ms-appx:///Images/Memes/Comida/meme8.jpg"));
        }
    }
}
