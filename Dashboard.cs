using GTA_Online_Public_Sessioner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Online_Public_Sessioner
{
    public partial class Dashboard : Form
    {
        SettingsForm settingsForm;
        public Dashboard()
        {
            InitializeComponent();
            settingsForm = new SettingsForm(this);
        }
        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);


        private static void SuspendProcess(int pid)
        {
            var process = Process.GetProcessById(pid); // throws exception if process does not exist

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }
        Process[] processlist;
        public static void ResumeProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue; 
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            this.Hide();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            processlist = Process.GetProcesses();
            int n = -1, i = 0;
            foreach (Process p in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", p.ProcessName, p.Id);

                if (p.ProcessName == Settings.Default.ProcessName)//GTA5
                    n = i;
                i++;
            }
            if (n != -1)
            {
                Process process = processlist[n];
                SuspendProcess(process.Id);
                InitTimer();
                Thread.Sleep((Settings.Default.Duration * 1000));
                ResumeProcess(process.Id);
                Thread.Sleep(2000);
                Application.Exit();
            }
            else
            {
                MessageBox.Show(Settings.Default.ProcessName + ".exe Not Running");
            }

        }
        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = Settings.Default.Duration * 1000; // in miliseconds
            timer1.Start();
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            InitTimer();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            connectButton.Text = "" + timer1.Interval;
            Console.WriteLine(timer1.Interval);
        }

    }
}
