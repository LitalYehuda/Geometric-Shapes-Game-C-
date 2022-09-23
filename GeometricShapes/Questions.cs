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
    public enum Qtype // משתנה של סוג השאלה
    {
        TrueFalse = 0, Multiple, TrueFalseWImage, MultipleWImages
    }

    public class Questions :IComparable //מחלקת שאלות ותשובות עם 4 בנאים שונים עבור כל סוג שאלה
    {
        protected int qnumber;
        protected string question;
        protected Image imageQuestion;
        protected string correctAnswer;
        protected string incorrectAnswer1;
        protected string incorrectAnswer2;
        protected Image imageCorrectAnswer;
        protected Image imageIncorrectAnswer1;
        protected Image imageIncorrectAnswer2;

        public Questions(int qnumber, Qtype qtype, string question, string correctAnswer, string incorrectAnswer1) //בנאי לשאלת אמת או שקר
        {
            this.qnumber = qnumber;
            this.Qtype = qtype;
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswer1 = incorrectAnswer1;
        }

        public Questions(int qnumber, Qtype qtype, string question, string correctAnswer, string incorrectAnswer1, string incorrectAnswer2) //בנאי לשאלת ריבוי בחירה
        {
            this.qnumber = qnumber;
            this.Qtype = qtype;
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswer1 = incorrectAnswer1;
            this.incorrectAnswer2 = incorrectAnswer2;
        }

        public Questions(int qnumber, Qtype qtype, string question, string correctAnswer, string incorrectAnswer1, Image imageQuestion) //בנאי לשאלת אמת או שקר עם תמונה
        {
            this.qnumber = qnumber;
            this.Qtype = qtype;
            this.question = question;
            this.imageQuestion = imageQuestion;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswer1 = incorrectAnswer1;
        }

        public Questions(int qnumber, Qtype qtype, string question, Image ImagecorrectAnswer, Image ImageincorrectAnswer1, Image ImageincorrectAnswer2) //בנאי לשאלת ריבוי בחירה עם תמונות
        {
            this.qnumber = qnumber;
            this.Qtype = qtype;
            this.question = question;
            this.ImageCorrectAnswer = ImagecorrectAnswer;
            this.ImageIncorrectAnswer1 = ImageincorrectAnswer1;
            this.ImageIncorrectAnswer2 = ImageincorrectAnswer2;
        }

        public Qtype Qtype { get ; set ; }
        public int Qnumber { get => qnumber; set => qnumber = value; }
        public Image ImageQuestion { get => imageQuestion; set => imageQuestion = value; }
        public string Question { get => question; set => question = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string IncorrectAnswer1 { get => incorrectAnswer1; set => incorrectAnswer1 = value; }
        public string IncorrectAnswer2 { get => incorrectAnswer2; set => incorrectAnswer2 = value; }
        public Image ImageCorrectAnswer { get => imageCorrectAnswer; set => imageCorrectAnswer = value; }
        public Image ImageIncorrectAnswer1 { get => imageIncorrectAnswer1; set => imageIncorrectAnswer1 = value; }
        public Image ImageIncorrectAnswer2 { get => imageIncorrectAnswer2; set => imageIncorrectAnswer2 = value; }


        public int CompareTo(Object obj) //מתודת השוואה בין שאלה שקיימת במערך לבין שאלה חדשה
        {
            Questions item = (Questions)obj;
            return question.CompareTo(item.question);
        }


        public List<string> TrueOrFalseAnswer() //מתודת עזר שמחזירה רשימת עזר של תשובות אמת או שקר
        {
            List<string> TrueOrFalse = new List<string>();
            TrueOrFalse.Add(correctAnswer);
            TrueOrFalse.Add(incorrectAnswer1); 
            return TrueOrFalse;
        }

        public List<string> MultipleAnswers() //מתודת עזר שמחזירה רשימת עזר של תשובות מרובות
        {
            List<string> Multiple = new List<string>();
            Multiple.Add(correctAnswer);
            Multiple.Add(incorrectAnswer1);
            Multiple.Add(incorrectAnswer2);
            return Multiple;
        }

        public List<Image> MultipleImages() //מתודת עזר שמחזירה רשימת עזר של תשובות תמונה מרובות
        {
            List<Image> MultipleImages = new List<Image>();
            MultipleImages.Add(imageCorrectAnswer);
            MultipleImages.Add(imageIncorrectAnswer1);
            MultipleImages.Add(imageIncorrectAnswer2);
            return MultipleImages;
        }
    }
}
