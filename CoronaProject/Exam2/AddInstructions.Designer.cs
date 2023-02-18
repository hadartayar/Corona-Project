namespace Exam2
{
    partial class AddInstructions
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(310, 42);
            this.lblHello.Name = "lblHello";
            this.lblHello.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHello.Size = new System.Drawing.Size(418, 29);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "שלום! תודה שבחרתם להוסיף תוכן לאתר שלנו !";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(345, 125);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInstructions.Size = new System.Drawing.Size(323, 23);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "כעת תבחרו איזה סוג מידע תרצו להוסיף-";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.Location = new System.Drawing.Point(608, 249);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLearn.Size = new System.Drawing.Size(147, 63);
            this.btnLearn.TabIndex = 6;
            this.btnLearn.Text = "הוספת תוכן לימוד";
            this.btnLearn.UseVisualStyleBackColor = false;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGame.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(280, 249);
            this.btnGame.Name = "btnGame";
            this.btnGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGame.Size = new System.Drawing.Size(147, 63);
            this.btnGame.TabIndex = 7;
            this.btnGame.Text = "הוספת שאלת טריוויה";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(21, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(106, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHp
            // 
            this.btnHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHp.Location = new System.Drawing.Point(958, 450);
            this.btnHp.Name = "btnHp";
            this.btnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHp.Size = new System.Drawing.Size(106, 47);
            this.btnHp.TabIndex = 9;
            this.btnHp.Text = "חזרה לעמוד הראשי";
            this.btnHp.UseVisualStyleBackColor = false;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // AddInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1076, 509);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblHello);
            this.Name = "AddInstructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHp;
    }
}