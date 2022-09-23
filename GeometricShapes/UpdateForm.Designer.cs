namespace GeometricShapes
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChooseAdd = new System.Windows.Forms.Label();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblTitleUpdate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseAdd
            // 
            this.lblChooseAdd.AutoSize = true;
            this.lblChooseAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAdd.Location = new System.Drawing.Point(204, 236);
            this.lblChooseAdd.Name = "lblChooseAdd";
            this.lblChooseAdd.Size = new System.Drawing.Size(478, 33);
            this.lblChooseAdd.TabIndex = 20;
            this.lblChooseAdd.Text = "Choose which content do you want to add:";
            // 
            // btnAdditem
            // 
            this.btnAdditem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAdditem.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdditem.Location = new System.Drawing.Point(469, 308);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdditem.Size = new System.Drawing.Size(210, 101);
            this.btnAdditem.TabIndex = 19;
            this.btnAdditem.Text = "Information Item";
            this.btnAdditem.UseVisualStyleBackColor = false;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddQuestion.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddQuestion.Location = new System.Drawing.Point(210, 308);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddQuestion.Size = new System.Drawing.Size(208, 101);
            this.btnAddQuestion.TabIndex = 18;
            this.btnAddQuestion.Text = "Trivia Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblTitleUpdate
            // 
            this.lblTitleUpdate.AutoSize = true;
            this.lblTitleUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleUpdate.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblTitleUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleUpdate.Location = new System.Drawing.Point(239, 113);
            this.lblTitleUpdate.Name = "lblTitleUpdate";
            this.lblTitleUpdate.Size = new System.Drawing.Size(418, 60);
            this.lblTitleUpdate.TabIndex = 17;
            this.lblTitleUpdate.Text = "Repository Update";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 58);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeometricShapes.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 573);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChooseAdd);
            this.Controls.Add(this.btnAdditem);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.lblTitleUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseAdd;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblTitleUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}