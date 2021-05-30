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
    public sealed partial class TiendaPage : Page
    {
        public TiendaPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
            frmTienda.Navigate(typeof(TiendaCamisetasPage));
           // this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

            if (Width >= 720)
            {
                svMenuArtículos.IsPaneOpen = true;
                svMenuArtículos.DisplayMode = SplitViewDisplayMode.CompactInline;
            }
            else if (Width >= 360)
            {
                svMenuArtículos.IsPaneOpen = false;
                svMenuArtículos.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            }
            else
            {
                svMenuArtículos.IsPaneOpen = false;
                svMenuArtículos.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irTiendaCamisetas(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaCamisetasPage));
        }

        private void irTiendaSudaderas(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaSudaderasPage));
        }

        private void irTiendaGorras(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaGorrasPage));
        }

        private void irTiendaTazas(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaTazasPage));
        }

        private void irTiendaFavoritos(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaFavoritosPage));
        }
        private void irTiendaCalcetines(object sender, PointerRoutedEventArgs e)
        {
            frmTienda.Navigate(typeof(TiendaCalcetinesPage));
        }
        private void openPanel(object sender, PointerRoutedEventArgs e)
        {
            svMenuArtículos.IsPaneOpen = true;
            svMenuArtículos.DisplayMode = SplitViewDisplayMode.CompactInline;
        }

        private void closePanel(object sender, PointerRoutedEventArgs e)
        {
            svMenuArtículos.IsPaneOpen = false;
            svMenuArtículos.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width <= 360)
            {
                svMenuArtículos.IsPaneOpen = false;
                svMenuArtículos.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        
    }

}
