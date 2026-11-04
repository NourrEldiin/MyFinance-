using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    [Flags]
    public enum RoundedCorners
    {
        None = 0,
        TopLeft = 1,
        TopRight = 2,
        BottomRight = 4,
        BottomLeft = 8,
        All = 15
    }

    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 12;
        private RoundedCorners _corners = RoundedCorners.All;
        private Color _fillColor = Color.White;
        private Color _borderColor = Color.Empty;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public RoundedCorners Corners
        {
            get => _corners;
            set { _corners = value; Invalidate(); }
        }

        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new RectangleF(0.5f, 0.5f, Width - 1f, Height - 1f);
            using (var path = CreatePath(rect, _cornerRadius, _corners))
            {
                using (var brush = new SolidBrush(_fillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (_borderColor != Color.Empty)
                {
                    using (var pen = new Pen(_borderColor, 1f))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private static GraphicsPath CreatePath(RectangleF r, int radius, RoundedCorners corners)
        {
            var path = new GraphicsPath();
            float d = Math.Min(radius * 2f, Math.Min(r.Width, r.Height));

            if (d <= 0)
            {
                path.AddRectangle(r);
                return path;
            }

            float x = r.X, y = r.Y, w = r.Width, h = r.Height;

            if (corners.HasFlag(RoundedCorners.TopLeft))
                path.AddArc(x, y, d, d, 180, 90);
            else
                path.AddLine(x, y, x, y);

            if (corners.HasFlag(RoundedCorners.TopRight))
                path.AddArc(x + w - d, y, d, d, 270, 90);
            else
                path.AddLine(x + w, y, x + w, y);

            if (corners.HasFlag(RoundedCorners.BottomRight))
                path.AddArc(x + w - d, y + h - d, d, d, 0, 90);
            else
                path.AddLine(x + w, y + h, x + w, y + h);

            if (corners.HasFlag(RoundedCorners.BottomLeft))
                path.AddArc(x, y + h - d, d, d, 90, 90);
            else
                path.AddLine(x, y + h, x, y + h);

            path.CloseFigure();
            return path;
        }
    }
}