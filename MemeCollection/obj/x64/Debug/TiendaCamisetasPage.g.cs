﻿#pragma checksum "C:\Users\Carlos\Source\Repos\jalvarezz13\MeMeCollection\MemeCollection\TiendaCamisetasPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83F8058B3D93F6F8088535DFD00F9EB00E8C29225CA39FC3FD8395C6DEB3CB55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemeCollection
{
    partial class TiendaCamisetasPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // TiendaCamisetasPage.xaml line 22
                {
                    this.cbTienda = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbTienda).SelectionChanged += this.ordenarProductos;
                }
                break;
            case 3: // TiendaCamisetasPage.xaml line 23
                {
                    this.imgaddCarrito = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // TiendaCamisetasPage.xaml line 24
                {
                    this.txtCompras = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // TiendaCamisetasPage.xaml line 26
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 6: // TiendaCamisetasPage.xaml line 27
                {
                    this.producto1 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 7: // TiendaCamisetasPage.xaml line 28
                {
                    this.producto2 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 8: // TiendaCamisetasPage.xaml line 29
                {
                    this.producto3 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 9: // TiendaCamisetasPage.xaml line 30
                {
                    this.producto4 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 10: // TiendaCamisetasPage.xaml line 31
                {
                    this.producto5 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 11: // TiendaCamisetasPage.xaml line 32
                {
                    this.producto6 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 12: // TiendaCamisetasPage.xaml line 33
                {
                    this.txtprueba = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // TiendaCamisetasPage.xaml line 34
                {
                    this.txtpruebas1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

