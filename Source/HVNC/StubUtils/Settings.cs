using System;
using System.IO;
using Newtonsoft.Json;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000AE RID: 174
	public class Settings
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x0005AFA4 File Offset: 0x000591A4
		public static SettingsObject Load()
		{
			SettingsObject settingsObject;
			if (File.Exists(savepath))
			{
				settingsObject = JsonConvert.DeserializeObject<SettingsObject>(File.ReadAllText(savepath));
			}
			else
			{
				settingsObject = null;
			}
			return settingsObject;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000AA38 File Offset: 0x00008C38
		public static void Save(SettingsObject obj)
		{
			File.WriteAllText(savepath, JsonConvert.SerializeObject(obj, Formatting.Indented));
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x0600085A RID: 2138 RVA: 0x0000AA4B File Offset: 0x00008C4B
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
		}

		// Token: 0x0400067D RID: 1661
		private static string savepath = AppDomain.CurrentDomain.BaseDirectory + "\\bin\\settings.json";
	}
}
