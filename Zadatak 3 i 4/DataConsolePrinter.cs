using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_i_4
{
    class DataConsolePrinter
    {
        public void PrintData(IDataset dataset)
        {
            try
            {
                IReadOnlyCollection<List<string>> dataToPrint = dataset.GetData();

                if (dataToPrint == null)
                {
                    throw new NullReferenceException(); 
                    

                }

                foreach (var data in dataToPrint)
                {
                    foreach (string item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch(NullReferenceException exception)
            {
                Console.WriteLine("You don't have a permission for this action!");
                
            }
        }
    }
}
