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
    public partial class AddQuestion : Form //טופס הוספת שאלה
    {
        public AddQuestion()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(740, 550);
            Globals.LoadGameData(); //טעינת קובץ המידע של המשחק מחדש ועדכון המערך
            Show();
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

        private void Show() //מתודה שמציגה פקדים לפי סוג השאלה שאותה המשתמש רוצה להוסיף
        {
            if (ChooseQuestion.type == 1)
            {
                txtIncorrect2.Visible = true;
                lblIncorrect2.Visible = true;
            }
            else if(ChooseQuestion.type == 2)
            {
                pcbQuestion.Visible = true;
                btnAddPic.Visible = true;
            }
            return;
        }

        private void Clear() //מתודה שמאפסת את הפקדים 
        {
            txtAddQuestion.Text = "";
            txtCorrectAnswer.Text = "";
            txtIncorrect1.Text = "";
            txtIncorrect2.Text = "";
            pcbQuestion.Image = null;
        }

        private void btnAddPic_Click(object sender, EventArgs e) //כפתור העלאת תמונה מסייר קבצים
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pcbQuestion.ImageLocation = ofd.FileName;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)  //בדיקת תקינות נתונים
        {
            try
            {
                if (txtAddQuestion.Text == "" || txtCorrectAnswer.Text == "" || txtIncorrect1.Text == "") //בדיקה האם כל השדות מלאים
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
                // כתיבה לתוך הקובץ עפ"י סוג שאלה ושמירת תמונת השאלה בתקיית QIMAGES
                string rowNumber = (Globals.gameData.Count + 1).ToString();
                string newRow;
                if (txtIncorrect2.Text != "")
                {
                    newRow = "\r\n" + rowNumber + ';' + (int)Qtype.Multiple + ';' + txtAddQuestion.Text + ';' + txtCorrectAnswer.Text + ';' + txtIncorrect1.Text + ';' + txtIncorrect2.Text;
                }
                else if (pcbQuestion.ImageLocation != null)
                {
                    string image = rowNumber + "Question" + pcbQuestion.ImageLocation.Substring(pcbQuestion.ImageLocation.LastIndexOf('.'));
                    File.Copy(pcbQuestion.ImageLocation, "DATA\\QIMAGES\\" + image);
                    newRow = "\r\n" + rowNumber + ';' + (int)Qtype.TrueFalseWImage + ';' + txtAddQuestion.Text + ';' + txtCorrectAnswer.Text + ';' + txtIncorrect1.Text + ';' + image;
                }
                else
                {
                    newRow = "\r\n" + rowNumber + ';' + (int)Qtype.TrueFalse + ';' + txtAddQuestion.Text + ';' + txtCorrectAnswer.Text + ';' + txtIncorrect1.Text;
                }
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
