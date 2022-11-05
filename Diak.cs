using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Karesz
{
    public partial class Form1 : Form
    {
        void DIÁK_ROBOTJAI()
        {
            Robot karesz = Robot.Get("Karesz");

            karesz.Feladat = delegate ()
            {
                // ide írd az algoritmust!
            };
        }
    }
}

/* LEGFONTOSABB PARANCSOK

MOZGÁSOK

Lépj();                          -------- Karesz előre lép egyet.
Fordulj(jobbra);                 -------- Karesz jobbra fordul.
Fordulj(balra);                  -------- Karesz balra fordul.
Vegyél_fel_egy_kavicsot();       -------- Karesz felvesz egy kavicsot.
Tegyél_le_egy_kavicsot();        -------- Karesz letesz egy fekete kavicsot

*/