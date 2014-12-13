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
    public sealed partial class PTForm8 : Page
    {
        object[] info;
        public PTForm8()
        {
            this.InitializeComponent();
        }

        public void CompleteClicked(object sender, RoutedEventArgs e)
        {
            List<CheckBox> cbList = new List<CheckBox>();
            cbList.Add((CheckBox)FindName("cb_diff_swallowing"));
            cbList.Add((CheckBox)FindName("cb_arthritus"));
            cbList.Add((CheckBox)FindName("cb_high_blood"));
            cbList.Add((CheckBox)FindName("cb_heart_trouble"));
            cbList.Add((CheckBox)FindName("cb_pacemaker"));
            cbList.Add((CheckBox)FindName("cb_epilepsy"));
            cbList.Add((CheckBox)FindName("cb_drug_abuse"));
            cbList.Add((CheckBox)FindName("cb_myofacial"));
            cbList.Add((CheckBox)FindName("cb_cancer"));
            cbList.Add((CheckBox)FindName("cb_motion_sickness"));
            cbList.Add((CheckBox)FindName("cb_fever"));
            cbList.Add((CheckBox)FindName("cb_weight_loss"));
            cbList.Add((CheckBox)FindName("cb_blood_clot"));
            cbList.Add((CheckBox)FindName("cb_smoker"));
            cbList.Add((CheckBox)FindName("cb_shortness"));
            cbList.Add((CheckBox)FindName("cb_diabetes"));
            cbList.Add((CheckBox)FindName("cb_stroke"));
            cbList.Add((CheckBox)FindName("cb_anemia"));
            cbList.Add((CheckBox)FindName("cb_bleeding"));
            cbList.Add((CheckBox)FindName("cb_hiv"));
            cbList.Add((CheckBox)FindName("cb_alcohol"));
            cbList.Add((CheckBox)FindName("cb_depression"));
            cbList.Add((CheckBox)FindName("cb_pregnant"));

            foreach (CheckBox cb in cbList)
            {
                if (cb.IsChecked == true)
                {
                    ((Form)info[Form.FORM]).medicalInformation.Add(cb.Content.ToString());
                }
            }
            ((PTPatient)info[PTPatient.PATIENT]).ListOfForms.Add((Form)info[Form.FORM]);
            ((PTUser)info[PTUser.USER]).listOfPatients.Add(((PTPatient)info[PTPatient.PATIENT]));
            this.Frame.Navigate(typeof(MainMenu), info);

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
