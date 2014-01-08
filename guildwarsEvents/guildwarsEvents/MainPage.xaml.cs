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

namespace guildwarsEvents
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            
        }

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

    }
}