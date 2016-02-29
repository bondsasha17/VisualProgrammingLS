using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace HtmlExtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            string WayToTheFile ;
            OpenFileDialog ofd = new OpenFileDialog();
           if  (ofd.ShowDialog()== DialogResult.OK)
           {
               WayToTheFile = ofd.FileName;
               StreamReader sr = new StreamReader(WayToTheFile);
               string FileText = sr.ReadToEnd();
               StringBuilder sb = new StringBuilder(FileText);
               int startHead = FileText.IndexOf("<head>") + 6;
               int endHead = FileText.IndexOf("</head>");
               string head = FileText.Substring(startHead, endHead - startHead);
               MessageBox.Show(head);
           }

       
        }

      
    }
}
