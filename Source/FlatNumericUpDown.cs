using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000008 RID: 8
namespace BirdBrainmofo
{
    public class FlatNumericUpDown : NumericUpDown
    {
        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000022 RID: 34 RVA: 0x0000B91C File Offset: 0x00009B1C
        // (set) Token: 0x06000023 RID: 35 RVA: 0x000062D6 File Offset: 0x000044D6
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                if (borderColor != value)
                {
                    borderColor = value;
                    Invalidate();
                }
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000024 RID: 36 RVA: 0x0000B934 File Offset: 0x00009B34
        // (set) Token: 0x06000025 RID: 37 RVA: 0x000062F3 File Offset: 0x000044F3
        [DefaultValue(typeof(Color), "LightGray")]
        public Color ButtonHighlightColor
        {
            get
            {
                return buttonHighlightColor;
            }
            set
            {
                if (buttonHighlightColor != value)
                {
                    buttonHighlightColor = value;
                    Invalidate();
                }
            }
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00006310 File Offset: 0x00004510
        public FlatNumericUpDown()
        {
            new UpDownButtonRenderer(Controls[0]);
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000027 RID: 39 RVA: 0x0000B94C File Offset: 0x00009B4C
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 33554432;
                return createParams;
            }
        }

        // Token: 0x06000028 RID: 40 RVA: 0x0000B978 File Offset: 0x00009B78
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (BorderStyle == BorderStyle.FixedSingle)
            {
                using (Pen pen = new Pen(BorderColor, 1f))
                {
                    pevent.Graphics.DrawRectangle(pen, ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
                }
            }
        }

        // Token: 0x04000027 RID: 39
        private Color borderColor = Color.Gray;

        // Token: 0x04000028 RID: 40
        private Color buttonHighlightColor = Color.LightGray;

        // Token: 0x02000009 RID: 9
        private class UpDownButtonRenderer : NativeWindow
        {
            // Token: 0x06000029 RID: 41
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            private static extern IntPtr BeginPaint(IntPtr hWnd, [In] [Out] ref PAINTSTRUCT lpPaint);

            // Token: 0x0600002A RID: 42
            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

            // Token: 0x0600002B RID: 43 RVA: 0x0000BA0C File Offset: 0x00009C0C
            public UpDownButtonRenderer(Control control_0)
            {
                updown = control_0;
                if (updown.IsHandleCreated)
                {
                    AssignHandle(updown.Handle);
                }
                else
                {
                    updown.HandleCreated += delegate
                    {
                        AssignHandle(updown.Handle);
                    };
                }
            }

            // Token: 0x0600002C RID: 44 RVA: 0x0000BA60 File Offset: 0x00009C60
            private Point[] GetDownArrow(Rectangle rectangle_0)
            {
                Point point = new Point(rectangle_0.Left + rectangle_0.Width / 2, rectangle_0.Top + rectangle_0.Height / 2);
                return new[]
                {
                    new Point(point.X - 3, point.Y - 2),
                    new Point(point.X + 4, point.Y - 2),
                    new Point(point.X, point.Y + 2)
                };
            }

            // Token: 0x0600002D RID: 45 RVA: 0x0000BAF8 File Offset: 0x00009CF8
            private Point[] GetUpArrow(Rectangle rectangle_0)
            {
                Point point = new Point(rectangle_0.Left + rectangle_0.Width / 2, rectangle_0.Top + rectangle_0.Height / 2);
                return new[]
                {
                    new Point(point.X - 4, point.Y + 2),
                    new Point(point.X + 4, point.Y + 2),
                    new Point(point.X, point.Y - 3)
                };
            }

            // Token: 0x0600002E RID: 46 RVA: 0x0000BB90 File Offset: 0x00009D90
            protected override void WndProc(ref Message message_0)
            {
                if (message_0.Msg == 15 && ((FlatNumericUpDown)updown.Parent).BorderStyle == BorderStyle.FixedSingle)
                {
                    PAINTSTRUCT paintstruct = default(PAINTSTRUCT);
                    BeginPaint(updown.Handle, ref paintstruct);
                    using (Graphics graphics = Graphics.FromHdc(paintstruct.hdc))
                    {
                        bool enabled;
                        using (SolidBrush solidBrush = new SolidBrush((enabled = updown.Enabled) ? ((FlatNumericUpDown)updown.Parent).BackColor : SystemColors.Control))
                        {
                            graphics.FillRectangle(solidBrush, updown.ClientRectangle);
                        }
                        Rectangle rectangle = new Rectangle(0, 0, updown.Width, updown.Height / 2);
                        Rectangle rectangle2 = new Rectangle(0, updown.Height / 2, updown.Width, updown.Height / 2 + 1);
                        Point point = updown.PointToClient(MousePosition);
                        if (enabled && updown.ClientRectangle.Contains(point))
                        {
                            using (SolidBrush solidBrush2 = new SolidBrush(((FlatNumericUpDown)updown.Parent).ButtonHighlightColor))
                            {
                                if (rectangle.Contains(point))
                                {
                                    graphics.FillRectangle(solidBrush2, rectangle);
                                }
                                else
                                {
                                    graphics.FillRectangle(solidBrush2, rectangle2);
                                }
                            }
                            using (Pen pen = new Pen(((FlatNumericUpDown)updown.Parent).BorderColor))
                            {
                                graphics.DrawLines(pen, new[]
                                {
                                    new Point(0, 0),
                                    new Point(0, updown.Height),
                                    new Point(0, updown.Height / 2),
                                    new Point(updown.Width, updown.Height / 2)
                                });
                            }
                        }
                        graphics.FillPolygon(Brushes.Black, GetUpArrow(rectangle));
                        graphics.FillPolygon(Brushes.Black, GetDownArrow(rectangle2));
                    }
                    message_0.Result = (IntPtr)1;
                    base.WndProc(ref message_0);
                    EndPaint(updown.Handle, ref paintstruct);
                }
                else if (message_0.Msg == 20)
                {
                    using (Graphics graphics2 = Graphics.FromHdcInternal(message_0.WParam))
                    {
                        graphics2.FillRectangle(Brushes.White, updown.ClientRectangle);
                    }
                    message_0.Result = (IntPtr)1;
                }
                else
                {
                    base.WndProc(ref message_0);
                }
            }

            // Token: 0x0600002F RID: 47 RVA: 0x00006340 File Offset: 0x00004540
            [CompilerGenerated]
            private void b__4_0(object sender, EventArgs e)
            {
                AssignHandle(updown.Handle);
            }

            // Token: 0x04000029 RID: 41
            private Control updown;

            // Token: 0x0200000A RID: 10
            public struct PAINTSTRUCT
            {
                // Token: 0x0400002A RID: 42
                public IntPtr hdc;

                // Token: 0x0400002B RID: 43
                public bool fErase;

                // Token: 0x0400002C RID: 44
                public int rcPaint_left;

                // Token: 0x0400002D RID: 45
                public int rcPaint_top;

                // Token: 0x0400002E RID: 46
                public int rcPaint_right;

                // Token: 0x0400002F RID: 47
                public int rcPaint_bottom;

                // Token: 0x04000030 RID: 48
                public bool fRestore;

                // Token: 0x04000031 RID: 49
                public bool fIncUpdate;

                // Token: 0x04000032 RID: 50
                public int reserved1;

                // Token: 0x04000033 RID: 51
                public int reserved2;

                // Token: 0x04000034 RID: 52
                public int reserved3;

                // Token: 0x04000035 RID: 53
                public int reserved4;

                // Token: 0x04000036 RID: 54
                public int reserved5;

                // Token: 0x04000037 RID: 55
                public int reserved6;

                // Token: 0x04000038 RID: 56
                public int reserved7;

                // Token: 0x04000039 RID: 57
                public int reserved8;
            }
        }
    }
}
