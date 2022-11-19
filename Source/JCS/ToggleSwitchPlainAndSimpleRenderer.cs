using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace BirdBrainmofo.JCS
{
	// Token: 0x0200004A RID: 74
	public class ToggleSwitchPlainAndSimpleRenderer : ToggleSwitchRendererBase
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00020788 File Offset: 0x0001E988
		public ToggleSwitchPlainAndSimpleRenderer()
		{
			BorderColorChecked = Color.Black;
			BorderColorUnchecked = Color.Black;
			BorderWidth = 2;
			ButtonMargin = 1;
			InnerBackgroundColor = Color.White;
			ButtonColor = Color.Black;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00008599 File Offset: 0x00006799
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x000085A1 File Offset: 0x000067A1
		public Color BorderColorChecked
		{
			[CompilerGenerated]
			get
			{
				return <BorderColorChecked>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColorChecked>k__BackingField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000085AA File Offset: 0x000067AA
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000085B2 File Offset: 0x000067B2
		public Color BorderColorUnchecked
		{
			[CompilerGenerated]
			get
			{
				return <BorderColorUnchecked>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColorUnchecked>k__BackingField = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000085BB File Offset: 0x000067BB
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000085C3 File Offset: 0x000067C3
		public int BorderWidth
		{
			[CompilerGenerated]
			get
			{
				return <BorderWidth>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderWidth>k__BackingField = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x000085CC File Offset: 0x000067CC
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000085D4 File Offset: 0x000067D4
		public int ButtonMargin
		{
			[CompilerGenerated]
			get
			{
				return <ButtonMargin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonMargin>k__BackingField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000085DD File Offset: 0x000067DD
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000085E5 File Offset: 0x000067E5
		public Color InnerBackgroundColor
		{
			[CompilerGenerated]
			get
			{
				return <InnerBackgroundColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InnerBackgroundColor>k__BackingField = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000085EE File Offset: 0x000067EE
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000085F6 File Offset: 0x000067F6
		public Color ButtonColor
		{
			[CompilerGenerated]
			get
			{
				return <ButtonColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonColor>k__BackingField = value;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000063EF File Offset: 0x000045EF
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000207D8 File Offset: 0x0001E9D8
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			GetButtonWidth();
			Rectangle rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			GraphicsPath innerBorderClipPath = GetInnerBorderClipPath(rectangle);
			graphics_0.SetClip(innerBorderClipPath);
			graphics_0.IntersectClip(leftRectangle);
			using (Brush brush = new SolidBrush(InnerBackgroundColor))
			{
				graphics_0.FillPath(brush, innerBorderClipPath);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000207D8 File Offset: 0x0001E9D8
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			GetButtonWidth();
			Rectangle rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			GraphicsPath innerBorderClipPath = GetInnerBorderClipPath(rectangle);
			graphics_0.SetClip(innerBorderClipPath);
			graphics_0.IntersectClip(rightRectangle);
			using (Brush brush = new SolidBrush(InnerBackgroundColor))
			{
				graphics_0.FillPath(brush, innerBorderClipPath);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00020868 File Offset: 0x0001EA68
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			GraphicsPath buttonClipPath = GetButtonClipPath();
			Rectangle rectangle = new Rectangle(0, 0, ToggleSwitch.Width, ToggleSwitch.Height);
			GraphicsPath controlClipPath = GetControlClipPath(rectangle);
			GraphicsPath innerBorderClipPath = GetInnerBorderClipPath(rectangle);
			graphics_0.SetClip(innerBorderClipPath);
			graphics_0.IntersectClip(buttonRectangle);
			using (Brush brush = new SolidBrush(InnerBackgroundColor))
			{
				graphics_0.FillRectangle(brush, buttonRectangle);
			}
			graphics_0.ResetClip();
			graphics_0.SetClip(GetButtonClipPath());
			graphics_0.IntersectClip(rectangle);
			using (Brush brush2 = new SolidBrush(ButtonColor))
			{
				graphics_0.FillPath(brush2, buttonClipPath);
			}
			graphics_0.ResetClip();
			graphics_0.SetClip(controlClipPath);
			graphics_0.ExcludeClip(new Region(innerBorderClipPath));
			Color color = (ToggleSwitch.Checked ? BorderColorChecked : BorderColorUnchecked);
			using (Brush brush3 = new SolidBrush(color))
			{
				graphics_0.FillPath(brush3, controlClipPath);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		public GraphicsPath GetControlClipPath(Rectangle controlRectangle)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(controlRectangle.X, controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 90f, 180f);
			graphicsPath.AddArc(controlRectangle.X + controlRectangle.Width - controlRectangle.Height, controlRectangle.Y, controlRectangle.Height, controlRectangle.Height, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000209AC File Offset: 0x0001EBAC
		public GraphicsPath GetInnerBorderClipPath(Rectangle controlRectangle)
		{
			Rectangle rectangle = new Rectangle(controlRectangle.X + BorderWidth, controlRectangle.Y + BorderWidth, controlRectangle.Width - 2 * BorderWidth, controlRectangle.Height - 2 * BorderWidth);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Height, 90f, 180f);
			graphicsPath.AddArc(rectangle.X + rectangle.Width - rectangle.Height, rectangle.Y, rectangle.Height, rectangle.Height, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00020A74 File Offset: 0x0001EC74
		public GraphicsPath GetButtonClipPath()
		{
			Rectangle buttonRectangle = GetButtonRectangle();
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddArc(buttonRectangle.X + ButtonMargin, buttonRectangle.Y + ButtonMargin, buttonRectangle.Height - 2 * ButtonMargin, buttonRectangle.Height - 2 * ButtonMargin, 0f, 360f);
			return graphicsPath;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		public override int GetButtonWidth()
		{
			int num = ToggleSwitch.Height - 2 * BorderWidth;
			return (num > 0) ? num : 0;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00020B0C File Offset: 0x0001ED0C
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle;
			if (buttonWidth <= 0)
			{
				rectangle = Rectangle.Empty;
			}
			else
			{
				Rectangle rectangle2 = new Rectangle(ToggleSwitch.ButtonValue, BorderWidth, buttonWidth, buttonWidth);
				if (rectangle2.X < BorderWidth + ButtonMargin - 1)
				{
					rectangle2.X = BorderWidth + ButtonMargin - 1;
				}
				if (rectangle2.X + rectangle2.Width > ToggleSwitch.Width - BorderWidth - ButtonMargin + 1)
				{
					rectangle2.X = ToggleSwitch.Width - rectangle2.Width - BorderWidth - ButtonMargin + 1;
				}
				rectangle = rectangle2;
			}
			return rectangle;
		}

		// Token: 0x04000247 RID: 583
		[CompilerGenerated]
		private System.Drawing.Color <BorderColorChecked>k__BackingField;

		// Token: 0x04000248 RID: 584
		[CompilerGenerated]
		private System.Drawing.Color <BorderColorUnchecked>k__BackingField;

		// Token: 0x04000249 RID: 585
		[CompilerGenerated]
		private int <BorderWidth>k__BackingField;

		// Token: 0x0400024A RID: 586
		[CompilerGenerated]
		private int <ButtonMargin>k__BackingField;

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private System.Drawing.Color <InnerBackgroundColor>k__BackingField;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private System.Drawing.Color <ButtonColor>k__BackingField;
	}
}
