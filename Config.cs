using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace RedisGuiManager
{
    public class Config
    {
        public static int scan_page_count = 100000;
        public static int dp_type;
        public static int mainform_is_maximized;
        public static int mainform_pos_x;
        public static int mainform_pos_y;
        public static int mainform_width = 1159;
        public static int mainform_height = 712;
        public static int darkmode = 0;
        public Config()
        {
        }

        public static void Load()
        {
            if (File.Exists("config.json") == false)
            {
                return;
            }

            string config_json = File.ReadAllText("config.json");
            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(config_json);
            if (json == null)
            {
                return;
            }

            if (json.ContainsKey("dp_type"))
            {
                dp_type = Convert.ToInt32(json["dp_type"]);
            }

            if (json.ContainsKey("mainform_is_maximized"))
            {
                mainform_is_maximized = Convert.ToInt32(json["mainform_is_maximized"]);
            }
            if (json.ContainsKey("mainform_pos_x"))
            {
                mainform_pos_x = Convert.ToInt32(json["mainform_pos_x"]);
            }
            if (json.ContainsKey("mainform_pos_y"))
            {
                mainform_pos_y = Convert.ToInt32(json["mainform_pos_y"]);
            }
            if (json.ContainsKey("mainform_width"))
            {
                mainform_width = Convert.ToInt32(json["mainform_width"]);
            }
            if (json.ContainsKey("mainform_height"))
            {
                mainform_height = Convert.ToInt32(json["mainform_height"]);
            }
            if (json.ContainsKey("darkmode"))
            {
                darkmode = Convert.ToInt32(json["darkmode"]);
            }
        }

        public static void Save()
        {
            Dictionary<string, object> dic_config = new Dictionary<string, object>();
            dic_config.Add("dp_type", dp_type);
            dic_config.Add("mainform_is_maximized", mainform_is_maximized);
            dic_config.Add("mainform_pos_x", mainform_pos_x);
            dic_config.Add("mainform_pos_y", mainform_pos_y);
            dic_config.Add("mainform_width", mainform_width);
            dic_config.Add("mainform_height", mainform_height);
            dic_config.Add("darkmode", darkmode);
            string save_string = JsonConvert.SerializeObject(dic_config).ToString();
            save_string = JsonConvert.DeserializeObject(save_string).ToString();

            File.WriteAllText("config.json", save_string);
        }
    }
}
