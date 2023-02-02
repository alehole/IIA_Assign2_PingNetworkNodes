using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
namespace PingNetworkNodes
{
    public partial class Form1 : Form
    {
        int successCounter;
        int failedCounter;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_Scan_Click(object sender, EventArgs e)
        {
            StartPingTask();
        }
        private async void StartPingTask()
        {
            //txtBx_Result.Text = "Waiting For Task to complete";
            await Task.Run(() => PingNetwork());
            //txtBx_Result.Text = "Task Completed";
        }
        public void UpdateTxtBox(String text)
        {
            Invoke((MethodInvoker)delegate
            {
                richTxtBx_PingResp.AppendText(text);
                richTxtBx_PingResp.AppendText("\n");
            });
        }
        public void UpdateAvaileableNodes(String text)
        {
            Invoke((MethodInvoker)delegate
            {
                richTxtBx_AccesibleNodes.AppendText(text);
                richTxtBx_AccesibleNodes.AppendText("\n");
            });
        }
        public void UpdateCounters(bool Sucess)
        {
            Invoke((MethodInvoker)delegate
            {
                if (Sucess)
                {
                    successCounter += 1;
                    txtBox_SuccessCounter.Text = successCounter.ToString();
                }
                else
                {
                    failedCounter += 1;
                    txtBox_FailedCounter.Text = failedCounter.ToString();
                }
            });
        }
        private void PingNetwork()
        {
            string host, data;
            byte[] buffer;
            int timeout;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            options.Ttl = 128;
            // fragmentation behavior.
            options.DontFragment = true;
            // Data buffer to be transmitted.
            data = "ABC";
            buffer = Encoding.ASCII.GetBytes(data);
            timeout = 120;
            for (int i = 0; i <= 255; i++)
            {
                //host = "192.168.0." + i.ToString();
                host = txtBx_IP.Text + "." + i.ToString();
                PingReply reply = pingSender.Send(host, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    UpdateTxtBox(("Success Ping: " + host).ToString());
                    UpdateAvaileableNodes(host);
                    UpdateCounters(true);
                    Thread.Sleep(10);
                }
                else
                {
                    UpdateTxtBox(("Failed Ping: " + host).ToString());
                    UpdateCounters(false);
                    Thread.Sleep(10);
                }
            }
            UpdateTxtBox("Finished");
        }
        private void richTxtBx_PingResp_TextChanged(object sender, EventArgs e)
        {
            richTxtBx_PingResp.SelectionStart = richTxtBx_PingResp.Text.Length;
            richTxtBx_PingResp.ScrollToCaret();
        }
        private void richTxtBx_AccesibleNodes_TextChanged(object sender, EventArgs e)
        {
            richTxtBx_AccesibleNodes.SelectionStart = richTxtBx_AccesibleNodes.Text.Length;
            richTxtBx_AccesibleNodes.ScrollToCaret();
        }

    }
}
