namespace SheetM
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.pictureBoxAnswersToCompare = new System.Windows.Forms.PictureBox();
            this.btnLoadAnswersToCompare = new System.Windows.Forms.Button();
            this.btnLoadCorrectAnswer = new System.Windows.Forms.Button();
            this.pictureBoxCorrectAnswers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswersToCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrectAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(1477, 931);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(93, 36);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "label2";
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswers.Location = new System.Drawing.Point(1477, 1012);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(93, 36);
            this.labelCorrectAnswers.TabIndex = 23;
            this.labelCorrectAnswers.Text = "label1";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(1648, 27);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(773, 886);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 22;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(966, 997);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(343, 93);
            this.btnProcessImage.TabIndex = 21;
            this.btnProcessImage.Text = "button2";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // pictureBoxAnswersToCompare
            // 
            this.pictureBoxAnswersToCompare.Location = new System.Drawing.Point(840, 27);
            this.pictureBoxAnswersToCompare.Name = "pictureBoxAnswersToCompare";
            this.pictureBoxAnswersToCompare.Size = new System.Drawing.Size(773, 886);
            this.pictureBoxAnswersToCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnswersToCompare.TabIndex = 20;
            this.pictureBoxAnswersToCompare.TabStop = false;
            // 
            // btnLoadAnswersToCompare
            // 
            this.btnLoadAnswersToCompare.Location = new System.Drawing.Point(568, 997);
            this.btnLoadAnswersToCompare.Name = "btnLoadAnswersToCompare";
            this.btnLoadAnswersToCompare.Size = new System.Drawing.Size(343, 93);
            this.btnLoadAnswersToCompare.TabIndex = 19;
            this.btnLoadAnswersToCompare.Text = "button2";
            this.btnLoadAnswersToCompare.UseVisualStyleBackColor = true;
            // 
            // btnLoadCorrectAnswer
            // 
            this.btnLoadCorrectAnswer.Location = new System.Drawing.Point(166, 997);
            this.btnLoadCorrectAnswer.Name = "btnLoadCorrectAnswer";
            this.btnLoadCorrectAnswer.Size = new System.Drawing.Size(343, 93);
            this.btnLoadCorrectAnswer.TabIndex = 18;
            this.btnLoadCorrectAnswer.Text = "button1";
            this.btnLoadCorrectAnswer.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCorrectAnswers
            // 
            this.pictureBoxCorrectAnswers.Location = new System.Drawing.Point(39, 27);
            this.pictureBoxCorrectAnswers.Name = "pictureBoxCorrectAnswers";
            this.pictureBoxCorrectAnswers.Size = new System.Drawing.Size(773, 886);
            this.pictureBoxCorrectAnswers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCorrectAnswers.TabIndex = 17;
            this.pictureBoxCorrectAnswers.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1410);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCorrectAnswers);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.pictureBoxAnswersToCompare);
            this.Controls.Add(this.btnLoadAnswersToCompare);
            this.Controls.Add(this.btnLoadCorrectAnswer);
            this.Controls.Add(this.pictureBoxCorrectAnswers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswersToCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrectAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCorrectAnswers;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.PictureBox pictureBoxAnswersToCompare;
        private System.Windows.Forms.Button btnLoadAnswersToCompare;
        private System.Windows.Forms.Button btnLoadCorrectAnswer;
        private System.Windows.Forms.PictureBox pictureBoxCorrectAnswers;
    }
}

