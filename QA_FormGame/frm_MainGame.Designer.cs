namespace QA_FormGame
{
    partial class frm_MainGame
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
            this.txtb_Insert = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_lettersUsed = new System.Windows.Forms.Label();
            this.pgrbrLife = new System.Windows.Forms.ProgressBar();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlWord = new System.Windows.Forms.Panel();
            this.lblLifesLeft = new System.Windows.Forms.Label();
            this.lblDificulty = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblHintLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlStats.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_Insert
            // 
            this.txtb_Insert.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtb_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtb_Insert.Location = new System.Drawing.Point(33, 201);
            this.txtb_Insert.MaxLength = 1;
            this.txtb_Insert.Name = "txtb_Insert";
            this.txtb_Insert.Size = new System.Drawing.Size(74, 35);
            this.txtb_Insert.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Confirm.Location = new System.Drawing.Point(113, 201);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(67, 37);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_lettersUsed
            // 
            this.lbl_lettersUsed.AutoSize = true;
            this.lbl_lettersUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_lettersUsed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_lettersUsed.Location = new System.Drawing.Point(29, 175);
            this.lbl_lettersUsed.Name = "lbl_lettersUsed";
            this.lbl_lettersUsed.Size = new System.Drawing.Size(118, 20);
            this.lbl_lettersUsed.TabIndex = 2;
            this.lbl_lettersUsed.Text = "Letters Used:";
            // 
            // pgrbrLife
            // 
            this.pgrbrLife.Location = new System.Drawing.Point(245, 4);
            this.pgrbrLife.Name = "pgrbrLife";
            this.pgrbrLife.Size = new System.Drawing.Size(125, 23);
            this.pgrbrLife.TabIndex = 3;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLife.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLife.Location = new System.Drawing.Point(143, 6);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(96, 20);
            this.lblLife.TabIndex = 4;
            this.lblLife.Text = "Current Life:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTime.Location = new System.Drawing.Point(91, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "15\"";
            // 
            // tmrCounter
            // 
            this.tmrCounter.Enabled = true;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMessage.Location = new System.Drawing.Point(186, 211);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(54, 20);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "lblmsg";
            // 
            // pnlWord
            // 
            this.pnlWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWord.Location = new System.Drawing.Point(33, 23);
            this.pnlWord.Name = "pnlWord";
            this.pnlWord.Size = new System.Drawing.Size(814, 112);
            this.pnlWord.TabIndex = 7;
            // 
            // lblLifesLeft
            // 
            this.lblLifesLeft.AutoSize = true;
            this.lblLifesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLifesLeft.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLifesLeft.Location = new System.Drawing.Point(389, 6);
            this.lblLifesLeft.Name = "lblLifesLeft";
            this.lblLifesLeft.Size = new System.Drawing.Size(77, 20);
            this.lblLifesLeft.TabIndex = 8;
            this.lblLifesLeft.Text = "Lifes left :";
            // 
            // lblDificulty
            // 
            this.lblDificulty.AutoSize = true;
            this.lblDificulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDificulty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDificulty.Location = new System.Drawing.Point(631, 6);
            this.lblDificulty.Name = "lblDificulty";
            this.lblDificulty.Size = new System.Drawing.Size(113, 20);
            this.lblDificulty.TabIndex = 9;
            this.lblDificulty.Text = "Dificulty Level :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblScore.Location = new System.Drawing.Point(316, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 20);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score :";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHighScore.Location = new System.Drawing.Point(572, 4);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(96, 20);
            this.lblHighScore.TabIndex = 11;
            this.lblHighScore.Text = "High Score :";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblDificulty);
            this.pnlStats.Controls.Add(this.lblHintLeft);
            this.pnlStats.Controls.Add(this.pgrbrLife);
            this.pnlStats.Controls.Add(this.label1);
            this.pnlStats.Controls.Add(this.lblLife);
            this.pnlStats.Controls.Add(this.lblLifesLeft);
            this.pnlStats.Controls.Add(this.lblTime);
            this.pnlStats.Location = new System.Drawing.Point(33, 141);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(814, 31);
            this.pnlStats.TabIndex = 13;
            this.pnlStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStats_Paint);
            // 
            // lblHintLeft
            // 
            this.lblHintLeft.AutoSize = true;
            this.lblHintLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHintLeft.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblHintLeft.Location = new System.Drawing.Point(513, 6);
            this.lblHintLeft.Name = "lblHintLeft";
            this.lblHintLeft.Size = new System.Drawing.Size(82, 20);
            this.lblHintLeft.TabIndex = 15;
            this.lblHintLeft.Text = "Hints Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time Left:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlayerName.Location = new System.Drawing.Point(3, 4);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(102, 20);
            this.lblPlayerName.TabIndex = 15;
            this.lblPlayerName.Text = "Player Name:";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.lblScore);
            this.pnlPlayer.Controls.Add(this.lblPlayerName);
            this.pnlPlayer.Controls.Add(this.lblHighScore);
            this.pnlPlayer.Location = new System.Drawing.Point(33, 244);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(814, 30);
            this.pnlPlayer.TabIndex = 16;
            // 
            // frm_MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlWord);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbl_lettersUsed);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txtb_Insert);
            this.MaximumSize = new System.Drawing.Size(900, 350);
            this.MinimumSize = new System.Drawing.Size(900, 350);
            this.Name = "frm_MainGame";
            this.Text = "frm_MainGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MainGame_FormClosing);
            this.Load += new System.EventHandler(this.frm_MainGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MainGame_KeyDown);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_Insert;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_lettersUsed;
        private System.Windows.Forms.ProgressBar pgrbrLife;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlWord;
        private System.Windows.Forms.Label lblLifesLeft;
        private System.Windows.Forms.Label lblDificulty;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblHintLeft;
    }
}