using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calc
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new frm_main());
        }
    }
}