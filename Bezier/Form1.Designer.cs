namespace Bezier
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
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.pictrueBox = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.trackBarValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictrueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictrueBox
            // 
            this.pictrueBox.Location = new System.Drawing.Point(0, 0);
            this.pictrueBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictrueBox.Name = "pictrueBox";
            this.pictrueBox.Size = new System.Drawing.Size(785, 563);
            this.pictrueBox.TabIndex = 0;
            this.pictrueBox.TabStop = false;
            this.pictrueBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar.Location = new System.Drawing.Point(314, 13);
            this.trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar.Minimum = 3;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(100, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 3;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_valueChanged);
            // 
            // trackBarValueLabel
            // 
            this.trackBarValueLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trackBarValueLabel.Location = new System.Drawing.Point(417, 13);
            this.trackBarValueLabel.Name = "trackBarValueLabel";
            this.trackBarValueLabel.Size = new System.Drawing.Size(29, 45);
            this.trackBarValueLabel.TabIndex = 2;
            this.trackBarValueLabel.Text = "10";
            this.trackBarValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(179, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "控制点的数量";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarValueLabel);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.pictrueBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictrueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictrueBox;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label trackBarValueLabel;
        private System.Windows.Forms.Label label1;
    }
}

