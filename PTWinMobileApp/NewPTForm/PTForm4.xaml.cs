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
    public sealed partial class PTForm4 : Page
    {
        PTPatient patient;
        List<object> info;
        public PTForm4()
        {
            this.InitializeComponent();
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;

        }

        public void NextStepClicked(object sender, RoutedEventArgs e)
        {
            CheckBox treated = (CheckBox)FindName("cb_checked");
            DatePicker when = (DatePicker)FindName("dp_when_treated");
            TextBox numVisit = (TextBox)FindName("tb_num_visits");
            RadioButton better = (RadioButton)FindName("rb_better");
            RadioButton same = (RadioButton)FindName("rb_same");
            RadioButton worse = (RadioButton)FindName("rb_worse");
            CheckBox constant = (CheckBox)FindName("cb_constant");
            TextBox painAtBest = (TextBox)FindName("tb_lvl_pain");
            TextBox painAtWorst = (TextBox)FindName("tb_lvl_pain_worst");
            Form form = new Form();
            
            if (treated.IsChecked == true)
            {
                form.treated = true;
                form.dateTreated = when.Date.DateTime;
                form.numOfVisits = Convert.ToInt32(numVisit.Text);

                
            }
            if (better.IsChecked == true)
            {
                form.condition = better.Content.ToString();
            }
            else if (worse.IsChecked == true)
            {
                form.condition = better.Content.ToString();
            }
            else
            {
                form.condition = same.Content.ToString();
            }

            if (constant.IsChecked == true)
            {
                form.symptomsConstant = true;
            }

            form.painLevelBest = Convert.ToInt32(painAtBest.Text);
            form.painLevelWorst = Convert.ToInt32(painAtWorst.Text);

            info.Add(form);

            this.Frame.Navigate(typeof(PTForm5), info);
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
            info = e.Parameter as List<object>;
        }
    }
}
