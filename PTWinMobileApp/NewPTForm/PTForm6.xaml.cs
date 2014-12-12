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
    public sealed partial class PTForm6 : Page
    {
        object[] info;
        public PTForm6()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        public void NextStepClicked(object sender, RoutedEventArgs e)
        {
            List<CheckBox> cb_list = new List<CheckBox>();
            cb_list.Add((CheckBox)FindName("cb_bending"));
            cb_list.Add((CheckBox)FindName("cb_sitting"));
            cb_list.Add((CheckBox)FindName("cb_rising"));
            cb_list.Add((CheckBox)FindName("cb_prologned_position"));
            cb_list.Add((CheckBox)FindName("cb_movement"));
            cb_list.Add((CheckBox)FindName("cb_standing"));
            cb_list.Add((CheckBox)FindName("cb_walking"));
            cb_list.Add((CheckBox)FindName("cb_lying"));
            cb_list.Add((CheckBox)FindName("cb_rest"));
            cb_list.Add((CheckBox)FindName("cb_cough"));
            cb_list.Add((CheckBox)FindName("cb_sneeze"));
            cb_list.Add((CheckBox)FindName("cb_breath"));
            cb_list.Add((CheckBox)FindName("cb_medication"));

            foreach (CheckBox cb in cb_list)
            {
                if (cb.IsChecked == true)
                {
                    ((Form)info[Form.FORM]).listOfWorseningCondition.Add(cb.Content.ToString());
                }
            }
            this.Frame.Navigate(typeof(PTForm7), info);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as object[];
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
    }
}
