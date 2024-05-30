namespace projekt
{
    partial class subjectPage
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
            label1 = new Label();
            mathButton = new Button();
            engButton = new Button();
            compButton = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(444, 238);
            label1.Name = "label1";
            label1.Size = new Size(371, 46);
            label1.TabIndex = 0;
            label1.Text = "Vad vill du plugga på?";
            // 
            // mathButton
            // 
            mathButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mathButton.Location = new Point(254, 383);
            mathButton.Name = "mathButton";
            mathButton.Size = new Size(170, 57);
            mathButton.TabIndex = 1;
            mathButton.Text = "Matematik";
            mathButton.UseVisualStyleBackColor = true;
            mathButton.Click += mathButton_Click;
            // 
            // engButton
            // 
            engButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            engButton.Location = new Point(532, 383);
            engButton.Name = "engButton";
            engButton.Size = new Size(170, 57);
            engButton.TabIndex = 2;
            engButton.Text = "Engelska";
            engButton.UseVisualStyleBackColor = true;
            engButton.Click += engButton_Click;
            // 
            // compButton
            // 
            compButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            compButton.Location = new Point(815, 383);
            compButton.Name = "compButton";
            compButton.Size = new Size(170, 57);
            compButton.TabIndex = 3;
            compButton.Text = "Datorteknik";
            compButton.UseVisualStyleBackColor = true;
            compButton.Click += compButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(295, 360);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Inte färdig";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(575, 360);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Inte färdig";
            // 
            // subjectPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1210, 751);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(compButton);
            Controls.Add(engButton);
            Controls.Add(mathButton);
            Controls.Add(label1);
            Name = "subjectPage";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button mathButton;
        private Button engButton;
        private Button compButton;
        private Label label2;
        private Label label3;
    }
}