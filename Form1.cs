﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Karesz
{
    public partial class Form1 : Form
    {
        void FELADAT()
        {
            Robot Karesz = new Robot("Karesz", new int[] { 100, 20, 20, 20, 10 }, this);

            for (int i = 0; i < 10; i++)
            {
                Karesz.Lép();
            }
        }

        private void pályatextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pályagomb.PerformClick();
        }
    }
}