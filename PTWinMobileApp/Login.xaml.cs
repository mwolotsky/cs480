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

using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PTWinMobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class Login : Page
    {


        //List<object> info = new List<object>(4);
        object[] info = new object[4];
        Dictionary<string, PTUser> users = new Dictionary<string, PTUser>();
        Dictionary<string, PTPatient> clients = new Dictionary<string, PTPatient>();

        public Login()
        {
            this.InitializeComponent();
            PTUser pt = new PTUser(101010, "ptuser1", "pass123", new DateTime(), PTUser.PT);
            PTUser pt2 = new PTUser(11111, "ptuser2", "pass123", new DateTime(), PTUser.PT);
            PTUser manager = new PTUser(100100, "manager", "pass123", new DateTime(), PTUser.MANAGER);
            PTPatient p1 = new PTPatient("John", "Smith", "Electrician", new DateTime(), 5, 7, 140, 5, "5553724321", "Edison");
            PTPatient p2 = new PTPatient("David", "L", "Mechanic", new DateTime(), 5, 7, 140, 5, "5553724321", "RepairAndFix");
            PTPatient p3 = new PTPatient("Rob", "Silva", "N/A", new DateTime(), 5, 7, 140, 5, "5553724321", "N/A");
            PTPatient p4 = new PTPatient("Danny", "Chavez", "N/A", new DateTime(), 5, 7, 140, 5, "5553724321", "N/A");
            PTPatient p5 = new PTPatient("Victoria", "Medina", "N/A", new DateTime(), 5, 7, 140, 5, "5553724321", "N/A");
            PTPatient p6 = new PTPatient("Milhouse", "N", "N/A", new DateTime(), 5, 7, 140, 5, "5553724321", "N/A");
            p1.ListOfForms.Add(new Form());
            p1.ListOfForms.Add(new Form());
            p1.ListOfForms.ElementAt(1).appointmentDate = new DateTime(2014, 5, 11);
            p2.ListOfForms.Add(new Form());
            p3.ListOfForms.Add(new Form());
            pt.listOfPatients.Add(p1);
            pt.listOfPatients.Add(p4);
            pt2.listOfPatients.Add(p2);
            pt2.listOfPatients.Add(p3);
            pt2.listOfPatients.Add(p5);
            pt2.listOfPatients.Add(p6);
            manager.listOfPatients.Add(p1);
            manager.listOfPatients.Add(p2);
            manager.listOfPatients.Add(p3);
            manager.listOfPatients.Add(p4);
            manager.listOfPatients.Add(p5);
            manager.listOfPatients.Add(p6);

            users.Add(pt.UserName, pt);
            users.Add(pt2.UserName, pt2);
            users.Add(manager.UserName, manager);
            this.NavigationCacheMode = NavigationCacheMode.Required;
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;

        }

        public void LoginClicked(object sender, RoutedEventArgs e)
        {
            TextBox userName = (TextBox)FindName("tb_username");
            PasswordBox password = (PasswordBox)FindName("pb_password");
            PTUser thisUser;
            users.TryGetValue(userName.Text, out thisUser);

            if (thisUser != null) // check userType
            {
                if (thisUser.Password.Equals(password.Password))
                {
                    if (thisUser.Type == PTUser.PT || thisUser.Type == PTUser.MANAGER)
                    {
                        info[PTUser.USER] =  thisUser;
                        info[PTPatient.CLIENTS]= clients;
                        this.Frame.Navigate(typeof(MainMenu), info);
                    }
                }
            }
        }

        public void SignUpClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignUp), users);
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
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
