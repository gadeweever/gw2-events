using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public class SaveData
    {
        public GuildWorld savedWorld {get; set;}
        public List<GuildMap> savedMaps { get; set; }
        public List<GuildEvent> savedEvents { get; set; }

        public SaveData()
        {
            savedWorld = new GuildWorld();
            savedMaps = new List<GuildMap>();
            savedEvents = new List<GuildEvent>();
        }

        public void setWorld(GuildWorld a)
        {
            this.savedWorld = a;
        }

     

    }
}
