using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace BirdBrainmofo.ToggleSwitch
{
	// Token: 0x0200003E RID: 62
	public static class ImageHelper
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00015020 File Offset: 0x00013220
		public static ImageAttributes GetGrayscaleAttributes()
		{
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(_grayscaleColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			return imageAttributes;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00015044 File Offset: 0x00013244
		public static Size RescaleImageToFit(Size imageSize, Size canvasSize)
		{
			double num = canvasSize.Width / (double)imageSize.Width;
			double num2 = canvasSize.Height / (double)imageSize.Height;
			double num3 = Math.Min(num, num2);
			int num4 = Convert.ToInt32(imageSize.Height * num3);
			int num5 = Convert.ToInt32(imageSize.Width * num3);
			Size size = new Size(num5, num4);
			if (size.Width > canvasSize.Width || size.Height > canvasSize.Height)
			{
				throw new Exception("ImageHelper.RescaleImageToFit - Resize failed!");
			}
			return size;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000150DC File Offset: 0x000132DC
		// Note: this type is marked as 'beforefieldinit'.
		static ImageHelper()
		{
			float[][] array = new float[5][];
			array[0] = new[] { 0.299f, 0.299f, 0.299f, 0f, 0f };
			array[1] = new[] { 0.587f, 0.587f, 0.587f, 0f, 0f };
			array[2] = new[] { 0.114f, 0.114f, 0.114f, 0f, 0f };
			int num = 3;
			float[] array2 = new float[5];
			array2[3] = 1f;
			array[num] = array2;
			array[4] = new[] { 0f, 0f, 0f, 0f, 1f };
			_colorMatrixElements = array;
			_grayscaleColorMatrix = new ColorMatrix(_colorMatrixElements);
		}

		// Token: 0x04000187 RID: 391
		private static float[][] _colorMatrixElements;

		// Token: 0x04000188 RID: 392
		private static ColorMatrix _grayscaleColorMatrix;
	}
}
