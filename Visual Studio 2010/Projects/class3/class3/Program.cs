using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
            String strCmdText;
            strCmdText = "/C echo /b abcd";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
