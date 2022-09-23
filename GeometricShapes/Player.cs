using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Player //מחלקת משתמש 
    {
        protected readonly string nickName; 
        protected string userEmail;
        protected string date;
        protected string path;

        public Player(string userEmail) //בנאי שיוצר קובץ סטטיסטיקת שחקן ספיצי בתאריך ספציפי
        {
            this.UserEmail = userEmail;
            nickName = userEmail.Split('@')[0];
            Date = (DateTime.Now.ToString("yyyy-MM-dd'T'HH':'mm':'ss")).Replace(':', '_') + ".txt"; //שמירת שם הקובץ עפ"י datetime
            if (Directory.Exists("DATA\\PLAYERS\\" + nickName) == false) // בדיקה האם תקייה של שם המשתמש הנוכחי קיימת, במידה ולא- נוצרת תקייה חדשה עם שמו
            {
                Directory.CreateDirectory("DATA\\PLAYERS\\" + nickName);
            }
            Path = $"DATA\\PLAYERS\\{nickName}\\" + nickName + "_" + Date; 
            File.Create(Path).Close();
        }

        public string NickName => nickName;
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string Date { get => date; set => date = value; }
        public string Path { get => path; set => path = value; }

    }
}
