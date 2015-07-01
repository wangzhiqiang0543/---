namespace AirLineDesighDemo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.airlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pichtureNodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.demo平行四边形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // airlineToolStripMenuItem
            // 
            this.airlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demo2ToolStripMenuItem,
            this.demo平行四边形ToolStripMenuItem,
            this.demo1ToolStripMenuItem,
            this.pichtureNodingToolStripMenuItem});
            this.airlineToolStripMenuItem.Name = "airlineToolStripMenuItem";
            this.airlineToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.airlineToolStripMenuItem.Text = "airline";
            // 
            // demo2ToolStripMenuItem
            // 
            this.demo2ToolStripMenuItem.Name = "demo2ToolStripMenuItem";
            this.demo2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.demo2ToolStripMenuItem.Text = "demo-矩形";
            this.demo2ToolStripMenuItem.Click += new System.EventHandler(this.demo2ToolStripMenuItem_Click);
            // 
            // demo1ToolStripMenuItem
            // 
            this.demo1ToolStripMenuItem.Name = "demo1ToolStripMenuItem";
            this.demo1ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.demo1ToolStripMenuItem.Text = "demo-线";
            this.demo1ToolStripMenuItem.Click += new System.EventHandler(this.demo1ToolStripMenuItem_Click);
            // 
            // pichtureNodingToolStripMenuItem
            // 
            this.pichtureNodingToolStripMenuItem.Name = "pichtureNodingToolStripMenuItem";
            this.pichtureNodingToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pichtureNodingToolStripMenuItem.Text = "Pichture Noding";
            this.pichtureNodingToolStripMenuItem.Click += new System.EventHandler(this.pichtureNodingToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 237);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // demo平行四边形ToolStripMenuItem
            // 
            this.demo平行四边形ToolStripMenuItem.Name = "demo平行四边形ToolStripMenuItem";
            this.demo平行四边形ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.demo平行四边形ToolStripMenuItem.Text = "demo-平行四边形";
            this.demo平行四边形ToolStripMenuItem.Click += new System.EventHandler(this.demo平行四边形ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem airlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demo2ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem pichtureNodingToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem demo平行四边形ToolStripMenuItem;
    }
}

