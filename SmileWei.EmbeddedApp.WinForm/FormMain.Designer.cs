namespace SmileWei.EmbeddedApp.WinForm
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowseApp = new System.Windows.Forms.Button();
            this.txtAppFilename = new System.Windows.Forms.TextBox();
            this.openApp = new System.Windows.Forms.OpenFileDialog();
            this.appBox = new SmileWei.EmbeddedApp.AppContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseApp
            // 
            this.btnBrowseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseApp.Location = new System.Drawing.Point(515, 3);
            this.btnBrowseApp.Name = "btnBrowseApp";
            this.btnBrowseApp.Size = new System.Drawing.Size(65, 23);
            this.btnBrowseApp.TabIndex = 1;
            this.btnBrowseApp.Text = "浏览...";
            this.btnBrowseApp.UseVisualStyleBackColor = true;
            this.btnBrowseApp.Click += new System.EventHandler(this.btnBrowseApp_Click);
            // 
            // txtAppFilename
            // 
            this.txtAppFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppFilename.Location = new System.Drawing.Point(5, 5);
            this.txtAppFilename.Name = "txtAppFilename";
            this.txtAppFilename.ReadOnly = true;
            this.txtAppFilename.Size = new System.Drawing.Size(506, 21);
            this.txtAppFilename.TabIndex = 2;
            // 
            // openApp
            // 
            this.openApp.Filter = "可执行程序 (*.exe)|*.exe";
            // 
            // appBox
            // 
            this.appBox.AppFilename = "";
            this.appBox.AppProcess = null;
            this.appBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appBox.Location = new System.Drawing.Point(0, 32);
            this.appBox.Name = "appBox";
            this.appBox.ShowEmbedResult = false;
            this.appBox.Size = new System.Drawing.Size(583, 422);
            this.appBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAppFilename);
            this.panel1.Controls.Add(this.btnBrowseApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 32);
            this.panel1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 454);
            this.Controls.Add(this.appBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内嵌程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppContainer appBox;
        private System.Windows.Forms.Button btnBrowseApp;
        private System.Windows.Forms.TextBox txtAppFilename;
        private System.Windows.Forms.OpenFileDialog openApp;
        private System.Windows.Forms.Panel panel1;
    }
}

