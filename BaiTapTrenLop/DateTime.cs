
using System;
using BaiTapTrenLop;
namespace BaiTapTrenLop
{
    public class DateTime
    {
        public string FormatDateAndMonth(int value)
        {
            return value >0 && value <10? value.ToString(): "0" + value.ToString();
        }
        public DateTimeModel DateTimeHandle(string data = "")
        {
            string value = string.Empty;
            DateTimeModel dateTimeModel = new DateTimeModel();
            if (data.Length != 0)
            {
                value = data.Trim();
                string number = "";
                foreach (char c in value)
                {
                    char space = (char) 32;
                    if (c == space)
                    {
                        continue;
                    }
                    number += c;
                    
                }

                if (number.Length == 8)
                {
                    dateTimeModel.Date = number.Substring(0, 2);
                    dateTimeModel.Month = number.Substring(2, 2);
                    dateTimeModel.Year = number.Substring(4, 4);
                }

                if (number.Length == 7)
                {

                    dateTimeModel.Year = number.Substring(3, 4);
                }

                if (number.Length == 6)
                {
                    
                }
                

            }
            return dateTimeModel;
        }
    }
}