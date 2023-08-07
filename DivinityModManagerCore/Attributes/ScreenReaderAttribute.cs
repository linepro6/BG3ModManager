using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivinityModManager
{
	public class ScreenReaderHelperAttribute : Attribute
	{
		public string Name { get; set; }
		public string HelpText { get; set; }

		public ScreenReaderHelperAttribute(string name = "", string helpText = "")
		{
			Name = Properties.Resources.ResourceManager.GetString(name) ?? name;
			HelpText = Properties.Resources.ResourceManager.GetString(helpText) ?? helpText;
        }
	}
}
