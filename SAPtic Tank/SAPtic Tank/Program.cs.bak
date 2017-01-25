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
           // try
           // {
           //     string[] file = read();
           //     string path = file[0];
           //     string contents = file[1];

          //      Assembler.assemble(contents);
            //    string output = Assembler.getRAM();

//                print(path, output);
   //             Console.Write("Assembling Complete");
     ////           Console.ReadLine();

                //Emulator emu = new Emulator();
         //   }
           // catch(ArgumentException e)
           // {
           //     Console.WriteLine(e.Message);
           //     Console.ReadKey();
           // }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }

        /// <summary>
        /// Let us choose which file are we going to assemble then loads it to our assembler
        /// </summary>
        /// <returns>File contents in string format</returns>
        private static string[] read()
        {
            string[] FILE = new string[2];

            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "SAPtic Tank - Open File";
            open_file.Filter = "SAP1 Files (*.sap1)|*.sap1";
            

            DialogResult result = open_file.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open_file.FileName;
                FILE[0] = @file.Substring(0, file.Length - 5)+".bin";

                try
                {
                    FILE[1] = File.ReadAllText(file);
                }
                catch
                {
                    MessageBox.Show("Cannot open File 😐");
                }
            }

            return FILE;
        }
        private static void print(string address, string content )
        {
            try
            {
                if (File.Exists(address))
                {
                    StreamWriter sw = new StreamWriter(address, false);
                    sw.Write(content);
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = File.CreateText(address);
                    sw.Write(content);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
