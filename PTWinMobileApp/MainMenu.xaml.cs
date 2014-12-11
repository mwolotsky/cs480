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
        //List<object> info;
        object[] info;
        public MainMenu()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;

        }

        public void NewFormClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PTForm), info);
        }

        public void ClientsClicked(object sender, RoutedEventArgs e)
        {
            if(info != null && info.ElementAt(PTUser.USER) != null)
                this.Frame.Navigate(typeof(ViewClientList), info);
        }

        public void SearchFormClicked(object sender, RoutedEventArgs e)
        {

        }

        public void LogOutClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login), info);
        }

        public void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                // Clear the status block when navigating 
                //NotifyUser(String.Empty, NotifyType.StatusMessage);

                this.Frame.GoBack();

                //Indicate the back button press is handled so the app does not exit 
                e.Handled = true;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as object[];

        }
    }
}
