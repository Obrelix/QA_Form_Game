namespace QA_FormGame
{
    partial class frm_StartGame
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
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstb_Profiles = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_HighScores = new System.Windows.Forms.Button();
            this.pnl_Add = new System.Windows.Forms.Panel();
            this.pnl_Psw = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_Psw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkb_AddNew = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.pnl_Add.SuspendLayout();
            this.pnl_Psw.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(62, 3);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.Size = new System.Drawing.Size(100, 20);
            this.txtb_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // lstb_Profiles
            // 
            this.lstb_Profiles.FormattingEnabled = true;
            this.lstb_Profiles.Location = new System.Drawing.Point(14, 25);
            this.lstb_Profiles.Name = "lstb_Profiles";
            this.lstb_Profiles.Size = new System.Drawing.Size(244, 95);
            this.lstb_Profiles.TabIndex = 2;
            this.lstb_Profiles.SelectedIndexChanged += new System.EventHandler(this.lstb_Profiles_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(186, 29);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtb_Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txtb_Name);
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 52);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(62, 29);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.Size = new System.Drawing.Size(100, 20);
            this.txtb_Password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add  a new Profile";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(264, 65);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(75, 23);
            this.btn_StartGame.TabIndex = 6;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_HighScores
            // 
            this.btn_HighScores.Location = new System.Drawing.Point(264, 25);
            this.btn_HighScores.Name = "btn_HighScores";
            this.btn_HighScores.Size = new System.Drawing.Size(75, 23);
            this.btn_HighScores.TabIndex = 7;
            this.btn_HighScores.Text = "High Scores";
            this.btn_HighScores.UseVisualStyleBackColor = true;
            // 
            // pnl_Add
            // 
            this.pnl_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add.Controls.Add(this.panel1);
            this.pnl_Add.Controls.Add(this.label3);
            this.pnl_Add.Location = new System.Drawing.Point(14, 149);
            this.pnl_Add.Name = "pnl_Add";
            this.pnl_Add.Size = new System.Drawing.Size(244, 79);
            this.pnl_Add.TabIndex = 8;
            this.pnl_Add.Visible = false;
            // 
            // pnl_Psw
            // 
            this.pnl_Psw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Psw.Controls.Add(this.panel4);
            this.pnl_Psw.Controls.Add(this.label7);
            this.pnl_Psw.Location = new System.Drawing.Point(14, 149);
            this.pnl_Psw.Name = "pnl_Psw";
            this.pnl_Psw.Size = new System.Drawing.Size(244, 51);
            this.pnl_Psw.TabIndex = 9;
            this.pnl_Psw.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtb_Psw);
            this.panel4.Location = new System.Drawing.Point(3, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 52);
            this.panel4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // txtb_Psw
            // 
            this.txtb_Psw.Location = new System.Drawing.Point(61, 3);
            this.txtb_Psw.Name = "txtb_Psw";
            this.txtb_Psw.Size = new System.Drawing.Size(100, 20);
            this.txtb_Psw.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Write your Password";
            // 
            // chkb_AddNew
            // 
            this.chkb_AddNew.AutoSize = true;
            this.chkb_AddNew.Location = new System.Drawing.Point(158, 126);
            this.chkb_AddNew.Name = "chkb_AddNew";
            this.chkb_AddNew.Size = new System.Drawing.Size(100, 17);
            this.chkb_AddNew.TabIndex = 10;
            this.chkb_AddNew.Text = "Add new Profile";
            this.chkb_AddNew.UseVisualStyleBackColor = true;
            this.chkb_AddNew.CheckedChanged += new System.EventHandler(this.chkb_AddNew_CheckedChanged);
            // 
            // frm_StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 242);
            this.Controls.Add(this.chkb_AddNew);
            this.Controls.Add(this.pnl_Psw);
            this.Controls.Add(this.pnl_Add);
            this.Controls.Add(this.btn_HighScores);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstb_Profiles);
            this.Name = "frm_StartGame";
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_StartGame_FormClosing);
            this.Load += new System.EventHandler(this.frm_StartGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Add.ResumeLayout(false);
            this.pnl_Add.PerformLayout();
            this.pnl_Psw.ResumeLayout(false);
            this.pnl_Psw.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstb_Profiles;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_HighScores;
        private System.Windows.Forms.Panel pnl_Add;
        private System.Windows.Forms.Panel pnl_Psw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_Psw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkb_AddNew;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

