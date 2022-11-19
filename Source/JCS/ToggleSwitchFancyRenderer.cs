using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using BirdBrainmofo.ToggleSwitch;

namespace BirdBrainmofo.JCS
{
	// Token: 0x02000044 RID: 68
	public class ToggleSwitchFancyRenderer : ToggleSwitchRendererBase, IDisposable
	{
		// Token: 0x060002EC RID: 748 RVA: 0x0001877C File Offset: 0x0001697C
		public ToggleSwitchFancyRenderer()
		{
			OuterBorderColor1 = Color.FromArgb(255, 197, 199, 201);
			OuterBorderColor2 = Color.FromArgb(255, 207, 209, 212);
			InnerBorderColor1 = Color.FromArgb(200, 205, 208, 207);
			InnerBorderColor2 = Color.FromArgb(255, 207, 209, 212);
			LeftSideBackColor1 = Color.FromArgb(255, 61, 110, 6);
			LeftSideBackColor2 = Color.FromArgb(255, 93, 170, 9);
			RightSideBackColor1 = Color.FromArgb(255, 149, 0, 0);
			RightSideBackColor2 = Color.FromArgb(255, 198, 0, 0);
			ButtonNormalBorderColor1 = Color.FromArgb(255, 212, 209, 211);
			ButtonNormalBorderColor2 = Color.FromArgb(255, 197, 199, 201);
			ButtonNormalUpperSurfaceColor1 = Color.FromArgb(255, 252, 251, 252);
			ButtonNormalUpperSurfaceColor2 = Color.FromArgb(255, 247, 247, 247);
			ButtonNormalLowerSurfaceColor1 = Color.FromArgb(255, 233, 233, 233);
			ButtonNormalLowerSurfaceColor2 = Color.FromArgb(255, 225, 225, 225);
			ButtonHoverBorderColor1 = Color.FromArgb(255, 212, 207, 209);
			ButtonHoverBorderColor2 = Color.FromArgb(255, 223, 223, 223);
			ButtonHoverUpperSurfaceColor1 = Color.FromArgb(255, 240, 239, 240);
			ButtonHoverUpperSurfaceColor2 = Color.FromArgb(255, 235, 235, 235);
			ButtonHoverLowerSurfaceColor1 = Color.FromArgb(255, 221, 221, 221);
			ButtonHoverLowerSurfaceColor2 = Color.FromArgb(255, 214, 214, 214);
			ButtonPressedBorderColor1 = Color.FromArgb(255, 176, 176, 176);
			ButtonPressedBorderColor2 = Color.FromArgb(255, 176, 176, 176);
			ButtonPressedUpperSurfaceColor1 = Color.FromArgb(255, 189, 188, 189);
			ButtonPressedUpperSurfaceColor2 = Color.FromArgb(255, 185, 185, 185);
			ButtonPressedLowerSurfaceColor1 = Color.FromArgb(255, 175, 175, 175);
			ButtonPressedLowerSurfaceColor2 = Color.FromArgb(255, 169, 169, 169);
			ButtonShadowColor1 = Color.FromArgb(50, 0, 0, 0);
			ButtonShadowColor2 = Color.FromArgb(0, 0, 0, 0);
			ButtonShadowWidth = 7;
			CornerRadius = 6;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00007BFE File Offset: 0x00005DFE
		public void Dispose()
		{
			if (_innerControlPath != null)
			{
				_innerControlPath.Dispose();
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00007C16 File Offset: 0x00005E16
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00007C1E File Offset: 0x00005E1E
		public Color OuterBorderColor1
		{
			[CompilerGenerated]
			get
			{
				return <OuterBorderColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OuterBorderColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00007C27 File Offset: 0x00005E27
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00007C2F File Offset: 0x00005E2F
		public Color OuterBorderColor2
		{
			[CompilerGenerated]
			get
			{
				return <OuterBorderColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OuterBorderColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00007C38 File Offset: 0x00005E38
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00007C40 File Offset: 0x00005E40
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00007C49 File Offset: 0x00005E49
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00007C51 File Offset: 0x00005E51
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00007C5A File Offset: 0x00005E5A
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00007C62 File Offset: 0x00005E62
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00007C6B File Offset: 0x00005E6B
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00007C73 File Offset: 0x00005E73
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00007C7C File Offset: 0x00005E7C
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00007C84 File Offset: 0x00005E84
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00007C8D File Offset: 0x00005E8D
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00007C95 File Offset: 0x00005E95
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00007C9E File Offset: 0x00005E9E
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00007CA6 File Offset: 0x00005EA6
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00007CAF File Offset: 0x00005EAF
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00007CB7 File Offset: 0x00005EB7
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00007CC0 File Offset: 0x00005EC0
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public Color ButtonNormalUpperSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalUpperSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalUpperSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00007CD1 File Offset: 0x00005ED1
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00007CD9 File Offset: 0x00005ED9
		public Color ButtonNormalUpperSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalUpperSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalUpperSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00007CE2 File Offset: 0x00005EE2
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00007CEA File Offset: 0x00005EEA
		public Color ButtonNormalLowerSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalLowerSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalLowerSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00007CF3 File Offset: 0x00005EF3
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00007CFB File Offset: 0x00005EFB
		public Color ButtonNormalLowerSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonNormalLowerSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonNormalLowerSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00007D04 File Offset: 0x00005F04
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00007D0C File Offset: 0x00005F0C
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00007D15 File Offset: 0x00005F15
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00007D1D File Offset: 0x00005F1D
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00007D26 File Offset: 0x00005F26
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00007D2E File Offset: 0x00005F2E
		public Color ButtonHoverUpperSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverUpperSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverUpperSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00007D37 File Offset: 0x00005F37
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00007D3F File Offset: 0x00005F3F
		public Color ButtonHoverUpperSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverUpperSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverUpperSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00007D48 File Offset: 0x00005F48
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00007D50 File Offset: 0x00005F50
		public Color ButtonHoverLowerSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverLowerSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverLowerSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00007D59 File Offset: 0x00005F59
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00007D61 File Offset: 0x00005F61
		public Color ButtonHoverLowerSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonHoverLowerSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonHoverLowerSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00007D6A File Offset: 0x00005F6A
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00007D72 File Offset: 0x00005F72
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00007D7B File Offset: 0x00005F7B
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00007D83 File Offset: 0x00005F83
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00007D8C File Offset: 0x00005F8C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00007D94 File Offset: 0x00005F94
		public Color ButtonPressedUpperSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedUpperSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedUpperSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00007D9D File Offset: 0x00005F9D
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00007DA5 File Offset: 0x00005FA5
		public Color ButtonPressedUpperSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedUpperSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedUpperSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00007DAE File Offset: 0x00005FAE
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00007DB6 File Offset: 0x00005FB6
		public Color ButtonPressedLowerSurfaceColor1
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedLowerSurfaceColor1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedLowerSurfaceColor1>k__BackingField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00007DBF File Offset: 0x00005FBF
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00007DC7 File Offset: 0x00005FC7
		public Color ButtonPressedLowerSurfaceColor2
		{
			[CompilerGenerated]
			get
			{
				return <ButtonPressedLowerSurfaceColor2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ButtonPressedLowerSurfaceColor2>k__BackingField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00007DD0 File Offset: 0x00005FD0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00007DD8 File Offset: 0x00005FD8
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00007DE1 File Offset: 0x00005FE1
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00007DE9 File Offset: 0x00005FE9
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00007DF2 File Offset: 0x00005FF2
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00007DFA File Offset: 0x00005FFA
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00007E03 File Offset: 0x00006003
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00007E0B File Offset: 0x0000600B
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

		// Token: 0x0600032A RID: 810 RVA: 0x00018ACC File Offset: 0x00016CCC
		public override void RenderBorder(Graphics graphics_0, Rectangle borderRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(borderRectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath);
				Color color = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? OuterBorderColor1 : OuterBorderColor1.ToGrayScale());
				Color color2 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? OuterBorderColor2 : OuterBorderColor2.ToGrayScale());
				using (Brush brush = new LinearGradientBrush(borderRectangle, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, roundedRectanglePath);
				}
				graphics_0.ResetClip();
			}
			Rectangle rectangle = new Rectangle(borderRectangle.X + 1, borderRectangle.Y + 1, borderRectangle.Width - 2, borderRectangle.Height - 2);
			using (GraphicsPath roundedRectanglePath2 = GetRoundedRectanglePath(rectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath2);
				Color color3 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? InnerBorderColor1 : InnerBorderColor1.ToGrayScale());
				Color color4 = ((ToggleSwitch.Enabled || !ToggleSwitch.GrayWhenDisabled) ? InnerBorderColor2 : InnerBorderColor2.ToGrayScale());
				using (Brush brush2 = new LinearGradientBrush(borderRectangle, color3, color4, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush2, roundedRectanglePath2);
				}
				graphics_0.ResetClip();
			}
			Rectangle rectangle2 = new Rectangle(borderRectangle.X + 2, borderRectangle.Y + 2, borderRectangle.Width - 4, borderRectangle.Height - 4);
			_innerControlPath = GetRoundedRectanglePath(rectangle2, CornerRadius);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00018CE0 File Offset: 0x00016EE0
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

		// Token: 0x0600032C RID: 812 RVA: 0x000192F8 File Offset: 0x000174F8
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

		// Token: 0x0600032D RID: 813 RVA: 0x00019900 File Offset: 0x00017B00
		public override void RenderButton(Graphics graphics_0, Rectangle buttonRectangle)
		{
			graphics_0.SmoothingMode = SmoothingMode.HighQuality;
			graphics_0.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics_0.InterpolationMode = InterpolationMode.HighQualityBilinear;
			Color color = ButtonNormalUpperSurfaceColor1;
			Color color2 = ButtonNormalUpperSurfaceColor2;
			Color color3 = ButtonNormalLowerSurfaceColor1;
			Color color4 = ButtonNormalLowerSurfaceColor2;
			if (ToggleSwitch.IsButtonPressed)
			{
				color = ButtonPressedUpperSurfaceColor1;
				color2 = ButtonPressedUpperSurfaceColor2;
				color3 = ButtonPressedLowerSurfaceColor1;
				color4 = ButtonPressedLowerSurfaceColor2;
			}
			else if (ToggleSwitch.IsButtonHovered)
			{
				color = ButtonHoverUpperSurfaceColor1;
				color2 = ButtonHoverUpperSurfaceColor2;
				color3 = ButtonHoverLowerSurfaceColor1;
				color4 = ButtonHoverLowerSurfaceColor2;
			}
			if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
			{
				color = color.ToGrayScale();
				color2 = color2.ToGrayScale();
				color3 = color3.ToGrayScale();
				color4 = color4.ToGrayScale();
			}
			buttonRectangle.Inflate(-1, -1);
			int num = buttonRectangle.Height / 2;
			Rectangle rectangle = new Rectangle(buttonRectangle.X, buttonRectangle.Y, buttonRectangle.Width, num);
			Rectangle rectangle2 = new Rectangle(buttonRectangle.X, buttonRectangle.Y + num, buttonRectangle.Width, buttonRectangle.Height - num);
			using (GraphicsPath roundedRectanglePath = GetRoundedRectanglePath(buttonRectangle, CornerRadius))
			{
				graphics_0.SetClip(roundedRectanglePath);
				graphics_0.IntersectClip(rectangle);
				using (Brush brush = new LinearGradientBrush(buttonRectangle, color, color2, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush, roundedRectanglePath);
				}
				graphics_0.ResetClip();
				graphics_0.SetClip(roundedRectanglePath);
				graphics_0.IntersectClip(rectangle2);
				using (Brush brush2 = new LinearGradientBrush(buttonRectangle, color3, color4, LinearGradientMode.Vertical))
				{
					graphics_0.FillPath(brush2, roundedRectanglePath);
				}
				graphics_0.ResetClip();
				graphics_0.SetClip(roundedRectanglePath);
				Color color5 = ButtonNormalBorderColor1;
				Color color6 = ButtonNormalBorderColor2;
				if (ToggleSwitch.IsButtonPressed)
				{
					color5 = ButtonPressedBorderColor1;
					color6 = ButtonPressedBorderColor2;
				}
				else if (ToggleSwitch.IsButtonHovered)
				{
					color5 = ButtonHoverBorderColor1;
					color6 = ButtonHoverBorderColor2;
				}
				if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
				{
					color5 = color5.ToGrayScale();
					color6 = color6.ToGrayScale();
				}
				using (Brush brush3 = new LinearGradientBrush(buttonRectangle, color5, color6, LinearGradientMode.Vertical))
				{
					using (Pen pen = new Pen(brush3))
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
					int num2 = buttonRectangle.X;
					if (ToggleSwitch.ButtonImage == null)
					{
						if (!ToggleSwitch.Checked)
						{
							if (!ToggleSwitch.OffButtonScaleImageToFit)
							{
								goto IL_42C;
							}
						}
						else if (!ToggleSwitch.OnButtonScaleImageToFit)
						{
							goto IL_42C;
						}
					}
					else if (!ToggleSwitch.ButtonScaleImageToFit)
					{
						goto IL_42C;
					}
					Size size2 = buttonRectangle.Size;
					Size size3 = ImageHelper.RescaleImageToFit(size, size2);
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num2 = (int)(buttonRectangle.X + (buttonRectangle.Width - (float)size3.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num2 = (int)(buttonRectangle.X + (float)buttonRectangle.Width - size3.Width);
					}
					Rectangle rectangle3 = new Rectangle(num2, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size3.Height) / 2f), size3.Width, size3.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
						goto IL_4FA;
					}
					graphics_0.DrawImage(image, rectangle3);
					goto IL_4FA;
					IL_42C:
					if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Center)
					{
						num2 = (int)(buttonRectangle.X + (buttonRectangle.Width - (float)size.Width) / 2f);
					}
					else if (toggleSwitchButtonAlignment == ToggleSwitch.ToggleSwitchButtonAlignment.Right)
					{
						num2 = (int)(buttonRectangle.X + (float)buttonRectangle.Width - size.Width);
					}
					rectangle3 = new Rectangle(num2, (int)(buttonRectangle.Y + (buttonRectangle.Height - (float)size.Height) / 2f), size.Width, size.Height);
					if (!ToggleSwitch.Enabled && ToggleSwitch.GrayWhenDisabled)
					{
						graphics_0.DrawImage(image, rectangle3, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ImageHelper.GetGrayscaleAttributes());
					}
					else
					{
						graphics_0.DrawImageUnscaled(image, rectangle3);
					}
					IL_4FA:
					graphics_0.ResetClip();
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00018654 File Offset: 0x00016854
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

		// Token: 0x0600032F RID: 815 RVA: 0x00019E98 File Offset: 0x00018098
		public override int GetButtonWidth()
		{
			float num = 1.61f * ToggleSwitch.Height;
			return (int)num;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00015C24 File Offset: 0x00013E24
		public override Rectangle GetButtonRectangle()
		{
			int buttonWidth = GetButtonWidth();
			return GetButtonRectangle(buttonWidth);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00015C44 File Offset: 0x00013E44
		public override Rectangle GetButtonRectangle(int buttonWidth)
		{
			Rectangle rectangle = new Rectangle(ToggleSwitch.ButtonValue, 0, buttonWidth, ToggleSwitch.Height);
			return rectangle;
		}

		// Token: 0x040001B8 RID: 440
		private GraphicsPath _innerControlPath;

		// Token: 0x040001B9 RID: 441
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor1>k__BackingField;

		// Token: 0x040001BA RID: 442
		[CompilerGenerated]
		private System.Drawing.Color <OuterBorderColor2>k__BackingField;

		// Token: 0x040001BB RID: 443
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor1>k__BackingField;

		// Token: 0x040001BC RID: 444
		[CompilerGenerated]
		private System.Drawing.Color <InnerBorderColor2>k__BackingField;

		// Token: 0x040001BD RID: 445
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor1>k__BackingField;

		// Token: 0x040001BE RID: 446
		[CompilerGenerated]
		private System.Drawing.Color <LeftSideBackColor2>k__BackingField;

		// Token: 0x040001BF RID: 447
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor1>k__BackingField;

		// Token: 0x040001C0 RID: 448
		[CompilerGenerated]
		private System.Drawing.Color <RightSideBackColor2>k__BackingField;

		// Token: 0x040001C1 RID: 449
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor1>k__BackingField;

		// Token: 0x040001C2 RID: 450
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalBorderColor2>k__BackingField;

		// Token: 0x040001C3 RID: 451
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalUpperSurfaceColor1>k__BackingField;

		// Token: 0x040001C4 RID: 452
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalUpperSurfaceColor2>k__BackingField;

		// Token: 0x040001C5 RID: 453
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalLowerSurfaceColor1>k__BackingField;

		// Token: 0x040001C6 RID: 454
		[CompilerGenerated]
		private System.Drawing.Color <ButtonNormalLowerSurfaceColor2>k__BackingField;

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor1>k__BackingField;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverBorderColor2>k__BackingField;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverUpperSurfaceColor1>k__BackingField;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverUpperSurfaceColor2>k__BackingField;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverLowerSurfaceColor1>k__BackingField;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private System.Drawing.Color <ButtonHoverLowerSurfaceColor2>k__BackingField;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor1>k__BackingField;

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedBorderColor2>k__BackingField;

		// Token: 0x040001CF RID: 463
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedUpperSurfaceColor1>k__BackingField;

		// Token: 0x040001D0 RID: 464
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedUpperSurfaceColor2>k__BackingField;

		// Token: 0x040001D1 RID: 465
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedLowerSurfaceColor1>k__BackingField;

		// Token: 0x040001D2 RID: 466
		[CompilerGenerated]
		private System.Drawing.Color <ButtonPressedLowerSurfaceColor2>k__BackingField;

		// Token: 0x040001D3 RID: 467
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor1>k__BackingField;

		// Token: 0x040001D4 RID: 468
		[CompilerGenerated]
		private System.Drawing.Color <ButtonShadowColor2>k__BackingField;

		// Token: 0x040001D5 RID: 469
		[CompilerGenerated]
		private int <ButtonShadowWidth>k__BackingField;

		// Token: 0x040001D6 RID: 470
		[CompilerGenerated]
		private int <CornerRadius>k__BackingField;
	}
}
