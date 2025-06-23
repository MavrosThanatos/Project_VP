namespace Project_VP
{
    partial class Swap
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
            this.question = new System.Windows.Forms.ListBox();
            this.progressBarQuestion = new System.Windows.Forms.ProgressBar();
            this.answerD = new System.Windows.Forms.Button();
            this.answerB = new System.Windows.Forms.Button();
            this.answerC = new System.Windows.Forms.Button();
            this.answerA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.FormattingEnabled = true;
            this.question.ItemHeight = 35;
            this.question.Location = new System.Drawing.Point(12, 70);
            this.question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(854, 72);
            this.question.TabIndex = 18;
            // 
            // progressBarQuestion
            // 
            this.progressBarQuestion.BackColor = System.Drawing.Color.White;
            this.progressBarQuestion.ForeColor = System.Drawing.Color.Navy;
            this.progressBarQuestion.Location = new System.Drawing.Point(12, 365);
            this.progressBarQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarQuestion.Name = "progressBarQuestion";
            this.progressBarQuestion.Size = new System.Drawing.Size(853, 48);
            this.progressBarQuestion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarQuestion.TabIndex = 17;
            this.progressBarQuestion.Value = 100;
            // 
            // answerD
            // 
            this.answerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerD.ForeColor = System.Drawing.Color.White;
            this.answerD.Location = new System.Drawing.Point(446, 266);
            this.answerD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(419, 89);
            this.answerD.TabIndex = 16;
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
            this.answerB.Location = new System.Drawing.Point(12, 266);
            this.answerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(419, 89);
            this.answerB.TabIndex = 15;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = false;
            this.answerB.Click += new System.EventHandler(this.answerB_Click);
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerC.ForeColor = System.Drawing.Color.White;
            this.answerC.Location = new System.Drawing.Point(446, 173);
            this.answerC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(419, 89);
            this.answerC.TabIndex = 14;
            this.answerC.Text = "C";
            this.answerC.UseVisualStyleBackColor = false;
            this.answerC.Click += new System.EventHandler(this.answerC_Click);
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA.ForeColor = System.Drawing.Color.White;
            this.answerA.Location = new System.Drawing.Point(12, 173);
            this.answerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(419, 89);
            this.answerA.TabIndex = 13;
            this.answerA.Text = "A";
            this.answerA.UseVisualStyleBackColor = false;
            this.answerA.Click += new System.EventHandler(this.answerA_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Swap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(883, 426);
            this.Controls.Add(this.question);
            this.Controls.Add(this.progressBarQuestion);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerA);
            this.Name = "Swap";
            this.Text = "Swap";
            this.Load += new System.EventHandler(this.Swap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox question;
        public System.Windows.Forms.ProgressBar progressBarQuestion;
        private System.Windows.Forms.Button answerD;
        private System.Windows.Forms.Button answerB;
        private System.Windows.Forms.Button answerC;
        private System.Windows.Forms.Button answerA;
        private System.Windows.Forms.Timer timer1;
    }
}