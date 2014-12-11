using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PTWinMobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PTForm : Page
    {
        PTPatient patient;
        List<object> info;
        public PTForm()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        public void NextStepForm2Clicked(object sender, RoutedEventArgs e)
        {
            TextBox fName, lName, pNumber, provider, hFeet, hIn, wLb, wOz, phoneNum;
            DatePicker bDay;
            fName = (TextBox)FindName("tb_fname");
            lName = (TextBox)FindName("tb_lname");
            pNumber = (TextBox)FindName("tb_patient_number");
            provider = (TextBox)FindName("tb_provider");
            bDay = (DatePicker)FindName("dp_birthday");
            hFeet = (TextBox)FindName("tb_height_ft");
            hIn = (TextBox)FindName("tb_height_inches");
            wLb = (TextBox)FindName("tb_weight_lb");
            wOz = (TextBox)FindName("tb_weight_oz");
            phoneNum = (TextBox)FindName("tb_phone_number");
            if (patient == null)
            {
                patient = new PTPatient();
                patient.Fname = fName.Text;
                patient.Lname = lName.Text;
                //patient.Patientnumber = Convert.ToInt32(pNumber.Text);
                patient.Birthdate = bDay.Date.DateTime;
                patient.HeightFeet = Convert.ToInt32(hFeet.Text);
                patient.HeightInches = Convert.ToInt32(hIn.Text);
                patient.WeightPounds = Convert.ToInt32(wLb.Text);
                patient.Phone = phoneNum.Text;
            }
            info.Add(patient);
            this.Frame.Navigate(typeof(PTForm2), info);
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
            info = e.Parameter as List<object>;
        }

        private void tb_fname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
