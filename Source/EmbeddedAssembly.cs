

// Token: 0x02000013 RID: 19

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace BirdBrainmofo
{
    public class EmbeddedAssembly
    {
        // Token: 0x06000118 RID: 280 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
        public static void Load(string embeddedResource, string fileName)
        {
            if (dic == null)
            {
                dic = new Dictionary<string, Assembly>();
            }
            byte[] array = null;
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Assembly assembly;
            using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(embeddedResource))
            {
                if (manifestResourceStream == null)
                {
                    throw new Exception(embeddedResource + " is not found in Embedded Resources.");
                }
                array = new byte[(int)manifestResourceStream.Length];
                manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
                try
                {
                    assembly = Assembly.Load(array);
                    dic.Add(assembly.FullName, assembly);
                    return;
                }
                catch
                {
                }
            }
            bool flag = false;
            string text = "";
            using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
            {
                string text2 = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(array)).Replace("-", string.Empty);
                text = Path.GetTempPath() + fileName;
                if (File.Exists(text))
                {
                    byte[] array2 = File.ReadAllBytes(text);
                    string text3 = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(array2)).Replace("-", string.Empty);
                    flag = text2 == text3;
                }
                else
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                File.WriteAllBytes(text, array);
            }
            assembly = Assembly.LoadFile(text);
            dic.Add(assembly.FullName, assembly);
        }

        // Token: 0x06000119 RID: 281 RVA: 0x0000E520 File Offset: 0x0000C720
        public static Assembly Get(string assemblyFullName)
        {
            Assembly assembly;
            if (dic != null && dic.Count != 0)
            {
                if (dic.ContainsKey(assemblyFullName))
                {
                    assembly = dic[assemblyFullName];
                }
                else
                {
                    assembly = null;
                }
            }
            else
            {
                assembly = null;
            }
            return assembly;
        }

        // Token: 0x0600011A RID: 282 RVA: 0x00006F52 File Offset: 0x00005152

        // Token: 0x040000AC RID: 172
        private static Dictionary<string, Assembly> dic;
    }
}
