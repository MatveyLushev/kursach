using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursavaya_poject
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form1 Forma = new Form1();
            Application.Run(Forma);
            return;
        }
    }
}
