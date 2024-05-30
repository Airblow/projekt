namespace projekt
{
    partial class startPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTitle = new Label();
            start = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            mainTitle.Location = new Point(451, 296);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(316, 46);
            mainTitle.TabIndex = 0;
            mainTitle.Text = "Pluggprogrammet";
            mainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            start.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            start.Location = new Point(500, 364);
            start.Name = "start";
            start.Size = new Size(213, 74);
            start.TabIndex = 1;
            start.Text = "Börja";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(517, 247);
            label1.Name = "label1";
            label1.Size = new Size(179, 35);
            label1.TabIndex = 2;
            label1.Text = "Välkommen till";
            // 
            // startPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1210, 751);
            Controls.Add(label1);
            Controls.Add(start);
            Controls.Add(mainTitle);
            Name = "startPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTitle;
        private Button start;
        private Label label1;
    }
}