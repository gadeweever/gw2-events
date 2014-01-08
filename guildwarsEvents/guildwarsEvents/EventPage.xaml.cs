﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace guildwarsEvents
{
    public partial class EventPage : PhoneApplicationPage
    {
        public EventPage()
        {
            InitializeComponent();
        }

        private void NavigateDetailPage(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventDetailPage.xaml", UriKind.Relative));
        }
    }
}