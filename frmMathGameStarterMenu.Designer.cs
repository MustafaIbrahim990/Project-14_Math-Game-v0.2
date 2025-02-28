namespace Simple_Math_Game
{
    partial class frmMathGameStarterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathGameStarterMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblOpType = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtPlayerAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckPlayerAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumberOfCorrectAnswer = new System.Windows.Forms.Label();
            this.lblNumberOfWrongAnswer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question :";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(487, 30);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(28, 32);
            this.lblCurrentQuestion.TabIndex = 4;
            this.lblCurrentQuestion.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(521, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(549, 30);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(28, 32);
            this.lblNumberOfQuestion.TabIndex = 6;
            this.lblNumberOfQuestion.Text = "0";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumber1.Location = new System.Drawing.Point(487, 201);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(28, 32);
            this.lblNumber1.TabIndex = 7;
            this.lblNumber1.Text = "0";
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOpType.Location = new System.Drawing.Point(429, 243);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(55, 35);
            this.lblOpType.TabIndex = 8;
            this.lblOpType.Text = "Op";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumber2.Location = new System.Drawing.Point(487, 296);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(28, 32);
            this.lblNumber2.TabIndex = 9;
            this.lblNumber2.Text = "0";
            // 
            // txtPlayerAnswer
            // 
            this.txtPlayerAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlayerAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerAnswer.ForeColor = System.Drawing.Color.Blue;
            this.txtPlayerAnswer.Location = new System.Drawing.Point(416, 350);
            this.txtPlayerAnswer.Name = "txtPlayerAnswer";
            this.txtPlayerAnswer.Size = new System.Drawing.Size(170, 39);
            this.txtPlayerAnswer.TabIndex = 0;
            this.txtPlayerAnswer.TextChanged += new System.EventHandler(this.txtPlayerAnswer_TextChanged);
            this.txtPlayerAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayerAnswer_Validating);
            // 
            // btnCheckPlayerAnswer
            // 
            this.btnCheckPlayerAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheckPlayerAnswer.Enabled = false;
            this.btnCheckPlayerAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPlayerAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPlayerAnswer.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckPlayerAnswer.Location = new System.Drawing.Point(415, 411);
            this.btnCheckPlayerAnswer.Name = "btnCheckPlayerAnswer";
            this.btnCheckPlayerAnswer.Size = new System.Drawing.Size(170, 58);
            this.btnCheckPlayerAnswer.TabIndex = 1;
            this.btnCheckPlayerAnswer.Text = "Check";
            this.btnCheckPlayerAnswer.UseVisualStyleBackColor = false;
            this.btnCheckPlayerAnswer.Click += new System.EventHandler(this.btnCheckPlayerAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Blue;
            this.btnNextQuestion.Location = new System.Drawing.Point(311, 556);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(170, 58);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Simple_Math_Game.Properties.Resources.photo_2023_11_20_17_27_26;
            this.pictureBox3.Location = new System.Drawing.Point(918, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Simple_Math_Game.Properties.Resources.for_children;
            this.pictureBox2.Location = new System.Drawing.Point(732, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Simple_Math_Game.Properties.Resources.photo_2024_02_18_20_14_25;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTimer.Location = new System.Drawing.Point(863, 261);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(40, 45);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(527, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(12, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 49);
            this.label9.TabIndex = 16;
            this.label9.Text = "✅";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 49);
            this.label10.TabIndex = 17;
            this.label10.Text = "❎";
            // 
            // lblNumberOfCorrectAnswer
            // 
            this.lblNumberOfCorrectAnswer.AutoSize = true;
            this.lblNumberOfCorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCorrectAnswer.ForeColor = System.Drawing.Color.Lime;
            this.lblNumberOfCorrectAnswer.Location = new System.Drawing.Point(89, 281);
            this.lblNumberOfCorrectAnswer.Name = "lblNumberOfCorrectAnswer";
            this.lblNumberOfCorrectAnswer.Size = new System.Drawing.Size(44, 49);
            this.lblNumberOfCorrectAnswer.TabIndex = 18;
            this.lblNumberOfCorrectAnswer.Text = "0";
            // 
            // lblNumberOfWrongAnswer
            // 
            this.lblNumberOfWrongAnswer.AutoSize = true;
            this.lblNumberOfWrongAnswer.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWrongAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfWrongAnswer.Location = new System.Drawing.Point(89, 354);
            this.lblNumberOfWrongAnswer.Name = "lblNumberOfWrongAnswer";
            this.lblNumberOfWrongAnswer.Size = new System.Drawing.Size(44, 49);
            this.lblNumberOfWrongAnswer.TabIndex = 19;
            this.lblNumberOfWrongAnswer.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMathGameStarterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 650);
            this.Controls.Add(this.lblNumberOfWrongAnswer);
            this.Controls.Add(this.lblNumberOfCorrectAnswer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnCheckPlayerAnswer);
            this.Controls.Add(this.txtPlayerAnswer);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblOpType);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblNumberOfQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMathGameStarterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.frmMathGameStarterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblOpType;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtPlayerAnswer;
        private System.Windows.Forms.Button btnCheckPlayerAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumberOfCorrectAnswer;
        private System.Windows.Forms.Label lblNumberOfWrongAnswer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}