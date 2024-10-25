﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Test
{
    public partial class UnmanagedCodeExample : Form
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox(0, "Hello World", "Title", 0); // BAD
        }
    }
}