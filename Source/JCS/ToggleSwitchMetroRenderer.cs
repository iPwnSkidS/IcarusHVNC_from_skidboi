using System.Drawing;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000047 RID: 71
	public class ToggleSwitchMetroRenderer : ToggleSwitchRendererBase
	{
		// Token: 0x060003AA RID: 938 RVA: 0x0001D298 File Offset: 0x0001B498
		public ToggleSwitchMetroRenderer()
		{
			BackColor = Color.White;
			LeftSideColor = Color.FromArgb(255, 23, 153, 0);
			LeftSideColorHovered = Color.FromArgb(255, 36, 182, 9);
			LeftSideColorPressed = Color.FromArgb(255, 121, 245, 100);
			RightSideColor = Color.FromArgb(255, 166, 166, 166);
			RightSideColorHovered = Color.FromArgb(255, 181, 181, 181);
			RightSideColorPressed = Color.FromArgb(255, 189, 189, 189);
			BorderColor = Color.FromArgb(255, 166, 166, 166);
			ButtonColor = Color.Black;
			ButtonColorHovered = Color.Black;
			ButtonColorPressed = Color.Black;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000817E File Offset: 0x0000637E
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00008186 File Offset: 0x00006386
		public Color BackColor
		{
			[CompilerGenerated]
			get
			{
				return this.<BackColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BackColor>k__BackingField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000818F File Offset: 0x0000638F
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00008197 File Offset: 0x00006397
		public Color LeftSideColor
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideColor>k__BackingField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000081A0 File Offset: 0x000063A0
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x000081A8 File Offset: 0x000063A8
		public Color LeftSideColorHovered
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideColorHovered>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideColorHovered>k__BackingField = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000081B1 File Offset: 0x000063B1
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x000081B9 File Offset: 0x000063B9
		public Color LeftSideColorPressed
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideColorPressed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideColorPressed>k__BackingField = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000081C2 File Offset: 0x000063C2
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x000081CA File Offset: 0x000063CA
		public Color RightSideColor
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideColor>k__BackingField = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000081D3 File Offset: 0x000063D3
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000081DB File Offset: 0x000063DB
		public Color RightSideColorHovered
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideColorHovered>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideColorHovered>k__BackingField = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000081E4 File Offset: 0x000063E4
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000081EC File Offset: 0x000063EC
		public Color RightSideColorPressed
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideColorPressed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideColorPressed>k__BackingField = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000081F5 File Offset: 0x000063F5
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000081FD File Offset: 0x000063FD
		public Color BorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<BorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00008206 File Offset: 0x00006406
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0000820E File Offset: 0x0000640E
		public Color ButtonColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonColor>k__BackingField = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00008217 File Offset: 0x00006417
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000821F File Offset: 0x0000641F
		public Color ButtonColorHovered
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonColorHovered>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonColorHovered>k__BackingField = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00008228 File Offset: 0x00006428
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00008230 File Offset: 0x00006430
		public Color ButtonColorPressed
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonColorPressed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonColorPressed>k__BackingField = value;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BorderColor : BorderColor.ToGrayScale());
			graphics_0.SetClip(borderRectangle);
			using (Pen pen = new Pen(color))
			{
				graphics_0.DrawRectangle(pen, borderRectangle.X, borderRectangle.Y, borderRectangle.Width - 1, borderRectangle.Height - 1);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0001D434 File Offset: 0x0001B634
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			Rectangle rectangle = new Rectangle(leftRectangle.X + 2, 2, leftRectangle.Width - 2, leftRectangle.Height - 4);
			if (rectangle.Width > 0)
			{
				Color color = LeftSideColor;
				if (ToggleSwitch.IsLeftSidePressed)
				{
					color = LeftSideColorPressed;
				}
				else if (ToggleSwitch.IsLeftSideHovered)
				{
					color = LeftSideColorHovered;
				}
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					color = color.ToGrayScale();
				}
				graphics_0.SetClip(rectangle);
				using (Brush brush = new SolidBrush(color))
				{
					graphics_0.FillRectangle(brush, rectangle);
				}
				if (ToggleSwitch.OnSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OnText))
				{
					RectangleF rectangleF = new RectangleF(leftRectangle.X + 2 - (totalToggleFieldWidth - leftRectangle.Width), 2f, totalToggleFieldWidth - 2, ToggleSwitch.Height - 4);
					graphics_0.IntersectClip(rectangleF);
					if (ToggleSwitch.OnSideImage != null)
					{
						Size size = ToggleSwitch.OnSideImage.Size;
						int num = (int)rectangleF.X;
						if (ToggleSwitch.OnSideScaleImageToFit)
						{
							Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
							Size size3 = ImageHelper.RescaleImageToFit(size, size2);
							if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
							{
								num = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
							}
							else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
							{
								num = (int)(rectangleF.X + rectangleF.Width - size3.Width);
							}
							Rectangle rectangle2 = new Rectangle(num, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
							if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
							}
							else
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2);
							}
						}
						else
						{
							if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
							{
								num = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
							}
							else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
							{
								num = (int)(rectangleF.X + rectangleF.Width - size.Width);
							}
							Rectangle rectangle2 = new Rectangle(num, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
							if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
							}
							else
							{
								graphics_0.DrawImageUnscaled(ToggleSwitch.OnSideImage, rectangle2);
							}
						}
					}
					else if (!string.IsNullOrEmpty(ToggleSwitch.OnText))
					{
						SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OnText, ToggleSwitch.OnFont);
						float num2 = rectangleF.X;
						if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
						}
						else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
						{
							num2 = rectangleF.X + rectangleF.Width - sizeF.Width;
						}
						RectangleF rectangleF2 = new RectangleF(num2, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
						Color color2 = ToggleSwitch.OnForeColor;
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							color2 = color2.ToGrayScale();
						}
						using (Brush brush2 = new SolidBrush(color2))
						{
							graphics_0.DrawString(ToggleSwitch.OnText, ToggleSwitch.OnFont, brush2, rectangleF2);
						}
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001D920 File Offset: 0x0001BB20
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			Rectangle rectangle = new Rectangle(rightRectangle.X, 2, rightRectangle.Width - 2, rightRectangle.Height - 4);
			if (rectangle.Width > 0)
			{
				Color color = RightSideColor;
				if (ToggleSwitch.IsRightSidePressed)
				{
					color = RightSideColorPressed;
				}
				else if (ToggleSwitch.IsRightSideHovered)
				{
					color = RightSideColorHovered;
				}
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					color = color.ToGrayScale();
				}
				graphics_0.SetClip(rectangle);
				using (Brush brush = new SolidBrush(color))
				{
					graphics_0.FillRectangle(brush, rectangle);
				}
				if (ToggleSwitch.OffSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OffText))
				{
					RectangleF rectangleF = new RectangleF(rightRectangle.X, 2f, totalToggleFieldWidth - 2, ToggleSwitch.Height - 4);
					graphics_0.IntersectClip(rectangleF);
					if (ToggleSwitch.OffSideImage != null)
					{
						Size size = ToggleSwitch.OffSideImage.Size;
						int num = (int)rectangleF.X;
						if (ToggleSwitch.OffSideScaleImageToFit)
						{
							Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
							Size size3 = ImageHelper.RescaleImageToFit(size, size2);
							if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
							{
								num = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
							}
							else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
							{
								num = (int)(rectangleF.X + rectangleF.Width - size3.Width);
							}
							Rectangle rectangle2 = new Rectangle(num, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
							if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
							}
							else
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2);
							}
						}
						else
						{
							if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
							{
								num = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
							}
							else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
							{
								num = (int)(rectangleF.X + rectangleF.Width - size.Width);
							}
							Rectangle rectangle2 = new Rectangle(num, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
							if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
							{
								graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle2, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
							}
							else
							{
								graphics_0.DrawImageUnscaled(ToggleSwitch.OffSideImage, rectangle2);
							}
						}
					}
					else if (!string.IsNullOrEmpty(ToggleSwitch.OffText))
					{
						SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OffText, ToggleSwitch.OffFont);
						float num2 = rectangleF.X;
						if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
						}
						else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
						{
							num2 = rectangleF.X + rectangleF.Width - sizeF.Width;
						}
						RectangleF rectangleF2 = new RectangleF(num2, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
						Color color2 = ToggleSwitch.OffForeColor;
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							color2 = color2.ToGrayScale();
						}
						using (Brush brush2 = new SolidBrush(color2))
						{
							graphics_0.DrawString(ToggleSwitch.OffText, ToggleSwitch.OffFont, brush2, rectangleF2);
						}
					}
				}
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			Color color = ButtonColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color = ButtonColorPressed;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color = ButtonColorHovered;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
			}
			graphics_0.SetClip(buttonRectangle);
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(brush, buttonRectangle);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001DE90 File Offset: 0x0001C090
		public override int GetButtonWidth()
		{
			return (int)(ToggleSwitch.Height / 3.0 * 2.0);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private System.Drawing.Color <BackColor>k__BackingField;

		// Token: 0x0400020B RID: 523
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideColor>k__BackingField;

		// Token: 0x0400020C RID: 524
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideColorHovered>k__BackingField;

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideColorPressed>k__BackingField;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private System.Drawing.Color <RightSideColor>k__BackingField;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private System.Drawing.Color <RightSideColorHovered>k__BackingField;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private System.Drawing.Color <RightSideColorPressed>k__BackingField;

		// Token: 0x04000211 RID: 529
		[CompilerGenerated]
		private System.Drawing.Color <BorderColor>k__BackingField;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private System.Drawing.Color <ButtonColor>k__BackingField;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private System.Drawing.Color <ButtonColorHovered>k__BackingField;

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private System.Drawing.Color <ButtonColorPressed>k__BackingField;
	}
}
