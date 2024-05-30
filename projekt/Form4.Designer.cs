namespace projekt
{
    partial class engPage
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
            backButton = new Button();
            menuButton = new Button();
            engHeadline = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(981, 710);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 4;
            backButton.Text = "Tillbaka";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // menuButton
            // 
            menuButton.Location = new Point(1104, 710);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(94, 29);
            menuButton.TabIndex = 3;
            menuButton.Text = "Meny";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // engHeadline
            // 
            engHeadline.AutoSize = true;
            engHeadline.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            engHeadline.Location = new Point(538, 69);
            engHeadline.Name = "engHeadline";
            engHeadline.Size = new Size(160, 46);
            engHeadline.TabIndex = 5;
            engHeadline.Text = "Engelska";
            // 
            // engPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1210, 751);
            Controls.Add(engHeadline);
            Controls.Add(backButton);
            Controls.Add(menuButton);
            Name = "engPage";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button menuButton;
        private Label engHeadline;
    }
}