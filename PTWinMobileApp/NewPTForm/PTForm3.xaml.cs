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
    public sealed partial class PTForm3 : Page
    {
        PTPatient patient;
        Form ptForm;
        object[] info;
        public PTForm3()
        {
            this.InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;

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
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as object[];

            TextBox ptnumber = (TextBox)FindName("tb_ptnumber");
            ptnumber.Text = ((PTUser)info[PTUser.USER]).UserID.ToString();
            ptForm = new Form();
            ptForm.ptNumber = ((PTUser)info[PTUser.USER]).UserID;
            
        }

        public void NextStepClicked(object sender, RoutedEventArgs e)
        {
           
            DatePicker dateOf = (DatePicker)FindName("dp_date_of_appointment");
            TextBox infoInjury = (TextBox)FindName("tb_complaint");
            DatePicker dateOfInjury = (DatePicker)FindName("dp_date_of_injury");
            DatePicker dateOfSurgery = (DatePicker)FindName("dp_date_of_surger");
            TextBox sustainedInj = (TextBox)FindName("tb_sustain_injury");
            ptForm.appointmentDate = dateOf.Date.DateTime;
            ptForm.chiefComplaint = infoInjury.Text;
            ptForm.dateOfInjury = dateOfInjury.Date.DateTime;
            ptForm.dateOfSurgery = dateOfSurgery.Date.DateTime;
            ptForm.injurySustained = sustainedInj.Text;

            info[Form.FORM] = ptForm;
            this.Frame.Navigate(typeof(PTForm4), info);
        }
    }
}
