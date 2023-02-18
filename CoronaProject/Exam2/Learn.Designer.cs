namespace Exam2
{
    partial class Learn
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnHp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(467, 55);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuestion.Size = new System.Drawing.Size(470, 23);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "שאלה:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Tan;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(467, 95);
            this.txtContent.Name = "txtContent";
            this.txtContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContent.Size = new System.Drawing.Size(470, 355);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Linen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(12, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNext.Size = new System.Drawing.Size(102, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Linen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(102, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(125, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Linen;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGame.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(12, 412);
            this.btnGame.Name = "btnGame";
            this.btnGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGame.Size = new System.Drawing.Size(102, 38);
            this.btnGame.TabIndex = 5;
            this.btnGame.Text = "מוכן למשחק";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnHp
            // 
            this.btnHp.BackColor = System.Drawing.Color.Linen;
            this.btnHp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHp.Location = new System.Drawing.Point(12, 31);
            this.btnHp.Name = "btnHp";
            this.btnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHp.Size = new System.Drawing.Size(93, 67);
            this.btnHp.TabIndex = 6;
            this.btnHp.Text = "חזרה לעמוד הראשי";
            this.btnHp.UseVisualStyleBackColor = false;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1047, 528);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Learn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Learnform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnHp;
    }
}