using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public class GuildWorld
    {
        public int id { get; set; }
        public string name { get; set; }
        public string region { get; set; }

        public GuildWorld()
        {
            id = -1;
            name = "";
            region = "";
        }

        public void setInfo(int a, string b, string c)
        {
            this.id = a;
            this.name = b;
            this.region = c;
        }

        public void setRegion()
        {
            switch(id/1000)
            {
                case 1 : this.region = "North America";
                    break;
                case 2 : this.region = "Europe";
                    break;
                default :
                    this.region = "North America";
                    break;
            }
        }
    }
}
