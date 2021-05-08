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
    public sealed partial class TiendaCamisetasPage : Page
    {
        public TiendaCamisetasPage()
        {
            this.InitializeComponent();
            cbTienda.Items.Add("Menores de 50€");
            cbTienda.Items.Add("Menores de 30€");
            cbTienda.Items.Add("Menores de 15€");
            cbTienda.Items.Add("Mejores Valorados");
            cbTienda.Items.Add("Peores Valorados");

        }
    }
}
