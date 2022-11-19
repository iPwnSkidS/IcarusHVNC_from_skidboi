

// Token: 0x0200000C RID: 12

using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal class PrimeButton : ThemeControl152
    {
        // Token: 0x06000033 RID: 51 RVA: 0x0000C194 File Offset: 0x0000A394
        public PrimeButton()
        {
            SetColor("DownGradient1", 215, 215, 215);
            SetColor("DownGradient2", 235, 235, 235);
            SetColor("NoneGradient1", 235, 235, 235);
            SetColor("NoneGradient2", 215, 215, 215);
            SetColor("NoneGradient3", 252, 252, 252);
            SetColor("NoneGradient4", 242, 242, 242);
            SetColor("Glow", 50, Color.White);
            SetColor("TextShade", Color.White);
            SetColor("Text", 80, 80, 80);
            SetColor("Border1", Color.White);
            SetColor("Border2", 180, 180, 180);
        }

        // Token: 0x06000034 RID: 52 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
        protected override void ColorHook()
        {
            C1 = GetColor("DownGradient1");
            C2 = GetColor("DownGradient2");
            C3 = GetColor("NoneGradient1");
            C4 = GetColor("NoneGradient2");
            C5 = GetColor("NoneGradient3");
            C6 = GetColor("NoneGradient4");
            B1 = new SolidBrush(GetColor("Glow"));
            B2 = new SolidBrush(GetColor("TextShade"));
            B3 = new SolidBrush(GetColor("Text"));
            P1 = new Pen(GetColor("Border1"));
            P2 = new Pen(GetColor("Border2"));
        }

        // Token: 0x06000035 RID: 53 RVA: 0x0000C384 File Offset: 0x0000A584
        protected override void PaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(C1, C2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(C3, C4, ClientRectangle, 90f);
                DrawGradient(C5, C6, 0, 0, Width, Height / 2, 90f);
            }
            if (State == MouseState.Over)
            {
                graphics_0.FillRectangle(B1, ClientRectangle);
            }
            if (State == MouseState.Down)
            {
                DrawText(B2, HorizontalAlignment.Center, 2, 2);
                DrawText(B3, HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                DrawText(B2, HorizontalAlignment.Center, 1, 1);
                DrawText(B3, HorizontalAlignment.Center, 0, 0);
            }
            DrawBorders(P1, 1);
            DrawBorders(P2);
            DrawCorners(BackColor);
        }

        // Token: 0x04000045 RID: 69
        private Color C1;

        // Token: 0x04000046 RID: 70
        private Color C2;

        // Token: 0x04000047 RID: 71
        private Color C3;

        // Token: 0x04000048 RID: 72
        private Color C4;

        // Token: 0x04000049 RID: 73
        private Color C5;

        // Token: 0x0400004A RID: 74
        private Color C6;

        // Token: 0x0400004B RID: 75
        private SolidBrush B1;

        // Token: 0x0400004C RID: 76
        private SolidBrush B2;

        // Token: 0x0400004D RID: 77
        private SolidBrush B3;

        // Token: 0x0400004E RID: 78
        private Pen P1;

        // Token: 0x0400004F RID: 79
        private Pen P2;
    }
}
