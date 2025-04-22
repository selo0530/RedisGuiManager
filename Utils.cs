using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisGuiManager
{
    public class Utils
    {
        public static string Version { get; set; } = "1.0.0";
        private static List<string> sql_keyword_list;
        public static List<string> Sql_keyword_list
        {
            get
            {
                if (sql_keyword_list == null)
                {
                    sql_keyword_list = new List<string>()
                    {
                        "ADD","ALL","ALTER","AND","AS","ASC","BEFORE","BETWEEN","BOTH","BY","CALL","CASCADE","CHANGE","CHARACTER","CHECK","COLLATE","COLUMN","CONDITION","CONSTRAINT","CONTINUE","CONVERT","CREATE","CROSS","CURSOR","DATABASE","DATABASES","DAY_HOUR","DAY_MICROSECOND","DAY_MINUTE","DAY_SECOND","DECLARE","DEFAULT","DELAYED","DELETE","DESC","DESCRIBE","DETERMINISTIC","DISTINCT","DISTINCTROW","DIV","DROP","DUAL","EACH","ELSE","ELSEIF","ENCLOSED","ESCAPED","EXISTS","EXPLAIN","FALSE","FOR","FORCE","FOREIGN","FROM","FULLTEXT","GENERAL","GRANT","GROUP","HAVING","HIGH_PRIORITY","HOUR_MICROSECOND","HOUR_MINUTE","HOUR_SECOND","IGNORE","IGNORE_SERVER_IDS","IN","INDEX","INFILE","INNER","INOUT","INSERT","INTO","IS","JOIN","KEY","KEYS","KILL","LEADING","LEFT","LIKE","LIMIT","LINEAR","LINES","LOAD","LOCK","LOW_PRIORITY","MASTER_HEARTBEAT_PERIOD","MASTER_SSL_VERIFY_SERVER_CERT","MATCH","MAXVALUE","MINUTE_MICROSECOND","MINUTE_SECOND","MOD","MODIFIES","NATURAL","NOT","NO_WRITE_TO_BINLOG","NULL","ON","OPTIMIZE","OPTION","OPTIONALLY","OR","ORDER","OUT","OUTER","OUTFILE","PAGE_CHECKSUM","PARTITION","PRIMARY","PROCEDURE","PURGE","RANGE","READ","READS","REFERENCES","REGEXP","RELEASE","RENAME","REPLACE","REQUIRE","RESIGNAL","RESTRICT","RETURN","REVOKE","RLIKE","ROWS","SCHEMA","SECOND_MICROSECOND","SELECT","SEPARATOR","SET","SHOW","SIGNAL","SLOW","SPATIAL","SQL","SQLEXCEPTION","SQLSTATE","SQLWARNING","SQL_BIG_RESULT","SQL_CALC_FOUND_ROWS","SQL_SMALL_RESULT","STARTING","STATS_AUTO_RECALC","STATS_PERSISTENT","STATS_SAMPLE_PAGES","STRAIGHT_JOIN","TABLE","TERMINATED","TO","TRAILING","TRIGGER","TRUE","UNDO","UNION","UNIQUE","UNLOCK","UNSIGNED","UPDATE","USAGE","USE","USING","VALUES","WHERE","WITH","WRITE","XOR","YEAR_MONTH"
                    };
                }

                return sql_keyword_list;
            }
        }
        private static List<string> sql_json_func_list;
        public static List<string> Sql_json_func_list
        {
            get
            {
                if (sql_json_func_list == null)
                {
                    sql_json_func_list = new List<string>()
                    {
                        "JSON","JSON_ARRAY","JSON_ARRAY_LENGTH","JSON_EXTRACT","JSON_INSERT","JSON_OBJECT","JSON_PATCH","JSON_REMOVE","JSON_REPLACE","JSON_SET","JSON_TYPE","JSON_VALID","JSON_QUOTE","JSON_GROUP_ARRAY","JSON_GROUP_OBJECT","JSON_EACH","JSON_TREE"
                    };
                }

                return sql_json_func_list;
            }
        }

        public static void ControlDataGridViewRow(DataGridView dataGridView, int row)
        {
            int rowCount = dataGridView.RowCount;
            if (rowCount < row)
            {
                for (int i = 0; i < row - rowCount; i++)
                {
                    dataGridView.Rows.Add();
                }
            }
            else if (rowCount > row)
            {
                for (int i = 0; i < rowCount - row; i++)
                {
                    dataGridView.Rows.RemoveAt(dataGridView.RowCount - 1);
                }
            }

            foreach (DataGridViewRow viewRow in dataGridView.SelectedRows)
            {
                viewRow.Selected = false;
            }
        }

        public static string GetSizeDescription(int byte_size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (byte_size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                byte_size = byte_size / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return string.Format("{0:0.##} {1}", byte_size, sizes[order]);
        }

		// Convert an object to a byte array
		public static byte[] ObjectToByteArray(object obj)
		{
			if (obj == null)
				return null;

			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();
			bf.Serialize(ms, obj);

			return ms.ToArray();
		}

		// Convert a byte array to an Object
		public static object ByteArrayToObject(byte[] arrBytes)
		{
			MemoryStream memStream = new MemoryStream();
			BinaryFormatter binForm = new BinaryFormatter();
			memStream.Write(arrBytes, 0, arrBytes.Length);
			memStream.Seek(0, SeekOrigin.Begin);
			object obj = (object)binForm.Deserialize(memStream);

			return obj;
		}

		public static bool RedisGlobMatch(string pattern, string str)
        {
            unsafe
            {
                fixed (char* ppattern = pattern)
                {
                    fixed (char* pstr = str)
                    {
                        return RedisGlobMatch(ppattern, pattern.Length, pstr, str.Length);
                    }
                }
            }
        }

        public unsafe static bool RedisGlobMatch(char* pattern, int patternLen, char* str, int stringLen)
        {
            while (patternLen > 0 && stringLen > 0)
            {
                switch (pattern[0])
                {
                    case '*':
                    {
                        while (patternLen > 0 && pattern[1] == '*')
                        {
                            pattern++;
                            patternLen--;
                        }

                        if (patternLen == 1)
                        {
                            return true; /* match */
                        }

                        while (stringLen > 0)
                        {
                            if (RedisGlobMatch(pattern + 1, patternLen - 1, str, stringLen))
                            {
                                return true; /* match */
                            }

                            str++;
                            stringLen--;
                        }

                        return false; /* no match */
                    }

                    case '?':
                    {
                        str++;
                        stringLen--;
                    }
                    break;

                    case '[':
                    {
                        bool not = false;
                        bool match = false;

                        pattern++;
                        patternLen--;
                        not = pattern[0] == '^';

                        if (not)
                        {
                            pattern++;
                            patternLen--;
                        }

                        match = false;

                        while (true)
                        {
                            if (pattern[0] == '\\' && patternLen >= 2)
                            {
                                pattern++;
                                patternLen--;

                                if (pattern[0] == str[0])
                                {
                                    match = true;
                                }
                            }
                            else if (pattern[0] == ']')
                            {
                                break;
                            }
                            else if (patternLen == 0)
                            {
                                pattern--;
                                patternLen++;

                                break;
                            }
                            else if (patternLen >= 3 && pattern[1] == '-')
                            {
                                int start = pattern[0];
                                int end = pattern[2];
                                int c = str[0];

                                if (start > end)
                                {
                                    int t = start;
                                    start = end;
                                    end = t;
                                }

                                pattern += 2;
                                patternLen -= 2;

                                if (c >= start && c <= end)
                                {
                                    match = true;
                                }
                            }
                            else
                            {
                                if (pattern[0] == str[0])
                                {
                                    match = true;
                                }
                            }

                            pattern++;
                            patternLen--;
                        }

                        if (not)
                        {
                            match = !match;
                        }

                        if (match == false)
                        {
                            return false; /* no match */
                        }

                        str++;
                        stringLen--;
                    }
                    break;

                    /* fall through */
                    default:
                    {
                        if (pattern[0] != str[0])
                        {
                            return false; /* no match */
                        }

                        str++;
                        stringLen--;
                    }
                    break;
                }

                pattern++;
                patternLen--;

                if (stringLen == 0)
                {
                    while (*pattern == '*')
                    {
                        pattern++;
                        patternLen--;
                    }
                    break;
                }
            }

            if (patternLen == 0 && stringLen == 0)
            {
                return true;
            }

            return false;
        }

        public static int FreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }

        public static void DarkThemeForm(Form form)
        {
            form.BackColor = DarkColors.GreyBackground;
            form.ForeColor = DarkColors.LightText;
            DarkThemeControls(form.Controls);
        }

        public static void DarkThemeControl(Control control)
        {
            control.BackColor = DarkColors.GreyBackground;
            control.ForeColor = DarkColors.LightText;
            DarkThemeControls(control.Controls);
        }

        public static void DarkThemeControls(Control.ControlCollection controls)
        {
            foreach (Control component in controls)
            {
                if (component is DataGridView)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                    ((DataGridView)component).BackgroundColor = DarkColors.GreyHighlight;
                    ((DataGridView)component).DefaultCellStyle.BackColor = DarkColors.GreyBackground;
                    ((DataGridView)component).DefaultCellStyle.ForeColor = DarkColors.LightText;
                    ((DataGridView)component).AlternatingRowsDefaultCellStyle.BackColor = DarkColors.GreyBackground;
                    ((DataGridView)component).AlternatingRowsDefaultCellStyle.ForeColor = DarkColors.LightText;
                }
                else if (component is LinkLabel)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = Color.LightBlue;
                }
                else if (component is UserControl)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is Panel)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is SplitContainer)
                {
                    DarkThemeControls(component.Controls);
                    DarkThemeControl(((SplitContainer)component).Panel1);
                    DarkThemeControl(((SplitContainer)component).Panel2);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is SplitterPanel)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is TreeView)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is StatusStrip)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is TabControl)
                {
                    DarkThemeControls(component.Controls);
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is Button)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                    ((Button)component).FlatStyle = FlatStyle.Flat;
                    ((Button)component).FlatAppearance.BorderColor = DarkColors.GreySelection;
                }
                else if (component is CheckBox)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                    ((CheckBox)component).FlatStyle = FlatStyle.Flat;
                    ((CheckBox)component).FlatAppearance.BorderColor = DarkColors.LightText;
                }
                else if (component is TextBox)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is RichTextBox)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is SyntaxRichTextBox)
                {
                    component.BackColor = DarkColors.GreyBackground;
                    component.ForeColor = DarkColors.LightText;
                }
                else if (component is ListBox)
				{
					component.BackColor = DarkColors.GreyBackground;
					component.ForeColor = DarkColors.LightText;
				}
            }
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();

            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);

            pi.SetValue(dgv, setting, null);
        }
    }
}
