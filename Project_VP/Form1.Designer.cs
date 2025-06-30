namespace Project_VP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answerA = new System.Windows.Forms.Button();
            this.answerC = new System.Windows.Forms.Button();
            this.answerD = new System.Windows.Forms.Button();
            this.answerB = new System.Windows.Forms.Button();
            this.progressBarQuestion = new System.Windows.Forms.ProgressBar();
            this.prizeList = new System.Windows.Forms.CheckedListBox();
            this.joker1 = new System.Windows.Forms.Button();
            this.joker2 = new System.Windows.Forms.Button();
            this.joker3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.question = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA.ForeColor = System.Drawing.Color.White;
            this.answerA.Location = new System.Drawing.Point(44, 280);
            this.answerA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(314, 72);
            this.answerA.TabIndex = 1;
            this.answerA.Text = "A";
            this.answerA.UseVisualStyleBackColor = false;
            this.answerA.Click += new System.EventHandler(this.answerA_Click);
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerC.ForeColor = System.Drawing.Color.White;
            this.answerC.Location = new System.Drawing.Point(370, 280);
            this.answerC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(314, 72);
            this.answerC.TabIndex = 2;
            this.answerC.Text = "C";
            this.answerC.UseVisualStyleBackColor = false;
            this.answerC.Click += new System.EventHandler(this.answerC_Click);
            // 
            // answerD
            // 
            this.answerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerD.ForeColor = System.Drawing.Color.White;
            this.answerD.Location = new System.Drawing.Point(370, 356);
            this.answerD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(314, 72);
            this.answerD.TabIndex = 4;
            this.answerD.Text = "D";
            this.answerD.UseVisualStyleBackColor = false;
            this.answerD.Click += new System.EventHandler(this.answerD_Click);
            // 
            // answerB
            // 
            this.answerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerB.ForeColor = System.Drawing.Color.White;
            this.answerB.Location = new System.Drawing.Point(44, 356);
            this.answerB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(314, 72);
            this.answerB.TabIndex = 3;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = false;
            this.answerB.Click += new System.EventHandler(this.answerB_Click);
            // 
            // progressBarQuestion
            // 
            this.progressBarQuestion.BackColor = System.Drawing.Color.White;
            this.progressBarQuestion.ForeColor = System.Drawing.Color.Navy;
            this.progressBarQuestion.Location = new System.Drawing.Point(44, 436);
            this.progressBarQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarQuestion.Name = "progressBarQuestion";
            this.progressBarQuestion.Size = new System.Drawing.Size(640, 39);
            this.progressBarQuestion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarQuestion.TabIndex = 5;
            this.progressBarQuestion.Value = 100;
            // 
            // prizeList
            // 
            this.prizeList.BackColor = System.Drawing.Color.Blue;
            this.prizeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeList.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.prizeList.ForeColor = System.Drawing.Color.White;
            this.prizeList.FormattingEnabled = true;
            this.prizeList.Items.AddRange(new object[] {
            "$1,000,000",
            "$500,000",
            "$250,000",
            "$125.000",
            "$64,000",
            "$32,000",
            "$16,000",
            "$8,000",
            "$4,000",
            "$2,000",
            "$1,000",
            "$500",
            "$300",
            "$200",
            "$100"});
            this.prizeList.Location = new System.Drawing.Point(739, 41);
            this.prizeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prizeList.Name = "prizeList";
            this.prizeList.Size = new System.Drawing.Size(238, 407);
            this.prizeList.TabIndex = 7;
            this.prizeList.UseTabStops = false;
            // 
            // joker1
            // 
            this.joker1.BackColor = System.Drawing.Color.Blue;
            this.joker1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker1.ForeColor = System.Drawing.Color.White;
            this.joker1.Location = new System.Drawing.Point(739, 5);
            this.joker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joker1.Name = "joker1";
            this.joker1.Size = new System.Drawing.Size(30, 32);
            this.joker1.TabIndex = 8;
            this.joker1.Text = "⌛";
            this.joker1.UseVisualStyleBackColor = false;
            this.joker1.Click += new System.EventHandler(this.joker1_Click);
            // 
            // joker2
            // 
            this.joker2.BackColor = System.Drawing.Color.Blue;
            this.joker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker2.ForeColor = System.Drawing.Color.White;
            this.joker2.Location = new System.Drawing.Point(773, 5);
            this.joker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joker2.Name = "joker2";
            this.joker2.Size = new System.Drawing.Size(80, 32);
            this.joker2.TabIndex = 9;
            this.joker2.Text = " ? ? ? ";
            this.joker2.UseVisualStyleBackColor = false;
            this.joker2.Click += new System.EventHandler(this.joker2_Click);
            // 
            // joker3
            // 
            this.joker3.BackColor = System.Drawing.Color.Blue;
            this.joker3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker3.ForeColor = System.Drawing.Color.White;
            this.joker3.Location = new System.Drawing.Point(857, 5);
            this.joker3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joker3.Name = "joker3";
            this.joker3.Size = new System.Drawing.Size(83, 32);
            this.joker3.TabIndex = 10;
            this.joker3.Text = "X O X";
            this.joker3.UseVisualStyleBackColor = false;
            this.joker3.Click += new System.EventHandler(this.joker3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(947, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "🔄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerQuestion
            // 
            this.timerQuestion.Enabled = true;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.FormattingEnabled = true;
            this.question.ItemHeight = 27;
            this.question.Location = new System.Drawing.Point(44, 188);
            this.question.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(641, 56);
            this.question.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 494);
            this.Controls.Add(this.question);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.joker3);
            this.Controls.Add(this.joker2);
            this.Controls.Add(this.joker1);
            this.Controls.Add(this.prizeList);
            this.Controls.Add(this.progressBarQuestion);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WHO WANTS TO BE A MILLIONAIRE?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button answerA;
        private System.Windows.Forms.Button answerC;
        private System.Windows.Forms.Button answerD;
        private System.Windows.Forms.Button answerB;
        private System.Windows.Forms.CheckedListBox prizeList;
        private System.Windows.Forms.Button joker1;
        private System.Windows.Forms.Button joker2;
        private System.Windows.Forms.Button joker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerQuestion;
        public System.Windows.Forms.ProgressBar progressBarQuestion;
        private System.Windows.Forms.ListBox question;
    }
}

