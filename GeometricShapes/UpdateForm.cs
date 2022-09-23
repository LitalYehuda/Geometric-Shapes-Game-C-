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
    public partial class UpdateForm : Form //טופס בחירת נתונים שאותם רוצים להוסיף למאגר
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnAdditem_Click(object sender, EventArgs e) //מעבר לטופס הוספת פריט
        {
            AddItem newItem = new AddItem();
            newItem.ShowDialog();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) //מעבר לטופס בחירת סוג שאלה
        {
            ChooseQuestion chooseQuestion = new ChooseQuestion();
            chooseQuestion.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e) //סגירת הטופס וחזרה לתפריט הראשי
        {
            this.Close();
        }
    }
}
