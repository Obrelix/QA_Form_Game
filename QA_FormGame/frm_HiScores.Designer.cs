namespace QA_FormGame
{
    partial class frm_HiScores
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
            this.lstb_HiScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstb_HiScores
            // 
            this.lstb_HiScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstb_HiScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstb_HiScores.FormattingEnabled = true;
            this.lstb_HiScores.ItemHeight = 20;
            this.lstb_HiScores.Location = new System.Drawing.Point(12, 12);
            this.lstb_HiScores.Name = "lstb_HiScores";
            this.lstb_HiScores.Size = new System.Drawing.Size(260, 224);
            this.lstb_HiScores.TabIndex = 0;
            // 
            // frm_HiScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstb_HiScores);
            this.Name = "frm_HiScores";
            this.Text = "Hi Scores";
            this.Load += new System.EventHandler(this.frm_HiScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_HiScores;
    }
}