namespace projekt
{
    partial class compPage
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
            label1 = new Label();
            label2 = new Label();
            memoryButtonComp = new Button();
            netButtonComp = new Button();
            operButtonComp = new Button();
            hardButtonComp = new Button();
            historyButtonComp = new Button();
            resetButtonComp = new Button();
            label3 = new Label();
            questionComp = new Label();
            label5 = new Label();
            answerBoxComp = new TextBox();
            answerSubmitComp = new Button();
            label6 = new Label();
            infoBoxComp = new Label();
            corAnswerCompLabel = new Label();
            correctAnswerComp = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(521, 69);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 5;
            label1.Text = "Datorteknik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 232);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 6;
            label2.Text = "Delar";
            // 
            // memoryButtonComp
            // 
            memoryButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            memoryButtonComp.Location = new Point(48, 380);
            memoryButtonComp.Name = "memoryButtonComp";
            memoryButtonComp.Size = new Size(150, 40);
            memoryButtonComp.TabIndex = 7;
            memoryButtonComp.Text = "Lagring och Minne";
            memoryButtonComp.UseVisualStyleBackColor = true;
            memoryButtonComp.Click += memoryButtonComp_Click;
            // 
            // netButtonComp
            // 
            netButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            netButtonComp.Location = new Point(48, 430);
            netButtonComp.Name = "netButtonComp";
            netButtonComp.Size = new Size(150, 40);
            netButtonComp.TabIndex = 8;
            netButtonComp.Text = "Nätverk";
            netButtonComp.UseVisualStyleBackColor = true;
            netButtonComp.Click += netButtonComp_Click;
            // 
            // operButtonComp
            // 
            operButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            operButtonComp.Location = new Point(48, 480);
            operButtonComp.Name = "operButtonComp";
            operButtonComp.Size = new Size(150, 40);
            operButtonComp.TabIndex = 9;
            operButtonComp.Text = "Operativsystem";
            operButtonComp.UseVisualStyleBackColor = true;
            operButtonComp.Click += operButtonComp_Click;
            // 
            // hardButtonComp
            // 
            hardButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hardButtonComp.Location = new Point(48, 330);
            hardButtonComp.Name = "hardButtonComp";
            hardButtonComp.Size = new Size(150, 40);
            hardButtonComp.TabIndex = 10;
            hardButtonComp.Text = "Hårdvara";
            hardButtonComp.UseVisualStyleBackColor = true;
            hardButtonComp.Click += hardButtonComp_Click;
            // 
            // historyButtonComp
            // 
            historyButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            historyButtonComp.Location = new Point(48, 280);
            historyButtonComp.Name = "historyButtonComp";
            historyButtonComp.Size = new Size(150, 40);
            historyButtonComp.TabIndex = 11;
            historyButtonComp.Text = "Historia";
            historyButtonComp.UseVisualStyleBackColor = true;
            historyButtonComp.Click += historyButtonComp_Click;
            // 
            // resetButtonComp
            // 
            resetButtonComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetButtonComp.Location = new Point(76, 536);
            resetButtonComp.Name = "resetButtonComp";
            resetButtonComp.Size = new Size(94, 29);
            resetButtonComp.TabIndex = 12;
            resetButtonComp.Text = "Reset";
            resetButtonComp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(463, 297);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 13;
            label3.Text = "Fråga:";
            // 
            // questionComp
            // 
            questionComp.AutoSize = true;
            questionComp.BackColor = SystemColors.Control;
            questionComp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            questionComp.ForeColor = SystemColors.ActiveCaptionText;
            questionComp.Location = new Point(540, 297);
            questionComp.Name = "questionComp";
            questionComp.Size = new Size(69, 23);
            questionComp.TabIndex = 14;
            questionComp.Text = "Välj del";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(472, 347);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 15;
            label5.Text = "Svar:";
            // 
            // answerBoxComp
            // 
            answerBoxComp.Location = new Point(540, 346);
            answerBoxComp.Name = "answerBoxComp";
            answerBoxComp.Size = new Size(125, 27);
            answerBoxComp.TabIndex = 16;
            // 
            // answerSubmitComp
            // 
            answerSubmitComp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            answerSubmitComp.Location = new Point(685, 347);
            answerSubmitComp.Name = "answerSubmitComp";
            answerSubmitComp.Size = new Size(67, 26);
            answerSubmitComp.TabIndex = 17;
            answerSubmitComp.Text = "Svara";
            answerSubmitComp.UseVisualStyleBackColor = true;
            answerSubmitComp.Click += answerSubmitComp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(452, 447);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 18;
            label6.Text = "Information:";
            // 
            // infoBoxComp
            // 
            infoBoxComp.AutoSize = true;
            infoBoxComp.BackColor = SystemColors.Control;
            infoBoxComp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            infoBoxComp.ForeColor = SystemColors.ActiveCaptionText;
            infoBoxComp.Location = new Point(452, 480);
            infoBoxComp.MaximumSize = new Size(350, 0);
            infoBoxComp.Name = "infoBoxComp";
            infoBoxComp.Size = new Size(71, 23);
            infoBoxComp.TabIndex = 19;
            infoBoxComp.Text = "*Insert*";
            // 
            // corAnswerCompLabel
            // 
            corAnswerCompLabel.AutoSize = true;
            corAnswerCompLabel.BackColor = SystemColors.Control;
            corAnswerCompLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            corAnswerCompLabel.ForeColor = SystemColors.ActiveCaptionText;
            corAnswerCompLabel.Location = new Point(406, 380);
            corAnswerCompLabel.Name = "corAnswerCompLabel";
            corAnswerCompLabel.Size = new Size(117, 23);
            corAnswerCompLabel.TabIndex = 20;
            corAnswerCompLabel.Text = "Korrekt Svar:";
            // 
            // correctAnswerComp
            // 
            correctAnswerComp.AutoSize = true;
            correctAnswerComp.BackColor = SystemColors.Control;
            correctAnswerComp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            correctAnswerComp.ForeColor = SystemColors.ActiveCaptionText;
            correctAnswerComp.Location = new Point(540, 380);
            correctAnswerComp.Name = "correctAnswerComp";
            correctAnswerComp.Size = new Size(38, 23);
            correctAnswerComp.TabIndex = 21;
            correctAnswerComp.Text = "----";
            // 
            // compPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1210, 751);
            Controls.Add(correctAnswerComp);
            Controls.Add(corAnswerCompLabel);
            Controls.Add(infoBoxComp);
            Controls.Add(label6);
            Controls.Add(answerSubmitComp);
            Controls.Add(answerBoxComp);
            Controls.Add(label5);
            Controls.Add(questionComp);
            Controls.Add(label3);
            Controls.Add(resetButtonComp);
            Controls.Add(historyButtonComp);
            Controls.Add(hardButtonComp);
            Controls.Add(operButtonComp);
            Controls.Add(netButtonComp);
            Controls.Add(memoryButtonComp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(menuButton);
            Name = "compPage";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button menuButton;
        private Label label1;
        private Label label2;
        private Button memoryButtonComp;
        private Button netButtonComp;
        private Button operButtonComp;
        private Button hardButtonComp;
        private Button historyButtonComp;
        private Button resetButtonComp;
        private Label label3;
        private Label questionComp;
        private Label label5;
        private TextBox answerBoxComp;
        private Button answerSubmitComp;
        private Label label6;
        private Label infoBoxComp;
        private Label corAnswerCompLabel;
        private Label correctAnswerComp;
    }
}