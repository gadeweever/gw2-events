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
    public partial class servers : PhoneApplicationPage
    {
        
        public servers()
        {
            InitializeComponent();
            GetServerData();
            
        }

        private void GetServerData()
        {
            string serverRequest = "https://api.guildwars2.com/v1/world_names.json";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(serverRequest);
            request.BeginGetResponse(RequestCallback, request);

        }

        private void RequestCallback(IAsyncResult result)
        {
            HttpWebRequest request = result.AsyncState as HttpWebRequest;
            if (request != null)
            {
                try
                {
                    WebResponse response = request.EndGetResponse(result);
                    serverList.ItemsSource = null;
                    
                }
                catch (WebException e)
                {
                    Globals.WorldID = -1;
                    return;
                }
            }

        }

        private void SetServer(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}