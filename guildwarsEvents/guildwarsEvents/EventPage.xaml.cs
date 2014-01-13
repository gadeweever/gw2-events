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
using GW2DotNET.V1.World;


namespace guildwarsEvents
{
    public partial class EventPage : PhoneApplicationPage
    {
        public EventPage()
        {
            InitializeComponent();
            GetServerData();
        }

        private void NavigateDetailPage(object sender, SelectionChangedEventArgs e)
        {
            Globals.CurrentEvent = eventList.SelectedItem as GuildEvent;
            NavigationService.Navigate(new Uri("/EventDetailPage.xaml", UriKind.Relative));
        }

        private void GetServerData2()
        {
            string serverRequest = "https://api.guildwars2.com/";
            var client = new RestClient(serverRequest);
            var request = new RestRequest();
            request.Resource = "v1/events.json?world_id=" + Globals.CurrentServer.id;
            request.Method = Method.GET;
            request.RootElement = "events";

            client.ExecuteAsync<Dictionary<string, GuildEventResponse>>(request, response =>
            {

                
                GuildEventResponse example = response.Data["703E5B36-63E8-4150-B0E3-68535CBFB144"];
                //eventList.ItemsSource = gothby.Content;
            });

            eventList.ItemsSource = null;
        }

        private void GetServerData()
        {
            GW2DotNET.V1.World.WorldManager wm = new GW2DotNET.V1.World.WorldManager();


        }

        
    }
}