
namespace PingNetworkNodes
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
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.txtBx_IP = new System.Windows.Forms.TextBox();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.richTxtBx_PingResp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_SuccessCounter = new System.Windows.Forms.TextBox();
            this.txtBox_FailedCounter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtBx_AccesibleNodes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Location = new System.Drawing.Point(24, 22);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(54, 13);
            this.lbl_Ip.TabIndex = 0;
            this.lbl_Ip.Text = "IP adress:";
            // 
            // txtBx_IP
            // 
            this.txtBx_IP.Location = new System.Drawing.Point(84, 22);
            this.txtBx_IP.Name = "txtBx_IP";
            this.txtBx_IP.Size = new System.Drawing.Size(132, 20);
            this.txtBx_IP.TabIndex = 2;
            // 
            // btn_Scan
            // 
            this.btn_Scan.Location = new System.Drawing.Point(141, 48);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.btn_Scan.TabIndex = 4;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // richTxtBx_PingResp
            // 
            this.richTxtBx_PingResp.Location = new System.Drawing.Point(225, 22);
            this.richTxtBx_PingResp.Name = "richTxtBx_PingResp";
            this.richTxtBx_PingResp.ReadOnly = true;
            this.richTxtBx_PingResp.Size = new System.Drawing.Size(174, 140);
            this.richTxtBx_PingResp.TabIndex = 5;
            this.richTxtBx_PingResp.Text = "";
            this.richTxtBx_PingResp.TextChanged += new System.EventHandler(this.richTxtBx_PingResp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Success:";
            // 
            // txtBox_SuccessCounter
            // 
            this.txtBox_SuccessCounter.Location = new System.Drawing.Point(165, 111);
            this.txtBox_SuccessCounter.Name = "txtBox_SuccessCounter";
            this.txtBox_SuccessCounter.ReadOnly = true;
            this.txtBox_SuccessCounter.Size = new System.Drawing.Size(51, 20);
            this.txtBox_SuccessCounter.TabIndex = 7;
            // 
            // txtBox_FailedCounter
            // 
            this.txtBox_FailedCounter.Location = new System.Drawing.Point(165, 137);
            this.txtBox_FailedCounter.Name = "txtBox_FailedCounter";
            this.txtBox_FailedCounter.ReadOnly = true;
            this.txtBox_FailedCounter.Size = new System.Drawing.Size(51, 20);
            this.txtBox_FailedCounter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Failed:";
            // 
            // richTxtBx_AccesibleNodes
            // 
            this.richTxtBx_AccesibleNodes.Location = new System.Drawing.Point(405, 22);
            this.richTxtBx_AccesibleNodes.Name = "richTxtBx_AccesibleNodes";
            this.richTxtBx_AccesibleNodes.ReadOnly = true;
            this.richTxtBx_AccesibleNodes.Size = new System.Drawing.Size(128, 140);
            this.richTxtBx_AccesibleNodes.TabIndex = 10;
            this.richTxtBx_AccesibleNodes.Text = "";
            this.richTxtBx_AccesibleNodes.TextChanged += new System.EventHandler(this.richTxtBx_AccesibleNodes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Accessible Nodes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTxtBx_AccesibleNodes);
            this.Controls.Add(this.txtBox_FailedCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_SuccessCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtBx_PingResp);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.txtBx_IP);
            this.Controls.Add(this.lbl_Ip);
            this.Name = "Form1";
            this.Text = "Ping Network Nodes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txtBx_IP;
        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.RichTextBox richTxtBx_PingResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_SuccessCounter;
        private System.Windows.Forms.TextBox txtBox_FailedCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtBx_AccesibleNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

