﻿#pragma checksum "C:\Users\Carlos\Source\Repos\jalvarezz13\MeMeCollection\MemeCollection\TiendaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "444EB189C41152BA73E38BB35F6B2E7AD7ED35FAF54DD6351F6ACDAEC48F02C2"
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
    partial class TiendaPage : 
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
            case 2: // TiendaPage.xaml line 12
                {
                    this.svMenuArtículos = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // TiendaPage.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element3).PointerEntered += this.openPanel;
                    ((global::Windows.UI.Xaml.Controls.Grid)element3).PointerExited += this.closePanel;
                }
                break;
            case 4: // TiendaPage.xaml line 30
                {
                    this.txtCamisetas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtCamisetas).PointerReleased += this.irTiendaCamisetas;
                }
                break;
            case 5: // TiendaPage.xaml line 31
                {
                    this.txtSudaderas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtSudaderas).PointerReleased += this.irTiendaSudaderas;
                }
                break;
            case 6: // TiendaPage.xaml line 32
                {
                    this.txtGorras = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtGorras).PointerReleased += this.irTiendaGorras;
                }
                break;
            case 7: // TiendaPage.xaml line 33
                {
                    this.txtTazas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtTazas).PointerReleased += this.irTiendaTazas;
                }
                break;
            case 8: // TiendaPage.xaml line 34
                {
                    this.txtCarpetas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtCarpetas).PointerReleased += this.irTiendaCarpetas;
                }
                break;
            case 9: // TiendaPage.xaml line 35
                {
                    this.txtFavoritos = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtFavoritos).PointerReleased += this.irTiendaFavoritos;
                }
                break;
            case 10: // TiendaPage.xaml line 41
                {
                    this.frmTienda = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

