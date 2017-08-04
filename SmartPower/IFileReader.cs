using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPower
{
    interface IFileReader
    {
        string getFile();
        void ParseFile(); 
    }
}
