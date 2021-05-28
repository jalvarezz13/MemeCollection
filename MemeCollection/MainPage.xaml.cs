using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace MemeCollection
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
            frmMain.Navigate(typeof(RecientesPage));
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 720)
            {
                svMenu.IsPaneOpen = true;
                svMenu.DisplayMode = SplitViewDisplayMode.CompactInline;
            }
            else if (Width >= 360)
            {
                svMenu.IsPaneOpen = false;
                svMenu.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            }
            else
            {
                svMenu.IsPaneOpen = false;
                svMenu.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void volver(object sender, RoutedEventArgs e)
        {
            if (frmMain.BackStack.Any())
            {
                frmMain.GoBack();
            }
        }

        private void volverAlante(object sender, RoutedEventArgs e)
        {
            if (frmMain.ForwardStack.Any())
            {
                frmMain.GoForward();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            svMenu.IsPaneOpen = !svMenu.IsPaneOpen;
        }

        private void irRecientes(object sender, PointerRoutedEventArgs e)
        {
            frmMain.Navigate(typeof(RecientesPage));
        }

        private void irCategorias(object sender, PointerRoutedEventArgs e)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            frmMain.Navigate(typeof(CategoriasPage));
            
            if (Width<360)
            {
                svMenu.IsPaneOpen = false;
                svMenu.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irTienda(object sender, PointerRoutedEventArgs e)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            frmMain.Navigate(typeof(TiendaPage));
            if (Width < 360)
            {
                svMenu.IsPaneOpen = false;
                svMenu.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void irAcercaDe(object sender, PointerRoutedEventArgs e)
        {
            //Como lo hacemos al final?
            //frmMain.Navigate(typeof(AcercaDePage));

            MessageDialog dialog = new MessageDialog("\nPrograma realizado por:\nJavier Álverz Páramo\nCarlos Mohedano Callejo\nJuan Muñoz Calvo\n\n","Acerca de MemeCollection");
            dialog.Commands.Add(new UICommand("Vale", null));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            var cmd = dialog.ShowAsync();
        }

        private void irAjustes(object sender, PointerRoutedEventArgs e)
        {
            frmMain.Navigate(typeof(AjustesPage));            
        }

    }
}
