namespace Tyuiu.chernyhim.Sprint6.Task1.V28
{
    partial class FormMain
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
            buttonDone = new Button();
            StartTextBox = new TextBox();
            StopTextBox = new TextBox();
            Start = new Label();
            Stop = new Label();
            textBoxresult = new TextBox();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(375, 352);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(152, 75);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // StartTextBox
            // 
            StartTextBox.Location = new Point(21, 402);
            StartTextBox.Name = "StartTextBox";
            StartTextBox.Size = new Size(125, 27);
            StartTextBox.TabIndex = 1;
            StartTextBox.Text = "-5";
            // 
            // StopTextBox
            // 
            StopTextBox.Location = new Point(201, 402);
            StopTextBox.Name = "StopTextBox";
            StopTextBox.Size = new Size(125, 27);
            StopTextBox.TabIndex = 2;
            StopTextBox.Text = "5";
            // 
            // Start
            // 
            Start.AutoSize = true;
            Start.Location = new Point(21, 379);
            Start.Name = "Start";
            Start.Size = new Size(40, 20);
            Start.TabIndex = 3;
            Start.Text = "Start";
            // 
            // Stop
            // 
            Stop.AutoSize = true;
            Stop.Location = new Point(201, 379);
            Stop.Name = "Stop";
            Stop.Size = new Size(40, 20);
            Stop.TabIndex = 4;
            Stop.Text = "Stop";
            // 
            // textBoxresult
            // 
            textBoxresult.Location = new Point(555, 54);
            textBoxresult.Multiline = true;
            textBoxresult.Name = "textBoxresult";
            textBoxresult.ScrollBars = ScrollBars.Vertical;
            textBoxresult.Size = new Size(233, 382);
            textBoxresult.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxresult);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(StopTextBox);
            Controls.Add(StartTextBox);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox StartTextBox;
        private TextBox StopTextBox;
        private Label Start;
        private Label Stop;
        private TextBox textBoxresult;
    }
}
