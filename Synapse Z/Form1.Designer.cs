namespace Synapse_Z
{
    partial class SynapseZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynapseZ));
            TopBar = new System.Windows.Forms.Panel();
            Minimize = new System.Windows.Forms.Button();
            Close = new System.Windows.Forms.Button();
            Maximize = new System.Windows.Forms.Button();
            synlabel = new System.Windows.Forms.Label();
            Logo = new System.Windows.Forms.PictureBox();
            Scriptbox = new System.Windows.Forms.ListBox();
            Execute = new System.Windows.Forms.Button();
            Clear = new System.Windows.Forms.Button();
            OpenFile = new System.Windows.Forms.Button();
            SaveFile = new System.Windows.Forms.Button();
            Options = new System.Windows.Forms.Button();
            ScriptHub = new System.Windows.Forms.Button();
            Attach = new System.Windows.Forms.Button();
            ExecuteFile = new System.Windows.Forms.Button();
            mainWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1 = new Manina.Windows.Forms.TabControl();
            ExampleTab = new Manina.Windows.Forms.Tab();
            backPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainWebView2).BeginInit();
            tabControl1.SuspendLayout();
            backPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            TopBar.Controls.Add(Minimize);
            TopBar.Controls.Add(Close);
            TopBar.Controls.Add(Maximize);
            TopBar.Controls.Add(synlabel);
            TopBar.Controls.Add(Logo);
            TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            TopBar.Location = new System.Drawing.Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new System.Drawing.Size(853, 31);
            TopBar.TabIndex = 1;
            TopBar.MouseDown += panel1_MouseDown;
            TopBar.MouseMove += panel1_MouseMove;
            TopBar.MouseUp += panel1_MouseUp;
            // 
            // Minimize
            // 
            Minimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Minimize.BackColor = System.Drawing.Color.Transparent;
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Minimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Minimize.ForeColor = System.Drawing.Color.White;
            Minimize.Location = new System.Drawing.Point(781, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new System.Drawing.Size(20, 23);
            Minimize.TabIndex = 4;
            Minimize.Text = "_";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += MinimizeButton_Click;
            Minimize.MouseEnter += FlatButton_MouseEnter;
            Minimize.MouseLeave += FlatButton_MouseLeave;
            // 
            // Close
            // 
            Close.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Close.BackColor = System.Drawing.Color.Transparent;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Close.ForeColor = System.Drawing.Color.White;
            Close.Location = new System.Drawing.Point(833, 0);
            Close.Name = "Close";
            Close.Size = new System.Drawing.Size(20, 23);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += CloseButton_Click;
            Close.MouseEnter += FlatButton_MouseEnter;
            Close.MouseLeave += FlatButton_MouseLeave;
            // 
            // Maximize
            // 
            Maximize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Maximize.BackColor = System.Drawing.Color.Transparent;
            Maximize.FlatAppearance.BorderSize = 0;
            Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Maximize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Maximize.ForeColor = System.Drawing.Color.White;
            Maximize.Location = new System.Drawing.Point(807, 0);
            Maximize.Name = "Maximize";
            Maximize.Size = new System.Drawing.Size(20, 23);
            Maximize.TabIndex = 3;
            Maximize.Text = "M";
            Maximize.UseVisualStyleBackColor = false;
            Maximize.Click += MaximizeButton_Click;
            Maximize.MouseEnter += FlatButton_MouseEnter;
            Maximize.MouseLeave += FlatButton_MouseLeave;
            // 
            // synlabel
            // 
            synlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            synlabel.BackColor = System.Drawing.Color.Transparent;
            synlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            synlabel.ForeColor = System.Drawing.Color.White;
            synlabel.Location = new System.Drawing.Point(33, 0);
            synlabel.Name = "synlabel";
            synlabel.Size = new System.Drawing.Size(742, 31);
            synlabel.TabIndex = 1;
            synlabel.Text = "Synapse Z - vX.X.X";
            synlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            synlabel.MouseDown += panel1_MouseDown;
            synlabel.MouseMove += panel1_MouseMove;
            synlabel.MouseUp += panel1_MouseUp;
            // 
            // Logo
            // 
            Logo.BackColor = System.Drawing.Color.Transparent;
            Logo.BackgroundImage = (System.Drawing.Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Logo.Location = new System.Drawing.Point(4, 4);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(23, 23);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // Scriptbox
            // 
            Scriptbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Scriptbox.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Scriptbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Scriptbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            Scriptbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Scriptbox.ForeColor = System.Drawing.Color.White;
            Scriptbox.FormattingEnabled = true;
            Scriptbox.ItemHeight = 15;
            Scriptbox.Location = new System.Drawing.Point(714, 36);
            Scriptbox.Name = "Scriptbox";
            Scriptbox.Size = new System.Drawing.Size(135, 300);
            Scriptbox.TabIndex = 2;
            // 
            // Execute
            // 
            Execute.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Execute.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Execute.FlatAppearance.BorderSize = 0;
            Execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Execute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Execute.ForeColor = System.Drawing.Color.White;
            Execute.Location = new System.Drawing.Point(4, 342);
            Execute.Name = "Execute";
            Execute.Size = new System.Drawing.Size(100, 35);
            Execute.TabIndex = 3;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = false;
            Execute.Click += Execute_Click;
            Execute.MouseEnter += FlatButton_MouseEnter;
            Execute.MouseLeave += FlatButton_MouseLeave;
            // 
            // Clear
            // 
            Clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Clear.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Clear.ForeColor = System.Drawing.Color.White;
            Clear.Location = new System.Drawing.Point(110, 342);
            Clear.Name = "Clear";
            Clear.Size = new System.Drawing.Size(100, 35);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            Clear.MouseEnter += FlatButton_MouseEnter;
            Clear.MouseLeave += FlatButton_MouseLeave;
            // 
            // OpenFile
            // 
            OpenFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            OpenFile.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            OpenFile.FlatAppearance.BorderSize = 0;
            OpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            OpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            OpenFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            OpenFile.ForeColor = System.Drawing.Color.White;
            OpenFile.Location = new System.Drawing.Point(216, 342);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new System.Drawing.Size(100, 35);
            OpenFile.TabIndex = 3;
            OpenFile.Text = "Open File";
            OpenFile.UseVisualStyleBackColor = false;
            OpenFile.Click += OpenFile_Click;
            OpenFile.MouseEnter += FlatButton_MouseEnter;
            OpenFile.MouseLeave += FlatButton_MouseLeave;
            // 
            // SaveFile
            // 
            SaveFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            SaveFile.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            SaveFile.FlatAppearance.BorderSize = 0;
            SaveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            SaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SaveFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SaveFile.ForeColor = System.Drawing.Color.White;
            SaveFile.Location = new System.Drawing.Point(428, 342);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new System.Drawing.Size(100, 35);
            SaveFile.TabIndex = 3;
            SaveFile.Text = "Save File";
            SaveFile.UseVisualStyleBackColor = false;
            SaveFile.Click += SaveFile_Click;
            SaveFile.MouseEnter += FlatButton_MouseEnter;
            SaveFile.MouseLeave += FlatButton_MouseLeave;
            // 
            // Options
            // 
            Options.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Options.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Options.FlatAppearance.BorderSize = 0;
            Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Options.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Options.ForeColor = System.Drawing.Color.White;
            Options.Location = new System.Drawing.Point(534, 342);
            Options.Name = "Options";
            Options.Size = new System.Drawing.Size(100, 35);
            Options.TabIndex = 3;
            Options.Text = "Options";
            Options.UseVisualStyleBackColor = false;
            Options.Click += Options_Click;
            Options.MouseEnter += FlatButton_MouseEnter;
            Options.MouseLeave += FlatButton_MouseLeave;
            // 
            // ScriptHub
            // 
            ScriptHub.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ScriptHub.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            ScriptHub.FlatAppearance.BorderSize = 0;
            ScriptHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            ScriptHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            ScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ScriptHub.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ScriptHub.ForeColor = System.Drawing.Color.White;
            ScriptHub.Location = new System.Drawing.Point(754, 342);
            ScriptHub.Name = "ScriptHub";
            ScriptHub.Size = new System.Drawing.Size(95, 35);
            ScriptHub.TabIndex = 3;
            ScriptHub.Text = "Script Hub";
            ScriptHub.UseVisualStyleBackColor = false;
            ScriptHub.Click += ScriptHub_Click;
            ScriptHub.MouseEnter += FlatButton_MouseEnter;
            ScriptHub.MouseLeave += FlatButton_MouseLeave;
            // 
            // Attach
            // 
            Attach.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Attach.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Attach.FlatAppearance.BorderSize = 0;
            Attach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Attach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Attach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Attach.ForeColor = System.Drawing.Color.White;
            Attach.Location = new System.Drawing.Point(653, 342);
            Attach.Name = "Attach";
            Attach.Size = new System.Drawing.Size(95, 35);
            Attach.TabIndex = 3;
            Attach.Text = "Attach";
            Attach.UseVisualStyleBackColor = false;
            Attach.Click += Attach_Click;
            Attach.MouseEnter += FlatButton_MouseEnter;
            Attach.MouseLeave += FlatButton_MouseLeave;
            // 
            // ExecuteFile
            // 
            ExecuteFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ExecuteFile.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            ExecuteFile.FlatAppearance.BorderSize = 0;
            ExecuteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            ExecuteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            ExecuteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ExecuteFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ExecuteFile.ForeColor = System.Drawing.Color.White;
            ExecuteFile.Location = new System.Drawing.Point(322, 342);
            ExecuteFile.Name = "ExecuteFile";
            ExecuteFile.Size = new System.Drawing.Size(100, 35);
            ExecuteFile.TabIndex = 3;
            ExecuteFile.Text = "Execute File";
            ExecuteFile.UseVisualStyleBackColor = false;
            ExecuteFile.Click += ExecuteFile_Click;
            ExecuteFile.MouseEnter += FlatButton_MouseEnter;
            ExecuteFile.MouseLeave += FlatButton_MouseLeave;
            // 
            // mainWebView2
            // 
            mainWebView2.AllowExternalDrop = true;
            mainWebView2.CreationProperties = null;
            mainWebView2.DefaultBackgroundColor = System.Drawing.Color.White;
            mainWebView2.Dock = System.Windows.Forms.DockStyle.Fill;
            mainWebView2.Location = new System.Drawing.Point(0, 22);
            mainWebView2.Name = "mainWebView2";
            mainWebView2.Size = new System.Drawing.Size(704, 277);
            mainWebView2.TabIndex = 0;
            mainWebView2.ZoomFactor = 1D;
            // 
            // tabControl1
            // 
            tabControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tabControl1.CloseTabImage = Properties.Resources.Xn;
            tabControl1.Controls.Add(ExampleTab);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.ForeColor = System.Drawing.Color.Black;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowCloseTabButtons = true;
            tabControl1.Size = new System.Drawing.Size(704, 22);
            tabControl1.TabIndex = 0;
            tabControl1.Tabs.Add(ExampleTab);
            tabControl1.TabSizing = Manina.Windows.Forms.TabSizing.Fixed;
            // 
            // ExampleTab
            // 
            ExampleTab.BackColor = System.Drawing.Color.FromArgb(129, 129, 129);
            ExampleTab.ForeColor = System.Drawing.Color.White;
            ExampleTab.Location = new System.Drawing.Point(0, 23);
            ExampleTab.Name = "ExampleTab";
            ExampleTab.Size = new System.Drawing.Size(704, 0);
            ExampleTab.Text = "Script 1";
            // 
            // backPanel
            // 
            backPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            backPanel.Controls.Add(mainWebView2);
            backPanel.Controls.Add(panel1);
            backPanel.Location = new System.Drawing.Point(4, 37);
            backPanel.Name = "backPanel";
            backPanel.Size = new System.Drawing.Size(704, 299);
            backPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(704, 22);
            panel1.TabIndex = 1;
            // 
            // SynapseZ
            // 
            BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            ClientSize = new System.Drawing.Size(853, 381);
            Controls.Add(backPanel);
            Controls.Add(Attach);
            Controls.Add(ScriptHub);
            Controls.Add(Options);
            Controls.Add(ExecuteFile);
            Controls.Add(SaveFile);
            Controls.Add(OpenFile);
            Controls.Add(Clear);
            Controls.Add(Execute);
            Controls.Add(Scriptbox);
            Controls.Add(TopBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SynapseZ";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            Load += SynapseZ_Load;
            TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainWebView2).EndInit();
            tabControl1.ResumeLayout(false);
            backPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage Script1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox SynLogo;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label synTitle;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label synlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Scriptbox;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button ScriptHub;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ExecuteFile;
        private Microsoft.Web.WebView2.WinForms.WebView2 mainWebView2;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab ExampleTab;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

