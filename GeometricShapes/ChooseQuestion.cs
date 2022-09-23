using System;
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
    public partial class ChooseQuestion : Form //טופס בחירת סוג השאלה אותה המשתמש רוצה להוסיף
    {
        public static int type=0; //משתנה עזר שעוזר לדעת באיזה סוג שאלה מדובר

        public ChooseQuestion()
        {
            InitializeComponent();
        }

        private void btnAddQuestion3_Click(object sender, EventArgs e) //פתיחת הטופס המתאים עפ"י סוג השאלה
        {
            AddQuestionWImage MultipaleWImage = new AddQuestionWImage();
            MultipaleWImage.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור חזרה לטופס הקודם
        {
            this.Close();
        }

        private void btnAddQuestion2_Click(object sender, EventArgs e)  //פתיחת הטופס המתאים עפ"י סוג השאלה
        {
            type = 2;
            AddQuestion TrueOrFalseWImage = new AddQuestion();
            TrueOrFalseWImage.ShowDialog();
        }

        private void btnAddQuestion1_Click(object sender, EventArgs e)  //פתיחת הטופס המתאים עפ"י סוג השאלה
        {
            type = 1;
            AddQuestion Multipale = new AddQuestion();
            Multipale.ShowDialog();
        }

        private void btnAddQuestion0_Click(object sender, EventArgs e)  //פתיחת הטופס המתאים עפ"י סוג השאלה
        {
            type = 0;
            AddQuestion TrueOrFalse = new AddQuestion();
            TrueOrFalse.ShowDialog();
        }
    }
}
