using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000A0 RID: 160
	public static class IconInjector
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x0000A9CF File Offset: 0x00008BCF
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00059EB8 File Offset: 0x000580B8
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconFile iconFile = IconFile.FromFile(iconFileName);
			IntPtr intPtr = NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			NativeMethods.UpdateResource(intPtr, new IntPtr(14L), new IntPtr(iconGroupID), 0, array, array.Length);
			for (int i = 0; i <= iconFile.ImageCount - 1; i++)
			{
				byte[] array2 = iconFile.ImageData(i);
				NativeMethods.UpdateResource(intPtr, new IntPtr(3L), new IntPtr((long)(iconBaseID + (ulong)i)), 0, array2, array2.Length);
			}
			NativeMethods.EndUpdateResource(intPtr, false);
		}

		// Token: 0x020000A1 RID: 161
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x06000838 RID: 2104
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x06000839 RID: 2105
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x0600083A RID: 2106
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);

			// Token: 0x0600083B RID: 2107 RVA: 0x00006F52 File Offset: 0x00005152
        }

		// Token: 0x020000A2 RID: 162
		private struct ICONDIR
		{
			// Token: 0x04000656 RID: 1622
			public ushort Reserved;

			// Token: 0x04000657 RID: 1623
			public ushort Type;

			// Token: 0x04000658 RID: 1624
			public ushort Count;
		}

		// Token: 0x020000A3 RID: 163
		private struct ICONDIRENTRY
		{
			// Token: 0x04000659 RID: 1625
			public byte Width;

			// Token: 0x0400065A RID: 1626
			public byte Height;

			// Token: 0x0400065B RID: 1627
			public byte ColorCount;

			// Token: 0x0400065C RID: 1628
			public byte Reserved;

			// Token: 0x0400065D RID: 1629
			public ushort Planes;

			// Token: 0x0400065E RID: 1630
			public ushort BitCount;

			// Token: 0x0400065F RID: 1631
			public int BytesInRes;

			// Token: 0x04000660 RID: 1632
			public int ImageOffset;
		}

		// Token: 0x020000A4 RID: 164
		private struct BITMAPINFOHEADER
		{
			// Token: 0x04000661 RID: 1633
			public uint Size;

			// Token: 0x04000662 RID: 1634
			public int Width;

			// Token: 0x04000663 RID: 1635
			public int Height;

			// Token: 0x04000664 RID: 1636
			public ushort Planes;

			// Token: 0x04000665 RID: 1637
			public ushort BitCount;

			// Token: 0x04000666 RID: 1638
			public uint Compression;

			// Token: 0x04000667 RID: 1639
			public uint SizeImage;

			// Token: 0x04000668 RID: 1640
			public int XPelsPerMeter;

			// Token: 0x04000669 RID: 1641
			public int YPelsPerMeter;

			// Token: 0x0400066A RID: 1642
			public uint ClrUsed;

			// Token: 0x0400066B RID: 1643
			public uint ClrImportant;
		}

		// Token: 0x020000A5 RID: 165
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x0400066C RID: 1644
			public byte Width;

			// Token: 0x0400066D RID: 1645
			public byte Height;

			// Token: 0x0400066E RID: 1646
			public byte ColorCount;

			// Token: 0x0400066F RID: 1647
			public byte Reserved;

			// Token: 0x04000670 RID: 1648
			public ushort Planes;

			// Token: 0x04000671 RID: 1649
			public ushort BitCount;

			// Token: 0x04000672 RID: 1650
			public int BytesInRes;

			// Token: 0x04000673 RID: 1651
			public ushort ushort_0;
		}

		// Token: 0x020000A6 RID: 166
		private class IconFile
		{
			// Token: 0x17000202 RID: 514
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x0000A9DA File Offset: 0x00008BDA
			public int ImageCount
			{
				get
				{
					return iconDir.Count;
				}
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x00059F4C File Offset: 0x0005814C
			public byte[] ImageData(int index)
			{
				return iconImage[index];
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00059F64 File Offset: 0x00058164
			public static IconFile FromFile(string filename)
			{
				IconFile iconFile = new IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(ICONDIR));
				iconFile.iconEntry = new ICONDIRENTRY[iconFile.iconDir.Count];
				iconFile.iconImage = new byte[iconFile.iconDir.Count][];
				int num = Marshal.SizeOf(iconFile.iconDir);
				Type typeFromHandle = typeof(ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				for (int i = 0; i <= iconFile.iconDir.Count - 1; i++)
				{
					ICONDIRENTRY icondirentry = (ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + num), typeFromHandle);
					iconFile.iconEntry[i] = icondirentry;
					iconFile.iconImage[i] = new byte[icondirentry.BytesInRes];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[i], 0, icondirentry.BytesInRes);
					num += num2;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x0005A094 File Offset: 0x00058294
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				int num = Marshal.SizeOf(typeof(ICONDIR)) + Marshal.SizeOf(typeof(GRPICONDIRENTRY)) * ImageCount;
				byte[] array = new byte[num];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr(iconDir, gchandle.AddrOfPinnedObject(), false);
				int num2 = Marshal.SizeOf(iconDir);
				for (int i = 0; i <= ImageCount - 1; i++)
				{
					GRPICONDIRENTRY grpicondirentry = default(GRPICONDIRENTRY);
					BITMAPINFOHEADER bitmapinfoheader = default(BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(BITMAPINFOHEADER)));
					gchandle2.Free();
					grpicondirentry.Width = iconEntry[i].Width;
					grpicondirentry.Height = iconEntry[i].Height;
					grpicondirentry.ColorCount = iconEntry[i].ColorCount;
					grpicondirentry.Reserved = iconEntry[i].Reserved;
					grpicondirentry.Planes = bitmapinfoheader.Planes;
					grpicondirentry.BitCount = bitmapinfoheader.BitCount;
					grpicondirentry.BytesInRes = iconEntry[i].BytesInRes;
					grpicondirentry.ushort_0 = Convert.ToUInt16((long)(iconBaseID + (ulong)i));
					Marshal.StructureToPtr(grpicondirentry, new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + num2), false);
					num2 += Marshal.SizeOf(typeof(GRPICONDIRENTRY));
				}
				gchandle.Free();
				return array;
			}

			// Token: 0x06000840 RID: 2112 RVA: 0x00006F52 File Offset: 0x00005152

            // Token: 0x04000674 RID: 1652
			private ICONDIR iconDir;

			// Token: 0x04000675 RID: 1653
			private ICONDIRENTRY[] iconEntry;

			// Token: 0x04000676 RID: 1654
			private byte[][] iconImage;
		}
	}
}
