using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ___Statue___ = true;
        private void btnControl_Click(object sender, EventArgs e)
        {
            ___Statue___ = !___Statue___;
            if (___Statue___)
                __stop__();
            else
                __Start__();


        }

        private void __Start__()
        {
            timer1.Start();
            btnControl.Text = "Stop";
        }

        private void __stop__()
        {
            timer1.Stop();
            btnControl.Text = "Start";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            __CallBack__();
        }

        private void __CallBack__()
        {
            string __xcopied__ = Clipboard.GetText();
            string __savedData__ ="";
            try
            {
               __savedData__= System.IO.File.ReadAllText(this.__StorePath__);
            }
            catch { }
            if ((__xcopied__ == this.__LastCopied__ || __xcopied__ == null || __xcopied__.Length < 1) && __savedData__.Length>4)
                return;

            this.__LastCopied__ = __xcopied__;

           
            
            //if (this.storeInMultiFiles)
            //    MultiStore(x,time);
            //else
                __Store__(__xcopied__); 
        }

        private bool __Store__(string __par__)
        {   // singlefile
            try
            {
                string __data__ = "";
                try
                {
                    __data__ = System.IO.File.ReadAllText(this.__StorePath__);
                }
                catch { }
                if(__par__.StartsWith("["))
                 __par__+=(".   "+__par__);
            __data__ += (Environment.NewLine+Environment.NewLine+Environment.NewLine);
            __data__ += "[ " + Manager.getTimeNow() + " ]" + Environment.NewLine + __par__;
           
            System.IO.File.WriteAllText(this.__StorePath__,__data__.Trim());
              return true;
            }
            catch { return false; }
        }

        //private bool  MultiStore(string p, string time)
        //{ // separated files
        //    try
        //    {
        //        string newpath = this.StorePath + "\\" + time + ".txt";
        //        System.IO.File.WriteAllText(newpath, p);
        //        return true;
        //    }
        //    catch { return false; }
        //}

        public string __LastCopied__ { get; set; }

     //   public bool storeInMultiFiles { get; set; }

       /* public string StorePath {
            get
        {
            if (storepath == "")
                return Application.StartupPath + "\\saved.txt";
            else return storepath;
        }

            set
            {
            }
        }*/
        string __storepath__ = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            rb_startup.Checked = Manager.StartupStatue();
            btnControl.PerformClick();
            this.MinimumSize = MaximumSize = this.Size;
            notifyIcon1.BalloonTipText = "Application Minimized.";
            notifyIcon1.BalloonTipTitle = "Paster";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
       // string storefolder="";
       /* public string StoreFolder
        {
            get
            {

                if (System.IO.Directory.Exists(storefolder))
                    return storefolder;
                else
                {

                    if (System.IO.Directory.Exists(Application.StartupPath + "\\Store"))
                        System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Store");

                    return Application.StartupPath + "\\Store";
                }

            }
            set { }
            
        }*/

        private void lnklblView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ___i__="";
            //if (this.storeInMultiFiles)
            //    i = this.StoreFolder;
            //else
                ___i__ = this.__StorePath__;
            System.Diagnostics.Process.Start(___i__);
        }

        public string __StorePath__
        {
            get
            {
                if (this.__storepath__ == "")
                    return Application.StartupPath + "\\saved.txt";
                else
                    return __storepath__;
            }
            set{}
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Paster";
            notifyIcon1.BalloonTipText = "Im Here.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void rb_startup_CheckedChanged(object sender, EventArgs e)
        {
            string __startup_path__ = System.IO.Path.GetTempPath();
            __startup_path__ = __startup_path__ + "\\..\\..\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\paster.exe";

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rb_startup.Checked)
            {
                rk.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
                //C:\Users\GersyWin\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
                //C:\Users\GersyWin\AppData\Local\Temp
                try
                {
                
                    if (!System.IO.File.Exists(__startup_path__))
                        System.IO.File.Copy(Application.ExecutablePath, __startup_path__);
                }
                catch { }

            }
            else
            {
                rk.DeleteValue(Application.ProductName, false);
                if (!System.IO.File.Exists(__startup_path__))
                    System.IO.File.Delete(__startup_path__);
              

            }
            Manager.RunOnstartup(rb_startup.Checked);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Coded by YasserGersy","Paster :D ");
            System.Diagnostics.Process.Start("https://twitter.com/YasserGersy");
        }
    }
}
