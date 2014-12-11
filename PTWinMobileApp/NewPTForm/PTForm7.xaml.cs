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
    public sealed partial class PTForm7 : Page
    {
        object[] info;
        public PTForm7()
        {
            this.InitializeComponent();
        }

        public void NextStepClicked(object sender, RoutedEventArgs e)
        {
            List<CheckBox> cbList = new List<CheckBox>();
            cbList.Add((CheckBox)FindName("cb_x_ray"));
            cbList.Add((CheckBox)FindName("cb_mri"));
            cbList.Add((CheckBox)FindName("cb_other"));
            cbList.Add((CheckBox)FindName("cb_injection"));
            cbList.Add((CheckBox)FindName("cb_cat_scan"));

            foreach(CheckBox cb in cbList)
            {
                if (cb.IsChecked == true)
                {
                    ((Form)info[Form.FORM]).medicalIntervention.Add(cb.Content.ToString());
                }
            }
            this.Frame.Navigate(typeof(PTForm8), info);
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
    }
}
