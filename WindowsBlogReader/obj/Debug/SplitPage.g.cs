﻿

#pragma checksum "C:\Users\Marc\documents\visual studio 2013\Projects\TP2\WindowsBlogReader\SplitPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F7A237F77A5BED66011BB99B17A3D7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsBlogReader
{
    partial class SplitPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 46 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonBase_OnClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 98 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 120 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationFailed += this.ContentView_OnNavigationFailed;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


