using System.Text;
using System.Threading.Tasks.Dataflow;

namespace BaiTapTrenLop
{
    public class NameHandle
    {
        private string name;
        public NameHandle(){}
        public string Name { get; set; }

        public string HandleName(string data = "")
        {
            string value = string.Empty;
            //format utf-8
            byte[] bytes = Encoding.Default.GetBytes(data);
            value = Encoding.UTF8.GetString(bytes);
           
            if (data != null)
            {
                value = value.ToUpper();
                value = value.Trim();

            }
            return value;
        }
    }
}