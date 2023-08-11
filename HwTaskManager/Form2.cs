using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwTaskManager
{
    public partial class frmRunTasks : Form
    {
        public frmRunTasks()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (processName.Text is not null)
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = processName.Text;
                    process.Start();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
