using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingHandson
{
    internal class Redtextf
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Training\DotNetTraining\file.txt", FileMode.Create, FileAccess.Write);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
        }

        public void ReadFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Training\DotNetTraining\file.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\tStatus\tNetwork");

            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] dateNTimeArr = line.Split(' ');
                        string[] dateArr = dateNTimeArr[0].Split(':');
                        Console.Write(dateArr[1] + "\t");
                        Console.Write(dateNTimeArr[1] + "\t");
                    }
                    else
                    {
                        string[] myValues = line.Split(':');
                        if (myValues[0] == "Network")
                        {
                            Console.WriteLine(myValues[1] + "\t  ");
                        }
                        else
                        {
                            Console.Write(myValues[1] + "\t");
                        }
                    }
                }
            }

        }
    }
}
