using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlExtract
{
    class HtmlFile
    {
       public string filePath;

       public enum tags { head, title, body, a, p, html};
        
        public HtmlFile ( string filePath)
        {
            this.filePath = filePath;

        }
        public void Extract(string tag)
        { 

        }


    }
}
