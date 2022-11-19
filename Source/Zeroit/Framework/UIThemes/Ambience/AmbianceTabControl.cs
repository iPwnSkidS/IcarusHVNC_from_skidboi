using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000068 RID: 104
	public class AmbianceTabControl : TabControl
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x0000939B File Offset: 0x0000759B
		public AmbianceTabControl()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000093AF File Offset: 0x000075AF
		protected override void CreateHandle()
		{
			base.CreateHandle();
			ItemSize = new Size(80, 24);
			Alignment = TabAlignment.Top;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00024F0C File Offset: 0x0002310C
		protected override void OnPaint(PaintEventArgs pevent)
		{
			Graphics graphics = pevent.Graphics;
			Rectangle rectangle = default(Rectangle);
			graphics.Clear(Parent.BackColor);
			for (int i = 0; i <= TabCount - 1; i++)
			{
				rectangle = GetTabRect(i);
				if (i != SelectedIndex)
				{
					graphics.DrawString(TabPages[i].Text, new Font(Font.Name, Font.Size - 1f, FontStyle.Bold), new SolidBrush(Color.FromArgb(80, 76, 76)), new Rectangle(GetTabRect(i).Location, GetTabRect(i).Size), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Center
					});
				}
			}
			graphics.FillPath(new SolidBrush(Color.White), RoundRectangle.RoundRect(0, 23, Width - 1, Height - 24, 2));
			graphics.DrawPath(new Pen(Color.FromArgb(201, 198, 195)), RoundRectangle.RoundRect(0, 23, Width - 1, Height - 24, 2));
			for (int num = 0; num <= TabCount - 1; num++)
			{
				rectangle = GetTabRect(num);
				if (num == SelectedIndex)
				{
					graphics.DrawPath(new Pen(Color.FromArgb(201, 198, 195)), RoundRectangle.RoundedTopRect(new Rectangle(new Point(rectangle.X - 2, rectangle.Y - 2), new Size(rectangle.Width + 3, rectangle.Height)), 7));
					graphics.FillPath(new SolidBrush(Color.White), RoundRectangle.RoundedTopRect(new Rectangle(new Point(rectangle.X - 1, rectangle.Y - 1), new Size(rectangle.Width + 2, rectangle.Height)), 7));
					try
					{
						graphics.DrawString(TabPages[num].Text, new Font(Font.Name, Font.Size - 1f, FontStyle.Bold), new SolidBrush(Color.FromArgb(80, 76, 76)), new Rectangle(GetTabRect(num).Location, GetTabRect(num).Size), new StringFormat
						{
							LineAlignment = StringAlignment.Center,
							Alignment = StringAlignment.Center
						});
						TabPages[num].BackColor = Color.White;
					}
					catch
					{
					}
				}
			}
		}
	}
}
