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

        public SaveData()
        {
            savedWorld = new GuildWorld();
        }

        public void setWorld(GuildWorld a)
        {
            this.savedWorld = a;
        }

    }
}
