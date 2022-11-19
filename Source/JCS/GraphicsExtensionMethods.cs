using System.Drawing;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000040 RID: 64
	public static class GraphicsExtensionMethods
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00015164 File Offset: 0x00013364
		public static Color ToGrayScale(this Color originalColor)
		{
			Color color;
			if (originalColor.Equals(Color.Transparent))
			{
				color = originalColor;
			}
			else
			{
				int num = (int)(originalColor.R * 0.299 + originalColor.G * 0.587 + originalColor.B * 0.114);
				color = Color.FromArgb(num, num, num);
			}
			return color;
		}
	}
}
