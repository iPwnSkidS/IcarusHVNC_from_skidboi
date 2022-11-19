using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BirdBrainmofo.ToggleSwitch;
using Timer = System.Windows.Forms.Timer;

namespace BirdBrainmofo.JCS
{
	// Token: 0x0200004C RID: 76
	[DefaultEvent("CheckedChanged")]
	[DefaultValue("Checked")]
	[ToolboxBitmap(typeof(CheckBox))]
	public class ToggleSwitch : Control
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000462 RID: 1122 RVA: 0x00020DC8 File Offset: 0x0001EFC8
		// (remove) Token: 0x06000463 RID: 1123 RVA: 0x00020E00 File Offset: 0x0001F000
		[Description("Raised when the ToggleSwitch has changed state")]
		public event CheckedChangedDelegate CheckedChanged
		{
			[CompilerGenerated]
			add
			{
				CheckedChangedDelegate checkedChangedDelegate = this.CheckedChanged;
				CheckedChangedDelegate checkedChangedDelegate2;
				do
				{
					checkedChangedDelegate2 = checkedChangedDelegate;
					CheckedChangedDelegate checkedChangedDelegate3 = (CheckedChangedDelegate)Delegate.Combine(checkedChangedDelegate2, value);
					checkedChangedDelegate = Interlocked.CompareExchange<CheckedChangedDelegate>(ref this.CheckedChanged, checkedChangedDelegate3, checkedChangedDelegate2);
				}
				while (checkedChangedDelegate != checkedChangedDelegate2);
			}
			[CompilerGenerated]
			remove
			{
				CheckedChangedDelegate checkedChangedDelegate = this.CheckedChanged;
				CheckedChangedDelegate checkedChangedDelegate2;
				do
				{
					checkedChangedDelegate2 = checkedChangedDelegate;
					CheckedChangedDelegate checkedChangedDelegate3 = (CheckedChangedDelegate)Delegate.Remove(checkedChangedDelegate2, value);
					checkedChangedDelegate = Interlocked.CompareExchange<CheckedChangedDelegate>(ref this.CheckedChanged, checkedChangedDelegate3, checkedChangedDelegate2);
				}
				while (checkedChangedDelegate != checkedChangedDelegate2);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000464 RID: 1124 RVA: 0x00020E38 File Offset: 0x0001F038
		// (remove) Token: 0x06000465 RID: 1125 RVA: 0x00020E70 File Offset: 0x0001F070
		[Description("Raised when the ToggleSwitch renderer is changed")]
		public event BeforeRenderingDelegate BeforeRendering
		{
			[CompilerGenerated]
			add
			{
				BeforeRenderingDelegate beforeRenderingDelegate = this.BeforeRendering;
				BeforeRenderingDelegate beforeRenderingDelegate2;
				do
				{
					beforeRenderingDelegate2 = beforeRenderingDelegate;
					BeforeRenderingDelegate beforeRenderingDelegate3 = (BeforeRenderingDelegate)Delegate.Combine(beforeRenderingDelegate2, value);
					beforeRenderingDelegate = Interlocked.CompareExchange<BeforeRenderingDelegate>(ref this.BeforeRendering, beforeRenderingDelegate3, beforeRenderingDelegate2);
				}
				while (beforeRenderingDelegate != beforeRenderingDelegate2);
			}
			[CompilerGenerated]
			remove
			{
				BeforeRenderingDelegate beforeRenderingDelegate = this.BeforeRendering;
				BeforeRenderingDelegate beforeRenderingDelegate2;
				do
				{
					beforeRenderingDelegate2 = beforeRenderingDelegate;
					BeforeRenderingDelegate beforeRenderingDelegate3 = (BeforeRenderingDelegate)Delegate.Remove(beforeRenderingDelegate2, value);
					beforeRenderingDelegate = Interlocked.CompareExchange<BeforeRenderingDelegate>(ref this.BeforeRendering, beforeRenderingDelegate3, beforeRenderingDelegate2);
				}
				while (beforeRenderingDelegate != beforeRenderingDelegate2);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		public ToggleSwitch()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
			OnFont = method_0();
			OffFont = method_0();
			SetRenderer(new ToggleSwitchMetroRenderer());
			_animationTimer.Enabled = false;
			_animationTimer.Interval = _animationInterval;
			_animationTimer.Tick += AnimationTimer_Tick;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00008608 File Offset: 0x00006808
		public void SetRenderer(ToggleSwitchRendererBase renderer)
		{
			renderer.SetToggleSwitch(this);
			_renderer = renderer;
			if (_renderer != null)
			{
				Refresh();
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002104C File Offset: 0x0001F24C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00021064 File Offset: 0x0001F264
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchStyle), "Metro")]
		[Description("Gets or sets the style of the ToggleSwitch")]
		public ToggleSwitchStyle Style
		{
			get
			{
				return _style;
			}
			set
			{
				if (value != _style)
				{
					_style = value;
					switch (_style)
					{
					case ToggleSwitchStyle.Metro:
						SetRenderer(new ToggleSwitchMetroRenderer());
						break;
					case ToggleSwitchStyle.Android:
						SetRenderer(new ToggleSwitchAndroidRenderer());
						break;
					case ToggleSwitchStyle.IOS5:
						SetRenderer(new ToggleSwitchIOS5Renderer());
						break;
					case ToggleSwitchStyle.BrushedMetal:
						SetRenderer(new ToggleSwitchBrushedMetalRenderer());
						break;
					case ToggleSwitchStyle.OSX:
						SetRenderer(new ToggleSwitchOSXRenderer());
						break;
					case ToggleSwitchStyle.Carbon:
						SetRenderer(new ToggleSwitchCarbonRenderer());
						break;
					case ToggleSwitchStyle.Iphone:
						SetRenderer(new ToggleSwitchIphoneRenderer());
						break;
					case ToggleSwitchStyle.Fancy:
						SetRenderer(new ToggleSwitchFancyRenderer());
						break;
					case ToggleSwitchStyle.Modern:
						SetRenderer(new ToggleSwitchModernRenderer());
						break;
					case ToggleSwitchStyle.PlainAndSimpel:
						SetRenderer(new ToggleSwitchPlainAndSimpleRenderer());
						break;
					}
				}
				Refresh();
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00008629 File Offset: 0x00006829
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0002114C File Offset: 0x0001F34C
		[Bindable(true)]
		[Category("Data")]
		[DefaultValue(false)]
		[Description("Gets or sets the Checked value of the ToggleSwitch")]
		public bool Checked
		{
			get
			{
				return _checked;
			}
			set
			{
				if (value != _checked)
				{
					while (_animating)
					{
						Application.DoEvents();
					}
					if (value)
					{
						int buttonWidth = _renderer.GetButtonWidth();
						_animationTarget = Width - buttonWidth;
						BeginAnimation(true);
					}
					else
					{
						_animationTarget = 0;
						BeginAnimation(false);
					}
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00008631 File Offset: 0x00006831
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00008639 File Offset: 0x00006839
		[Bindable(true)]
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Gets or sets whether the user can change the value of the button or not")]
		public bool AllowUserChange
		{
			get
			{
				return _allowUserChange;
			}
			set
			{
				_allowUserChange = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000211AC File Offset: 0x0001F3AC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string CheckedString
		{
			get
			{
				return Checked ? (string.IsNullOrEmpty(OnText) ? "ON" : OnText) : (string.IsNullOrEmpty(OffText) ? "OFF" : OffText);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000211FC File Offset: 0x0001F3FC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Rectangle ButtonRectangle
		{
			get
			{
				return _renderer.GetButtonRectangle();
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00008642 File Offset: 0x00006842
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000864A File Offset: 0x0000684A
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(true)]
		[Description("Gets or sets if the ToggleSwitch should be grayed out when disabled")]
		public bool GrayWhenDisabled
		{
			get
			{
				return _grayWhenDisabled;
			}
			set
			{
				if (value != _grayWhenDisabled)
				{
					_grayWhenDisabled = value;
					if (!Enabled)
					{
						Refresh();
					}
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00008672 File Offset: 0x00006872
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0000867A File Offset: 0x0000687A
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Gets or sets if the ToggleSwitch should toggle when the button is clicked")]
		public bool ToggleOnButtonClick
		{
			get
			{
				return _toggleOnButtonClick;
			}
			set
			{
				_toggleOnButtonClick = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00008683 File Offset: 0x00006883
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0000868B File Offset: 0x0000688B
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Gets or sets if the ToggleSwitch should toggle when the track besides the button is clicked")]
		public bool ToggleOnSideClick
		{
			get
			{
				return _toggleOnSideClick;
			}
			set
			{
				_toggleOnSideClick = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00021218 File Offset: 0x0001F418
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00008694 File Offset: 0x00006894
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(50)]
		[Description("Gets or sets how much the button need to be on the other side (in peercept) before it snaps")]
		public int ThresholdPercentage
		{
			get
			{
				return _thresholdPercentage;
			}
			set
			{
				_thresholdPercentage = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00021230 File Offset: 0x0001F430
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0000869D File Offset: 0x0000689D
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "Black")]
		[Description("Gets or sets the forecolor of the text when Checked=false")]
		public Color OffForeColor
		{
			get
			{
				return _offForeColor;
			}
			set
			{
				if (value != _offForeColor)
				{
					_offForeColor = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00021248 File Offset: 0x0001F448
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000086BA File Offset: 0x000068BA
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(Font), "Microsoft Sans Serif, 8.25pt")]
		[Description("Gets or sets the font of the text when Checked=false")]
		public Font OffFont
		{
			get
			{
				return _offFont;
			}
			set
			{
				if (!value.Equals(_offFont))
				{
					_offFont = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00021260 File Offset: 0x0001F460
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x000086DA File Offset: 0x000068DA
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Description("Gets or sets the text when Checked=true")]
		public string OffText
		{
			get
			{
				return _offText;
			}
			set
			{
				if (value != _offText)
				{
					_offText = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00021278 File Offset: 0x0001F478
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000086F7 File Offset: 0x000068F7
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(null)]
		[Description("Gets or sets the side image when Checked=false - Note: Settings the OffSideImage overrules the OffText property. Only the image will be shown")]
		public Image OffSideImage
		{
			get
			{
				return _offSideImage;
			}
			set
			{
				if (value != _offSideImage)
				{
					_offSideImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00008714 File Offset: 0x00006914
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0000871C File Offset: 0x0000691C
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets whether the side image visible when Checked=false should be scaled to fit")]
		public bool OffSideScaleImageToFit
		{
			get
			{
				return _offSideScaleImage;
			}
			set
			{
				if (value != _offSideScaleImage)
				{
					_offSideScaleImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00021290 File Offset: 0x0001F490
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00008739 File Offset: 0x00006939
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchAlignment), "Center")]
		[Description("Gets or sets how the text or side image visible when Checked=false should be aligned")]
		public ToggleSwitchAlignment OffSideAlignment
		{
			get
			{
				return _offSideAlignment;
			}
			set
			{
				if (value != _offSideAlignment)
				{
					_offSideAlignment = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000212A8 File Offset: 0x0001F4A8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00008756 File Offset: 0x00006956
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(null)]
		[Description("Gets or sets the button image when Checked=false and ButtonImage is not set")]
		public Image OffButtonImage
		{
			get
			{
				return _offButtonImage;
			}
			set
			{
				if (value != _offButtonImage)
				{
					_offButtonImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00008773 File Offset: 0x00006973
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x0000877B File Offset: 0x0000697B
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets whether the button image visible when Checked=false should be scaled to fit")]
		public bool OffButtonScaleImageToFit
		{
			get
			{
				return _offButtonScaleImage;
			}
			set
			{
				if (value != _offButtonScaleImage)
				{
					_offButtonScaleImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000212C0 File Offset: 0x0001F4C0
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00008798 File Offset: 0x00006998
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchButtonAlignment), "Center")]
		[Description("Gets or sets how the button image visible when Checked=false should be aligned")]
		public ToggleSwitchButtonAlignment OffButtonAlignment
		{
			get
			{
				return _offButtonAlignment;
			}
			set
			{
				if (value != _offButtonAlignment)
				{
					_offButtonAlignment = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x000212D8 File Offset: 0x0001F4D8
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x000087B5 File Offset: 0x000069B5
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "Black")]
		[Description("Gets or sets the forecolor of the text when Checked=true")]
		public Color OnForeColor
		{
			get
			{
				return _onForeColor;
			}
			set
			{
				if (value != _onForeColor)
				{
					_onForeColor = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000212F0 File Offset: 0x0001F4F0
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x000087D2 File Offset: 0x000069D2
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(Font), "Microsoft Sans Serif, 8,25pt")]
		[Description("Gets or sets the font of the text when Checked=true")]
		public Font OnFont
		{
			get
			{
				return _onFont;
			}
			set
			{
				if (!value.Equals(_onFont))
				{
					_onFont = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00021308 File Offset: 0x0001F508
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000087F2 File Offset: 0x000069F2
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue("")]
		[Description("Gets or sets the text when Checked=true")]
		public string OnText
		{
			get
			{
				return _onText;
			}
			set
			{
				if (value != _onText)
				{
					_onText = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00021320 File Offset: 0x0001F520
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x0000880F File Offset: 0x00006A0F
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(null)]
		[Description("Gets or sets the side image visible when Checked=true - Note: Settings the OnSideImage overrules the OnText property. Only the image will be shown.")]
		public Image OnSideImage
		{
			get
			{
				return _onSideImage;
			}
			set
			{
				if (value != _onSideImage)
				{
					_onSideImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000882C File Offset: 0x00006A2C
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00008834 File Offset: 0x00006A34
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets whether the side image visible when Checked=true should be scaled to fit")]
		public bool OnSideScaleImageToFit
		{
			get
			{
				return _onSideScaleImage;
			}
			set
			{
				if (value != _onSideScaleImage)
				{
					_onSideScaleImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00021338 File Offset: 0x0001F538
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00008851 File Offset: 0x00006A51
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(null)]
		[Description("Gets or sets the button image")]
		public Image ButtonImage
		{
			get
			{
				return _buttonImage;
			}
			set
			{
				if (value != _buttonImage)
				{
					_buttonImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000886E File Offset: 0x00006A6E
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00008876 File Offset: 0x00006A76
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets whether the button image should be scaled to fit")]
		public bool ButtonScaleImageToFit
		{
			get
			{
				return _buttonScaleImage;
			}
			set
			{
				if (value != _buttonScaleImage)
				{
					_buttonScaleImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00021350 File Offset: 0x0001F550
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00008893 File Offset: 0x00006A93
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchButtonAlignment), "Center")]
		[Description("Gets or sets how the button image should be aligned")]
		public ToggleSwitchButtonAlignment ButtonAlignment
		{
			get
			{
				return _buttonAlignment;
			}
			set
			{
				if (value != _buttonAlignment)
				{
					_buttonAlignment = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00021368 File Offset: 0x0001F568
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchAlignment), "Center")]
		[Description("Gets or sets how the text or side image visible when Checked=true should be aligned")]
		public ToggleSwitchAlignment OnSideAlignment
		{
			get
			{
				return _onSideAlignment;
			}
			set
			{
				if (value != _onSideAlignment)
				{
					_onSideAlignment = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00021380 File Offset: 0x0001F580
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x000088CD File Offset: 0x00006ACD
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(null)]
		[Description("Gets or sets the button image visible when Checked=true and ButtonImage is not set")]
		public Image OnButtonImage
		{
			get
			{
				return _onButtonImage;
			}
			set
			{
				if (value != _onButtonImage)
				{
					_onButtonImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000088EA File Offset: 0x00006AEA
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x000088F2 File Offset: 0x00006AF2
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets whether the button image visible when Checked=true should be scaled to fit")]
		public bool OnButtonScaleImageToFit
		{
			get
			{
				return _onButtonScaleImage;
			}
			set
			{
				if (value != _onButtonScaleImage)
				{
					_onButtonScaleImage = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00021398 File Offset: 0x0001F598
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0000890F File Offset: 0x00006B0F
		[Bindable(false)]
		[Category("Appearance")]
		[DefaultValue(typeof(ToggleSwitchButtonAlignment), "Center")]
		[Description("Gets or sets how the button image visible when Checked=true should be aligned")]
		public ToggleSwitchButtonAlignment OnButtonAlignment
		{
			get
			{
				return _onButtonAlignment;
			}
			set
			{
				if (value != _onButtonAlignment)
				{
					_onButtonAlignment = value;
					Refresh();
				}
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000892C File Offset: 0x00006B2C
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00008934 File Offset: 0x00006B34
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Gets or sets whether the toggle change should be animated or not")]
		public bool UseAnimation
		{
			get
			{
				return _useAnimation;
			}
			set
			{
				_useAnimation = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000213B0 File Offset: 0x0001F5B0
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0000893D File Offset: 0x00006B3D
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(1)]
		[Description("Gets or sets the interval in ms between animation frames")]
		public int AnimationInterval
		{
			get
			{
				return _animationInterval;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("AnimationInterval must larger than zero!");
				}
				_animationInterval = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000213C8 File Offset: 0x0001F5C8
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x0000895A File Offset: 0x00006B5A
		[Bindable(false)]
		[Category("Behavior")]
		[DefaultValue(10)]
		[Description("Gets or sets the step in pixes the button shouldbe moved between each animation interval")]
		public int AnimationStep
		{
			get
			{
				return _animationStep;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("AnimationStep must larger than zero!");
				}
				_animationStep = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000213E0 File Offset: 0x0001F5E0
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00008977 File Offset: 0x00006B77
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new string Text
		{
			get
			{
				return "";
			}
			set
			{
				method_1("");
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000213F4 File Offset: 0x0001F5F4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00008984 File Offset: 0x00006B84
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Color ForeColor
		{
			get
			{
				return Color.Black;
			}
			set
			{
				method_2(Color.Black);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00021408 File Offset: 0x0001F608
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00008991 File Offset: 0x00006B91
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Font Font
		{
			get
			{
				return method_0();
			}
			set
			{
				method_3(new Font(method_0(), FontStyle.Regular));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000089A5 File Offset: 0x00006BA5
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonHovered
		{
			get
			{
				return _isButtonHovered && !_isButtonPressed;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000089BB File Offset: 0x00006BBB
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonPressed
		{
			get
			{
				return _isButtonPressed;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000089C3 File Offset: 0x00006BC3
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsLeftSideHovered
		{
			get
			{
				return _isLeftFieldHovered && !_isLeftFieldPressed;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000089D9 File Offset: 0x00006BD9
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsLeftSidePressed
		{
			get
			{
				return _isLeftFieldPressed;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000089E1 File Offset: 0x00006BE1
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsRightSideHovered
		{
			get
			{
				return _isRightFieldHovered && !_isRightFieldPressed;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000089F7 File Offset: 0x00006BF7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsRightSidePressed
		{
			get
			{
				return _isRightFieldPressed;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00021420 File Offset: 0x0001F620
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000089FF File Offset: 0x00006BFF
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal int ButtonValue
		{
			get
			{
				int num;
				if (!_animating && !_moving)
				{
					if (_checked)
					{
						num = Width - _renderer.GetButtonWidth();
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					num = _buttonValue;
				}
				return num;
			}
			set
			{
				if (value != _buttonValue)
				{
					_buttonValue = value;
					Refresh();
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00008A1C File Offset: 0x00006C1C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonOnLeftSide
		{
			get
			{
				return ButtonValue <= 0;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00008A2A File Offset: 0x00006C2A
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonOnRightSide
		{
			get
			{
				return ButtonValue >= Width - _renderer.GetButtonWidth();
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00008A49 File Offset: 0x00006C49
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonMovingLeft
		{
			get
			{
				return _animating && !IsButtonOnLeftSide && !_animationResult;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00008A67 File Offset: 0x00006C67
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool IsButtonMovingRight
		{
			get
			{
				return _animating && !IsButtonOnRightSide && _animationResult;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00008A82 File Offset: 0x00006C82
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		internal bool AnimationResult
		{
			get
			{
				return _animationResult;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00021468 File Offset: 0x0001F668
		protected override Size DefaultSize
		{
			get
			{
				return new Size(50, 19);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00008A8A File Offset: 0x00006C8A
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			pevent.Graphics.ResetClip();
			base.OnPaintBackground(pevent);
			if (_renderer != null)
			{
				_renderer.RenderBackground(pevent);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00021480 File Offset: 0x0001F680
		protected override void OnPaint(PaintEventArgs pevent)
		{
			pevent.Graphics.ResetClip();
			base.OnPaint(pevent);
			if (_renderer != null)
			{
				if (this.BeforeRendering != null)
				{
					this.BeforeRendering(this, new BeforeRenderingEventArgs(_renderer));
				}
				_renderer.RenderControl(pevent);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000214D8 File Offset: 0x0001F6D8
		protected override void OnMouseMove(MouseEventArgs mevent)
		{
			_lastMouseEventArgs = mevent;
			int buttonWidth = _renderer.GetButtonWidth();
			Rectangle buttonRectangle = _renderer.GetButtonRectangle(buttonWidth);
			if (_moving)
			{
				int num = _xValue + (mevent.Location.X - _xOffset);
				if (num < 0)
				{
					num = 0;
				}
				if (num > Width - buttonWidth)
				{
					num = Width - buttonWidth;
				}
				ButtonValue = num;
				Refresh();
			}
			else
			{
				if (buttonRectangle.Contains(mevent.Location))
				{
					_isButtonHovered = true;
					_isLeftFieldHovered = false;
					_isRightFieldHovered = false;
				}
				else if (mevent.Location.X > buttonRectangle.X + buttonRectangle.Width)
				{
					_isButtonHovered = false;
					_isLeftFieldHovered = false;
					_isRightFieldHovered = true;
				}
				else if (mevent.Location.X < buttonRectangle.X)
				{
					_isButtonHovered = false;
					_isLeftFieldHovered = true;
					_isRightFieldHovered = false;
				}
				Refresh();
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000215EC File Offset: 0x0001F7EC
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			if (!_animating && AllowUserChange)
			{
				int buttonWidth = _renderer.GetButtonWidth();
				Rectangle buttonRectangle = _renderer.GetButtonRectangle(buttonWidth);
				_savedButtonValue = ButtonValue;
				if (buttonRectangle.Contains(mevent.Location))
				{
					_isButtonPressed = true;
					_isLeftFieldPressed = false;
					_isRightFieldPressed = false;
					_moving = true;
					_xOffset = mevent.Location.X;
					_buttonValue = buttonRectangle.X;
					_xValue = ButtonValue;
				}
				else if (mevent.Location.X > buttonRectangle.X + buttonRectangle.Width)
				{
					_isButtonPressed = false;
					_isLeftFieldPressed = false;
					_isRightFieldPressed = true;
				}
				else if (mevent.Location.X < buttonRectangle.X)
				{
					_isButtonPressed = false;
					_isLeftFieldPressed = true;
					_isRightFieldPressed = false;
				}
				Refresh();
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00021700 File Offset: 0x0001F900
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			if (!_animating && AllowUserChange)
			{
				int buttonWidth = _renderer.GetButtonWidth();
				bool isLeftSidePressed = IsLeftSidePressed;
				bool isRightSidePressed = IsRightSidePressed;
				_isButtonPressed = false;
				_isLeftFieldPressed = false;
				_isRightFieldPressed = false;
				if (_moving)
				{
					int num = (int)(100.0 * ButtonValue / (Width - (double)buttonWidth));
					if (_checked)
					{
						if (num <= 100 - _thresholdPercentage)
						{
							_animationTarget = 0;
							BeginAnimation(false);
						}
						else if (ToggleOnButtonClick && _savedButtonValue == ButtonValue)
						{
							_animationTarget = 0;
							BeginAnimation(false);
						}
						else
						{
							_animationTarget = Width - buttonWidth;
							BeginAnimation(true);
						}
					}
					else if (num >= _thresholdPercentage)
					{
						_animationTarget = Width - buttonWidth;
						BeginAnimation(true);
					}
					else if (ToggleOnButtonClick && _savedButtonValue == ButtonValue)
					{
						_animationTarget = Width - buttonWidth;
						BeginAnimation(true);
					}
					else
					{
						_animationTarget = 0;
						BeginAnimation(false);
					}
					_moving = false;
				}
				else
				{
					if (IsButtonOnRightSide)
					{
						_buttonValue = Width - buttonWidth;
						_animationTarget = 0;
					}
					else
					{
						_buttonValue = 0;
						_animationTarget = Width - buttonWidth;
					}
					if (isLeftSidePressed && ToggleOnSideClick)
					{
						SetValueInternal(false);
					}
					else if (isRightSidePressed && ToggleOnSideClick)
					{
						SetValueInternal(true);
					}
					Refresh();
				}
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00008AB5 File Offset: 0x00006CB5
		protected override void OnMouseLeave(EventArgs eventargs)
		{
			_isButtonHovered = false;
			_isLeftFieldHovered = false;
			_isRightFieldHovered = false;
			_isButtonPressed = false;
			_isLeftFieldPressed = false;
			_isRightFieldPressed = false;
			Refresh();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00008AE7 File Offset: 0x00006CE7
		protected override void OnEnabledChanged(EventArgs eventArgs_0)
		{
			base.OnEnabledChanged(eventArgs_0);
			Refresh();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00008AF6 File Offset: 0x00006CF6
		protected override void OnRegionChanged(EventArgs eventArgs_0)
		{
			base.OnRegionChanged(eventArgs_0);
			Refresh();
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000218B4 File Offset: 0x0001FAB4
		protected override void OnSizeChanged(EventArgs eventArgs_0)
		{
			if (_animationTarget > 0)
			{
				int buttonWidth = _renderer.GetButtonWidth();
				_animationTarget = Width - buttonWidth;
			}
			base.OnSizeChanged(eventArgs_0);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00008B05 File Offset: 0x00006D05
		private void SetValueInternal(bool checkedValue)
		{
			if (checkedValue != _checked)
			{
				while (_animating)
				{
					Application.DoEvents();
				}
				BeginAnimation(checkedValue);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000218F0 File Offset: 0x0001FAF0
		private void BeginAnimation(bool checkedValue)
		{
			_animating = true;
			_animationResult = checkedValue;
			if (_animationTimer != null && _useAnimation)
			{
				_animationTimer.Interval = _animationInterval;
				_animationTimer.Enabled = true;
			}
			else
			{
				AnimationComplete();
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00021940 File Offset: 0x0001FB40
		private void AnimationTimer_Tick(object sender, EventArgs e)
		{
			_animationTimer.Enabled = false;
			bool flag;
			if (IsButtonMovingRight)
			{
				int num = ButtonValue + _animationStep;
				if (num > _animationTarget)
				{
					num = _animationTarget;
				}
				ButtonValue = num;
				flag = ButtonValue >= _animationTarget;
			}
			else
			{
				int num = ButtonValue - _animationStep;
				if (num < _animationTarget)
				{
					num = _animationTarget;
				}
				ButtonValue = num;
				flag = ButtonValue <= _animationTarget;
			}
			if (flag)
			{
				AnimationComplete();
			}
			else
			{
				_animationTimer.Enabled = true;
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000219F0 File Offset: 0x0001FBF0
		private void AnimationComplete()
		{
			_animating = false;
			_moving = false;
			_checked = _animationResult;
			_isButtonHovered = false;
			_isButtonPressed = false;
			_isLeftFieldHovered = false;
			_isLeftFieldPressed = false;
			_isRightFieldHovered = false;
			_isRightFieldPressed = false;
			Refresh();
			if (this.CheckedChanged != null)
			{
				this.CheckedChanged(this, new EventArgs());
			}
			if (_lastMouseEventArgs != null)
			{
				OnMouseMove(_lastMouseEventArgs);
			}
			_lastMouseEventArgs = null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00006A13 File Offset: 0x00004C13
		object method_0()
		{
			return base.Font;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00006A0A File Offset: 0x00004C0A
		void method_1(string string_0)
		{
			base.Text = string_0;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000078C0 File Offset: 0x00005AC0
		void method_2(Color color_0)
		{
			base.ForeColor = color_0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00006A1B File Offset: 0x00004C1B
		void method_3(object object_0)
		{
			base.Font = object_0;
		}

		// Token: 0x0400024E RID: 590
		[CompilerGenerated]
		private CheckedChangedDelegate CheckedChanged;

		// Token: 0x0400024F RID: 591
		[CompilerGenerated]
		private BeforeRenderingDelegate BeforeRendering;

		// Token: 0x04000250 RID: 592
		private readonly Timer _animationTimer = new Timer();

		// Token: 0x04000251 RID: 593
		private ToggleSwitchRendererBase _renderer;

		// Token: 0x04000252 RID: 594
		private ToggleSwitchStyle _style = ToggleSwitchStyle.Metro;

		// Token: 0x04000253 RID: 595
		private bool _checked;

		// Token: 0x04000254 RID: 596
		private bool _moving;

		// Token: 0x04000255 RID: 597
		private bool _animating;

		// Token: 0x04000256 RID: 598
		private bool _animationResult;

		// Token: 0x04000257 RID: 599
		private int _animationTarget;

		// Token: 0x04000258 RID: 600
		private bool _useAnimation = true;

		// Token: 0x04000259 RID: 601
		private int _animationInterval = 1;

		// Token: 0x0400025A RID: 602
		private int _animationStep = 10;

		// Token: 0x0400025B RID: 603
		private bool _allowUserChange = true;

		// Token: 0x0400025C RID: 604
		private bool _isLeftFieldHovered;

		// Token: 0x0400025D RID: 605
		private bool _isButtonHovered;

		// Token: 0x0400025E RID: 606
		private bool _isRightFieldHovered;

		// Token: 0x0400025F RID: 607
		private bool _isLeftFieldPressed;

		// Token: 0x04000260 RID: 608
		private bool _isButtonPressed;

		// Token: 0x04000261 RID: 609
		private bool _isRightFieldPressed;

		// Token: 0x04000262 RID: 610
		private int _buttonValue;

		// Token: 0x04000263 RID: 611
		private int _savedButtonValue;

		// Token: 0x04000264 RID: 612
		private int _xOffset;

		// Token: 0x04000265 RID: 613
		private int _xValue;

		// Token: 0x04000266 RID: 614
		private int _thresholdPercentage = 50;

		// Token: 0x04000267 RID: 615
		private bool _grayWhenDisabled = true;

		// Token: 0x04000268 RID: 616
		private bool _toggleOnButtonClick = true;

		// Token: 0x04000269 RID: 617
		private bool _toggleOnSideClick = true;

		// Token: 0x0400026A RID: 618
		private MouseEventArgs _lastMouseEventArgs;

		// Token: 0x0400026B RID: 619
		private bool _buttonScaleImage;

		// Token: 0x0400026C RID: 620
		private ToggleSwitchButtonAlignment _buttonAlignment = ToggleSwitchButtonAlignment.Center;

		// Token: 0x0400026D RID: 621
		private Image _buttonImage;

		// Token: 0x0400026E RID: 622
		private string _offText = "";

		// Token: 0x0400026F RID: 623
		private Color _offForeColor = Color.Black;

		// Token: 0x04000270 RID: 624
		private Font _offFont;

		// Token: 0x04000271 RID: 625
		private Image _offSideImage;

		// Token: 0x04000272 RID: 626
		private bool _offSideScaleImage;

		// Token: 0x04000273 RID: 627
		private ToggleSwitchAlignment _offSideAlignment = ToggleSwitchAlignment.Center;

		// Token: 0x04000274 RID: 628
		private Image _offButtonImage;

		// Token: 0x04000275 RID: 629
		private bool _offButtonScaleImage;

		// Token: 0x04000276 RID: 630
		private ToggleSwitchButtonAlignment _offButtonAlignment = ToggleSwitchButtonAlignment.Center;

		// Token: 0x04000277 RID: 631
		private string _onText = "";

		// Token: 0x04000278 RID: 632
		private Color _onForeColor = Color.Black;

		// Token: 0x04000279 RID: 633
		private Font _onFont;

		// Token: 0x0400027A RID: 634
		private Image _onSideImage;

		// Token: 0x0400027B RID: 635
		private bool _onSideScaleImage;

		// Token: 0x0400027C RID: 636
		private ToggleSwitchAlignment _onSideAlignment = ToggleSwitchAlignment.Center;

		// Token: 0x0400027D RID: 637
		private Image _onButtonImage;

		// Token: 0x0400027E RID: 638
		private bool _onButtonScaleImage;

		// Token: 0x0400027F RID: 639
		private ToggleSwitchButtonAlignment _onButtonAlignment = ToggleSwitchButtonAlignment.Center;

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060004CE RID: 1230
		public delegate void CheckedChangedDelegate(object sender, EventArgs e);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060004D2 RID: 1234
		public delegate void BeforeRenderingDelegate(object sender, BeforeRenderingEventArgs e);

		// Token: 0x0200004F RID: 79
		public enum ToggleSwitchStyle
		{
			// Token: 0x04000281 RID: 641
			Metro,
			// Token: 0x04000282 RID: 642
			Android,
			// Token: 0x04000283 RID: 643
			IOS5,
			// Token: 0x04000284 RID: 644
			BrushedMetal,
			// Token: 0x04000285 RID: 645
			OSX,
			// Token: 0x04000286 RID: 646
			Carbon,
			// Token: 0x04000287 RID: 647
			Iphone,
			// Token: 0x04000288 RID: 648
			Fancy,
			// Token: 0x04000289 RID: 649
			Modern,
			// Token: 0x0400028A RID: 650
			PlainAndSimpel
		}

		// Token: 0x02000050 RID: 80
		public enum ToggleSwitchAlignment
		{
			// Token: 0x0400028C RID: 652
			Near,
			// Token: 0x0400028D RID: 653
			Center,
			// Token: 0x0400028E RID: 654
			Far
		}

		// Token: 0x02000051 RID: 81
		public enum ToggleSwitchButtonAlignment
		{
			// Token: 0x04000290 RID: 656
			Left,
			// Token: 0x04000291 RID: 657
			Center,
			// Token: 0x04000292 RID: 658
			Right
		}
	}
}
