using System;
using System.Text;
using static BaiTapTrenLop.Point;
using static BaiTapTrenLop.Retangle;
using static BaiTapTrenLop.NameHandle;

namespace BaiTapTrenLop
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Console.OutputEncoding = Encoding.UTF8;
            // NameHandle nameHandle = new NameHandle();
            // string name = "   Nguyễn Việt Hoàng     ";
            // string handledName = nameHandle.HandleName(name);
            // Console.WriteLine(handledName);
            // DateTime dateTime = new DateTime();
            // string dataDateTime = "   05 09 1999";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();
           
            // byte[] bytes = Encoding.Default.GetBytes(data);
            // value = Encoding.UTF8.GetString(bytes);
            
            name = name.Trim();//bỏ khoảng trắng ở đầu và cuối
            
            
            //2 khoảng trắng liên tiếp thành 1 khoảng trắng
            // while(name.IndexOf("  ") != -1)
            // {
            //     name = name.Replace("  ", " ");
            // }

            //lấy ra các từ trong tên
            string[] subName = name.Split(' ');
            for (int i = 0; i < subName.Length; i++)
            {
                string firstChar = subName[i].Substring(0, 1); 
                string otherChars = subName[i].Substring(1);    
                subName[i] = firstChar.ToUpper() + otherChars.ToLower();
            }

            string tenChuanHoa = subName[0];
            for (int i = 1; i < subName.Length; i++)
            {
                tenChuanHoa += " " + subName[i];
            }

            Console.WriteLine("Tên chuẩn hoá: "+ tenChuanHoa);
            
        }
    }
}