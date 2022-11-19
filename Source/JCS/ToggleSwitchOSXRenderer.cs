using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000049 RID: 73
	public class ToggleSwitchOSXRenderer : ToggleSwitchRendererBase, IDisposable
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		public ToggleSwitchOSXRenderer()
		{
			OuterBorderColor = Color.FromArgb(255, 108, 108, 108);
			InnerBorderColor1 = Color.FromArgb(255, 137, 138, 139);
			InnerBorderColor2 = Color.FromArgb(255, 167, 168, 169);
			BackColor1 = Color.FromArgb(255, 108, 108, 108);
			BackColor2 = Color.FromArgb(255, 163, 163, 163);
			ButtonNormalBorderColor1 = Color.FromArgb(255, 147, 147, 148);
			ButtonNormalBorderColor2 = Color.FromArgb(255, 167, 168, 169);
			ButtonNormalSurfaceColor1 = Color.FromArgb(255, 250, 250, 250);
			ButtonNormalSurfaceColor2 = Color.FromArgb(255, 224, 224, 224);
			ButtonHoverBorderColor1 = Color.FromArgb(255, 145, 146, 147);
			ButtonHoverBorderColor2 = Color.FromArgb(255, 164, 165, 166);
			ButtonHoverSurfaceColor1 = Color.FromArgb(255, 238, 238, 238);
			ButtonHoverSurfaceColor2 = Color.FromArgb(255, 213, 213, 213);
			ButtonPressedBorderColor1 = Color.FromArgb(255, 138, 138, 140);
			ButtonPressedBorderColor2 = Color.FromArgb(255, 158, 158, 160);
			ButtonPressedSurfaceColor1 = Color.FromArgb(255, 187, 187, 187);
			ButtonPressedSurfaceColor2 = Color.FromArgb(255, 168, 168, 168);
			ButtonShadowColor1 = Color.FromArgb(50, 0, 0, 0);
			ButtonShadowColor2 = Color.FromArgb(0, 0, 0, 0);
			ButtonShadowWidth = 7;
			CornerRadius = 4;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000841C File Offset: 0x0000661C
		public void Dispose()
		{
			if (_innerControlPath != null)
			{
				_innerControlPath.Dispose();
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00008434 File Offset: 0x00006634
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0000843C File Offset: 0x0000663C
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00008445 File Offset: 0x00006645
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000844D File Offset: 0x0000664D
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00008456 File Offset: 0x00006656
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0000845E File Offset: 0x0000665E
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00008467 File Offset: 0x00006667
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000846F File Offset: 0x0000666F
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00008478 File Offset: 0x00006678
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00008480 File Offset: 0x00006680
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00008489 File Offset: 0x00006689
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00008491 File Offset: 0x00006691
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000849A File Offset: 0x0000669A
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000084A2 File Offset: 0x000066A2
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000084AB File Offset: 0x000066AB
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000084B3 File Offset: 0x000066B3
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000084BC File Offset: 0x000066BC
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000084C4 File Offset: 0x000066C4
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000084CD File Offset: 0x000066CD
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000084D5 File Offset: 0x000066D5
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x000084DE File Offset: 0x000066DE
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000084E6 File Offset: 0x000066E6
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000084EF File Offset: 0x000066EF
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000084F7 File Offset: 0x000066F7
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00008500 File Offset: 0x00006700
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00008508 File Offset: 0x00006708
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00008511 File Offset: 0x00006711
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00008519 File Offset: 0x00006719
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00008522 File Offset: 0x00006722
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000852A File Offset: 0x0000672A
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00008533 File Offset: 0x00006733
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000853B File Offset: 0x0000673B
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00008544 File Offset: 0x00006744
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0000854C File Offset: 0x0000674C
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00008555 File Offset: 0x00006755
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000855D File Offset: 0x0000675D
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00008566 File Offset: 0x00006766
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000856E File Offset: 0x0000676E
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00008577 File Offset: 0x00006777
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000857F File Offset: 0x0000677F
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00008588 File Offset: 0x00006788
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00008590 File Offset: 0x00006790
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

		// Token: 0x06000436 RID: 1078 RVA: 0x0001F60C File Offset: 0x0001D80C
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
			graphics_0.SetClip(_innerControlPath);
			Color color4 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BackColor1 : BackColor1.ToGrayScale());
			Color color5 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BackColor2 : BackColor2.ToGrayScale());
			using (Brush brush3 = new LinearGradientBrush(borderRectangle, color4, color5, LinearGradientMode.Vertical))
			{
				graphics_0.FillPath(brush3, _innerControlPath);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001F898 File Offset: 0x0001DA98
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			Rectangle rectangle = default(Rectangle);
			rectangle.X = leftRectangle.X + leftRectangle.Width - ButtonShadowWidth;
			rectangle.Y = leftRectangle.Y;
			rectangle.Width = ButtonShadowWidth + CornerRadius;
			rectangle.Height = leftRectangle.Height;
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle);
			}
			else
			{
				graphics_0.SetClip(rectangle);
			}
			using (Brush brush = new LinearGradientBrush(rectangle, ButtonShadowColor2, ButtonShadowColor1, LinearGradientMode.Horizontal))
			{
				graphics_0.FillRectangle(brush, rectangle);
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
					using (Brush brush2 = new SolidBrush(color))
					{
						graphics_0.DrawString(ToggleSwitch.OnText, ToggleSwitch.OnFont, brush2, rectangleF2);
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			Rectangle rectangle = default(Rectangle);
			rectangle.X = rightRectangle.X - CornerRadius;
			rectangle.Y = rightRectangle.Y;
			rectangle.Width = ButtonShadowWidth + CornerRadius;
			rectangle.Height = rightRectangle.Height;
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(rectangle);
			}
			else
			{
				graphics_0.SetClip(rectangle);
			}
			using (Brush brush = new LinearGradientBrush(rectangle, ButtonShadowColor1, ButtonShadowColor2, LinearGradientMode.Horizontal))
			{
				graphics_0.FillRectangle(brush, rectangle);
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
					using (Brush brush2 = new SolidBrush(color))
					{
						graphics_0.DrawString(ToggleSwitch.OffText, ToggleSwitch.OffFont, brush2, rectangleF2);
					}
				}
				graphics_0.ResetClip();
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000202C4 File Offset: 0x0001E4C4
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

		// Token: 0x0600043A RID: 1082 RVA: 0x00018654 File Offset: 0x00016854
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

		// Token: 0x0600043B RID: 1083 RVA: 0x00020760 File Offset: 0x0001E960
		public override int GetButtonWidth()
		{
			float num = 1.53f * (ToggleSwitch.Height - 2);
			return (int)num;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x04000231 RID: 561
		private GraphicsPath _innerControlPath;

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor>k__BackingField;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor1>k__BackingField;

		// Token: 0x04000234 RID: 564
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor2>k__BackingField;

		// Token: 0x04000235 RID: 565
		[CompilerGenerated]
		private System.Drawing.Color <BackColor1>k__BackingField;

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		private System.Drawing.Color <BackColor2>k__BackingField;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor1>k__BackingField;

		// Token: 0x04000238 RID: 568
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor2>k__BackingField;

		// Token: 0x04000239 RID: 569
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor1>k__BackingField;

		// Token: 0x0400023A RID: 570
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor2>k__BackingField;

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor1>k__BackingField;

		// Token: 0x0400023C RID: 572
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor2>k__BackingField;

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor1>k__BackingField;

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor2>k__BackingField;

		// Token: 0x0400023F RID: 575
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor1>k__BackingField;

		// Token: 0x04000240 RID: 576
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor2>k__BackingField;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor1>k__BackingField;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor2>k__BackingField;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor1>k__BackingField;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor2>k__BackingField;

		// Token: 0x04000245 RID: 581
		[CompilerGenerated]
		private int <ButtonShadowWidth>k__BackingField;

		// Token: 0x04000246 RID: 582
		[CompilerGenerated]
		private int <CornerRadius>k__BackingField;
	}
}
