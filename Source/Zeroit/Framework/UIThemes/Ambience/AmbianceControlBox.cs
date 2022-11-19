using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000057 RID: 87
	public class AmbianceControlBox : Control
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00008D40 File Offset: 0x00006F40
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			State = MouseState.Down;
			Invalidate();
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00022E34 File Offset: 0x00021034
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (int_0 > 3 && int_0 < 20)
			{
				FindForm().Close();
			}
			else if (int_0 > 23 && int_0 < 40)
			{
				FindForm().WindowState = FormWindowState.Minimized;
			}
			else if (int_0 > 43 && int_0 < 60 && _EnableMaximize)
			{
				if (FindForm().WindowState == FormWindowState.Maximized)
				{
					FindForm().WindowState = FormWindowState.Minimized;
					FindForm().WindowState = FormWindowState.Normal;
				}
				else
				{
					FindForm().WindowState = FormWindowState.Minimized;
					FindForm().WindowState = FormWindowState.Maximized;
				}
			}
			State = MouseState.Over;
			Invalidate();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00008D56 File Offset: 0x00006F56
		protected override void OnMouseEnter(EventArgs eventargs)
		{
			base.OnMouseEnter(eventargs);
			State = MouseState.Over;
			Invalidate();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00008D6C File Offset: 0x00006F6C
		protected override void OnMouseLeave(EventArgs eventargs)
		{
			base.OnMouseLeave(eventargs);
			State = MouseState.None;
			Invalidate();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00022F00 File Offset: 0x00021100
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			int_0 = mevent.Location.X;
			Invalidate();
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00008D82 File Offset: 0x00006F82
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00008D8A File Offset: 0x00006F8A
		public bool EnableMaximize
		{
			get
			{
				return _EnableMaximize;
			}
			set
			{
				_EnableMaximize = value;
				if (_EnableMaximize)
				{
					Size = new Size(64, 22);
				}
				else
				{
					Size = new Size(44, 22);
				}
				Invalidate();
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00022F30 File Offset: 0x00021130
		public AmbianceControlBox()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.DoubleBuffer, true);
			DoubleBuffered = true;
			BackColor = Color.Transparent;
			Font = new Font("Marlett", 7f);
			Anchor = AnchorStyles.Top | AnchorStyles.Left;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00008DC1 File Offset: 0x00006FC1
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			if (_EnableMaximize)
			{
				Size = new Size(64, 22);
			}
			else
			{
				Size = new Size(44, 22);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00008DF2 File Offset: 0x00006FF2
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			Location = new Point(5, 13);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00022FC0 File Offset: 0x000211C0
		protected override void OnPaint(PaintEventArgs pevent)
		{
			Bitmap bitmap = new Bitmap(Width, Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			base.OnPaint(pevent);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(CloseBtn, Color.FromArgb(242, 132, 99), Color.FromArgb(224, 82, 33), 90f);
			graphics.FillEllipse(linearGradientBrush, CloseBtn);
			graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), CloseBtn);
			graphics.DrawString("r", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(6, 8, 0, 0));
			LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(MinBtn, Color.FromArgb(130, 129, 123), Color.FromArgb(103, 102, 96), 90f);
			graphics.FillEllipse(linearGradientBrush2, MinBtn);
			graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MinBtn);
			graphics.DrawString("0", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(26, 4, 0, 0));
			if (_EnableMaximize)
			{
				LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(MaxBtn, Color.FromArgb(130, 129, 123), Color.FromArgb(103, 102, 96), 90f);
				graphics.FillEllipse(linearGradientBrush3, MaxBtn);
				graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MaxBtn);
				graphics.DrawString("1", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(46, 7, 0, 0));
			}
			MouseState state = State;
			MouseState mouseState = state;
			if (mouseState != MouseState.None)
			{
				if (mouseState == MouseState.Over)
				{
					if (int_0 > 3 && int_0 < 20)
					{
						LinearGradientBrush linearGradientBrush4 = new LinearGradientBrush(CloseBtn, Color.FromArgb(248, 152, 124), Color.FromArgb(231, 92, 45), 90f);
						graphics.FillEllipse(linearGradientBrush4, CloseBtn);
						graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), CloseBtn);
						graphics.DrawString("r", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(6, 8, 0, 0));
					}
					else if (int_0 > 23 && int_0 < 40)
					{
						LinearGradientBrush linearGradientBrush5 = new LinearGradientBrush(MinBtn, Color.FromArgb(196, 196, 196), Color.FromArgb(173, 173, 173), 90f);
						graphics.FillEllipse(linearGradientBrush5, MinBtn);
						graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MinBtn);
						graphics.DrawString("0", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(26, 4, 0, 0));
					}
					else if (int_0 > 43 && int_0 < 60 && _EnableMaximize)
					{
						LinearGradientBrush linearGradientBrush6 = new LinearGradientBrush(MaxBtn, Color.FromArgb(196, 196, 196), Color.FromArgb(173, 173, 173), 90f);
						graphics.FillEllipse(linearGradientBrush6, MaxBtn);
						graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MaxBtn);
						graphics.DrawString("1", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(46, 7, 0, 0));
					}
				}
			}
			else
			{
				LinearGradientBrush linearGradientBrush7 = new LinearGradientBrush(CloseBtn, Color.FromArgb(242, 132, 99), Color.FromArgb(224, 82, 33), 90f);
				graphics.FillEllipse(linearGradientBrush7, CloseBtn);
				graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), CloseBtn);
				graphics.DrawString("r", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(6, 8, 0, 0));
				LinearGradientBrush linearGradientBrush8 = new LinearGradientBrush(MinBtn, Color.FromArgb(130, 129, 123), Color.FromArgb(103, 102, 96), 90f);
				graphics.FillEllipse(linearGradientBrush8, MinBtn);
				graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MinBtn);
				graphics.DrawString("0", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(26, 4, 0, 0));
				if (_EnableMaximize)
				{
					LinearGradientBrush linearGradientBrush9 = new LinearGradientBrush(MaxBtn, Color.FromArgb(130, 129, 123), Color.FromArgb(103, 102, 96), 90f);
					graphics.FillEllipse(linearGradientBrush9, MaxBtn);
					graphics.DrawEllipse(new Pen(Color.FromArgb(57, 56, 53)), MaxBtn);
					graphics.DrawString("1", new Font("Marlett", 7f), new SolidBrush(Color.FromArgb(52, 50, 46)), new Rectangle(46, 7, 0, 0));
				}
			}
			pevent.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040002B5 RID: 693
		private MouseState State = MouseState.None;

		// Token: 0x040002B6 RID: 694
		private int int_0;

		// Token: 0x040002B7 RID: 695
		private Rectangle CloseBtn = new Rectangle(3, 2, 17, 17);

		// Token: 0x040002B8 RID: 696
		private Rectangle MinBtn = new Rectangle(23, 2, 17, 17);

		// Token: 0x040002B9 RID: 697
		private Rectangle MaxBtn = new Rectangle(43, 2, 17, 17);

		// Token: 0x040002BA RID: 698
		private bool _EnableMaximize = true;

		// Token: 0x02000058 RID: 88
		public enum MouseState
		{
			// Token: 0x040002BC RID: 700
			None,
			// Token: 0x040002BD RID: 701
			Over,
			// Token: 0x040002BE RID: 702
			Down
		}
	}
}
