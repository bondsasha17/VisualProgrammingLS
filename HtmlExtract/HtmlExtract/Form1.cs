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
            HtmlFile MyFile;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MyFile = new HtmlFile(ofd.FileName);
                string headText = MyFile.Extract(HtmlFile.Tag.head);
                string bodyText = MyFile.Extract(HtmlFile.Tag.body);

                label1.Text = headText + "\n" + bodyText;

            }
            
        }
    }
}