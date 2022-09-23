using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricShapes
{
    public static class Globals //מחלקת עזר סטאטית המכילה מערך של שאלות ותשובות למשחק ורשימה של פרטי מידע
    {
        public static ArrayList gameData; //מערך של שאלות ותשובות למשחק טריוויה
        public static List<DataItem> infoData; //רשימה של פרטי מידע

        public static void LoadGameData() //קריאה מתוך קובץ השאלות והתשובות למשחק והוספת הנתונים למערך
        {
            gameData = new ArrayList();
            StreamReader stream = new StreamReader("DATA\\gameData.txt");
            while (!stream.EndOfStream)
            {
                string row = stream.ReadLine();
                string[] dataItem = row.Split(';');
                if (int.Parse(dataItem[1]) == 0) //הוספת שאלה ותשובות מסוג 0 למערך 
                {
                    Questions item0 = new Questions(int.Parse(dataItem[0]), (Qtype)int.Parse(dataItem[1]), dataItem[2], dataItem[3], dataItem[4]);
                    gameData.Add(item0);
                }
                else if (int.Parse(dataItem[1]) == 1) //הוספת שאלה ותשובןת מסוג 1 למערך 
                {
                    Questions item1 = new Questions(int.Parse(dataItem[0]), (Qtype)int.Parse(dataItem[1]), dataItem[2], dataItem[3], dataItem[4], dataItem[5]);
                    gameData.Add(item1);

                }
                else if (int.Parse(dataItem[1]) == 2) //הוספת שאלה כוללת תמונה ותשובות מסוג 2 למערך 
                {
                    Image image = Image.FromFile(Directory.GetCurrentDirectory() + @"\DATA\QIMAGES\" + dataItem[5]);
                    Questions item2 = new Questions(int.Parse(dataItem[0]), (Qtype)int.Parse(dataItem[1]), dataItem[2], dataItem[3], dataItem[4], image);
                    gameData.Add(item2);
                }
                else if (int.Parse(dataItem[1]) == 3) //הוספת שאלה ותשובות תמונה מסוג 3 למערך 
                {
                    Image image1 = Image.FromFile(Directory.GetCurrentDirectory() + @"\DATA\QIMAGES\" + dataItem[3]);
                    Image image2 = Image.FromFile(Directory.GetCurrentDirectory() + @"\DATA\QIMAGES\" + dataItem[4]);
                    Image image3 = Image.FromFile(Directory.GetCurrentDirectory() + @"\DATA\QIMAGES\" + dataItem[5]);
                    Questions item3 = new Questions(int.Parse(dataItem[0]), (Qtype)int.Parse(dataItem[1]), dataItem[2], image1, image2, image3);
                    gameData.Add(item3);
                }
            }
            stream.Close();
        }

        public static void LoadInfoData() //קריאה מתוך קובץ המידע והוספת הנתונים לרשימת הפריטים
        {
            infoData = new List<DataItem>();
            StreamReader stream = new StreamReader("DATA\\infoData.txt");
            while (!stream.EndOfStream)
            {
                string row = stream.ReadLine();
                string[] dataItem = row.Split(';');
                if (dataItem.Length == 3) //הוספת פריט לרשימה ללא תמונה
                {
                    DataItem item = new DataItem(int.Parse(dataItem[0]), dataItem[1], dataItem[2]);
                    infoData.Add(item);
                }
                else //הוספת פריט לרשימה עם תמונה
                {
                    Image image = Image.FromFile(Directory.GetCurrentDirectory() + @"\DATA\DIMAGES\" + dataItem[3]);
                    DataItemWImage item = new DataItemWImage(int.Parse(dataItem[0]), dataItem[1], dataItem[2], image);
                    infoData.Add(item);
                }
            }
            stream.Close();
        }
    }
}
