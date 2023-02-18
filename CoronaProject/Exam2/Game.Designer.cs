namespace Exam2
{
    partial class Game
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
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNextQues = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.questionControl = new Exam2.QuestionControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Turquoise;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndGame.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.Location = new System.Drawing.Point(242, 498);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEndGame.Size = new System.Drawing.Size(139, 55);
            this.btnEndGame.TabIndex = 4;
            this.btnEndGame.Text = "סיים משחק";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Turquoise;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(25, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(134, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNextQues
            // 
            this.btnNextQues.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextQues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQues.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQues.Location = new System.Drawing.Point(473, 498);
            this.btnNextQues.Name = "btnNextQues";
            this.btnNextQues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextQues.Size = new System.Drawing.Size(150, 55);
            this.btnNextQues.TabIndex = 20;
            this.btnNextQues.Text = "לשאלה הבאה";
            this.btnNextQues.UseVisualStyleBackColor = false;
            this.btnNextQues.Click += new System.EventHandler(this.btnNextQues_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(109, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(55, 26);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "ניקוד:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(34, 37);
            this.lblScore.Name = "lblScore";
            this.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScore.Size = new System.Drawing.Size(63, 26);
            this.lblScore.TabIndex = 29;
            this.lblScore.Text = "נקודות";
            // 
            // questionControl
            // 
            this.questionControl.IsMultiple = false;
            this.questionControl.Location = new System.Drawing.Point(252, 49);
            this.questionControl.Name = "questionControl";
            this.questionControl.Question = null;
            this.questionControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.questionControl.Size = new System.Drawing.Size(803, 410);
            this.questionControl.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHp
            // 
            this.btnHp.BackColor = System.Drawing.Color.Turquoise;
            this.btnHp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHp.Location = new System.Drawing.Point(974, 498);
            this.btnHp.Name = "btnHp";
            this.btnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHp.Size = new System.Drawing.Size(134, 55);
            this.btnHp.TabIndex = 30;
            this.btnHp.Text = "חזרה לעמוד הראשי";
            this.btnHp.UseVisualStyleBackColor = false;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1120, 570);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.questionControl);
            this.Controls.Add(this.btnNextQues);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEndGame);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNextQues;
        private QuestionControl questionControl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHp;
    }
}