using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeometricShapes
{
    public partial class AddQuestionWImage : Form //טופס הוספת שאלה עם תמונה
    {
        public AddQuestionWImage()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(750, 600);
            Globals.LoadGameData();  //טעינת קובץ המידע של המשחק מחדש ועדכון המערך
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור חזרה לתפריט הקודם
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Addition didn't save", 
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Clear();
            }
        }

        private void btnCorrectAnswer_Click(object sender, EventArgs e) //כפתור העלאת תמונת תשובה נכונה מסייר קבצים
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcbCorrect.ImageLocation = ofd.FileName;
            }
        }

        private void btnIncorrect1_Click(object sender, EventArgs e) //כפתור העלאת תמונה שגויה 1 מסייר קבצים
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcbIncorrect1.ImageLocation = ofd.FileName;
            }
        }

        private void btnIncorrect2_Click(object sender, EventArgs e) //כפתור העלאת תמונה שגויה 2 מסייר קבצים
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcbIncorrect2.ImageLocation = ofd.FileName;
            }
        }

        private void Clear() //מתודה שמאפסת את הפקדים 
        {
            pcbIncorrect1.ImageLocation = null;
            pcbIncorrect2.ImageLocation = null;
            pcbCorrect.ImageLocation = null;
            txtAddQuestion.Text = "";
        }

        private void btnApprove_Click(object sender, EventArgs e) //בדיקת תקינות נתונים
        {
            try
            {
                if (txtAddQuestion.Text == "" || pcbCorrect.ImageLocation == null || 
                    pcbIncorrect2.ImageLocation == null || pcbIncorrect1.ImageLocation == null) //בדיקה האם כל השדות מלאים
                {
                    MessageBox.Show("All fields must be filled!");
                    return;
                }
                foreach (Questions item in Globals.gameData) //בדיקה האם השאלה לא קיימת כבר בקובץ
                {
                    if (item.Question == txtAddQuestion.Text)
                    {
                        MessageBox.Show("The question is already exist");
                        return;
                    }
                }

                // כתיבה לתוך הקובץ ושמירת תמונות בתקיית QIMAGES
                string prefix = (Globals.gameData.Count + 1).ToString();
                string image1 = prefix + "Correct" + pcbCorrect.ImageLocation.Substring(pcbCorrect.ImageLocation.LastIndexOf('.'));
                string image2 = prefix + "Incorrect1" + pcbIncorrect1.ImageLocation.Substring(pcbIncorrect1.ImageLocation.LastIndexOf('.'));
                string image3 = prefix + "Incorrect2" + pcbIncorrect2.ImageLocation.Substring(pcbIncorrect2.ImageLocation.LastIndexOf('.'));
                File.Copy(pcbCorrect.ImageLocation, "DATA\\QIMAGES\\" + image1);
                File.Copy(pcbIncorrect1.ImageLocation, "DATA\\QIMAGES\\" + image2);
                File.Copy(pcbIncorrect2.ImageLocation, "DATA\\QIMAGES\\" + image3);

                string newRow = "\r\n" + (Globals.gameData.Count + 1).ToString() + ';' + (int)Qtype.MultipleWImages + ';' + txtAddQuestion.Text + ';' + image1 + ';' + image2 + ';' + image3;
                File.AppendAllText("DATA\\gameData.txt", newRow);
                Globals.LoadGameData(); //טעינת קובץ המידע של המשחק מחדש ועדכון המערך

                MessageBox.Show("The question was added seccessfully");
                this.Close();
                Clear();
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
    }
}
