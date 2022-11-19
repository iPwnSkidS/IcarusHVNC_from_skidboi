using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kavod.Vba.Compression;

namespace BirdBrainmofo
{
	// Token: 0x0200003B RID: 59
	public class Utils
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00014680 File Offset: 0x00012880
		public static Dictionary<string, string> ParseArgs(string[] args)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (args.Length != 0)
			{
				for (int i = 0; i < args.Length; i += 2)
				{
					if (args[i].Substring(1).ToLower() == "l")
					{
						dictionary.Add(args[i].Substring(1).ToLower(), "true");
					}
					else
					{
						dictionary.Add(args[i].Substring(1).ToLower(), args[i + 1]);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000146FC File Offset: 0x000128FC
		public static List<ModuleInformation> ParseModulesFromDirStream(byte[] dirStream)
		{
			List<ModuleInformation> list = new List<ModuleInformation>();
			int i = 0;
			ModuleInformation moduleInformation = new ModuleInformation
			{
				moduleName = "",
				textOffset = 0U
			};
			while (i < dirStream.Length)
			{
				ushort word = GetWord(dirStream, i);
				uint num = GetDoubleWord(dirStream, i + 2);
				if (word == 9)
				{
					num = 6U;
				}
				else if (word == 3)
				{
					num = 2U;
				}
				ushort num2 = word;
				ushort num3 = num2;
				if (num3 != 26)
				{
					if (num3 == 49)
					{
						moduleInformation.textOffset = GetDoubleWord(dirStream, i + 6);
						list.Add(moduleInformation);
						moduleInformation = new ModuleInformation
						{
							moduleName = "",
							textOffset = 0U
						};
					}
				}
				else
				{
					moduleInformation.moduleName = Encoding.UTF8.GetString(dirStream, i + 6, (int)num);
				}
				i += 6;
				i += (int)num;
			}
			return list;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000147CC File Offset: 0x000129CC
		public static ushort GetWord(byte[] buffer, int offset)
		{
			byte[] array = new byte[2];
			Array.Copy(buffer, offset, array, 0, 2);
			return BitConverter.ToUInt16(array, 0);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000147F4 File Offset: 0x000129F4
		public static uint GetDoubleWord(byte[] buffer, int offset)
		{
			byte[] array = new byte[4];
			Array.Copy(buffer, offset, array, 0, 4);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00010A68 File Offset: 0x0000EC68
		public static byte[] Compress(byte[] data)
        {
            //DecompressedBuffer decompressedBuffer = new DecompressedBuffer(data);
			//CompressedContainer compressedContainer = new CompressedContainer(decompressedBuffer);
			//return compressedContainer.SerializeData();
            return new byte[] { };
        }

		// Token: 0x0600022D RID: 557 RVA: 0x00010A8C File Offset: 0x0000EC8C
		public static byte[] Decompress(byte[] data)
        {
            //CompressedContainer compressedContainer = new CompressedContainer(data);
			//DecompressedBuffer decompressedBuffer = new DecompressedBuffer(compressedContainer);
			//return decompressedBuffer.Data;
            return new byte[] { };
        }

		// Token: 0x0600022E RID: 558 RVA: 0x0001481C File Offset: 0x00012A1C
		public static string GetVBATextFromModuleStream(byte[] moduleStream, uint textOffset)
		{
			return Encoding.UTF8.GetString(Decompress(moduleStream.Skip((int)textOffset).ToArray()));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00014848 File Offset: 0x00012A48
		public static byte[] RemovePcodeInModuleStream(byte[] moduleStream, uint textOffset, string OG_VBACode)
		{
			return Compress(Encoding.UTF8.GetBytes(OG_VBACode)).ToArray();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001486C File Offset: 0x00012A6C
		public static string GetOutFilename(string filename)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
			string extension = Path.GetExtension(filename);
			string directoryName = Path.GetDirectoryName(filename);
			return Path.Combine(directoryName, fileNameWithoutExtension + extension);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000148A0 File Offset: 0x00012AA0
		public static byte[] HexToByte(string hex)
		{
			hex = hex.Replace("-", "");
			byte[] array = new byte[hex.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			}
			return array;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000148F4 File Offset: 0x00012AF4
		public static byte[] ChangeOffset(byte[] dirStream)
		{
			int i = 0;
			string text = "\0\0\0\0";
			while (i < dirStream.Length)
			{
				ushort word = GetWord(dirStream, i);
				uint num = GetDoubleWord(dirStream, i + 2);
				if (word == 9)
				{
					num = 6U;
				}
				else if (word == 3)
				{
					num = 2U;
				}
				ushort num2 = word;
				ushort num3 = num2;
				if (num3 == 49)
				{
					GetDoubleWord(dirStream, i + 6);
					UTF8Encoding utf8Encoding = new UTF8Encoding();
					utf8Encoding.GetBytes(text, 0, (int)num, dirStream, i + 6);
				}
				i += 6;
				i += (int)num;
			}
			return dirStream;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x0200003C RID: 60
		public class ModuleInformation
		{
			// Token: 0x06000234 RID: 564 RVA: 0x00006F52 File Offset: 0x00005152

            // Token: 0x0400017B RID: 379
			public string moduleName;

			// Token: 0x0400017C RID: 380
			public uint textOffset;
		}
	}
}
