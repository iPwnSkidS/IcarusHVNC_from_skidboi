using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC.Controls
{
	// Token: 0x020000EE RID: 238
	public class RJCircularPictureBox : PictureBox
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x00062A50 File Offset: 0x00060C50
		public RJCircularPictureBox()
		{
			Size = new Size(100, 100);
			SizeMode = PictureBoxSizeMode.StretchImage;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00062AB0 File Offset: 0x00060CB0
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0000AD86 File Offset: 0x00008F86
		[Category("RJ Code Advance")]
		public int BorderSize
		{
			get
			{
				return borderSize;
			}
			set
			{
				borderSize = value;
				Invalidate();
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00062AC8 File Offset: 0x00060CC8
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0000AD95 File Offset: 0x00008F95
		[Category("RJ Code Advance")]
		public Color BorderColor
		{
			get
			{
				return borderColor;
			}
			set
			{
				borderColor = value;
				Invalidate();
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00062AE0 File Offset: 0x00060CE0
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0000ADA4 File Offset: 0x00008FA4
		[Category("RJ Code Advance")]
		public Color BorderColor2
		{
			get
			{
				return borderColor2;
			}
			set
			{
				borderColor2 = value;
				Invalidate();
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00062AF8 File Offset: 0x00060CF8
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0000ADB3 File Offset: 0x00008FB3
		[Category("RJ Code Advance")]
		public DashStyle BorderLineStyle
		{
			get
			{
				return borderLineStyle;
			}
			set
			{
				borderLineStyle = value;
				Invalidate();
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00062B10 File Offset: 0x00060D10
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0000ADC2 File Offset: 0x00008FC2
		[Category("RJ Code Advance")]
		public DashCap BorderCapStyle
		{
			get
			{
				return borderCapStyle;
			}
			set
			{
				borderCapStyle = value;
				Invalidate();
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00062B28 File Offset: 0x00060D28
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0000ADD1 File Offset: 0x00008FD1
		[Category("RJ Code Advance")]
		public float GradientAngle
		{
			get
			{
				return gradientAngle;
			}
			set
			{
				gradientAngle = value;
				Invalidate();
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Size = new Size(Width, Width);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00062B40 File Offset: 0x00060D40
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			Rectangle rectangle = Rectangle.Inflate(ClientRectangle, -1, -1);
			Rectangle rectangle2 = Rectangle.Inflate(rectangle, -borderSize, -borderSize);
			int num = ((borderSize > 0) ? (borderSize * 3) : 1);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle2, borderColor, borderColor2, gradientAngle))
			{
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					using (Pen pen = new Pen(Parent.BackColor, num))
					{
						using (Pen pen2 = new Pen(linearGradientBrush, borderSize))
						{
							graphics.SmoothingMode = SmoothingMode.AntiAlias;
							pen2.DashStyle = borderLineStyle;
							pen2.DashCap = borderCapStyle;
							graphicsPath.AddEllipse(rectangle);
							Region = new Region(graphicsPath);
							graphics.DrawEllipse(pen, rectangle);
							if (borderSize > 0)
							{
								graphics.DrawEllipse(pen2, rectangle2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0400075C RID: 1884
		private int borderSize = 2;

		// Token: 0x0400075D RID: 1885
		private Color borderColor = Color.RoyalBlue;

		// Token: 0x0400075E RID: 1886
		private Color borderColor2 = Color.HotPink;

		// Token: 0x0400075F RID: 1887
		private DashStyle borderLineStyle = DashStyle.Solid;

		// Token: 0x04000760 RID: 1888
		private DashCap borderCapStyle = DashCap.Flat;

		// Token: 0x04000761 RID: 1889
		private float gradientAngle = 50f;
	}
}
