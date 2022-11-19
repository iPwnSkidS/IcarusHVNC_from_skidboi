

// Token: 0x0200000D RID: 13

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal class StudioTheme : ThemeContainer152
    {
        // Token: 0x06000036 RID: 54 RVA: 0x0000C490 File Offset: 0x0000A690
        public StudioTheme()
        {
            MoveHeight = 30;
            BackColor = Color.FromArgb(20, 40, 70);
            TransparencyKey = Color.Fuchsia;
            SetColor("Sides", 50, 70, 100);
            SetColor("Gradient1", 65, 85, 115);
            SetColor("Gradient2", 50, 70, 100);
            SetColor("Hatch1", 20, 40, 70);
            SetColor("Hatch2", 40, 60, 90);
            SetColor("Shade1", 15, Color.Black);
            SetColor("Shade2", Color.Transparent);
            SetColor("Border1", 12, 32, 62);
            SetColor("Border2", 20, Color.Black);
            SetColor("Border3", 30, Color.White);
            SetColor("Border4", Color.Black);
            SetColor("Text", Color.White);
            Path = new GraphicsPath();
        }

        // Token: 0x06000037 RID: 55 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
        protected override void ColorHook()
        {
            P1 = new Pen(TransparencyKey, 3f);
            P2 = new Pen(GetColor("Border1"));
            P3 = new Pen(GetColor("Border2"), 2f);
            P4 = new Pen(GetColor("Border3"));
            P5 = new Pen(GetColor("Border4"));
            C1 = GetColor("Sides");
            C2 = GetColor("Gradient1");
            C3 = GetColor("Gradient2");
            C4 = GetColor("Shade1");
            C5 = GetColor("Shade2");
            B1 = new HatchBrush(HatchStyle.LightDownwardDiagonal, GetColor("Hatch1"), GetColor("Hatch2"));
            B2 = new SolidBrush(GetColor("Text"));
            BackColor = GetColor("Hatch2");
        }

        // Token: 0x06000038 RID: 56 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
        protected override void PaintHook()
        {
            graphics_0.DrawRectangle(P1, ClientRectangle);
            graphics_0.SetClip(Path);
            graphics_0.Clear(C1);
            DrawGradient(C2, C3, 0, 0, Width, 30);
            RT1 = new Rectangle(12, 30, Width - 24, Height - 12 - 30);
            graphics_0.FillRectangle(B1, RT1);
            DrawGradient(C4, C5, 12, 30, Width - 24, 30);
            DrawBorders(P2, RT1);
            DrawBorders(P3, 14, 32, Width - 26, Height - 12 - 32);
            DrawText(B2, HorizontalAlignment.Left, 12, 0);
            DrawBorders(P4, 1);
            graphics_0.ResetClip();
            graphics_0.DrawPath(P5, Path);
        }

        // Token: 0x06000039 RID: 57 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
        protected override void OnResize(EventArgs eventArgs_0)
        {
            Path.Reset();
            Path.AddLines(new[]
            {
                new Point(2, 0),
                new Point(Width - 3, 0),
                new Point(Width - 1, 2),
                new Point(Width - 1, Height - 3),
                new Point(Width - 3, Height - 1),
                new Point(2, Height - 1),
                new Point(0, Height - 3),
                new Point(0, 2),
                new Point(2, 0)
            });
            base.OnResize(eventArgs_0);
        }

        // Token: 0x04000050 RID: 80
        private GraphicsPath Path;

        // Token: 0x04000051 RID: 81
        private Color C1;

        // Token: 0x04000052 RID: 82
        private Color C2;

        // Token: 0x04000053 RID: 83
        private Color C3;

        // Token: 0x04000054 RID: 84
        private Color C4;

        // Token: 0x04000055 RID: 85
        private Color C5;

        // Token: 0x04000056 RID: 86
        private Pen P1;

        // Token: 0x04000057 RID: 87
        private Pen P2;

        // Token: 0x04000058 RID: 88
        private Pen P3;

        // Token: 0x04000059 RID: 89
        private Pen P4;

        // Token: 0x0400005A RID: 90
        private Pen P5;

        // Token: 0x0400005B RID: 91
        private HatchBrush B1;

        // Token: 0x0400005C RID: 92
        private SolidBrush B2;

        // Token: 0x0400005D RID: 93
        private Rectangle RT1;
    }
}