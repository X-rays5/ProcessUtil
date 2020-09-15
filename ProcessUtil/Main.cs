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

		void LoadConfig()
        {
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			if (!File.Exists(path + "\\config.ini"))
            {
				MessageBox.Show("config.ini does not exist!");
            }
			else
            {
				var parser = new FileIniDataParser();
				IniData data = parser.ReadFile("config.ini");
				string converttoint = data["inject"]["injectdelay"];
				InjectionDelaySelect.Value = Convert.ToInt64(converttoint);
				DllPath.Text = data["inject"]["dllpath"];
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

		private void SaveSettings_Click(object sender, EventArgs e)
		{
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("config.ini");
			data["inject"]["injectdelay"] = Convert.ToString(InjectionDelaySelect.Value);
			parser.WriteFile("config.ini", data);
			data["inject"]["dllpath"] = DllPath.Text;
			parser.WriteFile("config.ini", data);
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
			LoadConfig();
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

		List<string> ProcessListInject = new List<string>();
		private void SelectProcessInject_Click(object sender, EventArgs e)
		{
			GetProcessesInject();
			SelectProcessInject.DataSource = ProcessListInject;
		}

		private void GetProcessesInject()
		{
			Process[] processCollection = Process.GetProcesses();
			foreach (Process p in processCollection)
			{
				string toadd = p.ProcessName;
				ProcessListInject.Add(toadd);
				ProcessListInject = ProcessListInject.Distinct().ToList();
			}
			ProcessListInject.Sort();
		}

		private void InjectButton_Click(object sender, EventArgs e)
		{
			int delay = (int)InjectionDelaySelect.Value;
			Thread.Sleep(delay);
			Int32 ProcID = GetProcessId(SelectProcessInject.Text);
			if (ProcID >= 0)
			{
				IntPtr hProcess = (IntPtr)OpenProcess(0x1F0FFF, 1, ProcID);
				if (hProcess == null)
				{
					MessageBox.Show("OpenProcess() Failed!");
					return;
				}
				else
					InjectDLL(hProcess, DllPath.Text);
			}
		}

        private void ChooseDllPath_Click(object sender, EventArgs e)
        {
			OpenFileDialog();
        }

		void OpenFileDialog()
        {
			var fileContent = string.Empty;
			var filePath = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "DLL Files (*.dll)|*.dll";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;

					//Read the contents of the file into a stream
					var fileStream = openFileDialog.OpenFile();

					using (StreamReader reader = new StreamReader(fileStream))
					{
						fileContent = reader.ReadToEnd();
					}
				}
			}
			DllPath.Text = filePath;
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

		[DllImport("kernel32")]
		public static extern IntPtr CreateRemoteThread(
		  IntPtr hProcess,
		  IntPtr lpThreadAttributes,
		  uint dwStackSize,
		  UIntPtr lpStartAddress, // raw Pointer into remote process
		  IntPtr lpParameter,
		  uint dwCreationFlags,
		  out IntPtr lpThreadId
		);

		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(
			UInt32 dwDesiredAccess,
			Int32 bInheritHandle,
			Int32 dwProcessId
			);

		[DllImport("kernel32.dll")]
		public static extern Int32 CloseHandle(
		IntPtr hObject
		);

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		static extern bool VirtualFreeEx(
			IntPtr hProcess,
			IntPtr lpAddress,
			UIntPtr dwSize,
			uint dwFreeType
			);

		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern UIntPtr GetProcAddress(
			IntPtr hModule,
			string procName
			);

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		static extern IntPtr VirtualAllocEx(
			IntPtr hProcess,
			IntPtr lpAddress,
			uint dwSize,
			uint flAllocationType,
			uint flProtect
			);

		[DllImport("kernel32.dll")]
		static extern bool WriteProcessMemory(
			IntPtr hProcess,
			IntPtr lpBaseAddress,
			string lpBuffer,
			UIntPtr nSize,
			out IntPtr lpNumberOfBytesWritten
		);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(
			string lpModuleName
			);

		[DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
		internal static extern Int32 WaitForSingleObject(
			IntPtr handle,
			Int32 milliseconds
			);

		public Int32 GetProcessId(String proc)
		{
			Process[] ProcList;
			ProcList = Process.GetProcessesByName(proc);
			return ProcList[0].Id;
		}

		public void InjectDLL(IntPtr hProcess, String strDLLName)
		{
			IntPtr bytesout;

			// Length of string containing the DLL file name +1 byte padding
			Int32 LenWrite = strDLLName.Length + 1;
			// Allocate memory within the virtual address space of the target process
			IntPtr AllocMem = (IntPtr)VirtualAllocEx(hProcess, (IntPtr)null, (uint)LenWrite, 0x1000, 0x40); //allocation pour WriteProcessMemory

			// Write DLL file name to allocated memory in target process
			WriteProcessMemory(hProcess, AllocMem, strDLLName, (UIntPtr)LenWrite, out bytesout);
			// Function pointer "Injector"
			UIntPtr Injector = (UIntPtr)GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

			if (Injector == null)
			{
				MessageBox.Show(" Injector Error! \n ");
				// return failed
				return;
			}

			// Create thread in target process, and store handle in hThread
			IntPtr hThread = (IntPtr)CreateRemoteThread(hProcess, (IntPtr)null, 0, Injector, AllocMem, 0, out bytesout);
			// Make sure thread handle is valid
			if (hThread == null)
			{
				//incorrect thread handle ... return failed
				MessageBox.Show(" hThread [ 1 ] Error! \n ");
				return;
			}
			// Time-out is 10 seconds...
			int Result = WaitForSingleObject(hThread, 10 * 1000);
			// Check whether thread timed out...
			if (Result == 0x00000080L || Result == 0x00000102L || Result == 0xFFFFFFFF)
			{
				/* Thread timed out... */
				MessageBox.Show(" hThread [ 2 ] Error! \n ");
				// Make sure thread handle is valid before closing... prevents crashes.
				if (hThread != null)
				{
					//Close thread in target process
					CloseHandle(hThread);
				}
				return;
			}
			// Sleep thread for 1 second
			Thread.Sleep(1000);
			// Clear up allocated space ( Allocmem )
			VirtualFreeEx(hProcess, AllocMem, (UIntPtr)0, 0x8000);
			// Make sure thread handle is valid before closing... prevents crashes.
			if (hThread != null)
			{
				//Close thread in target process
				CloseHandle(hThread);
			}
			// return succeeded
			return;
		}
	}
}

