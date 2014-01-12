using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public class GuildEvent
    {
        public string name { get; set; }
        public int level { get; set; }
        public int map_id { get; set; }
        public List<string> flags { get; set; }
        public GuildLocation location { get; set; }
       
        public GuildEvent()
        {
            name = "";
            level = -1;
            map_id = -1;
            flags = new List<string>();
            location = new GuildLocation();
        }
        
    }
}
