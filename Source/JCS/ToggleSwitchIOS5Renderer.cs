using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000045 RID: 69
	public class ToggleSwitchIOS5Renderer : ToggleSwitchRendererBase
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00019EBC File Offset: 0x000180BC
		public ToggleSwitchIOS5Renderer()
		{
			BorderColor = Color.FromArgb(255, 202, 202, 202);
			LeftSideUpperColor1 = Color.FromArgb(255, 48, 115, 189);
			LeftSideUpperColor2 = Color.FromArgb(255, 17, 123, 220);
			LeftSideLowerColor1 = Color.FromArgb(255, 65, 143, 218);
			LeftSideLowerColor2 = Color.FromArgb(255, 130, 190, 243);
			LeftSideUpperBorderColor = Color.FromArgb(150, 123, 157, 196);
			LeftSideLowerBorderColor = Color.FromArgb(150, 174, 208, 241);
			RightSideUpperColor1 = Color.FromArgb(255, 191, 191, 191);
			RightSideUpperColor2 = Color.FromArgb(255, 229, 229, 229);
			RightSideLowerColor1 = Color.FromArgb(255, 232, 232, 232);
			RightSideLowerColor2 = Color.FromArgb(255, 251, 251, 251);
			RightSideUpperBorderColor = Color.FromArgb(150, 175, 175, 175);
			RightSideLowerBorderColor = Color.FromArgb(150, 229, 230, 233);
			ButtonShadowColor = Color.Transparent;
			ButtonNormalOuterBorderColor = Color.FromArgb(255, 149, 172, 194);
			ButtonNormalInnerBorderColor = Color.FromArgb(255, 235, 235, 235);
			ButtonNormalSurfaceColor1 = Color.FromArgb(255, 216, 215, 216);
			ButtonNormalSurfaceColor2 = Color.FromArgb(255, 251, 250, 251);
			ButtonHoverOuterBorderColor = Color.FromArgb(255, 141, 163, 184);
			ButtonHoverInnerBorderColor = Color.FromArgb(255, 223, 223, 223);
			ButtonHoverSurfaceColor1 = Color.FromArgb(255, 205, 204, 205);
			ButtonHoverSurfaceColor2 = Color.FromArgb(255, 239, 238, 239);
			ButtonPressedOuterBorderColor = Color.FromArgb(255, 111, 128, 145);
			ButtonPressedInnerBorderColor = Color.FromArgb(255, 176, 176, 176);
			ButtonPressedSurfaceColor1 = Color.FromArgb(255, 162, 161, 162);
			ButtonPressedSurfaceColor2 = Color.FromArgb(255, 187, 187, 187);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00007E14 File Offset: 0x00006014
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00007E1C File Offset: 0x0000601C
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00007E25 File Offset: 0x00006025
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00007E2D File Offset: 0x0000602D
		public Color LeftSideUpperColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideUpperColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideUpperColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00007E36 File Offset: 0x00006036
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00007E3E File Offset: 0x0000603E
		public Color LeftSideUpperColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideUpperColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideUpperColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00007E47 File Offset: 0x00006047
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00007E4F File Offset: 0x0000604F
		public Color LeftSideLowerColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideLowerColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideLowerColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00007E58 File Offset: 0x00006058
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00007E60 File Offset: 0x00006060
		public Color LeftSideLowerColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideLowerColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideLowerColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00007E69 File Offset: 0x00006069
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00007E71 File Offset: 0x00006071
		public Color LeftSideUpperBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideUpperBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideUpperBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00007E7A File Offset: 0x0000607A
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00007E82 File Offset: 0x00006082
		public Color LeftSideLowerBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<LeftSideLowerBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideLowerBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00007E8B File Offset: 0x0000608B
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00007E93 File Offset: 0x00006093
		public Color RightSideUpperColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideUpperColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideUpperColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00007E9C File Offset: 0x0000609C
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00007EA4 File Offset: 0x000060A4
		public Color RightSideUpperColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideUpperColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideUpperColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00007EAD File Offset: 0x000060AD
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00007EB5 File Offset: 0x000060B5
		public Color RightSideLowerColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideLowerColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideLowerColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00007EBE File Offset: 0x000060BE
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00007EC6 File Offset: 0x000060C6
		public Color RightSideLowerColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideLowerColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideLowerColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00007ECF File Offset: 0x000060CF
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00007ED7 File Offset: 0x000060D7
		public Color RightSideUpperBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideUpperBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideUpperBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00007EE0 File Offset: 0x000060E0
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00007EE8 File Offset: 0x000060E8
		public Color RightSideLowerBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<RightSideLowerBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideLowerBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00007EF1 File Offset: 0x000060F1
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00007EF9 File Offset: 0x000060F9
		public Color ButtonShadowColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonShadowColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonShadowColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00007F02 File Offset: 0x00006102
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00007F0A File Offset: 0x0000610A
		public Color ButtonNormalOuterBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonNormalOuterBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalOuterBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00007F13 File Offset: 0x00006113
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00007F1B File Offset: 0x0000611B
		public Color ButtonNormalInnerBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonNormalInnerBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalInnerBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00007F24 File Offset: 0x00006124
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00007F2C File Offset: 0x0000612C
		public Color ButtonNormalSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonNormalSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00007F35 File Offset: 0x00006135
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00007F3D File Offset: 0x0000613D
		public Color ButtonNormalSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonNormalSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00007F46 File Offset: 0x00006146
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00007F4E File Offset: 0x0000614E
		public Color ButtonHoverOuterBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonHoverOuterBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverOuterBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00007F57 File Offset: 0x00006157
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00007F5F File Offset: 0x0000615F
		public Color ButtonHoverInnerBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonHoverInnerBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverInnerBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00007F68 File Offset: 0x00006168
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00007F70 File Offset: 0x00006170
		public Color ButtonHoverSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonHoverSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00007F79 File Offset: 0x00006179
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00007F81 File Offset: 0x00006181
		public Color ButtonHoverSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonHoverSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00007F8A File Offset: 0x0000618A
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00007F92 File Offset: 0x00006192
		public Color ButtonPressedOuterBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonPressedOuterBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedOuterBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00007F9B File Offset: 0x0000619B
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00007FA3 File Offset: 0x000061A3
		public Color ButtonPressedInnerBorderColor
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonPressedInnerBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedInnerBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00007FAC File Offset: 0x000061AC
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00007FB4 File Offset: 0x000061B4
		public Color ButtonPressedSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonPressedSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00007FBD File Offset: 0x000061BD
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00007FC5 File Offset: 0x000061C5
		public Color ButtonPressedSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return this.<ButtonPressedSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000063EF File Offset: 0x000045EF
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001A1CC File Offset: 0x000183CC
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			int buttonWidth = GetButtonWidth();
			int num = leftRectangle.Width + buttonWidth / 2;
			int num2 = (int)(0.8 * (leftRectangle.Height - 2));
			Rectangle rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			GraphicsPath graphicsPath = GetControlClipPath(rectangle);
			Rectangle rectangle2 = new Rectangle(leftRectangle.X, leftRectangle.Y + 1, num, num2 - 1);
			graphics_0.SetClip(graphicsPath);
			graphics_0.IntersectClip(rectangle2);
			using (GraphicsPath graphicsPath2 = new GraphicsPath())
			{
				graphicsPath2.AddArc(rectangle2.X, rectangle2.Y, ToggleSwitch.Height, ToggleSwitch.Height, 135f, 135f);
				graphicsPath2.AddLine(rectangle2.X, rectangle2.Y, rectangle2.X + rectangle2.Width, rectangle2.Y);
				graphicsPath2.AddLine(rectangle2.X + rectangle2.Width, rectangle2.Y, rectangle2.X + rectangle2.Width, rectangle2.Y + rectangle2.Height);
				graphicsPath2.AddLine(rectangle2.X, rectangle2.Y + rectangle2.Height, rectangle2.X + rectangle2.Width, rectangle2.Y + rectangle2.Height);
				Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideUpperColor1 : LeftSideUpperColor1.ToGrayScale());
				Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideUpperColor2 : LeftSideUpperColor2.ToGrayScale());
				using (Brush brush = new LinearGradientBrush(rectangle2, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, graphicsPath2);
				}
			}
			graphics_0.ResetClip();
			int num3 = (int)Math.Ceiling(0.5 * (leftRectangle.Height - 2));
			Rectangle rectangle3 = new Rectangle(leftRectangle.X, leftRectangle.Y + leftRectangle.Height / 2, num, num3);
			graphics_0.SetClip(graphicsPath);
			graphics_0.IntersectClip(rectangle3);
			using (GraphicsPath graphicsPath3 = new GraphicsPath())
			{
				graphicsPath3.AddArc(1, rectangle3.Y, (int)(0.75 * (ToggleSwitch.Height - 1)), ToggleSwitch.Height - 1, 215f, 45f);
				graphicsPath3.AddLine(rectangle3.X + buttonWidth / 2, rectangle3.Y, rectangle3.X + rectangle3.Width, rectangle3.Y);
				graphicsPath3.AddLine(rectangle3.X + rectangle3.Width, rectangle3.Y, rectangle3.X + rectangle3.Width, rectangle3.Y + rectangle3.Height);
				graphicsPath3.AddLine(rectangle3.X + buttonWidth / 4, rectangle3.Y + rectangle3.Height, rectangle3.X + rectangle3.Width, rectangle3.Y + rectangle3.Height);
				graphicsPath3.AddArc(1, 1, ToggleSwitch.Height - 1, ToggleSwitch.Height - 1, 90f, 70f);
				Color color3 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideLowerColor1 : LeftSideLowerColor1.ToGrayScale());
				Color color4 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? LeftSideLowerColor2 : LeftSideLowerColor2.ToGrayScale());
				using (Brush brush2 = new LinearGradientBrush(rectangle3, color3, color4, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush2, graphicsPath3);
				}
			}
			graphics_0.ResetClip();
			rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			graphicsPath = GetControlClipPath(rectangle);
			graphics_0.SetClip(graphicsPath);
			Color color5 = LeftSideUpperBorderColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color5 = color5.ToGrayScale();
			}
			using (Pen pen = new Pen(color5))
			{
				graphics_0.DrawLine(pen, leftRectangle.X, leftRectangle.Y + 1, leftRectangle.X + leftRectangle.Width + buttonWidth / 2, leftRectangle.Y + 1);
			}
			Color color6 = LeftSideLowerBorderColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color6 = color6.ToGrayScale();
			}
			using (Pen pen2 = new Pen(color6))
			{
				graphics_0.DrawLine(pen2, leftRectangle.X, leftRectangle.Y + leftRectangle.Height - 1, leftRectangle.X + leftRectangle.Width + buttonWidth / 2, leftRectangle.Y + leftRectangle.Height - 1);
			}
			if (ToggleSwitch.OnSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OnText))
			{
				RectangleF rectangleF = new RectangleF(leftRectangle.X + 2 - (totalToggleFieldWidth - leftRectangle.Width), 2f, totalToggleFieldWidth - 2, ToggleSwitch.Height - 4);
				graphics_0.IntersectClip(rectangleF);
				if (ToggleSwitch.OnSideImage != null)
				{
					Size size = ToggleSwitch.OnSideImage.Size;
					int num4 = (int)rectangleF.X;
					if (ToggleSwitch.OnSideScaleImageToFit)
					{
						Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
						Size size3 = ImageHelper.RescaleImageToFit(size, size2);
						if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num4 = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
						}
						else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
						{
							num4 = (int)(rectangleF.X + rectangleF.Width - size3.Width);
						}
						Rectangle rectangle4 = new Rectangle(num4, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4);
						}
					}
					else
					{
						if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num4 = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
						}
						else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
						{
							num4 = (int)(rectangleF.X + rectangleF.Width - size.Width);
						}
						Rectangle rectangle4 = new Rectangle(num4, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImageUnscaled(ToggleSwitch.OnSideImage, rectangle4);
						}
					}
				}
				else if (!string.IsNullOrEmpty(ToggleSwitch.OnText))
				{
					SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OnText, ToggleSwitch.OnFont);
					float num5 = rectangleF.X;
					if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
					{
						num5 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
					}
					else if (ToggleSwitch.OnSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Near)
					{
						num5 = rectangleF.X + rectangleF.Width - sizeF.Width;
					}
					RectangleF rectangleF2 = new RectangleF(num5, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
					Color color7 = ToggleSwitch.OnForeColor;
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						color7 = color7.ToGrayScale();
					}
					using (Brush brush3 = new SolidBrush(color7))
					{
						graphics_0.DrawString(ToggleSwitch.OnText, ToggleSwitch.OnFont, brush3, rectangleF2);
					}
				}
			}
			graphics_0.ResetClip();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			Rectangle buttonRectangle = GetButtonRectangle();
			Rectangle rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			GraphicsPath graphicsPath = GetControlClipPath(rectangle);
			int num = rightRectangle.Width + buttonRectangle.Width / 2;
			int num2 = (int)(0.8 * (rightRectangle.Height - 2));
			Rectangle rectangle2 = new Rectangle(rightRectangle.X - buttonRectangle.Width / 2, rightRectangle.Y + 1, num - 1, num2 - 1);
			graphics_0.SetClip(graphicsPath);
			graphics_0.IntersectClip(rectangle2);
			using (GraphicsPath graphicsPath2 = new GraphicsPath())
			{
				graphicsPath2.AddLine(rectangle2.X, rectangle2.Y, rectangle2.X + rectangle2.Width, rectangle2.Y);
				graphicsPath2.AddArc(rectangle2.X + rectangle2.Width - ToggleSwitch.Height + 1, rectangle2.Y - 1, ToggleSwitch.Height, ToggleSwitch.Height, 270f, 115f);
				graphicsPath2.AddLine(rectangle2.X + rectangle2.Width, rectangle2.Y + rectangle2.Height, rectangle2.X, rectangle2.Y + rectangle2.Height);
				graphicsPath2.AddLine(rectangle2.X, rectangle2.Y + rectangle2.Height, rectangle2.X, rectangle2.Y);
				Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideUpperColor1 : RightSideUpperColor1.ToGrayScale());
				Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideUpperColor2 : RightSideUpperColor2.ToGrayScale());
				using (Brush brush = new LinearGradientBrush(rectangle2, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, graphicsPath2);
				}
			}
			graphics_0.ResetClip();
			int num3 = (int)Math.Ceiling(0.5 * (rightRectangle.Height - 2));
			Rectangle rectangle3 = new Rectangle(rightRectangle.X - buttonRectangle.Width / 2, rightRectangle.Y + rightRectangle.Height / 2, num - 1, num3);
			graphics_0.SetClip(graphicsPath);
			graphics_0.IntersectClip(rectangle3);
			using (GraphicsPath graphicsPath3 = new GraphicsPath())
			{
				graphicsPath3.AddLine(rectangle3.X, rectangle3.Y, rectangle3.X + rectangle3.Width, rectangle3.Y);
				graphicsPath3.AddArc(rectangle3.X + rectangle3.Width - (int)(0.75 * (ToggleSwitch.Height - 1)), rectangle3.Y, (int)(0.75 * (ToggleSwitch.Height - 1)), ToggleSwitch.Height - 1, 270f, 45f);
				graphicsPath3.AddArc(ToggleSwitch.Width - ToggleSwitch.Height, 0, ToggleSwitch.Height, ToggleSwitch.Height, 20f, 70f);
				graphicsPath3.AddLine(rectangle3.X + rectangle3.Width, rectangle3.Y + rectangle3.Height, rectangle3.X, rectangle3.Y + rectangle3.Height);
				graphicsPath3.AddLine(rectangle3.X, rectangle3.Y + rectangle3.Height, rectangle3.X, rectangle3.Y);
				Color color3 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideLowerColor1 : RightSideLowerColor1.ToGrayScale());
				Color color4 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? RightSideLowerColor2 : RightSideLowerColor2.ToGrayScale());
				using (Brush brush2 = new LinearGradientBrush(rectangle3, color3, color4, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush2, graphicsPath3);
				}
			}
			graphics_0.ResetClip();
			rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			graphicsPath = GetControlClipPath(rectangle);
			graphics_0.SetClip(graphicsPath);
			Color color5 = RightSideUpperBorderColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color5 = color5.ToGrayScale();
			}
			using (Pen pen = new Pen(color5))
			{
				graphics_0.DrawLine(pen, rightRectangle.X - buttonRectangle.Width / 2, rightRectangle.Y + 1, rightRectangle.X + rightRectangle.Width, rightRectangle.Y + 1);
			}
			Color color6 = RightSideLowerBorderColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color6 = color6.ToGrayScale();
			}
			using (Pen pen2 = new Pen(color6))
			{
				graphics_0.DrawLine(pen2, rightRectangle.X - buttonRectangle.Width / 2, rightRectangle.Y + rightRectangle.Height - 1, rightRectangle.X + rightRectangle.Width, rightRectangle.Y + rightRectangle.Height - 1);
			}
			if (ToggleSwitch.OffSideImage != null || !string.IsNullOrEmpty(ToggleSwitch.OffText))
			{
				RectangleF rectangleF = new RectangleF(rightRectangle.X, 2f, totalToggleFieldWidth - 2, ToggleSwitch.Height - 4);
				graphics_0.IntersectClip(rectangleF);
				if (ToggleSwitch.OffSideImage != null)
				{
					Size size = ToggleSwitch.OffSideImage.Size;
					int num4 = (int)rectangleF.X;
					if (ToggleSwitch.OffSideScaleImageToFit)
					{
						Size size2 = new Size((int)rectangleF.Width, (int)rectangleF.Height);
						Size size3 = ImageHelper.RescaleImageToFit(size, size2);
						if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num4 = (int)(rectangleF.X + (rectangleF.Width - size3.Width) / 2f);
						}
						else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
						{
							num4 = (int)(rectangleF.X + rectangleF.Width - size3.Width);
						}
						Rectangle rectangle4 = new Rectangle(num4, (int)(rectangleF.Y + (rectangleF.Height - size3.Height) / 2f), size3.Width, size3.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4);
						}
					}
					else
					{
						if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
						{
							num4 = (int)(rectangleF.X + (rectangleF.Width - size.Width) / 2f);
						}
						else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
						{
							num4 = (int)(rectangleF.X + rectangleF.Width - size.Width);
						}
						Rectangle rectangle4 = new Rectangle(num4, (int)(rectangleF.Y + (rectangleF.Height - size.Height) / 2f), size.Width, size.Height);
						if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
						{
							graphics_0.DrawImage(ToggleSwitch.OnSideImage, rectangle4, 0, 0, ToggleSwitch.OnSideImage.Width, ToggleSwitch.OnSideImage.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						}
						else
						{
							graphics_0.DrawImageUnscaled(ToggleSwitch.OffSideImage, rectangle4);
						}
					}
				}
				else if (!string.IsNullOrEmpty(ToggleSwitch.OffText))
				{
					SizeF sizeF = graphics_0.MeasureString(ToggleSwitch.OffText, ToggleSwitch.OffFont);
					float num5 = rectangleF.X;
					if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Center)
					{
						num5 = rectangleF.X + (rectangleF.Width - sizeF.Width) / 2f;
					}
					else if (ToggleSwitch.OffSideAlignment == ToggleSwitch.ToggleSwitchAlignment.Far)
					{
						num5 = rectangleF.X + rectangleF.Width - sizeF.Width;
					}
					RectangleF rectangleF2 = new RectangleF(num5, rectangleF.Y + (rectangleF.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
					Color color7 = ToggleSwitch.OffForeColor;
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						color7 = color7.ToGrayScale();
					}
					using (Brush brush3 = new SolidBrush(color7))
					{
						graphics_0.DrawString(ToggleSwitch.OffText, ToggleSwitch.OffFont, brush3, rectangleF2);
					}
				}
			}
			graphics_0.ResetClip();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001B618 File Offset: 0x00019818
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			if (ToggleSwitch.IsButtonOnLeftSide)
			{
				buttonRectangle.X++;
			}
			else if (ToggleSwitch.IsButtonOnRightSide)
			{
				buttonRectangle.X--;
			}
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			buttonRectangle.Inflate(1, 1);
			Rectangle rectangle = new Rectangle(buttonRectangle.Location, buttonRectangle.Size);
			rectangle.Inflate(0, -1);
			if (ToggleSwitch.IsButtonOnLeftSide)
			{
				rectangle.X += rectangle.Width / 2;
				rectangle.Width /= 2;
			}
			else if (ToggleSwitch.IsButtonOnRightSide)
			{
				rectangle.Width /= 2;
			}
			graphics_0.SetClip(rectangle);
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? ButtonShadowColor : ButtonShadowColor.ToGrayScale());
			using (Pen pen = new Pen(color))
			{
				graphics_0.DrawEllipse(pen, buttonRectangle);
			}
			graphics_0.ResetClip();
			buttonRectangle.Inflate(-1, -1);
			Color color2 = ButtonNormalOuterBorderColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color2 = ButtonPressedOuterBorderColor;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color2 = ButtonHoverOuterBorderColor;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color2 = color2.ToGrayScale();
			}
			using (Brush brush = new SolidBrush(color2))
			{
				graphics_0.FillEllipse(brush, buttonRectangle);
			}
			buttonRectangle.Inflate(-1, -1);
			Color color3 = ButtonNormalInnerBorderColor;
			if (ToggleSwitch.IsButtonPressed)
			{
				color3 = ButtonPressedInnerBorderColor;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color3 = ButtonHoverInnerBorderColor;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color3 = color3.ToGrayScale();
			}
			using (Brush brush2 = new SolidBrush(color3))
			{
				graphics_0.FillEllipse(brush2, buttonRectangle);
			}
			buttonRectangle.Inflate(-1, -1);
			Color color4 = ButtonNormalSurfaceColor1;
			if (ToggleSwitch.IsButtonPressed)
			{
				color4 = ButtonPressedSurfaceColor1;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color4 = ButtonHoverSurfaceColor1;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color4 = color4.ToGrayScale();
			}
			Color color5 = ButtonNormalSurfaceColor2;
			if (ToggleSwitch.IsButtonPressed)
			{
				color5 = ButtonPressedSurfaceColor2;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color5 = ButtonHoverSurfaceColor2;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color5 = color5.ToGrayScale();
			}
			using (Brush brush3 = new LinearGradientBrush(buttonRectangle, color4, color5, LinearGradientMode.Vertical))
			{
				graphics_0.FillEllipse(brush3, buttonRectangle);
			}
			graphics_0.CompositingMode = CompositingMode.SourceOver;
			graphics_0.CompositingQuality = CompositingQuality.HighQuality;
			Rectangle rectangle2 = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			using (GraphicsPath controlClipPath = GetControlClipPath(rectangle2))
			{
				Color color6 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BorderColor : BorderColor.ToGrayScale());
				using (Pen pen2 = new Pen(color6))
				{
					graphics_0.DrawPath(pen2, controlClipPath);
				}
			}
			graphics_0.ResetClip();
			Image image = ToggleSwitch.ButtonImage ?? (ToggleSwitch.Checked ? ToggleSwitch.OnButtonImage : ToggleSwitch.OffButtonImage);
			if (image != null)
			{
				graphics_0.SetClip(GetButtonClipPath());
				ToggleSwitch.ToggleSwitchButtonAlignment toggleSwitchButtonAlignment = ((ToggleSwitch.ButtonImage != null) ? ToggleSwitch.ButtonAlignment : (ToggleSwitch.Checked ? ToggleSwitch.OnButtonAlignment : ToggleSwitch.OffButtonAlignment));
				Size size = image.Size;
				int num = buttonRectangle.X;
				if (ToggleSwitch.ButtonImage == null)
				{
					if (!ToggleSwitch.Checked)
					{
						if (!ToggleSwitch.OffButtonScaleImageToFit)
						{
							goto IL_55F;
						}
					}
					else if (!ToggleSwitch.OnButtonScaleImageToFit)
					{
						goto IL_55F;
					}
				}
				else if (!ToggleSwitch.ButtonScaleImageToFit)
				{
					goto IL_55F;
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
				Rectangle rectangle3 = new Rectangle(num, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size3.Height) / 2f), size3.Width, size3.Height);
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					graphics_0.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
					goto IL_62D;
				}
				graphics_0.DrawImage(image, rectangle3);
				goto IL_62D;
				IL_55F:
				if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
				{
					num = (int)(buttonRectangle.X + (buttonRectangle.Width - (float)size.Width) / 2f);
				}
				else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
				{
					num = (int)(buttonRectangle.X + (float)buttonRectangle.Width - size.Width);
				}
				rectangle3 = new Rectangle(num, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size.Height) / 2f), size.Width, size.Height);
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					graphics_0.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
				}
				else
				{
					graphics_0.DrawImageUnscaled(image, rectangle3);
				}
				IL_62D:
				graphics_0.ResetClip();
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		public GraphicsPath GetControlClipPath(Rectangle controlRectangle)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(controlRectangle.X, controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 90f, 180f);
			graphicsPath.AddArc(controlRectangle.X + controlRectangle.Width - controlRectangle.Height, controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00016F34 File Offset: 0x00015134
		public GraphicsPath GetButtonClipPath()
		{
			Rectangle buttonRectangle = GetButtonRectangle();
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(buttonRectangle.X, buttonRectangle.Y, buttonRectangle.Height, buttonRectangle.Height, 0f, 360f);
			return graphicsPath;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00016F80 File Offset: 0x00015180
		public override int GetButtonWidth()
		{
			return ToggleSwitch.Height - 2;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00016F9C File Offset: 0x0001519C
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 1, buttonWidth, buttonWidth);
			return rectangle;
		}

		// Token: 0x040001D7 RID: 471
		[CompilerGenerated]
		private System.Drawing.Color <BorderColor>k__BackingField;

		// Token: 0x040001D8 RID: 472
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideUpperColor1>k__BackingField;

		// Token: 0x040001D9 RID: 473
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideUpperColor2>k__BackingField;

		// Token: 0x040001DA RID: 474
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideLowerColor1>k__BackingField;

		// Token: 0x040001DB RID: 475
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideLowerColor2>k__BackingField;

		// Token: 0x040001DC RID: 476
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideUpperBorderColor>k__BackingField;

		// Token: 0x040001DD RID: 477
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideLowerBorderColor>k__BackingField;

		// Token: 0x040001DE RID: 478
		[CompilerGenerated]
		private System.Drawing.Color <RightSideUpperColor1>k__BackingField;

		// Token: 0x040001DF RID: 479
		[CompilerGenerated]
		private System.Drawing.Color <RightSideUpperColor2>k__BackingField;

		// Token: 0x040001E0 RID: 480
		[CompilerGenerated]
		private System.Drawing.Color <RightSideLowerColor1>k__BackingField;

		// Token: 0x040001E1 RID: 481
		[CompilerGenerated]
		private System.Drawing.Color <RightSideLowerColor2>k__BackingField;

		// Token: 0x040001E2 RID: 482
		[CompilerGenerated]
		private System.Drawing.Color <RightSideUpperBorderColor>k__BackingField;

		// Token: 0x040001E3 RID: 483
		[CompilerGenerated]
		private System.Drawing.Color <RightSideLowerBorderColor>k__BackingField;

		// Token: 0x040001E4 RID: 484
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor>k__BackingField;

		// Token: 0x040001E5 RID: 485
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalOuterBorderColor>k__BackingField;

		// Token: 0x040001E6 RID: 486
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalInnerBorderColor>k__BackingField;

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor1>k__BackingField;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalSurfaceColor2>k__BackingField;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverOuterBorderColor>k__BackingField;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverInnerBorderColor>k__BackingField;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor1>k__BackingField;

		// Token: 0x040001EC RID: 492
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverSurfaceColor2>k__BackingField;

		// Token: 0x040001ED RID: 493
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedOuterBorderColor>k__BackingField;

		// Token: 0x040001EE RID: 494
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedInnerBorderColor>k__BackingField;

		// Token: 0x040001EF RID: 495
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor1>k__BackingField;

		// Token: 0x040001F0 RID: 496
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedSurfaceColor2>k__BackingField;
	}
}
