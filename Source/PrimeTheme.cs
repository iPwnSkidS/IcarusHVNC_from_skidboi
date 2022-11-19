

// Token: 0x0200000B RID: 11

using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal class PrimeTheme : ThemeContainer152
    {
        // Token: 0x06000030 RID: 48 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
        public PrimeTheme()
        {
            MoveHeight = 32;
            BackColor = Color.White;
            TransparencyKey = Color.Fuchsia;
            SetColor("Sides", 232, 232, 232);
            SetColor("Gradient1", 252, 252, 252);
            SetColor("Gradient2", 242, 242, 242);
            SetColor("TextShade", Color.White);
            SetColor("Text", 80, 80, 80);
            SetColor("Back", Color.White);
            SetColor("Border1", 180, 180, 180);
            SetColor("Border2", Color.White);
            SetColor("Border3", Color.White);
            SetColor("Border4", 150, 150, 150);
        }

        // Token: 0x06000031 RID: 49 RVA: 0x0000BFCC File Offset: 0x0000A1CC
        protected override void ColorHook()
        {
            C1 = GetColor("Sides");
            C2 = GetColor("Gradient1");
            C3 = GetColor("Gradient2");
            B1 = new SolidBrush(GetColor("TextShade"));
            B2 = new SolidBrush(GetColor("Text"));
            B3 = new SolidBrush(GetColor("Back"));
            P1 = new Pen(GetColor("Border1"));
            P2 = new Pen(GetColor("Border2"));
            P3 = new Pen(GetColor("Border3"));
            P4 = new Pen(GetColor("Border4"));
            BackColor = B3.Color;
        }

        // Token: 0x06000032 RID: 50 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
        protected override void PaintHook()
        {
            graphics_0.Clear(C1);
            DrawGradient(C2, C3, 0, 0, Width, 15);
            DrawText(B1, HorizontalAlignment.Left, 13, 1);
            DrawText(B2, HorizontalAlignment.Left, 12, 0);
            RT1 = new Rectangle(12, 30, Width - 24, Height - 42);
            graphics_0.FillRectangle(B3, RT1);
            DrawBorders(P1, RT1, 1);
            DrawBorders(P2, RT1);
            DrawBorders(P3, 1);
            DrawBorders(P4);
            DrawCorners(TransparencyKey);
        }

        // Token: 0x0400003A RID: 58
        private Color C1;

        // Token: 0x0400003B RID: 59
        private Color C2;

        // Token: 0x0400003C RID: 60
        private Color C3;

        // Token: 0x0400003D RID: 61
        private SolidBrush B1;

        // Token: 0x0400003E RID: 62
        private SolidBrush B2;

        // Token: 0x0400003F RID: 63
        private SolidBrush B3;

        // Token: 0x04000040 RID: 64
        private Pen P1;

        // Token: 0x04000041 RID: 65
        private Pen P2;

        // Token: 0x04000042 RID: 66
        private Pen P3;

        // Token: 0x04000043 RID: 67
        private Pen P4;

        // Token: 0x04000044 RID: 68
        private Rectangle RT1;
    }
}