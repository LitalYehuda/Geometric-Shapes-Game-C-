using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricShapes
{
    public partial class FormResults : Form //טופס הצגת תוצאות המשחק
    {
        string fileName;

        public FormResults(string str) //בנאי מלא המקבל מחרוזת עם שם התקייה שנוצרה עבור אותו שחקן  
        {
            InitializeComponent();
            fileName = str; 
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור סגירת הטופס
        {
            this.Close();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader(fileName); //קריאה מתוך הקובץ הרלוונטי שנוצר עובר משחק ספציפי ועבור שחקן ספציפי
            txtResult.Text= "\r\n\r\n" +stream.ReadToEnd(); //הצגת התוצאות לשחקן
            stream.Close();
        }

    }
}
