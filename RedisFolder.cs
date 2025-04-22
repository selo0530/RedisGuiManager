using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisGuiManager
{
    public class RedisFolder
    {
        public List<KeyValuePair<string, string>> sub_items { get; set; }
        public string path_name { get; set; }
        public string display_name { get; set; }
    }
}
