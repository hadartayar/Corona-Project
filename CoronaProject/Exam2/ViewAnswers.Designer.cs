namespace Exam2
{
    partial class ViewAnswers
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
            Exam2.Questions questions1 = new Exam2.Questions();
            this.btnNextQues = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblYourAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.questionControl1 = new Exam2.QuestionControl();
            this.btnHp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextQues
            // 
            this.btnNextQues.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNextQues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQues.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQues.Location = new System.Drawing.Point(199, 525);
            this.btnNextQues.Name = "btnNextQues";
            this.btnNextQues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextQues.Size = new System.Drawing.Size(158, 55);
            this.btnNextQues.TabIndex = 22;
            this.btnNextQues.Text = "לשאלה הבאה";
            this.btnNextQues.UseVisualStyleBackColor = false;
            this.btnNextQues.Click += new System.EventHandler(this.btnNextQues_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(22, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(134, 55);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.AutoSize = true;
            this.lblYourAnswer.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAnswer.Location = new System.Drawing.Point(855, 457);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYourAnswer.Size = new System.Drawing.Size(122, 26);
            this.lblYourAnswer.TabIndex = 29;
            this.lblYourAnswer.Text = "התשובה שלך:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(561, 20);
            this.textBox1.TabIndex = 30;
            // 
            // questionControl1
            // 
            this.questionControl1.IsMultiple = false;
            this.questionControl1.Location = new System.Drawing.Point(199, 33);
            this.questionControl1.Name = "questionControl1";
            questions1.CorrectAns = "";
            questions1.IncorrectAnswer = new string[0];
            questions1.Qnumber = 0;
            questions1.Qtype = 5;
            questions1.Question = "";
            this.questionControl1.Question = questions1;
            this.questionControl1.Size = new System.Drawing.Size(805, 421);
            this.questionControl1.TabIndex = 0;
            // 
            // btnHp
            // 
            this.btnHp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHp.Location = new System.Drawing.Point(12, 12);
            this.btnHp.Name = "btnHp";
            this.btnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHp.Size = new System.Drawing.Size(134, 55);
            this.btnHp.TabIndex = 31;
            this.btnHp.Text = "חזרה לעמוד הראשי";
            this.btnHp.UseVisualStyleBackColor = false;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // ViewAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1030, 592);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.btnNextQues);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.questionControl1);
            this.Name = "ViewAnswers";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuestionControl questionControl1;
        private System.Windows.Forms.Button btnNextQues;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblYourAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHp;
    }
}