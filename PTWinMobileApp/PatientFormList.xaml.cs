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
    public sealed partial class PatientFormList : Page
    {
        object[] info;
        public PatientFormList()
        {
            this.InitializeComponent();
            //Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as object[];

            PTPatient patient = (PTPatient)info[PTPatient.PATIENT];
            List<string> list = new List<String>();
            if (patient.ListOfForms.Count != 0)
            {
                ListView clientList = (ListView)FindName("lv_client_list");

                ListViewItem items = (ListViewItem)FindName("lvi_item");


                foreach (Form f in patient.ListOfForms)
                {
                    list.Add(f.appointmentDate.ToString());

                }
                clientList.ItemsSource = list;
                clientList.SelectionChanged += ListView_SelectionChanged;
            }
        }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void BackClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu), info);
        }
    }
}
