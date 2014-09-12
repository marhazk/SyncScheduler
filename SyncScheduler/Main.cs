using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SyncScheduler
{
    public partial class Main : Form
    {
        public Aera.FileDB datadb;
        public int mins = 60;
        public int totalSync = 0;
        public System.Threading.Thread client;
        public bool running = false;
        public Main()
        {
            InitializeComponent();
        }

        public void cliThread()
        {
            string file = "";
            int num = 1;
            int success = 0;
            int fail = 0;
            while (running)
            {
                success = 0;
                fail = 0;
                for (int filenum = 1; filenum <= totalSync; filenum++)
                {
                    try
                    {
                        Program.f.send(lstStatus, "ID : " + num + " Syncronizing " + file);
                        file = INI.GetIniValue("sync", "file" + filenum, "aera.ini");
                        datadb = new Aera.FileDB(new Uri(@"" + file));
                        datadb.Dispose();
                        Program.f.send(lstStatus, "ID : " + num + " Sync completed for" + file);
                        success++;
                    }
                    catch
                    {
                        fail++;
                    }
                }
                num++;
                Program.f.send(mComplete, "Total completed synced : " + success);
                Program.f.send(mFail, "Total failed to be synced : " + fail);
                System.Threading.Thread.Sleep(mins * 1000);
            }
        }
        public void startProgress()
        {
            try
            {
                mins = Convert.ToInt32(mMins.Text);
                running = true;
                client = new System.Threading.Thread(new System.Threading.ThreadStart(cliThread));
            }
            catch
            {
                client.Abort();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "&Start")
            {
                totalSync = Convert.ToInt32(INI.GetIniValue("sync", "total", "aera.ini"));
                mTotal.Text = "Total need to be synced : "+totalSync;
                startProgress();
                btnStart.Text = "&Stop";
                mStatus.Text = "Status : Service started";
                Program.f.send(lstStatus, "SYNC started");
            }
            else
            {
                running = false;
                client.Abort();
                btnStart.Text = "&Start";
                mStatus.Text = "Status : Service stopped";
                Program.f.send(lstStatus, "SYNC stopped");
            }
        }
    }
}
