using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1st task assign
            //ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
            // readFromTxtFile.ReadFile(); 


            //2nd taskassign
            ReadMatch readMatching = new ReadMatch();

            readMatching.Success();
            //readMatch.Failed();
            //readMatch.Dialled();
            //readMatch.Missed();


        }
    }
}
