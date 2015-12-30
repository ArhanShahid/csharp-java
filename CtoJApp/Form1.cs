using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CtoJApp
{
    public partial class CtoJ : Form
    {
        CtoJConverter CtoJObj;

        public CtoJ()
        {
            InitializeComponent();
            CtoJObj = new CtoJConverter();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectSource_Click(object sender, EventArgs e)
        {
            DialogResult sourceFilePath = selectSourceFile.ShowDialog();
            if (sourceFilePath == DialogResult.OK)
            {
                string file = selectSourceFile.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    CtoJObj.setSourceFile(text);
                    viewCodebtn.Enabled = true;
                    convertbtn.Enabled = true;
                    msg.ForeColor = System.Drawing.Color.Green;
                    msg.Text = "Source File Selected";
                    msg.Visible = true;

                    Application.DoEvents();
                    Thread.Sleep(3000);

                    msg.Visible = false;
                    msg.Text = "";
                    msg.ForeColor = System.Drawing.Color.Black;   
                }
                catch (IOException ex)
                {
                    msg.ForeColor = System.Drawing.Color.Red;
                    msg.Text = ex.ToString();
                    msg.Visible = true;

                    Application.DoEvents();
                    Thread.Sleep(3000);

                    msg.Visible = false;
                    msg.Text = "";
                    msg.ForeColor = System.Drawing.Color.Black;              
                }
               
            }
            else
            {
              
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "Invalid File Selection";
                msg.Visible = true;

                Application.DoEvents();
                Thread.Sleep(3000);

                msg.Visible = false;
                msg.Text = "";
                msg.ForeColor = System.Drawing.Color.Black;              
            }
           
        }

        private void selectSourceFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void viewCodebtn_Click(object sender, EventArgs e)
        {
            string sourceFile = CtoJObj.getSourceFile();
            codeView cv = new codeView(false,sourceFile);
            cv.Show();
        }

        private void convertbtn_Click(object sender, EventArgs e)
        {

            string sourceFile = CtoJObj.getSourceFile();
            Dictionary<string, string> rulesDictionary = CtoJObj.readRulesFile();
            CtoJObj.convertPassOne(sourceFile, rulesDictionary);
            string resultFile = CtoJObj.getResultFile();

            codeView cv = new codeView(true, resultFile);
            cv.Show();
            
            msg.ForeColor = System.Drawing.Color.Green;
            msg.Text = "Code Converted";
            msg.Visible = true;

            Application.DoEvents();
            Thread.Sleep(3000);

            msg.Visible = false;
            msg.Text = "";
            msg.ForeColor = System.Drawing.Color.Black;   
            
        }

        private void msg_Click(object sender, EventArgs e)
        {

        }

       

    }
}
