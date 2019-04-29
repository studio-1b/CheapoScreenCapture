namespace CheapoScreenCapture
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
            this.captureBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.framerateText = new System.Windows.Forms.TextBox();
            this.secondsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previewCaptureArea = new System.Windows.Forms.Button();
            this.xText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(29, 165);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(96, 33);
            this.captureBtn.TabIndex = 1;
            this.captureBtn.Text = "Capture";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            this.captureBtn.Move += new System.EventHandler(this.captureBtn_Move);
            this.captureBtn.Resize += new System.EventHandler(this.captureBtn_Resize);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(141, 165);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 33);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // framerateText
            // 
            this.framerateText.Location = new System.Drawing.Point(340, 168);
            this.framerateText.Name = "framerateText";
            this.framerateText.Size = new System.Drawing.Size(100, 26);
            this.framerateText.TabIndex = 4;
            this.framerateText.Text = "15";
            // 
            // secondsText
            // 
            this.secondsText.Location = new System.Drawing.Point(577, 165);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(100, 26);
            this.secondsText.TabIndex = 5;
            this.secondsText.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Capture for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "seconds";
            // 
            // previewCaptureArea
            // 
            this.previewCaptureArea.Location = new System.Drawing.Point(29, 65);
            this.previewCaptureArea.Name = "previewCaptureArea";
            this.previewCaptureArea.Size = new System.Drawing.Size(175, 32);
            this.previewCaptureArea.TabIndex = 9;
            this.previewCaptureArea.Text = "Show Capture Area";
            this.previewCaptureArea.UseVisualStyleBackColor = true;
            this.previewCaptureArea.Click += new System.EventHandler(this.previewCaptureArea_Click);
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(262, 65);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(72, 26);
            this.xText.TabIndex = 10;
            this.xText.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "x";
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(359, 65);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(81, 26);
            this.yText.TabIndex = 12;
            this.yText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "y";
            // 
            // wText
            // 
            this.wText.Location = new System.Drawing.Point(486, 65);
            this.wText.Name = "wText";
            this.wText.Size = new System.Drawing.Size(100, 26);
            this.wText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "w";
            // 
            // hText
            // 
            this.hText.Location = new System.Drawing.Point(628, 65);
            this.hText.Name = "hText";
            this.hText.Size = new System.Drawing.Size(100, 26);
            this.hText.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "h";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(29, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(716, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "create animated gif at [https://gifmaker.me/] or create mpeg4 by downloading [ffm" +
    "peg] at [ffmpeg,org]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 677);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.previewCaptureArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsText);
            this.Controls.Add(this.framerateText);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.captureBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox framerateText;
        private System.Windows.Forms.TextBox secondsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previewCaptureArea;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

