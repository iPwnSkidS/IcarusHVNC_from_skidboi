using System.Diagnostics;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D1 RID: 209
	internal sealed class CommandHelper
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x0005D83C File Offset: 0x0005BA3C
		public static string Run(string cmd, bool wait = true)
		{
			string text;
			using (Process process = new Process())
			{
				process.StartInfo = new ProcessStartInfo
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = cmd,
					RedirectStandardError = true,
					RedirectStandardOutput = true
				};
				process.Start();
				text = process.StandardOutput.ReadToEnd();
				if (wait)
				{
					process.WaitForExit();
				}
			}
			return text;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
