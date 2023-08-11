using System.Diagnostics;

namespace HwTaskManager
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        Process[] p;

        void GetAllProcesses()
        {
            p = Process.GetProcesses();

            taskFeild.Items.Clear();

            foreach (Process process in p)
            {
                taskFeild.Items.Add(process.ProcessName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void endTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                p[taskFeild.SelectedIndex].Kill();
                GetAllProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmRunTasks frm = new frmRunTasks()) 
            {
                if (frm.ShowDialog() == DialogResult.OK)
                { 
                    GetAllProcesses(); 
                }
            }
        }
    }
}