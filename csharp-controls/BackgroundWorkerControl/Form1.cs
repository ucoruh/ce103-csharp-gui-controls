using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabelControl
{
    public partial class MainForm : Form
    {
        bool _flag = true;

        public MainForm()
        {

            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(_flag)
            {
                richtextLog.AppendText("Hello World\r\n");
                Thread.Sleep(2000);
            }
        }

        private void buttonStartWorker_Click(object sender, EventArgs e)
        {
            _flag = true;

            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonStopWorker_Click(object sender, EventArgs e)
        {
            _flag= false;
        }
    }
}
