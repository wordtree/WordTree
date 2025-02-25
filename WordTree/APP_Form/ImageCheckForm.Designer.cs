﻿
namespace APP_Form
{
    partial class ImageCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageCheckForm));
            this.lblWordStr = new System.Windows.Forms.Label();
            this.picTrueWord = new System.Windows.Forms.PictureBox();
            this.flp_Pictures = new System.Windows.Forms.FlowLayoutPanel();
            this.picFalseWord1 = new System.Windows.Forms.PictureBox();
            this.picFalseWord2 = new System.Windows.Forms.PictureBox();
            this.picFalseWord3 = new System.Windows.Forms.PictureBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picTrueWord)).BeginInit();
            this.flp_Pictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordStr
            // 
            this.lblWordStr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordStr.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblWordStr.Location = new System.Drawing.Point(4, 9);
            this.lblWordStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordStr.Name = "lblWordStr";
            this.lblWordStr.Size = new System.Drawing.Size(808, 84);
            this.lblWordStr.TabIndex = 0;
            this.lblWordStr.Text = "Word";
            this.lblWordStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTrueWord
            // 
            this.picTrueWord.BackColor = System.Drawing.Color.Gray;
            this.picTrueWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTrueWord.Location = new System.Drawing.Point(4, 4);
            this.picTrueWord.Margin = new System.Windows.Forms.Padding(4);
            this.picTrueWord.Name = "picTrueWord";
            this.picTrueWord.Size = new System.Drawing.Size(400, 174);
            this.picTrueWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrueWord.TabIndex = 1;
            this.picTrueWord.TabStop = false;
            this.picTrueWord.Click += new System.EventHandler(this.picTrueWord_Click);
            // 
            // flp_Pictures
            // 
            this.flp_Pictures.BackColor = System.Drawing.Color.White;
            this.flp_Pictures.Controls.Add(this.picTrueWord);
            this.flp_Pictures.Controls.Add(this.picFalseWord1);
            this.flp_Pictures.Controls.Add(this.picFalseWord2);
            this.flp_Pictures.Controls.Add(this.picFalseWord3);
            this.flp_Pictures.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_Pictures.Location = new System.Drawing.Point(0, 99);
            this.flp_Pictures.Margin = new System.Windows.Forms.Padding(4);
            this.flp_Pictures.Name = "flp_Pictures";
            this.flp_Pictures.Size = new System.Drawing.Size(817, 369);
            this.flp_Pictures.TabIndex = 2;
            // 
            // picFalseWord1
            // 
            this.picFalseWord1.BackColor = System.Drawing.Color.Gray;
            this.picFalseWord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFalseWord1.Location = new System.Drawing.Point(412, 4);
            this.picFalseWord1.Margin = new System.Windows.Forms.Padding(4);
            this.picFalseWord1.Name = "picFalseWord1";
            this.picFalseWord1.Size = new System.Drawing.Size(400, 174);
            this.picFalseWord1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFalseWord1.TabIndex = 2;
            this.picFalseWord1.TabStop = false;
            this.picFalseWord1.Click += new System.EventHandler(this.picFalseWord1_Click);
            // 
            // picFalseWord2
            // 
            this.picFalseWord2.BackColor = System.Drawing.Color.Gray;
            this.picFalseWord2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFalseWord2.Location = new System.Drawing.Point(4, 186);
            this.picFalseWord2.Margin = new System.Windows.Forms.Padding(4);
            this.picFalseWord2.Name = "picFalseWord2";
            this.picFalseWord2.Size = new System.Drawing.Size(400, 174);
            this.picFalseWord2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFalseWord2.TabIndex = 3;
            this.picFalseWord2.TabStop = false;
            this.picFalseWord2.Click += new System.EventHandler(this.picFalseWord2_Click);
            // 
            // picFalseWord3
            // 
            this.picFalseWord3.BackColor = System.Drawing.Color.Gray;
            this.picFalseWord3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFalseWord3.Location = new System.Drawing.Point(412, 186);
            this.picFalseWord3.Margin = new System.Windows.Forms.Padding(4);
            this.picFalseWord3.Name = "picFalseWord3";
            this.picFalseWord3.Size = new System.Drawing.Size(400, 174);
            this.picFalseWord3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFalseWord3.TabIndex = 4;
            this.picFalseWord3.TabStop = false;
            this.picFalseWord3.Click += new System.EventHandler(this.picFalseWord3_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(697, 51);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 3;
            this.mediaPlayer.Visible = false;
            // 
            // ImageCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.flp_Pictures);
            this.Controls.Add(this.lblWordStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageCheckForm";
            this.Text = "ImageCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.picTrueWord)).EndInit();
            this.flp_Pictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFalseWord3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWordStr;
        private System.Windows.Forms.PictureBox picTrueWord;
        private System.Windows.Forms.FlowLayoutPanel flp_Pictures;
        private System.Windows.Forms.PictureBox picFalseWord1;
        private System.Windows.Forms.PictureBox picFalseWord2;
        private System.Windows.Forms.PictureBox picFalseWord3;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}