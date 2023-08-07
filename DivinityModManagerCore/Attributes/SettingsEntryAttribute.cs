using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivinityModManager
{
	public class SettingsEntryAttribute : Attribute
	{
		public string DisplayName { get; set; }
		public string Tooltip { get; set; }
		public bool IsDebug { get; set; }
		public SettingsEntryAttribute(string displayName = "", string tooltip = "", bool isDebug = false)
		{
			DisplayName = Properties.Resources.ResourceManager.GetString(displayName) ?? displayName;
			Tooltip = Properties.Resources.ResourceManager.GetString(tooltip) ?? tooltip;
			IsDebug = isDebug;
        }
	}
}
