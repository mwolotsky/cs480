﻿

#pragma checksum "C:\Users\FailQuality\Documents\Visual Studio 2013\Projects\PTWinMobileApp\cs480\PTWinMobileApp\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A4EFFE874C56C964B07C60FF8EF6A6F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTWinMobileApp
{
    partial class MainMenu : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 12 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.NewFormClicked;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 13 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ClientsClicked;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 14 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SearchFormClicked;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 15 "..\..\MainMenu.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.LogOutClicked;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


