namespace CtoJApp
{
    partial class CtoJ
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.selectSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.selectSource = new System.Windows.Forms.Button();
            this.readSourcePanel = new System.Windows.Forms.Panel();
            this.convertbtn = new System.Windows.Forms.Button();
            this.viewCodebtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.readSourcePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(355, 465);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // selectSourceFile
            // 
            this.selectSourceFile.FileName = "selectSourceFile";
            this.selectSourceFile.FileOk += new System.ComponentModel.CancelEventHandler(this.selectSourceFile_FileOk);
            // 
            // selectSource
            // 
            this.selectSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.selectSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSource.ForeColor = System.Drawing.Color.White;
            this.selectSource.Location = new System.Drawing.Point(15, 14);
            this.selectSource.Name = "selectSource";
            this.selectSource.Size = new System.Drawing.Size(360, 30);
            this.selectSource.TabIndex = 1;
            this.selectSource.Text = "Select Source File";
            this.selectSource.UseVisualStyleBackColor = false;
            this.selectSource.Click += new System.EventHandler(this.selectSource_Click);
            // 
            // readSourcePanel
            // 
            this.readSourcePanel.BackColor = System.Drawing.Color.Transparent;
            this.readSourcePanel.Controls.Add(this.convertbtn);
            this.readSourcePanel.Controls.Add(this.viewCodebtn);
            this.readSourcePanel.Controls.Add(this.selectSource);
            this.readSourcePanel.Location = new System.Drawing.Point(31, 101);
            this.readSourcePanel.Name = "readSourcePanel";
            this.readSourcePanel.Size = new System.Drawing.Size(388, 116);
            this.readSourcePanel.TabIndex = 2;
            // 
            // convertbtn
            // 
            this.convertbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.convertbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.convertbtn.Enabled = false;
            this.convertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertbtn.ForeColor = System.Drawing.Color.White;
            this.convertbtn.Location = new System.Drawing.Point(207, 62);
            this.convertbtn.Name = "convertbtn";
            this.convertbtn.Size = new System.Drawing.Size(168, 30);
            this.convertbtn.TabIndex = 3;
            this.convertbtn.Text = "Convert";
            this.convertbtn.UseVisualStyleBackColor = false;
            this.convertbtn.Click += new System.EventHandler(this.convertbtn_Click);
            // 
            // viewCodebtn
            // 
            this.viewCodebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.viewCodebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewCodebtn.Enabled = false;
            this.viewCodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCodebtn.ForeColor = System.Drawing.Color.White;
            this.viewCodebtn.Location = new System.Drawing.Point(15, 62);
            this.viewCodebtn.Name = "viewCodebtn";
            this.viewCodebtn.Size = new System.Drawing.Size(168, 30);
            this.viewCodebtn.TabIndex = 2;
            this.viewCodebtn.Text = "View Code";
            this.viewCodebtn.UseVisualStyleBackColor = false;
            this.viewCodebtn.Click += new System.EventHandler(this.viewCodebtn_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.Red;
            this.msg.Location = new System.Drawing.Point(14, 471);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(45, 16);
            this.msg.TabIndex = 3;
            this.msg.Text = "label1";
            this.msg.Visible = false;
            this.msg.Click += new System.EventHandler(this.msg_Click);
            // 
            // CtoJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CtoJApp.Properties.Resources.CC;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.readSourcePanel);
            this.Controls.Add(this.exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CtoJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CtoJ";
            this.readSourcePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.OpenFileDialog selectSourceFile;
        private System.Windows.Forms.Button selectSource;
        private System.Windows.Forms.Panel readSourcePanel;
        private System.Windows.Forms.Button convertbtn;
        private System.Windows.Forms.Button viewCodebtn;
        public System.Windows.Forms.Label msg;
    }
}

