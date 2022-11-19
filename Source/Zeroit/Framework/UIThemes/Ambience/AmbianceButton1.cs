using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000052 RID: 82
	public class AmbianceButton1 : Control
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00021A84 File Offset: 0x0001FC84
		private static PointF ImageLocation(StringFormat stringFormat_0, SizeF Area, SizeF ImageArea)
		{
			PointF pointF = default(PointF);
			switch (stringFormat_0.Alignment)
			{
			case StringAlignment.Near:
				pointF.X = 2f;
				break;
			case StringAlignment.Center:
				pointF.X = Convert.ToSingle((Area.Width - ImageArea.Width) / 2f);
				break;
			case StringAlignment.Far:
				pointF.X = Area.Width - ImageArea.Width - 2f;
				break;
			}
			switch (stringFormat_0.LineAlignment)
			{
			case StringAlignment.Near:
				pointF.Y = 2f;
				break;
			case StringAlignment.Center:
				pointF.Y = Convert.ToSingle((Area.Height - ImageArea.Height) / 2f);
				break;
			case StringAlignment.Far:
				pointF.Y = Area.Height - ImageArea.Height - 2f;
				break;
			}
			return pointF;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00021B74 File Offset: 0x0001FD74
		private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
		{
			StringFormat stringFormat = new StringFormat();
			if (_ContentAlignment <= ContentAlignment.MiddleCenter)
			{
				switch (_ContentAlignment)
				{
				case ContentAlignment.TopLeft:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Near;
					break;
				case ContentAlignment.TopCenter:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Center;
					break;
				case (ContentAlignment)3:
					break;
				case ContentAlignment.TopRight:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Far;
					break;
				default:
					if (_ContentAlignment != ContentAlignment.MiddleLeft)
					{
						if (_ContentAlignment == ContentAlignment.MiddleCenter)
						{
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
						}
					}
					else
					{
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Alignment = StringAlignment.Near;
					}
					break;
				}
			}
			else if (_ContentAlignment <= ContentAlignment.BottomLeft)
			{
				if (_ContentAlignment != ContentAlignment.MiddleRight)
				{
					if (_ContentAlignment == ContentAlignment.BottomLeft)
					{
						stringFormat.LineAlignment = StringAlignment.Far;
						stringFormat.Alignment = StringAlignment.Near;
					}
				}
				else
				{
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else if (_ContentAlignment != ContentAlignment.BottomCenter)
			{
				if (_ContentAlignment == ContentAlignment.BottomRight)
				{
					stringFormat.LineAlignment = StringAlignment.Far;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else
			{
				stringFormat.LineAlignment = StringAlignment.Far;
				stringFormat.Alignment = StringAlignment.Center;
			}
			return stringFormat;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00021C80 File Offset: 0x0001FE80
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00008B28 File Offset: 0x00006D28
		public Image Image
		{
			get
			{
				return _Image;
			}
			set
			{
				if (value == null)
				{
					_ImageSize = Size.Empty;
				}
				else
				{
					_ImageSize = value.Size;
				}
				_Image = value;
				Invalidate();
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00021C98 File Offset: 0x0001FE98
		protected Size ImageSize
		{
			get
			{
				return _ImageSize;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00021CB0 File Offset: 0x0001FEB0
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00008B56 File Offset: 0x00006D56
		public ContentAlignment ImageAlign
		{
			get
			{
				return _ImageAlign;
			}
			set
			{
				_ImageAlign = value;
				Invalidate();
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00008B65 File Offset: 0x00006D65
		public StringAlignment TextAlignment
		{
			get
			{
				return _TextAlignment;
			}
			set
			{
				_TextAlignment = value;
				Invalidate();
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00021CE0 File Offset: 0x0001FEE0
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00008B74 File Offset: 0x00006D74
		public override Color ForeColor
		{
			get
			{
				return _TextColor;
			}
			set
			{
				_TextColor = value;
				Invalidate();
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00008B83 File Offset: 0x00006D83
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			MouseState = 0;
			Invalidate();
			base.OnMouseUp(mevent);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00008B99 File Offset: 0x00006D99
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			MouseState = 1;
			Focus();
			Invalidate();
			base.OnMouseDown(mevent);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00008BB6 File Offset: 0x00006DB6
		protected override void OnMouseLeave(EventArgs eventargs)
		{
			MouseState = 0;
			Invalidate();
			base.OnMouseLeave(eventargs);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00008BCC File Offset: 0x00006DCC
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			Invalidate();
			base.OnTextChanged(eventArgs_0);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		public AmbianceButton1()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 12f);
			ForeColor = Color.FromArgb(76, 76, 76);
			Size = new Size(177, 30);
			_TextAlignment = StringAlignment.Center;
			P1 = new Pen(Color.FromArgb(180, 180, 180));
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		protected override void OnResize(EventArgs eventArgs_0)
		{
			if (Width > 0 && Height > 0)
			{
				Shape = new GraphicsPath();
				R1 = new Rectangle(0, 0, Width, Height);
				InactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(253, 252, 252), Color.FromArgb(239, 237, 236), 90f);
				PressedGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(226, 226, 226), Color.FromArgb(237, 237, 237), 90f);
				PressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(167, 167, 167), Color.FromArgb(167, 167, 167), 90f);
				P3 = new Pen(PressedContourGB);
			}
			GraphicsPath shape = Shape;
			shape.AddArc(0, 0, 10, 10, 180f, 90f);
			shape.AddArc(Width - 11, 0, 10, 10, -90f, 90f);
			shape.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
			shape.AddArc(0, Height - 11, 10, 10, 90f, 90f);
			shape.CloseAllFigures();
			Invalidate();
			base.OnResize(eventArgs_0);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00021F80 File Offset: 0x00020180
		protected override void OnPaint(PaintEventArgs pevent)
		{
			Graphics graphics = pevent.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);
			int mouseState = MouseState;
			int num = mouseState;
			if (num != 0)
			{
				if (num == 1)
				{
					graphics.FillPath(PressedGB, Shape);
					graphics.DrawPath(P3, Shape);
					if (Image == null)
					{
						graphics.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
						{
							Alignment = _TextAlignment,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawImage(_Image, pointF.X, pointF.Y, ImageSize.Width, ImageSize.Height);
						graphics.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
						{
							Alignment = _TextAlignment,
							LineAlignment = StringAlignment.Center
						});
					}
				}
			}
			else
			{
				graphics.FillPath(InactiveGB, Shape);
				graphics.DrawPath(P1, Shape);
				if (Image == null)
				{
					graphics.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
					{
						Alignment = _TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawImage(_Image, pointF.X, pointF.Y, ImageSize.Width, ImageSize.Height);
					graphics.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
					{
						Alignment = _TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			base.OnPaint(pevent);
		}

		// Token: 0x04000293 RID: 659
		private int MouseState;

		// Token: 0x04000294 RID: 660
		private GraphicsPath Shape;

		// Token: 0x04000295 RID: 661
		private LinearGradientBrush InactiveGB;

		// Token: 0x04000296 RID: 662
		private LinearGradientBrush PressedGB;

		// Token: 0x04000297 RID: 663
		private LinearGradientBrush PressedContourGB;

		// Token: 0x04000298 RID: 664
		private Rectangle R1;

		// Token: 0x04000299 RID: 665
		private Pen P1;

		// Token: 0x0400029A RID: 666
		private Pen P3;

		// Token: 0x0400029B RID: 667
		private Image _Image;

		// Token: 0x0400029C RID: 668
		private Size _ImageSize;

		// Token: 0x0400029D RID: 669
		private StringAlignment _TextAlignment = StringAlignment.Center;

		// Token: 0x0400029E RID: 670
		private Color _TextColor = Color.FromArgb(150, 150, 150);

		// Token: 0x0400029F RID: 671
		private ContentAlignment _ImageAlign = ContentAlignment.MiddleLeft;
	}
}
