using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public class World
    {

        public int id { get; set; }
        public string name { get; set; }

        public World()
        {
            id = 0;
            name = "";
        }

        public World(int myid, string myname)
        {
            id = myid;
            name = myname;
        }
    }
}
