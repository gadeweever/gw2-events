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
            string serverRequest = "https://api.guildwars2.com/";
            var client = new RestClient(serverRequest);
            var request = new RestRequest();
            request.Resource = "v1/world_names.json";
            request.Method = Method.GET;
            //client.Execute(request);


            client.ExecuteAsync<List<World>>(request, response =>
            {
                System.Diagnostics.Debug.WriteLine(response.Data[0].name);
                serverList.ItemsSource = null;
                serverList.ItemsSource = response.Data;
                
            });

            


        }


        private void SetServer(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selected = sender as ListBoxItem;
            int i = 10;
        }

        
    }
}