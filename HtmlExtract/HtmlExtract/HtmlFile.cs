﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;



namespace HtmlExtract
{
    public class HtmlFile
    {
        public string filePath;

        public enum Tag { head, title, body, a, p, html};
        
        public HtmlFile ( string filePath)
        {
            this.filePath = filePath;
        }
        
        public string Extract(Tag tag)
        {
            StreamReader sr = new StreamReader(filePath);
            string FileText = sr.ReadToEnd();

            string tagName = Enum.GetName(typeof(Tag), tag);

            string tagText = FileText.Substring(FileText.IndexOf("<" + tagName) + tagName.Length + 1);
            tagText = tagText.Substring(tagText.IndexOf(">") + 1, tagText.IndexOf("</" + tagName) - 1);

      

            while (tagText.IndexOf("<") != -1)
            {
                int startdeletTag = tagText.IndexOf("<");
                int enddeletTag = tagText.IndexOf(">");
                tagText = tagText.Remove(startdeletTag, enddeletTag - startdeletTag + 1);
            }

            return tagText;
        }


    }
}
