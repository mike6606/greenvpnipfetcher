namespace GreenLinkFetcher
{
    partial class LinkFetcher
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
            this.webBrowserGreen = new System.Windows.Forms.WebBrowser();
            this.buttonFetchIP = new System.Windows.Forms.Button();
            this.dataGridViewIP = new System.Windows.Forms.DataGridView();
            this.ColumnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIP)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserGreen
            // 
            this.webBrowserGreen.Location = new System.Drawing.Point(0, 159);
            this.webBrowserGreen.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGreen.Name = "webBrowserGreen";
            this.webBrowserGreen.Size = new System.Drawing.Size(997, 419);
            this.webBrowserGreen.TabIndex = 0;
            this.webBrowserGreen.Url = new System.Uri("https://www.grjsq.biz/user-xianlu.html", System.UriKind.Absolute);
            this.webBrowserGreen.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserGreen_DocumentCompleted);
            // 
            // buttonFetchIP
            // 
            this.buttonFetchIP.Enabled = false;
            this.buttonFetchIP.Location = new System.Drawing.Point(12, 12);
            this.buttonFetchIP.Name = "buttonFetchIP";
            this.buttonFetchIP.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchIP.TabIndex = 1;
            this.buttonFetchIP.Text = "获取IP";
            this.buttonFetchIP.UseVisualStyleBackColor = true;
            this.buttonFetchIP.Click += new System.EventHandler(this.buttonFetchIP_Click);
            // 
            // dataGridViewIP
            // 
            this.dataGridViewIP.AllowUserToAddRows = false;
            this.dataGridViewIP.AllowUserToDeleteRows = false;
            this.dataGridViewIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIP,
            this.ColumnPing,
            this.ColumnName});
            this.dataGridViewIP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewIP.Location = new System.Drawing.Point(108, 12);
            this.dataGridViewIP.Name = "dataGridViewIP";
            this.dataGridViewIP.ReadOnly = true;
            this.dataGridViewIP.Size = new System.Drawing.Size(889, 141);
            this.dataGridViewIP.TabIndex = 2;
            // 
            // ColumnIP
            // 
            this.ColumnIP.HeaderText = "IP";
            this.ColumnIP.Name = "ColumnIP";
            this.ColumnIP.Width = 150;
            // 
            // ColumnPing
            // 
            this.ColumnPing.HeaderText = "Ping";
            this.ColumnPing.Name = "ColumnPing";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "服务器名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 595;
            // 
            // labelTimeout
            // 
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Location = new System.Drawing.Point(13, 42);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(64, 13);
            this.labelTimeout.TabIndex = 3;
            this.labelTimeout.Text = "Ping超时：";
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(12, 59);
            this.textBoxTimeout.MaxLength = 6;
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(75, 20);
            this.textBoxTimeout.TabIndex = 4;
            this.textBoxTimeout.Text = "500";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(12, 86);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(0, 13);
            this.labelState.TabIndex = 5;
            // 
            // LinkFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 590);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxTimeout);
            this.Controls.Add(this.labelTimeout);
            this.Controls.Add(this.dataGridViewIP);
            this.Controls.Add(this.buttonFetchIP);
            this.Controls.Add(this.webBrowserGreen);
            this.Name = "LinkFetcher";
            this.Text = "Green网络加速器链路测试";
            this.Activated += new System.EventHandler(this.LinkFetcher_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGreen;
        private System.Windows.Forms.Button buttonFetchIP;
        private System.Windows.Forms.DataGridView dataGridViewIP;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    }
}

