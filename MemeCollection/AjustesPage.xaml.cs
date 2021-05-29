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
    public sealed partial class AjustesPage : Page
    {
        GridLength visible = GridLength.Auto;
        GridLength novisible = new GridLength(0);
        public AjustesPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            
        }

        private void showHideComida(object sender, PointerRoutedEventArgs e)
        {
            switch (tsComida.IsOn)
            {
                case true:
                    
                    
                    break;
                case false:
                    Application.Current.Resources["gridHeight"] = "0";

                    break;

            }
        }
    }
}
