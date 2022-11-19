using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000053 RID: 83
	public class AmbianceButton2 : Control
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x00021A84 File Offset: 0x0001FC84
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

		// Token: 0x060004E8 RID: 1256 RVA: 0x00021B74 File Offset: 0x0001FD74
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000221C0 File Offset: 0x000203C0
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00008BDB File Offset: 0x00006DDB
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000221D8 File Offset: 0x000203D8
		protected Size ImageSize
		{
			get
			{
				return _ImageSize;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000221F0 File Offset: 0x000203F0
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00008C09 File Offset: 0x00006E09
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00022208 File Offset: 0x00020408
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00008C18 File Offset: 0x00006E18
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00022220 File Offset: 0x00020420
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00008C27 File Offset: 0x00006E27
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

		// Token: 0x060004F2 RID: 1266 RVA: 0x00008C36 File Offset: 0x00006E36
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			MouseState = 0;
			Invalidate();
			base.OnMouseUp(mevent);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00008C4C File Offset: 0x00006E4C
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			MouseState = 1;
			Focus();
			Invalidate();
			base.OnMouseDown(mevent);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00008C69 File Offset: 0x00006E69
		protected override void OnMouseLeave(EventArgs eventargs)
		{
			MouseState = 0;
			Invalidate();
			base.OnMouseLeave(eventargs);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00008BCC File Offset: 0x00006DCC
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			Invalidate();
			base.OnTextChanged(eventArgs_0);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00022238 File Offset: 0x00020438
		public AmbianceButton2()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 11f, FontStyle.Bold);
			ForeColor = Color.FromArgb(76, 76, 76);
			Size = new Size(177, 30);
			_TextAlignment = StringAlignment.Center;
			P1 = new Pen(Color.FromArgb(162, 120, 101));
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000222EC File Offset: 0x000204EC
		protected override void OnResize(EventArgs eventArgs_0)
		{
			if (Width > 0 && Height > 0)
			{
				Shape = new GraphicsPath();
				R1 = new Rectangle(0, 0, Width, Height);
				InactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(253, 175, 143), Color.FromArgb(244, 146, 106), 90f);
				PressedGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(244, 146, 106), Color.FromArgb(244, 146, 106), 90f);
				PressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(162, 120, 101), Color.FromArgb(162, 120, 101), 90f);
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x000224A8 File Offset: 0x000206A8
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

		// Token: 0x040002A0 RID: 672
		private int MouseState;

		// Token: 0x040002A1 RID: 673
		private GraphicsPath Shape;

		// Token: 0x040002A2 RID: 674
		private LinearGradientBrush InactiveGB;

		// Token: 0x040002A3 RID: 675
		private LinearGradientBrush PressedGB;

		// Token: 0x040002A4 RID: 676
		private LinearGradientBrush PressedContourGB;

		// Token: 0x040002A5 RID: 677
		private Rectangle R1;

		// Token: 0x040002A6 RID: 678
		private Pen P1;

		// Token: 0x040002A7 RID: 679
		private Pen P3;

		// Token: 0x040002A8 RID: 680
		private Image _Image;

		// Token: 0x040002A9 RID: 681
		private Size _ImageSize;

		// Token: 0x040002AA RID: 682
		private StringAlignment _TextAlignment = StringAlignment.Center;

		// Token: 0x040002AB RID: 683
		private Color _TextColor = Color.FromArgb(150, 150, 150);

		// Token: 0x040002AC RID: 684
		private ContentAlignment _ImageAlign = ContentAlignment.MiddleLeft;
	}
}
