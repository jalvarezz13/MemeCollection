﻿#pragma checksum "C:\Users\Carlos\Source\Repos\jalvarezz13\MeMeCollection\MemeCollection\TiendaFavoritosPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6A241BB3330BF455E32EC3B3F2532147F131A42084D86481A77B8BCA9C918B6"
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
    partial class TiendaFavoritosPage : 
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
            case 2: // TiendaFavoritosPage.xaml line 21
                {
                    this.cbTienda = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbTienda).SelectionChanged += this.ordenarProductos;
                }
                break;
            case 3: // TiendaFavoritosPage.xaml line 22
                {
                    this.imgaddCarrito = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // TiendaFavoritosPage.xaml line 23
                {
                    this.txtCompras = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // TiendaFavoritosPage.xaml line 24
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 6: // TiendaFavoritosPage.xaml line 25
                {
                    this.producto1 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 7: // TiendaFavoritosPage.xaml line 26
                {
                    this.producto2 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 8: // TiendaFavoritosPage.xaml line 27
                {
                    this.producto3 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 9: // TiendaFavoritosPage.xaml line 28
                {
                    this.producto4 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 10: // TiendaFavoritosPage.xaml line 29
                {
                    this.producto5 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 11: // TiendaFavoritosPage.xaml line 30
                {
                    this.producto6 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 12: // TiendaFavoritosPage.xaml line 31
                {
                    this.producto7 = (global::MemeCollection.tiendaUserControl)(target);
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

