namespace GestureRadarDemoV3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroProgressBarZ = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelZ = new MetroFramework.Controls.MetroLabel();
            this.picBoxYZ = new System.Windows.Forms.PictureBox();
            this.picBoxXY = new System.Windows.Forms.PictureBox();
            this.metroTextBoxMsg = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXY)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressBarZ
            // 
            this.metroProgressBarZ.Location = new System.Drawing.Point(25, 792);
            this.metroProgressBarZ.Maximum = 255;
            this.metroProgressBarZ.Name = "metroProgressBarZ";
            this.metroProgressBarZ.Size = new System.Drawing.Size(711, 40);
            this.metroProgressBarZ.TabIndex = 2;
            // 
            // metroLabelZ
            // 
            this.metroLabelZ.AutoSize = true;
            this.metroLabelZ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelZ.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelZ.Location = new System.Drawing.Point(819, 792);
            this.metroLabelZ.Name = "metroLabelZ";
            this.metroLabelZ.Size = new System.Drawing.Size(23, 25);
            this.metroLabelZ.TabIndex = 3;
            this.metroLabelZ.Text = "0";
            // 
            // picBoxYZ
            // 
            this.picBoxYZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picBoxYZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxYZ.Location = new System.Drawing.Point(507, 1148);
            this.picBoxYZ.Name = "picBoxYZ";
            this.picBoxYZ.Size = new System.Drawing.Size(38, 0);
            this.picBoxYZ.TabIndex = 1;
            this.picBoxYZ.TabStop = false;
            this.picBoxYZ.Visible = false;
            // 
            // picBoxXY
            // 
            this.picBoxXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxXY.Location = new System.Drawing.Point(25, 98);
            this.picBoxXY.Name = "picBoxXY";
            this.picBoxXY.Size = new System.Drawing.Size(867, 653);
            this.picBoxXY.TabIndex = 0;
            this.picBoxXY.TabStop = false;
            this.picBoxXY.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxXY_Paint);
            // 
            // metroTextBoxMsg
            // 
            this.metroTextBoxMsg.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxMsg.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBoxMsg.Location = new System.Drawing.Point(924, 98);
            this.metroTextBoxMsg.Multiline = true;
            this.metroTextBoxMsg.Name = "metroTextBoxMsg";
            this.metroTextBoxMsg.Size = new System.Drawing.Size(286, 653);
            this.metroTextBoxMsg.TabIndex = 5;
            this.metroTextBoxMsg.Text = "Lrng";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(924, 792);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(286, 40);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Send";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 862);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBoxMsg);
            this.Controls.Add(this.metroLabelZ);
            this.Controls.Add(this.metroProgressBarZ);
            this.Controls.Add(this.picBoxYZ);
            this.Controls.Add(this.picBoxXY);
            this.Name = "Form1";
            this.Text = "GestureRadarDemoV3.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxXY;
        private System.Windows.Forms.PictureBox picBoxYZ;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarZ;
        private MetroFramework.Controls.MetroLabel metroLabelZ;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMsg;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

