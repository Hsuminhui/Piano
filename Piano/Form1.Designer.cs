namespace Piano
{
    partial class frmBeepPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.palMain = new System.Windows.Forms.Panel();
            this.song = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.label1);
            this.palMain.Controls.Add(this.pictureBox1);
            this.palMain.Controls.Add(this.lbl);
            this.palMain.Controls.Add(this.song);
            this.palMain.Controls.Add(this.play);
            this.palMain.Controls.Add(this.Record);
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(0, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(872, 936);
            this.palMain.TabIndex = 0;
            // 
            // song
            // 
            this.song.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.song.Location = new System.Drawing.Point(540, 213);
            this.song.Name = "song";
            this.song.Size = new System.Drawing.Size(102, 45);
            this.song.TabIndex = 10;
            this.song.Text = "小星星";
            this.song.UseVisualStyleBackColor = true;
            this.song.Click += new System.EventHandler(this.song_Click);
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.play.Location = new System.Drawing.Point(387, 213);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(103, 45);
            this.play.TabIndex = 9;
            this.play.Text = "播放";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Record
            // 
            this.Record.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Record.Location = new System.Drawing.Point(220, 213);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(120, 45);
            this.Record.TabIndex = 8;
            this.Record.Text = "開始錄音";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.Location = new System.Drawing.Point(742, 26);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 94);
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "7";
            this.btn8.Text = "Do";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(641, 26);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 94);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "6";
            this.btn7.Text = "Si";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(544, 26);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 94);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "5";
            this.btn6.Text = "La";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(446, 26);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 94);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "4";
            this.btn5.Text = "Sol";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(351, 26);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 94);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "3";
            this.btn4.Text = "Fa";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(253, 26);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 94);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "2";
            this.btn3.Text = "Mi";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(158, 26);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 94);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "1";
            this.btn2.Text = "Re";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(64, 26);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 94);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "0";
            this.btn1.Text = "Do";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl.Location = new System.Drawing.Point(289, 327);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(305, 37);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "歡迎使用簡易電子琴!!";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Piano.Properties.Resources.piano;
            this.pictureBox1.Location = new System.Drawing.Point(0, 656);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 199);
            this.label1.TabIndex = 13;
            this.label1.Text = "MUSIC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBeepPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(872, 936);
            this.Controls.Add(this.palMain);
            this.Name = "frmBeepPlayer";
            this.Text = "簡易電子琴";
            this.palMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button song;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

