using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivinityModManager
{
	public class MenuSettingsAttribute : Attribute
	{
		public string DisplayName { get; set; }
		public string Parent { get; set; }
		public bool AddSeparator { get; set; }
		public string Tooltip { get; set; }
		public string Style { get; set; }
		public MenuSettingsAttribute(string parent = "", string displayName = "", bool addSeparatorAfter = false, string tooltip = "")
		{
			DisplayName = Properties.Resources.ResourceManager.GetString(displayName) ?? displayName;
			Parent = Properties.Resources.ResourceManager.GetString(parent) ?? parent;
			AddSeparator = addSeparatorAfter;
			Tooltip = Properties.Resources.ResourceManager.GetString(tooltip) ?? tooltip;
		}

		public static void WriteString(string s)
		{
            string path = @"text.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(s);
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(s);
            }
        }
	}
}
