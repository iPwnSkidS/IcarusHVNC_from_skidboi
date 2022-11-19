using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x02000062 RID: 98
	public class AmbianceProgressIndicator : Control
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00024598 File Offset: 0x00022798
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x000090C8 File Offset: 0x000072C8
		public Color P_BaseColor
		{
			get
			{
				return BaseColor.Color;
			}
			set
			{
				BaseColor.Color = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x000245B4 File Offset: 0x000227B4
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x000090D6 File Offset: 0x000072D6
		public Color P_AnimationColor
		{
			get
			{
				return AnimationColor.Color;
			}
			set
			{
				AnimationColor.Color = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x000245D0 File Offset: 0x000227D0
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000090E4 File Offset: 0x000072E4
		public int P_AnimationSpeed
		{
			get
			{
				return AnimationSpeed.Interval;
			}
			set
			{
				AnimationSpeed.Interval = value;
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000090F2 File Offset: 0x000072F2
		protected override void OnSizeChanged(EventArgs eventArgs_0)
		{
			base.OnSizeChanged(eventArgs_0);
			SetStandardSize();
			UpdateGraphics();
			SetPoints();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000910D File Offset: 0x0000730D
		protected override void OnEnabledChanged(EventArgs eventArgs_0)
		{
			base.OnEnabledChanged(eventArgs_0);
			AnimationSpeed.Enabled = Enabled;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00009127 File Offset: 0x00007327
		protected override void OnHandleCreated(EventArgs eventArgs_0)
		{
			base.OnHandleCreated(eventArgs_0);
			AnimationSpeed.Tick += AnimationSpeed_Tick;
			AnimationSpeed.Start();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00009152 File Offset: 0x00007352
		private void AnimationSpeed_Tick(object sender, EventArgs e)
		{
			if (IndicatorIndex.Equals(0))
			{
				IndicatorIndex = FloatPoint.Length - 1;
			}
			else
			{
				IndicatorIndex--;
			}
			Invalidate(false);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000245EC File Offset: 0x000227EC
		public AmbianceProgressIndicator()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			Size = new Size(80, 80);
			Text = string.Empty;
			MinimumSize = new Size(80, 80);
			SetPoints();
			AnimationSpeed.Interval = 100;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00024684 File Offset: 0x00022884
		private void SetStandardSize()
		{
			int num = Math.Max(Width, Height);
			Size = new Size(num, num);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000246B0 File Offset: 0x000228B0
		private void SetPoints()
		{
			Stack<PointF> stack = new Stack<PointF>();
			PointF pointF = new PointF(Width / 2f, Height / 2f);
			for (float num = 0f; num < 360f; num += 45f)
			{
				SetValue(pointF, (int)Math.Round(Width / 2.0 - 15.0), num);
				PointF endPoint = EndPoint;
				endPoint = new PointF(endPoint.X - 7.5f, endPoint.Y - 7.5f);
				stack.Push(endPoint);
			}
			FloatPoint = stack.ToArray();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00024764 File Offset: 0x00022964
		private void UpdateGraphics()
		{
			if (Width > 0 && Height > 0)
			{
				Size size = new Size(Width + 1, Height + 1);
				GraphicsContext.MaximumBuffer = size;
				BuffGraphics = GraphicsContext.Allocate(CreateGraphics(), ClientRectangle);
				BuffGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000247D8 File Offset: 0x000229D8
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			BuffGraphics.Graphics.Clear(BackColor);
			int num = FloatPoint.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (IndicatorIndex == i)
				{
					BuffGraphics.Graphics.FillEllipse(AnimationColor, FloatPoint[i].X, FloatPoint[i].Y, 15f, 15f);
				}
				else
				{
					BuffGraphics.Graphics.FillEllipse(BaseColor, FloatPoint[i].X, FloatPoint[i].Y, 15f, 15f);
				}
			}
			BuffGraphics.Render(pevent.Graphics);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000248C8 File Offset: 0x00022AC8
		private T AssignValues<T>(ref T Run, T Length)
		{
			Run = Length;
			return Length;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000248E0 File Offset: 0x00022AE0
		private void SetValue(PointF StartingFloatPoint, int Length, double Angle)
		{
			double num = 3.1415926535897931 * Angle / 180.0;
			_StartingFloatPoint = StartingFloatPoint;
			Rise = AssignValues(ref Run, Length);
			Rise = Math.Sin(num) * Rise;
			Run = Math.Cos(num) * Run;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00024944 File Offset: 0x00022B44
		private PointF EndPoint
		{
			get
			{
				float num = Convert.ToSingle(_StartingFloatPoint.Y + Rise);
				float num2 = Convert.ToSingle(_StartingFloatPoint.X + Run);
				return new PointF(num2, num);
			}
		}

		// Token: 0x040002DC RID: 732
		private readonly SolidBrush BaseColor = new SolidBrush(Color.FromArgb(76, 76, 76));

		// Token: 0x040002DD RID: 733
		private readonly SolidBrush AnimationColor = new SolidBrush(Color.Gray);

		// Token: 0x040002DE RID: 734
		private readonly Timer AnimationSpeed = new Timer();

		// Token: 0x040002DF RID: 735
		private PointF[] FloatPoint;

		// Token: 0x040002E0 RID: 736
		private BufferedGraphics BuffGraphics;

		// Token: 0x040002E1 RID: 737
		private int IndicatorIndex;

		// Token: 0x040002E2 RID: 738
		private readonly BufferedGraphicsContext GraphicsContext = BufferedGraphicsManager.Current;

		// Token: 0x040002E3 RID: 739
		private double Rise;

		// Token: 0x040002E4 RID: 740
		private double Run;

		// Token: 0x040002E5 RID: 741
		private PointF _StartingFloatPoint;
	}
}
