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
    public partial class AddItem : Form //טופס הוספת פריט מידע
    {
        public AddItem()
        {
            InitializeComponent();
            Globals.LoadInfoData(); //טעינת קובץ המידע מחדש ועדכון הרשימה
            pbxAddPic.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e) //כפתור חזרה לתפריט הקודם
        {
            DialogResult dr = MessageBox.Show("Are you sure?","Addition didn't save", 
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Clear();
            }
        }     

        private void btnAddPic_Click(object sender, EventArgs e) //כפתור העלאת תמונה מסייר קבצים
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbxAddPic.ImageLocation = ofd.FileName;
                pbxAddPic.Visible = true;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e) //בדיקת תקינות נתונים
        {
            try
            {
                if (txtAddTopic.Text == "" || txtAddContact.Text == "" || 
                    (pbxAddPic.ImageLocation == null && pbxAddPic.Visible == true)) //בדיקה האם כל השדות מלאים
                {
                    MessageBox.Show("All fields must be filled!");
                    return;
                }
                foreach (var item in Globals.infoData) //בדיקה האם הפריט לא קיים כבר בקובץ
                {
                    if (item.Content == txtAddContact.Text) 
                    {
                        MessageBox.Show("The item is already exist");
                        return;
                    }
                }
                string rowNumber = (Globals.infoData.Count() + 1).ToString();
                if (pbxAddPic.ImageLocation == null) //כתיבה לתוך הקובץ- פריט מידע ללא תמונה
                {
                     string newRow = "\r\n" + rowNumber + ';' + txtAddTopic.Text + ';' + txtAddContact.Text;
                     File.AppendAllText("DATA\\infoData.txt", newRow);
                }
                else
                {
                    //שמירת תמונה בשם הרצוי והעלאת תמונה לתקיית DIMAGES
                     string imageName = rowNumber + txtAddTopic.Text + pbxAddPic.ImageLocation.Substring(pbxAddPic.ImageLocation.LastIndexOf('.')); 
                     File.Copy(pbxAddPic.ImageLocation, "DATA\\DIMAGES\\" + imageName);
                     string newRow = "\r\n" + rowNumber + ';' + txtAddTopic.Text + ';' + txtAddContact.Text + ';' + imageName;
                     File.AppendAllText("DATA\\infoData.txt", newRow);
                }
                Globals.LoadInfoData(); //טעינת קובץ המידע מחדש

                MessageBox.Show("The item was added seccessfully");
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

        private void Clear() //מתודה שמאפסת את הפקדים למצב התחלתי
        {
            txtAddTopic.Text = "";
            txtAddContact.Text = "";
            pbxAddPic.ImageLocation = null;
            pbxAddPic.Visible = false;
        }
    }
}
