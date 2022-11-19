using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200006D RID: 109
	[DefaultEvent("ToggledChanged")]
	public class AmbianceToggle : Control
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060005BA RID: 1466 RVA: 0x0000962F File Offset: 0x0000782F
		// (remove) Token: 0x060005BB RID: 1467 RVA: 0x00009648 File Offset: 0x00007848
		public event ToggledChangedEventHandler ToggledChanged
		{
			add
			{
				ToggledChangedEvent = (ToggledChangedEventHandler)Delegate.Combine(ToggledChangedEvent, value);
			}
			remove
			{
				ToggledChangedEvent = (ToggledChangedEventHandler)Delegate.Remove(ToggledChangedEvent, value);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00009661 File Offset: 0x00007861
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00009669 File Offset: 0x00007869
		public bool Toggled
		{
			get
			{
				return _Toggled;
			}
			set
			{
				_Toggled = value;
				Invalidate();
				if (ToggledChangedEvent != null)
				{
					ToggledChangedEvent();
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00026628 File Offset: 0x00024828
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0000968E File Offset: 0x0000788E
		public _Type Type
		{
			get
			{
				return ToggleType;
			}
			set
			{
				ToggleType = value;
				Invalidate();
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000969D File Offset: 0x0000789D
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Width = 79;
			Height = 27;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000096B6 File Offset: 0x000078B6
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			Toggled = !Toggled;
			Focus();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000096D5 File Offset: 0x000078D5
		public AmbianceToggle()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00026640 File Offset: 0x00024840
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.Clear(Parent.BackColor);
			Rectangle rectangle = new Rectangle(0, 0, Width - 1, Height - 1);
			GraphicsPath graphicsPath = RoundRectangle.RoundRect(rectangle, 4);
			int num;
			LinearGradientBrush linearGradientBrush;
			if (_Toggled)
			{
				num = 37;
				linearGradientBrush = new LinearGradientBrush(rectangle, Color.FromArgb(231, 108, 58), Color.FromArgb(236, 113, 63), 90f);
			}
			else
			{
				num = 0;
				linearGradientBrush = new LinearGradientBrush(rectangle, Color.FromArgb(208, 208, 208), Color.FromArgb(226, 226, 226), 90f);
			}
			graphics.FillPath(linearGradientBrush, graphicsPath);
			switch (ToggleType)
			{
			case _Type.OnOff:
				if (Toggled)
				{
					graphics.DrawString("ON", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawString("OFF", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 59, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				break;
			case _Type.YesNo:
				if (Toggled)
				{
					graphics.DrawString("YES", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawString("NO", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 59, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				break;
			case _Type.const_2:
				if (Toggled)
				{
					graphics.DrawString("I", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawString("O", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 59, (float)(Bar.Y + 13.5), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				break;
			}
			Rectangle rectangle2 = new Rectangle(num, 0, Width - 38, Height);
			GraphicsPath graphicsPath2 = RoundRectangle.RoundRect(rectangle2, 4);
			LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rectangle2, Color.FromArgb(253, 253, 253), Color.FromArgb(240, 238, 237), LinearGradientMode.Vertical);
			graphics.FillPath(linearGradientBrush2, graphicsPath2);
			if (_Toggled)
			{
				graphics.DrawPath(new Pen(Color.FromArgb(185, 89, 55)), graphicsPath2);
				graphics.DrawPath(new Pen(Color.FromArgb(185, 89, 55)), graphicsPath);
			}
			else
			{
				graphics.DrawPath(new Pen(Color.FromArgb(181, 181, 181)), graphicsPath2);
				graphics.DrawPath(new Pen(Color.FromArgb(181, 181, 181)), graphicsPath);
			}
		}

		// Token: 0x04000316 RID: 790
		private ToggledChangedEventHandler ToggledChangedEvent;

		// Token: 0x04000317 RID: 791
		private bool _Toggled;

		// Token: 0x04000318 RID: 792
		private _Type ToggleType;

		// Token: 0x04000319 RID: 793
		private Rectangle Bar;

		// Token: 0x0400031A RID: 794
		private Size cHandle = new Size(15, 20);

		// Token: 0x0200006E RID: 110
		public enum _Type
		{
			// Token: 0x0400031C RID: 796
			OnOff,
			// Token: 0x0400031D RID: 797
			YesNo,
			// Token: 0x0400031E RID: 798
			const_2
		}

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060005C5 RID: 1477
		public delegate void ToggledChangedEventHandler();
	}
}
