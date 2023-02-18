namespace Exam2
{
    partial class AddInfo
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
            this.lblEnterInfo = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSucceed = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterInfo
            // 
            this.lblEnterInfo.AutoSize = true;
            this.lblEnterInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInfo.Location = new System.Drawing.Point(723, 28);
            this.lblEnterInfo.Name = "lblEnterInfo";
            this.lblEnterInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnterInfo.Size = new System.Drawing.Size(229, 32);
            this.lblEnterInfo.TabIndex = 0;
            this.lblEnterInfo.Text = "טופס הכנסת מידע:";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(901, 120);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTopic.Size = new System.Drawing.Size(46, 19);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "נושא:";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(900, 161);
            this.lblContent.Name = "lblContent";
            this.lblContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContent.Size = new System.Drawing.Size(47, 19);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "מידע:";
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic.Location = new System.Drawing.Point(589, 116);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTopic.Size = new System.Drawing.Size(294, 26);
            this.txtTopic.TabIndex = 3;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(309, 158);
            this.txtContent.Name = "txtContent";
            this.txtContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContent.Size = new System.Drawing.Size(574, 26);
            this.txtContent.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(834, 478);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblSucceed
            // 
            this.lblSucceed.AutoSize = true;
            this.lblSucceed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucceed.Location = new System.Drawing.Point(634, 505);
            this.lblSucceed.Name = "lblSucceed";
            this.lblSucceed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSucceed.Size = new System.Drawing.Size(153, 19);
            this.lblSucceed.TabIndex = 8;
            this.lblSucceed.Text = "*התוכן הוכנס בהצלחה";
            this.lblSucceed.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(27, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(102, 47);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(860, 266);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddPic.Size = new System.Drawing.Size(102, 40);
            this.btnAddPic.TabIndex = 10;
            this.btnAddPic.Text = "הוסף תמונה:";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(309, 286);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(536, 20);
            this.txtImage.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(105, 63);
            this.button1.TabIndex = 23;
            this.button1.Text = "חזרה לדף הראשי";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1007, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSucceed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblEnterInfo);
            this.Name = "AddInfo";
            this.Text = "AddInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterInfo;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSucceed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button button1;
    }
}