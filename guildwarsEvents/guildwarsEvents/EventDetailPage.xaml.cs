using System;
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
    public partial class EventDetailPage : PhoneApplicationPage
    {
        private bool isFavorite;
        private ApplicationBarIconButton add;
        public EventDetailPage()
        {
            InitializeComponent();
            isFavorite = false;
            add = this.ApplicationBar.Buttons[0] as ApplicationBarIconButton;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Globals.StorageSave.savedEvents.Contains(Globals.CurrentEvent))
            {
                isFavorite = true;
                add.IconUri = new Uri("/do.png", UriKind.Relative);
            }
                
            base.OnNavigatedTo(e);
        }
        private void ToggleFavorite(object sender, EventArgs e)
        {
            if (isFavorite)
            {
                Globals.StorageSave.savedEvents.Remove(Globals.CurrentEvent);
                add.IconUri = new Uri("/do.png", UriKind.Relative);
            }
            else
            {
                Globals.StorageSave.savedEvents.Add(Globals.CurrentEvent);
                add.IconUri = new Uri("/do2.png", UriKind.Relative);
            }
            isFavorite = !isFavorite;
            
        }
    }
}