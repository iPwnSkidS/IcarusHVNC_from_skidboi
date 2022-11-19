using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000046 RID: 70
	public class ToggleSwitchIphoneRenderer : ToggleSwitchRendererBase, IDisposable
	{
		// Token: 0x06000370 RID: 880 RVA: 0x0001BD28 File Offset: 0x00019F28
		public ToggleSwitchIphoneRenderer()
		{
			OuterBorderColor = Color.FromArgb(255, 205, 205, 207);
			InnerBorderColor1 = Color.FromArgb(200, 205, 205, 207);
			InnerBorderColor2 = Color.FromArgb(200, 205, 205, 207);
			LeftSideBackColor1 = Color.FromArgb(255, 50, 101, 161);
			LeftSideBackColor2 = Color.FromArgb(255, 123, 174, 229);
			RightSideBackColor1 = Color.FromArgb(255, 161, 161, 161);
			RightSideBackColor2 = Color.FromArgb(255, 250, 250, 250);
			ButtonNormalBorderColor1 = Color.FromArgb(255, 172, 172, 172);
			ButtonNormalBorderColor2 = Color.FromArgb(255, 196, 196, 196);
			ButtonNormalSurfaceColor1 = Color.FromArgb(255, 216, 215, 216);
			ButtonNormalSurfaceColor2 = Color.FromArgb(255, 251, 250, 251);
			ButtonHoverBorderColor1 = Color.FromArgb(255, 163, 163, 163);
			ButtonHoverBorderColor2 = Color.FromArgb(255, 185, 185, 185);
			ButtonHoverSurfaceColor1 = Color.FromArgb(255, 205, 204, 205);
			ButtonHoverSurfaceColor2 = Color.FromArgb(255, 239, 238, 239);
			ButtonPressedBorderColor1 = Color.FromArgb(255, 129, 129, 129);
			ButtonPressedBorderColor2 = Color.FromArgb(255, 146, 146, 146);
			ButtonPressedSurfaceColor1 = Color.FromArgb(255, 162, 161, 162);
			ButtonPressedSurfaceColor2 = Color.FromArgb(255, 188, 187, 188);
			ButtonShadowColor1 = Color.FromArgb(50, 0, 0, 0);
			ButtonShadowColor2 = Color.FromArgb(0, 0, 0, 0);
			ButtonShadowWidth = 7;
			CornerRadius = 6;
			ButtonCornerRadius = 9;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00007FCE File Offset: 0x000061CE
		public void Dispose()
		{
			if (_innerControlPath != null)
			{
				_innerControlPath.Dispose();
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00007FE6 File Offset: 0x000061E6
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00007FEE File Offset: 0x000061EE
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00007FF7 File Offset: 0x000061F7
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00007FFF File Offset: 0x000061FF
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00008008 File Offset: 0x00006208
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00008010 File Offset: 0x00006210
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00008019 File Offset: 0x00006219
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00008021 File Offset: 0x00006221
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000802A File Offset: 0x0000622A
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00008032 File Offset: 0x00006232
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000803B File Offset: 0x0000623B
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00008043 File Offset: 0x00006243
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000804C File Offset: 0x0000624C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00008054 File Offset: 0x00006254
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000805D File Offset: 0x0000625D
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00008065 File Offset: 0x00006265
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000806E File Offset: 0x0000626E
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00008076 File Offset: 0x00006276
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000807F File Offset: 0x0000627F
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00008087 File Offset: 0x00006287
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00008090 File Offset: 0x00006290
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00008098 File Offset: 0x00006298
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000080A1 File Offset: 0x000062A1
		// (set) Token: 0x06000389 RID: 905 RVA: 0x000080A9 File Offset: 0x000062A9
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000080B2 File Offset: 0x000062B2
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000080BA File Offset: 0x000062BA
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000080C3 File Offset: 0x000062C3
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000080CB File Offset: 0x000062CB
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000080D4 File Offset: 0x000062D4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000080DC File Offset: 0x000062DC
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000080E5 File Offset: 0x000062E5
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000080ED File Offset: 0x000062ED
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000080F6 File Offset: 0x000062F6
		// (set) Token: 0x06000393 RID: 915 RVA: 0x000080FE File Offset: 0x000062FE
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00008107 File Offset: 0x00006307
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000810F File Offset: 0x0000630F
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00008118 File Offset: 0x00006318
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00008120 File Offset: 0x00006320
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00008129 File Offset: 0x00006329
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00008131 File Offset: 0x00006331
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000813A File Offset: 0x0000633A
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00008142 File Offset: 0x00006342
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000814B File Offset: 0x0000634B
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00008153 File Offset: 0x00006353
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000815C File Offset: 0x0000635C
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00008164 File Offset: 0x00006364
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000816D File Offset: 0x0000636D
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00008175 File Offset: 0x00006375
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0001BFBC File Offset: 0x0001A1BC
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

		// Token: 0x060003A3 RID: 931 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
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

		// Token: 0x060003A4 RID: 932 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(buttonRectangle, ButtonCornerRadius))
			{
				if (_innerControlPath != null)
				{
					graphics_0.SetClip(_innerControlPath);
					graphics_0.IntersectClip(buttonRectangle);
				}
				else
				{
					graphics_0.SetClip(buttonRectangle);
				}
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
								goto IL_361;
							}
						}
						else if (!ToggleSwitch.OnButtonScaleImageToFit)
						{
							goto IL_361;
						}
					}
					else if (!ToggleSwitch.ButtonScaleImageToFit)
					{
						goto IL_361;
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
						goto IL_42F;
					}
					graphics_0.DrawImage(image, rectangle);
					goto IL_42F;
					IL_361:
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
					IL_42F:
					graphics_0.ResetClip();
				}
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00018654 File Offset: 0x00016854
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

		// Token: 0x060003A7 RID: 935 RVA: 0x0001D274 File Offset: 0x0001B474
		public override int GetButtonWidth()
		{
			float num = 1.57f * ToggleSwitch.Height;
			return (int)num;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x040001F1 RID: 497
		private GraphicsPath _innerControlPath;

		// Token: 0x040001F2 RID: 498
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor>k__BackingField;

		// Token: 0x040001F3 RID: 499
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor1>k__BackingField;

		// Token: 0x040001F4 RID: 500
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor2>k__BackingField;

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor1>k__BackingField;

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor2>k__BackingField;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor1>k__BackingField;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor2>k__BackingField;

		// Token: 0x040001F9 RID: 505
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor1>k__BackingField;

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor2>k__BackingField;

		// Token: 0x040001FB RID: 507
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor1>k__BackingField;

		// Token: 0x040001FC RID: 508
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor2>k__BackingField;

		// Token: 0x040001FD RID: 509
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor1>k__BackingField;

		// Token: 0x040001FE RID: 510
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor2>k__BackingField;

		// Token: 0x040001FF RID: 511
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor1>k__BackingField;

		// Token: 0x04000200 RID: 512
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor2>k__BackingField;

		// Token: 0x04000201 RID: 513
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor1>k__BackingField;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor2>k__BackingField;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor1>k__BackingField;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor2>k__BackingField;

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor1>k__BackingField;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor2>k__BackingField;

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		private int <ButtonShadowWidth>k__BackingField;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		private int <CornerRadius>k__BackingField;

		// Token: 0x04000209 RID: 521
		[CompilerGenerated]
		private int <ButtonCornerRadius>k__BackingField;
	}
}
