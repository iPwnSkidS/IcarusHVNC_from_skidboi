using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200005D RID: 93
	public class AmbianceNumericUpDown : Control
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00023870 File Offset: 0x00021A70
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00008EBB File Offset: 0x000070BB
		public long Value
		{
			get
			{
				return _Value;
			}
			set
			{
				if ((value <= _Maximum) & (value >= _Minimum))
				{
					_Value = value;
				}
				Invalidate();
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00023888 File Offset: 0x00021A88
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00008EE5 File Offset: 0x000070E5
		public long Minimum
		{
			get
			{
				return _Minimum;
			}
			set
			{
				if (value < _Maximum)
				{
					_Minimum = value;
				}
				if (_Value < _Minimum)
				{
					_Value = Minimum;
				}
				Invalidate();
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000238A0 File Offset: 0x00021AA0
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00008F1B File Offset: 0x0000711B
		public long Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value > _Minimum)
				{
					_Maximum = value;
				}
				if (_Value > _Maximum)
				{
					_Value = _Maximum;
				}
				Invalidate();
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x000238B8 File Offset: 0x00021AB8
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00008F51 File Offset: 0x00007151
		public _TextAlignment TextAlignment
		{
			get
			{
				return MyStringAlignment;
			}
			set
			{
				MyStringAlignment = value;
				Invalidate();
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000238D0 File Offset: 0x00021AD0
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Height = 28;
			MinimumSize = new Size(93, 28);
			Shape = new GraphicsPath();
			Shape.AddArc(0, 0, 10, 10, 180f, 90f);
			Shape.AddArc(Width - 11, 0, 10, 10, -90f, 90f);
			Shape.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
			Shape.AddArc(0, Height - 11, 10, 10, 90f, 90f);
			Shape.CloseAllFigures();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000239A0 File Offset: 0x00021BA0
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			Xval = mevent.Location.X;
			Invalidate();
			if (mevent.X < Width - 50)
			{
				Cursor = Cursors.IBeam;
			}
			else
			{
				Cursor = Cursors.Default;
			}
			if (mevent.X > Width - 25 && mevent.X < Width - 10)
			{
				Cursor = Cursors.Hand;
			}
			if (mevent.X > Width - 44 && mevent.X < Width - 33)
			{
				Cursor = Cursors.Hand;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00023A58 File Offset: 0x00021C58
		private void ClickButton()
		{
			if (Xval > Width - 25 && Xval < Width - 10)
			{
				if (Value + 1L <= _Maximum)
				{
					_Value += 1L;
				}
			}
			else
			{
				if (Xval > Width - 44 && Xval < Width - 33 && Value - 1L >= _Minimum)
				{
					_Value -= 1L;
				}
				KeyboardNum = !KeyboardNum;
			}
			Focus();
			Invalidate();
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00008F60 File Offset: 0x00007160
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseClick(mevent);
			ClickButton();
			LongPressTimer.Start();
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00008F7A File Offset: 0x0000717A
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			LongPressTimer.Stop();
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00008F8E File Offset: 0x0000718E
		private void LongPressTimer_Tick(object sender, EventArgs e)
		{
			ClickButton();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00023B34 File Offset: 0x00021D34
		protected override void OnKeyPress(KeyPressEventArgs keyPressEventArgs_0)
		{
			base.OnKeyPress(keyPressEventArgs_0);
			try
			{
				if (KeyboardNum)
				{
					_Value = long.Parse(_Value + keyPressEventArgs_0.KeyChar.ToString());
				}
				if (_Value > _Maximum)
				{
					_Value = _Maximum;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00023BB0 File Offset: 0x00021DB0
		protected override void OnKeyUp(KeyEventArgs kevent)
		{
			base.OnKeyUp(kevent);
			if (kevent.KeyCode == Keys.Back)
			{
				string text = _Value.ToString();
				text = text.Remove(Convert.ToInt32(text.Length - 1));
				if (text.Length == 0)
				{
					text = "0";
				}
				_Value = Convert.ToInt32(text);
			}
			Invalidate();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00023C14 File Offset: 0x00021E14
		protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
		{
			base.OnMouseWheel(mouseEventArgs_0);
			if (mouseEventArgs_0.Delta > 0)
			{
				if (Value + 1L <= _Maximum)
				{
					_Value += 1L;
				}
				Invalidate();
			}
			else
			{
				if (Value - 1L >= _Minimum)
				{
					_Value -= 1L;
				}
				Invalidate();
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public AmbianceNumericUpDown()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.UserPaint, true);
			P1 = new Pen(Color.FromArgb(180, 180, 180));
			BackColor = Color.Transparent;
			ForeColor = Color.FromArgb(76, 76, 76);
			_Minimum = 0L;
			_Maximum = 100L;
			Font = new Font("Tahoma", 11f);
			Size = new Size(70, 28);
			MinimumSize = new Size(62, 28);
			DoubleBuffered = true;
			LongPressTimer.Tick += LongPressTimer_Tick;
			LongPressTimer.Interval = 300;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00008F96 File Offset: 0x00007196
		public void Increment(int Value)
		{
			_Value += Value;
			Invalidate();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00008FAD File Offset: 0x000071AD
		public void Decrement(int Value)
		{
			_Value -= Value;
			Invalidate();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00023D94 File Offset: 0x00021F94
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Bitmap bitmap = new Bitmap(Width, Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(ClientRectangle, Color.FromArgb(246, 246, 246), Color.FromArgb(254, 254, 254), 90f);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(linearGradientBrush, Shape);
			graphics.DrawPath(P1, Shape);
			graphics.DrawString("+", new Font("Tahoma", 14f), new SolidBrush(Color.FromArgb(75, 75, 75)), new Rectangle(Width - 25, 1, 19, 30));
			graphics.DrawLine(new Pen(Color.FromArgb(229, 228, 227)), Width - 28, 1, Width - 28, Height - 2);
			graphics.DrawString("-", new Font("Tahoma", 14f), new SolidBrush(Color.FromArgb(75, 75, 75)), new Rectangle(Width - 44, 1, 19, 30));
			graphics.DrawLine(new Pen(Color.FromArgb(229, 228, 227)), Width - 48, 1, Width - 48, Height - 2);
			_TextAlignment myStringAlignment = MyStringAlignment;
			_TextAlignment textAlignment = myStringAlignment;
			if (textAlignment != _TextAlignment.Near)
			{
				if (textAlignment == _TextAlignment.Center)
				{
					graphics.DrawString(Convert.ToString(Value), Font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			else
			{
				graphics.DrawString(Convert.ToString(Value), Font, new SolidBrush(ForeColor), new Rectangle(5, 0, Width - 1, Height - 1), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Center
				});
			}
			pevent.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040002BF RID: 703
		private GraphicsPath Shape;

		// Token: 0x040002C0 RID: 704
		private Pen P1;

		// Token: 0x040002C1 RID: 705
		private long _Value;

		// Token: 0x040002C2 RID: 706
		private long _Minimum;

		// Token: 0x040002C3 RID: 707
		private long _Maximum;

		// Token: 0x040002C4 RID: 708
		private int Xval;

		// Token: 0x040002C5 RID: 709
		private bool KeyboardNum;

		// Token: 0x040002C6 RID: 710
		private _TextAlignment MyStringAlignment;

		// Token: 0x040002C7 RID: 711
		private Timer LongPressTimer = new Timer();

		// Token: 0x0200005E RID: 94
		public enum _TextAlignment
		{
			// Token: 0x040002C9 RID: 713
			Near,
			// Token: 0x040002CA RID: 714
			Center
		}
	}
}
