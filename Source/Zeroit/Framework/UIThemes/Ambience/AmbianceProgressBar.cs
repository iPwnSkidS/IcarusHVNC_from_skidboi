using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000060 RID: 96
	public class AmbianceProgressBar : Control
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000240BC File Offset: 0x000222BC
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00008FE0 File Offset: 0x000071E0
		public int Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value < 1)
				{
					value = 1;
				}
				if (value < _Value)
				{
					_Value = value;
				}
				_Maximum = value;
				Invalidate();
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000240D4 File Offset: 0x000222D4
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000900A File Offset: 0x0000720A
		public int Minimum
		{
			get
			{
				return _Minimum;
			}
			set
			{
				_Minimum = value;
				if (value > _Maximum)
				{
					_Maximum = value;
				}
				if (value > _Value)
				{
					_Value = value;
				}
				Invalidate();
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000240EC File Offset: 0x000222EC
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0000903D File Offset: 0x0000723D
		public int Value
		{
			get
			{
				return _Value;
			}
			set
			{
				if (value > _Maximum)
				{
					value = Maximum;
				}
				_Value = value;
				Invalidate();
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00024104 File Offset: 0x00022304
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0000905F File Offset: 0x0000725F
		public Alignment ValueAlignment
		{
			get
			{
				return ALN;
			}
			set
			{
				ALN = value;
				Invalidate();
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000906E File Offset: 0x0000726E
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00009076 File Offset: 0x00007276
		public bool DrawHatch
		{
			get
			{
				return _DrawHatch;
			}
			set
			{
				_DrawHatch = value;
				Invalidate();
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00009085 File Offset: 0x00007285
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000908D File Offset: 0x0000728D
		public bool ShowPercentage
		{
			get
			{
				return _ShowPercentage;
			}
			set
			{
				_ShowPercentage = value;
				Invalidate();
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002411C File Offset: 0x0002231C
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Height = 20;
			Size size = new Size(58, 20);
			MinimumSize = size;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002414C File Offset: 0x0002234C
		public AmbianceProgressBar()
		{
			_Maximum = 100;
			_ShowPercentage = true;
			_DrawHatch = true;
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.UserPaint, true);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000909C File Offset: 0x0000729C
		public void Increment(int value)
		{
			_Value += value;
			Invalidate();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000090B2 File Offset: 0x000072B2
		public void Deincrement(int value)
		{
			_Value -= value;
			Invalidate();
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000241AC File Offset: 0x000223AC
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Bitmap bitmap = new Bitmap(Width, Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.Clear(Color.Transparent);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			GP1 = RoundRectangle.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 4);
			GP2 = RoundRectangle.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 4);
			R1 = new Rectangle(0, 2, Width - 1, Height - 1);
			GB1 = new LinearGradientBrush(R1, Color.FromArgb(255, 255, 255), Color.FromArgb(230, 230, 230), 90f);
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(244, 241, 243)), R1);
			graphics.SetClip(GP1);
			graphics.FillPath(new SolidBrush(Color.FromArgb(244, 241, 243)), RoundRectangle.RoundRect(new Rectangle(1, 1, Width - 3, Height / 2 - 2), 4));
			I1 = (int)Math.Round((_Value - _Minimum) / (double)(_Maximum - _Minimum) * (Width - 3));
			if (I1 > 1)
			{
				GP3 = RoundRectangle.RoundRect(new Rectangle(1, 1, I1, Height - 3), 4);
				R2 = new Rectangle(1, 1, I1, Height - 3);
				GB2 = new LinearGradientBrush(R2, Color.FromArgb(214, 89, 37), Color.FromArgb(223, 118, 75), 90f);
				graphics.FillPath(GB2, GP3);
				if (_DrawHatch)
				{
					for (int i = 0; i <= (Width - 1) * _Maximum / _Value; i += 20)
					{
						graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(25, Color.White)), 10f), new Point(Convert.ToInt32(i), 0), new Point(i - 10, Height));
					}
				}
				graphics.SetClip(GP3);
				graphics.SmoothingMode = SmoothingMode.None;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.ResetClip();
			}
			string text = Convert.ToString(Convert.ToInt32(Value)) + "%";
			int num = (int)(Width - graphics.MeasureString(text, Font).Width - 1f);
			int num2 = Height / 2 - (Convert.ToInt32(graphics.MeasureString(text, Font).Height / 2f) - 2);
			if (_ShowPercentage)
			{
				Alignment valueAlignment = ValueAlignment;
				Alignment alignment = valueAlignment;
				if (alignment != Alignment.Right)
				{
					if (alignment == Alignment.Center)
					{
						graphics.DrawString(text, new Font("Segoe UI", 8f), Brushes.DimGray, new Rectangle(0, 0, Width, Height + 2), new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
				}
				else
				{
					graphics.DrawString(text, new Font("Segoe UI", 8f), Brushes.DimGray, new Point(num, num2));
				}
			}
			graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), GP2);
			pevent.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040002CB RID: 715
		private int _Minimum;

		// Token: 0x040002CC RID: 716
		private int _Maximum = 100;

		// Token: 0x040002CD RID: 717
		private int _Value;

		// Token: 0x040002CE RID: 718
		private Alignment ALN;

		// Token: 0x040002CF RID: 719
		private bool _DrawHatch;

		// Token: 0x040002D0 RID: 720
		private bool _ShowPercentage;

		// Token: 0x040002D1 RID: 721
		private GraphicsPath GP1;

		// Token: 0x040002D2 RID: 722
		private GraphicsPath GP2;

		// Token: 0x040002D3 RID: 723
		private GraphicsPath GP3;

		// Token: 0x040002D4 RID: 724
		private Rectangle R1;

		// Token: 0x040002D5 RID: 725
		private Rectangle R2;

		// Token: 0x040002D6 RID: 726
		private LinearGradientBrush GB1;

		// Token: 0x040002D7 RID: 727
		private LinearGradientBrush GB2;

		// Token: 0x040002D8 RID: 728
		private int I1;

		// Token: 0x02000061 RID: 97
		public enum Alignment
		{
			// Token: 0x040002DA RID: 730
			Right,
			// Token: 0x040002DB RID: 731
			Center
		}
	}
}
