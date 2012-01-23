namespace ReflectiveCode.GMinder
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayCalendarsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayResetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarRefresher = new System.ComponentModel.BackgroundWorker();
            this.eventWhere = new System.Windows.Forms.Label();
            this.eventWhat = new System.Windows.Forms.Label();
            this.eventWhen = new System.Windows.Forms.Label();
            this.eventTable = new System.Windows.Forms.TableLayoutPanel();
            this.agenda = new ReflectiveCode.GMinder.Agenda();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.integerSnooze = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.buttonSnooze = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.minuteTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.snoozeTimer = new System.Windows.Forms.Timer(this.components);
            this.trayAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu.SuspendLayout();
            this.eventTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerSnooze)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "GMinder";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleTrayClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HandleTrayDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayCalendarsMenuItem,
            this.trayOptionsMenuItem,
            this.toolStripSeparator2,
            this.trayResetMenuItem,
            this.trayRefreshMenuItem,
            this.trayAddMenuItem,
            this.toolStripSeparator1,
            this.trayAboutMenuItem,
            this.trayExitMenuItem});
            this.trayMenu.Name = "contextMenuStrip1";
            this.trayMenu.Size = new System.Drawing.Size(160, 192);
            // 
            // trayCalendarsMenuItem
            // 
            this.trayCalendarsMenuItem.Name = "trayCalendarsMenuItem";
            this.trayCalendarsMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayCalendarsMenuItem.Text = "Calendars";
            this.trayCalendarsMenuItem.Click += new System.EventHandler(this.HandleTrayCalendars);
            // 
            // trayOptionsMenuItem
            // 
            this.trayOptionsMenuItem.Name = "trayOptionsMenuItem";
            this.trayOptionsMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayOptionsMenuItem.Text = "Options";
            this.trayOptionsMenuItem.Click += new System.EventHandler(this.HandleTrayOptions);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // trayResetMenuItem
            // 
            this.trayResetMenuItem.Name = "trayResetMenuItem";
            this.trayResetMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayResetMenuItem.Text = "Clear Events";
            this.trayResetMenuItem.Click += new System.EventHandler(this.HandleTrayReset);
            // 
            // trayRefreshMenuItem
            // 
            this.trayRefreshMenuItem.Name = "trayRefreshMenuItem";
            this.trayRefreshMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayRefreshMenuItem.Text = "Refresh Events";
            this.trayRefreshMenuItem.Click += new System.EventHandler(this.HandleTrayRefresh);
            // 
            // trayAddMenuItem
            // 
            this.trayAddMenuItem.Name = "trayAddMenuItem";
            this.trayAddMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayAddMenuItem.Text = "Add Event";
            this.trayAddMenuItem.Click += new System.EventHandler(this.HandleAddButton);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // trayExitMenuItem
            // 
            this.trayExitMenuItem.Name = "trayExitMenuItem";
            this.trayExitMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayExitMenuItem.Text = "Exit";
            this.trayExitMenuItem.Click += new System.EventHandler(this.HandleTrayExit);
            // 
            // calendarRefresher
            // 
            this.calendarRefresher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HandleCalendarRefresherWork);
            this.calendarRefresher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.HandleCalendarRefresherCompleted);
            // 
            // eventWhere
            // 
            this.eventWhere.AutoSize = true;
            this.eventWhere.Location = new System.Drawing.Point(3, 37);
            this.eventWhere.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhere.Name = "eventWhere";
            this.eventWhere.Size = new System.Drawing.Size(39, 13);
            this.eventWhere.TabIndex = 2;
            this.eventWhere.Text = "Where";
            // 
            // eventWhat
            // 
            this.eventWhat.AutoSize = true;
            this.eventWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventWhat.Location = new System.Drawing.Point(3, 0);
            this.eventWhat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhat.Name = "eventWhat";
            this.eventWhat.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.eventWhat.Size = new System.Drawing.Size(37, 18);
            this.eventWhat.TabIndex = 0;
            this.eventWhat.Text = "What";
            // 
            // eventWhen
            // 
            this.eventWhen.AutoSize = true;
            this.eventWhen.Location = new System.Drawing.Point(3, 21);
            this.eventWhen.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.eventWhen.Name = "eventWhen";
            this.eventWhen.Size = new System.Drawing.Size(36, 13);
            this.eventWhen.TabIndex = 1;
            this.eventWhen.Text = "When";
            // 
            // eventTable
            // 
            this.eventTable.AutoSize = true;
            this.eventTable.ColumnCount = 1;
            this.eventTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTable.Controls.Add(this.eventWhat, 0, 0);
            this.eventTable.Controls.Add(this.eventWhere, 0, 2);
            this.eventTable.Controls.Add(this.agenda, 0, 3);
            this.eventTable.Controls.Add(this.eventWhen, 0, 1);
            this.eventTable.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.eventTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTable.Location = new System.Drawing.Point(0, 0);
            this.eventTable.Name = "eventTable";
            this.eventTable.RowCount = 5;
            this.eventTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventTable.Size = new System.Drawing.Size(459, 388);
            this.eventTable.TabIndex = 0;
            // 
            // agenda
            // 
            this.agenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenda.ForeColor = System.Drawing.Color.Black;
            this.agenda.FullRowSelect = true;
            this.agenda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.agenda.HideSelection = false;
            this.agenda.Location = new System.Drawing.Point(0, 53);
            this.agenda.Margin = new System.Windows.Forms.Padding(0);
            this.agenda.MultiSelect = false;
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(459, 306);
            this.agenda.TabIndex = 3;
            this.agenda.UseCompatibleStateImageBehavior = false;
            this.agenda.View = System.Windows.Forms.View.Details;
            this.agenda.SelectedChanged += new System.EventHandler(this.HandleAgendaSelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.integerSnooze, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSnooze, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHide, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDismiss, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpen, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 359);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // integerSnooze
            // 
            this.integerSnooze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.integerSnooze.Location = new System.Drawing.Point(292, 6);
            this.integerSnooze.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.integerSnooze.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.integerSnooze.Name = "integerSnooze";
            this.integerSnooze.Size = new System.Drawing.Size(60, 20);
            this.integerSnooze.TabIndex = 3;
            this.integerSnooze.Value = 10;
            this.integerSnooze.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleSnoozeKeyPress);
            // 
            // buttonSnooze
            // 
            this.buttonSnooze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSnooze.AutoSize = true;
            this.buttonSnooze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSnooze.Location = new System.Drawing.Point(358, 3);
            this.buttonSnooze.Name = "buttonSnooze";
            this.buttonSnooze.Size = new System.Drawing.Size(53, 23);
            this.buttonSnooze.TabIndex = 4;
            this.buttonSnooze.Text = "Snooze";
            this.buttonSnooze.UseVisualStyleBackColor = true;
            this.buttonSnooze.Click += new System.EventHandler(this.HandleSnoozeButton);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.AutoSize = true;
            this.buttonHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHide.Location = new System.Drawing.Point(417, 3);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(39, 23);
            this.buttonHide.TabIndex = 5;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.HandleHideButton);
            // 
            // buttonNew
            // 
            this.buttonNew.AutoSize = true;
            this.buttonNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNew.Location = new System.Drawing.Point(3, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(39, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.HandleAddButton);
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDismiss.AutoSize = true;
            this.buttonDismiss.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDismiss.Location = new System.Drawing.Point(97, 3);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(52, 23);
            this.buttonDismiss.TabIndex = 2;
            this.buttonDismiss.Text = "Dismiss";
            this.buttonDismiss.UseVisualStyleBackColor = true;
            this.buttonDismiss.Click += new System.EventHandler(this.HandleDismissClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.AutoSize = true;
            this.buttonOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpen.Location = new System.Drawing.Point(48, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(43, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.HandleOpenButton);
            // 
            // minuteTimer
            // 
            this.minuteTimer.Enabled = true;
            this.minuteTimer.Interval = 1000;
            this.minuteTimer.Tick += new System.EventHandler(this.HandleMinuteTimerTick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.HandleRefreshTimerTick);
            // 
            // snoozeTimer
            // 
            this.snoozeTimer.Tick += new System.EventHandler(this.HandleSnoozeTimerTick);
            // 
            // trayAboutMenuItem
            // 
            this.trayAboutMenuItem.Name = "trayAboutMenuItem";
            this.trayAboutMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trayAboutMenuItem.Text = "About GMinder";
            this.trayAboutMenuItem.Click += new System.EventHandler(this.HandleTrayAbout);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 388);
            this.Controls.Add(this.eventTable);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::ReflectiveCode.GMinder.Properties.Settings.Default, "OnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reminder";
            this.Text = "GMinder";
            this.TopMost = global::ReflectiveCode.GMinder.Properties.Settings.Default.OnTop;
            this.trayMenu.ResumeLayout(false);
            this.eventTable.ResumeLayout(false);
            this.eventTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerSnooze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Timer minuteTimer;
        private System.ComponentModel.BackgroundWorker calendarRefresher;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayRefreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayExitMenuItem;
        private System.Windows.Forms.TableLayoutPanel eventTable;
        private System.Windows.Forms.Label eventWhat;
        private System.Windows.Forms.Label eventWhen;
        private System.Windows.Forms.Label eventWhere;
        private System.Windows.Forms.ToolStripMenuItem trayResetMenuItem;
        private Agenda agenda;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSnooze;
        private Controls.IntegerUpDown integerSnooze;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Timer snoozeTimer;
        private System.Windows.Forms.ToolStripMenuItem trayCalendarsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayAddMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayAboutMenuItem;
    }
}

