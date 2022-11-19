using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000066 RID: 102
	[DefaultEvent("TextChanged")]
	public class AmbianceRichTextBox : Control
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00024BDC File Offset: 0x00022DDC
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000922F File Offset: 0x0000742F
		public override string Text
		{
			get
			{
				return AmbianceRTB.Text;
			}
			set
			{
				AmbianceRTB.Text = value;
				Invalidate();
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00009243 File Offset: 0x00007443
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0000924B File Offset: 0x0000744B
		public bool ReadOnly
		{
			get
			{
				return _ReadOnly;
			}
			set
			{
				_ReadOnly = value;
				if (AmbianceRTB != null)
				{
					AmbianceRTB.ReadOnly = value;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000926B File Offset: 0x0000746B
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00009273 File Offset: 0x00007473
		public bool WordWrap
		{
			get
			{
				return _WordWrap;
			}
			set
			{
				_WordWrap = value;
				if (AmbianceRTB != null)
				{
					AmbianceRTB.WordWrap = value;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00009293 File Offset: 0x00007493
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000929B File Offset: 0x0000749B
		public bool AutoWordSelection
		{
			get
			{
				return _AutoWordSelection;
			}
			set
			{
				_AutoWordSelection = value;
				if (AmbianceRTB != null)
				{
					AmbianceRTB.AutoWordSelection = value;
				}
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000092BB File Offset: 0x000074BB
		protected override void OnForeColorChanged(EventArgs eventArgs_0)
		{
			base.OnForeColorChanged(eventArgs_0);
			AmbianceRTB.ForeColor = ForeColor;
			Invalidate();
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000092DB File Offset: 0x000074DB
		protected override void OnFontChanged(EventArgs eventArgs_0)
		{
			base.OnFontChanged(eventArgs_0);
			AmbianceRTB.Font = Font;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00008D13 File Offset: 0x00006F13
		protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaintBackground(paintEventArgs_0);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000092F5 File Offset: 0x000074F5
		protected override void OnSizeChanged(EventArgs eventArgs_0)
		{
			base.OnSizeChanged(eventArgs_0);
			AmbianceRTB.Size = new Size(Width - 13, Height - 11);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00009320 File Offset: 0x00007520
		private void _Enter(object sender, EventArgs e)
		{
			P1 = new Pen(Color.FromArgb(205, 87, 40));
			Refresh();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00009341 File Offset: 0x00007541
		private void _Leave(object sender, EventArgs e)
		{
			P1 = new Pen(Color.FromArgb(180, 180, 180));
			Refresh();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00024BF8 File Offset: 0x00022DF8
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Shape = new GraphicsPath();
			GraphicsPath shape = Shape;
			shape.AddArc(0, 0, 10, 10, 180f, 90f);
			shape.AddArc(Width - 11, 0, 10, 10, -90f, 90f);
			shape.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
			shape.AddArc(0, Height - 11, 10, 10, 90f, 90f);
			shape.CloseAllFigures();
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00009368 File Offset: 0x00007568
		public void _TextChanged(object sender, EventArgs e)
		{
			AmbianceRTB.Text = Text;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00024C9C File Offset: 0x00022E9C
		public void AddRichTextBox()
		{
			RichTextBox ambianceRTB = AmbianceRTB;
			ambianceRTB.BackColor = Color.White;
			ambianceRTB.Size = new Size(Width - 10, 100);
			ambianceRTB.Location = new Point(7, 5);
			ambianceRTB.Text = string.Empty;
			ambianceRTB.BorderStyle = BorderStyle.None;
			ambianceRTB.Font = new Font("Tahoma", 10f);
			ambianceRTB.Multiline = true;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00024D0C File Offset: 0x00022F0C
		public AmbianceRichTextBox()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.UserPaint, true);
			AddRichTextBox();
			Controls.Add(AmbianceRTB);
			BackColor = Color.Transparent;
			ForeColor = Color.FromArgb(76, 76, 76);
			P1 = new Pen(Color.FromArgb(180, 180, 180));
			Text = null;
			Font = new Font("Tahoma", 10f);
			Size = new Size(150, 100);
			WordWrap = true;
			AutoWordSelection = false;
			DoubleBuffered = true;
			AmbianceRTB.Enter += _Enter;
			AmbianceRTB.Leave += _Leave;
			TextChanged += _TextChanged;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00024E14 File Offset: 0x00023014
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Bitmap bitmap = new Bitmap(Width, Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(Brushes.White, Shape);
			graphics.DrawPath(P1, Shape);
			graphics.Dispose();
			pevent.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040002ED RID: 749
		public RichTextBox AmbianceRTB = new RichTextBox();

		// Token: 0x040002EE RID: 750
		private bool _ReadOnly;

		// Token: 0x040002EF RID: 751
		private bool _WordWrap;

		// Token: 0x040002F0 RID: 752
		private bool _AutoWordSelection;

		// Token: 0x040002F1 RID: 753
		private GraphicsPath Shape;

		// Token: 0x040002F2 RID: 754
		private Pen P1;
	}
}
