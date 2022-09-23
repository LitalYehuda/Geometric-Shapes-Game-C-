using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GeometricShapes
{
    public partial class MainForm : Form  //טופס ראשי לבחירת הפעולה הרצוייה ואימות מייל המשתמש
    {
        public static string userEmail; //משתנה עזר סטאטי ששומר את הכתובת מייל התקינה של המשתמש

        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(725, 515);
            Globals.LoadGameData();  //טעינת קובץ השאלות והתשובות ועדכון המערך
            Globals.LoadInfoData(); //טעינת קובץ המידע מחדש ועדכון הרשימה
        }
        
        private void btnTrivia_Click(object sender, EventArgs e) //מעבר לטופס משחק הטריוויה
        {
            TriviaForm trivia = new TriviaForm();
            trivia.ShowDialog();
        }

        private void btnStudy_Click(object sender, EventArgs e) //מעבר לטופס למידה 
        {
            StudyForm study = new StudyForm();
            study.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e) //מעבר לטופס הוספת מידע או שאלה
        {
            UpdateForm update = new UpdateForm();
            update.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //סגירת תוכנית
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e) //כפתור אישור כניסה למערכת
        {
            userEmail = txtLogin.Text;
            bool res = CheckEmail(userEmail);
            if (res == true)
            {
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                btnLogin.Visible = false;
                btnTrivia.Visible = true;
                btnStudy.Visible = true;
                btnUpdate.Visible = true;
            }
            else
                MessageBox.Show("The email in not valid, Please try again", "Error", MessageBoxButtons.OK);
        }

        private bool CheckEmail(string userEmail) //מתודת אימות כתובת מייל
        {
            Regex email = new Regex(@"[0-9a-zA-Z]+@[0-9a-zA-Z]+\.[0-9a-zA-Z]+");
            if (email.IsMatch(userEmail))
                    return true;
            return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
