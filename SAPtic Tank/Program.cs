using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPtic_Tank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* try
            {
                File file = new File();
                string contents = file.assemblerReader();

                Assembler ass = new Assembler();
                string output = ass.assemble(contents);

                file.export(output);
                Console.Write("Assembling Complete");
                Console.ReadLine();

                //Emulator emu = new Emulator();
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }*/
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
        
    }
}
