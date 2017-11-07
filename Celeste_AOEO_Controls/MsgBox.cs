﻿#region Using directives

using System;
using System.Windows.Forms;

#endregion

namespace Celeste_AOEO_Controls
{
    public partial class MsgBox : Form
    {
        public MsgBox(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        public static void ShowMessage(string message)
        {
            using (var frm = new MsgBox(message))
            {
                frm.ShowDialog();
            }
        }

        public static void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            ShowMessage(message);
        }

        private void Lb_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}