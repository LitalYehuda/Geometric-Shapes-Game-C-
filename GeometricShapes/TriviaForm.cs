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
    public partial class TriviaForm : Form //טופס משחק הטריוויה
    {
        int selectedRow = 0, tick = 0, score;
        Player player;
        List<Questions> dataRand = new List<Questions>(); //רשימת עזר עם 10 שאלות רנדומליות
        Random rand = new Random();
        Questions current;

        public TriviaForm()
        {
            InitializeComponent();
            score = 0;
            this.ClientSize = new System.Drawing.Size(730, 580);
            rbtAnswer1.Checked = false;
            rbtAnswer2.Checked = false;
            rbtAnswer3.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור חזרה לתפריט הקודם
        {
            DialogResult dr = MessageBox.Show("Are you sure?","The game didn't save",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                TriviaTimer.Stop();
                this.Close();
            }
        }

        private void TriviaForm_Load(object sender, EventArgs e) //טעינת קובץ השאלות והתשובות מחדש, עדכון המערך ויצירת רשימת עזר
        {
            try
            {
                Globals.LoadGameData(); //טעינת קובץ השאלות והתשובות מחדש ועדכון המערך

                int counter = 0;
                while (counter < 10) //הוספת 10 שאלות ותשובות רנדומליות לרשימת העזר
                {
                    int index = rand.Next(0, Globals.gameData.Count - 1);
                    if (!dataRand.Contains(Globals.gameData[index]))
                    {
                        dataRand.Add((Questions)Globals.gameData[index]);
                        counter++;
                    }
                }
                LoadQuestion();

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
            TriviaTimer.Start();
            tick = 0;
        }

        private void btnSaveGame_Click(object sender, EventArgs e) //שמירת פרטי המשחק, כתיבה לקובץ הסטטיסטיקה ויצירת שחקן עפ"י מייל האימות הראשוני
        {
            player= new Player(MainForm.userEmail);
            TriviaTimer.Stop();
            writeToFile();
            this.Close();
            this.Hide();
            FormResults results = new FormResults(player.Path); //מעבר לתוצאות המשחק
            results.ShowDialog();
        }

        private void TriviaTimer_Tick(object sender, EventArgs e) //מתודה שמציגה לשחקן את הזמן שהוא נמצא במשחק
        {
            tick++;
            txtTimer.Text = "" + tick;
        }

        private void btnForward_Click(object sender, EventArgs e) //מתודת דפדוף קדימה ובדיקת התשובה שנבחרה
        {
            selectedRow++;
            if (selectedRow == 9)
                btnForward.Visible = false;
            if (CheckAnswers() == true) //בדיקה האם התשובה שנבחרה היא הנכונה, במידה וכן הניקוד עולה בנקודה אחת
            {
                score++;
                txtScore.Text = score.ToString();
            }
            Clear();
            LoadQuestion();
        }

        private void LoadQuestion() //טעינת השאלה והתשובות מרשימת העזר על פי סוג השאלה והצגתן למשתמש 
        {
            lblIndex.Text = "" + (selectedRow + 1) + "/10";
            current = dataRand[selectedRow];
            txtQuestion.Text = current.Question;

            switch (dataRand[selectedRow].Qtype)
            {
                case Qtype.TrueFalse:
                    int res = Rendom2Answers(); //הגרלת סדר התשובות
                    rbtAnswer1.Text = current.TrueOrFalseAnswer()[res];
                    rbtAnswer2.Text = current.TrueOrFalseAnswer()[1-res];
                    break;

                case Qtype.TrueFalseWImage:
                    pbxPicQuestion.Image = current.ImageQuestion;
                    pbxPicQuestion.Visible = true;
                    res = Rendom2Answers(); //הגרלת סדר התשובות
                    rbtAnswer1.Text = current.TrueOrFalseAnswer()[res];
                    rbtAnswer2.Text = current.TrueOrFalseAnswer()[1 - res];
                    break;

                case Qtype.Multiple:
                    int first = Rendom3Answers(); //הגרלת סדר התשובות
                    int secnd = rand.Next(3);
                    while (secnd == first)
                        secnd = rand.Next(3);
                    rbtAnswer1.Text = current.MultipleAnswers()[first];
                    rbtAnswer2.Text = current.MultipleAnswers()[secnd];
                    rbtAnswer3.Text = current.MultipleAnswers()[3 - first - secnd];
                    break;

                case Qtype.MultipleWImages:
                    pcbAnswer1.Visible = true;
                    pcbAnswer2.Visible = true;
                    pcbAnswer3.Visible = true;
                    first = Rendom3Answers(); //הגרלת סדר התשובות
                    secnd = rand.Next(3);
                    while (secnd == first)
                        secnd = rand.Next(3);
                    pcbAnswer1.Image = current.MultipleImages()[first];
                    pcbAnswer2.Image = current.MultipleImages()[secnd];
                    pcbAnswer3.Image = current.MultipleImages()[3-first-secnd];
                    break;
            }
        }

        private int Rendom2Answers() // פונקציית עזר שמגרילה סדר של 2 תשובות להצגה
        {
            rbtAnswer1.Visible = true;
            rbtAnswer2.Visible = true;
            int randNum = rand.Next(2);
            return randNum;
        }

        private int Rendom3Answers() // פונקציית עזר שמגרילה סדר של 3 תשובות להצגה
        {
            rbtAnswer1.Visible = true;
            rbtAnswer2.Visible = true;
            rbtAnswer3.Visible = true;
            int randNum = rand.Next(3);
            return randNum;
        }

        private bool CheckAnswers() // פונקציית עזר שמחזירה אמת במידה והתשובה שבחר השחקן זהה לתשובה הנכונה 
        {
            switch (current.Qtype)
            {
                case Qtype.TrueFalseWImage:
                    if (rbtAnswer1.Checked && current.CorrectAnswer == rbtAnswer1.Text)
                        return true;
                    else if (rbtAnswer2.Checked && current.CorrectAnswer == rbtAnswer2.Text)
                        return true;
                    break;

                case Qtype.TrueFalse:
                    if (rbtAnswer1.Checked && current.CorrectAnswer == rbtAnswer1.Text)
                        return true;
                    else if (rbtAnswer2.Checked && current.CorrectAnswer == rbtAnswer2.Text)
                        return true;
                    break;

                case Qtype.Multiple:
                    if (rbtAnswer1.Checked && current.CorrectAnswer == rbtAnswer1.Text)
                        return true;
                    else if (rbtAnswer2.Checked && current.CorrectAnswer == rbtAnswer2.Text)
                        return true;
                    else if (rbtAnswer3.Checked && current.CorrectAnswer == rbtAnswer3.Text)
                        return true;
                    break;

                case Qtype.MultipleWImages:
                    if (rbtAnswer1.Checked && current.ImageCorrectAnswer == pcbAnswer1.Image)
                        return true;
                    else if (rbtAnswer2.Checked && current.ImageCorrectAnswer == pcbAnswer2.Image)
                        return true;
                    else if (rbtAnswer3.Checked && current.ImageCorrectAnswer == pcbAnswer3.Image)
                        return true;
                    break;
            }
            return false;
        }


        private void Clear() //מתודה שמאפסת את הפקדים למצב התחלתי
        {
            rbtAnswer1.Visible = false;
            rbtAnswer2.Visible = false;
            rbtAnswer3.Visible = false;
            rbtAnswer1.Text = "";
            rbtAnswer2.Text = "";
            rbtAnswer3.Text = "";
            pbxPicQuestion.Visible = false;
            pcbAnswer1.Visible = false;
            pcbAnswer2.Visible = false;
            pcbAnswer3.Visible = false;
            rbtAnswer1.Checked = false;
            rbtAnswer2.Checked = false;
            rbtAnswer3.Checked = false;
        }

        public void writeToFile() //כתיבה לתוך קובץ הסטטיסטיקה של השחקן עבור משחק ספציפי
        {
            File.AppendAllText(player.Path, "User Email: " + player.UserEmail + "\r\nHow long the game took: " + txtTimer.Text
                               + " sec\r\ncorrect answers: " + score + "\r\nincorrect answers: " + (10 - score));
        }
    }
}

