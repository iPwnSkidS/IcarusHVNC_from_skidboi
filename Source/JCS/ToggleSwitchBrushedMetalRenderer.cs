using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000042 RID: 66
	public class ToggleSwitchBrushedMetalRenderer : ToggleSwitchRendererBase
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00015C74 File Offset: 0x00013E74
		public ToggleSwitchBrushedMetalRenderer()
		{
			BorderColor1 = Color.FromArgb(255, 145, 146, 149);
			BorderColor2 = Color.FromArgb(255, 227, 229, 232);
			BackColor1 = Color.FromArgb(255, 125, 126, 128);
			BackColor2 = Color.FromArgb(255, 224, 226, 228);
			UpperShadowColor1 = Color.FromArgb(150, 0, 0, 0);
			UpperShadowColor2 = Color.FromArgb(5, 0, 0, 0);
			ButtonNormalBorderColor = Color.FromArgb(255, 144, 144, 145);
			ButtonNormalSurfaceColor = Color.FromArgb(255, 251, 251, 251);
			ButtonHoverBorderColor = Color.FromArgb(255, 166, 167, 168);
			ButtonHoverSurfaceColor = Color.FromArgb(255, 238, 238, 238);
			ButtonPressedBorderColor = Color.FromArgb(255, 123, 123, 123);
			ButtonPressedSurfaceColor = Color.FromArgb(255, 184, 184, 184);
			UpperShadowHeight = 8;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00007982 File Offset: 0x00005B82
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000798A File Offset: 0x00005B8A
		public Color BorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <BorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00007993 File Offset: 0x00005B93
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000799B File Offset: 0x00005B9B
		public Color BorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <BorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000079A4 File Offset: 0x00005BA4
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000079AC File Offset: 0x00005BAC
		public Color BackColor1
		{
			[CompilerGenerated]
			get
			{
				return <BackColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BackColor1>k__BackingField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000079B5 File Offset: 0x00005BB5
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000079BD File Offset: 0x00005BBD
		public Color BackColor2
		{
			[CompilerGenerated]
			get
			{
				return <BackColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BackColor2>k__BackingField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000079C6 File Offset: 0x00005BC6
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000079CE File Offset: 0x00005BCE
		public Color UpperShadowColor1
		{
			[CompilerGenerated]
			get
			{
				return <UpperShadowColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UpperShadowColor1>k__BackingField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000079D7 File Offset: 0x00005BD7
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000079DF File Offset: 0x00005BDF
		public Color UpperShadowColor2
		{
			[CompilerGenerated]
			get
			{
				return <UpperShadowColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UpperShadowColor2>k__BackingField = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000079E8 File Offset: 0x00005BE8
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000079F0 File Offset: 0x00005BF0
		public Color ButtonNormalBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000079F9 File Offset: 0x00005BF9
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00007A01 File Offset: 0x00005C01
		public Color ButtonNormalSurfaceColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalSurfaceColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalSurfaceColor>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00007A0A File Offset: 0x00005C0A
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00007A12 File Offset: 0x00005C12
		public Color ButtonHoverBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00007A1B File Offset: 0x00005C1B
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00007A23 File Offset: 0x00005C23
		public Color ButtonHoverSurfaceColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverSurfaceColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverSurfaceColor>k__BackingField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00007A2C File Offset: 0x00005C2C
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00007A34 File Offset: 0x00005C34
		public Color ButtonPressedBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00007A3D File Offset: 0x00005C3D
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00007A45 File Offset: 0x00005C45
		public Color ButtonPressedSurfaceColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedSurfaceColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedSurfaceColor>k__BackingField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00007A4E File Offset: 0x00005C4E
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00007A56 File Offset: 0x00005C56
		public int UpperShadowHeight
		{
			[CompilerGenerated]
			get
			{
				return <UpperShadowHeight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UpperShadowHeight>k__BackingField = value;
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00015DD8 File Offset: 0x00013FD8
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			using (GraphicsPath rectangleClipPath = GetRectangleClipPath(borderRectangle))
			{
				graphics_0.SetClip(rectangleClipPath);
				Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BorderColor1 : BorderColor1.ToGrayScale());
				Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BorderColor2 : BorderColor2.ToGrayScale());
				using (Brush brush = new LinearGradientBrush(borderRectangle, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, rectangleClipPath);
				}
				graphics_0.ResetClip();
			}
			Rectangle rectangle = new Rectangle(borderRectangle.X + 1, borderRectangle.Y + 1, borderRectangle.Width - 1, borderRectangle.Height - 2);
			using (GraphicsPath rectangleClipPath2 = GetRectangleClipPath(rectangle))
			{
				graphics_0.SetClip(rectangleClipPath2);
				Color color3 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BackColor1 : BackColor1.ToGrayScale());
				Color color4 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BackColor2 : BackColor2.ToGrayScale());
				using (Brush brush2 = new LinearGradientBrush(borderRectangle, color3, color4, LinearGradientMode.Horizontal))
				{
					graphics_0.FillPath(brush2, rectangleClipPath2);
				}
				Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, UpperShadowHeight);
				graphics_0.IntersectClip(rectangle2);
				using (Brush brush3 = new LinearGradientBrush(rectangle2, UpperShadowColor1, UpperShadowColor2, LinearGradientMode.Vertical))
				{
					graphics_0.FillRectangle(brush3, rectangle2);
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00016004 File Offset: 0x00014204
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			Rectangle rectangle = new Rectangle(1, 1, ToggleSwitch.Width - 1, ToggleSwitch.Height - 2);
			using (GraphicsPath rectangleClipPath = GetRectangleClipPath(rectangle))
			{
				graphics_0.SetClip(rectangleClipPath);
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
						Color color = ToggleSwitch.OnForeColor;
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							color = color.ToGrayScale();
						}
						using (Brush brush = new SolidBrush(color))
						{
							graphics_0.DrawString(ToggleSwitch.OnText, ToggleSwitch.OnFont, brush, rectangleF2);
						}
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000164B0 File Offset: 0x000146B0
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			Rectangle rectangle = new Rectangle(1, 1, ToggleSwitch.Width - 1, ToggleSwitch.Height - 2);
			using (GraphicsPath rectangleClipPath = GetRectangleClipPath(rectangle))
			{
				graphics_0.SetClip(rectangleClipPath);
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
						Color color = ToggleSwitch.OffForeColor;
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							color = color.ToGrayScale();
						}
						using (Brush brush = new SolidBrush(color))
						{
							graphics_0.DrawString(ToggleSwitch.OffText, ToggleSwitch.OffFont, brush, rectangleF2);
						}
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00016950 File Offset: 0x00014B50
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			graphics_0.SetClip(buttonRectangle);
			Color color = ButtonNormalSurfaceColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color = ButtonPressedSurfaceColor;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color = ButtonHoverSurfaceColor;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
			}
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillEllipse(brush, buttonRectangle);
			}
			PointF pointF = new PointF(buttonRectangle.X + buttonRectangle.Width / 2f, buttonRectangle.Y + 1.2f * (buttonRectangle.Height / 2f));
			using (PathGradientBrush brush2 = GetBrush(new[]
			{
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.FromArgb(255, 110, 110, 110),
				Color.Transparent,
				Color.Transparent,
				Color.Transparent
			}, buttonRectangle, pointF))
			{
				graphics_0.FillEllipse(brush2, buttonRectangle);
			}
			PointF pointF2 = new PointF(buttonRectangle.X + 0.8f * (buttonRectangle.Width / 2f), buttonRectangle.Y + buttonRectangle.Height / 2f);
			using (PathGradientBrush brush3 = GetBrush(new[]
			{
				Color.FromArgb(255, 110, 110, 110),
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.FromArgb(255, 110, 110, 110)
			}, buttonRectangle, pointF2))
			{
				graphics_0.FillEllipse(brush3, buttonRectangle);
			}
			PointF pointF3 = new PointF(buttonRectangle.X + 1.2f * (buttonRectangle.Width / 2f), buttonRectangle.Y + buttonRectangle.Height / 2f);
			using (PathGradientBrush brush4 = GetBrush(new[]
			{
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.FromArgb(255, 98, 98, 98),
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent
			}, buttonRectangle, pointF3))
			{
				graphics_0.FillEllipse(brush4, buttonRectangle);
			}
			PointF pointF4 = new PointF(buttonRectangle.X + 0.9f * (buttonRectangle.Width / 2f), buttonRectangle.Y + 0.9f * (buttonRectangle.Height / 2f));
			using (PathGradientBrush brush5 = GetBrush(new[]
			{
				Color.Transparent,
				Color.FromArgb(255, 188, 188, 188),
				Color.FromArgb(255, 110, 110, 110),
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent,
				Color.Transparent
			}, buttonRectangle, pointF4))
			{
				graphics_0.FillEllipse(brush5, buttonRectangle);
			}
			Color color2 = ButtonNormalBorderColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color2 = ButtonPressedBorderColor;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color2 = ButtonHoverBorderColor;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color2 = color2.ToGrayScale();
			}
			using (Pen pen = new Pen(color2))
			{
				graphics_0.DrawEllipse(pen, buttonRectangle);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00016EB8 File Offset: 0x000150B8
		public GraphicsPath GetRectangleClipPath(Rectangle rect)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(rect.X, rect.Y, rect.Height, rect.Height, 90f, 180f);
			graphicsPath.AddArc(rect.Width - rect.Height, rect.Y, rect.Height, rect.Height, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00016F34 File Offset: 0x00015134
		public GraphicsPath GetButtonClipPath()
		{
			Rectangle buttonRectangle = GetButtonRectangle();
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(buttonRectangle.X, buttonRectangle.Y, buttonRectangle.Height, buttonRectangle.Height, 0f, 360f);
			return graphicsPath;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00016F80 File Offset: 0x00015180
		public override int GetButtonWidth()
		{
			return ToggleSwitch.Height - 2;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00016F9C File Offset: 0x0001519C
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 1, buttonWidth, buttonWidth);
			return rectangle;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00016FC4 File Offset: 0x000151C4
		private PathGradientBrush GetBrush(Color[] Colors, RectangleF rectangleF_0, PointF centerPoint)
		{
			int num = Colors.Length - 1;
			PointF[] array = new PointF[num + 1];
			float num2 = 0f;
			int num3 = 0;
			float num4 = rectangleF_0.Width / 2f;
			float num5 = rectangleF_0.Height / 2f;
			int num6 = (int)Math.Floor(180.0 * (num - 2.0) / num / 2.0);
			double num7 = num6 * 3.1415926535897931 / 180.0;
			double num8 = 1.0 / Math.Sin(num7);
			float num9 = (float)(num4 * num8);
			float num10 = (float)(num5 * num8);
			while (num2 <= 6.2831853071795862)
			{
				array[num3] = new PointF((float)(num4 + Math.Cos(num2) * num9) + rectangleF_0.Left, (float)(num5 + Math.Sin(num2) * (double)num10) + rectangleF_0.Top);
				num3++;
				num2 += (float)(6.2831853071795862 / num);
			}
			array[num] = array[0];
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLines(array);
			PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
			pathGradientBrush.CenterPoint = centerPoint;
			pathGradientBrush.CenterColor = Color.Transparent;
			pathGradientBrush.SurroundColors = new[] { Color.White };
			try
			{
				pathGradientBrush.SurroundColors = Colors;
			}
			catch (Exception ex)
			{
				throw new Exception("Too may colors!", ex);
			}
			return pathGradientBrush;
		}

		// Token: 0x04000193 RID: 403
		[CompilerGenerated]
		private System.Drawing.Color <BorderColor1>k__BackingField;

		// Token: 0x04000194 RID: 404
		[CompilerGenerated]
		private System.Drawing.Color <BorderColor2>k__BackingField;

		// Token: 0x04000195 RID: 405
		[CompilerGenerated]
		private System.Drawing.Color <BackColor1>k__BackingField;

		// Token: 0x04000196 RID: 406
		[CompilerGenerated]
		private System.Drawing.Color <BackColor2>k__BackingField;

		// Token: 0x04000197 RID: 407
		[CompilerGenerated]
		private System.Drawing.Color <UpperShadowColor1>k__BackingField;

		// Token: 0x04000198 RID: 408
		[CompilerGenerated]
		private System.Drawing.Color <UpperShadowColor2>k__BackingField;

		// Token: 0x04000199 RID: 409
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor>k__BackingField;

		// Token: 0x0400019A RID: 410
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor>k__BackingField;

		// Token: 0x0400019B RID: 411
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor>k__BackingField;

		// Token: 0x0400019C RID: 412
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor>k__BackingField;

		// Token: 0x0400019D RID: 413
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor>k__BackingField;

		// Token: 0x0400019E RID: 414
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor>k__BackingField;

		// Token: 0x0400019F RID: 415
		[CompilerGenerated]
		private int <UpperShadowHeight>k__BackingField;
	}
}
