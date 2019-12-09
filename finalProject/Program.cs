using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{

    /* Bass Guitar
     * WinForms App
     * This application allows the user to play a bass guitar with the keyboard or mouse
     * Jordan Hunt
     * Date Created 20 November 2019
     * Date Revised 8 December 2019
     */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            Application.Run(new Form1());
            Application.Run(new Form3());
        }
    }
}
