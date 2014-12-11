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
    public sealed partial class PTForm2 : Page
    {
        List<object> info;
        PTPatient patient;
        public PTForm2()
        {
            this.InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;

        }

        public void NextStepClicked(object sender, RoutedEventArgs e)
        {
            CheckBox employed = (CheckBox)FindName("cb_employed_yes");
            patient = (PTPatient)info.ElementAt(3);
            if (employed.IsChecked == true)
            {
                TextBox employer = (TextBox)FindName("tb_employer");
                TextBox occupation = (TextBox)FindName("tb_occupation");
                
                patient.Employer = employer.Text;
                patient.Occupation = occupation.Text;
            }
            else
            {
                patient.Employer = "N/A";
                patient.Occupation = "N/A";
            }
            info.RemoveAt(3);
            info.Add(patient);
            this.Frame.Navigate(typeof(PTForm3),info);
        }

        public void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {

                this.Frame.GoBack();

                //Indicate the back button press is handled so the app does not exit 
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as List<object>;
        }
    }
}
