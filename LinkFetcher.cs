using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace GreenLinkFetcher
{
    public partial class LinkFetcher : Form
    {
        public LinkFetcher()
        {
            InitializeComponent();
        }

        private void buttonFetchIP_Click(object sender, EventArgs e)
        {
            buttonFetchIP.Enabled = false;
            string strContent = webBrowserGreen.Document.Body.InnerHtml;
            Regex rgxParser = new Regex(@"<TR>\s*<TD.*?</TD>.*?<CENTER>(.*?)</CENTER>.*?<CENTER>(.*?)</CENTER>.*?</TR>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match mthLink = rgxParser.Match(strContent);
            mthLink = mthLink.NextMatch();
            Ping p = new Ping();
            int intTimeout = int.Parse(textBoxTimeout.Text);
            while (mthLink.Success)
            {
                try
                {
                    string strLinkName = mthLink.Groups[1].Value;
                    string strLinkIP = mthLink.Groups[2].Value;
                    long longLinkTime = 9999;
                    PingReply pReply = p.Send(strLinkIP, intTimeout);
                    if (pReply.Status == IPStatus.Success)
                    {
                        longLinkTime = pReply.RoundtripTime;
                    }
                    int intGridCount = dataGridViewIP.Rows.Count;
                    //if (intGridCount == 0)
                    //{
                    //    dataGridViewIP.Rows.Add(strLinkIP, longLinkTime, strLinkName);
                    //}
                    //else
                    //{
                    //    bool isLargest = true;
                    //    for (int i = 0; i < dataGridViewIP.Rows.Count; i++)
                    //    {
                    //        if ((long)dataGridViewIP.Rows[i].Cells[1].Value > longLinkTime)
                    //        {
                    //            dataGridViewIP.Rows.Insert(i, strLinkIP, longLinkTime, strLinkName);
                    //            isLargest = false;
                    //            break;
                    //        }
                    //    }
                    //    if (isLargest)
                    //    {
                    //        dataGridViewIP.Rows.Add(strLinkIP, longLinkTime, strLinkName);
                    //    }
                    //}
                    dataGridViewIP.Rows.Add(strLinkIP, longLinkTime, strLinkName);
                    mthLink = mthLink.NextMatch();
                    labelState.Text = strLinkIP + "\r\n" + longLinkTime.ToString();
                    this.Refresh();
                }
                catch(Exception ex)
                {
                    using (StreamWriter swLog = new StreamWriter("debug.log",true, Encoding.UTF8))
                    {
                        swLog.Write(ex.Message + "\r\n");
                    }
                }
            }
            dataGridViewIP.Sort(ColumnPing, ListSortDirection.Ascending);
            buttonFetchIP.Enabled = true;
            labelState.Text = "";
        }

        private void webBrowserGreen_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Equals(webBrowserGreen.Url))
            {
                if (webBrowserGreen.Url.ToString().ToLower() == "https://www.grjsq.biz/user-xianlu.html")
                {
                    webBrowserGreen.Document.Window.ScrollTo(0, 400);
                    buttonFetchIP.Enabled = true;
                }
                else
                {
                    webBrowserGreen.Navigate("https://www.grjsq.biz/user-xianlu.html");
                    buttonFetchIP.Enabled = false;
                }
            }
        }

        private void LinkFetcher_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }
    }
}
