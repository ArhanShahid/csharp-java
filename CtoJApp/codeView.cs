using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CtoJApp
{
    public partial class codeView : Form
    {
        CtoJConverter CtoJObj;
       
        public codeView(bool isEnable,string sourceFile)
        {
            InitializeComponent();
            CtoJObj = new CtoJConverter();
            savebtn.Visible = isEnable;
            copytoclipboard.Visible = isEnable;
            richTextBox1.ReadOnly = !isEnable;
            richTextBox1.Text = sourceFile;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
             string resultFile = richTextBox1.Text;
             CtoJObj.saveFile(resultFile);
             msgcode.ForeColor = System.Drawing.Color.Green;
             msgcode.Text = "File Saved";
             msgcode.Visible = true;

             Application.DoEvents();
             Thread.Sleep(3000);

             msgcode.Visible = false;
             msgcode.Text = "";
             msgcode.ForeColor = System.Drawing.Color.Black;   
        }

        private void copytoclipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            msgcode.ForeColor = System.Drawing.Color.Green;
            msgcode.Text = "Code Copy To Clipboard";
            msgcode.Visible = true;

            Application.DoEvents();
            Thread.Sleep(3000);

            msgcode.Visible = false;
            msgcode.Text = "";
            msgcode.ForeColor = System.Drawing.Color.Black;  
        }

       

       
    }
}
