namespace HwTaskManager
{
    partial class frmRunTasks
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
            processName = new TextBox();
            btnRun = new Button();
            runProcessLabel = new Label();
            SuspendLayout();
            // 
            // processName
            // 
            processName.Location = new Point(130, 49);
            processName.Name = "processName";
            processName.Size = new Size(643, 27);
            processName.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.DialogResult = DialogResult.OK;
            btnRun.Location = new Point(679, 94);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // runProcessLabel
            // 
            runProcessLabel.AutoSize = true;
            runProcessLabel.Location = new Point(32, 52);
            runProcessLabel.Name = "runProcessLabel";
            runProcessLabel.Size = new Size(90, 20);
            runProcessLabel.TabIndex = 2;
            runProcessLabel.Text = "Run Process:";
            // 
            // frmRunTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 170);
            Controls.Add(runProcessLabel);
            Controls.Add(btnRun);
            Controls.Add(processName);
            Name = "frmRunTasks";
            Text = "Run Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox processName;
        private Button btnRun;
        private Label runProcessLabel;
    }
}