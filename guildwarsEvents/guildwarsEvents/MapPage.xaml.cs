using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RestSharp;


namespace guildwarsEvents
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
            GetServerData();
        }

        private void NavigateMapDetail(object sender, SelectionChangedEventArgs e)
        {
            Globals.MapID = (mapList.SelectedItem as GuildMap).id;
            System.Diagnostics.Debug.WriteLine(Globals.WorldID);
            NavigationService.Navigate(new Uri("/MapDetailPage.xaml", UriKind.Relative));
        }

        private void GetServerData()
        {
            string serverRequest = "https://api.guildwars2.com/";
            var client = new RestClient(serverRequest);
            var request = new RestRequest();
            request.Resource = "v1/map_names.json";
            request.Method = Method.GET;

            client.ExecuteAsync<List<World>>(request, response =>
            {
                //System.Diagnostics.Debug.WriteLine(response.Data[0].name);
                mapList.ItemsSource = null;
                mapList.ItemsSource = response.Data;

            });
        }

    }
}