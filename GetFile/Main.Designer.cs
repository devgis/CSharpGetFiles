namespace GetFileList
{
    partial class Main
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
            this.btSelectPath = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btSaveFileList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelectPath
            // 
            this.btSelectPath.Location = new System.Drawing.Point(273, 24);
            this.btSelectPath.Name = "btSelectPath";
            this.btSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btSelectPath.TabIndex = 0;
            this.btSelectPath.Text = "选择文件夹";
            this.btSelectPath.UseVisualStyleBackColor = true;
            this.btSelectPath.Click += new System.EventHandler(this.btSelectPath_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(31, 25);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(236, 21);
            this.tbPath.TabIndex = 1;
            // 
            // btSaveFileList
            // 
            this.btSaveFileList.Location = new System.Drawing.Point(354, 24);
            this.btSaveFileList.Name = "btSaveFileList";
            this.btSaveFileList.Size = new System.Drawing.Size(75, 23);
            this.btSaveFileList.TabIndex = 2;
            this.btSaveFileList.Text = "保存";
            this.btSaveFileList.UseVisualStyleBackColor = true;
            this.btSaveFileList.Click += new System.EventHandler(this.btSaveFileList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 87);
            this.Controls.Add(this.btSaveFileList);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btSelectPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "获取文件列表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btSaveFileList;
    }
}

