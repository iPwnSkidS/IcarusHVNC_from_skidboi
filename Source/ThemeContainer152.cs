using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace BirdBrainmofo
{
    internal abstract class ThemeContainer152 : ContainerControl
    {
        private Rectangle Header;

        protected MouseState State;

        private bool WM_LMBUTTONDOWN;

        private Point GetIndexPoint;

        private bool B1;

        private bool B2;

        private bool B3;

        private bool B4;

        private int Current;

        private int Previous;

        private Message[] Messages = new Message[9];

        private bool _SmartBounds = true;

        private bool _Movable = true;

        private bool _Sizable = true;

        private Color _TransparencyKey;

        private FormBorderStyle _BorderStyle;

        private bool _NoRounding;

        private Image _Image;

        private Size _ImageSize;

        private bool _IsParentForm;

        private int _LockWidth;

        private int _LockHeight;

        private int _MoveHeight = 24;

        private bool _ControlMode;

        private Dictionary<string, Color> Items = new Dictionary<string, Color>();

        private string _Customization;

        private Point CenterReturn;

        private Bitmap MeasureBitmap;

        private Graphics MeasureGraphics;

        private SolidBrush DrawCornersBrush;

        private Point DrawTextPoint;

        private Size DrawTextSize;

        private Point DrawImagePoint;

        private LinearGradientBrush DrawGradientBrush;

        private Rectangle DrawGradientRectangle;

        protected Graphics graphics_0;

        public override DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                if (_ControlMode)
                {
                    base.Dock = value;
                }
            }
        }

        [Category("Misc")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                if (value == BackColor)
                {
                    return;
                }
                base.BackColor = value;
                if (Parent != null)
                {
                    if (!_ControlMode)
                    {
                        Parent.BackColor = value;
                    }
                    ColorHook();
                }
            }
        }

        public override Size MinimumSize
        {
            get
            {
                return base.MinimumSize;
            }
            set
            {
                base.MinimumSize = value;
                if (Parent != null)
                {
                    Parent.MinimumSize = value;
                }
            }
        }

        public override Size MaximumSize
        {
            get
            {
                return base.MaximumSize;
            }
            set
            {
                base.MaximumSize = value;
                if (Parent != null)
                {
                    Parent.MaximumSize = value;
                }
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get
            {
                return Color.Empty;
            }
            set
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Image BackgroundImage
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return ImageLayout.None;
            }
            set
            {
            }
        }

        public bool SmartBounds
        {
            get
            {
                return _SmartBounds;
            }
            set
            {
                _SmartBounds = value;
            }
        }

        public bool Movable
        {
            get
            {
                return _Movable;
            }
            set
            {
                _Movable = value;
            }
        }

        public bool Sizable
        {
            get
            {
                return _Sizable;
            }
            set
            {
                _Sizable = value;
            }
        }

        public Color TransparencyKey
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                {
                    return ParentForm.TransparencyKey;
                }
                return _TransparencyKey;
            }
            set
            {
                if (!(value == _TransparencyKey))
                {
                    _TransparencyKey = value;
                    if (_IsParentForm && !_ControlMode)
                    {
                        ParentForm.TransparencyKey = value;
                        ColorHook();
                    }
                }
            }
        }

        public FormBorderStyle BorderStyle
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                {
                    return ParentForm.FormBorderStyle;
                }
                return _BorderStyle;
            }
            set
            {
                _BorderStyle = value;
                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.FormBorderStyle = value;
                    if (value != 0)
                    {
                        Movable = false;
                        Sizable = false;
                    }
                }
            }
        }

        public bool NoRounding
        {
            get
            {
                return _NoRounding;
            }
            set
            {
                _NoRounding = value;
                Invalidate();
            }
        }

        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }
                _Image = value;
                Invalidate();
            }
        }

        protected Size ImageSize => _ImageSize;

        protected bool IsParentForm => _IsParentForm;

        protected bool IsParentMdi
        {
            get
            {
                if (Parent == null)
                {
                    return false;
                }
                return Parent.Parent != null;
            }
        }

        protected int LockWidth
        {
            get
            {
                return _LockWidth;
            }
            set
            {
                _LockWidth = value;
                if (LockWidth != 0 && IsHandleCreated)
                {
                    Width = LockWidth;
                }
            }
        }

        protected int LockHeight
        {
            get
            {
                return _LockHeight;
            }
            set
            {
                _LockHeight = value;
                if (LockHeight != 0 && IsHandleCreated)
                {
                    Height = LockHeight;
                }
            }
        }

        protected int MoveHeight
        {
            get
            {
                return _MoveHeight;
            }
            set
            {
                if (value >= 8)
                {
                    Header = new Rectangle(7, 7, Width - 14, value - 7);
                    _MoveHeight = value;
                    Invalidate();
                }
            }
        }

        protected bool ControlMode
        {
            get
            {
                return _ControlMode;
            }
            set
            {
                _ControlMode = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Bloom[] Colors
        {
            get
            {
                List<Bloom> list = new List<Bloom>();
                Dictionary<string, Color>.Enumerator enumerator = Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    list.Add(new Bloom(enumerator.Current.Key, enumerator.Current.Value));
                }
                return list.ToArray();
            }
            set
            {
                foreach (Bloom bloom in value)
                {
                    if (Items.ContainsKey(bloom.Name))
                    {
                        Items[bloom.Name] = bloom.Value;
                    }
                }
                InvalidateCustimization();
                ColorHook();
                Invalidate();
            }
        }

        public string Customization
        {
            get
            {
                return _Customization;
            }
            set
            {
                if (value == _Customization)
                {
                    return;
                }
                byte[] array = null;
                Bloom[] colors = Colors;
                try
                {
                    array = Convert.FromBase64String(value);
                    for (int i = 0; i <= colors.Length - 1; i++)
                    {
                        colors[i].Value = Color.FromArgb(BitConverter.ToInt32(array, i * 4));
                    }
                }
                catch
                {
                    return;
                }
                _Customization = value;
                Colors = colors;
                ColorHook();
                Invalidate();
            }
        }

        public ThemeContainer152()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            _ImageSize = Size.Empty;
            MeasureBitmap = new Bitmap(1, 1);
            MeasureGraphics = Graphics.FromImage(MeasureBitmap);
            Font = new Font("Verdana", 8f);
            InvalidateCustimization();
        }

        protected override void SetBoundsCore(int int_0, int int_1, int width, int height, BoundsSpecified specified)
        {
            if (_LockWidth != 0)
            {
                width = _LockWidth;
            }
            if (_LockHeight != 0)
            {
                height = _LockHeight;
            }
            base.SetBoundsCore(int_0, int_1, width, height, specified);
        }

        protected sealed override void OnSizeChanged(EventArgs eventArgs_0)
        {
            if (_Movable && !_ControlMode)
            {
                Header = new Rectangle(7, 7, Width - 14, _MoveHeight - 7);
            }
            Invalidate();
            base.OnSizeChanged(eventArgs_0);
        }

        protected sealed override void OnPaint(PaintEventArgs pevent)
        {
            if (Width != 0 && Height != 0)
            {
                graphics_0 = pevent.Graphics;
                PaintHook();
            }
        }

        protected sealed override void OnHandleCreated(EventArgs eventArgs_0)
        {
            InvalidateCustimization();
            ColorHook();
            if (_LockWidth != 0)
            {
                Width = _LockWidth;
            }
            if (_LockHeight != 0)
            {
                Height = _LockHeight;
            }
            if (!_ControlMode)
            {
                base.Dock = DockStyle.Fill;
            }
            base.OnHandleCreated(eventArgs_0);
        }

        protected sealed override void OnParentChanged(EventArgs eventArgs_0)
        {
            base.OnParentChanged(eventArgs_0);
            if (Parent == null)
            {
                return;
            }
            _IsParentForm = Parent is Form;
            if (!_ControlMode)
            {
                InitializeMessages();
                if (_IsParentForm)
                {
                    ParentForm.FormBorderStyle = _BorderStyle;
                    ParentForm.TransparencyKey = _TransparencyKey;
                }
                Parent.BackColor = BackColor;
            }
            OnCreation();
        }

        protected virtual void OnCreation()
        {
        }

        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if ((!_IsParentForm || ParentForm.WindowState != FormWindowState.Maximized) && _Sizable && !_ControlMode)
            {
                InvalidateMouse();
            }
            base.OnMouseMove(mevent);
        }

        protected override void OnEnabledChanged(EventArgs eventArgs_0)
        {
            if (Enabled)
            {
                SetState(MouseState.None);
            }
            else
            {
                SetState(MouseState.Block);
            }
            base.OnEnabledChanged(eventArgs_0);
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            SetState(MouseState.Over);
            base.OnMouseEnter(eventargs);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            SetState(MouseState.Over);
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseLeave(EventArgs eventargs)
        {
            SetState(MouseState.None);
            if (GetChildAtPoint(PointToClient(MousePosition)) != null && _Sizable && !_ControlMode)
            {
                Cursor = Cursors.Default;
                Previous = 0;
            }
            base.OnMouseLeave(eventargs);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left)
            {
                SetState(MouseState.Down);
            }
            if ((!_IsParentForm || ParentForm.WindowState != FormWindowState.Maximized) && !_ControlMode)
            {
                if (_Movable && Header.Contains(mevent.Location))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[0]);
                }
                else if (_Sizable && Previous != 0)
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[Previous]);
                }
            }
            base.OnMouseDown(mevent);
        }

        protected override void WndProc(ref Message message_0)
        {
            base.WndProc(ref message_0);
            if (!WM_LMBUTTONDOWN || message_0.Msg != 513)
            {
                return;
            }
            WM_LMBUTTONDOWN = false;
            SetState(MouseState.Over);
            if (_SmartBounds)
            {
                if (IsParentMdi)
                {
                    CorrectBounds(new Rectangle(Point.Empty, Parent.Parent.Size));
                }
                else
                {
                    CorrectBounds(Screen.FromControl(Parent).WorkingArea);
                }
            }
        }

        private int GetIndex()
        {
            GetIndexPoint = PointToClient(MousePosition);
            B1 = GetIndexPoint.X < 7;
            B2 = GetIndexPoint.X > Width - 7;
            B3 = GetIndexPoint.Y < 7;
            B4 = GetIndexPoint.Y > Height - 7;
            if (B1 && B3)
            {
                return 4;
            }
            if (B1 && B4)
            {
                return 7;
            }
            if (B2 && B3)
            {
                return 5;
            }
            if (B2 && B4)
            {
                return 8;
            }
            if (B1)
            {
                return 1;
            }
            if (B2)
            {
                return 2;
            }
            if (B3)
            {
                return 3;
            }
            if (B4)
            {
                return 6;
            }
            return 0;
        }

        private void InvalidateMouse()
        {
            Current = GetIndex();
            if (Current != Previous)
            {
                Previous = Current;
                switch (Previous)
                {
                    case 0:
                        Cursor = Cursors.Default;
                        break;
                    case 1:
                    case 2:
                        Cursor = Cursors.SizeWE;
                        break;
                    case 3:
                    case 6:
                        Cursor = Cursors.SizeNS;
                        break;
                    case 5:
                    case 7:
                        Cursor = Cursors.SizeNESW;
                        break;
                    case 4:
                    case 8:
                        Cursor = Cursors.SizeNWSE;
                        break;
                }
            }
        }

        private void InitializeMessages()
        {
            Messages[0] = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
            for (int i = 1; i <= 8; i++)
            {
                Messages[i] = Message.Create(Parent.Handle, 161, new IntPtr(i + 9), IntPtr.Zero);
            }
        }

        private void CorrectBounds(Rectangle bounds)
        {
            if (Parent.Width > bounds.Width)
            {
                Parent.Width = bounds.Width;
            }
            if (Parent.Height > bounds.Height)
            {
                Parent.Height = bounds.Height;
            }
            int num = Parent.Location.X;
            int num2 = Parent.Location.Y;
            if (num < bounds.X)
            {
                num = bounds.X;
            }
            if (num2 < bounds.Y)
            {
                num2 = bounds.Y;
            }
            int num3 = bounds.X + bounds.Width;
            int num4 = bounds.Y + bounds.Height;
            if (num + Parent.Width > num3)
            {
                num = num3 - Parent.Width;
            }
            if (num2 + Parent.Height > num4)
            {
                num2 = num4 - Parent.Height;
            }
            Parent.Location = new Point(num, num2);
        }

        protected Color GetColor(string name)
        {
            return Items[name];
        }

        protected void SetColor(string name, Color value)
        {
            if (Items.ContainsKey(name))
            {
                Items[name] = value;
            }
            else
            {
                Items.Add(name, value);
            }
        }

        protected void SetColor(string name, byte byte_0, byte byte_1, byte byte_2)
        {
            SetColor(name, Color.FromArgb(byte_0, byte_1, byte_2));
        }

        protected void SetColor(string name, byte byte_0, byte byte_1, byte byte_2, byte byte_3)
        {
            SetColor(name, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
        }

        protected void SetColor(string name, byte byte_0, Color value)
        {
            SetColor(name, Color.FromArgb(byte_0, value));
        }

        private void InvalidateCustimization()
        {
            MemoryStream memoryStream = new MemoryStream(Items.Count * 4);
            Bloom[] colors = Colors;
            for (int i = 0; i < colors.Length; i++)
            {
                memoryStream.Write(BitConverter.GetBytes(colors[i].Value.ToArgb()), 0, 4);
            }
            memoryStream.Close();
            _Customization = Convert.ToBase64String(memoryStream.ToArray());
        }

        protected abstract void ColorHook();

        protected abstract void PaintHook();

        protected Point Center(Rectangle r1, Size s1)
        {
            CenterReturn = new Point(r1.Width / 2 - s1.Width / 2 + r1.X, r1.Height / 2 - s1.Height / 2 + r1.Y);
            return CenterReturn;
        }

        protected Point Center(Rectangle r1, Rectangle r2)
        {
            return Center(r1, r2.Size);
        }

        protected Point Center(int w1, int h1, int w2, int h2)
        {
            CenterReturn = new Point(w1 / 2 - w2 / 2, h1 / 2 - h2 / 2);
            return CenterReturn;
        }

        protected Point Center(Size s1, Size s2)
        {
            return Center(s1.Width, s1.Height, s2.Width, s2.Height);
        }

        protected Point Center(Rectangle r1)
        {
            return Center(ClientRectangle.Width, ClientRectangle.Height, r1.Width, r1.Height);
        }

        protected Point Center(Size s1)
        {
            return Center(Width, Height, s1.Width, s1.Height);
        }

        protected Point Center(int w1, int h1)
        {
            return Center(Width, Height, w1, h1);
        }

        protected Size Measure(string text)
        {
            return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
        }

        protected Size Measure()
        {
            return MeasureGraphics.MeasureString(Text, Font).ToSize();
        }

        protected void DrawCorners(Color c1)
        {
            DrawCorners(c1, 0, 0, Width, Height);
        }

        protected void DrawCorners(Color c1, Rectangle r1)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }

        protected void DrawCorners(Color c1, int int_0, int int_1, int width, int height)
        {
            if (!_NoRounding)
            {
                DrawCornersBrush = new SolidBrush(c1);
                graphics_0.FillRectangle(DrawCornersBrush, int_0, int_1, 1, 1);
                graphics_0.FillRectangle(DrawCornersBrush, int_0 + (width - 1), int_1, 1, 1);
                graphics_0.FillRectangle(DrawCornersBrush, int_0, int_1 + (height - 1), 1, 1);
                graphics_0.FillRectangle(DrawCornersBrush, int_0 + (width - 1), int_1 + (height - 1), 1, 1);
            }
        }

        protected void DrawBorders(Pen p1, int int_0, int int_1, int width, int height, int offset)
        {
            DrawBorders(p1, int_0 + offset, int_1 + offset, width - offset * 2, height - offset * 2);
        }

        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }

        protected void DrawBorders(Pen p1, Rectangle rectangle_0, int offset)
        {
            DrawBorders(p1, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, offset);
        }

        protected void DrawBorders(Pen p1, int int_0, int int_1, int width, int height)
        {
            graphics_0.DrawRectangle(p1, int_0, int_1, width - 1, height - 1);
        }

        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }

        protected void DrawBorders(Pen p1, Rectangle rectangle_0)
        {
            DrawBorders(p1, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
        }

        protected void DrawText(Brush b1, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1)
        {
            DrawText(b1, Text, horizontalAlignment_0, int_0, int_1);
        }

        protected void DrawText(Brush b1, Point p1)
        {
            DrawText(b1, Text, p1.X, p1.Y);
        }

        protected void DrawText(Brush b1, int int_0, int int_1)
        {
            DrawText(b1, Text, int_0, int_1);
        }

        protected void DrawText(Brush b1, string text, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1)
        {
            if (text.Length != 0)
            {
                DrawTextSize = Measure(text);
                if (_ControlMode)
                {
                    DrawTextPoint = Center(DrawTextSize);
                }
                else
                {
                    DrawTextPoint = new Point(Width / 2 - DrawTextSize.Width / 2, MoveHeight / 2 - DrawTextSize.Height / 2);
                }
                switch (horizontalAlignment_0)
                {
                    case HorizontalAlignment.Left:
                        DrawText(b1, text, int_0, DrawTextPoint.Y + int_1);
                        break;
                    case HorizontalAlignment.Right:
                        DrawText(b1, text, Width - DrawTextSize.Width - int_0, DrawTextPoint.Y + int_1);
                        break;
                    case HorizontalAlignment.Center:
                        DrawText(b1, text, DrawTextPoint.X + int_0, DrawTextPoint.Y + int_1);
                        break;
                }
            }
        }

        protected void DrawText(Brush b1, string text, Point p1)
        {
            DrawText(b1, text, p1.X, p1.Y);
        }

        protected void DrawText(Brush b1, string text, int int_0, int int_1)
        {
            if (text.Length != 0)
            {
                graphics_0.DrawString(text, Font, b1, int_0, int_1);
            }
        }

        protected void DrawImage(HorizontalAlignment horizontalAlignment_0, int int_0, int int_1)
        {
            DrawImage(_Image, horizontalAlignment_0, int_0, int_1);
        }

        protected void DrawImage(Point p1)
        {
            DrawImage(_Image, p1.X, p1.Y);
        }

        protected void DrawImage(int int_0, int int_1)
        {
            DrawImage(_Image, int_0, int_1);
        }

        protected void DrawImage(Image image, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1)
        {
            if (image != null)
            {
                if (_ControlMode)
                {
                    DrawImagePoint = Center(image.Size);
                }
                else
                {
                    DrawImagePoint = new Point(Width / 2 - image.Width / 2, MoveHeight / 2 - image.Height / 2);
                }
                switch (horizontalAlignment_0)
                {
                    case HorizontalAlignment.Left:
                        DrawImage(image, int_0, DrawImagePoint.Y + int_1);
                        break;
                    case HorizontalAlignment.Right:
                        DrawImage(image, Width - image.Width - int_0, DrawImagePoint.Y + int_1);
                        break;
                    case HorizontalAlignment.Center:
                        DrawImage(image, DrawImagePoint.X + int_0, DrawImagePoint.Y + int_1);
                        break;
                }
            }
        }

        protected void DrawImage(Image image, Point p1)
        {
            DrawImage(image, p1.X, p1.Y);
        }

        protected void DrawImage(Image image, int int_0, int int_1)
        {
            if (image != null)
            {
                graphics_0.DrawImage(image, int_0, int_1, image.Width, image.Height);
            }
        }

        protected void DrawGradient(ColorBlend blend, int int_0, int int_1, int width, int height)
        {
            DrawGradient(blend, int_0, int_1, width, height, 90f);
        }

        protected void DrawGradient(Color c1, Color c2, int int_0, int int_1, int width, int height)
        {
            DrawGradient(c1, c2, int_0, int_1, width, height, 90f);
        }

        protected void DrawGradient(ColorBlend blend, int int_0, int int_1, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(int_0, int_1, width, height);
            DrawGradient(blend, DrawGradientRectangle, angle);
        }

        protected void DrawGradient(Color c1, Color c2, int int_0, int int_1, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(int_0, int_1, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle, angle);
        }

        protected void DrawGradient(ColorBlend blend, Rectangle rectangle_0, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(rectangle_0, Color.Empty, Color.Empty, angle);
            DrawGradientBrush.InterpolationColors = blend;
            graphics_0.FillRectangle(DrawGradientBrush, rectangle_0);
        }

        protected void DrawGradient(Color c1, Color c2, Rectangle rectangle_0, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(rectangle_0, c1, c2, angle);
            graphics_0.FillRectangle(DrawGradientBrush, rectangle_0);
        }
    }
}
