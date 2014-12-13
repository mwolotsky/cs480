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
    public sealed partial class Search : Page
    {
        public object[] info;
        public const int SEARCH = 4;

        public Search()
        {
            this.InitializeComponent();
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

        public void BackClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu), info);
        }

        public void SearchClicked(object sender, RoutedEventArgs e)
        {
            TextBox name = (TextBox)FindName("tb_name");
            TextBox id = (TextBox)FindName("tb_id");
            if(name.Text != null || !name.Text.Equals(""))
            {
                info[Search.SEARCH]  = searchName(name.Text);
                this.Frame.Navigate(typeof(SearchResult),info);

            }else if(id.Text != null || !name.Text.Equals(""))
            {
                info[Search.SEARCH] = searchID(Convert.ToInt32(id.Text));
                this.Frame.Navigate(typeof(SearchResult),info);
            }
            
        }

        public List<PTPatient> searchName(string str)
        {
            string key = "";
            str = str.ToLower();
            PTPatient currentPatient;
            List<PTPatient> patients = ((PTUser)info[PTUser.USER]).listOfPatients;
            List<PTPatient>searchResults = new List<PTPatient>();
            for (int i = 0; i < patients.Count; i++)
            {
                currentPatient = patients.ElementAt(i);
                key = currentPatient.Fname + " " + currentPatient.Lname;
                key = key.ToLower();

                if (key.Contains(str))
                {
                    searchResults.Add(currentPatient);
                }
            }

            return searchResults;
        }

        public List<PTPatient> searchID(int number)
        {
            int searchNum; 

            PTPatient currentPatient;
            List<PTPatient> patients = ((PTUser)info[PTUser.USER]).listOfPatients;
            List<PTPatient>searchResults = new List<PTPatient>();
            for (int i = 0; i < patients.Count; i++)
            {
                currentPatient = patients.ElementAt(i);
                searchNum = currentPatient.Patientnumber;

                if (searchNum == number)
                {
                    searchResults.Add(currentPatient);
                }
            }

            return searchResults;
        }
    }
}
