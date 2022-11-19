using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000069 RID: 105
	[DefaultEvent("TextChanged")]
	public class AmbianceTextBox : Control
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000251E4 File Offset: 0x000233E4
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000093CD File Offset: 0x000075CD
		public HorizontalAlignment TextAlignment
		{
			get
			{
				return ALNType;
			}
			set
			{
				ALNType = value;
				Invalidate();
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000251FC File Offset: 0x000233FC
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x000093DC File Offset: 0x000075DC
		public int MaxLength
		{
			get
			{
				return _maxchars;
			}
			set
			{
				_maxchars = value;
				AmbianceTB.MaxLength = MaxLength;
				Invalidate();
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000093FC File Offset: 0x000075FC
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00009404 File Offset: 0x00007604
		public bool UseSystemPasswordChar
		{
			get
			{
				return isPasswordMasked;
			}
			set
			{
				AmbianceTB.UseSystemPasswordChar = UseSystemPasswordChar;
				isPasswordMasked = value;
				Invalidate();
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00009424 File Offset: 0x00007624
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0000942C File Offset: 0x0000762C
		public bool ReadOnly
		{
			get
			{
				return _ReadOnly;
			}
			set
			{
				_ReadOnly = value;
				if (AmbianceTB != null)
				{
					AmbianceTB.ReadOnly = value;
				}
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000944C File Offset: 0x0000764C
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00025214 File Offset: 0x00023414
		public bool Multiline
		{
			get
			{
				return _Multiline;
			}
			set
			{
				_Multiline = value;
				if (AmbianceTB != null)
				{
					AmbianceTB.Multiline = value;
					if (value)
					{
						AmbianceTB.Height = Height - 10;
					}
					else
					{
						Height = AmbianceTB.Height + 10;
					}
				}
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00009454 File Offset: 0x00007654
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			base.OnTextChanged(eventArgs_0);
			AmbianceTB.Text = Text;
			Invalidate();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00009474 File Offset: 0x00007674
		private void OnBaseTextChanged(object sender, EventArgs e)
		{
			Text = AmbianceTB.Text;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00009487 File Offset: 0x00007687
		protected override void OnForeColorChanged(EventArgs eventArgs_0)
		{
			base.OnForeColorChanged(eventArgs_0);
			AmbianceTB.ForeColor = ForeColor;
			Invalidate();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000094A7 File Offset: 0x000076A7
		protected override void OnFontChanged(EventArgs eventArgs_0)
		{
			base.OnFontChanged(eventArgs_0);
			AmbianceTB.Font = Font;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00008D13 File Offset: 0x00006F13
		protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaintBackground(paintEventArgs_0);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0002526C File Offset: 0x0002346C
		private void _OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				AmbianceTB.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				AmbianceTB.Copy();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000094C1 File Offset: 0x000076C1
		private void _Enter(object sender, EventArgs e)
		{
			P1 = new Pen(Color.FromArgb(205, 87, 40));
			Refresh();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000094E2 File Offset: 0x000076E2
		private void _Leave(object sender, EventArgs e)
		{
			P1 = new Pen(Color.FromArgb(180, 180, 180));
			Refresh();
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000252C8 File Offset: 0x000234C8
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			if (_Multiline)
			{
				AmbianceTB.Height = Height - 10;
			}
			else
			{
				Height = AmbianceTB.Height + 10;
			}
			Shape = new GraphicsPath();
			GraphicsPath shape = Shape;
			shape.AddArc(0, 0, 10, 10, 180f, 90f);
			shape.AddArc(Width - 11, 0, 10, 10, -90f, 90f);
			shape.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
			shape.AddArc(0, Height - 11, 10, 10, 90f, 90f);
			shape.CloseAllFigures();
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00009509 File Offset: 0x00007709
		protected override void OnGotFocus(EventArgs eventArgs_0)
		{
			base.OnGotFocus(eventArgs_0);
			AmbianceTB.Focus();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000253A0 File Offset: 0x000235A0
		public void AddTextBox()
		{
			TextBox ambianceTB = AmbianceTB;
			ambianceTB.Size = new Size(Width - 10, 33);
			ambianceTB.Location = new Point(7, 4);
			ambianceTB.Text = string.Empty;
			ambianceTB.BorderStyle = BorderStyle.None;
			ambianceTB.TextAlign = HorizontalAlignment.Left;
			ambianceTB.Font = new Font("Tahoma", 11f);
			ambianceTB.UseSystemPasswordChar = UseSystemPasswordChar;
			ambianceTB.Multiline = false;
			AmbianceTB.KeyDown += _OnKeyDown;
			AmbianceTB.Enter += _Enter;
			AmbianceTB.Leave += _Leave;
			AmbianceTB.TextChanged += OnBaseTextChanged;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00025474 File Offset: 0x00023674
		public AmbianceTextBox()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.UserPaint, true);
			AddTextBox();
			Controls.Add(AmbianceTB);
			P1 = new Pen(Color.FromArgb(180, 180, 180));
			B1 = new SolidBrush(Color.White);
			BackColor = Color.Transparent;
			ForeColor = Color.DimGray;
			Text = null;
			Font = new Font("Tahoma", 11f);
			Size = new Size(135, 33);
			DoubleBuffered = true;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002554C File Offset: 0x0002374C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Bitmap bitmap = new Bitmap(Width, Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			TextBox ambianceTB = AmbianceTB;
			ambianceTB.Width = Width - 10;
			ambianceTB.TextAlign = TextAlignment;
			ambianceTB.UseSystemPasswordChar = UseSystemPasswordChar;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(B1, Shape);
			graphics.DrawPath(P1, Shape);
			pevent.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040002F3 RID: 755
		public TextBox AmbianceTB = new TextBox();

		// Token: 0x040002F4 RID: 756
		private GraphicsPath Shape;

		// Token: 0x040002F5 RID: 757
		private int _maxchars = 32767;

		// Token: 0x040002F6 RID: 758
		private bool _ReadOnly;

		// Token: 0x040002F7 RID: 759
		private bool _Multiline;

		// Token: 0x040002F8 RID: 760
		private HorizontalAlignment ALNType;

		// Token: 0x040002F9 RID: 761
		private bool isPasswordMasked;

		// Token: 0x040002FA RID: 762
		private Pen P1;

		// Token: 0x040002FB RID: 763
		private SolidBrush B1;
	}
}
