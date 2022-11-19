using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000043 RID: 67
	public class ToggleSwitchCarbonRenderer : ToggleSwitchRendererBase, IDisposable
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00017158 File Offset: 0x00015358
		public ToggleSwitchCarbonRenderer()
		{
			OuterBorderColor = Color.FromArgb(255, 106, 106, 106);
			InnerBorderColor1 = Color.FromArgb(255, 141, 151, 158);
			InnerBorderColor2 = Color.FromArgb(255, 138, 139, 140);
			LeftSideBackColor1 = Color.FromArgb(255, 61, 99, 119);
			LeftSideBackColor2 = Color.FromArgb(255, 108, 148, 179);
			RightSideBackColor1 = Color.FromArgb(255, 72, 72, 72);
			RightSideBackColor2 = Color.FromArgb(255, 85, 85, 85);
			ButtonNormalBorderColor1 = Color.FromArgb(255, 165, 167, 169);
			ButtonNormalBorderColor2 = Color.FromArgb(255, 106, 106, 106);
			ButtonNormalSurfaceColor1 = Color.FromArgb(255, 235, 235, 235);
			ButtonNormalSurfaceColor2 = Color.FromArgb(255, 178, 180, 182);
			ButtonHoverBorderColor1 = Color.FromArgb(255, 166, 168, 169);
			ButtonHoverBorderColor2 = Color.FromArgb(255, 169, 171, 173);
			ButtonHoverSurfaceColor1 = Color.FromArgb(255, 223, 224, 224);
			ButtonHoverSurfaceColor2 = Color.FromArgb(255, 169, 171, 173);
			ButtonPressedBorderColor1 = Color.FromArgb(255, 159, 159, 162);
			ButtonPressedBorderColor2 = Color.FromArgb(255, 106, 106, 106);
			ButtonPressedSurfaceColor1 = Color.FromArgb(255, 176, 177, 177);
			ButtonPressedSurfaceColor2 = Color.FromArgb(255, 133, 135, 136);
			ButtonShadowColor1 = Color.FromArgb(50, 0, 0, 0);
			ButtonShadowColor2 = Color.FromArgb(0, 0, 0, 0);
			ButtonShadowWidth = 7;
			CornerRadius = 6;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00007A5F File Offset: 0x00005C5F
		public void Dispose()
		{
			if (_innerControlPath != null)
			{
				_innerControlPath.Dispose();
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00007A77 File Offset: 0x00005C77
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00007A7F File Offset: 0x00005C7F
		public Color OuterBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <OuterBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OuterBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00007A88 File Offset: 0x00005C88
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00007A90 File Offset: 0x00005C90
		public Color InnerBorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <InnerBorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InnerBorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00007A99 File Offset: 0x00005C99
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00007AA1 File Offset: 0x00005CA1
		public Color InnerBorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <InnerBorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InnerBorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00007AAA File Offset: 0x00005CAA
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00007AB2 File Offset: 0x00005CB2
		public Color LeftSideBackColor1
		{
			[CompilerGenerated]
			get
			{
				return <LeftSideBackColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideBackColor1>k__BackingField = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00007ABB File Offset: 0x00005CBB
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00007AC3 File Offset: 0x00005CC3
		public Color LeftSideBackColor2
		{
			[CompilerGenerated]
			get
			{
				return <LeftSideBackColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideBackColor2>k__BackingField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00007AD4 File Offset: 0x00005CD4
		public Color RightSideBackColor1
		{
			[CompilerGenerated]
			get
			{
				return <RightSideBackColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideBackColor1>k__BackingField = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00007ADD File Offset: 0x00005CDD
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00007AE5 File Offset: 0x00005CE5
		public Color RightSideBackColor2
		{
			[CompilerGenerated]
			get
			{
				return <RightSideBackColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideBackColor2>k__BackingField = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00007AEE File Offset: 0x00005CEE
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00007AF6 File Offset: 0x00005CF6
		public Color ButtonNormalBorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalBorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalBorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00007AFF File Offset: 0x00005CFF
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00007B07 File Offset: 0x00005D07
		public Color ButtonNormalBorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalBorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalBorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00007B10 File Offset: 0x00005D10
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00007B18 File Offset: 0x00005D18
		public Color ButtonNormalSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00007B21 File Offset: 0x00005D21
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00007B29 File Offset: 0x00005D29
		public Color ButtonNormalSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00007B32 File Offset: 0x00005D32
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00007B3A File Offset: 0x00005D3A
		public Color ButtonHoverBorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverBorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverBorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00007B43 File Offset: 0x00005D43
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00007B4B File Offset: 0x00005D4B
		public Color ButtonHoverBorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverBorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverBorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00007B54 File Offset: 0x00005D54
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00007B5C File Offset: 0x00005D5C
		public Color ButtonHoverSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00007B65 File Offset: 0x00005D65
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00007B6D File Offset: 0x00005D6D
		public Color ButtonHoverSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00007B76 File Offset: 0x00005D76
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00007B7E File Offset: 0x00005D7E
		public Color ButtonPressedBorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedBorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedBorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00007B87 File Offset: 0x00005D87
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00007B8F File Offset: 0x00005D8F
		public Color ButtonPressedBorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedBorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedBorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00007B98 File Offset: 0x00005D98
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public Color ButtonPressedSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00007BA9 File Offset: 0x00005DA9
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00007BB1 File Offset: 0x00005DB1
		public Color ButtonPressedSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00007BBA File Offset: 0x00005DBA
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00007BC2 File Offset: 0x00005DC2
		public Color ButtonShadowColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonShadowColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonShadowColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00007BCB File Offset: 0x00005DCB
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00007BD3 File Offset: 0x00005DD3
		public Color ButtonShadowColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonShadowColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonShadowColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00007BDC File Offset: 0x00005DDC
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00007BE4 File Offset: 0x00005DE4
		public int ButtonShadowWidth
		{
			[CompilerGenerated]
			get
			{
				return <ButtonShadowWidth>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonShadowWidth>k__BackingField = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00007BED File Offset: 0x00005DED
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public int CornerRadius
		{
			[CompilerGenerated]
			get
			{
				return <CornerRadius>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CornerRadius>k__BackingField = value;
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000173B4 File Offset: 0x000155B4
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(borderRectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath);
				Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? OuterBorderColor : OuterBorderColor.ToGrayScale());
				using (Brush brush = new SolidBrush(color))
				{
					graphics_0.FillPath(brush, roundedRectanglePath);
				}
				graphics_0.ResetClip();
			}
			Rectangle rectangle = new Rectangle(borderRectangle.X + 1, borderRectangle.Y + 1, borderRectangle.Width - 2, borderRectangle.Height - 2);
			using (GraphicsPath roundedRectanglePath2 = GetRoundedRectanglePath(rectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath2);
				Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? InnerBorderColor1 : InnerBorderColor1.ToGrayScale());
				Color color3 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? InnerBorderColor2 : InnerBorderColor2.ToGrayScale());
				using (Brush brush2 = new LinearGradientBrush(borderRectangle, color2, color3, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush2, roundedRectanglePath2);
				}
				graphics_0.ResetClip();
			}
			Rectangle rectangle2 = new Rectangle(borderRectangle.X + 2, borderRectangle.Y + 2, borderRectangle.Width - 4, borderRectangle.Height - 4);
			_innerControlPath = GetRoundedRectanglePath(rectangle2, CornerRadius);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00017598 File Offset: 0x00015798
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			int buttonWidth = GetButtonWidth();
			int num = leftRectangle.Width + buttonWidth / 2;
			Rectangle rectangle = new Rectangle(leftRectangle.X, leftRectangle.Y, num, leftRectangle.Height);
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideBackColor1 : LeftSideBackColor1.ToGrayScale());
			Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideBackColor2 : LeftSideBackColor2.ToGrayScale());
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle);
			}
			else
			{
				graphics_0.SetClip(rectangle);
			}
			using (Brush brush = new LinearGradientBrush(rectangle, color, color2, LinearGradientMode.Vertical))
			{
				graphics_0.FillRectangle(brush, rectangle);
			}
			graphics_0.ResetClip();
			Rectangle rectangle2 = default(Rectangle);
			rectangle2.X = leftRectangle.X + leftRectangle.Width - ButtonShadowWidth;
			rectangle2.Y = leftRectangle.Y;
			rectangle2.Width = ButtonShadowWidth + CornerRadius;
			rectangle2.Height = leftRectangle.Height;
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle2);
			}
			else
			{
				graphics_0.SetClip(rectangle2);
			}
			using (Brush brush2 = new LinearGradientBrush(rectangle2, ButtonShadowColor2, ButtonShadowColor1, LinearGradientMode.Horizontal))
			{
				graphics_0.FillRectangle(brush2, rectangle2);
			}
			graphics_0.ResetClip();
			if (ToggleSwitch.OnSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OnText))
			{
				RectangleF rectangleF = new RectangleF(leftRectangle.X + 1 - (totalToggleFieldWidth - leftRectangle.Width), 1f, totalToggleFieldWidth - 1, ToggleSwitch.Height - 2);
				if (_innerControlPath != null)
				{
					graphics_0.SetClip(_innerControlPath);
					graphics_0.IntersectClip(rectangleF);
				}
				else
				{
					graphics_0.SetClip(rectangleF);
				}
				if (ToggleSwitch.OnSideImage != null)
				{
					Size size = ToggleSwitch.OnSideImage.Size;
					int num2 = (int)rectangleF.X;
					if (ToggleSwitch.OnSideScaleImageToFit)
					{
						Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
						Size size3 = ImageHelper.RescaleImageToFit(size, size2);
						if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
						}
						else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
						{
							num2 = (int)(rectangleF.X + rectangleF.Width - size3.Width);
						}
						Rectangle rectangle3 = new Rectangle(num2, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3);
						}
					}
					else
					{
						if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
						}
						else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
						{
							num2 = (int)(rectangleF.X + rectangleF.Width - size.Width);
						}
						Rectangle rectangle3 = new Rectangle(num2, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImageUnscaled(ToggleSwitch.OnSideImage, rectangle3);
						}
					}
				}
				else if (!string.IsNullOrEmpty(ToggleSwitch.OnText))
				{
					SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OnText, ToggleSwitch.OnFont);
					float num3 = rectangleF.X;
					if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
					{
						num3 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
					}
					else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
					{
						num3 = rectangleF.X + rectangleF.Width - sizeF.Width;
					}
					RectangleF rectangleF2 = new RectangleF(num3, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
					Color color3 = ToggleSwitch.OnForeColor;
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						color3 = color3.ToGrayScale();
					}
					using (Brush brush3 = new SolidBrush(color3))
					{
						graphics_0.DrawString(ToggleSwitch.OnText, ToggleSwitch.OnFont, brush3, rectangleF2);
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00017BB0 File Offset: 0x00015DB0
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			int buttonWidth = GetButtonWidth();
			int num = rightRectangle.Width + buttonWidth / 2;
			Rectangle rectangle = new Rectangle(rightRectangle.X - buttonWidth / 2, rightRectangle.Y, num, rightRectangle.Height);
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideBackColor1 : RightSideBackColor1.ToGrayScale());
			Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideBackColor2 : RightSideBackColor2.ToGrayScale());
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle);
			}
			else
			{
				graphics_0.SetClip(rectangle);
			}
			using (Brush brush = new LinearGradientBrush(rectangle, color, color2, LinearGradientMode.Vertical))
			{
				graphics_0.FillRectangle(brush, rectangle);
			}
			graphics_0.ResetClip();
			Rectangle rectangle2 = default(Rectangle);
			rectangle2.X = rightRectangle.X - CornerRadius;
			rectangle2.Y = rightRectangle.Y;
			rectangle2.Width = ButtonShadowWidth + CornerRadius;
			rectangle2.Height = rightRectangle.Height;
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle2);
			}
			else
			{
				graphics_0.SetClip(rectangle2);
			}
			using (Brush brush2 = new LinearGradientBrush(rectangle2, ButtonShadowColor1, ButtonShadowColor2, LinearGradientMode.Horizontal))
			{
				graphics_0.FillRectangle(brush2, rectangle2);
			}
			graphics_0.ResetClip();
			if (ToggleSwitch.OffSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OffText))
			{
				RectangleF rectangleF = new RectangleF(rightRectangle.X, 1f, totalToggleFieldWidth - 1, ToggleSwitch.Height - 2);
				if (_innerControlPath != null)
				{
					graphics_0.SetClip(_innerControlPath);
					graphics_0.IntersectClip(rectangleF);
				}
				else
				{
					graphics_0.SetClip(rectangleF);
				}
				if (ToggleSwitch.OffSideImage != null)
				{
					Size size = ToggleSwitch.OffSideImage.Size;
					int num2 = (int)rectangleF.X;
					if (ToggleSwitch.OffSideScaleImageToFit)
					{
						Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
						Size size3 = ImageHelper.RescaleImageToFit(size, size2);
						if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
						}
						else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
						{
							num2 = (int)(rectangleF.X + rectangleF.Width - size3.Width);
						}
						Rectangle rectangle3 = new Rectangle(num2, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3);
						}
					}
					else
					{
						if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num2 = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
						}
						else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
						{
							num2 = (int)(rectangleF.X + rectangleF.Width - size.Width);
						}
						Rectangle rectangle3 = new Rectangle(num2, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle3, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImageUnscaled(ToggleSwitch.OffSideImage, rectangle3);
						}
					}
				}
				else if (!string.IsNullOrEmpty(ToggleSwitch.OffText))
				{
					SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OffText, ToggleSwitch.OffFont);
					float num3 = rectangleF.X;
					if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
					{
						num3 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
					}
					else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
					{
						num3 = rectangleF.X + rectangleF.Width - sizeF.Width;
					}
					RectangleF rectangleF2 = new RectangleF(num3, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
					Color color3 = ToggleSwitch.OffForeColor;
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						color3 = color3.ToGrayScale();
					}
					using (Brush brush3 = new SolidBrush(color3))
					{
						graphics_0.DrawString(ToggleSwitch.OffText, ToggleSwitch.OffFont, brush3, rectangleF2);
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000181B8 File Offset: 0x000163B8
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			buttonRectangle.Inflate(-1, -1);
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(buttonRectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath);
				Color color = ButtonNormalSurfaceColor1;
				Color color2 = ButtonNormalSurfaceColor2;
				if (ToggleSwitch.IsButtonPressed)
				{
					color = ButtonPressedSurfaceColor1;
					color2 = ButtonPressedSurfaceColor2;
				}
				else if (ToggleSwitch.IsButtonHovered)
				{
					color = ButtonHoverSurfaceColor1;
					color2 = ButtonHoverSurfaceColor2;
				}
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					color = color.ToGrayScale();
					color2 = color2.ToGrayScale();
				}
				using (Brush brush = new LinearGradientBrush(buttonRectangle, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, roundedRectanglePath);
				}
				Color color3 = ButtonNormalBorderColor1;
				Color color4 = ButtonNormalBorderColor2;
				if (ToggleSwitch.IsButtonPressed)
				{
					color3 = ButtonPressedBorderColor1;
					color4 = ButtonPressedBorderColor2;
				}
				else if (ToggleSwitch.IsButtonHovered)
				{
					color3 = ButtonHoverBorderColor1;
					color4 = ButtonHoverBorderColor2;
				}
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					color3 = color3.ToGrayScale();
					color4 = color4.ToGrayScale();
				}
				using (Brush brush2 = new LinearGradientBrush(buttonRectangle, color3, color4, LinearGradientMode.Vertical))
				{
					using (Pen pen = new Pen(brush2))
					{
						graphics_0.DrawPath(pen, roundedRectanglePath);
					}
				}
				graphics_0.ResetClip();
				Image image = ToggleSwitch.ButtonImage ?? (ToggleSwitch.Checked ? ToggleSwitch.OnButtonImage : ToggleSwitch.OffButtonImage);
				if (image != null)
				{
					graphics_0.SetClip(roundedRectanglePath);
					ToggleSwitch.ToggleSwitchButtonAlignment toggleSwitchButtonAlignment = ((ToggleSwitch.ButtonImage != null) ? ToggleSwitch.ButtonAlignment : (ToggleSwitch.Checked ? ToggleSwitch.OnButtonAlignment : ToggleSwitch.OffButtonAlignment));
					Size size = image.Size;
					int num = buttonRectangle.X;
					if (ToggleSwitch.ButtonImage == null)
					{
						if (!ToggleSwitch.Checked)
						{
							if (!ToggleSwitch.OffButtonScaleImageToFit)
							{
								goto IL_34A;
							}
						}
						else if (!ToggleSwitch.OnButtonScaleImageToFit)
						{
							goto IL_34A;
						}
					}
					else if (!ToggleSwitch.ButtonScaleImageToFit)
					{
						goto IL_34A;
					}
					Size size2 = buttonRectangle.Size;
					Size size3 = ImageHelper.RescaleImageToFit(size, size2);
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num = (int)(buttonRectangle.X + (buttonRectangle.Width - (float)size3.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num = (int)(buttonRectangle.X + (float)buttonRectangle.Width - size3.Width);
					}
					Rectangle rectangle = new Rectangle(num, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size3.Height) / 2f), size3.Width, size3.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						goto IL_418;
					}
					graphics_0.DrawImage(image, rectangle);
					goto IL_418;
					IL_34A:
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num = (int)(buttonRectangle.X + (buttonRectangle.Width - (float)size.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num = (int)(buttonRectangle.X + (float)buttonRectangle.Width - size.Width);
					}
					rectangle = new Rectangle(num, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size.Height) / 2f), size.Width, size.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
					}
					else
					{
						graphics_0.DrawImageUnscaled(image, rectangle);
					}
					IL_418:
					graphics_0.ResetClip();
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00018654 File Offset: 0x00016854
		public GraphicsPath GetRoundedRectanglePath(Rectangle rectangle, int radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = 2 * radius;
			if (num > ToggleSwitch.Height)
			{
				num = ToggleSwitch.Height;
			}
			if (num > ToggleSwitch.Width)
			{
				num = ToggleSwitch.Width;
			}
			graphicsPath.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
			graphicsPath.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
			graphicsPath.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0f, 90f);
			graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00018754 File Offset: 0x00016954
		public override int GetButtonWidth()
		{
			float num = 1.61f * (ToggleSwitch.Height - 2);
			return (int)num;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x040001A0 RID: 416
		private GraphicsPath _innerControlPath;

		// Token: 0x040001A1 RID: 417
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor>k__BackingField;

		// Token: 0x040001A2 RID: 418
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor1>k__BackingField;

		// Token: 0x040001A3 RID: 419
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor2>k__BackingField;

		// Token: 0x040001A4 RID: 420
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor1>k__BackingField;

		// Token: 0x040001A5 RID: 421
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor2>k__BackingField;

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor1>k__BackingField;

		// Token: 0x040001A7 RID: 423
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor2>k__BackingField;

		// Token: 0x040001A8 RID: 424
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor1>k__BackingField;

		// Token: 0x040001A9 RID: 425
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor2>k__BackingField;

		// Token: 0x040001AA RID: 426
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor1>k__BackingField;

		// Token: 0x040001AB RID: 427
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor2>k__BackingField;

		// Token: 0x040001AC RID: 428
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor1>k__BackingField;

		// Token: 0x040001AD RID: 429
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor2>k__BackingField;

		// Token: 0x040001AE RID: 430
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor1>k__BackingField;

		// Token: 0x040001AF RID: 431
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor2>k__BackingField;

		// Token: 0x040001B0 RID: 432
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor1>k__BackingField;

		// Token: 0x040001B1 RID: 433
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor2>k__BackingField;

		// Token: 0x040001B2 RID: 434
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor1>k__BackingField;

		// Token: 0x040001B3 RID: 435
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor2>k__BackingField;

		// Token: 0x040001B4 RID: 436
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor1>k__BackingField;

		// Token: 0x040001B5 RID: 437
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor2>k__BackingField;

		// Token: 0x040001B6 RID: 438
		[CompilerGenerated]
		private int <ButtonShadowWidth>k__BackingField;

		// Token: 0x040001B7 RID: 439
		[CompilerGenerated]
		private int <CornerRadius>k__BackingField;
	}
}
