using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class DataItemWImage : DataItem // מחלקה נגזרת של מחלקת פריט מידע
    {
        protected Image image;

        public DataItemWImage(int number, string topic, string content, Image image) : base(number, topic, content)
        {
            this.image = image; 
        }

        public Image Image { get => image; set => image = value; }
    }

}
