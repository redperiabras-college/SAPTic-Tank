using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SAPtic_Tank
{
    class File
    {
        public string assembler_currAddress;
        public string bin_address;

        public File()
        {

        }

        public string assemblerReader()
        {
            string content = "";

            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "SAPtic Tank - Open File";
            open_file.Filter = "SAP1 Files (*.sap1)|*.sap1";


            DialogResult result = open_file.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open_file.FileName;
                assembler_currAddress = file;
                bin_address  =  @file.Substring(0, file.Length - 5) + ".bin";

                try
                {
                    content = System.IO.File.ReadAllText(file);
                }
                catch
                {
                    MessageBox.Show("Cannot open File 😐");
                }
            }

            return content;
        }

        public void clear()
        {
            assembler_currAddress = "";
            bin_address = "";
        }

        public string save(string content)
        {
            try
            {
                if (content.Equals("")){
                    return "File is empty";
                }
                else
                {
                    if (assembler_currAddress.Equals(""))
                    {
                        saveAs(content);
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(assembler_currAddress, false);
                        sw.Write(content);
                        sw.Flush();
                        sw.Close();
                    }
                }
                
                return "File Successfully Saved";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string saveAs(string content)
        {
            SaveFileDialog create_file = new SaveFileDialog();
            create_file.Title = "SAPtic Tank - Save As";
            create_file.Filter = "SAP1 Files (*.sap1)|*.sap1";


            DialogResult result = create_file.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = create_file.FileName;

                try
                {
                    if (System.IO.File.Exists(fileName))
                    {
                        return "File Already Exists!";
                    }
                    else
                    {
                        StreamWriter sw = System.IO.File.CreateText(fileName);
                        sw.Write(content);
                        sw.Flush();
                        sw.Close();

                        assembler_currAddress = fileName;
                        bin_address = @fileName.Substring(0, fileName.Length - 5) + ".bin";
                        return "File successfully saved";
                    }
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            else
                return "";
        }

        public string export(string content)
        {
            try
            {
                if (System.IO.File.Exists(bin_address))
                {
                    StreamWriter sw = System.IO.File.CreateText(bin_address);
                    sw.Write(content);
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new StreamWriter(bin_address, false);
                    sw.Write(content);
                    sw.Flush();
                    sw.Close();
                }
                
                return "File Successfully Saved";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


    }
}
