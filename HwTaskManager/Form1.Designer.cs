namespace HwTaskManager
{
    partial class Form1
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
            taskFeild = new ListBox();
            endTaskBtn = new Button();
            SuspendLayout();
            // 
            // taskFeild
            // 
            taskFeild.FormattingEnabled = true;
            taskFeild.ItemHeight = 20;
            taskFeild.Location = new Point(12, 12);
            taskFeild.Name = "taskFeild";
            taskFeild.Size = new Size(776, 584);
            taskFeild.TabIndex = 0;
            // 
            // endTaskBtn
            // 
            endTaskBtn.Location = new Point(694, 620);
            endTaskBtn.Name = "endTaskBtn";
            endTaskBtn.Size = new Size(94, 29);
            endTaskBtn.TabIndex = 1;
            endTaskBtn.Text = "End Task";
            endTaskBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 691);
            Controls.Add(endTaskBtn);
            Controls.Add(taskFeild);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox taskFeild;
        private Button endTaskBtn;
    }
}