namespace Exam2
{
    partial class AddQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtBoxQuestoion = new System.Windows.Forms.TextBox();
            this.lblCorrectAns = new System.Windows.Forms.Label();
            this.lblChooseFormat = new System.Windows.Forms.Label();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.txtCorrectAns = new System.Windows.Forms.TextBox();
            this.txtIncorrectAns1 = new System.Windows.Forms.TextBox();
            this.lblIncorrectAns = new System.Windows.Forms.Label();
            this.btnAddTxt = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.listBoxIncorrectAns = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.btnHm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterInfo
            // 
            this.lblEnterInfo.AutoSize = true;
            this.lblEnterInfo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInfo.Location = new System.Drawing.Point(835, 21);
            this.lblEnterInfo.Name = "lblEnterInfo";
            this.lblEnterInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnterInfo.Size = new System.Drawing.Size(262, 34);
            this.lblEnterInfo.TabIndex = 1;
            this.lblEnterInfo.Text = "טופס הכנסת שאלות:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(1045, 178);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuestion.Size = new System.Drawing.Size(54, 19);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "שאלה:";
            // 
            // txtBoxQuestoion
            // 
            this.txtBoxQuestoion.Location = new System.Drawing.Point(463, 176);
            this.txtBoxQuestoion.Name = "txtBoxQuestoion";
            this.txtBoxQuestoion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxQuestoion.Size = new System.Drawing.Size(566, 20);
            this.txtBoxQuestoion.TabIndex = 3;
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = true;
            this.lblCorrectAns.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAns.Location = new System.Drawing.Point(1003, 245);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCorrectAns.Size = new System.Drawing.Size(99, 19);
            this.lblCorrectAns.TabIndex = 4;
            this.lblCorrectAns.Text = "תשובה נכונה:";
            // 
            // lblChooseFormat
            // 
            this.lblChooseFormat.AutoSize = true;
            this.lblChooseFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFormat.Location = new System.Drawing.Point(979, 81);
            this.lblChooseFormat.Name = "lblChooseFormat";
            this.lblChooseFormat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChooseFormat.Size = new System.Drawing.Size(125, 19);
            this.lblChooseFormat.TabIndex = 5;
            this.lblChooseFormat.Text = "בחירת סוג שאלה:";
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Checked = true;
            this.rbtn0.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn0.Location = new System.Drawing.Point(819, 83);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn0.Size = new System.Drawing.Size(135, 24);
            this.rbtn0.TabIndex = 6;
            this.rbtn0.TabStop = true;
            this.rbtn0.Text = "שאלת אמת או שקר";
            this.rbtn0.UseVisualStyleBackColor = true;
            this.rbtn0.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1.Location = new System.Drawing.Point(826, 119);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn1.Size = new System.Drawing.Size(128, 24);
            this.rbtn1.TabIndex = 7;
            this.rbtn1.Text = "שאלת ריבוי בחירה";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.Location = new System.Drawing.Point(463, 243);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCorrectAns.Size = new System.Drawing.Size(534, 20);
            this.txtCorrectAns.TabIndex = 10;
            // 
            // txtIncorrectAns1
            // 
            this.txtIncorrectAns1.Location = new System.Drawing.Point(463, 306);
            this.txtIncorrectAns1.Name = "txtIncorrectAns1";
            this.txtIncorrectAns1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIncorrectAns1.Size = new System.Drawing.Size(430, 20);
            this.txtIncorrectAns1.TabIndex = 12;
            // 
            // lblIncorrectAns
            // 
            this.lblIncorrectAns.AutoSize = true;
            this.lblIncorrectAns.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAns.Location = new System.Drawing.Point(907, 306);
            this.lblIncorrectAns.Name = "lblIncorrectAns";
            this.lblIncorrectAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIncorrectAns.Size = new System.Drawing.Size(197, 19);
            this.lblIncorrectAns.TabIndex = 11;
            this.lblIncorrectAns.Text = "תשובה או תשובות לא נכונות:";
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.BackColor = System.Drawing.Color.SeaShell;
            this.btnAddTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTxt.Location = new System.Drawing.Point(574, 343);
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddTxt.Size = new System.Drawing.Size(248, 29);
            this.btnAddTxt.TabIndex = 13;
            this.btnAddTxt.Text = "+ להוספת תשובות לא נכונות";
            this.btnAddTxt.UseVisualStyleBackColor = false;
            this.btnAddTxt.Click += new System.EventHandler(this.btnAddTxt_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.SeaShell;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(225, 425);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddQuestion.Size = new System.Drawing.Size(154, 83);
            this.btnAddQuestion.TabIndex = 17;
            this.btnAddQuestion.Text = "הוספת השאלה למאגר";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // listBoxIncorrectAns
            // 
            this.listBoxIncorrectAns.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIncorrectAns.FormattingEnabled = true;
            this.listBoxIncorrectAns.ItemHeight = 16;
            this.listBoxIncorrectAns.Location = new System.Drawing.Point(463, 378);
            this.listBoxIncorrectAns.Name = "listBoxIncorrectAns";
            this.listBoxIncorrectAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxIncorrectAns.Size = new System.Drawing.Size(438, 196);
            this.listBoxIncorrectAns.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaShell;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(105, 42);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2.Location = new System.Drawing.Point(601, 83);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn2.Size = new System.Drawing.Size(192, 24);
            this.rbtn2.TabIndex = 6;
            this.rbtn2.Text = "שאלת אמת או שקר עם תמונה";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn3.Location = new System.Drawing.Point(599, 119);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtn3.Size = new System.Drawing.Size(194, 24);
            this.rbtn3.TabIndex = 7;
            this.rbtn3.Text = "שאלת ריבוי בחירה עם תתמונה";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.Linen;
            this.btnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Location = new System.Drawing.Point(327, 231);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddPic.Size = new System.Drawing.Size(102, 40);
            this.btnAddPic.TabIndex = 20;
            this.btnAddPic.Text = "הוסף תמונה:";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Visible = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttention.Location = new System.Drawing.Point(85, 343);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAttention.Size = new System.Drawing.Size(0, 19);
            this.lblAttention.TabIndex = 21;
            // 
            // btnHm
            // 
            this.btnHm.BackColor = System.Drawing.Color.SeaShell;
            this.btnHm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHm.Location = new System.Drawing.Point(12, 11);
            this.btnHm.Name = "btnHm";
            this.btnHm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHm.Size = new System.Drawing.Size(105, 63);
            this.btnHm.TabIndex = 22;
            this.btnHm.Text = "חזרה לדף הראשי";
            this.btnHm.UseVisualStyleBackColor = false;
            this.btnHm.Click += new System.EventHandler(this.btnHm_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1124, 625);
            this.Controls.Add(this.btnHm);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBoxIncorrectAns);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnAddTxt);
            this.Controls.Add(this.txtIncorrectAns1);
            this.Controls.Add(this.lblIncorrectAns);
            this.Controls.Add(this.txtCorrectAns);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.rbtn0);
            this.Controls.Add(this.lblChooseFormat);
            this.Controls.Add(this.lblCorrectAns);
            this.Controls.Add(this.txtBoxQuestoion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblEnterInfo);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterInfo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtBoxQuestoion;
        private System.Windows.Forms.Label lblCorrectAns;
        private System.Windows.Forms.Label lblChooseFormat;
        private System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.TextBox txtCorrectAns;
        private System.Windows.Forms.TextBox txtIncorrectAns1;
        private System.Windows.Forms.Label lblIncorrectAns;
        private System.Windows.Forms.Button btnAddTxt;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ListBox listBoxIncorrectAns;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Button btnHm;
    }
}