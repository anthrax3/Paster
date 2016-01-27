namespace Paster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.lnklblView = new System.Windows.Forms.LinkLabel();
            this.btnControl = new System.Windows.Forms.Button();
            this.rb_startup = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMain.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.groupBoxContainer);
            this.panelMain.Location = new System.Drawing.Point(4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(255, 155);
            this.panelMain.TabIndex = 0;
            // 
            // groupBoxContainer
            // 
            this.groupBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxContainer.Controls.Add(this.lnklblView);
            this.groupBoxContainer.Controls.Add(this.btnControl);
            this.groupBoxContainer.Controls.Add(this.rb_startup);
            this.groupBoxContainer.Controls.Add(this.linkLabel1);
            this.groupBoxContainer.Location = new System.Drawing.Point(8, 9);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Size = new System.Drawing.Size(238, 137);
            this.groupBoxContainer.TabIndex = 0;
            this.groupBoxContainer.TabStop = false;
            // 
            // lnklblView
            // 
            this.lnklblView.AutoSize = true;
            this.lnklblView.Location = new System.Drawing.Point(82, 64);
            this.lnklblView.Name = "lnklblView";
            this.lnklblView.Size = new System.Drawing.Size(53, 13);
            this.lnklblView.TabIndex = 3;
            this.lnklblView.TabStop = true;
            this.lnklblView.Text = "view data";
            this.lnklblView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblView_LinkClicked);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(64, 19);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(110, 32);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "Start";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // rb_startup
            // 
            this.rb_startup.AutoSize = true;
            this.rb_startup.Location = new System.Drawing.Point(6, 96);
            this.rb_startup.Name = "rb_startup";
            this.rb_startup.Size = new System.Drawing.Size(95, 17);
            this.rb_startup.TabIndex = 1;
            this.rb_startup.TabStop = true;
            this.rb_startup.Text = "Run on startup";
            this.rb_startup.UseVisualStyleBackColor = true;
            this.rb_startup.CheckedChanged += new System.EventHandler(this.rb_startup_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(187, 114);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "paster";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 161);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMain.ResumeLayout(false);
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxContainer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox rb_startup;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnklblView;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

