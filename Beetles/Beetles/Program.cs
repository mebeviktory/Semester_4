﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Beetles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //public static Form1 form;
        public static Form1 curForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            curForm = form;
            //Thread formThread = new Thread(new ParameterizedThreadStart());
            //formThread.Start();
            Application.Run(form);
            
        }
    }
}
