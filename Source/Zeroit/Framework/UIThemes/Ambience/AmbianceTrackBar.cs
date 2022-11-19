using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000070 RID: 112
	[DefaultEvent("ValueChanged")]
	public class AmbianceTrackBar : Control
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00026A58 File Offset: 0x00024C58
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x000096F8 File Offset: 0x000078F8
		public int Minimum
		{
			get
			{
				return _Minimum;
			}
			set
			{
				if (value >= _Maximum)
				{
					value = _Maximum - 10;
				}
				if (_Value < value)
				{
					_Value = value;
				}
				_Minimum = value;
				Invalidate();
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00026A70 File Offset: 0x00024C70
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00009732 File Offset: 0x00007932
		public int Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value <= _Minimum)
				{
					value = _Minimum + 10;
				}
				if (_Value > value)
				{
					_Value = value;
				}
				_Maximum = value;
				Invalidate();
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060005CC RID: 1484 RVA: 0x0000976C File Offset: 0x0000796C
		// (remove) Token: 0x060005CD RID: 1485 RVA: 0x00009785 File Offset: 0x00007985
		public event ValueChangedEventHandler ValueChanged
		{
			add
			{
				ValueChangedEvent = (ValueChangedEventHandler)Delegate.Combine(ValueChangedEvent, value);
			}
			remove
			{
				ValueChangedEvent = (ValueChangedEventHandler)Delegate.Remove(ValueChangedEvent, value);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00026A88 File Offset: 0x00024C88
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00026AA0 File Offset: 0x00024CA0
		public int Value
		{
			get
			{
				return _Value;
			}
			set
			{
				if (_Value != value)
				{
					if (value < _Minimum)
					{
						_Value = _Minimum;
					}
					else if (value > _Maximum)
					{
						_Value = _Maximum;
					}
					else
					{
						_Value = value;
					}
					Invalidate();
					if (ValueChangedEvent != null)
					{
						ValueChangedEvent();
					}
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00026B10 File Offset: 0x00024D10
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000979E File Offset: 0x0000799E
		public ValueDivisor ValueDivison
		{
			get
			{
				return DividedValue;
			}
			set
			{
				DividedValue = value;
				Invalidate();
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00026B28 File Offset: 0x00024D28
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000097AD File Offset: 0x000079AD
		[Browsable(false)]
		public float ValueToSet
		{
			get
			{
				return _Value / (int)DividedValue;
			}
			set
			{
				Value = (int)(value * (float)DividedValue);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000097BF File Offset: 0x000079BF
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x000097C7 File Offset: 0x000079C7
		public bool JumpToMouse
		{
			get
			{
				return _JumpToMouse;
			}
			set
			{
				_JumpToMouse = value;
				Invalidate();
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000097D6 File Offset: 0x000079D6
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x000097DE File Offset: 0x000079DE
		public bool DrawValueString
		{
			get
			{
				return _DrawValueString;
			}
			set
			{
				_DrawValueString = value;
				if (_DrawValueString)
				{
					Height = 35;
				}
				else
				{
					Height = 22;
				}
				Invalidate();
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00026B48 File Offset: 0x00024D48
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			base.OnMouseMove(mevent);
			checked
			{
				if (Cap && mevent.X > -1 && mevent.X < Width + 1)
				{
					Value = _Minimum + (int)Math.Round(checked(_Maximum - _Minimum) * (mevent.X / (double)Width));
				}
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00026BB0 File Offset: 0x00024DB0
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			checked
			{
				if (mevent.Button == MouseButtons.Left)
				{
					ValueDrawer = (int)Math.Round(checked((_Value - _Minimum) / (double)(_Maximum - _Minimum)) * checked(Width - 11));
					TrackBarHandleRect = new Rectangle(ValueDrawer, 0, 25, 25);
					Cap = TrackBarHandleRect.Contains(mevent.Location);
					Focus();
					if (_JumpToMouse)
					{
						Value = _Minimum + (int)Math.Round(checked(_Maximum - _Minimum) * (mevent.X / (double)Width));
					}
				}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00009807 File Offset: 0x00007A07
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			Cap = false;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00026C78 File Offset: 0x00024E78
		public AmbianceTrackBar()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			Size = new Size(80, 22);
			MinimumSize = new Size(47, 22);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00009817 File Offset: 0x00007A17
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			if (_DrawValueString)
			{
				Height = 35;
			}
			else
			{
				Height = 22;
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00026CF0 File Offset: 0x00024EF0
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			graphics.Clear(Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			TrackThumb = new Rectangle(8, 10, Width - 16, 2);
			PipeBorder = RoundRectangle.RoundRect(1, 8, Width - 3, 5, 2);
			try
			{
				ValueDrawer = (int)Math.Round((_Value - _Minimum) / (double)(_Maximum - _Minimum) * (Width - 11));
			}
			catch (Exception)
			{
			}
			TrackBarHandleRect = new Rectangle(ValueDrawer, 0, 10, 20);
			graphics.SetClip(PipeBorder);
			graphics.FillPath(new SolidBrush(Color.FromArgb(221, 221, 221)), PipeBorder);
			FillValue = RoundRectangle.RoundRect(1, 8, TrackBarHandleRect.X + TrackBarHandleRect.Width - 4, 5, 2);
			graphics.ResetClip();
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.DrawPath(new Pen(Color.FromArgb(200, 200, 200)), PipeBorder);
			graphics.FillPath(new SolidBrush(Color.FromArgb(217, 99, 50)), FillValue);
			graphics.FillEllipse(new SolidBrush(Color.FromArgb(244, 244, 244)), TrackThumb.X + (int)Math.Round(TrackThumb.Width * (Value / (double)Maximum)) - (int)Math.Round(ThumbSize.Width / 2.0), TrackThumb.Y + (int)Math.Round(TrackThumb.Height / 2.0) - (int)Math.Round(ThumbSize.Height / 2.0), ThumbSize.Width, ThumbSize.Height);
			graphics.DrawEllipse(new Pen(Color.FromArgb(180, 180, 180)), TrackThumb.X + (int)Math.Round(TrackThumb.Width * (Value / (double)Maximum)) - (int)Math.Round(ThumbSize.Width / 2.0), TrackThumb.Y + (int)Math.Round(TrackThumb.Height / 2.0) - (int)Math.Round(ThumbSize.Height / 2.0), ThumbSize.Width, ThumbSize.Height);
			if (_DrawValueString)
			{
				graphics.DrawString(Convert.ToString(ValueToSet), Font, Brushes.DimGray, 1f, 20f);
			}
		}

		// Token: 0x0400031F RID: 799
		private GraphicsPath PipeBorder;

		// Token: 0x04000320 RID: 800
		private GraphicsPath FillValue;

		// Token: 0x04000321 RID: 801
		private Rectangle TrackBarHandleRect;

		// Token: 0x04000322 RID: 802
		private bool Cap;

		// Token: 0x04000323 RID: 803
		private int ValueDrawer;

		// Token: 0x04000324 RID: 804
		private Size ThumbSize = new Size(15, 15);

		// Token: 0x04000325 RID: 805
		private Rectangle TrackThumb;

		// Token: 0x04000326 RID: 806
		private int _Minimum;

		// Token: 0x04000327 RID: 807
		private int _Maximum = 10;

		// Token: 0x04000328 RID: 808
		private int _Value;

		// Token: 0x04000329 RID: 809
		private bool _DrawValueString;

		// Token: 0x0400032A RID: 810
		private bool _JumpToMouse;

		// Token: 0x0400032B RID: 811
		private ValueDivisor DividedValue = ValueDivisor.By1;

		// Token: 0x0400032C RID: 812
		private ValueChangedEventHandler ValueChangedEvent;

		// Token: 0x02000071 RID: 113
		public enum ValueDivisor
		{
			// Token: 0x0400032E RID: 814
			By1 = 1,
			// Token: 0x0400032F RID: 815
			By10 = 10,
			// Token: 0x04000330 RID: 816
			By100 = 100,
			// Token: 0x04000331 RID: 817
			By1000 = 1000
		}

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060005DF RID: 1503
		public delegate void ValueChangedEventHandler();
	}
}
