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
using MetroFramework;
using MetroFramework.Design;
using MetroFramework.Forms;

namespace ProcessUtil
{
    public partial class Form1 : MetroForm
    {
        List<string> ProcessList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectProcessEnd_Click(object sender, EventArgs e)
        {
            GetProcesses();
            SelectProcessEnd.DataSource = ProcessList;
        }

        int EndCurSel;
        private void GetProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                string toadd = p.ProcessName;
                ProcessList.Add(toadd);
                ProcessList = ProcessList.Distinct().ToList();
            }
            ProcessList.Sort();
        }

        private void endprocess_Click(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName(SelectProcessEnd.Text))
            {
                process.Kill();
            }
        }
    }
}
