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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemeCollection
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CategoriasPage : Page
    {
        public CategoriasPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
            frmCategoria.Navigate(typeof(CategoriaComidaPage));
            //this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 720)
            {
                svMenuCategorias.IsPaneOpen = true;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.CompactInline;
            }
            else if (Width >= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            }
            else
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaComida(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaComidaPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaDeportes(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaDeportesPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaFamosos(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaFamososPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaInformatica(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaInformaticaPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaPeliculas(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaPeliculasPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irCategoriaVidejuegos(object sender, PointerRoutedEventArgs e)
        {
            frmCategoria.Navigate(typeof(CategoriaVideojuegosPage));
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void openPanel(object sender, PointerRoutedEventArgs e)
        {
            svMenuCategorias.IsPaneOpen = true;
            svMenuCategorias.DisplayMode = SplitViewDisplayMode.CompactInline;
        }

        private void closePanel(object sender, PointerRoutedEventArgs e)
        {
            svMenuCategorias.IsPaneOpen = false;
            svMenuCategorias.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuCategorias.IsPaneOpen = false;
                svMenuCategorias.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }
       
    }
}
