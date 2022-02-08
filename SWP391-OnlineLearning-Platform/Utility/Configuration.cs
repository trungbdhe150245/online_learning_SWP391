using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Utils
{
	/// <summary>
	/// Read Email Components from appsettings.json
	/// </summary>
	public class SmtpConfigurations
	{
		public string SmtpAddress { get; set; }
		public string SmtpUserName { get; set; }
		public string SmtpPassWord { get; set; }
		public string ContactFromName { get; set; }
		public string ContatcFromAddress { get; set; }
		public string ContactToName { get; set; }
	}
}
