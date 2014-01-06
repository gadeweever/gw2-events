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
    public partial class servers : PhoneApplicationPage
    {
        
        public servers()
        {
            InitializeComponent();
            GetServerData();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void GetServerData()
        {
            string serverRequest = "https://api.guildwars2.com/v1";
            var client = new RestClient(serverRequest);
            var request = new RestRequest();
            request.Resource = "world_names.json";

            client.ExecuteAsync(request, response =>
            {
                System.Diagnostics.Debug.WriteLine(response.Content);
            });

            serverList.ItemsSource = null;
           


        }


        private void SetServer(object sender, SelectionChangedEventArgs e)
        {
            
        }

        
    }
}