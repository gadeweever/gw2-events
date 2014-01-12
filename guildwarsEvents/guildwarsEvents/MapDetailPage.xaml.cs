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
    public partial class MapDetailPage : PhoneApplicationPage
    {
        private bool isFavorite;
        ApplicationBarIconButton add;
        public MapDetailPage()
        {
            InitializeComponent();
            isFavorite = false;
            add = (ApplicationBarIconButton)this.ApplicationBar.Buttons[0];
            mapPageDetailTitle.Title = Globals.CurrentMap.name;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Globals.StorageSave.savedMaps.Contains(Globals.CurrentMap))
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
                Globals.StorageSave.savedMaps.Remove(Globals.CurrentMap);
                add.IconUri = new Uri("/do.png", UriKind.Relative);
            }
            else
            {
                Globals.StorageSave.savedMaps.Add(Globals.CurrentMap);
                add.IconUri = new Uri("/do2.png", UriKind.Relative);
            }
            isFavorite = !isFavorite;

            
        }
    }
}