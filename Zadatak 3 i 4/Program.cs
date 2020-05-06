using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Zadatak_3_i_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////// Zadatak 3
            /*
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("C:/Users/korisnik/source/repos/RPPOON LV5/CSVFile.txt");

            DataConsolePrinter printer = new DataConsolePrinter();
            Console.WriteLine("Virtual proxy test: ");
            printer.PrintData(virtualProxy);

            User professor1 = User.GenerateUser("Professor 1");
            User professor2 = User.GenerateUser("Professor 2");
            User student1 = User.GenerateUser("Student 1");
            User student2 = User.GenerateUser("Student 2");

            ProtectionProxyDataset proxy_professor1 = new ProtectionProxyDataset(professor1);
            ProtectionProxyDataset proxy_professor2 = new ProtectionProxyDataset(professor2);
            ProtectionProxyDataset proxy_student1 = new ProtectionProxyDataset(student1);
            ProtectionProxyDataset proxy_student2 = new ProtectionProxyDataset(student2);

            Console.WriteLine("Professor 1 test:");
            printer.PrintData(proxy_professor1);

            Console.WriteLine("Professor 2 test:");
            printer.PrintData(proxy_professor2);

            Console.WriteLine("Student 1 test:");
            printer.PrintData(proxy_student1);

            Console.WriteLine("Student 2 test:");
            printer.PrintData(proxy_student2);
            */
            /////////////////////////////////////////// Zadatak 4

            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("C:/Users/korisnik/source/repos/RPPOON LV5/CSVFile.txt");

            DataConsolePrinter printer = new DataConsolePrinter();
            
            User professor1 = User.GenerateUser("Professor 1");
            User professor2 = User.GenerateUser("Professor 2");
            User student1 = User.GenerateUser("Student 1");
            User student2 = User.GenerateUser("Student 2");

            LogDatasetProxy proxy_professor1 = new LogDatasetProxy(professor1);
            LogDatasetProxy proxy_professor2 = new LogDatasetProxy(professor2);
           
            
            printer.PrintData(proxy_professor1);
            printer.PrintData(proxy_professor2);
            
        }
    }
}
