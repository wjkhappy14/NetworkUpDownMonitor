namespace UpDownMonitor {
    partial class NetGraphForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetGraphForm));
            this.toolbox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPing = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.topmostMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparencyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.homePageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.TableLayoutPanel();
            this.dlRaw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlAvg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ulRaw = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ulAvg = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.close = new UpDownMonitor.Controls.BilgeButton();
            this.minimize = new UpDownMonitor.Controls.BilgeButton();
            this.topmost = new UpDownMonitor.Controls.BilgeButton();
            this.transparent = new UpDownMonitor.Controls.BilgeButton();
            this.reset = new UpDownMonitor.Controls.BilgeButton();
            this.settings = new UpDownMonitor.Controls.BilgeButton();
            this.nicSpeed = new UpDownMonitor.Controls.VerticalLabel();
            this.netGraph = new UpDownMonitor.Controls.NetGraph();
            this.toolbox.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.Moccasin;
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolbox.Controls.Add(this.close);
            this.toolbox.Controls.Add(this.minimize);
            this.toolbox.Controls.Add(this.topmost);
            this.toolbox.Controls.Add(this.transparent);
            this.toolbox.Controls.Add(this.reset);
            this.toolbox.Controls.Add(this.settings);
            this.toolbox.Controls.Add(this.btnPing);
            this.toolbox.Location = new System.Drawing.Point(474, 1);
            this.toolbox.Name = "toolbox";
            this.toolbox.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolbox.Size = new System.Drawing.Size(119, 133);
            this.toolbox.TabIndex = 7;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(3, 21);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(64, 31);
            this.btnPing.TabIndex = 5;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.optionsMenuItem,
            this.toolStripSeparator1,
            this.topmostMenuItem,
            this.transparencyMenuItem,
            this.resetMenuItem,
            this.toolStripSeparator2,
            this.homePageMenuItem,
            this.exitMenuItem});
            this.trayMenu.Name = "contextMenuStrip1";
            this.trayMenu.ShowCheckMargin = true;
            this.trayMenu.ShowImageMargin = false;
            this.trayMenu.Size = new System.Drawing.Size(227, 170);
            // 
            // showMenuItem
            // 
            this.showMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(226, 22);
            this.showMenuItem.Text = "&Show/Hide UpDown Meter";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(226, 22);
            this.optionsMenuItem.Text = "&Options...";
            this.optionsMenuItem.Click += new System.EventHandler(this.settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // topmostMenuItem
            // 
            this.topmostMenuItem.CheckOnClick = true;
            this.topmostMenuItem.Name = "topmostMenuItem";
            this.topmostMenuItem.Size = new System.Drawing.Size(226, 22);
            this.topmostMenuItem.Text = "&Always on top";
            this.topmostMenuItem.Click += new System.EventHandler(this.topmost_Click);
            // 
            // transparencyMenuItem
            // 
            this.transparencyMenuItem.CheckOnClick = true;
            this.transparencyMenuItem.Name = "transparencyMenuItem";
            this.transparencyMenuItem.Size = new System.Drawing.Size(226, 22);
            this.transparencyMenuItem.Text = "&Transparency";
            this.transparencyMenuItem.Click += new System.EventHandler(this.transparent_Click);
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(226, 22);
            this.resetMenuItem.Text = "Clea&r graph";
            this.resetMenuItem.Click += new System.EventHandler(this.reset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // homePageMenuItem
            // 
            this.homePageMenuItem.Name = "homePageMenuItem";
            this.homePageMenuItem.Size = new System.Drawing.Size(226, 22);
            this.homePageMenuItem.Text = "&Home page";
            this.homePageMenuItem.Click += new System.EventHandler(this.homePageMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(226, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.close_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusBar.ColumnCount = 8;
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41899F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58101F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41899F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.23958F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.45833F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.28125F));
            this.statusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58101F));
            this.statusBar.Controls.Add(this.dlRaw, 1, 0);
            this.statusBar.Controls.Add(this.label1, 0, 0);
            this.statusBar.Controls.Add(this.label3, 2, 0);
            this.statusBar.Controls.Add(this.dlAvg, 3, 0);
            this.statusBar.Controls.Add(this.label5, 4, 0);
            this.statusBar.Controls.Add(this.ulRaw, 5, 0);
            this.statusBar.Controls.Add(this.label7, 6, 0);
            this.statusBar.Controls.Add(this.ulAvg, 7, 0);
            this.statusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Location = new System.Drawing.Point(39, 12);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.statusBar.RowCount = 1;
            this.statusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusBar.Size = new System.Drawing.Size(429, 26);
            this.statusBar.TabIndex = 5;
            // 
            // dlRaw
            // 
            this.dlRaw.AutoSize = true;
            this.dlRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dlRaw.ForeColor = System.Drawing.Color.Red;
            this.dlRaw.Location = new System.Drawing.Point(60, 0);
            this.dlRaw.Margin = new System.Windows.Forms.Padding(0);
            this.dlRaw.Name = "dlRaw";
            this.dlRaw.Size = new System.Drawing.Size(49, 26);
            this.dlRaw.TabIndex = 1;
            this.dlRaw.Text = "0";
            this.dlRaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载速度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(109, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "下载均速";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dlAvg
            // 
            this.dlAvg.AutoSize = true;
            this.dlAvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dlAvg.ForeColor = System.Drawing.Color.Red;
            this.dlAvg.Location = new System.Drawing.Point(166, 0);
            this.dlAvg.Margin = new System.Windows.Forms.Padding(0);
            this.dlAvg.Name = "dlAvg";
            this.dlAvg.Size = new System.Drawing.Size(52, 26);
            this.dlAvg.TabIndex = 3;
            this.dlAvg.Text = "0";
            this.dlAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(218, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "上传速度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ulRaw
            // 
            this.ulRaw.AutoSize = true;
            this.ulRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ulRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ulRaw.ForeColor = System.Drawing.Color.Red;
            this.ulRaw.Location = new System.Drawing.Point(271, 0);
            this.ulRaw.Margin = new System.Windows.Forms.Padding(0);
            this.ulRaw.Name = "ulRaw";
            this.ulRaw.Size = new System.Drawing.Size(48, 26);
            this.ulRaw.TabIndex = 5;
            this.ulRaw.Text = "0";
            this.ulRaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(319, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "上传均速";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ulAvg
            // 
            this.ulAvg.AutoSize = true;
            this.ulAvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ulAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ulAvg.ForeColor = System.Drawing.Color.Red;
            this.ulAvg.Location = new System.Drawing.Point(375, 0);
            this.ulAvg.Margin = new System.Windows.Forms.Padding(0);
            this.ulAvg.Name = "ulAvg";
            this.ulAvg.Size = new System.Drawing.Size(51, 26);
            this.ulAvg.TabIndex = 7;
            this.ulAvg.Text = "0";
            this.ulAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 700;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.close.Image = null;
            this.close.Location = new System.Drawing.Point(1, 2);
            this.close.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.TabIndex = 0;
            this.toolTip.SetToolTip(this.close, "Close");
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.DarkOrange;
            this.minimize.Image = null;
            this.minimize.Location = new System.Drawing.Point(18, 2);
            this.minimize.Margin = new System.Windows.Forms.Padding(1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(15, 15);
            this.minimize.TabIndex = 1;
            this.toolTip.SetToolTip(this.minimize, "Minimize");
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // topmost
            // 
            this.topmost.BackColor = System.Drawing.Color.Lime;
            this.topmost.Image = null;
            this.topmost.Location = new System.Drawing.Point(35, 2);
            this.topmost.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.topmost.Name = "topmost";
            this.topmost.Size = new System.Drawing.Size(15, 15);
            this.topmost.TabIndex = 2;
            this.topmost.ToggleButton = true;
            this.toolTip.SetToolTip(this.topmost, "Always on top");
            this.topmost.Click += new System.EventHandler(this.topmost_Click);
            // 
            // transparent
            // 
            this.transparent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.transparent.Image = null;
            this.transparent.Location = new System.Drawing.Point(52, 2);
            this.transparent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.transparent.Name = "transparent";
            this.transparent.Size = new System.Drawing.Size(15, 15);
            this.transparent.TabIndex = 3;
            this.transparent.ToggleButton = true;
            this.toolTip.SetToolTip(this.transparent, "Transparency");
            this.transparent.Click += new System.EventHandler(this.transparent_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.reset.Image = null;
            this.reset.Location = new System.Drawing.Point(69, 2);
            this.reset.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(15, 15);
            this.reset.TabIndex = 4;
            this.toolTip.SetToolTip(this.reset, "Clear graph");
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Red;
            this.settings.Image = null;
            this.settings.Location = new System.Drawing.Point(86, 2);
            this.settings.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(15, 15);
            this.settings.TabIndex = 4;
            this.toolTip.SetToolTip(this.settings, "Options");
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // nicSpeed
            // 
            this.nicSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nicSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(10)));
            this.nicSpeed.ForeColor = System.Drawing.Color.Red;
            this.nicSpeed.Location = new System.Drawing.Point(4, 17);
            this.nicSpeed.Name = "nicSpeed";
            this.nicSpeed.Size = new System.Drawing.Size(22, 95);
            this.nicSpeed.TabIndex = 5;
            this.nicSpeed.Text = "NIC speed";
            this.nicSpeed.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // netGraph
            // 
            this.netGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.netGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netGraph.ForeColor = System.Drawing.Color.Red;
            this.netGraph.Location = new System.Drawing.Point(30, 44);
            this.netGraph.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.netGraph.Name = "netGraph";
            this.netGraph.Size = new System.Drawing.Size(438, 80);
            this.netGraph.TabIndex = 1;
            this.netGraph.Text = "netGraph1";
            this.netGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NetGraphForm_MouseDown);
            this.netGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NetGraphForm_MouseMove);
            // 
            // NetGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 135);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.nicSpeed);
            this.Controls.Add(this.netGraph);
            this.Controls.Add(this.statusBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetGraphForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NetGraphForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NetGraphForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NetGraphForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NetGraphForm_MouseMove);
            this.Resize += new System.EventHandler(this.NetGraphForm_Resize);
            this.toolbox.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.NetGraph netGraph;
        private Controls.VerticalLabel nicSpeed;
        private System.Windows.Forms.FlowLayoutPanel toolbox;
        private Controls.BilgeButton close;
        private Controls.BilgeButton minimize;
        private Controls.BilgeButton topmost;
        private Controls.BilgeButton transparent;
        private Controls.BilgeButton settings;
        private Controls.BilgeButton reset;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem topmostMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparencyMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.TableLayoutPanel statusBar;
        private System.Windows.Forms.Label dlRaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dlAvg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ulRaw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ulAvg;
        private System.Windows.Forms.ToolStripMenuItem homePageMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnPing;
    }
}