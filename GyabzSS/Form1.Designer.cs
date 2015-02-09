namespace GyabzSS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnScreenCap = new System.Windows.Forms.Button();
            this.btnAreaCap = new System.Windows.Forms.Button();
            this.ntfyGyabz = new System.Windows.Forms.NotifyIcon(this.components);
            this.ntfyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.captureScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScreenCap
            // 
            this.btnScreenCap.Location = new System.Drawing.Point(12, 12);
            this.btnScreenCap.Name = "btnScreenCap";
            this.btnScreenCap.Size = new System.Drawing.Size(210, 48);
            this.btnScreenCap.TabIndex = 0;
            this.btnScreenCap.Text = "Capture Screen";
            this.btnScreenCap.UseVisualStyleBackColor = true;
            this.btnScreenCap.Click += new System.EventHandler(this.btnScreenCap_Click);
            // 
            // btnAreaCap
            // 
            this.btnAreaCap.Location = new System.Drawing.Point(12, 66);
            this.btnAreaCap.Name = "btnAreaCap";
            this.btnAreaCap.Size = new System.Drawing.Size(210, 58);
            this.btnAreaCap.TabIndex = 1;
            this.btnAreaCap.Text = "Capture Region";
            this.btnAreaCap.UseVisualStyleBackColor = true;
            this.btnAreaCap.Click += new System.EventHandler(this.btnAreaCap_Click);
            // 
            // ntfyGyabz
            // 
            this.ntfyGyabz.ContextMenuStrip = this.ntfyMenu;
            this.ntfyGyabz.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyGyabz.Icon")));
            this.ntfyGyabz.Text = "GyabzSS";
            this.ntfyGyabz.Visible = true;
            // 
            // ntfyMenu
            // 
            this.ntfyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureScreenToolStripMenuItem,
            this.captureRegionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ntfyMenu.Name = "ntfyMenu";
            this.ntfyMenu.Size = new System.Drawing.Size(157, 92);
            // 
            // captureScreenToolStripMenuItem
            // 
            this.captureScreenToolStripMenuItem.Name = "captureScreenToolStripMenuItem";
            this.captureScreenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.captureScreenToolStripMenuItem.Text = "Capture Screen";
            this.captureScreenToolStripMenuItem.Click += new System.EventHandler(this.captureScreenToolStripMenuItem_Click);
            // 
            // captureRegionToolStripMenuItem
            // 
            this.captureRegionToolStripMenuItem.Name = "captureRegionToolStripMenuItem";
            this.captureRegionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.captureRegionToolStripMenuItem.Text = "Capture Region";
            this.captureRegionToolStripMenuItem.Click += new System.EventHandler(this.captureRegionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 136);
            this.Controls.Add(this.btnAreaCap);
            this.Controls.Add(this.btnScreenCap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GyabzSS";
            this.ntfyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenCap;
        private System.Windows.Forms.Button btnAreaCap;
        private System.Windows.Forms.NotifyIcon ntfyGyabz;
        private System.Windows.Forms.ContextMenuStrip ntfyMenu;
        private System.Windows.Forms.ToolStripMenuItem captureScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

