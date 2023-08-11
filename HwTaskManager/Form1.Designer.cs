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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            runNewTaskToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // taskFeild
            // 
            taskFeild.FormattingEnabled = true;
            taskFeild.ItemHeight = 20;
            taskFeild.Location = new Point(12, 55);
            taskFeild.Name = "taskFeild";
            taskFeild.Size = new Size(776, 564);
            taskFeild.TabIndex = 0;
            // 
            // endTaskBtn
            // 
            endTaskBtn.Location = new Point(694, 636);
            endTaskBtn.Name = "endTaskBtn";
            endTaskBtn.Size = new Size(94, 29);
            endTaskBtn.TabIndex = 1;
            endTaskBtn.Text = "End Task";
            endTaskBtn.UseVisualStyleBackColor = true;
            endTaskBtn.Click += endTaskBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runNewTaskToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            runNewTaskToolStripMenuItem.Size = new Size(224, 26);
            runNewTaskToolStripMenuItem.Text = "Run new task";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(endTaskBtn);
            Controls.Add(taskFeild);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox taskFeild;
        private Button endTaskBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem runNewTaskToolStripMenuItem;
    }
}