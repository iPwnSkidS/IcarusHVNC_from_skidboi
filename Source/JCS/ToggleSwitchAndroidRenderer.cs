using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000041 RID: 65
	public class ToggleSwitchAndroidRenderer : ToggleSwitchRendererBase
	{
		// Token: 0x06000272 RID: 626 RVA: 0x000151D4 File Offset: 0x000133D4
		public ToggleSwitchAndroidRenderer()
		{
			BorderColor = Color.FromArgb(255, 166, 166, 166);
			BackColor = Color.FromArgb(255, 32, 32, 32);
			LeftSideColor = Color.FromArgb(255, 32, 32, 32);
			RightSideColor = Color.FromArgb(255, 32, 32, 32);
			OffButtonColor = Color.FromArgb(255, 70, 70, 70);
			OnButtonColor = Color.FromArgb(255, 27, 161, 226);
			OffButtonBorderColor = Color.FromArgb(255, 70, 70, 70);
			OnButtonBorderColor = Color.FromArgb(255, 27, 161, 226);
			SlantAngle = 8;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000078E9 File Offset: 0x00005AE9
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000078F1 File Offset: 0x00005AF1
		public Color BorderColor
		{
			[CompilerGenerated]
			get
			{
				return <BorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BorderColor>k__BackingField = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000078FA File Offset: 0x00005AFA
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00007902 File Offset: 0x00005B02
		public Color BackColor
		{
			[CompilerGenerated]
			get
			{
				return <BackColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BackColor>k__BackingField = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000790B File Offset: 0x00005B0B
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00007913 File Offset: 0x00005B13
		public Color LeftSideColor
		{
			[CompilerGenerated]
			get
			{
				return <LeftSideColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LeftSideColor>k__BackingField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000791C File Offset: 0x00005B1C
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00007924 File Offset: 0x00005B24
		public Color RightSideColor
		{
			[CompilerGenerated]
			get
			{
				return <RightSideColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RightSideColor>k__BackingField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000792D File Offset: 0x00005B2D
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00007935 File Offset: 0x00005B35
		public Color OffButtonColor
		{
			[CompilerGenerated]
			get
			{
				return <OffButtonColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OffButtonColor>k__BackingField = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000793E File Offset: 0x00005B3E
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00007946 File Offset: 0x00005B46
		public Color OnButtonColor
		{
			[CompilerGenerated]
			get
			{
				return <OnButtonColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnButtonColor>k__BackingField = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000794F File Offset: 0x00005B4F
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00007957 File Offset: 0x00005B57
		public Color OffButtonBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <OffButtonBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OffButtonBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00007960 File Offset: 0x00005B60
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00007968 File Offset: 0x00005B68
		public Color OnButtonBorderColor
		{
			[CompilerGenerated]
			get
			{
				return <OnButtonBorderColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnButtonBorderColor>k__BackingField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00007971 File Offset: 0x00005B71
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00007979 File Offset: 0x00005B79
		public int SlantAngle
		{
			[CompilerGenerated]
			get
			{
				return <SlantAngle>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SlantAngle>k__BackingField = value;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000152B4 File Offset: 0x000134B4
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
			Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? BorderColor : BorderColor.ToGrayScale());
			graphics_0.SetClip(borderRectangle);
			using (Pen pen = new Pen(color))
			{
				graphics_0.DrawRectangle(pen, borderRectangle.X, borderRectangle.Y, borderRectangle.Width - 1, borderRectangle.Height - 1);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00015340 File Offset: 0x00013540
		public override void RenderLeftToggleField(Graphics graphics_0, Rectangle leftRectangle, int totalToggleFieldWidth)
		{
			Color color = LeftSideColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
			}
			Rectangle innerControlRectangle = GetInnerControlRectangle();
			graphics_0.SetClip(innerControlRectangle);
			int halfCathetusLengthBasedOnAngle = GetHalfCathetusLengthBasedOnAngle();
			Rectangle rectangle = new Rectangle(leftRectangle.X, leftRectangle.Y, leftRectangle.Width + halfCathetusLengthBasedOnAngle, leftRectangle.Height);
			graphics_0.IntersectClip(rectangle);
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(brush, rectangle);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000153EC File Offset: 0x000135EC
		public override void RenderRightToggleField(Graphics graphics_0, Rectangle rightRectangle, int totalToggleFieldWidth)
		{
			Color color = RightSideColor;
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
			}
			Rectangle innerControlRectangle = GetInnerControlRectangle();
			graphics_0.SetClip(innerControlRectangle);
			int halfCathetusLengthBasedOnAngle = GetHalfCathetusLengthBasedOnAngle();
			Rectangle rectangle = new Rectangle(rightRectangle.X - halfCathetusLengthBasedOnAngle, rightRectangle.Y, rightRectangle.Width + halfCathetusLengthBasedOnAngle, rightRectangle.Height);
			graphics_0.IntersectClip(rectangle);
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(brush, rectangle);
			}
			graphics_0.ResetClip();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001549C File Offset: 0x0001369C
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			Rectangle innerControlRectangle = GetInnerControlRectangle();
			graphics_0.SetClip(innerControlRectangle);
			int cathetusLengthBasedOnAngle = GetCathetusLengthBasedOnAngle();
			int num = 2 * cathetusLengthBasedOnAngle;
			Point[] array = new Point[4];
			Rectangle rectangle = new Rectangle(buttonRectangle.X - cathetusLengthBasedOnAngle, innerControlRectangle.Y, buttonRectangle.Width + num, innerControlRectangle.Height);
			if (SlantAngle > 0)
			{
				array[0] = new Point(rectangle.X + cathetusLengthBasedOnAngle, rectangle.Y);
				array[1] = new Point(rectangle.X + rectangle.Width - 1, rectangle.Y);
				array[2] = new Point(rectangle.X + rectangle.Width - cathetusLengthBasedOnAngle - 1, rectangle.Y + rectangle.Height - 1);
				array[3] = new Point(rectangle.X, rectangle.Y + rectangle.Height - 1);
			}
			else
			{
				array[0] = new Point(rectangle.X, rectangle.Y);
				array[1] = new Point(rectangle.X + rectangle.Width - cathetusLengthBasedOnAngle - 1, rectangle.Y);
				array[2] = new Point(rectangle.X + rectangle.Width - 1, rectangle.Y + rectangle.Height - 1);
				array[3] = new Point(rectangle.X + cathetusLengthBasedOnAngle, rectangle.Y + rectangle.Height - 1);
			}
			graphics_0.IntersectClip(rectangle);
			Color color = (ToggleSwitch.Checked ? OnButtonColor : OffButtonColor);
			Color color2 = (ToggleSwitch.Checked ? OnButtonBorderColor : OffButtonBorderColor);
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
				color2 = color2.ToGrayScale();
			}
			using (Pen pen = new Pen(color2))
			{
				graphics_0.DrawPolygon(pen, array);
			}
			using (Brush brush = new SolidBrush(color))
			{
				graphics_0.FillPolygon(brush, array);
			}
			Image image = ToggleSwitch.ButtonImage ?? (ToggleSwitch.Checked ? ToggleSwitch.OnButtonImage : ToggleSwitch.OffButtonImage);
			string text = (ToggleSwitch.Checked ? ToggleSwitch.OnText : ToggleSwitch.OffText);
			if (image != null || !string.IsNullOrEmpty(text))
			{
				ToggleSwitch.ToggleSwitchButtonAlignment toggleSwitchButtonAlignment = ((ToggleSwitch.ButtonImage != null) ? ToggleSwitch.ButtonAlignment : (ToggleSwitch.Checked ? ToggleSwitch.OnButtonAlignment : ToggleSwitch.OffButtonAlignment));
				if (image != null)
				{
					Size size = image.Size;
					int num2 = rectangle.X;
					if (ToggleSwitch.ButtonImage == null)
					{
						if (!ToggleSwitch.Checked)
						{
							if (!ToggleSwitch.OffButtonScaleImageToFit)
							{
								goto IL_435;
							}
						}
						else if (!ToggleSwitch.OnButtonScaleImageToFit)
						{
							goto IL_435;
						}
					}
					else if (!ToggleSwitch.ButtonScaleImageToFit)
					{
						goto IL_435;
					}
					Size size2 = rectangle.Size;
					Size size3 = ImageHelper.RescaleImageToFit(size, size2);
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num2 = (int)(rectangle.X + (rectangle.Width - (float)size3.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num2 = (int)(rectangle.X + (float)rectangle.Width - size3.Width);
					}
					Rectangle rectangle2 = new Rectangle(num2, (int)(rectangle.Y + (rectangle.Height - (float)size3.Height) / 2f), size3.Width, size3.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle2, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						goto IL_64B;
					}
					graphics_0.DrawImage(image, rectangle2);
					goto IL_64B;
					IL_435:
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num2 = (int)(rectangle.X + (rectangle.Width - (float)size.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num2 = (int)(rectangle.X + (float)rectangle.Width - size.Width);
					}
					rectangle2 = new Rectangle(num2, (int)(rectangle.Y + (rectangle.Height - (float)size.Height) / 2f), size.Width, size.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle2, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
					}
					else
					{
						graphics_0.DrawImageUnscaled(image, rectangle2);
					}
				}
				else if (!string.IsNullOrEmpty(text))
				{
					Font font = (ToggleSwitch.Checked ? ToggleSwitch.OnFont : ToggleSwitch.OffFont);
					Color color3 = (ToggleSwitch.Checked ? ToggleSwitch.OnForeColor : ToggleSwitch.OffForeColor);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						color3 = color3.ToGrayScale();
					}
					SizeF sizeF = graphics_0.MeasureString(text, font);
					float num3 = rectangle.X;
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num3 = rectangle.X + (rectangle.Width - sizeF.Width) / 2f;
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num3 = rectangle.X + (float)rectangle.Width - sizeF.Width;
					}
					RectangleF rectangleF = new RectangleF(num3, rectangle.Y + (rectangle.Height - sizeF.Height) / 2f, sizeF.Width, sizeF.Height);
					using (Brush brush2 = new SolidBrush(color3))
					{
						graphics_0.DrawString(text, font, brush2, rectangleF);
					}
				}
			}
			IL_64B:
			graphics_0.ResetClip();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00015B24 File Offset: 0x00013D24
		public Rectangle GetInnerControlRectangle()
		{
			return new Rectangle(1, 1, ToggleSwitch.Width - 2, ToggleSwitch.Height - 2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00015B54 File Offset: 0x00013D54
		public int GetCathetusLengthBasedOnAngle()
		{
			int num;
			if (SlantAngle == 0)
			{
				num = 0;
			}
			else
			{
				double num2 = Math.Abs(SlantAngle);
				double num3 = num2 * 0.017453292519943295;
				double num4 = Math.Tan(num3) * ToggleSwitch.Height;
				num = (int)num4;
			}
			return num;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00015BA4 File Offset: 0x00013DA4
		public int GetHalfCathetusLengthBasedOnAngle()
		{
			int num;
			if (SlantAngle == 0)
			{
				num = 0;
			}
			else
			{
				double num2 = Math.Abs(SlantAngle);
				double num3 = num2 * 0.017453292519943295;
				double num4 = Math.Tan(num3) * ToggleSwitch.Height / 2.0;
				num = (int)num4;
			}
			return num;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00015BFC File Offset: 0x00013DFC
		public override int GetButtonWidth()
		{
			double num = ToggleSwitch.Width / 2.0;
			return (int)num;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x0400018A RID: 394
		[CompilerGenerated]
		private System.Drawing.Color <BorderColor>k__BackingField;

		// Token: 0x0400018B RID: 395
		[CompilerGenerated]
		private System.Drawing.Color <BackColor>k__BackingField;

		// Token: 0x0400018C RID: 396
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideColor>k__BackingField;

		// Token: 0x0400018D RID: 397
		[CompilerGenerated]
		private System.Drawing.Color <RightSideColor>k__BackingField;

		// Token: 0x0400018E RID: 398
		[CompilerGenerated]
		private System.Drawing.Color <OffButtonColor>k__BackingField;

		// Token: 0x0400018F RID: 399
		[CompilerGenerated]
		private System.Drawing.Color <OnButtonColor>k__BackingField;

		// Token: 0x04000190 RID: 400
		[CompilerGenerated]
		private System.Drawing.Color <OffButtonBorderColor>k__BackingField;

		// Token: 0x04000191 RID: 401
		[CompilerGenerated]
		private System.Drawing.Color <OnButtonBorderColor>k__BackingField;

		// Token: 0x04000192 RID: 402
		[CompilerGenerated]
		private int <SlantAngle>k__BackingField;
	}
}
