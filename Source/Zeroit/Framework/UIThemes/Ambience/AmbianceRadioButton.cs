using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000063 RID: 99
	[DefaultEvent("CheckedChanged")]
	public class AmbianceRadioButton : Control
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600055C RID: 1372 RVA: 0x0002498C File Offset: 0x00022B8C
		// (remove) Token: 0x0600055D RID: 1373 RVA: 0x000249C4 File Offset: 0x00022BC4
        public event CheckedChangedEventHandler CheckedChanged;

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00009189 File Offset: 0x00007389
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00009191 File Offset: 0x00007391
        public bool Checked;

		// Token: 0x06000560 RID: 1376 RVA: 0x00008BCC File Offset: 0x00006DCC
		protected override void OnTextChanged(EventArgs eventArgs_0)
		{
			Invalidate();
			base.OnTextChanged(eventArgs_0);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000091BD File Offset: 0x000073BD
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			Height = 15;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000091CE File Offset: 0x000073CE
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			if (!_Checked)
			{
				Checked = true;
			}
			base.OnMouseDown(mevent);
			Focus();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000091F0 File Offset: 0x000073F0
		public AmbianceRadioButton()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			BackColor = Color.Transparent;
			Font = new Font("Segoe UI", 12f);
			Width = 193;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000249FC File Offset: 0x00022BFC
		private void InvalidateControls()
		{
			if (IsHandleCreated && _Checked)
			{
				foreach (object obj in Parent.Controls)
				{
					Control control = (Control)obj;
					if (control != this && control is AmbianceRadioButton)
					{
						((AmbianceRadioButton)control).Checked = false;
					}
				}
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00024A84 File Offset: 0x00022C84
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Graphics graphics = pevent.Graphics;
			graphics.Clear(Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 14)), Color.FromArgb(213, 85, 32), Color.FromArgb(224, 123, 82), 90f);
			graphics.FillEllipse(linearGradientBrush, new Rectangle(new Point(0, 0), new Size(14, 14)));
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(new Rectangle(0, 0, 14, 14));
			graphics.SetClip(graphicsPath);
			graphics.ResetClip();
			graphics.DrawEllipse(new Pen(Color.FromArgb(182, 88, 55)), new Rectangle(new Point(0, 0), new Size(14, 14)));
			if (_Checked)
			{
				SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
				graphics.FillEllipse(solidBrush, new Rectangle(new Point(4, 4), new Size(6, 6)));
			}
			graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(76, 76, 95)), 16f, 7f, new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			pevent.Dispose();
		}

		// Token: 0x040002E6 RID: 742
		private bool _Checked;


		// Token: 0x02000064 RID: 100
		public enum MouseState : byte
		{
			// Token: 0x040002E9 RID: 745
			None,
			// Token: 0x040002EA RID: 746
			Over,
			// Token: 0x040002EB RID: 747
			Down,
			// Token: 0x040002EC RID: 748
			Block
		}

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000567 RID: 1383
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
