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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PTWinMobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

        }

        public void NewFormClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PTForm));
        }

        public void RecentFormClicked(object sender, RoutedEventArgs e)
        {

        }

        public void SearchFormClicked(object sender, RoutedEventArgs e)
        {

        }

        public void LogOutClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private void BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
