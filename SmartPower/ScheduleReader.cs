using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPower
{
    class ScheduleReader : IFileReader
    {
        public string getFile()
        {
            return "filename.xml";
        }

        public void ParseFile()
        {
            //do stuff
            //parse the data
            //put into schedule data class
        }
    }
}
