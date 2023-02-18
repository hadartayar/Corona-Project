namespace Exam2
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnd1 = new System.Windows.Forms.Label();
            this.lblEnd2 = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnSeeAns = new System.Windows.Forms.Button();
            this.BtnSameGameAgain = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.BtnAddContent = new System.Windows.Forms.Button();
            this.BtnLearn = new System.Windows.Forms.Button();
            this.lblScoere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnd1
            // 
            this.lblEnd1.AutoSize = true;
            this.lblEnd1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd1.Location = new System.Drawing.Point(734, 60);
            this.lblEnd1.Name = "lblEnd1";
            this.lblEnd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnd1.Size = new System.Drawing.Size(138, 44);
            this.lblEnd1.TabIndex = 1;
            this.lblEnd1.Text = "זכית ב..";
            // 
            // lblEnd2
            // 
            this.lblEnd2.AutoSize = true;
            this.lblEnd2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd2.Location = new System.Drawing.Point(509, 56);
            this.lblEnd2.Name = "lblEnd2";
            this.lblEnd2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnd2.Size = new System.Drawing.Size(118, 44);
            this.lblEnd2.TabIndex = 2;
            this.lblEnd2.Text = "נקודות";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(275, 186);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChoose.Size = new System.Drawing.Size(494, 37);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "כעת תוכל לבחור אחת מהאופציות הבאות:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(310, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(204, 53);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnSeeAns
            // 
            this.BtnSeeAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSeeAns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSeeAns.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeeAns.Location = new System.Drawing.Point(534, 258);
            this.BtnSeeAns.Name = "BtnSeeAns";
            this.BtnSeeAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSeeAns.Size = new System.Drawing.Size(204, 52);
            this.BtnSeeAns.TabIndex = 12;
            this.BtnSeeAns.Text = "לראות את התשובות הנכונות לשאלות בהן טעית";
            this.BtnSeeAns.UseVisualStyleBackColor = false;
            this.BtnSeeAns.Click += new System.EventHandler(this.BtnSeeAns_Click);
            // 
            // BtnSameGameAgain
            // 
            this.BtnSameGameAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSameGameAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSameGameAgain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSameGameAgain.Location = new System.Drawing.Point(534, 334);
            this.BtnSameGameAgain.Name = "BtnSameGameAgain";
            this.BtnSameGameAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSameGameAgain.Size = new System.Drawing.Size(204, 52);
            this.BtnSameGameAgain.TabIndex = 13;
            this.BtnSameGameAgain.Text = "לחזור שוב על אותו משחק";
            this.BtnSameGameAgain.UseVisualStyleBackColor = false;
            this.BtnSameGameAgain.Click += new System.EventHandler(this.BtnSameGameAgain_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNewGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.Location = new System.Drawing.Point(534, 414);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnNewGame.Size = new System.Drawing.Size(204, 52);
            this.BtnNewGame.TabIndex = 14;
            this.BtnNewGame.Text = "להתחיל משחק חדש";
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BtnAddContent
            // 
            this.BtnAddContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnAddContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddContent.Location = new System.Drawing.Point(310, 338);
            this.BtnAddContent.Name = "BtnAddContent";
            this.BtnAddContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddContent.Size = new System.Drawing.Size(204, 52);
            this.BtnAddContent.TabIndex = 17;
            this.BtnAddContent.Text = "להוסיף תוכן";
            this.BtnAddContent.UseVisualStyleBackColor = false;
            this.BtnAddContent.Click += new System.EventHandler(this.BtnAddContent_Click);
            // 
            // BtnLearn
            // 
            this.BtnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLearn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLearn.Location = new System.Drawing.Point(310, 258);
            this.BtnLearn.Name = "BtnLearn";
            this.BtnLearn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnLearn.Size = new System.Drawing.Size(204, 52);
            this.BtnLearn.TabIndex = 15;
            this.BtnLearn.Text = "לחזור לחלק הלימודי";
            this.BtnLearn.UseVisualStyleBackColor = false;
            this.BtnLearn.Click += new System.EventHandler(this.BtnLearn_Click);
            // 
            // lblScoere
            // 
            this.lblScoere.AutoSize = true;
            this.lblScoere.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoere.Location = new System.Drawing.Point(618, 58);
            this.lblScoere.Name = "lblScoere";
            this.lblScoere.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScoere.Size = new System.Drawing.Size(128, 46);
            this.lblScoere.TabIndex = 18;
            this.lblScoere.Text = "נקודות";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1053, 573);
            this.Controls.Add(this.lblScoere);
            this.Controls.Add(this.BtnAddContent);
            this.Controls.Add(this.BtnLearn);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.BtnSameGameAgain);
            this.Controls.Add(this.BtnSeeAns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblEnd2);
            this.Controls.Add(this.lblEnd1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnd1;
        private System.Windows.Forms.Label lblEnd2;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnSeeAns;
        private System.Windows.Forms.Button BtnSameGameAgain;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnAddContent;
        private System.Windows.Forms.Button BtnLearn;
        private System.Windows.Forms.Label lblScoere;
    }
}