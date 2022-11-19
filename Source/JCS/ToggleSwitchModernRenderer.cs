using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000048 RID: 72
	public class ToggleSwitchModernRenderer : ToggleSwitchRendererBase, IDisposable
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		public ToggleSwitchModernRenderer()
		{
			OuterBorderColor = Color.FromArgb(255, 31, 31, 31);
			InnerBorderColor1 = Color.FromArgb(255, 80, 80, 82);
			InnerBorderColor2 = Color.FromArgb(255, 109, 110, 112);
			LeftSideBackColor1 = Color.FromArgb(255, 57, 166, 222);
			LeftSideBackColor2 = Color.FromArgb(255, 53, 155, 229);
			RightSideBackColor1 = Color.FromArgb(255, 48, 49, 45);
			RightSideBackColor2 = Color.FromArgb(255, 51, 52, 48);
			ButtonNormalBorderColor1 = Color.FromArgb(255, 31, 31, 31);
			ButtonNormalBorderColor2 = Color.FromArgb(255, 31, 31, 31);
			ButtonNormalSurfaceColor1 = Color.FromArgb(255, 51, 52, 48);
			ButtonNormalSurfaceColor2 = Color.FromArgb(255, 51, 52, 48);
			ArrowNormalColor = Color.FromArgb(255, 53, 156, 230);
			ButtonHoverBorderColor1 = Color.FromArgb(255, 29, 29, 29);
			ButtonHoverBorderColor2 = Color.FromArgb(255, 29, 29, 29);
			ButtonHoverSurfaceColor1 = Color.FromArgb(255, 48, 49, 45);
			ButtonHoverSurfaceColor2 = Color.FromArgb(255, 48, 49, 45);
			ArrowHoverColor = Color.FromArgb(255, 50, 148, 219);
			ButtonPressedBorderColor1 = Color.FromArgb(255, 23, 23, 23);
			ButtonPressedBorderColor2 = Color.FromArgb(255, 23, 23, 23);
			ButtonPressedSurfaceColor1 = Color.FromArgb(255, 38, 39, 36);
			ButtonPressedSurfaceColor2 = Color.FromArgb(255, 38, 39, 36);
			ArrowPressedColor = Color.FromArgb(255, 39, 117, 172);
			ButtonShadowColor1 = Color.FromArgb(50, 0, 0, 0);
			ButtonShadowColor2 = Color.FromArgb(0, 0, 0, 0);
			ButtonShadowWidth = 7;
			CornerRadius = 6;
			ButtonCornerRadius = 6;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00008239 File Offset: 0x00006439
		public void Dispose()
		{
			if (_innerControlPath != null)
			{
				_innerControlPath.Dispose();
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00008251 File Offset: 0x00006451
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00008259 File Offset: 0x00006459
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00008262 File Offset: 0x00006462
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0000826A File Offset: 0x0000646A
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00008273 File Offset: 0x00006473
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000827B File Offset: 0x0000647B
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00008284 File Offset: 0x00006484
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000828C File Offset: 0x0000648C
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00008295 File Offset: 0x00006495
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000829D File Offset: 0x0000649D
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000082A6 File Offset: 0x000064A6
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000082AE File Offset: 0x000064AE
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000082B7 File Offset: 0x000064B7
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000082BF File Offset: 0x000064BF
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000082C8 File Offset: 0x000064C8
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000082D0 File Offset: 0x000064D0
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000082D9 File Offset: 0x000064D9
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000082E1 File Offset: 0x000064E1
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000082EA File Offset: 0x000064EA
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000082F2 File Offset: 0x000064F2
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000082FB File Offset: 0x000064FB
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00008303 File Offset: 0x00006503
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000830C File Offset: 0x0000650C
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00008314 File Offset: 0x00006514
		public Color ArrowNormalColor
		{
			[CompilerGenerated]
			get
			{
				return <ArrowNormalColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ArrowNormalColor>k__BackingField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000831D File Offset: 0x0000651D
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00008325 File Offset: 0x00006525
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000832E File Offset: 0x0000652E
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00008336 File Offset: 0x00006536
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000833F File Offset: 0x0000653F
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00008347 File Offset: 0x00006547
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00008350 File Offset: 0x00006550
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00008358 File Offset: 0x00006558
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00008361 File Offset: 0x00006561
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00008369 File Offset: 0x00006569
		public Color ArrowHoverColor
		{
			[CompilerGenerated]
			get
			{
				return <ArrowHoverColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ArrowHoverColor>k__BackingField = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00008372 File Offset: 0x00006572
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000837A File Offset: 0x0000657A
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00008383 File Offset: 0x00006583
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000838B File Offset: 0x0000658B
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00008394 File Offset: 0x00006594
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000839C File Offset: 0x0000659C
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000083A5 File Offset: 0x000065A5
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000083AD File Offset: 0x000065AD
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000083B6 File Offset: 0x000065B6
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000083BE File Offset: 0x000065BE
		public Color ArrowPressedColor
		{
			[CompilerGenerated]
			get
			{
				return <ArrowPressedColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ArrowPressedColor>k__BackingField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000083C7 File Offset: 0x000065C7
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000083CF File Offset: 0x000065CF
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000083D8 File Offset: 0x000065D8
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000083E0 File Offset: 0x000065E0
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000083E9 File Offset: 0x000065E9
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x000083F1 File Offset: 0x000065F1
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000083FA File Offset: 0x000065FA
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00008402 File Offset: 0x00006602
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000840B File Offset: 0x0000660B
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00008413 File Offset: 0x00006613
		public int ButtonCornerRadius
		{
			[CompilerGenerated]
			get
			{
				return <ButtonCornerRadius>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonCornerRadius>k__BackingField = value;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001E110 File Offset: 0x0001C310
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

		// Token: 0x06000401 RID: 1025 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
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

		// Token: 0x06000402 RID: 1026 RVA: 0x0001E90C File Offset: 0x0001CB0C
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

		// Token: 0x06000403 RID: 1027 RVA: 0x0001EF14 File Offset: 0x0001D114
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			if (_innerControlPath != null)
			{
				graphics_0.SetClip(_innerControlPath);
				graphics_0.IntersectClip(buttonRectangle);
			}
			else
			{
				graphics_0.SetClip(buttonRectangle);
			}
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(buttonRectangle, ButtonCornerRadius))
			{
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
			}
			graphics_0.ResetClip();
			Color color5 = ArrowNormalColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color5 = ArrowPressedColor;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color5 = ArrowHoverColor;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color5 = color5.ToGrayScale();
			}
			Rectangle rectangle = default(Rectangle);
			rectangle.Height = 9;
			rectangle.Width = 22;
			rectangle.X = buttonRectangle.X + (int)((buttonRectangle.Width - (double)rectangle.Width) / 2.0);
			rectangle.Y = buttonRectangle.Y + (int)((buttonRectangle.Height - (double)rectangle.Height) / 2.0);
			using (Brush brush3 = new SolidBrush(color5))
			{
				using (GraphicsPath arrowLeftPath = GetArrowLeftPath(rectangle))
				{
					graphics_0.FillPath(brush3, arrowLeftPath);
				}
				using (GraphicsPath arrowRightPath = GetArrowRightPath(rectangle))
				{
					graphics_0.FillPath(brush3, arrowRightPath);
				}
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00018654 File Offset: 0x00016854
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

		// Token: 0x06000405 RID: 1029 RVA: 0x0001F28C File Offset: 0x0001D48C
		public GraphicsPath GetArrowLeftPath(Rectangle arrowRectangle)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Point point = new Point(arrowRectangle.X + 8, arrowRectangle.Y);
			Point point2 = new Point(arrowRectangle.X + 8, arrowRectangle.Y + arrowRectangle.Height);
			Point point3 = new Point(arrowRectangle.X, arrowRectangle.Y + arrowRectangle.Height / 2);
			graphicsPath.AddLine(point, point2);
			graphicsPath.AddLine(point2, point3);
			graphicsPath.AddLine(point3, point);
			return graphicsPath;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001F314 File Offset: 0x0001D514
		public GraphicsPath GetArrowRightPath(Rectangle arrowRectangle)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Point point = new Point(arrowRectangle.X + 14, arrowRectangle.Y);
			Point point2 = new Point(arrowRectangle.X + 14, arrowRectangle.Y + arrowRectangle.Height);
			Point point3 = new Point(arrowRectangle.X + arrowRectangle.Width, arrowRectangle.Y + arrowRectangle.Height / 2);
			graphicsPath.AddLine(point, point2);
			graphicsPath.AddLine(point2, point3);
			graphicsPath.AddLine(point3, point);
			return graphicsPath;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		public override int GetButtonWidth()
		{
			float num = 1.41f * ToggleSwitch.Height;
			return (int)num;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x04000215 RID: 533
		private GraphicsPath _innerControlPath;

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor>k__BackingField;

		// Token: 0x04000217 RID: 535
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor1>k__BackingField;

		// Token: 0x04000218 RID: 536
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor2>k__BackingField;

		// Token: 0x04000219 RID: 537
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor1>k__BackingField;

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor2>k__BackingField;

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor1>k__BackingField;

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor2>k__BackingField;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor1>k__BackingField;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor2>k__BackingField;

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor1>k__BackingField;

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor2>k__BackingField;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		private System.Drawing.Color <ArrowNormalColor>k__BackingField;

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor1>k__BackingField;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor2>k__BackingField;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor1>k__BackingField;

		// Token: 0x04000225 RID: 549
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor2>k__BackingField;

		// Token: 0x04000226 RID: 550
		[CompilerGenerated]
		private System.Drawing.Color <ArrowHoverColor>k__BackingField;

		// Token: 0x04000227 RID: 551
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor1>k__BackingField;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor2>k__BackingField;

		// Token: 0x04000229 RID: 553
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor1>k__BackingField;

		// Token: 0x0400022A RID: 554
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor2>k__BackingField;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private System.Drawing.Color <ArrowPressedColor>k__BackingField;

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor1>k__BackingField;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor2>k__BackingField;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private int <ButtonShadowWidth>k__BackingField;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private int <CornerRadius>k__BackingField;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private int <ButtonCornerRadius>k__BackingField;
	}
}
