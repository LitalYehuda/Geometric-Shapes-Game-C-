using System;
using System.IO;
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
    public partial class StudyForm : Form //טופס חלק לימודי
    {
        int selectedRow = 0;
        List<DataItem> dataRand = new List<DataItem>(); //רשימת עזר עם 12 פריטים רנדומליים
        Random rand = new Random();

        public StudyForm()
        {
            InitializeComponent();
            btnBackwards.Visible = false;
        }

        private void StudyForm_Load(object sender, EventArgs e)
        {
            try
            {
                Globals.LoadInfoData(); //טעינת קובץ המידע מחדש ועדכון הרשימה

                int counter = 0;
                while(counter <12) //הוספת 12 פריטים רנדומליים לרשימת העזר
                {
                   int index = rand.Next(0, Globals.infoData.Count() - 1);
                  if (!dataRand.Contains(Globals.infoData[index])) //כל עוד השאלות לא חוזרת על עצמן
                  {
                    dataRand.Add(Globals.infoData[index]);
                    counter++;
                  }
                }
                LoadItem();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Insufficient memory to allocate a buffer for the returned string Exception");
            }
            catch (Exception m)
            {
                MessageBox.Show("Exception" + m.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e) //הודעה על סיום פעולת הלמידה
        {
            MessageBox.Show("Well Done! Now you are ready");
            this.Close();
        }

        private void btnBackwards_Click(object sender, EventArgs e) //מתודת דפדוף אחורה
        {
            btnForward.Visible = true;
            selectedRow--;
            if (selectedRow == 0)
                btnBackwards.Visible = false;
            LoadItem();
        }

        private void btnForward_Click(object sender, EventArgs e) //מתודת דפדוף קדימה
        {
            btnBackwards.Visible = true;
            selectedRow++;
            if (selectedRow == 11)
                btnForward.Visible = false;
            LoadItem();
        }

        private void LoadItem() //טעינת הפריט מרשימת העזר והצגתו למשתמש 
        {
            lblIndex.Text = "" + (selectedRow + 1) + "/12";
            txtShowContact.Text = dataRand[selectedRow].Content;
            lblShowTopic.Text = dataRand[selectedRow].Topic;

            if (dataRand[selectedRow] is DataItemWImage) //אופציית הצגת תמונה כשמדובר בפריט עם תמונה
            {
                pbxShowPic.Image = ((DataItemWImage)dataRand[selectedRow]).Image;
                pbxShowPic.Visible = true;
            }     
            else
                pbxShowPic.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור חזרה לתפריט הראשי
        {
            this.Close();
        }

    }
}
