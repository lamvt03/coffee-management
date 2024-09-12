using CoffeeManagement.pdf;
using CoffeeManagement.qrCode;
using System;
using System.Windows.Forms;

using CoffeeManagement.management;

namespace CoffeeManagement
{
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
            Application.Run(new Login());
            //new PDFGenerator("invoice.xml").CreateDocument();
        }
    }
}
