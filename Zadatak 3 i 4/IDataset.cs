using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3_i_4
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
