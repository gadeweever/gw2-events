using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using guildwarsEvents.Resources;
using System.IO.IsolatedStorage;
using System.IO;

namespace guildwarsEvents
{
    public partial class MainPage : PhoneApplicationPage
    {
        SaveData myData;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            myData = new SaveData();
            LoadStoredData();


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            
        }
        #region Navigation and Override Handlers
        private void NavigateSettings(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/servers.xaml", UriKind.Relative));
        }

        private void NavigateMaps(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapPage.xaml", UriKind.Relative));
        }

        private void NavigateEvents(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Globals.MapID = -1;
            NavigationService.Navigate(new Uri("/EventPage.xaml", UriKind.Relative));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                serverText.Text = Globals.CurrentServer.name;
                base.OnNavigatedTo(e);
            }
            catch (NullReferenceException)
            {
                NavigationService.Navigate(new Uri("/servers.xaml", UriKind.Relative));
                MessageBox.Show("Please Select a server");
                return;
            }
            
        }
        #endregion
        #region Isolated Storage Handling
        private int LoadStoredData()
        {
            using (var filesystem = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!filesystem.FileExists("saveData.dat"))
                {
                    return 1;
                }
                else
                {
                    using (var fs = new IsolatedStorageFileStream(
                     "assignments.dat", FileMode.Open, filesystem))
                    {
                        var serializer = new System.Runtime.Serialization
                          .Json.DataContractJsonSerializer(typeof(
                          SaveData));
                        Globals.StorageSave = serializer.ReadObject(fs) as
                          SaveData;
                    }
                    //reset menu list to the stored assignments
                    Globals.CurrentServer = Globals.StorageSave.savedWorld;
                    serverText.Text = Globals.CurrentServer.name;

                }
            }
            return 0;

        }
        #endregion

    }
}