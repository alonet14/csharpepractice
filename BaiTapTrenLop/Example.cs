namespace BaiTapTrenLop
{
    public class Example
    {
        class Size
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Size() { }
            public Size(int width, int heigth)
            {
                this.Width = width;
                this.Height = heigth;
            }
        }
        class Rect
        {
            public Point Location { get; set; }
            public Size Size { get; set; }
            public Rect() { }
            public Rect(int x, int y, int width, int height)
                : this(new Point(x, y), new Size(width, height))
            {
            }
            public Rect(Point location, Size size)
            {
                this.Location = location;
                this.Size = size;
            }

            // Các bộ xử lý tọa độ
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; }
            public int Bottom { get; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int CenterX { get; set; }
            public int CenterY { get; set; }
            public Point Center { get; }

            // Các toán tử ép kiểu
            public static explicit operator System.Drawing.Rectangle(Rect source)
            {
                return new System.Drawing.Rectangle(source.Left, source.Top, source.Width, source.Height);
            }
            public static explicit operator System.Drawing.RectangleF(Rect source)
            {
                return new System.Drawing.RectangleF(source.Left, source.Top, source.Width, source.Height);
            }

            // Các toán tử số học
            public static Size operator / (Rect source, int divider)
            {
                return new Size(source.Width / divider, source.Height / divider);
            }
            public static Size operator * (Rect source, int multiplier)
            {
                return new Size(source.Width * multiplier, source.Height * multiplier);
            }
            public static Rect operator << (Rect source, int n)
            {
                source.Size = source * (1 << n);
                return source;
            }
            public static Rect operator >> (Rect source, int n)
            {
                source.Size = source * (1 >> n);
                return source;
            }
        }
    }
}