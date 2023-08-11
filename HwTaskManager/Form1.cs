using System.Diagnostics;

namespace HwTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}