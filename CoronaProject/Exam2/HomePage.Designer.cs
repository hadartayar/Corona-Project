namespace Exam2
{
    partial class HomePage
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
            this.lblHello = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(324, 31);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(519, 42);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "שלום וברוכים הבאים לאתר הקורונה";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(630, 130);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(49, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "שם: ";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(515, 132);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxName.Size = new System.Drawing.Size(100, 25);
            this.txtBoxName.TabIndex = 2;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(451, 200);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChoose.Size = new System.Drawing.Size(249, 29);
            this.lblChoose.TabIndex = 3;
            this.lblChoose.Text = "בפניכם האפשרויות הבאות:";
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.Salmon;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.Location = new System.Drawing.Point(827, 290);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLearn.Size = new System.Drawing.Size(147, 63);
            this.btnLearn.TabIndex = 4;
            this.btnLearn.Text = "לרכוש מידע בנושא";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Salmon;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGame.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(514, 290);
            this.btnGame.Name = "btnGame";
            this.btnGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGame.Size = new System.Drawing.Size(165, 63);
            this.btnGame.TabIndex = 5;
            this.btnGame.Text = "לשחק משחק טרוויה בנושא";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(189, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(147, 63);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "הוספת תוכן/ שאלה לקיים";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHello);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnAdd;
    }
}