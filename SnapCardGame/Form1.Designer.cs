namespace SnapCardGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbMatchCase = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFlipCard1 = new System.Windows.Forms.Button();
            this.btnSnapHitP1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScoreBoard1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFlipCard2 = new System.Windows.Forms.Button();
            this.btnSnapHitP2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreBoard2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbMatchCase
            // 
            this.cmbMatchCase.FormattingEnabled = true;
            this.cmbMatchCase.Location = new System.Drawing.Point(418, 23);
            this.cmbMatchCase.Name = "cmbMatchCase";
            this.cmbMatchCase.Size = new System.Drawing.Size(199, 21);
            this.cmbMatchCase.TabIndex = 1;
            this.cmbMatchCase.Text = "Rank";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(604, 296);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFlipCard1);
            this.groupBox1.Controls.Add(this.btnSnapHitP1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtScoreBoard1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // btnFlipCard1
            // 
            this.btnFlipCard1.Location = new System.Drawing.Point(10, 71);
            this.btnFlipCard1.Name = "btnFlipCard1";
            this.btnFlipCard1.Size = new System.Drawing.Size(184, 23);
            this.btnFlipCard1.TabIndex = 2;
            this.btnFlipCard1.Tag = "1";
            this.btnFlipCard1.Text = "Flip Card";
            this.btnFlipCard1.UseVisualStyleBackColor = true;
            this.btnFlipCard1.Click += new System.EventHandler(this.btnFlipCard1_Click);
            // 
            // btnSnapHitP1
            // 
            this.btnSnapHitP1.Location = new System.Drawing.Point(10, 46);
            this.btnSnapHitP1.Name = "btnSnapHitP1";
            this.btnSnapHitP1.Size = new System.Drawing.Size(184, 23);
            this.btnSnapHitP1.TabIndex = 2;
            this.btnSnapHitP1.Text = "Snap Hit Player 1";
            this.btnSnapHitP1.UseVisualStyleBackColor = true;
            this.btnSnapHitP1.Click += new System.EventHandler(this.btnSnapHitP1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtScoreBoard1
            // 
            this.txtScoreBoard1.Location = new System.Drawing.Point(94, 20);
            this.txtScoreBoard1.Name = "txtScoreBoard1";
            this.txtScoreBoard1.ReadOnly = true;
            this.txtScoreBoard1.Size = new System.Drawing.Size(100, 20);
            this.txtScoreBoard1.TabIndex = 1;
            this.txtScoreBoard1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score Board";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFlipCard2);
            this.groupBox2.Controls.Add(this.btnSnapHitP2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtScoreBoard2);
            this.groupBox2.Location = new System.Drawing.Point(318, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // btnFlipCard2
            // 
            this.btnFlipCard2.Location = new System.Drawing.Point(100, 71);
            this.btnFlipCard2.Name = "btnFlipCard2";
            this.btnFlipCard2.Size = new System.Drawing.Size(184, 23);
            this.btnFlipCard2.TabIndex = 2;
            this.btnFlipCard2.Tag = "2";
            this.btnFlipCard2.Text = "Flip Card";
            this.btnFlipCard2.UseVisualStyleBackColor = true;
            this.btnFlipCard2.Click += new System.EventHandler(this.btnFlipCard1_Click);
            // 
            // btnSnapHitP2
            // 
            this.btnSnapHitP2.Location = new System.Drawing.Point(100, 46);
            this.btnSnapHitP2.Name = "btnSnapHitP2";
            this.btnSnapHitP2.Size = new System.Drawing.Size(184, 23);
            this.btnSnapHitP2.TabIndex = 2;
            this.btnSnapHitP2.Text = "Snap Hit Player 2";
            this.btnSnapHitP2.UseVisualStyleBackColor = true;
            this.btnSnapHitP2.Click += new System.EventHandler(this.btnSnapHitP2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score Board";
            // 
            // txtScoreBoard2
            // 
            this.txtScoreBoard2.Location = new System.Drawing.Point(184, 20);
            this.txtScoreBoard2.Name = "txtScoreBoard2";
            this.txtScoreBoard2.ReadOnly = true;
            this.txtScoreBoard2.Size = new System.Drawing.Size(100, 20);
            this.txtScoreBoard2.TabIndex = 1;
            this.txtScoreBoard2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Card in Deck";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbMatchCase);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbMatchCase;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFlipCard1;
        private System.Windows.Forms.Button btnSnapHitP1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtScoreBoard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFlipCard2;
        private System.Windows.Forms.Button btnSnapHitP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreBoard2;
        private System.Windows.Forms.Label label1;
    }
}

