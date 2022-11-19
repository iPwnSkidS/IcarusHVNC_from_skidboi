using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000054 RID: 84
	[DefaultEvent("CheckedChanged")]
	public class AmbianceCheckBox : Control
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060004F9 RID: 1273 RVA: 0x000226E8 File Offset: 0x000208E8
		// (remove) Token: 0x060004FA RID: 1274 RVA: 0x00022720 File Offset: 0x00020920
        public event CheckedChangedEventHandler CheckedChanged;

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00008C7F File Offset: 0x00006E7F
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00008C87 File Offset: 0x00006E87
		public bool Checked
		{
			get
			{
				return _Checked;
			}
			set
			{
				_Checked = value;

				Invalidate();
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00022758 File Offset: 0x00020958
		public AmbianceCheckBox()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 12f);
			Size = new Size(171, 26);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00008CAD File Offset: 0x00006EAD
		protected override void OnClick(EventArgs eventArgs_0)
		{
			_Checked = !_Checked;

			Focus();
			Invalidate();
			base.OnClick(eventArgs_0);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00008BCC File Offset: 0x00006DCC
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			Invalidate();
			base.OnTextChanged(eventArgs_0);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000227B0 File Offset: 0x000209B0
		protected override void OnResize(EventArgs eventArgs_0)
		{
			if (Width > 0 && Height > 0)
			{
				Shape = new GraphicsPath();
				R1 = new Rectangle(17, 0, Width, Height + 1);
				R2 = new Rectangle(0, 0, Width, Height);
				linearGradientBrush_0 = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(213, 85, 32), Color.FromArgb(224, 123, 82), 90f);
				GraphicsPath shape = Shape;
				shape.AddArc(0, 0, 7, 7, 180f, 90f);
				shape.AddArc(7, 0, 7, 7, -90f, 90f);
				shape.AddArc(7, 7, 7, 7, 0f, 90f);
				shape.AddArc(0, 7, 7, 7, 90f, 90f);
				shape.CloseAllFigures();
				Height = 15;
			}
			Invalidate();
			base.OnResize(eventArgs_0);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000228C0 File Offset: 0x00020AC0
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			graphics.Clear(Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.FillPath(linearGradientBrush_0, Shape);
			graphics.DrawPath(new Pen(Color.FromArgb(182, 88, 55)), Shape);
			graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(76, 76, 95)), new Rectangle(17, 0, Width, Height - 1), new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			if (Checked)
			{
				graphics.DrawString("ü", new Font("Wingdings", 12f), new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(-2, 1, Width, Height + 2), new StringFormat
				{
					LineAlignment = StringAlignment.Center
				});
			}
			pevent.Dispose();
		}

		// Token: 0x040002AD RID: 685
		private GraphicsPath Shape;

		// Token: 0x040002AE RID: 686
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x040002AF RID: 687
		private Rectangle R1;

		// Token: 0x040002B0 RID: 688
		private Rectangle R2;

		// Token: 0x040002B1 RID: 689
		private bool _Checked;


		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000503 RID: 1283
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
