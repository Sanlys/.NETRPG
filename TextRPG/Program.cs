using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRPG
{
    
    public class Program
    {
        public static Form1 _Form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static Form1 formInstance;
        
        [STAThread]
        
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}