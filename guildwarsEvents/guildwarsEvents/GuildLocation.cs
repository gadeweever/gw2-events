using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public class GuildLocation
    {
        public string type { get; set; }
        public List<float> center { get; set; }
        public float radius { get; set; }
        public float rotation { get; set; }
        public List<float> z_range { get; set; }
        public List<List<float>> points { get; set; }

        public GuildLocation()
        {
            type = "";
            center = new List<float>();
            radius = 0;
            rotation = 0;
            z_range = new List<float>();
            points = new List<List<float>>();
        }

    }
}
