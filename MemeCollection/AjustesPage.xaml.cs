using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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

        private void mostrarAviso(object sender, PointerRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("\nEsta funcionalidad estaría genial pero... no la hemos podido conseguir :(\nLo hemos intentado de varias formas:\n- Binding estático en XAML\n- Binding dinámico en XAML\n- Instanciando la clase con un método publico\n- Haciendo accesible la variable con get y set\nEn general, la idea era ocultar tanto icono como texto del menu contextual de la izquierda y de esa forma que se ocultara gracias a que las RowDefinitions están en 'Auto'.", "Nota informativa");
            dialog.Commands.Add(new UICommand("Ok, lo entiendo", null));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            var cmd = dialog.ShowAsync();
        }
    }
}
