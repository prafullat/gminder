namespace ReflectiveCode.GMinder
{
    partial class Calendars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendars));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.Label();
            this.loginSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarAdd = new System.Windows.Forms.Button();
            this.calendarRemove = new System.Windows.Forms.Button();
            this.calendarDownload = new System.Windows.Forms.Button();
            this.calendarName = new System.Windows.Forms.TextBox();
            this.calendarUrl = new System.Windows.Forms.TextBox();
            this.calendarList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.calendarColor = new ReflectiveCode.GMinder.Controls.ColorButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.loginUsername);
            this.flowLayoutPanel2.Controls.Add(this.loginSet);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(443, 42);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // loginUsername
            // 
            this.loginUsername.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.loginUsername, true);
            this.loginUsername.Location = new System.Drawing.Point(67, 0);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(53, 13);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.Text = "username";
            // 
            // loginSet
            // 
            this.loginSet.Location = new System.Drawing.Point(3, 16);
            this.loginSet.Name = "loginSet";
            this.loginSet.Size = new System.Drawing.Size(75, 23);
            this.loginSet.TabIndex = 2;
            this.loginSet.Text = "Set";
            this.loginSet.UseVisualStyleBackColor = true;
            this.loginSet.Click += new System.EventHandler(this.loginSet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calendars";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.calendarName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.calendarUrl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.calendarList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.calendarColor, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 233);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Url";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.calendarAdd);
            this.flowLayoutPanel3.Controls.Add(this.calendarRemove);
            this.flowLayoutPanel3.Controls.Add(this.calendarDownload);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 201);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(437, 29);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // calendarAdd
            // 
            this.calendarAdd.Location = new System.Drawing.Point(3, 3);
            this.calendarAdd.Name = "calendarAdd";
            this.calendarAdd.Size = new System.Drawing.Size(84, 23);
            this.calendarAdd.TabIndex = 0;
            this.calendarAdd.Text = "Add";
            this.calendarAdd.UseVisualStyleBackColor = true;
            this.calendarAdd.Click += new System.EventHandler(this.calendarAdd_Click);
            // 
            // calendarRemove
            // 
            this.calendarRemove.Location = new System.Drawing.Point(93, 3);
            this.calendarRemove.Name = "calendarRemove";
            this.calendarRemove.Size = new System.Drawing.Size(84, 23);
            this.calendarRemove.TabIndex = 1;
            this.calendarRemove.Text = "Remove";
            this.calendarRemove.UseVisualStyleBackColor = true;
            this.calendarRemove.Click += new System.EventHandler(this.calendarRemove_Click);
            // 
            // calendarDownload
            // 
            this.calendarDownload.Location = new System.Drawing.Point(183, 3);
            this.calendarDownload.Name = "calendarDownload";
            this.calendarDownload.Size = new System.Drawing.Size(84, 23);
            this.calendarDownload.TabIndex = 2;
            this.calendarDownload.Text = "Download";
            this.calendarDownload.UseVisualStyleBackColor = true;
            this.calendarDownload.Click += new System.EventHandler(this.calendarDownload_Click);
            // 
            // calendarName
            // 
            this.calendarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarName.Location = new System.Drawing.Point(44, 120);
            this.calendarName.Name = "calendarName";
            this.calendarName.Size = new System.Drawing.Size(396, 20);
            this.calendarName.TabIndex = 2;
            this.calendarName.TextChanged += new System.EventHandler(this.calendarName_TextChanged);
            // 
            // calendarUrl
            // 
            this.calendarUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarUrl.Location = new System.Drawing.Point(44, 146);
            this.calendarUrl.Name = "calendarUrl";
            this.calendarUrl.Size = new System.Drawing.Size(396, 20);
            this.calendarUrl.TabIndex = 4;
            this.calendarUrl.TextChanged += new System.EventHandler(this.calendarUrl_TextChanged);
            // 
            // calendarList
            // 
            this.calendarList.CheckBoxes = true;
            this.calendarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.tableLayoutPanel2.SetColumnSpan(this.calendarList, 2);
            this.calendarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarList.FullRowSelect = true;
            this.calendarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.calendarList.LabelWrap = false;
            this.calendarList.Location = new System.Drawing.Point(3, 3);
            this.calendarList.MultiSelect = false;
            this.calendarList.Name = "calendarList";
            this.calendarList.Size = new System.Drawing.Size(437, 111);
            this.calendarList.TabIndex = 0;
            this.calendarList.UseCompatibleStateImageBehavior = false;
            this.calendarList.View = System.Windows.Forms.View.Details;
            this.calendarList.ClientSizeChanged += new System.EventHandler(this.calendarList_ClientSizeChanged);
            this.calendarList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.calendarList_ItemChecked);
            this.calendarList.SelectedIndexChanged += new System.EventHandler(this.calendarList_SelectedIndexChanged);
            this.calendarList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calendarList_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Calendar";
            this.columnHeader1.Width = 145;
            // 
            // calendarColor
            // 
            this.calendarColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarColor.BackColor = System.Drawing.Color.Black;
            this.calendarColor.Color = System.Drawing.Color.Black;
            this.calendarColor.ColorDialog = null;
            this.calendarColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.calendarColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.calendarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarColor.Location = new System.Drawing.Point(44, 172);
            this.calendarColor.Name = "calendarColor";
            this.calendarColor.Size = new System.Drawing.Size(396, 23);
            this.calendarColor.TabIndex = 6;
            this.calendarColor.UseVisualStyleBackColor = false;
            this.calendarColor.Click += new System.EventHandler(this.calendarColor_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.buttonOk);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 325);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(377, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(296, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Calendars
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(455, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calendars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendars";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginUsername;
        private System.Windows.Forms.Button loginSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button calendarAdd;
        private System.Windows.Forms.Button calendarRemove;
        private System.Windows.Forms.Button calendarDownload;
        private System.Windows.Forms.TextBox calendarName;
        private System.Windows.Forms.TextBox calendarUrl;
        private System.Windows.Forms.ListView calendarList;
        private Controls.ColorButton calendarColor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}