namespace CtoJApp
{
    partial class codeView
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
            this.closebtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.copytoclipboard = new System.Windows.Forms.Button();
            this.msgcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(613, 641);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 536);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(12, 641);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // copytoclipboard
            // 
            this.copytoclipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.copytoclipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.copytoclipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copytoclipboard.ForeColor = System.Drawing.Color.White;
            this.copytoclipboard.Location = new System.Drawing.Point(93, 641);
            this.copytoclipboard.Name = "copytoclipboard";
            this.copytoclipboard.Size = new System.Drawing.Size(125, 23);
            this.copytoclipboard.TabIndex = 4;
            this.copytoclipboard.Text = "Copy To Clipboard";
            this.copytoclipboard.UseVisualStyleBackColor = false;
            this.copytoclipboard.Click += new System.EventHandler(this.copytoclipboard_Click);
            // 
            // msgcode
            // 
            this.msgcode.AutoSize = true;
            this.msgcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgcode.ForeColor = System.Drawing.Color.Red;
            this.msgcode.Location = new System.Drawing.Point(225, 646);
            this.msgcode.Name = "msgcode";
            this.msgcode.Size = new System.Drawing.Size(45, 16);
            this.msgcode.TabIndex = 6;
            this.msgcode.Text = "label1";
            this.msgcode.Visible = false;
            // 
            // codeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::CtoJApp.Properties.Resources.CC_Code1;
            this.ClientSize = new System.Drawing.Size(700, 676);
            this.Controls.Add(this.msgcode);
            this.Controls.Add(this.copytoclipboard);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "codeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "codeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button copytoclipboard;
        public System.Windows.Forms.Label msgcode;
    }
}