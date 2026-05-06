using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class frmBeepPlayer : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };

        int initWidth = 0;
        int initHeight = 0;
        Dictionary<String, Rectangle> initcontrol = new Dictionary<string, Rectangle>();
        bool isRecording = false;
        List<int> recordNotes = new List<int>();

        public frmBeepPlayer()
        {
            InitializeComponent();
            InitializeButton();

            this.Load += frmBeepPlayer_Load;
            this.SizeChanged += frmBeepPlayer_SizeChanged;

        }

        private void frmBeepPlayer_Load(object sender, EventArgs e)
        {
            initWidth = this.palMain.Width;
            initHeight = this.palMain.Height;

            foreach (Control ctl in this.palMain.Controls)
            {
                initcontrol[ctl.Name] = new Rectangle(
                    ctl.Left,
                    ctl.Top,
                    ctl.Width,
                    ctl.Height
                );
            }
        }

        private void frmBeepPlayer_SizeChanged(object sender, EventArgs e)
        {
            if (initWidth == 0 || initHeight == 0) return;

            double ratioWidth = (double)this.palMain.Width / initWidth;
            double ratioHeight = (double)this.palMain.Height / initHeight;

            foreach(Control ctl in this.palMain.Controls)
            {
                if (!initcontrol.ContainsKey(ctl.Name)) continue;

                Rectangle rect = initcontrol[ctl.Name];

                ctl.Left = (int)(rect.Left * ratioWidth);
                ctl.Top = (int)(rect.Top * ratioHeight);
                ctl.Width = (int)(rect.Width * ratioWidth);
                ctl.Height = (int)(rect.Height * ratioHeight);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int index = Convert.ToInt32(btn.Tag);

            if (index < 0 || index >= freq.Length)
            {
                MessageBox.Show("按鈕的 TabIndex 設定錯誤。");
                return;
            }

            btn.Enabled = false;
            Beep(freq[index], 300);
            btn.Enabled = true;

            if (isRecording)
            {
                recordNotes.Add(index);
                lbl.Text = "正在錄音中...目前記錄 " + recordNotes.Count + " 個音";
            }
        }

        private void InitializeButton()
        {
            btn1.Click += btn1_Click;
            btn2.Click += btn1_Click;
            btn3.Click += btn1_Click;
            btn4.Click += btn1_Click;
            btn5.Click += btn1_Click;
            btn6.Click += btn1_Click;
            btn7.Click += btn1_Click;
            btn8.Click += btn1_Click;
        }

        private void Record_Click(object sender, EventArgs e)
        {

            if(isRecording == false)
            {
                recordNotes.Clear();
                isRecording = true;
                Record.Text = "停止錄音";
                lbl.Text = "正在錄音中...";
            }
            else
            {
                isRecording = false;
                Record.Text = "開始錄音";
                lbl.Text = "錄音停止";
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (recordNotes.Count == 0)
            {
                MessageBox.Show("目前沒有錄到任何音符。");
                return;
            }

            foreach (int index in recordNotes)
            {
                Beep(freq[index], 300);
            }
        }

        private void song_Click(object sender, EventArgs e)
        {
            // 小星星
            int[] song = {
                0, 0, 4, 4, 5, 5, 4,
                3, 3, 2, 2, 1, 1, 0,
                4, 4, 3, 3, 2, 2, 1,
                4, 4, 3, 3, 2, 2, 1,
                0, 0, 4, 4, 5, 5, 4,
                3, 3, 2, 2, 1, 1, 0
            };

            foreach (int index in song)
            {
                Beep(freq[index], 300);
            }
        }
    }
}
