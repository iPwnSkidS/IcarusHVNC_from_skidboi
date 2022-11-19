using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000056 RID: 86
	public class AmbianceComboBox : ComboBox
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000229D8 File Offset: 0x00020BD8
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x000229F0 File Offset: 0x00020BF0
		public int StartIndex
		{
			get
			{
				return _StartIndex;
			}
			set
			{
				_StartIndex = value;
				try
				{
					method_0(value);
				}
				catch
				{
				}
				Invalidate();
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00022A28 File Offset: 0x00020C28
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00008CE9 File Offset: 0x00006EE9
		public Color HoverSelectionColor
		{
			get
			{
				return _HoverSelectionColor;
			}
			set
			{
				_HoverSelectionColor = value;
				Invalidate();
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00022A40 File Offset: 0x00020C40
		protected override void OnDrawItem(DrawItemEventArgs drawItemEventArgs_0)
		{
			base.OnDrawItem(drawItemEventArgs_0);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(drawItemEventArgs_0.Bounds, Color.FromArgb(246, 132, 85), Color.FromArgb(231, 108, 57), 90f);
			if (Convert.ToInt32(drawItemEventArgs_0.State & DrawItemState.Selected) == 1)
			{
				if (drawItemEventArgs_0.Index != -1)
				{
					drawItemEventArgs_0.Graphics.FillRectangle(linearGradientBrush, drawItemEventArgs_0.Bounds);
					drawItemEventArgs_0.Graphics.DrawString(GetItemText(Items[drawItemEventArgs_0.Index]), drawItemEventArgs_0.Font, Brushes.WhiteSmoke, drawItemEventArgs_0.Bounds);
				}
			}
			else if (drawItemEventArgs_0.Index != -1)
			{
				drawItemEventArgs_0.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(242, 241, 240)), drawItemEventArgs_0.Bounds);
				drawItemEventArgs_0.Graphics.DrawString(GetItemText(Items[drawItemEventArgs_0.Index]), drawItemEventArgs_0.Font, Brushes.DimGray, drawItemEventArgs_0.Bounds);
			}
			linearGradientBrush.Dispose();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00008CF8 File Offset: 0x00006EF8
		protected override void OnLostFocus(EventArgs eventArgs_0)
		{
			base.OnLostFocus(eventArgs_0);
			SuspendLayout();
			Update();
			ResumeLayout();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00008D13 File Offset: 0x00006F13
		protected override void OnPaintBackground(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaintBackground(paintEventArgs_0);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00008D1C File Offset: 0x00006F1C
		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			if (!Focused)
			{
				SelectionLength = 0;
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00022B70 File Offset: 0x00020D70
		public AmbianceComboBox()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.Selectable, false);
			DrawMode = DrawMode.OwnerDrawFixed;
			DropDownStyle = ComboBoxStyle.DropDownList;
			BackColor = Color.FromArgb(246, 246, 246);
			ForeColor = Color.FromArgb(142, 142, 142);
			Size = new Size(135, 26);
			ItemHeight = 20;
			DropDownHeight = 100;
			Font = new Font("Segoe UI", 10f, FontStyle.Regular);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00022C1C File Offset: 0x00020E1C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			pevent.Graphics.Clear(Parent.BackColor);
			pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath graphicsPath = RoundRectangle.RoundRect(0, 0, Width - 1, Height - 1, 5);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(ClientRectangle, Color.FromArgb(253, 252, 252), Color.FromArgb(239, 237, 236), 90f);
			pevent.Graphics.SetClip(graphicsPath);
			pevent.Graphics.FillRectangle(linearGradientBrush, ClientRectangle);
			pevent.Graphics.ResetClip();
			pevent.Graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), graphicsPath);
			pevent.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(76, 76, 97)), new Rectangle(3, 0, Width - 20, Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near
			});
			pevent.Graphics.DrawString("6", new Font("Marlett", 13f, FontStyle.Regular), new SolidBrush(Color.FromArgb(119, 119, 118)), new Rectangle(3, 0, Width - 4, Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Far
			});
			pevent.Graphics.DrawLine(new Pen(Color.FromArgb(224, 222, 220)), Width - 24, 4, Width - 24, Height - 5);
			pevent.Graphics.DrawLine(new Pen(Color.FromArgb(250, 249, 249)), Width - 25, 4, Width - 25, Height - 5);
			graphicsPath.Dispose();
			linearGradientBrush.Dispose();
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00008D37 File Offset: 0x00006F37
		void method_0(int int_0)
		{
			base.SelectedIndex = int_0;
		}

		// Token: 0x040002B3 RID: 691
		private int _StartIndex;

		// Token: 0x040002B4 RID: 692
		private Color _HoverSelectionColor;
	}
}
