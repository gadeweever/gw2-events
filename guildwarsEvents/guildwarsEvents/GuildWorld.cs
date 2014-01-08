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

        public GuildWorld()
        {
            id = -1;
            name = "";
        }

        public void setInfo(int a, string b)
        {
            this.id = a;
            this.name = b;
        }

    }
}
