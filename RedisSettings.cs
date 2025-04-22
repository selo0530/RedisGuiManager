using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace RedisGuiManager
{
	public class RedisKey
	{
    }

	public class RedisGroup
    {
        public List<RedisSettings> connections { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class RedisSettings
    {
        public string auth { get; set; }
        public string host { get; set; }
        public string name { get; set; }
        public int port { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool use_tunnel { get; set; } = false;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ssh_host { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ssh_password { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ssh_port { get; set; } = 22;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ssh_user { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool use_ssh_key { get; set; } = false;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ssh_key { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool hide_default_dbs { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int> additional_dbs { get; set; }

        [JsonIgnore]
        public RedisClient redis_client { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class DbSettings
    {
        public DbSettings()
        {
            Filter = "*";
        }

        public int DBNumber { get; set; }
        public string Filter { get; set; }
        public List<string> Keys { get; set; }
    }
}
