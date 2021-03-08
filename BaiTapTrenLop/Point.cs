using System;


namespace BaiTapTrenLop
{
    public class Point
    {
        int x; // Thuộc tính private
        public int X
        {
            get => x; // Bộ đọc dữ liệu (get accessor)
            set => x = value; // Bộ ghi dữ liệu (set accessor)
        }
        public int Y { get; set; } // Hàm thuộc tính tự động (auto-implemented property)

        // Các hàm khởi tạo (constructors)
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x; // Cần từ khóa this để phân biệt với tham số
            Y = y; // Gọi bộ ghi
        }

        // Các phương thức (methods)
        public double Distance2(Point p)
        {
            int x = X - p.X; // Gọi bộ đọc và gán cho biến cục bộ
            int y = Y - p.Y;
            return x * x + y * y; // Sử dụng các biến cục bộ
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(this.Distance2(p));
        }    
        public Point Offset(int x, int y)
        {
            return new Point(X + x, Y + y); // Gọi constructor để tạo một đối tượng kiểu Point
        }
    
        // Viết lại phương thức của lớp cơ sở
        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
    }
}