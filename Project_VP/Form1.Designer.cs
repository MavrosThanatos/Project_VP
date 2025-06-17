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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.answerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA.ForeColor = System.Drawing.Color.White;
            this.answerA.Location = new System.Drawing.Point(12, 338);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(200, 50);
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
            this.answerC.Location = new System.Drawing.Point(312, 338);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(200, 50);
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
            this.answerD.Location = new System.Drawing.Point(312, 408);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(200, 50);
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
            this.answerB.Location = new System.Drawing.Point(12, 408);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(200, 50);
            this.answerB.TabIndex = 3;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = false;
            this.answerB.Click += new System.EventHandler(this.answerB_Click);
            // 
            // progressBarQuestion
            // 
            this.progressBarQuestion.BackColor = System.Drawing.Color.White;
            this.progressBarQuestion.ForeColor = System.Drawing.Color.Navy;
            this.progressBarQuestion.Location = new System.Drawing.Point(12, 464);
            this.progressBarQuestion.Name = "progressBarQuestion";
            this.progressBarQuestion.Size = new System.Drawing.Size(500, 10);
            this.progressBarQuestion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarQuestion.TabIndex = 5;
            this.progressBarQuestion.Value = 100;
            // 
            // prizeList
            // 
            this.prizeList.BackColor = System.Drawing.Color.Blue;
            this.prizeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.prizeList.Location = new System.Drawing.Point(582, 70);
            this.prizeList.Name = "prizeList";
            this.prizeList.Size = new System.Drawing.Size(200, 402);
            this.prizeList.TabIndex = 7;
            this.prizeList.UseTabStops = false;
            // 
            // joker1
            // 
            this.joker1.BackColor = System.Drawing.Color.Blue;
            this.joker1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker1.ForeColor = System.Drawing.Color.White;
            this.joker1.Location = new System.Drawing.Point(12, 31);
            this.joker1.Name = "joker1";
            this.joker1.Size = new System.Drawing.Size(40, 40);
            this.joker1.TabIndex = 8;
            this.joker1.Text = "⌛";
            this.joker1.UseVisualStyleBackColor = false;
            // 
            // joker2
            // 
            this.joker2.BackColor = System.Drawing.Color.Blue;
            this.joker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker2.ForeColor = System.Drawing.Color.White;
            this.joker2.Location = new System.Drawing.Point(58, 31);
            this.joker2.Name = "joker2";
            this.joker2.Size = new System.Drawing.Size(107, 40);
            this.joker2.TabIndex = 9;
            this.joker2.Text = "🃏🃏";
            this.joker2.UseVisualStyleBackColor = false;
            // 
            // joker3
            // 
            this.joker3.BackColor = System.Drawing.Color.Blue;
            this.joker3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joker3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joker3.ForeColor = System.Drawing.Color.White;
            this.joker3.Location = new System.Drawing.Point(171, 31);
            this.joker3.Name = "joker3";
            this.joker3.Size = new System.Drawing.Size(111, 40);
            this.joker3.TabIndex = 10;
            this.joker3.Text = "X O X";
            this.joker3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "🔄";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timerQuestion
            // 
            this.timerQuestion.Enabled = true;
            this.timerQuestion.Interval = 300;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.FormattingEnabled = true;
            this.question.ItemHeight = 35;
            this.question.Location = new System.Drawing.Point(12, 258);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(500, 72);
            this.question.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 486);
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
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WHO WANTS TO BE A MILLIONAIRE?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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

