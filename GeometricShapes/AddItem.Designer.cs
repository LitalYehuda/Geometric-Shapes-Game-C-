namespace GeometricShapes
{
    partial class AddItem
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
            this.lblAddItemTitle = new System.Windows.Forms.Label();
            this.lblAddTopic = new System.Windows.Forms.Label();
            this.lblAddContact = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.pbxAddPic = new System.Windows.Forms.PictureBox();
            this.txtAddContact = new System.Windows.Forms.TextBox();
            this.txtAddTopic = new System.Windows.Forms.TextBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddItemTitle
            // 
            this.lblAddItemTitle.AutoSize = true;
            this.lblAddItemTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItemTitle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemTitle.Location = new System.Drawing.Point(177, 94);
            this.lblAddItemTitle.Name = "lblAddItemTitle";
            this.lblAddItemTitle.Size = new System.Drawing.Size(229, 39);
            this.lblAddItemTitle.TabIndex = 11;
            this.lblAddItemTitle.Text = "Add New Item:";
            // 
            // lblAddTopic
            // 
            this.lblAddTopic.AutoSize = true;
            this.lblAddTopic.BackColor = System.Drawing.Color.Transparent;
            this.lblAddTopic.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTopic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddTopic.Location = new System.Drawing.Point(178, 180);
            this.lblAddTopic.Name = "lblAddTopic";
            this.lblAddTopic.Size = new System.Drawing.Size(80, 31);
            this.lblAddTopic.TabIndex = 10;
            this.lblAddTopic.Text = "Topic:";
            // 
            // lblAddContact
            // 
            this.lblAddContact.AutoSize = true;
            this.lblAddContact.BackColor = System.Drawing.Color.Transparent;
            this.lblAddContact.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddContact.Location = new System.Drawing.Point(178, 246);
            this.lblAddContact.Name = "lblAddContact";
            this.lblAddContact.Size = new System.Drawing.Size(106, 31);
            this.lblAddContact.TabIndex = 12;
            this.lblAddContact.Text = "Content:";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.LightSalmon;
            this.btnApprove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApprove.Location = new System.Drawing.Point(184, 460);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(233, 92);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.Text = "ADD";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // pbxAddPic
            // 
            this.pbxAddPic.BackColor = System.Drawing.Color.White;
            this.pbxAddPic.Location = new System.Drawing.Point(443, 323);
            this.pbxAddPic.Name = "pbxAddPic";
            this.pbxAddPic.Size = new System.Drawing.Size(370, 229);
            this.pbxAddPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddPic.TabIndex = 15;
            this.pbxAddPic.TabStop = false;
            // 
            // txtAddContact
            // 
            this.txtAddContact.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddContact.Location = new System.Drawing.Point(290, 240);
            this.txtAddContact.Multiline = true;
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(523, 37);
            this.txtAddContact.TabIndex = 16;
            // 
            // txtAddTopic
            // 
            this.txtAddTopic.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTopic.Location = new System.Drawing.Point(290, 180);
            this.txtAddTopic.Name = "txtAddTopic";
            this.txtAddTopic.Size = new System.Drawing.Size(222, 38);
            this.txtAddTopic.TabIndex = 18;
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPic.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(184, 323);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(233, 49);
            this.btnAddPic.TabIndex = 19;
            this.btnAddPic.Text = "Upload Image:";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(36, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 56);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeometricShapes.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 614);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.txtAddTopic);
            this.Controls.Add(this.txtAddContact);
            this.Controls.Add(this.pbxAddPic);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblAddContact);
            this.Controls.Add(this.lblAddItemTitle);
            this.Controls.Add(this.lblAddTopic);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItemTitle;
        private System.Windows.Forms.Label lblAddTopic;
        private System.Windows.Forms.Label lblAddContact;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.PictureBox pbxAddPic;
        private System.Windows.Forms.TextBox txtAddContact;
        private System.Windows.Forms.TextBox txtAddTopic;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnBack;
    }
}