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
    public sealed partial class ViewClientList : Page
    {
        //List<object> info;
        object[] info;
        public ViewClientList()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            CreateView();
        }

        public void CreateView()
        {


        }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            info = e.Parameter as object[];
            if (info != null)
            {
                PTUser thisUser = (PTUser)info[PTUser.USER];
                List<string> names = new List<String>();
                if (thisUser.listOfPatients.Count != 0)
                {
                    ListView clientList = (ListView)FindName("lv_client_list");
                    clientList.FontSize = 20;
                    
                    foreach (PTPatient patient in thisUser.listOfPatients)
                    {
                        clientList.Items.Add(patient.Fname + " " + patient.Lname);
                    }
                    
                    clientList.SelectionChanged += ListView_SelectionChanged;
                }

            }
        }
    }
}
