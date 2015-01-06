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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnScreenCap = new System.Windows.Forms.Button();
            this.btnAreaCap = new System.Windows.Forms.Button();
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
            this.btnAreaCap.Enabled = false;
            this.btnAreaCap.Location = new System.Drawing.Point(12, 66);
            this.btnAreaCap.Name = "btnAreaCap";
            this.btnAreaCap.Size = new System.Drawing.Size(210, 58);
            this.btnAreaCap.TabIndex = 1;
            this.btnAreaCap.Text = "Capture Area";
            this.btnAreaCap.UseVisualStyleBackColor = true;
            this.btnAreaCap.Click += new System.EventHandler(this.btnAreaCap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 136);
            this.Controls.Add(this.btnAreaCap);
            this.Controls.Add(this.btnScreenCap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GyabzSS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenCap;
        private System.Windows.Forms.Button btnAreaCap;
    }
}

