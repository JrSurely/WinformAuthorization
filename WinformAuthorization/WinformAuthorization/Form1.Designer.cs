namespace WinformAuthorization
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.GetFilesBtn = new System.Windows.Forms.Button();
            this.skinDataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddTxtBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GetHtmlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(801, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "user";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(381, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(842, 558);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(892, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "admin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(994, 15);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(75, 23);
            this.DownloadBtn.TabIndex = 6;
            this.DownloadBtn.Text = "下载";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // GetFilesBtn
            // 
            this.GetFilesBtn.Location = new System.Drawing.Point(1105, 16);
            this.GetFilesBtn.Name = "GetFilesBtn";
            this.GetFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.GetFilesBtn.TabIndex = 7;
            this.GetFilesBtn.Text = "获取目录";
            this.GetFilesBtn.UseVisualStyleBackColor = true;
            this.GetFilesBtn.Click += new System.EventHandler(this.GetFilesBtn_Click);
            // 
            // skinDataGridView2
            // 
            this.skinDataGridView2.AllowUserToAddRows = false;
            this.skinDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skinDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.skinDataGridView2.Name = "skinDataGridView2";
            this.skinDataGridView2.ReadOnly = true;
            this.skinDataGridView2.RowTemplate.Height = 23;
            this.skinDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView2.Size = new System.Drawing.Size(375, 558);
            this.skinDataGridView2.TabIndex = 8;
            this.skinDataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skinDataGridView2_CellDoubleClick);
            this.skinDataGridView2.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.skinDataGridView2_MouseUp);
            this.skinDataGridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skinDataGridView2_MouseUp);
            // 
            // AddTxtBtn
            // 
            this.AddTxtBtn.Location = new System.Drawing.Point(12, 16);
            this.AddTxtBtn.Name = "AddTxtBtn";
            this.AddTxtBtn.Size = new System.Drawing.Size(90, 23);
            this.AddTxtBtn.TabIndex = 9;
            this.AddTxtBtn.Text = "添加txt文件";
            this.AddTxtBtn.UseVisualStyleBackColor = true;
            this.AddTxtBtn.Click += new System.EventHandler(this.AddTxtBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(108, 16);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(69, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "删除";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.skinDataGridView2);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 559);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GetHtmlBtn);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.AddTxtBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.GetFilesBtn);
            this.panel2.Controls.Add(this.DownloadBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 52);
            this.panel2.TabIndex = 12;
            // 
            // GetHtmlBtn
            // 
            this.GetHtmlBtn.Location = new System.Drawing.Point(200, 15);
            this.GetHtmlBtn.Name = "GetHtmlBtn";
            this.GetHtmlBtn.Size = new System.Drawing.Size(75, 23);
            this.GetHtmlBtn.TabIndex = 11;
            this.GetHtmlBtn.Text = "获取html";
            this.GetHtmlBtn.UseVisualStyleBackColor = true;
            this.GetHtmlBtn.Click += new System.EventHandler(this.GetHtmlBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button GetFilesBtn;
        private System.Windows.Forms.DataGridView skinDataGridView2;
        private System.Windows.Forms.Button AddTxtBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GetHtmlBtn;
    }
}

