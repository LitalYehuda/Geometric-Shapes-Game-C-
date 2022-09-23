using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class DataItem : IComparable // מחלקת בסיס של פריט מידע
    {
        protected int number;
        protected string topic;
        protected string content;

        public DataItem(int number, string topic, string content)
        {
            this.Number = number;
            this.Topic = topic;
            this.Content = content;
        }

        public string Topic { get => topic; set => topic = value; }
        public string Content { get => content; set => content = value; } 
        public int Number
        {
            get => number;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The item number canot be negative");
                }
                number = value;
            }
        }

        public int CompareTo(Object obj) //מתודת השוואה בין 2 פריטים ע"י שדה content
        {
            DataItem item = (DataItem)obj;
            return content.CompareTo(item.content);
        }

        public override string ToString()
        {
            return "\r\n" + this.number + ";" + this.topic + ";" + this.content;
        }
    }
}
