﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReaderLibrary;
using EmailLibrary;
namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile2 rf = new ReadFile2();
            SendMail ss = new SendMail();
            int weeks = rf.GetTotalWeeks();
            Console.WriteLine($"Total weeks {weeks}.");
            string res = "";

            for (int i=1;i<=weeks; i++) {
                Console.WriteLine($"LogFile created for week {i}.");
                res = res + rf.Weekwisedata(i);
            }
          

            rf.write_logfile(res);
            ss.MailToManagerwithAttachment();
  
            Console.ReadLine();
        }
    }
}
