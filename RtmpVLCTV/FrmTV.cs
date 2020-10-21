using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RtmpVLCTV
{
    public partial class FrmTV : Form
    {
        public FrmTV()
        {
            InitializeComponent();
        }

        // install-package LibVLCSharp.WinForms
        // install-package VideoLAN.LibVLC.Windows
        Dictionary<string, string> dictChannel = new Dictionary<string, string>();
        Form frmSelChannel = new Form { Width = 750, Height = 300 };
        LibVLCSharp.Shared.LibVLC libvlc = null;
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var flow = new FlowLayoutPanel();
            frmSelChannel.Controls.Add(flow);
            frmSelChannel.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            frmSelChannel.StartPosition = FormStartPosition.CenterScreen;
            frmSelChannel.Text = "选台控制面板";
            flow.Dock = DockStyle.Fill;
            frmSelChannel.KeyPreview = true;
            frmSelChannel.KeyDown += FrmSelChannel_KeyDown;
            var fileName = Path.Combine(Application.StartupPath, "sys.json");
            var s = File.ReadAllText(fileName);
            JObject jo = (JObject)JsonConvert.DeserializeObject(s);
            var data = jo["data"] as JArray;
            foreach(JObject jitem in data)
            {
                var name = jitem["Name"].ToString();
                var url = jitem["URL"].ToString();
                if (!dictChannel.ContainsKey(name))
                {
                    dictChannel.Add(name, url);
                    var btn = new Button { Text = name, Tag = url };
                    btn.Click += SelectChannelButton_Click;
                    flow.Controls.Add(btn);
                }
            }
            LibVLCSharp.Shared.Core.Initialize();
            libvlc = new LibVLCSharp.Shared.LibVLC();
            videoView1.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libvlc);

            KeyPreview = true;
            KeyDown += FrmTV_KeyDown;
        }

        private void FrmTV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmSelChannel.Hide();
            }
            else if (e.KeyCode == Keys.F1)
            {
                menuSelectChannel.PerformClick();
            }
        }

        private void FrmSelChannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmSelChannel.Hide();
            }
        }

        public void NavToChannel(string channelName, string url)
        {
            Text = channelName;
            var media = new LibVLCSharp.Shared.Media(libvlc, new Uri(url));
            videoView1.MediaPlayer.Play(media);
        }

        private void SelectChannelButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var url = btn.Tag as string;
                if (url != string.Empty)
                {
                    NavToChannel(btn.Text, url);
                }
            }
        }

        private void menuSelectChannel_Click(object sender, EventArgs e)
        {
            frmSelChannel.Show();
        }
    }
}
