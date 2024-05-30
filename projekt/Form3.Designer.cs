namespace projekt
{
    partial class mathPage
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
            mathHeadline = new Label();
            menuButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // mathHeadline
            // 
            mathHeadline.AutoSize = true;
            mathHeadline.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            mathHeadline.Location = new Point(538, 69);
            mathHeadline.Name = "mathHeadline";
            mathHeadline.Size = new Size(193, 46);
            mathHeadline.TabIndex = 0;
            mathHeadline.Text = "Matematik";
            mathHeadline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            menuButton.Location = new Point(1104, 710);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(94, 29);
            menuButton.TabIndex = 1;
            menuButton.Text = "Meny";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(981, 710);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 2;
            backButton.Text = "Tillbaka";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // mathPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1210, 751);
            Controls.Add(backButton);
            Controls.Add(menuButton);
            Controls.Add(mathHeadline);
            Name = "mathPage";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mathHeadline;
        private Button menuButton;
        private Button backButton;
    }
}