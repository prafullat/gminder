namespace ReflectiveCode.GMinder
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.soonPopup = new System.Windows.Forms.CheckBox();
            this.soonSound = new System.Windows.Forms.CheckBox();
            this.soonVerbal = new System.Windows.Forms.CheckBox();
            this.soonTime = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.futureColor = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.nowPopup = new System.Windows.Forms.CheckBox();
            this.nowSound = new System.Windows.Forms.CheckBox();
            this.nowVerbal = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.pastDismiss = new System.Windows.Forms.CheckBox();
            this.soonColor = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.nowColor = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.pastColor = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.soundBrowse = new ReflectiveCode.GMinder.Controls.OpenFileButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soundPath = new System.Windows.Forms.TextBox();
            this.soundPlay = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshRate = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.preload = new ReflectiveCode.GMinder.Controls.IntegerUpDown();
            this.doPing = new System.Windows.Forms.CheckBox();
            this.onTop = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soonTime)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preload)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.flowLayoutPanel3.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(70, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refresh rate (minutes)";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(308, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.flowLayoutPanel3.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(70, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preload how many days";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Events";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.futureColor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.soonColor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nowColor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pastColor, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.soonPopup);
            this.flowLayoutPanel4.Controls.Add(this.soonSound);
            this.flowLayoutPanel4.Controls.Add(this.soonVerbal);
            this.flowLayoutPanel4.Controls.Add(this.soonTime);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(146, 34);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(312, 26);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // soonPopup
            // 
            this.soonPopup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soonPopup.AutoSize = true;
            this.soonPopup.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonPopup;
            this.soonPopup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soonPopup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonPopup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonPopup.Location = new System.Drawing.Point(3, 4);
            this.soonPopup.Name = "soonPopup";
            this.soonPopup.Size = new System.Drawing.Size(57, 17);
            this.soonPopup.TabIndex = 0;
            this.soonPopup.Text = "Popup";
            this.soonPopup.UseVisualStyleBackColor = true;
            // 
            // soonSound
            // 
            this.soonSound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soonSound.AutoSize = true;
            this.soonSound.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonSound;
            this.soonSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soonSound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonSound.Location = new System.Drawing.Point(66, 4);
            this.soonSound.Name = "soonSound";
            this.soonSound.Size = new System.Drawing.Size(57, 17);
            this.soonSound.TabIndex = 1;
            this.soonSound.Text = "Sound";
            this.soonSound.UseVisualStyleBackColor = true;
            // 
            // soonVerbal
            // 
            this.soonVerbal.AutoSize = true;
            this.soonVerbal.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonVerbal;
            this.soonVerbal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonVerbal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonVerbal.Location = new System.Drawing.Point(129, 3);
            this.soonVerbal.Name = "soonVerbal";
            this.soonVerbal.Size = new System.Drawing.Size(56, 17);
            this.soonVerbal.TabIndex = 4;
            this.soonVerbal.Text = "Verbal";
            this.soonVerbal.UseVisualStyleBackColor = true;
            // 
            // soonTime
            // 
            this.soonTime.AutoSize = true;
            this.soonTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonTime.Location = new System.Drawing.Point(191, 3);
            this.soonTime.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.soonTime.Name = "soonTime";
            this.soonTime.Size = new System.Drawing.Size(47, 20);
            this.soonTime.TabIndex = 2;
            this.soonTime.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonTime;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "minutes";
            // 
            // futureColor
            // 
            this.futureColor.AutoSize = true;
            this.futureColor.BackColor = System.Drawing.Color.White;
            this.futureColor.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.FutureColor;
            this.futureColor.ColorDialog = this.colorDialog1;
            this.futureColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.futureColor.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "FutureColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.futureColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.futureColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.futureColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.futureColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futureColor.Location = new System.Drawing.Point(46, 3);
            this.futureColor.Name = "futureColor";
            this.futureColor.Size = new System.Drawing.Size(94, 25);
            this.futureColor.TabIndex = 1;
            this.futureColor.Text = "Color";
            this.futureColor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Future";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soon";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Now";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Past";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.nowPopup);
            this.flowLayoutPanel5.Controls.Add(this.nowSound);
            this.flowLayoutPanel5.Controls.Add(this.nowVerbal);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(146, 66);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(312, 23);
            this.flowLayoutPanel5.TabIndex = 7;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // nowPopup
            // 
            this.nowPopup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nowPopup.AutoSize = true;
            this.nowPopup.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowPopup;
            this.nowPopup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nowPopup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowPopup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowPopup.Location = new System.Drawing.Point(3, 3);
            this.nowPopup.Name = "nowPopup";
            this.nowPopup.Size = new System.Drawing.Size(57, 17);
            this.nowPopup.TabIndex = 0;
            this.nowPopup.Text = "Popup";
            this.nowPopup.UseVisualStyleBackColor = true;
            // 
            // nowSound
            // 
            this.nowSound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nowSound.AutoSize = true;
            this.nowSound.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowSound;
            this.nowSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nowSound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.flowLayoutPanel5.SetFlowBreak(this.nowSound, true);
            this.nowSound.Location = new System.Drawing.Point(66, 3);
            this.nowSound.Name = "nowSound";
            this.nowSound.Size = new System.Drawing.Size(57, 17);
            this.nowSound.TabIndex = 1;
            this.nowSound.Text = "Sound";
            this.nowSound.UseVisualStyleBackColor = true;
            // 
            // nowVerbal
            // 
            this.nowVerbal.AutoSize = true;
            this.nowVerbal.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowVerbal;
            this.nowVerbal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowVerbal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowVerbal.Location = new System.Drawing.Point(129, 3);
            this.nowVerbal.Name = "nowVerbal";
            this.nowVerbal.Size = new System.Drawing.Size(56, 17);
            this.nowVerbal.TabIndex = 2;
            this.nowVerbal.Text = "Verbal";
            this.nowVerbal.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.pastDismiss);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(146, 97);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(312, 23);
            this.flowLayoutPanel8.TabIndex = 10;
            // 
            // pastDismiss
            // 
            this.pastDismiss.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pastDismiss.AutoSize = true;
            this.pastDismiss.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.PastDismiss;
            this.pastDismiss.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "PastDismiss", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pastDismiss.Location = new System.Drawing.Point(3, 3);
            this.pastDismiss.Name = "pastDismiss";
            this.pastDismiss.Size = new System.Drawing.Size(61, 17);
            this.pastDismiss.TabIndex = 0;
            this.pastDismiss.Text = "Dismiss";
            this.pastDismiss.UseVisualStyleBackColor = true;
            // 
            // soonColor
            // 
            this.soonColor.AutoSize = true;
            this.soonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.soonColor.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoonColor;
            this.soonColor.ColorDialog = this.colorDialog1;
            this.soonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soonColor.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soonColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.soonColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.soonColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.soonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soonColor.Location = new System.Drawing.Point(46, 34);
            this.soonColor.Name = "soonColor";
            this.soonColor.Size = new System.Drawing.Size(94, 25);
            this.soonColor.TabIndex = 3;
            this.soonColor.Text = "Color";
            this.soonColor.UseVisualStyleBackColor = false;
            // 
            // nowColor
            // 
            this.nowColor.AutoSize = true;
            this.nowColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowColor.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.NowColor;
            this.nowColor.ColorDialog = this.colorDialog1;
            this.nowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nowColor.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "NowColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nowColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.nowColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nowColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowColor.Location = new System.Drawing.Point(46, 66);
            this.nowColor.Name = "nowColor";
            this.nowColor.Size = new System.Drawing.Size(94, 25);
            this.nowColor.TabIndex = 6;
            this.nowColor.Text = "Color";
            this.nowColor.UseVisualStyleBackColor = false;
            // 
            // pastColor
            // 
            this.pastColor.AutoSize = true;
            this.pastColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastColor.Color = global::ReflectiveCode.GMinder.Properties.Settings.Default.PastColor;
            this.pastColor.ColorDialog = this.colorDialog1;
            this.pastColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastColor.DataBindings.Add(new System.Windows.Forms.Binding("Color", global::ReflectiveCode.GMinder.Properties.Settings.Default, "PastColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pastColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pastColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pastColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastColor.Location = new System.Drawing.Point(46, 97);
            this.pastColor.Name = "pastColor";
            this.pastColor.Size = new System.Drawing.Size(94, 25);
            this.pastColor.TabIndex = 9;
            this.pastColor.Text = "Color";
            this.pastColor.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.soundPlay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.soundBrowse, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.soundPath, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // soundBrowse
            // 
            this.soundBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundBrowse.AutoSize = true;
            this.soundBrowse.FileName = "First Run";
            this.soundBrowse.Location = new System.Drawing.Point(84, 3);
            this.soundBrowse.Name = "soundBrowse";
            this.soundBrowse.OpenFileDialog = this.openFileDialog1;
            this.soundBrowse.Size = new System.Drawing.Size(75, 23);
            this.soundBrowse.TabIndex = 1;
            this.soundBrowse.Text = "Browse";
            this.soundBrowse.TextBox = this.soundPath;
            this.soundBrowse.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wave|*.wav|All files|*.*";
            this.openFileDialog1.Title = "Sound File";
            // 
            // soundPath
            // 
            this.soundPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.soundPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReflectiveCode.GMinder.Properties.Settings.Default, "SoundPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soundPath.Location = new System.Drawing.Point(165, 4);
            this.soundPath.Name = "soundPath";
            this.soundPath.Size = new System.Drawing.Size(293, 20);
            this.soundPath.TabIndex = 2;
            this.soundPath.Text = global::ReflectiveCode.GMinder.Properties.Settings.Default.SoundPath;
            // 
            // soundPlay
            // 
            this.soundPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundPlay.AutoSize = true;
            this.soundPlay.Location = new System.Drawing.Point(3, 3);
            this.soundPlay.Name = "soundPlay";
            this.soundPlay.Size = new System.Drawing.Size(75, 23);
            this.soundPlay.TabIndex = 0;
            this.soundPlay.Text = "Play";
            this.soundPlay.UseVisualStyleBackColor = true;
            this.soundPlay.Click += new System.EventHandler(this.soundPlay_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.flowLayoutPanel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(467, 117);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agenda";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.refreshRate);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.preload);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.doPing);
            this.flowLayoutPanel3.Controls.Add(this.onTop);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(461, 98);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // refreshRate
            // 
            this.refreshRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshRate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "RefreshRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.refreshRate.Location = new System.Drawing.Point(3, 3);
            this.refreshRate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.refreshRate.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.refreshRate.Name = "refreshRate";
            this.refreshRate.Size = new System.Drawing.Size(67, 20);
            this.refreshRate.TabIndex = 0;
            this.refreshRate.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.RefreshRate;
            // 
            // preload
            // 
            this.preload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preload.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ReflectiveCode.GMinder.Properties.Settings.Default, "LoadDays", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.preload.Location = new System.Drawing.Point(3, 29);
            this.preload.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.preload.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.preload.Name = "preload";
            this.preload.Size = new System.Drawing.Size(67, 20);
            this.preload.TabIndex = 2;
            this.preload.Value = global::ReflectiveCode.GMinder.Properties.Settings.Default.LoadDays;
            // 
            // doPing
            // 
            this.doPing.AutoSize = true;
            this.doPing.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.DoPing;
            this.doPing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doPing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "DoPing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.flowLayoutPanel3.SetFlowBreak(this.doPing, true);
            this.doPing.Location = new System.Drawing.Point(3, 55);
            this.doPing.Name = "doPing";
            this.doPing.Size = new System.Drawing.Size(423, 17);
            this.doPing.TabIndex = 5;
            this.doPing.Text = "Test connectivity before downloading events (disable if your events won\'t downloa" +
                "d)";
            this.doPing.UseVisualStyleBackColor = true;
            // 
            // onTop
            // 
            this.onTop.AutoSize = true;
            this.onTop.Checked = global::ReflectiveCode.GMinder.Properties.Settings.Default.OnTop;
            this.onTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReflectiveCode.GMinder.Properties.Settings.Default, "OnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.onTop.Location = new System.Drawing.Point(3, 78);
            this.onTop.Name = "onTop";
            this.onTop.Size = new System.Drawing.Size(92, 17);
            this.onTop.TabIndex = 4;
            this.onTop.Text = "Always on top";
            this.onTop.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel7, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(473, 388);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel7.Controls.Add(this.buttonOk);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 347);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(467, 29);
            this.flowLayoutPanel7.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(389, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soonTime)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preload)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox soundPath;
        private System.Windows.Forms.Button soundPlay;
        private Controls.OpenFileButton soundBrowse;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controls.IntegerUpDown refreshRate;
        private Controls.IntegerUpDown preload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox soonPopup;
        private System.Windows.Forms.CheckBox soonSound;
        private Controls.IntegerUpDown soonTime;
        private System.Windows.Forms.Label label2;
        private Controls.ColorButton futureColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox nowPopup;
        private System.Windows.Forms.CheckBox nowSound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.CheckBox pastDismiss;
        private Controls.ColorButton soonColor;
        private Controls.ColorButton nowColor;
        private Controls.ColorButton pastColor;
        private System.Windows.Forms.CheckBox onTop;
        private System.Windows.Forms.CheckBox doPing;
        private System.Windows.Forms.CheckBox soonVerbal;
        private System.Windows.Forms.CheckBox nowVerbal;
    }
}