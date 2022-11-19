

// Token: 0x0200000E RID: 14

using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal class StudioButton : ThemeControl152
    {
        // Token: 0x0600003A RID: 58 RVA: 0x0000C8DC File Offset: 0x0000AADC
        public StudioButton()
        {
            Transparent = true;
            BackColor = Color.Transparent;
            SetColor("DownGradient1", 45, 65, 95);
            SetColor("DownGradient2", 65, 85, 115);
            SetColor("NoneGradient1", 65, 85, 115);
            SetColor("NoneGradient2", 45, 65, 95);
            SetColor("Shine1", 30, Color.White);
            SetColor("Shine2A", 30, Color.White);
            SetColor("Shine2B", Color.Transparent);
            SetColor("Shine3", 20, Color.White);
            SetColor("TextShade", 50, Color.Black);
            SetColor("Text", Color.White);
            SetColor("Glow", 10, Color.White);
            SetColor("Border", 20, 40, 70);
            SetColor("Corners", 20, 40, 70);
        }

        // Token: 0x0600003B RID: 59 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
        protected override void ColorHook()
        {
            C1 = GetColor("DownGradient1");
            C2 = GetColor("DownGradient2");
            C3 = GetColor("NoneGradient1");
            C4 = GetColor("NoneGradient2");
            C5 = GetColor("Shine2A");
            C6 = GetColor("Shine2B");
            C7 = GetColor("Corners");
            P1 = new Pen(GetColor("Shine1"));
            P2 = new Pen(GetColor("Shine3"));
            P3 = new Pen(GetColor("Border"));
            B1 = new SolidBrush(GetColor("TextShade"));
            B2 = new SolidBrush(GetColor("Text"));
            B3 = new SolidBrush(GetColor("Glow"));
        }

        // Token: 0x0600003C RID: 60 RVA: 0x0000CAEC File Offset: 0x0000ACEC
        protected override void PaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(C1, C2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(C3, C4, ClientRectangle, 90f);
            }
            graphics_0.DrawLine(P1, 1, 1, Width, 1);
            DrawGradient(C5, C6, 1, 1, 1, Height);
            DrawGradient(C5, C6, Width - 2, 1, 1, Height);
            graphics_0.DrawLine(P2, 1, Height - 2, Width, Height - 2);
            if (State == MouseState.Down)
            {
                DrawText(B1, HorizontalAlignment.Center, 2, 2);
                DrawText(B2, HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                DrawText(B1, HorizontalAlignment.Center, 1, 1);
                DrawText(B2, HorizontalAlignment.Center, 0, 0);
            }
            if (State == MouseState.Over)
            {
                graphics_0.FillRectangle(B3, ClientRectangle);
            }
            DrawBorders(P3);
            DrawCorners(C7, 1, 1, Width - 2, Height - 2);
            DrawCorners(BackColor);
        }

        // Token: 0x0400005E RID: 94
        private Color C1;

        // Token: 0x0400005F RID: 95
        private Color C2;

        // Token: 0x04000060 RID: 96
        private Color C3;

        // Token: 0x04000061 RID: 97
        private Color C4;

        // Token: 0x04000062 RID: 98
        private Color C5;

        // Token: 0x04000063 RID: 99
        private Color C6;

        // Token: 0x04000064 RID: 100
        private Color C7;

        // Token: 0x04000065 RID: 101
        private Pen P1;

        // Token: 0x04000066 RID: 102
        private Pen P2;

        // Token: 0x04000067 RID: 103
        private Pen P3;

        // Token: 0x04000068 RID: 104
        private SolidBrush B1;

        // Token: 0x04000069 RID: 105
        private SolidBrush B2;

        // Token: 0x0400006A RID: 106
        private SolidBrush B3;
    }
}
