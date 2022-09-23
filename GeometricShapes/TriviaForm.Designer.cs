namespace GeometricShapes
{
    partial class TriviaForm
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
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.TriviaTimer = new System.Windows.Forms.Timer(this.components);
            this.rbtAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtAnswer3 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion = new System.Windows.Forms.GroupBox();
            this.pcbAnswer3 = new System.Windows.Forms.PictureBox();
            this.pcbAnswer2 = new System.Windows.Forms.PictureBox();
            this.pcbAnswer1 = new System.Windows.Forms.PictureBox();
            this.pbxPicQuestion = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.lblTitleTrivia = new System.Windows.Forms.Label();
            this.gbxQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(898, 57);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(91, 35);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScore.Location = new System.Drawing.Point(807, 57);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(85, 31);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // TriviaTimer
            // 
            this.TriviaTimer.Interval = 1500;
            this.TriviaTimer.Tick += new System.EventHandler(this.TriviaTimer_Tick);
            // 
            // rbtAnswer1
            // 
            this.rbtAnswer1.AutoSize = true;
            this.rbtAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.rbtAnswer1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAnswer1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtAnswer1.Location = new System.Drawing.Point(30, 139);
            this.rbtAnswer1.Name = "rbtAnswer1";
            this.rbtAnswer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtAnswer1.Size = new System.Drawing.Size(21, 20);
            this.rbtAnswer1.TabIndex = 9;
            this.rbtAnswer1.TabStop = true;
            this.rbtAnswer1.UseVisualStyleBackColor = false;
            // 
            // rbtAnswer2
            // 
            this.rbtAnswer2.AutoSize = true;
            this.rbtAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.rbtAnswer2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAnswer2.Location = new System.Drawing.Point(30, 263);
            this.rbtAnswer2.Name = "rbtAnswer2";
            this.rbtAnswer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtAnswer2.Size = new System.Drawing.Size(21, 20);
            this.rbtAnswer2.TabIndex = 10;
            this.rbtAnswer2.TabStop = true;
            this.rbtAnswer2.UseVisualStyleBackColor = false;
            // 
            // rbtAnswer3
            // 
            this.rbtAnswer3.AutoSize = true;
            this.rbtAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.rbtAnswer3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAnswer3.Location = new System.Drawing.Point(30, 384);
            this.rbtAnswer3.Name = "rbtAnswer3";
            this.rbtAnswer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtAnswer3.Size = new System.Drawing.Size(21, 20);
            this.rbtAnswer3.TabIndex = 11;
            this.rbtAnswer3.TabStop = true;
            this.rbtAnswer3.UseVisualStyleBackColor = false;
            this.rbtAnswer3.Visible = false;
            // 
            // gbxQuestion
            // 
            this.gbxQuestion.BackColor = System.Drawing.Color.Transparent;
            this.gbxQuestion.Controls.Add(this.pcbAnswer3);
            this.gbxQuestion.Controls.Add(this.pcbAnswer2);
            this.gbxQuestion.Controls.Add(this.pcbAnswer1);
            this.gbxQuestion.Controls.Add(this.pbxPicQuestion);
            this.gbxQuestion.Controls.Add(this.txtQuestion);
            this.gbxQuestion.Controls.Add(this.btnForward);
            this.gbxQuestion.Controls.Add(this.rbtAnswer1);
            this.gbxQuestion.Controls.Add(this.rbtAnswer3);
            this.gbxQuestion.Controls.Add(this.rbtAnswer2);
            this.gbxQuestion.Location = new System.Drawing.Point(129, 143);
            this.gbxQuestion.Name = "gbxQuestion";
            this.gbxQuestion.Size = new System.Drawing.Size(860, 605);
            this.gbxQuestion.TabIndex = 12;
            this.gbxQuestion.TabStop = false;
            // 
            // pcbAnswer3
            // 
            this.pcbAnswer3.Location = new System.Drawing.Point(72, 384);
            this.pcbAnswer3.Name = "pcbAnswer3";
            this.pcbAnswer3.Size = new System.Drawing.Size(116, 101);
            this.pcbAnswer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnswer3.TabIndex = 30;
            this.pcbAnswer3.TabStop = false;
            this.pcbAnswer3.Visible = false;
            // 
            // pcbAnswer2
            // 
            this.pcbAnswer2.Location = new System.Drawing.Point(72, 263);
            this.pcbAnswer2.Name = "pcbAnswer2";
            this.pcbAnswer2.Size = new System.Drawing.Size(116, 101);
            this.pcbAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnswer2.TabIndex = 29;
            this.pcbAnswer2.TabStop = false;
            this.pcbAnswer2.Visible = false;
            // 
            // pcbAnswer1
            // 
            this.pcbAnswer1.Location = new System.Drawing.Point(72, 139);
            this.pcbAnswer1.Name = "pcbAnswer1";
            this.pcbAnswer1.Size = new System.Drawing.Size(116, 101);
            this.pcbAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnswer1.TabIndex = 28;
            this.pcbAnswer1.TabStop = false;
            this.pcbAnswer1.Visible = false;
            // 
            // pbxPicQuestion
            // 
            this.pbxPicQuestion.Location = new System.Drawing.Point(494, 139);
            this.pbxPicQuestion.Name = "pbxPicQuestion";
            this.pbxPicQuestion.Size = new System.Drawing.Size(350, 312);
            this.pbxPicQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicQuestion.TabIndex = 13;
            this.pbxPicQuestion.TabStop = false;
            this.pbxPicQuestion.Visible = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuestion.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(30, 37);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(814, 75);
            this.txtQuestion.TabIndex = 12;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnForward.Location = new System.Drawing.Point(72, 525);
            this.btnForward.Name = "btnForward";
            this.btnForward.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnForward.Size = new System.Drawing.Size(146, 52);
            this.btnForward.TabIndex = 27;
            this.btnForward.Text = "Check";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 53);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.BackColor = System.Drawing.Color.Transparent;
            this.lblIndex.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(942, 116);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(47, 24);
            this.lblIndex.TabIndex = 24;
            this.lblIndex.Text = "1/10";
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.Gold;
            this.btnSaveGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.Location = new System.Drawing.Point(418, 772);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(207, 67);
            this.btnSaveGame.TabIndex = 25;
            this.btnSaveGame.Text = "Done";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTimer.Location = new System.Drawing.Point(807, 15);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 31);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "Timer:";
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTimer.Enabled = false;
            this.txtTimer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(898, 12);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(91, 35);
            this.txtTimer.TabIndex = 29;
            this.txtTimer.Text = "0";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitleTrivia
            // 
            this.lblTitleTrivia.AutoSize = true;
            this.lblTitleTrivia.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTrivia.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTrivia.ForeColor = System.Drawing.Color.Black;
            this.lblTitleTrivia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleTrivia.Location = new System.Drawing.Point(408, 46);
            this.lblTitleTrivia.Name = "lblTitleTrivia";
            this.lblTitleTrivia.Size = new System.Drawing.Size(278, 60);
            this.lblTitleTrivia.TabIndex = 30;
            this.lblTitleTrivia.Text = "Trivia Game";
            // 
            // TriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeometricShapes.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 885);
            this.Controls.Add(this.lblTitleTrivia);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Name = "TriviaForm";
            this.Text = "TriviaForm";
            this.Load += new System.EventHandler(this.TriviaForm_Load);
            this.gbxQuestion.ResumeLayout(false);
            this.gbxQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer TriviaTimer;
        private System.Windows.Forms.RadioButton rbtAnswer1;
        private System.Windows.Forms.RadioButton rbtAnswer2;
        private System.Windows.Forms.RadioButton rbtAnswer3;
        private System.Windows.Forms.GroupBox gbxQuestion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox pbxPicQuestion;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label lblTitleTrivia;
        private System.Windows.Forms.PictureBox pcbAnswer3;
        private System.Windows.Forms.PictureBox pcbAnswer2;
        private System.Windows.Forms.PictureBox pcbAnswer1;
    }
}