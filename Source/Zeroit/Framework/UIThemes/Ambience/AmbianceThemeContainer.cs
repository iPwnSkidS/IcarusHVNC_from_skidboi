using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200006B RID: 107
	public class AmbianceThemeContainer : ContainerControl
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0000951E File Offset: 0x0000771E
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00009526 File Offset: 0x00007726
		public bool Sizable
		{
			get
			{
				return _Sizable;
			}
			set
			{
				_Sizable = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000952F File Offset: 0x0000772F
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00009537 File Offset: 0x00007737
		public bool SmartBounds
		{
			get
			{
				return _SmartBounds;
			}
			set
			{
				_SmartBounds = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00009540 File Offset: 0x00007740
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00009548 File Offset: 0x00007748
		public bool RoundCorners
		{
			get
			{
				return _RoundCorners;
			}
			set
			{
				_RoundCorners = value;
				Invalidate();
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00009557 File Offset: 0x00007757
		protected bool IsParentForm
		{
			get
			{
				return _IsParentForm;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000D430 File Offset: 0x0000B630
		protected bool IsParentMdi
		{
			get
			{
				return Parent != null && Parent.Parent != null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0000955F File Offset: 0x0000775F
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00009567 File Offset: 0x00007767
		protected bool ControlMode
		{
			get
			{
				return _ControlMode;
			}
			set
			{
				_ControlMode = value;
				Invalidate();
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00025920 File Offset: 0x00023B20
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00009576 File Offset: 0x00007776
		public FormStartPosition StartPosition
		{
			get
			{
				FormStartPosition formStartPosition;
				if (_IsParentForm && !_ControlMode)
				{
					formStartPosition = ParentForm.StartPosition;
				}
				else
				{
					formStartPosition = _StartPosition;
				}
				return formStartPosition;
			}
			set
			{
				_StartPosition = value;
				if (_IsParentForm && !_ControlMode)
				{
					ParentForm.StartPosition = value;
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00025958 File Offset: 0x00023B58
		protected sealed override void OnParentChanged(EventArgs eventArgs_0)
		{
			base.OnParentChanged(eventArgs_0);
			if (Parent != null)
			{
				_IsParentForm = Parent is Form;
				if (!_ControlMode)
				{
					InitializeMessages();
					if (_IsParentForm)
					{
						ParentForm.FormBorderStyle = FormBorderStyle.None;
						ParentForm.TransparencyKey = Color.Fuchsia;
						if (!DesignMode)
						{
							ParentForm.Shown += FormShown;
						}
					}
					Parent.BackColor = BackColor;
					Parent.MinimumSize = new Size(261, 65);
				}
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000959E File Offset: 0x0000779E
		protected sealed override void OnSizeChanged(EventArgs eventArgs_0)
		{
			base.OnSizeChanged(eventArgs_0);
			if (!_ControlMode)
			{
				HeaderRect = new Rectangle(0, 0, Width - 14, MoveHeight - 7);
			}
			Invalidate();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00025A10 File Offset: 0x00023C10
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			if (mevent.Button == MouseButtons.Left)
			{
				SetState(MouseState.Down);
			}
			if ((!_IsParentForm || ParentForm.WindowState != FormWindowState.Maximized) && !_ControlMode)
			{
				if (HeaderRect.Contains(mevent.Location))
				{
					Capture = false;
					WM_LMBUTTONDOWN = true;
					DefWndProc(ref Messages[0]);
				}
				else if (_Sizable && Previous != 0)
				{
					Capture = false;
					WM_LMBUTTONDOWN = true;
					DefWndProc(ref Messages[Previous]);
				}
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000095D6 File Offset: 0x000077D6
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			Cap = false;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00025AC8 File Offset: 0x00023CC8
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			if ((!_IsParentForm || ParentForm.WindowState != FormWindowState.Maximized) && _Sizable && !_ControlMode)
			{
				InvalidateMouse();
			}
			if (Cap)
			{
				//Parent.Location = (Point)(Convert.ToDouble(MousePosition) - Convert.ToDouble(MouseP));
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000095E6 File Offset: 0x000077E6
		protected override void OnInvalidated(InvalidateEventArgs invalidateEventArgs_0)
		{
			base.OnInvalidated(invalidateEventArgs_0);
			ParentForm.Text = Text;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00009600 File Offset: 0x00007800
		protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaintBackground(paintEventArgs_0);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00009609 File Offset: 0x00007809
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			base.OnTextChanged(eventArgs_0);
			Invalidate();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00025B50 File Offset: 0x00023D50
		private void FormShown(object sender, EventArgs e)
		{
			if (!_ControlMode && !HasShown)
			{
				if (_StartPosition == FormStartPosition.CenterParent || _StartPosition == FormStartPosition.CenterScreen)
				{
					Rectangle bounds = Screen.PrimaryScreen.Bounds;
					Rectangle bounds2 = ParentForm.Bounds;
					ParentForm.Location = new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2);
				}
				HasShown = true;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00009618 File Offset: 0x00007818
		private void SetState(MouseState current)
		{
			State = current;
			Invalidate();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00025BD8 File Offset: 0x00023DD8
		private int GetIndex()
		{
			GetIndexPoint = PointToClient(MousePosition);
			B1x = GetIndexPoint.X < 7;
			B2x = GetIndexPoint.X > Width - 7;
			B3 = GetIndexPoint.Y < 7;
			B4 = GetIndexPoint.Y > Height - 7;
			int num;
			if (B1x && B3)
			{
				num = 4;
			}
			else if (B1x && B4)
			{
				num = 7;
			}
			else if (B2x && B3)
			{
				num = 5;
			}
			else if (B2x && B4)
			{
				num = 8;
			}
			else if (B1x)
			{
				num = 1;
			}
			else if (B2x)
			{
				num = 2;
			}
			else if (B3)
			{
				num = 3;
			}
			else if (B4)
			{
				num = 6;
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00025CD8 File Offset: 0x00023ED8
		private void InvalidateMouse()
		{
			Current = GetIndex();
			if (Current != Previous)
			{
				Previous = Current;
				int previous = Previous;
				int num = previous;
				if (num != 0)
				{
					switch (num)
					{
					case 6:
						Cursor = Cursors.SizeNS;
						break;
					case 7:
						Cursor = Cursors.SizeNESW;
						break;
					case 8:
						Cursor = Cursors.SizeNWSE;
						break;
					}
				}
				else
				{
					Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00025D64 File Offset: 0x00023F64
		private void InitializeMessages()
		{
			Messages[0] = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
			for (int i = 1; i <= 8; i++)
			{
				Messages[i] = Message.Create(Parent.Handle, 161, new IntPtr(i + 9), IntPtr.Zero);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		private void CorrectBounds(Rectangle bounds)
		{
			if (Parent.Width > bounds.Width)
			{
				Parent.Width = bounds.Width;
			}
			if (Parent.Height > bounds.Height)
			{
				Parent.Height = bounds.Height;
			}
			int num = Parent.Location.X;
			int num2 = Parent.Location.Y;
			if (num < bounds.X)
			{
				num = bounds.X;
			}
			if (num2 < bounds.Y)
			{
				num2 = bounds.Y;
			}
			int num3 = bounds.X + bounds.Width;
			int num4 = bounds.Y + bounds.Height;
			if (num + Parent.Width > num3)
			{
				num = num3 - Parent.Width;
			}
			if (num2 + Parent.Height > num4)
			{
				num2 = num4 - Parent.Height;
			}
			Parent.Location = new Point(num, num2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00025DE0 File Offset: 0x00023FE0
		protected override void WndProc(ref Message message_0)
		{
			base.WndProc(ref message_0);
			if (WM_LMBUTTONDOWN && message_0.Msg == 513)
			{
				WM_LMBUTTONDOWN = false;
				SetState(MouseState.Over);
				if (_SmartBounds)
				{
					if (IsParentMdi)
					{
						CorrectBounds(new Rectangle(Point.Empty, Parent.Parent.Size));
					}
					else
					{
						CorrectBounds(Screen.FromControl(Parent).WorkingArea);
					}
				}
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00009627 File Offset: 0x00007827
		protected override void CreateHandle()
		{
			base.CreateHandle();
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00025E64 File Offset: 0x00024064
		public AmbianceThemeContainer()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			BackColor = Color.FromArgb(244, 241, 243);
			Padding = new Padding(20, 56, 20, 16);
			DoubleBuffered = true;
			Dock = DockStyle.Fill;
			MoveHeight = 48;
			Font = new Font("Segoe UI", 9f);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00025F14 File Offset: 0x00024114
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			graphics.Clear(Color.FromArgb(69, 68, 63));
			graphics.DrawRectangle(new Pen(Color.FromArgb(38, 38, 38)), new Rectangle(0, 0, Width - 1, Height - 1));
			graphics.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, 36), Color.FromArgb(87, 85, 77), Color.FromArgb(69, 68, 63)), new Rectangle(1, 1, Width - 2, 36));
			graphics.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(69, 68, 63), Color.FromArgb(69, 68, 63)), new Rectangle(1, 36, Width - 2, Height - 46));
			graphics.DrawRectangle(new Pen(Color.FromArgb(38, 38, 38)), new Rectangle(9, 47, Width - 19, Height - 55));
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(244, 241, 243)), new Rectangle(10, 48, Width - 20, Height - 56));
			if (_RoundCorners)
			{
				graphics.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 1, 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 1, 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 2, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 3, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 2, 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 2, 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 3, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 4, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 1, Height - 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 1, Height - 4, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 3, Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 2, Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 2, Height - 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 2, Height - 4, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 4, Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), Width - 3, Height - 2, 1, 1);
			}
			graphics.DrawString(Text, new Font("Tahoma", 12f, FontStyle.Bold), new SolidBrush(Color.FromArgb(223, 219, 210)), new Rectangle(0, 14, Width - 1, Height), new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Near
			});
		}

		// Token: 0x040002FC RID: 764
		private Rectangle HeaderRect;

		// Token: 0x040002FD RID: 765
		protected MouseState State;

		// Token: 0x040002FE RID: 766
		private int MoveHeight;

		// Token: 0x040002FF RID: 767
		private Point MouseP = new Point(0, 0);

		// Token: 0x04000300 RID: 768
		private bool Cap;

		// Token: 0x04000301 RID: 769
		private bool HasShown;

		// Token: 0x04000302 RID: 770
		private bool _Sizable = true;

		// Token: 0x04000303 RID: 771
		private bool _SmartBounds = true;

		// Token: 0x04000304 RID: 772
		private bool _RoundCorners = true;

		// Token: 0x04000305 RID: 773
		private bool _IsParentForm;

		// Token: 0x04000306 RID: 774
		private bool _ControlMode;

		// Token: 0x04000307 RID: 775
		private FormStartPosition _StartPosition;

		// Token: 0x04000308 RID: 776
		private Point GetIndexPoint;

		// Token: 0x04000309 RID: 777
		private bool B1x;

		// Token: 0x0400030A RID: 778
		private bool B2x;

		// Token: 0x0400030B RID: 779
		private bool B3;

		// Token: 0x0400030C RID: 780
		private bool B4;

		// Token: 0x0400030D RID: 781
		private int Current;

		// Token: 0x0400030E RID: 782
		private int Previous;

		// Token: 0x0400030F RID: 783
		private Message[] Messages = new Message[9];

		// Token: 0x04000310 RID: 784
		private bool WM_LMBUTTONDOWN;

		// Token: 0x0200006C RID: 108
		public enum MouseState
		{
			// Token: 0x04000312 RID: 786
			None,
			// Token: 0x04000313 RID: 787
			Over,
			// Token: 0x04000314 RID: 788
			Down,
			// Token: 0x04000315 RID: 789
			Block
		}
	}
}
