using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Design;
using MetroFramework.Forms;
using IniParser;
using IniParser.Model;
using System.Management;

namespace ProcessUtil
{
	public partial class Form1 : MetroForm
	{
		bool IsAdministrator()
		{
			var identity = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(identity);
			if (principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
				return true;
            }
			else
            {
				return false;
            }
		}

		void LoadPCInfo()
        {
            pcname.Text = "PC Name: " + Environment.MachineName.ToString();
			pcusername.Text = "Username" + Environment.UserName;
			pcosversion.Text = "OS: " + Environment.OSVersion;
			if (Environment.Is64BitOperatingSystem)
            {
				pcbit.Text = "PC Bit: x64 Bit";
            }
			else
            {
				pcbit.Text = "PC Bit: x86 Bit";
			}
			int uptime = (int)TimeSpan.FromMilliseconds(Environment.TickCount).TotalMinutes;
			pcuptime.Text = "PC Uptime: " + Convert.ToString(uptime) + " Minutes";

			int actualcores = Environment.ProcessorCount / 2;
			corecount.Text = "Core Count: " + actualcores;
			vcorecount.Text = "VCore Count: " + Environment.ProcessorCount;

			// Performance Counter
			PerformanceCounter ProcessCounter;
			PerformanceCounter ramCounter;
			PerformanceCounter pagefileCounter;

			ProcessCounter = new PerformanceCounter("System", "Processes");
			ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
			pagefileCounter = new PerformanceCounter("Paging File", "% Usage", "_Total");
			ramusage.Text = "Ram Usage: " + ramCounter.NextValue() + "%";
			pagefileusage.Text = "Paging File Usage: " + pagefileCounter.NextValue() + "%";
			totalprocesses.Text = "Number of Processes: " + ProcessCounter.NextValue();
		}

		public Form1()
		{
			InitializeComponent();
			if (IsAdministrator())
            {
				AdminNotice.Text = "Running as Admin";
				RestartAsAdmin.Visible = false;
            }
			else
            {
				AdminNotice.Text = "Not running as Admin";
            }
			LoadPCInfo();
		}

		List<string> ProcessListEnd = new List<string>();
		private void SelectProcessEnd_Click(object sender, EventArgs e)
		{
			GetProcessesEnd();
			SelectProcessEnd.DataSource = ProcessListEnd;
		}
		private void GetProcessesEnd()
		{
			Process[] processCollection = Process.GetProcesses();
			foreach (Process p in processCollection)
			{
				string toadd = p.ProcessName;
				ProcessListEnd.Add(toadd);
				ProcessListEnd = ProcessListEnd.Distinct().ToList();
				PidInfo.Text = "PID: " + Convert.ToString(p.Id);
			}
			ProcessListEnd.Sort();
		}

		private void SelectProcessEnd_SelectedIndexChanged(object sender, EventArgs e)
		{
			Process[] processCollection = Process.GetProcessesByName(SelectProcessEnd.Text);
			foreach (Process p in processCollection)
			{
				PidInfo.Text = "PID: " + Convert.ToString(p.Id);
			}
		}

		private void endprocess_Click(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName(SelectProcessEnd.Text))
			{
				process.Kill();
			}
		}

        private void RestartAsAdmin_Click(object sender, EventArgs e)
        {
			var exeName = Process.GetCurrentProcess().MainModule.FileName;
			ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
			startInfo.Verb = "runas";
			startInfo.Arguments = "restart";
			Process.Start(startInfo);
			Application.Exit();
		}

        private void UpdatepcUsage_Click(object sender, EventArgs e)
        {
			LoadPCInfo();
        }

		public Int32 GetProcessId(String proc)
		{
			Process[] ProcList;
			ProcList = Process.GetProcessesByName(proc);
			return ProcList[0].Id;
		}
	}
}

