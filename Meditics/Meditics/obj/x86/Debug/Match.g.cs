﻿#pragma checksum "C:\Users\pabca\OneDrive\Documentos\GitHub\DSI-PROYECTO\Meditics\Meditics\Match.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FAA79514A9F7093373613489511293C549F0D0C88D6315F2CF7AD815E92CC12C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Meditics
{
    partial class Match : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Match.xaml line 21
                {
                    this.GameGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Match.xaml line 22
                {
                    this.messagePopup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 4: // Match.xaml line 27
                {
                    this.synopup = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 5: // Match.xaml line 34
                {
                    this.Terreno = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.Terreno).Drop += this.Terreno_Drop;
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.Terreno).DragOver += this.Terreno_DragOver;
                }
                break;
            case 6: // Match.xaml line 73
                {
                    this.EXP = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // Match.xaml line 149
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Victory_Click;
                }
                break;
            case 8: // Match.xaml line 150
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Defeat_Click;
                }
                break;
            case 9: // Match.xaml line 141
                {
                    this.syn3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn3).Click += this.syn3_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn3).PointerExited += this.syn_PointerExited;
                }
                break;
            case 10: // Match.xaml line 133
                {
                    this.syn2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn2).Click += this.syn2_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn2).PointerExited += this.syn_PointerExited;
                }
                break;
            case 11: // Match.xaml line 125
                {
                    this.syn1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn1).Click += this.syn1_Click;
                    ((global::Windows.UI.Xaml.Controls.Button)this.syn1).PointerExited += this.syn_PointerExited;
                }
                break;
            case 12: // Match.xaml line 81
                {
                    this.Refresh = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13: // Match.xaml line 88
                {
                    this.Coins = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14: // Match.xaml line 92
                {
                    this.Shop = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15: // Match.xaml line 98
                {
                    this.MiContentControl1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MiContentControl1).DragStarting += this.StackPanel_DragStarting;
                }
                break;
            case 16: // Match.xaml line 103
                {
                    this.MiContentControl2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MiContentControl2).DragStarting += this.StackPanel_DragStarting;
                }
                break;
            case 17: // Match.xaml line 108
                {
                    this.MiContentControl3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MiContentControl3).DragStarting += this.StackPanel_DragStarting;
                }
                break;
            case 18: // Match.xaml line 113
                {
                    this.MiContentControl4 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MiContentControl4).DragStarting += this.StackPanel_DragStarting;
                }
                break;
            case 19: // Match.xaml line 114
                {
                    this.O4 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 20: // Match.xaml line 109
                {
                    this.O3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 21: // Match.xaml line 104
                {
                    this.P2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 22: // Match.xaml line 99
                {
                    this.P1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 23: // Match.xaml line 85
                {
                    this.RefreshB = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RefreshB).Click += this.RefreshB_Click;
                }
                break;
            case 24: // Match.xaml line 74
                {
                    this.EXPB = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EXPB).Click += this.EXPB_Click;
                }
                break;
            case 25: // Match.xaml line 38
                {
                    global::Windows.UI.Xaml.Controls.Button element25 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element25).Click += this.PlayersButton_Click;
                }
                break;
            case 26: // Match.xaml line 39
                {
                    this.MiStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 27: // Match.xaml line 29
                {
                    this.synText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

