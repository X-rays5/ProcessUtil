namespace ProcessUtil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcinformation = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.PidInfo = new System.Windows.Forms.Label();
            this.endprocess = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SelectProcessEnd = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.vcorecount = new System.Windows.Forms.Label();
            this.corecount = new System.Windows.Forms.Label();
            this.pcuptime = new System.Windows.Forms.Label();
            this.pcbit = new System.Windows.Forms.Label();
            this.pcosversion = new System.Windows.Forms.Label();
            this.pcusername = new System.Windows.Forms.Label();
            this.totalprocesses = new System.Windows.Forms.Label();
            this.UpdatepcUsage = new MetroFramework.Controls.MetroButton();
            this.pagefileusage = new System.Windows.Forms.Label();
            this.ramusage = new System.Windows.Forms.Label();
            this.cpuusagecounter = new System.Windows.Forms.Label();
            this.pcusagetitel = new MetroFramework.Controls.MetroLabel();
            this.pcinfotitel = new MetroFramework.Controls.MetroLabel();
            this.pcname = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.SaveSettings = new MetroFramework.Controls.MetroButton();
            this.ChooseDllPath = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DllPath = new System.Windows.Forms.Label();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.InjectionDelaySelect = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SelectProcessInject = new MetroFramework.Controls.MetroComboBox();
            this.InjectButton = new MetroFramework.Controls.MetroButton();
            this.AdminNotice = new MetroFramework.Controls.MetroLabel();
            this.RestartAsAdmin = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pcinformation.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjectionDelaySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // pcinformation
            // 
            this.pcinformation.AllowDrop = true;
            this.pcinformation.Controls.Add(this.metroTabPage1);
            this.pcinformation.Controls.Add(this.metroTabPage2);
            this.pcinformation.Controls.Add(this.metroTabPage3);
            this.pcinformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcinformation.Location = new System.Drawing.Point(20, 60);
            this.pcinformation.Name = "pcinformation";
            this.pcinformation.SelectedIndex = 0;
            this.pcinformation.Size = new System.Drawing.Size(760, 370);
            this.pcinformation.Style = MetroFramework.MetroColorStyle.White;
            this.pcinformation.TabIndex = 0;
            this.pcinformation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.PidInfo);
            this.metroTabPage1.Controls.Add(this.endprocess);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.SelectProcessEnd);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 331);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Process Terminator";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // PidInfo
            // 
            this.PidInfo.BackColor = System.Drawing.Color.Transparent;
            this.PidInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PidInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.PidInfo.Location = new System.Drawing.Point(227, 81);
            this.PidInfo.Name = "PidInfo";
            this.PidInfo.Size = new System.Drawing.Size(296, 23);
            this.PidInfo.TabIndex = 6;
            this.PidInfo.Text = "PID: 0";
            this.PidInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endprocess
            // 
            this.endprocess.Location = new System.Drawing.Point(24, 130);
            this.endprocess.Name = "endprocess";
            this.endprocess.Size = new System.Drawing.Size(157, 39);
            this.endprocess.TabIndex = 4;
            this.endprocess.Text = "End Process";
            this.endprocess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.endprocess.Click += new System.EventHandler(this.endprocess_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select Process";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SelectProcessEnd
            // 
            this.SelectProcessEnd.FormattingEnabled = true;
            this.SelectProcessEnd.ItemHeight = 23;
            this.SelectProcessEnd.Location = new System.Drawing.Point(3, 75);
            this.SelectProcessEnd.Name = "SelectProcessEnd";
            this.SelectProcessEnd.Size = new System.Drawing.Size(218, 29);
            this.SelectProcessEnd.Style = MetroFramework.MetroColorStyle.Black;
            this.SelectProcessEnd.TabIndex = 2;
            this.SelectProcessEnd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectProcessEnd.SelectedIndexChanged += new System.EventHandler(this.SelectProcessEnd_SelectedIndexChanged);
            this.SelectProcessEnd.Click += new System.EventHandler(this.SelectProcessEnd_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.vcorecount);
            this.metroTabPage3.Controls.Add(this.corecount);
            this.metroTabPage3.Controls.Add(this.pcuptime);
            this.metroTabPage3.Controls.Add(this.pcbit);
            this.metroTabPage3.Controls.Add(this.pcosversion);
            this.metroTabPage3.Controls.Add(this.pcusername);
            this.metroTabPage3.Controls.Add(this.totalprocesses);
            this.metroTabPage3.Controls.Add(this.UpdatepcUsage);
            this.metroTabPage3.Controls.Add(this.pagefileusage);
            this.metroTabPage3.Controls.Add(this.ramusage);
            this.metroTabPage3.Controls.Add(this.cpuusagecounter);
            this.metroTabPage3.Controls.Add(this.pcusagetitel);
            this.metroTabPage3.Controls.Add(this.pcinfotitel);
            this.metroTabPage3.Controls.Add(this.pcname);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(752, 331);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "PC Info";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // vcorecount
            // 
            this.vcorecount.BackColor = System.Drawing.Color.Transparent;
            this.vcorecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vcorecount.ForeColor = System.Drawing.SystemColors.Control;
            this.vcorecount.Location = new System.Drawing.Point(3, 188);
            this.vcorecount.Name = "vcorecount";
            this.vcorecount.Size = new System.Drawing.Size(409, 23);
            this.vcorecount.TabIndex = 19;
            this.vcorecount.Text = "VCore Count: ";
            this.vcorecount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // corecount
            // 
            this.corecount.BackColor = System.Drawing.Color.Transparent;
            this.corecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.corecount.ForeColor = System.Drawing.SystemColors.Control;
            this.corecount.Location = new System.Drawing.Point(3, 165);
            this.corecount.Name = "corecount";
            this.corecount.Size = new System.Drawing.Size(409, 23);
            this.corecount.TabIndex = 18;
            this.corecount.Text = "Core Count: ";
            this.corecount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcuptime
            // 
            this.pcuptime.BackColor = System.Drawing.Color.Transparent;
            this.pcuptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcuptime.ForeColor = System.Drawing.SystemColors.Control;
            this.pcuptime.Location = new System.Drawing.Point(3, 142);
            this.pcuptime.Name = "pcuptime";
            this.pcuptime.Size = new System.Drawing.Size(409, 23);
            this.pcuptime.TabIndex = 17;
            this.pcuptime.Text = "PC Uptime:";
            this.pcuptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbit
            // 
            this.pcbit.BackColor = System.Drawing.Color.Transparent;
            this.pcbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcbit.ForeColor = System.Drawing.SystemColors.Control;
            this.pcbit.Location = new System.Drawing.Point(3, 119);
            this.pcbit.Name = "pcbit";
            this.pcbit.Size = new System.Drawing.Size(255, 23);
            this.pcbit.TabIndex = 16;
            this.pcbit.Text = "PC Bit:";
            this.pcbit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcosversion
            // 
            this.pcosversion.BackColor = System.Drawing.Color.Transparent;
            this.pcosversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcosversion.ForeColor = System.Drawing.SystemColors.Control;
            this.pcosversion.Location = new System.Drawing.Point(3, 96);
            this.pcosversion.Name = "pcosversion";
            this.pcosversion.Size = new System.Drawing.Size(255, 23);
            this.pcosversion.TabIndex = 15;
            this.pcosversion.Text = "OS: ";
            this.pcosversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcusername
            // 
            this.pcusername.BackColor = System.Drawing.Color.Transparent;
            this.pcusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcusername.ForeColor = System.Drawing.SystemColors.Control;
            this.pcusername.Location = new System.Drawing.Point(3, 73);
            this.pcusername.Name = "pcusername";
            this.pcusername.Size = new System.Drawing.Size(255, 23);
            this.pcusername.TabIndex = 14;
            this.pcusername.Text = "PC Username:";
            this.pcusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalprocesses
            // 
            this.totalprocesses.BackColor = System.Drawing.Color.Transparent;
            this.totalprocesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalprocesses.ForeColor = System.Drawing.SystemColors.Control;
            this.totalprocesses.Location = new System.Drawing.Point(446, 96);
            this.totalprocesses.Name = "totalprocesses";
            this.totalprocesses.Size = new System.Drawing.Size(310, 23);
            this.totalprocesses.TabIndex = 13;
            this.totalprocesses.Text = "Number of Processes: ";
            this.totalprocesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdatepcUsage
            // 
            this.UpdatepcUsage.Location = new System.Drawing.Point(0, 294);
            this.UpdatepcUsage.Name = "UpdatepcUsage";
            this.UpdatepcUsage.Size = new System.Drawing.Size(128, 37);
            this.UpdatepcUsage.TabIndex = 9;
            this.UpdatepcUsage.Text = "Update PC info";
            this.UpdatepcUsage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdatepcUsage.Click += new System.EventHandler(this.UpdatepcUsage_Click);
            // 
            // pagefileusage
            // 
            this.pagefileusage.BackColor = System.Drawing.Color.Transparent;
            this.pagefileusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pagefileusage.ForeColor = System.Drawing.SystemColors.Control;
            this.pagefileusage.Location = new System.Drawing.Point(446, 73);
            this.pagefileusage.Name = "pagefileusage";
            this.pagefileusage.Size = new System.Drawing.Size(310, 23);
            this.pagefileusage.TabIndex = 8;
            this.pagefileusage.Text = "Pagefile Usage: ";
            this.pagefileusage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ramusage
            // 
            this.ramusage.BackColor = System.Drawing.Color.Transparent;
            this.ramusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ramusage.ForeColor = System.Drawing.SystemColors.Control;
            this.ramusage.Location = new System.Drawing.Point(446, 50);
            this.ramusage.Name = "ramusage";
            this.ramusage.Size = new System.Drawing.Size(310, 23);
            this.ramusage.TabIndex = 7;
            this.ramusage.Text = "RAM Usage: ";
            this.ramusage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuusagecounter
            // 
            this.cpuusagecounter.AutoSize = true;
            this.cpuusagecounter.BackColor = System.Drawing.Color.Transparent;
            this.cpuusagecounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpuusagecounter.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuusagecounter.Location = new System.Drawing.Point(449, 138);
            this.cpuusagecounter.Name = "cpuusagecounter";
            this.cpuusagecounter.Size = new System.Drawing.Size(0, 17);
            this.cpuusagecounter.TabIndex = 5;
            // 
            // pcusagetitel
            // 
            this.pcusagetitel.AutoSize = true;
            this.pcusagetitel.Location = new System.Drawing.Point(449, 19);
            this.pcusagetitel.Name = "pcusagetitel";
            this.pcusagetitel.Size = new System.Drawing.Size(66, 19);
            this.pcusagetitel.TabIndex = 4;
            this.pcusagetitel.Text = "PC Usage";
            this.pcusagetitel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pcinfotitel
            // 
            this.pcinfotitel.AutoSize = true;
            this.pcinfotitel.Location = new System.Drawing.Point(6, 19);
            this.pcinfotitel.Name = "pcinfotitel";
            this.pcinfotitel.Size = new System.Drawing.Size(52, 19);
            this.pcinfotitel.TabIndex = 3;
            this.pcinfotitel.Text = "PC Info";
            this.pcinfotitel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pcname
            // 
            this.pcname.BackColor = System.Drawing.Color.Transparent;
            this.pcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcname.ForeColor = System.Drawing.SystemColors.Control;
            this.pcname.Location = new System.Drawing.Point(3, 50);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(255, 23);
            this.pcname.TabIndex = 2;
            this.pcname.Text = "PC Name:";
            this.pcname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.SaveSettings);
            this.metroTabPage2.Controls.Add(this.ChooseDllPath);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.DllPath);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.InjectionDelaySelect);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.SelectProcessInject);
            this.metroTabPage2.Controls.Add(this.InjectButton);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 331);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Injector";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(0, 308);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(129, 23);
            this.SaveSettings.TabIndex = 13;
            this.SaveSettings.Text = "Save Injector Settings";
            this.SaveSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // ChooseDllPath
            // 
            this.ChooseDllPath.Location = new System.Drawing.Point(223, 208);
            this.ChooseDllPath.Name = "ChooseDllPath";
            this.ChooseDllPath.Size = new System.Drawing.Size(91, 23);
            this.ChooseDllPath.TabIndex = 12;
            this.ChooseDllPath.Text = "Choose Path";
            this.ChooseDllPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChooseDllPath.Click += new System.EventHandler(this.ChooseDllPath_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "DLL Path";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DllPath
            // 
            this.DllPath.AutoEllipsis = true;
            this.DllPath.Location = new System.Drawing.Point(3, 208);
            this.DllPath.Name = "DllPath";
            this.DllPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DllPath.Size = new System.Drawing.Size(218, 23);
            this.DllPath.TabIndex = 10;
            this.DllPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Injection Delay";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // InjectionDelaySelect
            // 
            this.InjectionDelaySelect.Location = new System.Drawing.Point(3, 147);
            this.InjectionDelaySelect.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.InjectionDelaySelect.Name = "InjectionDelaySelect";
            this.InjectionDelaySelect.Size = new System.Drawing.Size(218, 20);
            this.InjectionDelaySelect.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Select Process";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SelectProcessInject
            // 
            this.SelectProcessInject.FormattingEnabled = true;
            this.SelectProcessInject.ItemHeight = 23;
            this.SelectProcessInject.Location = new System.Drawing.Point(3, 75);
            this.SelectProcessInject.Name = "SelectProcessInject";
            this.SelectProcessInject.Size = new System.Drawing.Size(218, 29);
            this.SelectProcessInject.TabIndex = 6;
            this.SelectProcessInject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectProcessInject.Click += new System.EventHandler(this.SelectProcessInject_Click);
            // 
            // InjectButton
            // 
            this.InjectButton.Location = new System.Drawing.Point(29, 248);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(157, 39);
            this.InjectButton.TabIndex = 5;
            this.InjectButton.Text = "Inject";
            this.InjectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // AdminNotice
            // 
            this.AdminNotice.Location = new System.Drawing.Point(594, 6);
            this.AdminNotice.Name = "AdminNotice";
            this.AdminNotice.Size = new System.Drawing.Size(145, 23);
            this.AdminNotice.TabIndex = 1;
            this.AdminNotice.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RestartAsAdmin
            // 
            this.RestartAsAdmin.Location = new System.Drawing.Point(629, 31);
            this.RestartAsAdmin.Name = "RestartAsAdmin";
            this.RestartAsAdmin.Size = new System.Drawing.Size(110, 23);
            this.RestartAsAdmin.TabIndex = 2;
            this.RestartAsAdmin.Text = "Restart as Admin";
            this.RestartAsAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RestartAsAdmin.Click += new System.EventHandler(this.RestartAsAdmin_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(90, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "W.I.P.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestartAsAdmin);
            this.Controls.Add(this.AdminNotice);
            this.Controls.Add(this.pcinformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Process Utilities ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pcinformation.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjectionDelaySelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl pcinformation;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroComboBox SelectProcessEnd;
        private MetroFramework.Controls.MetroButton endprocess;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox SelectProcessInject;
        private MetroFramework.Controls.MetroButton InjectButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown InjectionDelaySelect;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label DllPath;
        private MetroFramework.Controls.MetroButton ChooseDllPath;
        private System.Windows.Forms.Label PidInfo;
        private MetroFramework.Controls.MetroLabel AdminNotice;
        private MetroFramework.Controls.MetroButton RestartAsAdmin;
        private MetroFramework.Controls.MetroButton SaveSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Label pcname;
        private MetroFramework.Controls.MetroLabel pcinfotitel;
        private System.Windows.Forms.Label cpuusagecounter;
        private MetroFramework.Controls.MetroLabel pcusagetitel;
        private System.Windows.Forms.Label ramusage;
        private System.Windows.Forms.Label pagefileusage;
        private MetroFramework.Controls.MetroButton UpdatepcUsage;
        private System.Windows.Forms.Label totalprocesses;
        private System.Windows.Forms.Label pcusername;
        private System.Windows.Forms.Label pcosversion;
        private System.Windows.Forms.Label pcbit;
        private System.Windows.Forms.Label pcuptime;
        private System.Windows.Forms.Label corecount;
        private System.Windows.Forms.Label vcorecount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

